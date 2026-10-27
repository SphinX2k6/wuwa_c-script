using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002BD6 RID: 11222
public class TowerDetailBuffData
{
	// Token: 0x0400AE6F RID: 44655
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<TowerDetailBuff> Buffs;

	// Token: 0x0400AE70 RID: 44656
	[Nullable(1)]
	public string Title = string.Empty;

	// Token: 0x0400AE71 RID: 44657
	public int Priority;
}
