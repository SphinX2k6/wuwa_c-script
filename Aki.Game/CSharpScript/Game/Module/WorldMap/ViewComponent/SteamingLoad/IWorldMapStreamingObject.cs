using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WorldMap.ViewComponent.SteamingLoad
{
	// Token: 0x020036EB RID: 14059
	[NullableContext(1)]
	public interface IWorldMapStreamingObject
	{
		// Token: 0x17004B4B RID: 19275
		// (get) Token: 0x06024989 RID: 149897
		// (set) Token: 0x0602498A RID: 149898
		bool IsStreaming { get; set; }

		// Token: 0x17004B4C RID: 19276
		// (get) Token: 0x0602498B RID: 149899
		// (set) Token: 0x0602498C RID: 149900
		bool IsVisible { get; set; }

		// Token: 0x0602498D RID: 149901
		void OnLoad();

		// Token: 0x0602498E RID: 149902
		void OnUnload();

		// Token: 0x0602498F RID: 149903
		Vector2D GetPreloadThreshold();

		// Token: 0x06024990 RID: 149904
		Vector GetUiPosition();
	}
}
