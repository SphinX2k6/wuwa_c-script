using System;

// Token: 0x02001E87 RID: 7815
public interface IRouletteAssemblyOpenParam
{
	// Token: 0x17001D6A RID: 7530
	// (get) Token: 0x060134C0 RID: 79040
	// (set) Token: 0x060134C1 RID: 79041
	ERouletteType? RouletteType { get; set; }

	// Token: 0x17001D6B RID: 7531
	// (get) Token: 0x060134C2 RID: 79042
	// (set) Token: 0x060134C3 RID: 79043
	int? SelectGridId { get; set; }

	// Token: 0x17001D6C RID: 7532
	// (get) Token: 0x060134C4 RID: 79044
	// (set) Token: 0x060134C5 RID: 79045
	int? SelectGridIndex { get; set; }

	// Token: 0x17001D6D RID: 7533
	// (get) Token: 0x060134C6 RID: 79046
	// (set) Token: 0x060134C7 RID: 79047
	ERouletteExploreId? EndSwitchSkillId { get; set; }

	// Token: 0x17001D6E RID: 7534
	// (get) Token: 0x060134C8 RID: 79048
	// (set) Token: 0x060134C9 RID: 79049
	bool? LocateEquippableSpecialItem { get; set; }
}
