using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001BB3 RID: 7091
public class ILimitContext
{
	// Token: 0x040060C5 RID: 24773
	public int DungeonId;

	// Token: 0x040060C6 RID: 24774
	[Nullable(1)]
	public IReadOnlyList<int> CurrentRoleIds = new List<int>();

	// Token: 0x040060C7 RID: 24775
	public int CandidateRoleId;
}
