using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.SceneItem
{
	// Token: 0x02006219 RID: 25113
	[NullableContext(1)]
	public interface IGuidePathVisibilityHost
	{
		// Token: 0x17007202 RID: 29186
		// (get) Token: 0x0603C619 RID: 247321
		// (set) Token: 0x0603C61A RID: 247322
		Action<ISceneItemGuidePathVisibilityProvider, EGuidePathProviderRemovedBehavior?> SetExternalVisibilityProvider { get; set; }

		// Token: 0x17007203 RID: 29187
		// (get) Token: 0x0603C61B RID: 247323
		// (set) Token: 0x0603C61C RID: 247324
		Action<ISceneItemGuidePathVisibilityProvider> ClearExternalVisibilityProvider { get; set; }

		// Token: 0x17007204 RID: 29188
		// (get) Token: 0x0603C61D RID: 247325
		// (set) Token: 0x0603C61E RID: 247326
		Action<ISceneItemGuidePathVisibilityProvider> NotifyExternalVisibilityChanged { get; set; }

		// Token: 0x17007205 RID: 29189
		// (get) Token: 0x0603C61F RID: 247327
		// (set) Token: 0x0603C620 RID: 247328
		Func<bool> HasExternalVisibilityProvider { get; set; }
	}
}
