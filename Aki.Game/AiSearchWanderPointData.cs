using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001435 RID: 5173
internal sealed class AiSearchWanderPointData
{
	// Token: 0x0600CDD7 RID: 52695 RVA: 0x003D40CE File Offset: 0x003D22CE
	public void AddSearchedWanderPointId(int wanderPointId)
	{
		this.SearchedWanderPointIdSet.Add(wanderPointId);
	}

	// Token: 0x0600CDD8 RID: 52696 RVA: 0x003D40DD File Offset: 0x003D22DD
	public void ClearSearchedWanderPointIdSet()
	{
		this.SearchedWanderPointIdSet.Clear();
	}

	// Token: 0x0600CDD9 RID: 52697 RVA: 0x003D40EA File Offset: 0x003D22EA
	public bool HasSearchedWanderPointId(int wanderPointId)
	{
		return this.SearchedWanderPointIdSet.Contains(wanderPointId);
	}

	// Token: 0x04007552 RID: 30034
	[Nullable(1)]
	public HashSet<int> SearchedWanderPointIdSet = new HashSet<int>();
}
