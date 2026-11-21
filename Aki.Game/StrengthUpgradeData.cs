using System;

// Token: 0x02001E06 RID: 7686
public class StrengthUpgradeData : IStrengthUpgradeData
{
	// Token: 0x17001CFF RID: 7423
	// (get) Token: 0x06012FCF RID: 77775 RVA: 0x0058E274 File Offset: 0x0058C474
	// (set) Token: 0x06012FD0 RID: 77776 RVA: 0x0058E27C File Offset: 0x0058C47C
	public EFormationAttributeId AttributeId { get; set; }

	// Token: 0x17001D00 RID: 7424
	// (get) Token: 0x06012FD1 RID: 77777 RVA: 0x0058E285 File Offset: 0x0058C485
	// (set) Token: 0x06012FD2 RID: 77778 RVA: 0x0058E28D File Offset: 0x0058C48D
	public int SingleStrengthValue { get; set; }

	// Token: 0x17001D01 RID: 7425
	// (get) Token: 0x06012FD3 RID: 77779 RVA: 0x0058E296 File Offset: 0x0058C496
	// (set) Token: 0x06012FD4 RID: 77780 RVA: 0x0058E29E File Offset: 0x0058C49E
	public int MaxSingleStrengthItemCount { get; set; }

	// Token: 0x17001D02 RID: 7426
	// (get) Token: 0x06012FD5 RID: 77781 RVA: 0x0058E2A7 File Offset: 0x0058C4A7
	// (set) Token: 0x06012FD6 RID: 77782 RVA: 0x0058E2AF File Offset: 0x0058C4AF
	public int MaxStrength { get; set; }
}
