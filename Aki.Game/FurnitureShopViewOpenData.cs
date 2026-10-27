using System;
using System.Runtime.CompilerServices;

// Token: 0x02000F8B RID: 3979
[NullableContext(1)]
[Nullable(0)]
public class FurnitureShopViewOpenData : IFurnitureShopViewOpenData
{
	// Token: 0x170007F1 RID: 2033
	// (get) Token: 0x0600660E RID: 26126 RVA: 0x00143ED6 File Offset: 0x001420D6
	// (set) Token: 0x0600660F RID: 26127 RVA: 0x00143EDE File Offset: 0x001420DE
	public int ShopId { get; set; }

	// Token: 0x170007F2 RID: 2034
	// (get) Token: 0x06006610 RID: 26128 RVA: 0x00143EE7 File Offset: 0x001420E7
	// (set) Token: 0x06006611 RID: 26129 RVA: 0x00143EEF File Offset: 0x001420EF
	public int NpcEntityId { get; set; }

	// Token: 0x170007F3 RID: 2035
	// (get) Token: 0x06006612 RID: 26130 RVA: 0x00143EF8 File Offset: 0x001420F8
	// (set) Token: 0x06006613 RID: 26131 RVA: 0x00143F00 File Offset: 0x00142100
	public string NpcName { get; set; }

	// Token: 0x170007F4 RID: 2036
	// (get) Token: 0x06006614 RID: 26132 RVA: 0x00143F09 File Offset: 0x00142109
	// (set) Token: 0x06006615 RID: 26133 RVA: 0x00143F11 File Offset: 0x00142111
	public string NpcDesc { get; set; }

	// Token: 0x170007F5 RID: 2037
	// (get) Token: 0x06006616 RID: 26134 RVA: 0x00143F1A File Offset: 0x0014211A
	// (set) Token: 0x06006617 RID: 26135 RVA: 0x00143F22 File Offset: 0x00142122
	public string NpcStartMontagePath { get; set; }

	// Token: 0x170007F6 RID: 2038
	// (get) Token: 0x06006618 RID: 26136 RVA: 0x00143F2B File Offset: 0x0014212B
	// (set) Token: 0x06006619 RID: 26137 RVA: 0x00143F33 File Offset: 0x00142133
	public int GoodsId { get; set; }

	// Token: 0x170007F7 RID: 2039
	// (get) Token: 0x0600661A RID: 26138 RVA: 0x00143F3C File Offset: 0x0014213C
	// (set) Token: 0x0600661B RID: 26139 RVA: 0x00143F44 File Offset: 0x00142144
	public bool UseSpareShopNpc { get; set; }
}
