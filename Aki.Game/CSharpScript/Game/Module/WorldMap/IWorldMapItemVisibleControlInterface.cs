using System;

namespace CSharpScript.Game.Module.WorldMap
{
	// Token: 0x020036D0 RID: 14032
	public interface IWorldMapItemVisibleControlInterface
	{
		// Token: 0x17004ABC RID: 19132
		// (get) Token: 0x060246F1 RID: 149233
		// (set) Token: 0x060246F2 RID: 149234
		EWorldMapShowMode ShowMode { get; set; }

		// Token: 0x060246F3 RID: 149235
		void SetWorldMapSelfShow(EWorldMapShowMode showMode);

		// Token: 0x060246F4 RID: 149236
		void RefreshWorldMapSelfShow(EWorldMapShowMode showMode);
	}
}
