using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    public class Green_2
    {
        public struct Student
        {
            //поля
            private string _name;
            private string _surname;
            private int[] _marks;

            //свойства
            public string Name  => _name;
            public string Surname  => _surname;
            public int[] Marks  => _marks;
            public double AvgMark
            {
                get
                {
                    if (_marks == null || _marks.Length == 0) return 0;
                    return _marks.Average();
                }
            }
            public bool IsExcellent
            {
                get
                {
                    if (_marks == null) return false;
                    foreach (int mark in _marks)
                    {
                        if (mark < 4)
                            return false;
                    }
                    return true;
                }
            }

            //конструкторы
            public Student(string name, string surname)
            {
                _name = name;
                _surname = surname;
                _marks = new int[4];
            }

            //остальные методы
            public void Exam(int mark)
            {
                if (_marks == null) return;
                if (mark < 2 || mark > 5) return;
                for (int i = 0; i < _marks.Length; i++)
                {
                    if (_marks[i] == 0)
                    {
                        _marks[i] = mark;
                        break;
                    }
                }
            }

            public static void SortByAvgMark(Student [] array)
            {
                if (array == null) return;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    for (int j = 0; j < array.Length - 1 - i; j++)
                    {
                        if (array[j].AvgMark < array[j+1].AvgMark)
                        {
                            (array[j],array[j+1])=(array[j+1],array[j]);
                        }
                    }
                }
            }

            public void Print()
            {
                Console.WriteLine($"{Name} {Surname} {AvgMark} {IsExcellent}");
            }
            
        }
    }
}
