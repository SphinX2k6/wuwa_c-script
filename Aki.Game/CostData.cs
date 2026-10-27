using System;

// Token: 0x0200201A RID: 8218
public class CostData : ICostData
{
	// Token: 0x170013AC RID: 5036
	// (get) Token: 0x060101B9 RID: 65977 RVA: 0x003EBF6A File Offset: 0x003EA16A
	// (set) Token: 0x060101BA RID: 65978 RVA: 0x003EBF72 File Offset: 0x003EA172
	public int ItemId { get; set; }

	// Token: 0x170013AD RID: 5037
	// (get) Token: 0x060101BB RID: 65979 RVA: 0x003EBF7B File Offset: 0x003EA17B
	// (set) Token: 0x060101BC RID: 65980 RVA: 0x003EBF83 File Offset: 0x003EA183
	public int Count { get; set; }

	// Token: 0x170013AE RID: 5038
	// (get) Token: 0x060101BD RID: 65981 RVA: 0x003EBF8C File Offset: 0x003EA18C
	// (set) Token: 0x060101BE RID: 65982 RVA: 0x003EBF94 File Offset: 0x003EA194
	public int Cost { get; set; }
}
