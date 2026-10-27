using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02003537 RID: 13623
[NullableContext(1)]
public interface IGraphNodeWithDependencies : IGraphNode
{
	// Token: 0x1700296B RID: 10603
	// (get) Token: 0x0601DEE9 RID: 122601
	// (set) Token: 0x0601DEEA RID: 122602
	HashSet<string> DependsOn { get; set; }

	// Token: 0x1700296C RID: 10604
	// (get) Token: 0x0601DEEB RID: 122603
	// (set) Token: 0x0601DEEC RID: 122604
	HashSet<string> DependedOnBy { get; set; }

	// Token: 0x1700296D RID: 10605
	// (get) Token: 0x0601DEED RID: 122605
	// (set) Token: 0x0601DEEE RID: 122606
	bool Failed { get; set; }
}
