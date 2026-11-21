using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020050D0 RID: 20688
	public interface IRoverlikeGameShopGridData
	{
		// Token: 0x17006500 RID: 25856
		// (get) Token: 0x06033C57 RID: 212055
		// (set) Token: 0x06033C58 RID: 212056
		int IncId { get; set; }

		// Token: 0x17006501 RID: 25857
		// (get) Token: 0x06033C59 RID: 212057
		// (set) Token: 0x06033C5A RID: 212058
		int ShowItemId { get; set; }

		// Token: 0x17006502 RID: 25858
		// (get) Token: 0x06033C5B RID: 212059
		// (set) Token: 0x06033C5C RID: 212060
		ERoverlikeGameShopItemType Type { get; set; }

		// Token: 0x17006503 RID: 25859
		// (get) Token: 0x06033C5D RID: 212061
		// (set) Token: 0x06033C5E RID: 212062
		int FinalPrice { get; set; }

		// Token: 0x17006504 RID: 25860
		// (get) Token: 0x06033C5F RID: 212063
		// (set) Token: 0x06033C60 RID: 212064
		int OriginalPrice { get; set; }

		// Token: 0x17006505 RID: 25861
		// (get) Token: 0x06033C61 RID: 212065
		// (set) Token: 0x06033C62 RID: 212066
		bool IsBought { get; set; }

		// Token: 0x17006506 RID: 25862
		// (get) Token: 0x06033C63 RID: 212067
		// (set) Token: 0x06033C64 RID: 212068
		bool IsSelected { get; set; }
	}
}
