using System;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow
{
	// Token: 0x0200714C RID: 29004
	internal static class PlayerFollowerChairHandlerFactoryInstance
	{
		// Token: 0x17009D50 RID: 40272
		// (get) Token: 0x06046D0D RID: 290061 RVA: 0x011D910D File Offset: 0x011D730D
		public static IPlayerFollowerHandlerFactory<IPlayerFollowerChairHandler> Instance { get; } = new PlayerFollowerChairHandlerFactory();
	}
}
