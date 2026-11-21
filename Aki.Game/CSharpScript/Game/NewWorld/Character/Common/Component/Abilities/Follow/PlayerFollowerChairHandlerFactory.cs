using System;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow
{
	// Token: 0x02006379 RID: 25465
	internal class PlayerFollowerChairHandlerFactory : IPlayerFollowerHandlerFactory<IPlayerFollowerChairHandler>
	{
		// Token: 0x0603DB65 RID: 252773 RVA: 0x011E22AF File Offset: 0x011E04AF
		public IPlayerFollowerChairHandler Create(int playerId)
		{
			return PlayerFollowerChairHandler.Create(playerId);
		}
	}
}
