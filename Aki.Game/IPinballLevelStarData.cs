using System;
using System.Runtime.CompilerServices;

// Token: 0x020008A6 RID: 2214
[NullableContext(2)]
public interface IPinballLevelStarData
{
	// Token: 0x17000C37 RID: 3127
	// (get) Token: 0x060063E0 RID: 25568
	// (set) Token: 0x060063E1 RID: 25569
	int ConditionId { get; set; }

	// Token: 0x17000C38 RID: 3128
	// (get) Token: 0x060063E2 RID: 25570
	// (set) Token: 0x060063E3 RID: 25571
	bool Passed { get; set; }

	// Token: 0x17000C39 RID: 3129
	// (get) Token: 0x060063E4 RID: 25572
	// (set) Token: 0x060063E5 RID: 25573
	string ConfigConditionDesc { get; set; }

	// Token: 0x17000C3A RID: 3130
	// (get) Token: 0x060063E6 RID: 25574
	// (set) Token: 0x060063E7 RID: 25575
	int? ConfigTargetValue { get; set; }
}
