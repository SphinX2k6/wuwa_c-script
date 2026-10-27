using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02006152 RID: 24914
	public interface IRoverlikeGameShopGridData
	{
		// Token: 0x1700919E RID: 37278
		// (get) Token: 0x0603EF97 RID: 257943
		// (set) Token: 0x0603EF98 RID: 257944
		int IncId { get; set; }

		// Token: 0x1700919F RID: 37279
		// (get) Token: 0x0603EF99 RID: 257945
		// (set) Token: 0x0603EF9A RID: 257946
		int ShowItemId { get; set; }

		// Token: 0x170091A0 RID: 37280
		// (get) Token: 0x0603EF9B RID: 257947
		// (set) Token: 0x0603EF9C RID: 257948
		ERoverlikeGameShopItemType Type { get; set; }

		// Token: 0x170091A1 RID: 37281
		// (get) Token: 0x0603EF9D RID: 257949
		// (set) Token: 0x0603EF9E RID: 257950
		int FinalPrice { get; set; }

		// Token: 0x170091A2 RID: 37282
		// (get) Token: 0x0603EF9F RID: 257951
		// (set) Token: 0x0603EFA0 RID: 257952
		int OriginalPrice { get; set; }

		// Token: 0x170091A3 RID: 37283
		// (get) Token: 0x0603EFA1 RID: 257953
		// (set) Token: 0x0603EFA2 RID: 257954
		bool IsBought { get; set; }

		// Token: 0x170091A4 RID: 37284
		// (get) Token: 0x0603EFA3 RID: 257955
		// (set) Token: 0x0603EFA4 RID: 257956
		bool IsSelected { get; set; }
	}
}
