using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001F7E RID: 8062
public struct InfluenceSearchData
{
	// Token: 0x0400748E RID: 29838
	public bool HasResult;

	// Token: 0x0400748F RID: 29839
	[Nullable(new byte[]
	{
		1,
		0,
		1
	})]
	public List<ValueTuple<int, List<int>>> InfluenceList;
}
