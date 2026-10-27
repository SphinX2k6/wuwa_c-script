using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.SceneItem
{
	// Token: 0x02007165 RID: 29029
	[NullableContext(1)]
	public interface IGuidePathVisibilityHost
	{
		// Token: 0x17009D57 RID: 40279
		// (get) Token: 0x06046DCD RID: 290253
		// (set) Token: 0x06046DCE RID: 290254
		Action<ISceneItemGuidePathVisibilityProvider, EGuidePathProviderRemovedBehavior?> SetExternalVisibilityProvider { get; set; }

		// Token: 0x17009D58 RID: 40280
		// (get) Token: 0x06046DCF RID: 290255
		// (set) Token: 0x06046DD0 RID: 290256
		Action<ISceneItemGuidePathVisibilityProvider> ClearExternalVisibilityProvider { get; set; }

		// Token: 0x17009D59 RID: 40281
		// (get) Token: 0x06046DD1 RID: 290257
		// (set) Token: 0x06046DD2 RID: 290258
		Action<ISceneItemGuidePathVisibilityProvider> NotifyExternalVisibilityChanged { get; set; }

		// Token: 0x17009D5A RID: 40282
		// (get) Token: 0x06046DD3 RID: 290259
		// (set) Token: 0x06046DD4 RID: 290260
		Func<bool> HasExternalVisibilityProvider { get; set; }
	}
}
