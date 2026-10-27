using System;

// Token: 0x0200288B RID: 10379
public class StrengthUpgradeData : IStrengthUpgradeData
{
	// Token: 0x17001CA7 RID: 7335
	// (get) Token: 0x060155D1 RID: 87505 RVA: 0x00563518 File Offset: 0x00561718
	// (set) Token: 0x060155D2 RID: 87506 RVA: 0x00563520 File Offset: 0x00561720
	public EFormationAttributeId AttributeId { get; set; }

	// Token: 0x17001CA8 RID: 7336
	// (get) Token: 0x060155D3 RID: 87507 RVA: 0x00563529 File Offset: 0x00561729
	// (set) Token: 0x060155D4 RID: 87508 RVA: 0x00563531 File Offset: 0x00561731
	public int SingleStrengthValue { get; set; }

	// Token: 0x17001CA9 RID: 7337
	// (get) Token: 0x060155D5 RID: 87509 RVA: 0x0056353A File Offset: 0x0056173A
	// (set) Token: 0x060155D6 RID: 87510 RVA: 0x00563542 File Offset: 0x00561742
	public int MaxSingleStrengthItemCount { get; set; }

	// Token: 0x17001CAA RID: 7338
	// (get) Token: 0x060155D7 RID: 87511 RVA: 0x0056354B File Offset: 0x0056174B
	// (set) Token: 0x060155D8 RID: 87512 RVA: 0x00563553 File Offset: 0x00561753
	public int MaxStrength { get; set; }
}
