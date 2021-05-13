using Xunit;

namespace CommandAPI.Tests
{
    public class CommandsControllerTests
    {
        [Fact]
        public void GetCommandItems_ReturnsZeroItems_WhenDBIsEmpty()
        {
            //Arrange
            //We need to create an instance of our CommandsController class
            var controller = new CommandsController( /* repository, AutoMapper */);
        }
    }
}