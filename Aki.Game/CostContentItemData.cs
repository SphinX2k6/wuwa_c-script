using System;

// Token: 0x0200287B RID: 10363
public class CostContentItemData : ICostContentItemData
{
	// Token: 0x17001C74 RID: 7284
	// (get) Token: 0x06015528 RID: 87336 RVA: 0x005625CC File Offset: 0x005607CC
	// (set) Token: 0x06015529 RID: 87337 RVA: 0x005625D4 File Offset: 0x005607D4
	public int CostNum { get; set; }

	// Token: 0x17001C75 RID: 7285
	// (get) Token: 0x0601552A RID: 87338 RVA: 0x005625DD File Offset: 0x005607DD
	// (set) Token: 0x0601552B RID: 87339 RVA: 0x005625E5 File Offset: 0x005607E5
	public EItemId CostType { get; set; }
}
