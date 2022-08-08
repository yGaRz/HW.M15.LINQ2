using System;
using System.Collections.Generic;
using System.Linq;

namespace HW.M15.LINQ2
{
    class Program
    {
        static void Main(string[] args)
        {
            var classes = new[]
            {
               new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
               new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
               new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
           };
            var allStudents = GetAllStudents(classes);

            Console.WriteLine(string.Join(" ", allStudents));
        }

        static string[] GetAllStudents(Classroom[] classes)
        {
            var allStudent = (from c in classes
                              from s in c.Students
                              select s).ToArray();
            return allStudent;
        }

        public class Classroom
        {
            public List<string> Students = new List<string>();
        }
    }
}
