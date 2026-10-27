using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001A9B RID: 6811
[NullableContext(1)]
[Nullable(0)]
public class ExploreCountryData
{
	// Token: 0x1700107E RID: 4222
	// (get) Token: 0x0600C99B RID: 51611 RVA: 0x002E0F75 File Offset: 0x002DF175
	// (set) Token: 0x0600C99C RID: 51612 RVA: 0x002E0F7D File Offset: 0x002DF17D
	public int CountryId { get; set; }

	// Token: 0x1700107F RID: 4223
	// (get) Token: 0x0600C99D RID: 51613 RVA: 0x002E0F86 File Offset: 0x002DF186
	// (set) Token: 0x0600C99E RID: 51614 RVA: 0x002E0F8E File Offset: 0x002DF18E
	public string Icon { get; set; } = "";

	// Token: 0x17001080 RID: 4224
	// (get) Token: 0x0600C99F RID: 51615 RVA: 0x002E0F97 File Offset: 0x002DF197
	// (set) Token: 0x0600C9A0 RID: 51616 RVA: 0x002E0F9F File Offset: 0x002DF19F
	public string TitleId { get; set; } = "";

	// Token: 0x17001081 RID: 4225
	// (get) Token: 0x0600C9A1 RID: 51617 RVA: 0x002E0FA8 File Offset: 0x002DF1A8
	// (set) Token: 0x0600C9A2 RID: 51618 RVA: 0x002E0FB0 File Offset: 0x002DF1B0
	public int SortIndex { get; set; }

	// Token: 0x0600C9A3 RID: 51619 RVA: 0x002E0FB9 File Offset: 0x002DF1B9
	public void Initialize(Country config)
	{
		this.CountryId = config.Id;
		this.TitleId = config.Title;
		this.Icon = config.Icon;
		this.SortIndex = config.SortIndex;
	}

	// Token: 0x0600C9A4 RID: 51620 RVA: 0x002E0FF0 File Offset: 0x002DF1F0
	public ExploreAreaData AddExploreAreaData(Area areaConfig)
	{
		int areaId = areaConfig.AreaId;
		ExploreAreaData exploreAreaData = new ExploreAreaData();
		exploreAreaData.Initialize(areaConfig);
		this.ExploreAreaDataMap[areaId] = exploreAreaData;
		this.ExploreAreaDataList.Add(exploreAreaData);
		IReadOnlyList<ExploreProgress> exploreProgressConfigListByArea = ExploreProgressConfig.Instance.GetExploreProgressConfigListByArea(areaId);
		if (exploreProgressConfigListByArea != null)
		{
			foreach (ExploreProgress exploreItemConfig in exploreProgressConfigListByArea)
			{
				exploreAreaData.AddExploreAreaItemData(exploreItemConfig);
			}
		}
		exploreAreaData.AddExploreAreaItemDataFinish();
		int stateId = exploreAreaData.StateId;
		ExploreStateData exploreStateData;
		ExploreStateData exploreStateData2;
		if (this.ExploreStateDataMap.TryGetValue(stateId, out exploreStateData))
		{
			exploreStateData2 = exploreStateData;
		}
		else
		{
			exploreStateData2 = new ExploreStateData();
			this.ExploreStateDataMap[stateId] = exploreStateData2;
			exploreStateData2.Initialize(stateId, this.CountryId);
		}
		exploreStateData2.PushAreaData(exploreAreaData);
		return exploreAreaData;
	}

	// Token: 0x0600C9A5 RID: 51621 RVA: 0x002E10CC File Offset: 0x002DF2CC
	[NullableContext(2)]
	public ExploreAreaData GetExploreAreaData(int areaId)
	{
		return this.ExploreAreaDataMap.GetValueOrDefault(areaId);
	}

	// Token: 0x0600C9A6 RID: 51622 RVA: 0x002E10DA File Offset: 0x002DF2DA
	public IReadOnlyDictionary<int, ExploreAreaData> GetExploreAreaDataMap()
	{
		return this.ExploreAreaDataMap;
	}

	// Token: 0x0600C9A7 RID: 51623 RVA: 0x002E10E2 File Offset: 0x002DF2E2
	public List<ExploreAreaData> GetExploreAreaDataList()
	{
		return this.ExploreAreaDataList;
	}

	// Token: 0x0600C9A8 RID: 51624 RVA: 0x002E10EA File Offset: 0x002DF2EA
	public int GetAreaSize()
	{
		return this.ExploreAreaDataMap.Count;
	}

	// Token: 0x0600C9A9 RID: 51625 RVA: 0x002E10F7 File Offset: 0x002DF2F7
	public string GetNameId()
	{
		return this.TitleId;
	}

	// Token: 0x0600C9AA RID: 51626 RVA: 0x002E1100 File Offset: 0x002DF300
	public float GetCountryExploreProgress()
	{
		float num = 100f * (float)this.ExploreAreaDataList.Count;
		float num2 = 0f;
		foreach (ExploreAreaData exploreAreaData in this.ExploreAreaDataList)
		{
			num2 += (float)exploreAreaData.GetProgress();
		}
		return num2 / num;
	}

	// Token: 0x0600C9AB RID: 51627 RVA: 0x002E1174 File Offset: 0x002DF374
	public List<ExploreStateData> GetStateDataList()
	{
		List<ExploreStateData> list = this.ExploreStateDataMap.Values.ToList<ExploreStateData>();
		if (list.Count <= 1)
		{
			return list;
		}
		list.Sort((ExploreStateData a, ExploreStateData b) => a.StateId.CompareTo(b.StateId));
		return list;
	}

	// Token: 0x0600C9AC RID: 51628 RVA: 0x002E11C3 File Offset: 0x002DF3C3
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public List<ExploreAreaData> GetAreaDataListByStateId(int stateId)
	{
		ExploreStateData stateDataByStateId = this.GetStateDataByStateId(stateId);
		if (stateDataByStateId == null)
		{
			return null;
		}
		return stateDataByStateId.ExploreAreaDataList;
	}

	// Token: 0x0600C9AD RID: 51629 RVA: 0x002E11D7 File Offset: 0x002DF3D7
	[NullableContext(2)]
	public ExploreStateData GetStateDataByStateId(int stateId)
	{
		return this.ExploreStateDataMap.GetValueOrDefault(stateId);
	}

	// Token: 0x0600C9AE RID: 51630 RVA: 0x002E11E5 File Offset: 0x002DF3E5
	public bool HasCanTakeStageReward()
	{
		return this.ExploreAreaDataList.Any((ExploreAreaData data) => data.HasCanTakeStageReward());
	}

	// Token: 0x0600C9AF RID: 51631 RVA: 0x002E1214 File Offset: 0x002DF414
	public void UpdateStateAreaDataListSort()
	{
		foreach (ExploreStateData exploreStateData in this.ExploreStateDataMap.Values)
		{
			exploreStateData.ExploreAreaDataList.Sort(delegate(ExploreAreaData a, ExploreAreaData b)
			{
				if (a.GetSortIndex() != b.GetSortIndex())
				{
					return a.GetSortIndex().CompareTo(b.GetSortIndex());
				}
				return a.AreaId.CompareTo(b.AreaId);
			});
		}
	}

	// Token: 0x04005CE3 RID: 23779
	private readonly Dictionary<int, ExploreAreaData> ExploreAreaDataMap = new Dictionary<int, ExploreAreaData>();

	// Token: 0x04005CE4 RID: 23780
	private readonly List<ExploreAreaData> ExploreAreaDataList = new List<ExploreAreaData>();

	// Token: 0x04005CE5 RID: 23781
	private readonly Dictionary<int, ExploreStateData> ExploreStateDataMap = new Dictionary<int, ExploreStateData>();
}
