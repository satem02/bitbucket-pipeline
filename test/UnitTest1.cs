using System;
using Xunit;

namespace test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int temp1 = 1;
            int temp2 = 1;
            Assert.Equal(temp1, temp2);
        }

        [Fact]
        public void Test2()
        {
            int temp1 = 2;
            int temp2 = 2;
            Assert.Equal(temp1, temp2);
        }
    }
}
