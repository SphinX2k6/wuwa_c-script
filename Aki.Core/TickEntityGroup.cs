using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000087 RID: 135
public class TickEntityGroup
{
	// Token: 0x06000443 RID: 1091 RVA: 0x000187EE File Offset: 0x000169EE
	public TickEntityGroup(int priority)
	{
		this.Priority = priority;
	}

	// Token: 0x040003E1 RID: 993
	[Nullable(1)]
	public readonly Dictionary<int, Entity> Entities = new Dictionary<int, Entity>();

	// Token: 0x040003E2 RID: 994
	public readonly int Priority;
}
