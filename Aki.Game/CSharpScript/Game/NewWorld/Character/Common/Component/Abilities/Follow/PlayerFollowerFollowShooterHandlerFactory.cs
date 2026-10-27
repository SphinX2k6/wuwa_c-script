using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow
{
	// Token: 0x0200714F RID: 29007
	public class PlayerFollowerFollowShooterHandlerFactory : IPlayerFollowerHandlerFactory<IPlayerFollowerFollowShooterHandler>
	{
		// Token: 0x06046D25 RID: 290085 RVA: 0x011D9470 File Offset: 0x011D7670
		[NullableContext(1)]
		public IPlayerFollowerFollowShooterHandler Create(int playerId)
		{
			return new PlayerFollowerFollowShooterHandler(playerId);
		}
	}
}
