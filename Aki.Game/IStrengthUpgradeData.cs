using System;

// Token: 0x02001E05 RID: 7685
public interface IStrengthUpgradeData
{
	// Token: 0x17001CFB RID: 7419
	// (get) Token: 0x06012FC7 RID: 77767
	// (set) Token: 0x06012FC8 RID: 77768
	EFormationAttributeId AttributeId { get; set; }

	// Token: 0x17001CFC RID: 7420
	// (get) Token: 0x06012FC9 RID: 77769
	// (set) Token: 0x06012FCA RID: 77770
	int SingleStrengthValue { get; set; }

	// Token: 0x17001CFD RID: 7421
	// (get) Token: 0x06012FCB RID: 77771
	// (set) Token: 0x06012FCC RID: 77772
	int MaxSingleStrengthItemCount { get; set; }

	// Token: 0x17001CFE RID: 7422
	// (get) Token: 0x06012FCD RID: 77773
	// (set) Token: 0x06012FCE RID: 77774
	int MaxStrength { get; set; }
}
