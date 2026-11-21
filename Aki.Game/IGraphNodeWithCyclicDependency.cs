using System;
using System.Runtime.CompilerServices;

// Token: 0x02002AAF RID: 10927
[NullableContext(1)]
public interface IGraphNodeWithCyclicDependency
{
	// Token: 0x17002D0D RID: 11533
	// (get) Token: 0x0601BC23 RID: 113699 RVA: 0x0088B7B8 File Offset: 0x008899B8
	bool HasCycle
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002D0E RID: 11534
	// (get) Token: 0x0601BC24 RID: 113700
	// (set) Token: 0x0601BC25 RID: 113701
	string[] Cycle { get; set; }
}
