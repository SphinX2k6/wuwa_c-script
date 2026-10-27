using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WorldMap.ViewComponent.SteamingLoad
{
	// Token: 0x020047BA RID: 18362
	[NullableContext(1)]
	public interface IWorldMapStreamingObject
	{
		// Token: 0x1700788E RID: 30862
		// (get) Token: 0x060301B9 RID: 197049
		// (set) Token: 0x060301BA RID: 197050
		bool IsStreaming { get; set; }

		// Token: 0x1700788F RID: 30863
		// (get) Token: 0x060301BB RID: 197051
		// (set) Token: 0x060301BC RID: 197052
		bool IsVisible { get; set; }

		// Token: 0x060301BD RID: 197053
		void OnLoad();

		// Token: 0x060301BE RID: 197054
		void OnUnload();

		// Token: 0x060301BF RID: 197055
		Vector2D GetPreloadThreshold();

		// Token: 0x060301C0 RID: 197056
		Vector GetUiPosition();
	}
}
