using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000085 RID: 133
public class TickEntityGroup
{
	// Token: 0x06000403 RID: 1027 RVA: 0x00017F06 File Offset: 0x00016106
	public TickEntityGroup(int priority)
	{
		this.Priority = priority;
	}

	// Token: 0x040003D3 RID: 979
	[Nullable(1)]
	public readonly Dictionary<int, Entity> Entities = new Dictionary<int, Entity>();

	// Token: 0x040003D4 RID: 980
	public readonly int Priority;
}
