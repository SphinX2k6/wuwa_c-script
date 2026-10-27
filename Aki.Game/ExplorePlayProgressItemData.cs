using System;
using System.Runtime.CompilerServices;

// Token: 0x02001AA7 RID: 6823
[NullableContext(2)]
[Nullable(0)]
public class ExplorePlayProgressItemData : IExplorePlayProgressItemData
{
	// Token: 0x1700109C RID: 4252
	// (get) Token: 0x0600CA0A RID: 51722 RVA: 0x002E17F6 File Offset: 0x002DF9F6
	// (set) Token: 0x0600CA0B RID: 51723 RVA: 0x002E17FE File Offset: 0x002DF9FE
	public EExploreType ExploreType { get; set; }

	// Token: 0x1700109D RID: 4253
	// (get) Token: 0x0600CA0C RID: 51724 RVA: 0x002E1807 File Offset: 0x002DFA07
	// (set) Token: 0x0600CA0D RID: 51725 RVA: 0x002E180F File Offset: 0x002DFA0F
	public EPlayPointType PlayPointType { get; set; }

	// Token: 0x1700109E RID: 4254
	// (get) Token: 0x0600CA0E RID: 51726 RVA: 0x002E1818 File Offset: 0x002DFA18
	// (set) Token: 0x0600CA0F RID: 51727 RVA: 0x002E1820 File Offset: 0x002DFA20
	public EPlayPointState PlayPointState { get; set; }

	// Token: 0x1700109F RID: 4255
	// (get) Token: 0x0600CA10 RID: 51728 RVA: 0x002E1829 File Offset: 0x002DFA29
	// (set) Token: 0x0600CA11 RID: 51729 RVA: 0x002E1831 File Offset: 0x002DFA31
	public int? PlayPointId { get; set; }

	// Token: 0x170010A0 RID: 4256
	// (get) Token: 0x0600CA12 RID: 51730 RVA: 0x002E183A File Offset: 0x002DFA3A
	// (set) Token: 0x0600CA13 RID: 51731 RVA: 0x002E1842 File Offset: 0x002DFA42
	public EPlayPointState? LastPlayPointState { get; set; }

	// Token: 0x170010A1 RID: 4257
	// (get) Token: 0x0600CA14 RID: 51732 RVA: 0x002E184B File Offset: 0x002DFA4B
	// (set) Token: 0x0600CA15 RID: 51733 RVA: 0x002E1853 File Offset: 0x002DFA53
	public int? EntityId { get; set; }

	// Token: 0x170010A2 RID: 4258
	// (get) Token: 0x0600CA16 RID: 51734 RVA: 0x002E185C File Offset: 0x002DFA5C
	// (set) Token: 0x0600CA17 RID: 51735 RVA: 0x002E1864 File Offset: 0x002DFA64
	public bool? IgnoreHiddenType { get; set; }

	// Token: 0x170010A3 RID: 4259
	// (get) Token: 0x0600CA18 RID: 51736 RVA: 0x002E186D File Offset: 0x002DFA6D
	// (set) Token: 0x0600CA19 RID: 51737 RVA: 0x002E1875 File Offset: 0x002DFA75
	public bool? IsClear { get; set; }

	// Token: 0x170010A4 RID: 4260
	// (get) Token: 0x0600CA1A RID: 51738 RVA: 0x002E187E File Offset: 0x002DFA7E
	// (set) Token: 0x0600CA1B RID: 51739 RVA: 0x002E1886 File Offset: 0x002DFA86
	public string ClearInfo { get; set; }

	// Token: 0x170010A5 RID: 4261
	// (get) Token: 0x0600CA1C RID: 51740 RVA: 0x002E188F File Offset: 0x002DFA8F
	// (set) Token: 0x0600CA1D RID: 51741 RVA: 0x002E1897 File Offset: 0x002DFA97
	public bool? IsUnlock { get; set; }
}
