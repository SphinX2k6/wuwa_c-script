using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002151 RID: 8529
public class TowerDetailBuffData
{
	// Token: 0x0400B274 RID: 45684
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<TowerDetailBuff> Buffs;

	// Token: 0x0400B275 RID: 45685
	[Nullable(1)]
	public string Title = string.Empty;

	// Token: 0x0400B276 RID: 45686
	public int Priority;
}
