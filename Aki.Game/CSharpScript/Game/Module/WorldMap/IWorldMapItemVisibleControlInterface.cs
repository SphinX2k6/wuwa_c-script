using System;

namespace CSharpScript.Game.Module.WorldMap
{
	// Token: 0x0200479F RID: 18335
	public interface IWorldMapItemVisibleControlInterface
	{
		// Token: 0x17007800 RID: 30720
		// (get) Token: 0x0602FF26 RID: 196390
		// (set) Token: 0x0602FF27 RID: 196391
		EWorldMapShowMode ShowMode { get; set; }

		// Token: 0x0602FF28 RID: 196392
		void SetWorldMapSelfShow(EWorldMapShowMode showMode);

		// Token: 0x0602FF29 RID: 196393
		void RefreshWorldMapSelfShow(EWorldMapShowMode showMode);
	}
}
