using System;
using System.Runtime.CompilerServices;

// Token: 0x020013F2 RID: 5106
[NullableContext(2)]
public interface IPinballLevelStarData
{
	// Token: 0x17000C17 RID: 3095
	// (get) Token: 0x0600904B RID: 36939
	// (set) Token: 0x0600904C RID: 36940
	int ConditionId { get; set; }

	// Token: 0x17000C18 RID: 3096
	// (get) Token: 0x0600904D RID: 36941
	// (set) Token: 0x0600904E RID: 36942
	bool Passed { get; set; }

	// Token: 0x17000C19 RID: 3097
	// (get) Token: 0x0600904F RID: 36943
	// (set) Token: 0x06009050 RID: 36944
	string ConfigConditionDesc { get; set; }

	// Token: 0x17000C1A RID: 3098
	// (get) Token: 0x06009051 RID: 36945
	// (set) Token: 0x06009052 RID: 36946
	int? ConfigTargetValue { get; set; }
}
