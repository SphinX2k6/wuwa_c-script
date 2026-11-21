using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02003AD9 RID: 15065
	[NullableContext(1)]
	public interface ITowerDefensePhantomIconItemData
	{
		// Token: 0x17004F1C RID: 20252
		// (get) Token: 0x06026B2A RID: 158506
		// (set) Token: 0x06026B2B RID: 158507
		int ConfigId { get; set; }

		// Token: 0x17004F1D RID: 20253
		// (get) Token: 0x06026B2C RID: 158508
		// (set) Token: 0x06026B2D RID: 158509
		string HexColorPath { get; set; }

		// Token: 0x17004F1E RID: 20254
		// (get) Token: 0x06026B2E RID: 158510
		// (set) Token: 0x06026B2F RID: 158511
		bool IsLocked { get; set; }

		// Token: 0x17004F1F RID: 20255
		// (get) Token: 0x06026B30 RID: 158512
		// (set) Token: 0x06026B31 RID: 158513
		bool IsChosen { get; set; }

		// Token: 0x17004F20 RID: 20256
		// (get) Token: 0x06026B32 RID: 158514
		// (set) Token: 0x06026B33 RID: 158515
		bool IsOccupied { get; set; }
	}
}
