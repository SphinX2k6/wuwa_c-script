using System;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow
{
	// Token: 0x0200637A RID: 25466
	internal static class PlayerFollowerChairHandlerFactoryInstance
	{
		// Token: 0x17007523 RID: 29987
		// (get) Token: 0x0603DB67 RID: 252775 RVA: 0x011E22BF File Offset: 0x011E04BF
		public static IPlayerFollowerHandlerFactory<IPlayerFollowerChairHandler> Instance { get; } = new PlayerFollowerChairHandlerFactory();
	}
}
