using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rock_paper_scissors
{
    class Program
    {
        static void Main()
        {
            GameMenu();
            while (Console.ReadKey(true).Key != ConsoleKey.E)
            {
                StartGame();
            }
            ExitGame();
        }
        static void GameMenu()
        {
            Console.WriteLine("|#####| Rock Paper Scissors |#####|");
            Console.WriteLine("\nHit Enter to Start New Game");
        }
        static void StartGame()
        {
            Console.Clear();
            GameMenu();
            DateTime timeNow = DateTime.Now;
            Console.WriteLine("\nNew Game Started " + timeNow);
            Console.WriteLine("\n\n\rEnter either Rock, Paper or Scissors\n");
            string userInput = Console.ReadLine();
            Console.WriteLine("\nYou have chosen " + userInput + "\n");
            PerformCountdown();
            string computerInput = ComputerLogic();
            Console.WriteLine("\nComputer has chosen " + computerInput);
            DecideWinner(userInput, computerInput);
        }
        static void DecideWinner(string user, string computer)
        {
            if (user == computer)
            {
                Console.WriteLine("\nDraw! Play Again?");
            }
            string combineChoices = user + computer;
            switch (combineChoices)
            {
                case "RockPaper":
                    Lose();
                    break;
                case "RockScissors":
                    Win();
                    break;
                case "PaperScissors":
                    Lose();
                    break;
                case "PaperRock":
                    Win();
                    break;
                case "ScissorsRock":
                    Lose();
                    break;
                case "ScissorsPaper":
                    Win();
                    break;
            }
        }
        static string ComputerLogic()
        {
            string[] winCondition = { "Rock", "Paper", "Scissors" };
            Random randNum = new Random();
            int randCondition = randNum.Next(0, 3);
            return winCondition[randCondition];
        }
        static void ExitGame()
        {
            int secondCounter = 3;
            while (secondCounter != 0)
            {
                Console.WriteLine("Exiting in " + secondCounter.ToString());
                System.Threading.Thread.Sleep(1000);
                secondCounter--;
            }
        }
        static void PerformCountdown()
        {
            int secondCounter = 3;
            while (secondCounter != 0)
            {
                Console.WriteLine("Starting in " + secondCounter.ToString());
                System.Threading.Thread.Sleep(1000);
                secondCounter--;
            }
        }
        static void Win()
        {
            Console.WriteLine("\nYou Win! Play Again?");
        }
        static void Lose()
        {
            Console.WriteLine("\nYou Lose! Play Again?");
        }
    }
}
