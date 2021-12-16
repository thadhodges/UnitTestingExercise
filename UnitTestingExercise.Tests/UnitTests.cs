using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(10, 10, 10, 30)]
        [InlineData(20, 20, 20, 60)]
        [InlineData(30, 30, 30, 90)]
        [InlineData(1, 2, 3, 6)]
        [InlineData(0, 0, 0, 0)]
        [InlineData(0, 0, -4, -4)]
        [InlineData(0, 0, 4, 4)]
        [InlineData(123, 0, 0, 123)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var challenger = new UnitTestMethods();

            //Act

            int actual = challenger.Add(num1, num2, num3);

            //Assert

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 5, 5)]
        [InlineData(20, 5, 15)]
        [InlineData(30, 5, 25)]
        [InlineData(10, 20, -10)]
        [InlineData(20, 20, 0)]

        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            var challenger = new UnitTestMethods();
            //Act
            int actual = challenger.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(actual, expected);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(1, 3, 3)]
        [InlineData(1, 4, 4)]
        [InlineData(5, 5, 25)]
        [InlineData(3, -3, -9)]

        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var challenger = new UnitTestMethods();

            //Act
            int actual = challenger.Multiply(num1, num2);
            //Assert
            Assert.Equal(actual, expected);
        }

        [Theory]
        [InlineData(10, 5, 2)]
        [InlineData(100, 10, 10)]
        [InlineData(7, 3, 2)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            var challenger = new UnitTestMethods();
            //Act
            int actual = challenger.Divide(num1, num2);
            //Assert
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void Hello()
        {
            //Arrange

            //Act
            string x = "Hello";
            //Assert
            Assert.Equal("Hello", x);
        }

        [Fact]
        public void GoodBye()
        {
            //Arrange

            //Act
            string x = "GoodBye";
            //Assert
            Assert.Equal("GoodBye", x);
        }
    }
}
