using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02000F5A RID: 3930
[NullableContext(1)]
[Nullable(0)]
public class ExploreCountryData
{
	// Token: 0x170010A3 RID: 4259
	// (get) Token: 0x06009DAC RID: 40364 RVA: 0x002EC0C9 File Offset: 0x002EA2C9
	// (set) Token: 0x06009DAD RID: 40365 RVA: 0x002EC0D1 File Offset: 0x002EA2D1
	public int CountryId { get; set; }

	// Token: 0x170010A4 RID: 4260
	// (get) Token: 0x06009DAE RID: 40366 RVA: 0x002EC0DA File Offset: 0x002EA2DA
	// (set) Token: 0x06009DAF RID: 40367 RVA: 0x002EC0E2 File Offset: 0x002EA2E2
	public string Icon { get; set; } = "";

	// Token: 0x170010A5 RID: 4261
	// (get) Token: 0x06009DB0 RID: 40368 RVA: 0x002EC0EB File Offset: 0x002EA2EB
	// (set) Token: 0x06009DB1 RID: 40369 RVA: 0x002EC0F3 File Offset: 0x002EA2F3
	public string TitleId { get; set; } = "";

	// Token: 0x170010A6 RID: 4262
	// (get) Token: 0x06009DB2 RID: 40370 RVA: 0x002EC0FC File Offset: 0x002EA2FC
	// (set) Token: 0x06009DB3 RID: 40371 RVA: 0x002EC104 File Offset: 0x002EA304
	public int SortIndex { get; set; }

	// Token: 0x06009DB4 RID: 40372 RVA: 0x002EC10D File Offset: 0x002EA30D
	public void Initialize(Country config)
	{
		this.CountryId = config.Id;
		this.TitleId = config.Title;
		this.Icon = config.Icon;
		this.SortIndex = config.SortIndex;
	}

	// Token: 0x06009DB5 RID: 40373 RVA: 0x002EC144 File Offset: 0x002EA344
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

	// Token: 0x06009DB6 RID: 40374 RVA: 0x002EC220 File Offset: 0x002EA420
	[NullableContext(2)]
	public ExploreAreaData GetExploreAreaData(int areaId)
	{
		return this.ExploreAreaDataMap.GetValueOrDefault(areaId);
	}

	// Token: 0x06009DB7 RID: 40375 RVA: 0x002EC22E File Offset: 0x002EA42E
	public IReadOnlyDictionary<int, ExploreAreaData> GetExploreAreaDataMap()
	{
		return this.ExploreAreaDataMap;
	}

	// Token: 0x06009DB8 RID: 40376 RVA: 0x002EC236 File Offset: 0x002EA436
	public List<ExploreAreaData> GetExploreAreaDataList()
	{
		return this.ExploreAreaDataList;
	}

	// Token: 0x06009DB9 RID: 40377 RVA: 0x002EC23E File Offset: 0x002EA43E
	public int GetAreaSize()
	{
		return this.ExploreAreaDataMap.Count;
	}

	// Token: 0x06009DBA RID: 40378 RVA: 0x002EC24B File Offset: 0x002EA44B
	public string GetNameId()
	{
		return this.TitleId;
	}

	// Token: 0x06009DBB RID: 40379 RVA: 0x002EC254 File Offset: 0x002EA454
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

	// Token: 0x06009DBC RID: 40380 RVA: 0x002EC2C8 File Offset: 0x002EA4C8
	public List<ExploreStateData> GetStateDataList()
	{
		List<ExploreStateData> list = new List<ExploreStateData>(this.ExploreStateDataMap.Values);
		if (list.Count <= 1)
		{
			return list;
		}
		list.Sort((ExploreStateData a, ExploreStateData b) => a.StateId.CompareTo(b.StateId));
		return list;
	}

	// Token: 0x06009DBD RID: 40381 RVA: 0x002EC317 File Offset: 0x002EA517
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

	// Token: 0x06009DBE RID: 40382 RVA: 0x002EC32B File Offset: 0x002EA52B
	[NullableContext(2)]
	public ExploreStateData GetStateDataByStateId(int stateId)
	{
		return this.ExploreStateDataMap.GetValueOrDefault(stateId);
	}

	// Token: 0x06009DBF RID: 40383 RVA: 0x002EC339 File Offset: 0x002EA539
	public bool HasCanTakeStageReward()
	{
		return this.ExploreAreaDataList.Exists((ExploreAreaData data) => data.HasCanTakeStageReward());
	}

	// Token: 0x06009DC0 RID: 40384 RVA: 0x002EC368 File Offset: 0x002EA568
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

	// Token: 0x04005DB2 RID: 23986
	private readonly Dictionary<int, ExploreAreaData> ExploreAreaDataMap = new Dictionary<int, ExploreAreaData>();

	// Token: 0x04005DB3 RID: 23987
	private readonly List<ExploreAreaData> ExploreAreaDataList = new List<ExploreAreaData>();

	// Token: 0x04005DB4 RID: 23988
	private readonly Dictionary<int, ExploreStateData> ExploreStateDataMap = new Dictionary<int, ExploreStateData>();
}
