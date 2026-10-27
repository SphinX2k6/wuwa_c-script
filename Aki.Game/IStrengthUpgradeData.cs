using System;

// Token: 0x0200288A RID: 10378
public interface IStrengthUpgradeData
{
	// Token: 0x17001CA3 RID: 7331
	// (get) Token: 0x060155C9 RID: 87497
	// (set) Token: 0x060155CA RID: 87498
	EFormationAttributeId AttributeId { get; set; }

	// Token: 0x17001CA4 RID: 7332
	// (get) Token: 0x060155CB RID: 87499
	// (set) Token: 0x060155CC RID: 87500
	int SingleStrengthValue { get; set; }

	// Token: 0x17001CA5 RID: 7333
	// (get) Token: 0x060155CD RID: 87501
	// (set) Token: 0x060155CE RID: 87502
	int MaxSingleStrengthItemCount { get; set; }

	// Token: 0x17001CA6 RID: 7334
	// (get) Token: 0x060155CF RID: 87503
	// (set) Token: 0x060155D0 RID: 87504
	int MaxStrength { get; set; }
}
