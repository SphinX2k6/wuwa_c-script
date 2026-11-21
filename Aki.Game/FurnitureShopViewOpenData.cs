using System;
using System.Runtime.CompilerServices;

// Token: 0x02000440 RID: 1088
[NullableContext(1)]
[Nullable(0)]
public class FurnitureShopViewOpenData : IFurnitureShopViewOpenData
{
	// Token: 0x17000813 RID: 2067
	// (get) Token: 0x060039A6 RID: 14758 RVA: 0x0014C76A File Offset: 0x0014A96A
	// (set) Token: 0x060039A7 RID: 14759 RVA: 0x0014C772 File Offset: 0x0014A972
	public int ShopId { get; set; }

	// Token: 0x17000814 RID: 2068
	// (get) Token: 0x060039A8 RID: 14760 RVA: 0x0014C77B File Offset: 0x0014A97B
	// (set) Token: 0x060039A9 RID: 14761 RVA: 0x0014C783 File Offset: 0x0014A983
	public int NpcEntityId { get; set; }

	// Token: 0x17000815 RID: 2069
	// (get) Token: 0x060039AA RID: 14762 RVA: 0x0014C78C File Offset: 0x0014A98C
	// (set) Token: 0x060039AB RID: 14763 RVA: 0x0014C794 File Offset: 0x0014A994
	public string NpcName { get; set; }

	// Token: 0x17000816 RID: 2070
	// (get) Token: 0x060039AC RID: 14764 RVA: 0x0014C79D File Offset: 0x0014A99D
	// (set) Token: 0x060039AD RID: 14765 RVA: 0x0014C7A5 File Offset: 0x0014A9A5
	public string NpcDesc { get; set; }

	// Token: 0x17000817 RID: 2071
	// (get) Token: 0x060039AE RID: 14766 RVA: 0x0014C7AE File Offset: 0x0014A9AE
	// (set) Token: 0x060039AF RID: 14767 RVA: 0x0014C7B6 File Offset: 0x0014A9B6
	public string NpcStartMontagePath { get; set; }

	// Token: 0x17000818 RID: 2072
	// (get) Token: 0x060039B0 RID: 14768 RVA: 0x0014C7BF File Offset: 0x0014A9BF
	// (set) Token: 0x060039B1 RID: 14769 RVA: 0x0014C7C7 File Offset: 0x0014A9C7
	public int GoodsId { get; set; }

	// Token: 0x17000819 RID: 2073
	// (get) Token: 0x060039B2 RID: 14770 RVA: 0x0014C7D0 File Offset: 0x0014A9D0
	// (set) Token: 0x060039B3 RID: 14771 RVA: 0x0014C7D8 File Offset: 0x0014A9D8
	public bool UseSpareShopNpc { get; set; }
}
