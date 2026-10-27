using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Area;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.WorldMap;

// Token: 0x02001AB1 RID: 6833
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class ExploreProgressModel : ModelBase
{
	// Token: 0x170010BA RID: 4282
	// (get) Token: 0x0600CA4A RID: 51786 RVA: 0x002E196A File Offset: 0x002DFB6A
	public bool GetIsRedDotAreaRewardBox
	{
		get
		{
			return this.IsRedDotAreaRewardBox;
		}
	}

	// Token: 0x0600CA4B RID: 51787 RVA: 0x002E1972 File Offset: 0x002DFB72
	protected override bool OnClear()
	{
		this.ClearExploreAreaData();
		return true;
	}

	// Token: 0x0600CA4C RID: 51788 RVA: 0x002E197B File Offset: 0x002DFB7B
	protected override bool OnLeaveLevel()
	{
		this.ClearExploreAreaData();
		return true;
	}

	// Token: 0x0600CA4D RID: 51789 RVA: 0x002E1984 File Offset: 0x002DFB84
	public void InitializeExploreAreaData()
	{
		List<Country> countryList = InfluenceConfig.Instance.GetCountryList();
		AreaConfig instance = AreaConfig.Instance;
		this.AllAreaIdList.Clear();
		foreach (Country config in countryList)
		{
			ExploreCountryData exploreCountryData = new ExploreCountryData();
			exploreCountryData.Initialize(config);
			this.ExploreCountryDataMap[config.Id] = exploreCountryData;
			IReadOnlyList<Aki.Config.Area> areaConfigByCountryAndLevel = instance.GetAreaConfigByCountryAndLevel(config.Id, 2);
			if (areaConfigByCountryAndLevel != null)
			{
				foreach (Aki.Config.Area areaConfig in areaConfigByCountryAndLevel)
				{
					if (!areaConfig.IsDisableInExplore)
					{
						int areaId = areaConfig.AreaId;
						ExploreAreaData value = exploreCountryData.AddExploreAreaData(areaConfig);
						this.ExploreAreaDataMap[areaId] = value;
						this.AllAreaIdList.Add(areaId);
					}
				}
			}
			exploreCountryData.UpdateStateAreaDataListSort();
		}
	}

	// Token: 0x0600CA4E RID: 51790 RVA: 0x002E1A94 File Offset: 0x002DFC94
	public void InitializeCurrentCountryIdAndAreaId()
	{
		AreaModel instance = AreaModel.Instance;
		this.SelectedCountryId = instance.GetAreaCountryId().GetValueOrDefault();
		if (this.SelectedCountryId <= 0)
		{
			this.SelectedCountryId = 1;
			Log instance2 = Log.Instance;
			ELogModule module = ELogModule.ExploreProgress;
			ELogAuthor author = ELogAuthor.LYX;
			string message = "初始化所有探索度区域数据时，找不到所在国家则选中皇龙";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("CountryId", this.SelectedCountryId);
			instance2.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		int worldMapLevelOneAreaId = MapUtil.GetWorldMapLevelOneAreaId();
		if (this.GetExploreAreaData(worldMapLevelOneAreaId) != null)
		{
			this.SelectedAreaId = worldMapLevelOneAreaId;
			return;
		}
		List<ExploreAreaData> exploreAreaDataList = this.GetExploreCountryData(this.SelectedCountryId).GetExploreAreaDataList();
		this.SelectedAreaId = exploreAreaDataList[0].AreaId;
		Log instance3 = Log.Instance;
		ELogModule module2 = ELogModule.ExploreProgress;
		ELogAuthor author2 = ELogAuthor.LYX;
		string message2 = "初始化所有探索度区域数据时，若玩家当前所在区域没有在对应区域探索数据，则选中当前国家的第一个区域";
		ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("AreaId", this.SelectedAreaId);
		instance3.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
	}

	// Token: 0x0600CA4F RID: 51791 RVA: 0x002E1B71 File Offset: 0x002DFD71
	public void ClearExploreAreaData()
	{
		this.ExploreCountryDataMap.Clear();
		this.ExploreAreaDataMap.Clear();
		this.AllAreaIdList.Clear();
	}

	// Token: 0x0600CA50 RID: 51792 RVA: 0x002E1B94 File Offset: 0x002DFD94
	public void RefreshExploreAreaData(AreaExploreInfo areaExploreInfo)
	{
		ExploreAreaData exploreAreaData;
		if (this.ExploreAreaDataMap.TryGetValue(areaExploreInfo.AreaId, out exploreAreaData))
		{
			exploreAreaData.Refresh(areaExploreInfo);
		}
	}

	// Token: 0x0600CA51 RID: 51793 RVA: 0x002E1BC0 File Offset: 0x002DFDC0
	[NullableContext(2)]
	public ExploreCountryData GetExploreCountryData(int countryId)
	{
		ExploreCountryData result;
		this.ExploreCountryDataMap.TryGetValue(countryId, out result);
		return result;
	}

	// Token: 0x0600CA52 RID: 51794 RVA: 0x002E1BE0 File Offset: 0x002DFDE0
	[NullableContext(2)]
	public ExploreAreaData GetExploreAreaData(int areaId)
	{
		ExploreAreaData result;
		this.ExploreAreaDataMap.TryGetValue(areaId, out result);
		return result;
	}

	// Token: 0x0600CA53 RID: 51795 RVA: 0x002E1BFD File Offset: 0x002DFDFD
	public IReadOnlyDictionary<int, ExploreCountryData> GetExploreCountryDataMap()
	{
		return this.ExploreCountryDataMap;
	}

	// Token: 0x0600CA54 RID: 51796 RVA: 0x002E1C05 File Offset: 0x002DFE05
	public IReadOnlyList<ExploreCountryData> GetExploreCountryDataList()
	{
		return this.ExploreCountryDataMap.Values.ToArray<ExploreCountryData>();
	}

	// Token: 0x0600CA55 RID: 51797 RVA: 0x002E1C18 File Offset: 0x002DFE18
	public List<ExploreAreaData> GetAllAreaDataListSortCountryState()
	{
		List<ExploreAreaData> list = new List<ExploreAreaData>();
		foreach (KeyValuePair<int, ExploreCountryData> keyValuePair in this.ExploreCountryDataMap)
		{
			foreach (ExploreStateData exploreStateData in keyValuePair.Value.GetStateDataList())
			{
				list.AddRange(exploreStateData.ExploreAreaDataList);
			}
		}
		return list;
	}

	// Token: 0x0600CA56 RID: 51798 RVA: 0x002E1CBC File Offset: 0x002DFEBC
	public List<int> GetAllAreaIdList()
	{
		return this.AllAreaIdList;
	}

	// Token: 0x0600CA57 RID: 51799 RVA: 0x002E1CC4 File Offset: 0x002DFEC4
	public void InitAreaStageRewardIdToAreaIdMap()
	{
		if (this.AreaStageRewardIdToAreaIdMap.Count > 0)
		{
			return;
		}
		IReadOnlyList<ExploreProgressReward> areaStageRewardConfigList = ExploreProgressConfig.Instance.GetAreaStageRewardConfigList();
		if (areaStageRewardConfigList != null)
		{
			foreach (ExploreProgressReward exploreProgressReward in areaStageRewardConfigList)
			{
				this.AreaStageRewardIdToAreaIdMap[exploreProgressReward.Id] = exploreProgressReward.Area;
			}
		}
	}

	// Token: 0x0600CA58 RID: 51800 RVA: 0x002E1D3C File Offset: 0x002DFF3C
	public void UpdateAreaStageRewardDataList(IReadOnlyList<int> rewardIds)
	{
		this.InitAreaStageRewardIdToAreaIdMap();
		foreach (int num in rewardIds)
		{
			int areaId;
			if (this.AreaStageRewardIdToAreaIdMap.TryGetValue(num, out areaId))
			{
				ExploreAreaData exploreAreaData = this.GetExploreAreaData(areaId);
				if (exploreAreaData != null)
				{
					exploreAreaData.UpdateAchievedStageReward(num);
				}
			}
			this.AchievedAreaRewardIds.Add(num);
		}
		this.CheckRedDotAreaRewardBox();
		EventSystem.Instance.Emit(EEventName.RedDotUpdateMapAreaBoxReward);
	}

	// Token: 0x0600CA59 RID: 51801 RVA: 0x002E1DCC File Offset: 0x002DFFCC
	public bool IsAreaStageRewardIdAchieved(int rewardId)
	{
		return this.AchievedAreaRewardIds.Contains(rewardId);
	}

	// Token: 0x0600CA5A RID: 51802 RVA: 0x002E1DDA File Offset: 0x002DFFDA
	[NullableContext(2)]
	public ExploreCountryData GetCurrentCountryData()
	{
		return this.GetExploreCountryData(this.SelectedCountryId);
	}

	// Token: 0x0600CA5B RID: 51803 RVA: 0x002E1DE8 File Offset: 0x002DFFE8
	private void CheckRedDotAreaRewardBox()
	{
		foreach (int areaId in this.AllAreaIdList)
		{
			ExploreAreaData exploreAreaData = this.GetExploreAreaData(areaId);
			if (exploreAreaData != null && exploreAreaData.HasCanTakeStageReward())
			{
				this.IsRedDotAreaRewardBox = true;
				return;
			}
		}
		this.IsRedDotAreaRewardBox = false;
	}

	// Token: 0x0600CA5C RID: 51804 RVA: 0x002E1E58 File Offset: 0x002E0058
	public void SureHasAreaRewardBox()
	{
		this.IsRedDotAreaRewardBox = true;
	}

	// Token: 0x0600CA5D RID: 51805 RVA: 0x002E1E64 File Offset: 0x002E0064
	public bool IsCollectAllStageReward()
	{
		foreach (int areaId in this.AllAreaIdList)
		{
			ExploreAreaData exploreAreaData = this.GetExploreAreaData(areaId);
			if (exploreAreaData == null || !exploreAreaData.IsCollectAllStageReward())
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600CA5E RID: 51806 RVA: 0x002E1ECC File Offset: 0x002E00CC
	public void UpdatePlayPointState(int areaId, Dictionary<int, LevelPlayStateMsg> playPointStateDict)
	{
		ExploreAreaData exploreAreaData = this.GetExploreAreaData(areaId);
		if (exploreAreaData == null)
		{
			return;
		}
		exploreAreaData.UpdatePlayPointData(playPointStateDict);
	}

	// Token: 0x0600CA5F RID: 51807 RVA: 0x002E1EE0 File Offset: 0x002E00E0
	public void UpdateTraceEntities(int areaId, int exploratoryDegree, int[] entities)
	{
		ExploreAreaData exploreAreaData = this.GetExploreAreaData(areaId);
		if (exploreAreaData == null)
		{
			return;
		}
		exploreAreaData.UpdateTraceEntities(exploratoryDegree, entities);
	}

	// Token: 0x0600CA60 RID: 51808 RVA: 0x002E1EF8 File Offset: 0x002E00F8
	public void UpdateOnlinePlayersArea(Dictionary<int, int> areaDict)
	{
		this.OnlinePlayersAreaMap.Clear();
		foreach (KeyValuePair<int, int> keyValuePair in areaDict)
		{
			int key = keyValuePair.Key;
			int value = keyValuePair.Value;
			this.OnlinePlayersAreaMap[key] = value;
		}
		EventSystem.Instance.Emit(EEventName.UpdateOnlinePlayersArea);
	}

	// Token: 0x0600CA61 RID: 51809 RVA: 0x002E1F78 File Offset: 0x002E0178
	public int? GetOnlinePlayersArea(int playerId)
	{
		int value;
		if (this.OnlinePlayersAreaMap.TryGetValue(playerId, out value))
		{
			return new int?(value);
		}
		return null;
	}

	// Token: 0x0600CA62 RID: 51810 RVA: 0x002E1FA8 File Offset: 0x002E01A8
	public List<int> GetOnlinePlayerIndexListByAreaId(int areaId)
	{
		List<int> list = new List<int>();
		foreach (KeyValuePair<int, int> keyValuePair in this.OnlinePlayersAreaMap)
		{
			int key = keyValuePair.Key;
			int value = keyValuePair.Value;
			if (AreaConfig.Instance.GetLevelOneAreaId(value) == areaId)
			{
				OnlineModel instance = OnlineModel.Instance;
				OnlineTeamData onlineTeamData = (instance != null) ? instance.GetCurrentTeamListById(key) : null;
				if (onlineTeamData != null)
				{
					int playerNumber = onlineTeamData.PlayerNumber;
					list.Add(onlineTeamData.PlayerNumber);
				}
			}
		}
		return list;
	}

	// Token: 0x0600CA63 RID: 51811 RVA: 0x002E2048 File Offset: 0x002E0248
	public void SetTrackTaskAreaId(int areaId, string taskIconPath)
	{
		this.TrackTaskAreaId = areaId;
		this.TrackTaskIconPath = taskIconPath;
	}

	// Token: 0x0600CA64 RID: 51812 RVA: 0x002E2058 File Offset: 0x002E0258
	public void ClearTrackTaskAreaId()
	{
		this.TrackTaskAreaId = 0;
		this.TrackTaskIconPath = "";
	}

	// Token: 0x0600CA65 RID: 51813 RVA: 0x002E206C File Offset: 0x002E026C
	public void ClearTrackExploreAreaItemData()
	{
		this.TrackExploreAreaItemData = null;
	}

	// Token: 0x0600CA66 RID: 51814 RVA: 0x002E2075 File Offset: 0x002E0275
	public void CheckTrackExploreAreaItemData()
	{
		if (this.TrackExploreAreaItemData != null)
		{
			this.TrackExploreAreaItemData.TrackPoint();
			this.ClearTrackExploreAreaItemData();
		}
	}

	// Token: 0x0600CA67 RID: 51815 RVA: 0x002E2090 File Offset: 0x002E0290
	public void SetTrackExploreAreaItemData(int areaId, int exploreType)
	{
		ExploreAreaData exploreAreaData = this.GetExploreAreaData(areaId);
		if (exploreAreaData != null)
		{
			this.TrackExploreAreaItemData = exploreAreaData.GetExploreAreaItemData((EExploreType)exploreType);
		}
	}

	// Token: 0x0600CA68 RID: 51816 RVA: 0x002E20B5 File Offset: 0x002E02B5
	public void SetTrackExploreAreaItemData(ExploreAreaItemData data)
	{
		this.TrackExploreAreaItemData = data;
	}

	// Token: 0x0600CA69 RID: 51817 RVA: 0x002E20BE File Offset: 0x002E02BE
	public void WorldMapViewClose()
	{
		this.ClearTrackExploreAreaItemData();
		this.SaveLocalAreaExplorePlayState();
	}

	// Token: 0x0600CA6A RID: 51818 RVA: 0x002E20CC File Offset: 0x002E02CC
	private void SaveLocalAreaExplorePlayState()
	{
		int worldMapLevelOneAreaId = MapUtil.GetWorldMapLevelOneAreaId();
		ExploreAreaData exploreAreaData = this.GetExploreAreaData(worldMapLevelOneAreaId);
		if (exploreAreaData != null)
		{
			exploreAreaData.SaveLocalAreaExplorePlayState();
		}
		if (exploreAreaData == null)
		{
			return;
		}
		exploreAreaData.ClearFlagSaveLocalAreaExplorePlayState();
	}

	// Token: 0x0600CA6B RID: 51819 RVA: 0x002E20FC File Offset: 0x002E02FC
	public IReadOnlySet<EMapNoteId> GetLocalShowNoteIdMap()
	{
		return this.ShowNoteIdMap;
	}

	// Token: 0x0600CA6C RID: 51820 RVA: 0x002E2104 File Offset: 0x002E0304
	public void SetLocalShowNoteIdMap(EMapNoteId noteId)
	{
		this.ShowNoteIdMap.Add(noteId);
	}

	// Token: 0x0600CA6D RID: 51821 RVA: 0x002E2113 File Offset: 0x002E0313
	public void SaveToLocalShowNoteIdMap()
	{
		LocalStorage.SetPlayer<HashSet<EMapNoteId>>(ELocalStoragePlayerKey.ShowNoteIdMap, this.ShowNoteIdMap);
	}

	// Token: 0x0600CA6E RID: 51822 RVA: 0x002E2126 File Offset: 0x002E0326
	public void LoadLocalShowNoteIdMap()
	{
		this.ShowNoteIdMap = (LocalStorage.GetPlayer<HashSet<EMapNoteId>>(ELocalStoragePlayerKey.ShowNoteIdMap, null) ?? new HashSet<EMapNoteId>());
	}

	// Token: 0x0600CA6F RID: 51823 RVA: 0x002E2142 File Offset: 0x002E0342
	public void ClearShowNoteIdMap()
	{
		this.ShowNoteIdMap.Clear();
	}

	// Token: 0x170010BB RID: 4283
	// (get) Token: 0x0600CA70 RID: 51824 RVA: 0x002E214F File Offset: 0x002E034F
	public static ExploreProgressModel Instance
	{
		get
		{
			return ExploreProgressModel._Instance;
		}
	}

	// Token: 0x0600CA71 RID: 51825 RVA: 0x002E2156 File Offset: 0x002E0356
	public static ExploreProgressModel GetOrCreateInstance()
	{
		if (ExploreProgressModel._Instance == null)
		{
			ExploreProgressModel.CreateInstance();
		}
		return ExploreProgressModel._Instance;
	}

	// Token: 0x0600CA72 RID: 51826 RVA: 0x002E216A File Offset: 0x002E036A
	public static bool CreateInstance()
	{
		if (ExploreProgressModel._Instance != null)
		{
			return true;
		}
		ExploreProgressModel._Instance = new ExploreProgressModel();
		return true;
	}

	// Token: 0x0600CA73 RID: 51827 RVA: 0x002E2180 File Offset: 0x002E0380
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600CA74 RID: 51828 RVA: 0x002E2182 File Offset: 0x002E0382
	public static void ResetStaticDefaultValue()
	{
		ExploreProgressModel._Instance = null;
	}

	// Token: 0x0600CA75 RID: 51829 RVA: 0x002E218A File Offset: 0x002E038A
	static ExploreProgressModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ExploreProgressModel.CreateStaticDefaultValue), new Action(ExploreProgressModel.ResetStaticDefaultValue));
	}

	// Token: 0x04005D2F RID: 23855
	private readonly Dictionary<int, ExploreCountryData> ExploreCountryDataMap = new Dictionary<int, ExploreCountryData>();

	// Token: 0x04005D30 RID: 23856
	private readonly Dictionary<int, ExploreAreaData> ExploreAreaDataMap = new Dictionary<int, ExploreAreaData>();

	// Token: 0x04005D31 RID: 23857
	private readonly List<int> AllAreaIdList = new List<int>();

	// Token: 0x04005D32 RID: 23858
	public int SelectedCountryId;

	// Token: 0x04005D33 RID: 23859
	public int SelectedAreaId;

	// Token: 0x04005D34 RID: 23860
	private readonly Dictionary<int, int> AreaStageRewardIdToAreaIdMap = new Dictionary<int, int>();

	// Token: 0x04005D35 RID: 23861
	private readonly HashSet<int> AchievedAreaRewardIds = new HashSet<int>();

	// Token: 0x04005D36 RID: 23862
	private bool IsRedDotAreaRewardBox;

	// Token: 0x04005D37 RID: 23863
	public readonly Dictionary<int, int> OnlinePlayersAreaMap = new Dictionary<int, int>();

	// Token: 0x04005D38 RID: 23864
	public int TrackTaskAreaId;

	// Token: 0x04005D39 RID: 23865
	public string TrackTaskIconPath = "";

	// Token: 0x04005D3A RID: 23866
	[Nullable(2)]
	private ExploreAreaItemData TrackExploreAreaItemData;

	// Token: 0x04005D3B RID: 23867
	private HashSet<EMapNoteId> ShowNoteIdMap = new HashSet<EMapNoteId>();

	// Token: 0x04005D3C RID: 23868
	[Nullable(2)]
	private static ExploreProgressModel _Instance;
}
