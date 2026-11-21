using System;
using System.Runtime.CompilerServices;

// Token: 0x02002ABB RID: 10939
[NullableContext(1)]
[Nullable(0)]
public class GraphNodeWithCyclicDependency : IGraphNodeWithCyclicDependency
{
	// Token: 0x17002D1F RID: 11551
	// (get) Token: 0x0601BC70 RID: 113776 RVA: 0x0088D108 File Offset: 0x0088B308
	// (set) Token: 0x0601BC71 RID: 113777 RVA: 0x0088D110 File Offset: 0x0088B310
	public bool HasCycle { get; set; }

	// Token: 0x17002D20 RID: 11552
	// (get) Token: 0x0601BC72 RID: 113778 RVA: 0x0088D119 File Offset: 0x0088B319
	// (set) Token: 0x0601BC73 RID: 113779 RVA: 0x0088D121 File Offset: 0x0088B321
	public string[] Cycle { get; set; } = new string[0];
}
