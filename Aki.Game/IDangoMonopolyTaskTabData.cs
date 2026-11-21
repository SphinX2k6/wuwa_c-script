using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020006E2 RID: 1762
[NullableContext(1)]
public interface IDangoMonopolyTaskTabData
{
	// Token: 0x17000AB8 RID: 2744
	// (get) Token: 0x06005169 RID: 20841
	EDangoMonopolyTaskType TaskType { get; }

	// Token: 0x17000AB9 RID: 2745
	// (get) Token: 0x0600516A RID: 20842
	string TaskTypeName { get; }

	// Token: 0x17000ABA RID: 2746
	// (get) Token: 0x0600516B RID: 20843
	IReadOnlyList<DangoMonopolyTaskData> TaskList { get; }

	// Token: 0x17000ABB RID: 2747
	// (get) Token: 0x0600516C RID: 20844
	long EndTime { get; }
}
