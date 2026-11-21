using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001072 RID: 4210
public class ILimitContext
{
	// Token: 0x04006194 RID: 24980
	public int DungeonId;

	// Token: 0x04006195 RID: 24981
	[Nullable(1)]
	public IReadOnlyList<int> CurrentRoleIds = new List<int>();

	// Token: 0x04006196 RID: 24982
	public int CandidateRoleId;
}
