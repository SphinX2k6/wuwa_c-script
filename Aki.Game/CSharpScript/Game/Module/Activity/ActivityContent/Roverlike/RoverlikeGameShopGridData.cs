using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02006153 RID: 24915
	public class RoverlikeGameShopGridData : IRoverlikeGameShopGridData
	{
		// Token: 0x170091A5 RID: 37285
		// (get) Token: 0x0603EFA5 RID: 257957 RVA: 0x00F370E5 File Offset: 0x00F352E5
		// (set) Token: 0x0603EFA6 RID: 257958 RVA: 0x00F370ED File Offset: 0x00F352ED
		public int IncId { get; set; }

		// Token: 0x170091A6 RID: 37286
		// (get) Token: 0x0603EFA7 RID: 257959 RVA: 0x00F370F6 File Offset: 0x00F352F6
		// (set) Token: 0x0603EFA8 RID: 257960 RVA: 0x00F370FE File Offset: 0x00F352FE
		public int ShowItemId { get; set; }

		// Token: 0x170091A7 RID: 37287
		// (get) Token: 0x0603EFA9 RID: 257961 RVA: 0x00F37107 File Offset: 0x00F35307
		// (set) Token: 0x0603EFAA RID: 257962 RVA: 0x00F3710F File Offset: 0x00F3530F
		public ERoverlikeGameShopItemType Type { get; set; }

		// Token: 0x170091A8 RID: 37288
		// (get) Token: 0x0603EFAB RID: 257963 RVA: 0x00F37118 File Offset: 0x00F35318
		// (set) Token: 0x0603EFAC RID: 257964 RVA: 0x00F37120 File Offset: 0x00F35320
		public int FinalPrice { get; set; }

		// Token: 0x170091A9 RID: 37289
		// (get) Token: 0x0603EFAD RID: 257965 RVA: 0x00F37129 File Offset: 0x00F35329
		// (set) Token: 0x0603EFAE RID: 257966 RVA: 0x00F37131 File Offset: 0x00F35331
		public int OriginalPrice { get; set; }

		// Token: 0x170091AA RID: 37290
		// (get) Token: 0x0603EFAF RID: 257967 RVA: 0x00F3713A File Offset: 0x00F3533A
		// (set) Token: 0x0603EFB0 RID: 257968 RVA: 0x00F37142 File Offset: 0x00F35342
		public bool IsBought { get; set; }

		// Token: 0x170091AB RID: 37291
		// (get) Token: 0x0603EFB1 RID: 257969 RVA: 0x00F3714B File Offset: 0x00F3534B
		// (set) Token: 0x0603EFB2 RID: 257970 RVA: 0x00F37153 File Offset: 0x00F35353
		public bool IsSelected { get; set; }
	}
}
