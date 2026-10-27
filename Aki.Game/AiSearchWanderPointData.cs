using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001F73 RID: 8051
internal sealed class AiSearchWanderPointData
{
	// Token: 0x0600F9B8 RID: 63928 RVA: 0x003C85E2 File Offset: 0x003C67E2
	public void AddSearchedWanderPointId(int wanderPointId)
	{
		this.SearchedWanderPointIdSet.Add(wanderPointId);
	}

	// Token: 0x0600F9B9 RID: 63929 RVA: 0x003C85F1 File Offset: 0x003C67F1
	public void ClearSearchedWanderPointIdSet()
	{
		this.SearchedWanderPointIdSet.Clear();
	}

	// Token: 0x0600F9BA RID: 63930 RVA: 0x003C85FE File Offset: 0x003C67FE
	public bool HasSearchedWanderPointId(int wanderPointId)
	{
		return this.SearchedWanderPointIdSet.Contains(wanderPointId);
	}

	// Token: 0x04007471 RID: 29809
	[Nullable(1)]
	public HashSet<int> SearchedWanderPointIdSet = new HashSet<int>();
}
