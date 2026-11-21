using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

// Token: 0x02002AAD RID: 10925
[NullableContext(1)]
[Nullable(0)]
public class GraphNodeWithDependenciesImpl : IGraphNodeWithDependencies, IGraphNode
{
	// Token: 0x17002D07 RID: 11527
	// (get) Token: 0x0601BC17 RID: 113687 RVA: 0x0088B758 File Offset: 0x00889958
	// (set) Token: 0x0601BC18 RID: 113688 RVA: 0x0088B760 File Offset: 0x00889960
	public Func<UniTask> Run { get; set; }

	// Token: 0x17002D08 RID: 11528
	// (get) Token: 0x0601BC19 RID: 113689 RVA: 0x0088B769 File Offset: 0x00889969
	// (set) Token: 0x0601BC1A RID: 113690 RVA: 0x0088B771 File Offset: 0x00889971
	public int? Priority { get; set; }

	// Token: 0x17002D09 RID: 11529
	// (get) Token: 0x0601BC1B RID: 113691 RVA: 0x0088B77A File Offset: 0x0088997A
	// (set) Token: 0x0601BC1C RID: 113692 RVA: 0x0088B782 File Offset: 0x00889982
	public HashSet<string> DependsOn { get; set; }

	// Token: 0x17002D0A RID: 11530
	// (get) Token: 0x0601BC1D RID: 113693 RVA: 0x0088B78B File Offset: 0x0088998B
	// (set) Token: 0x0601BC1E RID: 113694 RVA: 0x0088B793 File Offset: 0x00889993
	public HashSet<string> DependedOnBy { get; set; }

	// Token: 0x17002D0B RID: 11531
	// (get) Token: 0x0601BC1F RID: 113695 RVA: 0x0088B79C File Offset: 0x0088999C
	// (set) Token: 0x0601BC20 RID: 113696 RVA: 0x0088B7A4 File Offset: 0x008899A4
	public bool Failed { get; set; }
}
