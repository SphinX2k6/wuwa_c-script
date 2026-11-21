using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02000F71 RID: 3953
[NullableContext(1)]
[Nullable(0)]
public class ExploreStateData
{
	// Token: 0x06009E88 RID: 40584 RVA: 0x002ED368 File Offset: 0x002EB568
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

	// Token: 0x06009E89 RID: 40585 RVA: 0x002ED3BB File Offset: 0x002EB5BB
	public void PushAreaData(ExploreAreaData areaData)
	{
		this.ExploreAreaDataList.Add(areaData);
	}

	// Token: 0x06009E8A RID: 40586 RVA: 0x002ED3C9 File Offset: 0x002EB5C9
	public bool CheckPushAreaData(ExploreAreaData areaData)
	{
		if (areaData.StateId != this.StateId)
		{
			return false;
		}
		this.PushAreaData(areaData);
		return true;
	}

	// Token: 0x06009E8B RID: 40587 RVA: 0x002ED3E4 File Offset: 0x002EB5E4
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

	// Token: 0x04005E0C RID: 24076
	public int StateId;

	// Token: 0x04005E0D RID: 24077
	public int CountryId;

	// Token: 0x04005E0E RID: 24078
	public string StateNameKey = "TowerDefence_lock";

	// Token: 0x04005E0F RID: 24079
	public bool IsNoneState = true;

	// Token: 0x04005E10 RID: 24080
	public int SortIndex;

	// Token: 0x04005E11 RID: 24081
	public readonly List<ExploreAreaData> ExploreAreaDataList = new List<ExploreAreaData>();
}
