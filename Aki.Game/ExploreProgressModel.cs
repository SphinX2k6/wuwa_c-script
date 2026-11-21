using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Area;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.WorldMap;

// Token: 0x02000F70 RID: 3952
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class ExploreProgressModel : ModelBase
{
	// Token: 0x170010DF RID: 4319
	// (get) Token: 0x06009E5B RID: 40539 RVA: 0x002ECABA File Offset: 0x002EACBA
	public bool GetIsRedDotAreaRewardBox
	{
		get
		{
			return this.IsRedDotAreaRewardBox;
		}
	}

	// Token: 0x06009E5C RID: 40540 RVA: 0x002ECAC2 File Offset: 0x002EACC2
	protected override bool OnClear()
	{
		this.ClearExploreAreaData();
		return true;
	}

	// Token: 0x06009E5D RID: 40541 RVA: 0x002ECACB File Offset: 0x002EACCB
	protected override bool OnLeaveLevel()
	{
		this.ClearExploreAreaData();
		return true;
	}

	// Token: 0x06009E5E RID: 40542 RVA: 0x002ECAD4 File Offset: 0x002EACD4
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

	// Token: 0x06009E5F RID: 40543 RVA: 0x002ECBE4 File Offset: 0x002EADE4
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

	// Token: 0x06009E60 RID: 40544 RVA: 0x002ECCC1 File Offset: 0x002EAEC1
	public void ClearExploreAreaData()
	{
		this.ExploreCountryDataMap.Clear();
		this.ExploreAreaDataMap.Clear();
		this.AllAreaIdList.Clear();
	}

	// Token: 0x06009E61 RID: 40545 RVA: 0x002ECCE4 File Offset: 0x002EAEE4
	public void RefreshExploreAreaData(AreaExploreInfo areaExploreInfo)
	{
		ExploreAreaData exploreAreaData;
		if (this.ExploreAreaDataMap.TryGetValue(areaExploreInfo.AreaId, out exploreAreaData))
		{
			exploreAreaData.Refresh(areaExploreInfo);
		}
	}

	// Token: 0x06009E62 RID: 40546 RVA: 0x002ECD10 File Offset: 0x002EAF10
	[NullableContext(2)]
	public ExploreCountryData GetExploreCountryData(int countryId)
	{
		ExploreCountryData result;
		this.ExploreCountryDataMap.TryGetValue(countryId, out result);
		return result;
	}

	// Token: 0x06009E63 RID: 40547 RVA: 0x002ECD30 File Offset: 0x002EAF30
	[NullableContext(2)]
	public ExploreAreaData GetExploreAreaData(int areaId)
	{
		ExploreAreaData result;
		this.ExploreAreaDataMap.TryGetValue(areaId, out result);
		return result;
	}

	// Token: 0x06009E64 RID: 40548 RVA: 0x002ECD4D File Offset: 0x002EAF4D
	public IReadOnlyDictionary<int, ExploreCountryData> GetExploreCountryDataMap()
	{
		return this.ExploreCountryDataMap;
	}

	// Token: 0x06009E65 RID: 40549 RVA: 0x002ECD55 File Offset: 0x002EAF55
	public IReadOnlyList<ExploreCountryData> GetExploreCountryDataList()
	{
		return new List<ExploreCountryData>(this.ExploreCountryDataMap.Values);
	}

	// Token: 0x06009E66 RID: 40550 RVA: 0x002ECD68 File Offset: 0x002EAF68
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

	// Token: 0x06009E67 RID: 40551 RVA: 0x002ECE0C File Offset: 0x002EB00C
	public List<int> GetAllAreaIdList()
	{
		return this.AllAreaIdList;
	}

	// Token: 0x06009E68 RID: 40552 RVA: 0x002ECE14 File Offset: 0x002EB014
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

	// Token: 0x06009E69 RID: 40553 RVA: 0x002ECE8C File Offset: 0x002EB08C
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

	// Token: 0x06009E6A RID: 40554 RVA: 0x002ECF1C File Offset: 0x002EB11C
	public bool IsAreaStageRewardIdAchieved(int rewardId)
	{
		return this.AchievedAreaRewardIds.Contains(rewardId);
	}

	// Token: 0x06009E6B RID: 40555 RVA: 0x002ECF2A File Offset: 0x002EB12A
	[NullableContext(2)]
	public ExploreCountryData GetCurrentCountryData()
	{
		return this.GetExploreCountryData(this.SelectedCountryId);
	}

	// Token: 0x06009E6C RID: 40556 RVA: 0x002ECF38 File Offset: 0x002EB138
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

	// Token: 0x06009E6D RID: 40557 RVA: 0x002ECFA8 File Offset: 0x002EB1A8
	public void SureHasAreaRewardBox()
	{
		this.IsRedDotAreaRewardBox = true;
	}

	// Token: 0x06009E6E RID: 40558 RVA: 0x002ECFB4 File Offset: 0x002EB1B4
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

	// Token: 0x06009E6F RID: 40559 RVA: 0x002ED01C File Offset: 0x002EB21C
	public void UpdatePlayPointState(int areaId, Dictionary<int, LevelPlayStateMsg> playPointStateDict)
	{
		ExploreAreaData exploreAreaData = this.GetExploreAreaData(areaId);
		if (exploreAreaData == null)
		{
			return;
		}
		exploreAreaData.UpdatePlayPointData(playPointStateDict);
	}

	// Token: 0x06009E70 RID: 40560 RVA: 0x002ED030 File Offset: 0x002EB230
	public void UpdateTraceEntities(int areaId, int exploratoryDegree, int[] entities)
	{
		ExploreAreaData exploreAreaData = this.GetExploreAreaData(areaId);
		if (exploreAreaData == null)
		{
			return;
		}
		exploreAreaData.UpdateTraceEntities(exploratoryDegree, entities);
	}

	// Token: 0x06009E71 RID: 40561 RVA: 0x002ED048 File Offset: 0x002EB248
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

	// Token: 0x06009E72 RID: 40562 RVA: 0x002ED0C8 File Offset: 0x002EB2C8
	public int? GetOnlinePlayersArea(int playerId)
	{
		int value;
		if (this.OnlinePlayersAreaMap.TryGetValue(playerId, out value))
		{
			return new int?(value);
		}
		return null;
	}

	// Token: 0x06009E73 RID: 40563 RVA: 0x002ED0F8 File Offset: 0x002EB2F8
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

	// Token: 0x06009E74 RID: 40564 RVA: 0x002ED198 File Offset: 0x002EB398
	public void SetTrackTaskAreaId(int areaId, string taskIconPath)
	{
		this.TrackTaskAreaId = areaId;
		this.TrackTaskIconPath = taskIconPath;
	}

	// Token: 0x06009E75 RID: 40565 RVA: 0x002ED1A8 File Offset: 0x002EB3A8
	public void ClearTrackTaskAreaId()
	{
		this.TrackTaskAreaId = 0;
		this.TrackTaskIconPath = "";
	}

	// Token: 0x06009E76 RID: 40566 RVA: 0x002ED1BC File Offset: 0x002EB3BC
	public void ClearTrackExploreAreaItemData()
	{
		this.TrackExploreAreaItemData = null;
	}

	// Token: 0x06009E77 RID: 40567 RVA: 0x002ED1C5 File Offset: 0x002EB3C5
	public void CheckTrackExploreAreaItemData()
	{
		if (this.TrackExploreAreaItemData != null)
		{
			this.TrackExploreAreaItemData.TrackPoint();
			this.ClearTrackExploreAreaItemData();
		}
	}

	// Token: 0x06009E78 RID: 40568 RVA: 0x002ED1E0 File Offset: 0x002EB3E0
	public void SetTrackExploreAreaItemData(int areaId, int exploreType)
	{
		ExploreAreaData exploreAreaData = this.GetExploreAreaData(areaId);
		if (exploreAreaData != null)
		{
			this.TrackExploreAreaItemData = exploreAreaData.GetExploreAreaItemData((EExploreType)exploreType);
		}
	}

	// Token: 0x06009E79 RID: 40569 RVA: 0x002ED205 File Offset: 0x002EB405
	public void SetTrackExploreAreaItemData(ExploreAreaItemData data)
	{
		this.TrackExploreAreaItemData = data;
	}

	// Token: 0x06009E7A RID: 40570 RVA: 0x002ED20E File Offset: 0x002EB40E
	public void WorldMapViewClose()
	{
		this.ClearTrackExploreAreaItemData();
		this.SaveLocalAreaExplorePlayState();
	}

	// Token: 0x06009E7B RID: 40571 RVA: 0x002ED21C File Offset: 0x002EB41C
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

	// Token: 0x06009E7C RID: 40572 RVA: 0x002ED24C File Offset: 0x002EB44C
	public IReadOnlySet<EMapNoteId> GetLocalShowNoteIdMap()
	{
		return this.ShowNoteIdMap;
	}

	// Token: 0x06009E7D RID: 40573 RVA: 0x002ED254 File Offset: 0x002EB454
	public void SetLocalShowNoteIdMap(EMapNoteId noteId)
	{
		this.ShowNoteIdMap.Add(noteId);
	}

	// Token: 0x06009E7E RID: 40574 RVA: 0x002ED263 File Offset: 0x002EB463
	public void SaveToLocalShowNoteIdMap()
	{
		LocalStorage.SetPlayer<HashSet<EMapNoteId>>(ELocalStoragePlayerKey.ShowNoteIdMap, this.ShowNoteIdMap);
	}

	// Token: 0x06009E7F RID: 40575 RVA: 0x002ED276 File Offset: 0x002EB476
	public void LoadLocalShowNoteIdMap()
	{
		this.ShowNoteIdMap = (LocalStorage.GetPlayer<HashSet<EMapNoteId>>(ELocalStoragePlayerKey.ShowNoteIdMap, null) ?? new HashSet<EMapNoteId>());
	}

	// Token: 0x06009E80 RID: 40576 RVA: 0x002ED292 File Offset: 0x002EB492
	public void ClearShowNoteIdMap()
	{
		this.ShowNoteIdMap.Clear();
	}

	// Token: 0x170010E0 RID: 4320
	// (get) Token: 0x06009E81 RID: 40577 RVA: 0x002ED29F File Offset: 0x002EB49F
	public static ExploreProgressModel Instance
	{
		get
		{
			return ExploreProgressModel._Instance;
		}
	}

	// Token: 0x06009E82 RID: 40578 RVA: 0x002ED2A6 File Offset: 0x002EB4A6
	public static ExploreProgressModel GetOrCreateInstance()
	{
		if (ExploreProgressModel._Instance == null)
		{
			ExploreProgressModel.CreateInstance();
		}
		return ExploreProgressModel._Instance;
	}

	// Token: 0x06009E83 RID: 40579 RVA: 0x002ED2BA File Offset: 0x002EB4BA
	public static bool CreateInstance()
	{
		if (ExploreProgressModel._Instance != null)
		{
			return true;
		}
		ExploreProgressModel._Instance = new ExploreProgressModel();
		return true;
	}

	// Token: 0x06009E84 RID: 40580 RVA: 0x002ED2D0 File Offset: 0x002EB4D0
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06009E85 RID: 40581 RVA: 0x002ED2D2 File Offset: 0x002EB4D2
	public static void ResetStaticDefaultValue()
	{
		ExploreProgressModel._Instance = null;
	}

	// Token: 0x06009E86 RID: 40582 RVA: 0x002ED2DA File Offset: 0x002EB4DA
	static ExploreProgressModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ExploreProgressModel.CreateStaticDefaultValue), new Action(ExploreProgressModel.ResetStaticDefaultValue));
	}

	// Token: 0x04005DFE RID: 24062
	private readonly Dictionary<int, ExploreCountryData> ExploreCountryDataMap = new Dictionary<int, ExploreCountryData>();

	// Token: 0x04005DFF RID: 24063
	private readonly Dictionary<int, ExploreAreaData> ExploreAreaDataMap = new Dictionary<int, ExploreAreaData>();

	// Token: 0x04005E00 RID: 24064
	private readonly List<int> AllAreaIdList = new List<int>();

	// Token: 0x04005E01 RID: 24065
	public int SelectedCountryId;

	// Token: 0x04005E02 RID: 24066
	public int SelectedAreaId;

	// Token: 0x04005E03 RID: 24067
	private readonly Dictionary<int, int> AreaStageRewardIdToAreaIdMap = new Dictionary<int, int>();

	// Token: 0x04005E04 RID: 24068
	private readonly HashSet<int> AchievedAreaRewardIds = new HashSet<int>();

	// Token: 0x04005E05 RID: 24069
	private bool IsRedDotAreaRewardBox;

	// Token: 0x04005E06 RID: 24070
	public readonly Dictionary<int, int> OnlinePlayersAreaMap = new Dictionary<int, int>();

	// Token: 0x04005E07 RID: 24071
	public int TrackTaskAreaId;

	// Token: 0x04005E08 RID: 24072
	public string TrackTaskIconPath = "";

	// Token: 0x04005E09 RID: 24073
	[Nullable(2)]
	private ExploreAreaItemData TrackExploreAreaItemData;

	// Token: 0x04005E0A RID: 24074
	private HashSet<EMapNoteId> ShowNoteIdMap = new HashSet<EMapNoteId>();

	// Token: 0x04005E0B RID: 24075
	[Nullable(2)]
	private static ExploreProgressModel _Instance;
}
