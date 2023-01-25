﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Project_Refactoring
{
    class Player
    {
        public int X;
        public int Y;
        public int pastX;
        public int pastY;

        // 이동 함수
        public static void MoveToLeftOfTarget(out int x, int targetX) =>
            x = targetX + 1;
        public static void MoveToRightOfTarget(out int x, int targetX) =>
            x = targetX - 1;
        public static void MoveToUpOfTarget(out int y, int targetY) =>
            y = targetY + 1;
        public static void MoveToDownOfTarget(out int y, int targetY) =>
            y = targetY - 1;

        // 플레이어 이동 모듈화
        public static void MovePlayer(ConsoleKey key, ref int playerX, ref int playerY, int targetX, int targetY)
        {
            if (key == ConsoleKey.LeftArrow)
                MoveToRightOfTarget(out playerX, targetX);
            if (key == ConsoleKey.RightArrow)
                MoveToLeftOfTarget(out playerX, targetX);
            if (key == ConsoleKey.UpArrow)
                MoveToDownOfTarget(out playerY, targetY);
            if (key == ConsoleKey.DownArrow)
                MoveToUpOfTarget(out playerY, targetY);
        }
    }
}
