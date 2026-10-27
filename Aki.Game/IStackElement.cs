using System;
using System.Runtime.CompilerServices;

// Token: 0x0200353B RID: 13627
[NullableContext(1)]
public interface IStackElement
{
	// Token: 0x17002976 RID: 10614
	// (get) Token: 0x0601DEFE RID: 122622
	// (set) Token: 0x0601DEFF RID: 122623
	string Node { get; set; }

	// Token: 0x17002977 RID: 10615
	// (get) Token: 0x0601DF00 RID: 122624
	// (set) Token: 0x0601DF01 RID: 122625
	bool Traversing { get; set; }
}
