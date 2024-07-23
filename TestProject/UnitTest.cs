using CoveredClassLibrary;

namespace TestProject
{
    public class Tests
    {
        private CoveredClass _coveredClass;

        [SetUp]
        public void Setup()
        {
            _coveredClass = new();
        }

        [Test]
        public void CoveredClass_ReturnCorrectResult()
        {
            const int x = 2;
            const int y = 3;

            var result = _coveredClass.Sum(x, y);

            Assert.That(x + y, Is.EqualTo(result));
        }
    }
}