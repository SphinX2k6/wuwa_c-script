using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02004B31 RID: 19249
	[NullableContext(1)]
	public interface ITowerDefensePhantomIconItemData
	{
		// Token: 0x17007B6F RID: 31599
		// (get) Token: 0x06031D9A RID: 204186
		// (set) Token: 0x06031D9B RID: 204187
		int ConfigId { get; set; }

		// Token: 0x17007B70 RID: 31600
		// (get) Token: 0x06031D9C RID: 204188
		// (set) Token: 0x06031D9D RID: 204189
		string HexColorPath { get; set; }

		// Token: 0x17007B71 RID: 31601
		// (get) Token: 0x06031D9E RID: 204190
		// (set) Token: 0x06031D9F RID: 204191
		bool IsLocked { get; set; }

		// Token: 0x17007B72 RID: 31602
		// (get) Token: 0x06031DA0 RID: 204192
		// (set) Token: 0x06031DA1 RID: 204193
		bool IsChosen { get; set; }

		// Token: 0x17007B73 RID: 31603
		// (get) Token: 0x06031DA2 RID: 204194
		// (set) Token: 0x06031DA3 RID: 204195
		bool IsOccupied { get; set; }
	}
}
