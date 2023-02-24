using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SF.Unit4.Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string name, string lastName, int age, string login, int loginLenght, bool hasPet, string[] favColor) User;

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Введиет ваше имя: ");
                User.name = Console.ReadLine();

                Console.Write("\nВведите вашу фамилию: ");
                User.lastName = Console.ReadLine();

                Console.Write("\nВведите ваш возраст: ");
                User.age = int.Parse(Console.ReadLine());

                Console.Write("\nВведите ваш логин: ");
                User.login = Console.ReadLine();
                User.loginLenght = User.login.Length;

                Console.Write("\nУ вас есть домашние животные? 'да' / 'нет': ");
                string pet = Console.ReadLine();

                if (pet == "да")
                {
                    User.hasPet = true;
                }
                else
                {
                    User.hasPet = false;
                }

                User.favColor = new string[3];
                Console.WriteLine("\nНапишите три любимых цвета: ");

                for (int j = 0; j < 3; j++)
                {                    
                    Console.WriteLine(User.favColor + ", ");
                    User.favColor[j] = Console.ReadLine();
                }

            }
        }
    }
}
