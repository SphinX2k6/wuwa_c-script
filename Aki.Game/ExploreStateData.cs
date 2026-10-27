using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001AB2 RID: 6834
[NullableContext(1)]
[Nullable(0)]
public class ExploreStateData
{
	// Token: 0x0600CA77 RID: 51831 RVA: 0x002E2218 File Offset: 0x002E0418
	public void Initialize(int stateId, int countryId)
	{
		this.CountryId = countryId;
		this.StateId = stateId;
		if (stateId != 0)
		{
			this.IsNoneState = false;
			State value = ExploreProgressConfig.Instance.GetStateConfigByStateId(stateId).Value;
			this.StateNameKey = value.StateName;
			this.SortIndex = value.SortIndex;
		}
	}

	// Token: 0x0600CA78 RID: 51832 RVA: 0x002E226B File Offset: 0x002E046B
	public void PushAreaData(ExploreAreaData areaData)
	{
		this.ExploreAreaDataList.Add(areaData);
	}

	// Token: 0x0600CA79 RID: 51833 RVA: 0x002E2279 File Offset: 0x002E0479
	public bool CheckPushAreaData(ExploreAreaData areaData)
	{
		if (areaData.StateId != this.StateId)
		{
			return false;
		}
		this.PushAreaData(areaData);
		return true;
	}

	// Token: 0x0600CA7A RID: 51834 RVA: 0x002E2294 File Offset: 0x002E0494
	public bool HasCanTakeStageReward()
	{
		using (List<ExploreAreaData>.Enumerator enumerator = this.ExploreAreaDataList.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.HasCanTakeStageReward())
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x04005D3D RID: 23869
	public int StateId;

	// Token: 0x04005D3E RID: 23870
	public int CountryId;

	// Token: 0x04005D3F RID: 23871
	public string StateNameKey = "TowerDefence_lock";

	// Token: 0x04005D40 RID: 23872
	public bool IsNoneState = true;

	// Token: 0x04005D41 RID: 23873
	public int SortIndex;

	// Token: 0x04005D42 RID: 23874
	public readonly List<ExploreAreaData> ExploreAreaDataList = new List<ExploreAreaData>();
}
