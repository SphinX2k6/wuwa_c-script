using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002AAC RID: 10924
[NullableContext(1)]
public interface IGraphNodeWithDependencies : IGraphNode
{
	// Token: 0x17002D04 RID: 11524
	// (get) Token: 0x0601BC11 RID: 113681
	// (set) Token: 0x0601BC12 RID: 113682
	HashSet<string> DependsOn { get; set; }

	// Token: 0x17002D05 RID: 11525
	// (get) Token: 0x0601BC13 RID: 113683
	// (set) Token: 0x0601BC14 RID: 113684
	HashSet<string> DependedOnBy { get; set; }

	// Token: 0x17002D06 RID: 11526
	// (get) Token: 0x0601BC15 RID: 113685
	// (set) Token: 0x0601BC16 RID: 113686
	bool Failed { get; set; }
}
