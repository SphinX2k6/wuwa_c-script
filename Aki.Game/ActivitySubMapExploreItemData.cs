using System;
using System.Runtime.CompilerServices;

// Token: 0x0200077B RID: 1915
[NullableContext(1)]
[Nullable(0)]
public class ActivitySubMapExploreItemData : IActivitySubMapExploreItemData
{
	// Token: 0x17000B5F RID: 2911
	// (get) Token: 0x060057B7 RID: 22455 RVA: 0x001CAC66 File Offset: 0x001C8E66
	// (set) Token: 0x060057B8 RID: 22456 RVA: 0x001CAC6E File Offset: 0x001C8E6E
	public int TaskId { get; set; }

	// Token: 0x17000B60 RID: 2912
	// (get) Token: 0x060057B9 RID: 22457 RVA: 0x001CAC77 File Offset: 0x001C8E77
	// (set) Token: 0x060057BA RID: 22458 RVA: 0x001CAC7F File Offset: 0x001C8E7F
	public string RewardDesc { get; set; }

	// Token: 0x17000B61 RID: 2913
	// (get) Token: 0x060057BB RID: 22459 RVA: 0x001CAC88 File Offset: 0x001C8E88
	// (set) Token: 0x060057BC RID: 22460 RVA: 0x001CAC90 File Offset: 0x001C8E90
	public int RewardItemId { get; set; }

	// Token: 0x17000B62 RID: 2914
	// (get) Token: 0x060057BD RID: 22461 RVA: 0x001CAC99 File Offset: 0x001C8E99
	// (set) Token: 0x060057BE RID: 22462 RVA: 0x001CACA1 File Offset: 0x001C8EA1
	public int? RewardItemCount { get; set; }

	// Token: 0x17000B63 RID: 2915
	// (get) Token: 0x060057BF RID: 22463 RVA: 0x001CACAA File Offset: 0x001C8EAA
	// (set) Token: 0x060057C0 RID: 22464 RVA: 0x001CACB2 File Offset: 0x001C8EB2
	public bool IsComplete { get; set; }

	// Token: 0x17000B64 RID: 2916
	// (get) Token: 0x060057C1 RID: 22465 RVA: 0x001CACBB File Offset: 0x001C8EBB
	// (set) Token: 0x060057C2 RID: 22466 RVA: 0x001CACC3 File Offset: 0x001C8EC3
	public bool IsCanGet { get; set; }

	// Token: 0x17000B65 RID: 2917
	// (get) Token: 0x060057C3 RID: 22467 RVA: 0x001CACCC File Offset: 0x001C8ECC
	// (set) Token: 0x060057C4 RID: 22468 RVA: 0x001CACD4 File Offset: 0x001C8ED4
	public bool IsRunning { get; set; }
}
