using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

// Token: 0x02003535 RID: 13621
[NullableContext(1)]
[Nullable(0)]
public class GraphNodeImpl : IGraphNode
{
	// Token: 0x17002967 RID: 10599
	// (get) Token: 0x0601DEE0 RID: 122592 RVA: 0x00863AF6 File Offset: 0x00861CF6
	// (set) Token: 0x0601DEE1 RID: 122593 RVA: 0x00863AFE File Offset: 0x00861CFE
	public Func<UniTask> Run { get; set; }

	// Token: 0x17002968 RID: 10600
	// (get) Token: 0x0601DEE2 RID: 122594 RVA: 0x00863B07 File Offset: 0x00861D07
	// (set) Token: 0x0601DEE3 RID: 122595 RVA: 0x00863B0F File Offset: 0x00861D0F
	public int? Priority { get; set; }
}
