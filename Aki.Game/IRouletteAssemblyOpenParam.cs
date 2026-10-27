using System;

// Token: 0x0200290C RID: 10508
public interface IRouletteAssemblyOpenParam
{
	// Token: 0x17001D10 RID: 7440
	// (get) Token: 0x06015ABC RID: 88764
	// (set) Token: 0x06015ABD RID: 88765
	ERouletteType? RouletteType { get; set; }

	// Token: 0x17001D11 RID: 7441
	// (get) Token: 0x06015ABE RID: 88766
	// (set) Token: 0x06015ABF RID: 88767
	int? SelectGridId { get; set; }

	// Token: 0x17001D12 RID: 7442
	// (get) Token: 0x06015AC0 RID: 88768
	// (set) Token: 0x06015AC1 RID: 88769
	int? SelectGridIndex { get; set; }

	// Token: 0x17001D13 RID: 7443
	// (get) Token: 0x06015AC2 RID: 88770
	// (set) Token: 0x06015AC3 RID: 88771
	ERouletteExploreId? EndSwitchSkillId { get; set; }

	// Token: 0x17001D14 RID: 7444
	// (get) Token: 0x06015AC4 RID: 88772
	// (set) Token: 0x06015AC5 RID: 88773
	bool? LocateEquippableSpecialItem { get; set; }
}
