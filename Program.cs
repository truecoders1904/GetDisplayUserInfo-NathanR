using System;
using System.Collections.Generic;

namespace GetOrDisplayUserInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many people are there?");
            string userCountResponse = Console.ReadLine();
            int userCount = int.Parse(userCountResponse);

            List<User> users = new List<User>();
            for (int i = 0; i < userCount; i++)
            {
                User user = new User();

                user.Name = user.AnswerQuestion("What is your first & last name?");
                user.FavoriteNumber = user.AnswerQuestionWithInteger("What is your favorite number?");

                users.Add(user);
            }

            foreach (User user in users)
            {
                if (user.FavoriteNumber < 5)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Hello {user.Name}, your favorite number is {user.FavoriteNumber}!");
                }
                else if (user.FavoriteNumber > 10)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Hello {user.Name}, your favorite number is {user.FavoriteNumber}!");
                }
                else
                {
                    Console.WriteLine($"Hello {user.Name}, your favorite number is {user.FavoriteNumber}!");
                }
            }
        }
    }
}
