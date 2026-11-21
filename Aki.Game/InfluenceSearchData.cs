using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001440 RID: 5184
public struct InfluenceSearchData
{
	// Token: 0x0400756F RID: 30063
	public bool HasResult;

	// Token: 0x04007570 RID: 30064
	[Nullable(new byte[]
	{
		1,
		0,
		1
	})]
	public List<ValueTuple<int, List<int>>> InfluenceList;
}
