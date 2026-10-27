using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200122E RID: 4654
[NullableContext(1)]
public interface IDangoMonopolyTaskTabData
{
	// Token: 0x17000A98 RID: 2712
	// (get) Token: 0x06007DD2 RID: 32210
	EDangoMonopolyTaskType TaskType { get; }

	// Token: 0x17000A99 RID: 2713
	// (get) Token: 0x06007DD3 RID: 32211
	string TaskTypeName { get; }

	// Token: 0x17000A9A RID: 2714
	// (get) Token: 0x06007DD4 RID: 32212
	IReadOnlyList<DangoMonopolyTaskData> TaskList { get; }

	// Token: 0x17000A9B RID: 2715
	// (get) Token: 0x06007DD5 RID: 32213
	long EndTime { get; }
}
