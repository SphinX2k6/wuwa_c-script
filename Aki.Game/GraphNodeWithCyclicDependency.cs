using System;
using System.Runtime.CompilerServices;

// Token: 0x02003546 RID: 13638
[NullableContext(1)]
[Nullable(0)]
public class GraphNodeWithCyclicDependency : IGraphNodeWithCyclicDependency
{
	// Token: 0x17002986 RID: 10630
	// (get) Token: 0x0601DF48 RID: 122696 RVA: 0x008654D0 File Offset: 0x008636D0
	// (set) Token: 0x0601DF49 RID: 122697 RVA: 0x008654D8 File Offset: 0x008636D8
	public bool HasCycle { get; set; }

	// Token: 0x17002987 RID: 10631
	// (get) Token: 0x0601DF4A RID: 122698 RVA: 0x008654E1 File Offset: 0x008636E1
	// (set) Token: 0x0601DF4B RID: 122699 RVA: 0x008654E9 File Offset: 0x008636E9
	public string[] Cycle { get; set; } = new string[0];
}
