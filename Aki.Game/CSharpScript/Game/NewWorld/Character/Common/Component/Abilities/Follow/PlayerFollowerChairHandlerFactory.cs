using System;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow
{
	// Token: 0x0200714B RID: 29003
	internal class PlayerFollowerChairHandlerFactory : IPlayerFollowerHandlerFactory<IPlayerFollowerChairHandler>
	{
		// Token: 0x06046D0B RID: 290059 RVA: 0x011D90FD File Offset: 0x011D72FD
		public IPlayerFollowerChairHandler Create(int playerId)
		{
			return PlayerFollowerChairHandler.Create(playerId);
		}
	}
}
