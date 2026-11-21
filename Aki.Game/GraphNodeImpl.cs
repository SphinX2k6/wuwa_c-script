using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

// Token: 0x02002AAA RID: 10922
[NullableContext(1)]
[Nullable(0)]
public class GraphNodeImpl : IGraphNode
{
	// Token: 0x17002D00 RID: 11520
	// (get) Token: 0x0601BC08 RID: 113672 RVA: 0x0088B72E File Offset: 0x0088992E
	// (set) Token: 0x0601BC09 RID: 113673 RVA: 0x0088B736 File Offset: 0x00889936
	public Func<UniTask> Run { get; set; }

	// Token: 0x17002D01 RID: 11521
	// (get) Token: 0x0601BC0A RID: 113674 RVA: 0x0088B73F File Offset: 0x0088993F
	// (set) Token: 0x0601BC0B RID: 113675 RVA: 0x0088B747 File Offset: 0x00889947
	public int? Priority { get; set; }
}
