using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020050D1 RID: 20689
	public class RoverlikeGameShopGridData : IRoverlikeGameShopGridData
	{
		// Token: 0x17006507 RID: 25863
		// (get) Token: 0x06033C65 RID: 212069 RVA: 0x00E7DFB9 File Offset: 0x00E7C1B9
		// (set) Token: 0x06033C66 RID: 212070 RVA: 0x00E7DFC1 File Offset: 0x00E7C1C1
		public int IncId { get; set; }

		// Token: 0x17006508 RID: 25864
		// (get) Token: 0x06033C67 RID: 212071 RVA: 0x00E7DFCA File Offset: 0x00E7C1CA
		// (set) Token: 0x06033C68 RID: 212072 RVA: 0x00E7DFD2 File Offset: 0x00E7C1D2
		public int ShowItemId { get; set; }

		// Token: 0x17006509 RID: 25865
		// (get) Token: 0x06033C69 RID: 212073 RVA: 0x00E7DFDB File Offset: 0x00E7C1DB
		// (set) Token: 0x06033C6A RID: 212074 RVA: 0x00E7DFE3 File Offset: 0x00E7C1E3
		public ERoverlikeGameShopItemType Type { get; set; }

		// Token: 0x1700650A RID: 25866
		// (get) Token: 0x06033C6B RID: 212075 RVA: 0x00E7DFEC File Offset: 0x00E7C1EC
		// (set) Token: 0x06033C6C RID: 212076 RVA: 0x00E7DFF4 File Offset: 0x00E7C1F4
		public int FinalPrice { get; set; }

		// Token: 0x1700650B RID: 25867
		// (get) Token: 0x06033C6D RID: 212077 RVA: 0x00E7DFFD File Offset: 0x00E7C1FD
		// (set) Token: 0x06033C6E RID: 212078 RVA: 0x00E7E005 File Offset: 0x00E7C205
		public int OriginalPrice { get; set; }

		// Token: 0x1700650C RID: 25868
		// (get) Token: 0x06033C6F RID: 212079 RVA: 0x00E7E00E File Offset: 0x00E7C20E
		// (set) Token: 0x06033C70 RID: 212080 RVA: 0x00E7E016 File Offset: 0x00E7C216
		public bool IsBought { get; set; }

		// Token: 0x1700650D RID: 25869
		// (get) Token: 0x06033C71 RID: 212081 RVA: 0x00E7E01F File Offset: 0x00E7C21F
		// (set) Token: 0x06033C72 RID: 212082 RVA: 0x00E7E027 File Offset: 0x00E7C227
		public bool IsSelected { get; set; }
	}
}
