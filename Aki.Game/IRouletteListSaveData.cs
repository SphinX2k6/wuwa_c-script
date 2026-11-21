using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001E8B RID: 7819
[NullableContext(1)]
public interface IRouletteListSaveData
{
	// Token: 0x17001D7A RID: 7546
	// (get) Token: 0x060134E2 RID: 79074
	// (set) Token: 0x060134E3 RID: 79075
	ERouletteType RouletteType { get; set; }

	// Token: 0x17001D7B RID: 7547
	// (get) Token: 0x060134E4 RID: 79076
	// (set) Token: 0x060134E5 RID: 79077
	List<int> RouletteIdList { get; set; }

	// Token: 0x17001D7C RID: 7548
	// (get) Token: 0x060134E6 RID: 79078
	// (set) Token: 0x060134E7 RID: 79079
	int ExtraItemId { get; set; }

	// Token: 0x17001D7D RID: 7549
	// (get) Token: 0x060134E8 RID: 79080
	// (set) Token: 0x060134E9 RID: 79081
	int EquipExploreSkillId { get; set; }
}
