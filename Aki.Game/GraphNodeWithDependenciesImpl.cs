using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

// Token: 0x02003538 RID: 13624
[NullableContext(1)]
[Nullable(0)]
public class GraphNodeWithDependenciesImpl : IGraphNodeWithDependencies, IGraphNode
{
	// Token: 0x1700296E RID: 10606
	// (get) Token: 0x0601DEEF RID: 122607 RVA: 0x00863B20 File Offset: 0x00861D20
	// (set) Token: 0x0601DEF0 RID: 122608 RVA: 0x00863B28 File Offset: 0x00861D28
	public Func<UniTask> Run { get; set; }

	// Token: 0x1700296F RID: 10607
	// (get) Token: 0x0601DEF1 RID: 122609 RVA: 0x00863B31 File Offset: 0x00861D31
	// (set) Token: 0x0601DEF2 RID: 122610 RVA: 0x00863B39 File Offset: 0x00861D39
	public int? Priority { get; set; }

	// Token: 0x17002970 RID: 10608
	// (get) Token: 0x0601DEF3 RID: 122611 RVA: 0x00863B42 File Offset: 0x00861D42
	// (set) Token: 0x0601DEF4 RID: 122612 RVA: 0x00863B4A File Offset: 0x00861D4A
	public HashSet<string> DependsOn { get; set; }

	// Token: 0x17002971 RID: 10609
	// (get) Token: 0x0601DEF5 RID: 122613 RVA: 0x00863B53 File Offset: 0x00861D53
	// (set) Token: 0x0601DEF6 RID: 122614 RVA: 0x00863B5B File Offset: 0x00861D5B
	public HashSet<string> DependedOnBy { get; set; }

	// Token: 0x17002972 RID: 10610
	// (get) Token: 0x0601DEF7 RID: 122615 RVA: 0x00863B64 File Offset: 0x00861D64
	// (set) Token: 0x0601DEF8 RID: 122616 RVA: 0x00863B6C File Offset: 0x00861D6C
	public bool Failed { get; set; }
}
