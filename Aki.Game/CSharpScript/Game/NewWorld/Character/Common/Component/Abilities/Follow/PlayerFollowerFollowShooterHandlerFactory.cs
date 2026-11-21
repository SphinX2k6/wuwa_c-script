using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow
{
	// Token: 0x0200637D RID: 25469
	public class PlayerFollowerFollowShooterHandlerFactory : IPlayerFollowerHandlerFactory<IPlayerFollowerFollowShooterHandler>
	{
		// Token: 0x0603DB7F RID: 252799 RVA: 0x011E2624 File Offset: 0x011E0824
		[NullableContext(1)]
		public IPlayerFollowerFollowShooterHandler Create(int playerId)
		{
			return new PlayerFollowerFollowShooterHandler(playerId);
		}
	}
}
