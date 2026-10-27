using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002910 RID: 10512
[NullableContext(1)]
public interface IRouletteListSaveData
{
	// Token: 0x17001D20 RID: 7456
	// (get) Token: 0x06015ADE RID: 88798
	// (set) Token: 0x06015ADF RID: 88799
	ERouletteType RouletteType { get; set; }

	// Token: 0x17001D21 RID: 7457
	// (get) Token: 0x06015AE0 RID: 88800
	// (set) Token: 0x06015AE1 RID: 88801
	List<int> RouletteIdList { get; set; }

	// Token: 0x17001D22 RID: 7458
	// (get) Token: 0x06015AE2 RID: 88802
	// (set) Token: 0x06015AE3 RID: 88803
	int ExtraItemId { get; set; }

	// Token: 0x17001D23 RID: 7459
	// (get) Token: 0x06015AE4 RID: 88804
	// (set) Token: 0x06015AE5 RID: 88805
	int EquipExploreSkillId { get; set; }
}
