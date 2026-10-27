using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02002B89 RID: 11145
[NullableContext(1)]
public interface ISurvivorsLevelInfo
{
	// Token: 0x17001ED9 RID: 7897
	// (get) Token: 0x06017189 RID: 94601
	int LevelId { get; }

	// Token: 0x17001EDA RID: 7898
	// (get) Token: 0x0601718A RID: 94602
	long OpenTime { get; }

	// Token: 0x17001EDB RID: 7899
	// (get) Token: 0x0601718B RID: 94603
	bool IsEndlessMode { get; }

	// Token: 0x17001EDC RID: 7900
	// (get) Token: 0x0601718C RID: 94604
	ModeInfo Info { get; }
}
