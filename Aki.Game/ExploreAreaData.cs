using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Area;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.Reward;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02001A98 RID: 6808
[NullableContext(1)]
[Nullable(0)]
public class ExploreAreaData
{
	// Token: 0x1700107A RID: 4218
	// (get) Token: 0x0600C927 RID: 51495 RVA: 0x002DE7AD File Offset: 0x002DC9AD
	public bool IsReachMaxProgress
	{
		get
		{
			return this.ExploreProgress >= this.MaxExploreProgress;
		}
	}

	// Token: 0x0600C928 RID: 51496 RVA: 0x002DE7C0 File Offset: 0x002DC9C0
	private void UpdateExploreProgress(int progress)
	{
		if (this.ExploreProgress == progress)
		{
			return;
		}
		this.ExploreProgress = progress;
		this.NextStageNeedProgress = this.MaxExploreProgress;
		bool flag = false;
		foreach (DailyActivityDefine.IActivityGoalData activityGoalData in this.StageRewardDataList)
		{
			if (activityGoalData.Goal > progress)
			{
				this.NextStageNeedProgress = activityGoalData.Goal;
				break;
			}
			if (!activityGoalData.Achieved)
			{
				activityGoalData.State = EDailyActiveState.FinishedAndNotTaken;
				flag = true;
			}
		}
		EventSystem.Instance.Emit<int>(EEventName.OnAreaExploreProgressUpdate, this.AreaId);
		if (flag)
		{
			ExploreProgressModel.Instance.SureHasAreaRewardBox();
			EventSystem.Instance.Emit(EEventName.RedDotUpdateMapAreaBoxReward);
		}
	}

	// Token: 0x0600C929 RID: 51497 RVA: 0x002DE888 File Offset: 0x002DCA88
	public void Initialize(Area config)
	{
		this.AreaId = config.AreaId;
		this.TitleId = config.Title;
		this.AreaSortIndex = config.SortIndex;
		this.CountryId = config.CountryId;
		this.StateId = config.StateId;
		this.MapId = config.MapConfigId;
		this.InitStageReward();
		AreaReport? storyConfigByAreaIdAndStage = AreaConfig.Instance.GetStoryConfigByAreaIdAndStage(this.AreaId, 1);
		if (storyConfigByAreaIdAndStage != null)
		{
			this.PreviewImage = storyConfigByAreaIdAndStage.Value.PicResource;
		}
	}

	// Token: 0x0600C92A RID: 51498 RVA: 0x002DE91C File Offset: 0x002DCB1C
	private void InitStageReward()
	{
		IReadOnlyList<ExploreProgressReward> areaStageAwardConfigByAreaId = ExploreProgressConfig.Instance.GetAreaStageAwardConfigByAreaId(this.AreaId);
		if (areaStageAwardConfigByAreaId != null)
		{
			foreach (ExploreProgressReward exploreProgressReward in areaStageAwardConfigByAreaId)
			{
				DropPackage? dropPackage = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackage(exploreProgressReward.DropReward);
				List<TItem> list = new List<TItem>();
				if (dropPackage != null)
				{
					foreach (KeyValuePair<int, int> keyValuePair in dropPackage.Value.DropPreview())
					{
						list.Add(new TItem(new InventoryDefine.GetItemData(keyValuePair.Key, 0), keyValuePair.Value));
					}
				}
				bool flag = ExploreProgressModel.Instance.IsAreaStageRewardIdAchieved(exploreProgressReward.Id);
				ActivityGoalData activityGoalData = new ActivityGoalData
				{
					Id = exploreProgressReward.Id,
					Goal = exploreProgressReward.NeedExploreProgress,
					Rewards = list,
					Achieved = flag,
					State = (flag ? EDailyActiveState.FinishedAndTaken : EDailyActiveState.Unfinished)
				};
				this.StageRewardDataList.Add(activityGoalData);
				this.StageRewardDataMap[exploreProgressReward.Id] = activityGoalData;
			}
		}
		this.NextStageNeedProgress = ((this.StageRewardDataList.Count > 0) ? this.StageRewardDataList[0].Goal : this.MaxExploreProgress);
	}

	// Token: 0x0600C92B RID: 51499 RVA: 0x002DEABC File Offset: 0x002DCCBC
	public void Clear()
	{
		this.AreaId = 0;
		this.ExploreProgress = 0;
		this.NextStageNeedProgress = 1;
		this.ExploreAreaItemDataMap.Clear();
	}

	// Token: 0x0600C92C RID: 51500 RVA: 0x002DEAE0 File Offset: 0x002DCCE0
	public void AddExploreAreaItemData(ExploreProgress exploreItemConfig)
	{
		EExploreType exploreType = (EExploreType)exploreItemConfig.ExploreType;
		if (this.ExploreAreaItemDataMap.ContainsKey(exploreType))
		{
			return;
		}
		ExploreAreaItemData exploreAreaItemData = new ExploreAreaItemData();
		exploreAreaItemData.Initialize(exploreItemConfig);
		this.ExploreAreaItemDataMap[exploreType] = exploreAreaItemData;
		this.ExploreAreaItemDataList.Add(exploreAreaItemData);
	}

	// Token: 0x0600C92D RID: 51501 RVA: 0x002DEB2A File Offset: 0x002DCD2A
	public void AddExploreAreaItemDataFinish()
	{
		this.SortExploreAreaItemDataList(this.ExploreAreaItemDataList);
		this.UpdateExploreAreaItemSubType();
	}

	// Token: 0x0600C92E RID: 51502 RVA: 0x002DEB3E File Offset: 0x002DCD3E
	public void SortExploreAreaItemDataList(List<ExploreAreaItemData> list)
	{
		list.Sort(delegate(ExploreAreaItemData aAreaItemData, ExploreAreaItemData bAreaItemData)
		{
			if (aAreaItemData.SortIndex != bAreaItemData.SortIndex)
			{
				return aAreaItemData.SortIndex - bAreaItemData.SortIndex;
			}
			int configId = aAreaItemData.ConfigId;
			int configId2 = bAreaItemData.ConfigId;
			return configId - configId2;
		});
	}

	// Token: 0x0600C92F RID: 51503 RVA: 0x002DEB68 File Offset: 0x002DCD68
	private void UpdateExploreAreaItemSubType()
	{
		this.ExploreAreaItemSubTypeMap.Clear();
		foreach (ExploreAreaItemData exploreAreaItemData in this.ExploreAreaItemDataList)
		{
			foreach (int key in exploreAreaItemData.SubTypes)
			{
				this.ExploreAreaItemSubTypeMap[key] = (int)exploreAreaItemData.ExploreType;
			}
		}
	}

	// Token: 0x0600C930 RID: 51504 RVA: 0x002DEBEC File Offset: 0x002DCDEC
	public void Refresh(AreaExploreInfo areaExploreInfo)
	{
		this.UpdateExploreProgress(areaExploreInfo.ExplorePercent);
		ExploreProgressConfig instance = ExploreProgressConfig.Instance;
		foreach (OneExploreItem oneExploreItem in areaExploreInfo.ExploreProgress)
		{
			ExploreProgress? exploreProgressConfigById = instance.GetExploreProgressConfigById(oneExploreItem.ExploreProgressId);
			EExploreType key = (EExploreType)((exploreProgressConfigById != null) ? exploreProgressConfigById.Value.ExploreType : 0);
			ExploreAreaItemData exploreAreaItemData;
			if (this.ExploreAreaItemDataMap.TryGetValue(key, out exploreAreaItemData))
			{
				exploreAreaItemData.Refresh(oneExploreItem);
			}
		}
	}

	// Token: 0x0600C931 RID: 51505 RVA: 0x002DEC88 File Offset: 0x002DCE88
	[NullableContext(2)]
	public ExploreAreaItemData GetExploreAreaItemData(EExploreType exploreType)
	{
		ExploreAreaItemData result;
		this.ExploreAreaItemDataMap.TryGetValue(exploreType, out result);
		return result;
	}

	// Token: 0x0600C932 RID: 51506 RVA: 0x002DECA5 File Offset: 0x002DCEA5
	public List<ExploreAreaItemData> GetAllExploreAreaItemData()
	{
		return this.ExploreAreaItemDataList;
	}

	// Token: 0x0600C933 RID: 51507 RVA: 0x002DECAD File Offset: 0x002DCEAD
	public int GetProgress()
	{
		return this.ExploreProgress;
	}

	// Token: 0x0600C934 RID: 51508 RVA: 0x002DECB5 File Offset: 0x002DCEB5
	public string GetNameId()
	{
		return this.TitleId;
	}

	// Token: 0x0600C935 RID: 51509 RVA: 0x002DECBD File Offset: 0x002DCEBD
	public int GetSortIndex()
	{
		return this.AreaSortIndex;
	}

	// Token: 0x0600C936 RID: 51510 RVA: 0x002DECC5 File Offset: 0x002DCEC5
	public int GetNextStageNeedProgress()
	{
		return this.NextStageNeedProgress;
	}

	// Token: 0x0600C937 RID: 51511 RVA: 0x002DECD0 File Offset: 0x002DCED0
	public float GetStageProgress(bool isPercentage = false)
	{
		int num = isPercentage ? 100 : 1;
		return (float)this.GetProgress() / (float)this.GetNextStageNeedProgress() * (float)num;
	}

	// Token: 0x0600C938 RID: 51512 RVA: 0x002DECF8 File Offset: 0x002DCEF8
	public List<DailyActivityDefine.IActivityGoalData> GetStageRewardDataList()
	{
		return this.StageRewardDataList;
	}

	// Token: 0x0600C939 RID: 51513 RVA: 0x002DED00 File Offset: 0x002DCF00
	public void UpdateAchievedStageReward(int rewardId)
	{
		DailyActivityDefine.IActivityGoalData activityGoalData;
		if (this.StageRewardDataMap.TryGetValue(rewardId, out activityGoalData))
		{
			activityGoalData.Achieved = true;
			activityGoalData.State = EDailyActiveState.FinishedAndTaken;
		}
	}

	// Token: 0x0600C93A RID: 51514 RVA: 0x002DED2C File Offset: 0x002DCF2C
	public bool HasCanTakeStageReward()
	{
		using (List<DailyActivityDefine.IActivityGoalData>.Enumerator enumerator = this.StageRewardDataList.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.State == EDailyActiveState.FinishedAndNotTaken)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x0600C93B RID: 51515 RVA: 0x002DED88 File Offset: 0x002DCF88
	public bool IsCollectAllStageReward()
	{
		using (List<DailyActivityDefine.IActivityGoalData>.Enumerator enumerator = this.StageRewardDataList.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.State != EDailyActiveState.FinishedAndTaken)
				{
					return false;
				}
			}
		}
		return true;
	}

	// Token: 0x0600C93C RID: 51516 RVA: 0x002DEDE4 File Offset: 0x002DCFE4
	public bool IsShowRecommendPlayPoint()
	{
		using (List<ExploreAreaItemData>.Enumerator enumerator = this.ExploreAreaItemDataList.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.IsShowRecommendPlayPoint)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x0600C93D RID: 51517 RVA: 0x002DEE40 File Offset: 0x002DD040
	public List<ExploreAreaItemData> GetRecommendExploreItemDataList(bool hasNumLimit = true)
	{
		List<ExploreAreaItemData> list = new List<ExploreAreaItemData>();
		foreach (ExploreAreaItemData exploreAreaItemData in this.ExploreAreaItemDataList)
		{
			if (exploreAreaItemData.IsShowRecommendPlayPoint)
			{
				list.Add(exploreAreaItemData);
				if (hasNumLimit && list.Count >= 2)
				{
					break;
				}
			}
		}
		return list;
	}

	// Token: 0x0600C93E RID: 51518 RVA: 0x002DEEB0 File Offset: 0x002DD0B0
	public List<ExploreAreaItemData> GetShowRecommendExploreItemDataList()
	{
		List<ExploreAreaItemData> list = new List<ExploreAreaItemData>();
		List<ExploreAreaItemData> recommendExploreItemDataList = this.GetRecommendExploreItemDataList(true);
		Dictionary<int, AreaExplorePlayState> localAreaExplorePlayStateMap = this.GetLocalAreaExplorePlayStateMap();
		foreach (ExploreAreaItemData exploreAreaItemData in recommendExploreItemDataList)
		{
			AreaExplorePlayState areaExplorePlayState;
			if (localAreaExplorePlayStateMap.TryGetValue((int)exploreAreaItemData.ExploreType, out areaExplorePlayState))
			{
				List<IExplorePlayProgressItemData> playProgressDataList = exploreAreaItemData.PlayProgressDataList;
				int num = Math.Min(playProgressDataList.Count, areaExplorePlayState.PlayPointStateList.Count);
				for (int i = 0; i < num; i++)
				{
					IExplorePlayProgressItemData explorePlayProgressItemData = playProgressDataList[i];
					EPlayPointState eplayPointState = areaExplorePlayState.PlayPointStateList[i];
					bool flag = eplayPointState == EPlayPointState.Locked;
					bool flag2 = explorePlayProgressItemData.PlayPointState == EPlayPointState.ToBeCompleted;
					if (flag && flag2)
					{
						explorePlayProgressItemData.LastPlayPointState = new EPlayPointState?(eplayPointState);
					}
				}
				localAreaExplorePlayStateMap.Remove((int)exploreAreaItemData.ExploreType);
			}
			else
			{
				exploreAreaItemData.IsNewRecommendPlay = true;
			}
			list.Add(exploreAreaItemData);
		}
		foreach (KeyValuePair<int, AreaExplorePlayState> keyValuePair in localAreaExplorePlayStateMap)
		{
			int key = keyValuePair.Key;
			AreaExplorePlayState value = keyValuePair.Value;
			ExploreAreaItemData exploreAreaItemData2;
			if (this.ExploreAreaItemDataMap.TryGetValue((EExploreType)key, out exploreAreaItemData2))
			{
				if (!exploreAreaItemData2.IsFinishedPlayPoint)
				{
					this.LogUnFinishLocalExploreItemData(value);
				}
				else
				{
					list.Add(exploreAreaItemData2);
				}
			}
			else
			{
				this.LogNotLocalExploreItemData(value);
			}
		}
		this.SortExploreAreaItemDataList(list);
		List<ExploreAreaItemData> list2 = new List<ExploreAreaItemData>();
		List<ExploreAreaItemData> list3 = new List<ExploreAreaItemData>();
		foreach (ExploreAreaItemData exploreAreaItemData3 in list)
		{
			if (exploreAreaItemData3.IsFinishedPlayPoint)
			{
				list2.Add(exploreAreaItemData3);
			}
			else if (exploreAreaItemData3.IsNewRecommendPlay)
			{
				list3.Add(exploreAreaItemData3);
			}
			else
			{
				for (int j = 0; j < list3.Count; j++)
				{
					ExploreAreaItemData exploreAreaItemData4 = list3[j];
					if (j < list2.Count)
					{
						list2[j].SetSequenceData(exploreAreaItemData4);
						exploreAreaItemData4.SetFlagSequenceData(true);
					}
				}
				list3.Clear();
				list2.Clear();
			}
		}
		List<ExploreAreaItemData> list4 = new List<ExploreAreaItemData>();
		foreach (ExploreAreaItemData exploreAreaItemData5 in list)
		{
			if (!exploreAreaItemData5.GetFlagSequenceDataAndClean())
			{
				list4.Add(exploreAreaItemData5);
			}
		}
		return list4;
	}

	// Token: 0x0600C93F RID: 51519 RVA: 0x002DF14C File Offset: 0x002DD34C
	public void UpdatePlayPointData(Dictionary<int, LevelPlayStateMsg> idMap)
	{
		this.LogExploreAreaItemTypeInfo();
		foreach (KeyValuePair<int, List<int>> keyValuePair in this.GetExploreTypeMapByIdMap(idMap))
		{
			int key = keyValuePair.Key;
			List<int> value = keyValuePair.Value;
			ExploreAreaItemData exploreAreaItemData;
			if (this.ExploreAreaItemDataMap.TryGetValue((EExploreType)key, out exploreAreaItemData))
			{
				exploreAreaItemData.ClearPlayPointData();
				foreach (int num in value)
				{
					LevelPlayStateMsg levelPlayStateMsg;
					if (idMap.TryGetValue(num, out levelPlayStateMsg))
					{
						int num2 = num;
						EPlayPointState playPointState = this.GetPlayPointState(num2, levelPlayStateMsg, exploreAreaItemData);
						exploreAreaItemData.AddPlayPointData(new PlayPointInfo
						{
							PlayId = num2,
							EntityId = levelPlayStateMsg.LevelPlayEntityId,
							PlayState = playPointState,
							IsClear = new bool?(levelPlayStateMsg.HideGroupInfo != null && levelPlayStateMsg.HideGroupInfo.Length > 0),
							ClearInfo = levelPlayStateMsg.HideGroupInfo,
							LevelPlayMarkUnlock = new bool?(levelPlayStateMsg.LevelPlayMarkUnlock),
							IsUnlock = levelPlayStateMsg.IsUnlock
						});
					}
				}
				exploreAreaItemData.PlayPointDataAddFinish();
			}
		}
		this.FlagUpdatePlayPointData = true;
		EventSystem.Instance.Emit<int>(EEventName.AreaPlayPointUpdate, this.AreaId);
	}

	// Token: 0x0600C940 RID: 51520 RVA: 0x002DF2E8 File Offset: 0x002DD4E8
	public void UpdateTraceEntities(int exploratoryDegree, int[] entities)
	{
		int key;
		ExploreAreaItemData exploreAreaItemData;
		if (this.ExploreAreaItemSubTypeMap.TryGetValue(exploratoryDegree, out key) && this.ExploreAreaItemDataMap.TryGetValue((EExploreType)key, out exploreAreaItemData))
		{
			exploreAreaItemData.SetEntityList(entities);
		}
	}

	// Token: 0x0600C941 RID: 51521 RVA: 0x002DF31C File Offset: 0x002DD51C
	private EPlayPointState GetPlayPointState(int playIdNum, LevelPlayStateMsg playData, ExploreAreaItemData itemData)
	{
		EPlayPointState eplayPointState = ServerPlayState2Client.Map[playData.StateType];
		if (eplayPointState == EPlayPointState.Completed)
		{
			return eplayPointState;
		}
		if (playData.CompleteNumber > 0)
		{
			MapMark? mapMarkByPlayId = itemData.GetMapMarkByPlayId(playIdNum);
			if (mapMarkByPlayId != null && mapMarkByPlayId.GetValueOrDefault().HistoryState == 1)
			{
				return EPlayPointState.Completed;
			}
		}
		if (eplayPointState == EPlayPointState.Locked)
		{
			MapMark? mapMarkByPlayId2 = itemData.GetMapMarkByPlayId(playIdNum);
			if (mapMarkByPlayId2 != null && MapModel.Instance.IsConfigMarkIdUnlock(mapMarkByPlayId2.Value.MarkId))
			{
				return EPlayPointState.ToBeCompleted;
			}
		}
		return eplayPointState;
	}

	// Token: 0x0600C942 RID: 51522 RVA: 0x002DF3A8 File Offset: 0x002DD5A8
	private Dictionary<int, List<int>> GetExploreTypeMapByIdMap(Dictionary<int, LevelPlayStateMsg> idMap)
	{
		Dictionary<int, List<int>> dictionary = new Dictionary<int, List<int>>();
		foreach (KeyValuePair<int, LevelPlayStateMsg> keyValuePair in idMap)
		{
			int key = keyValuePair.Key;
			LevelPlayStateMsg value = keyValuePair.Value;
			int key2;
			if (this.ExploreAreaItemSubTypeMap.TryGetValue(value.ExploratoryType, out key2))
			{
				if (!dictionary.ContainsKey(key2))
				{
					dictionary[key2] = new List<int>();
				}
				dictionary[key2].Add(key);
			}
		}
		return dictionary;
	}

	// Token: 0x0600C943 RID: 51523 RVA: 0x002DF444 File Offset: 0x002DD644
	[Conditional("UE_BUILD_SHIPPING")]
	public void LogExploreAreaItemTypeInfo()
	{
		foreach (ExploreAreaItemData exploreAreaItemData in this.ExploreAreaItemDataList)
		{
		}
	}

	// Token: 0x0600C944 RID: 51524 RVA: 0x002DF490 File Offset: 0x002DD690
	public UniTask CheckUpdatePlayPointData()
	{
		ExploreAreaData.<CheckUpdatePlayPointData>d__49 <CheckUpdatePlayPointData>d__;
		<CheckUpdatePlayPointData>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CheckUpdatePlayPointData>d__.<>4__this = this;
		<CheckUpdatePlayPointData>d__.<>1__state = -1;
		<CheckUpdatePlayPointData>d__.<>t__builder.Start<ExploreAreaData.<CheckUpdatePlayPointData>d__49>(ref <CheckUpdatePlayPointData>d__);
		return <CheckUpdatePlayPointData>d__.<>t__builder.Task;
	}

	// Token: 0x0600C945 RID: 51525 RVA: 0x002DF4D3 File Offset: 0x002DD6D3
	public void ClearFlagUpdatePlayPointData()
	{
		this.FlagUpdatePlayPointData = false;
	}

	// Token: 0x0600C946 RID: 51526 RVA: 0x002DF4DC File Offset: 0x002DD6DC
	public UniTask RequestPlayPointData()
	{
		ExploreAreaData.<RequestPlayPointData>d__51 <RequestPlayPointData>d__;
		<RequestPlayPointData>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestPlayPointData>d__.<>4__this = this;
		<RequestPlayPointData>d__.<>1__state = -1;
		<RequestPlayPointData>d__.<>t__builder.Start<ExploreAreaData.<RequestPlayPointData>d__51>(ref <RequestPlayPointData>d__);
		return <RequestPlayPointData>d__.<>t__builder.Task;
	}

	// Token: 0x0600C947 RID: 51527 RVA: 0x002DF51F File Offset: 0x002DD71F
	public int GetSceneId()
	{
		return this.MapId;
	}

	// Token: 0x0600C948 RID: 51528 RVA: 0x002DF528 File Offset: 0x002DD728
	public List<IMapExploreStoryItemData> GetStoryList()
	{
		int progress = this.GetProgress();
		float localAreaStoryProgress = this.GetLocalAreaStoryProgress();
		IReadOnlyList<AreaReport> storyList = AreaConfig.Instance.GetStoryList(this.AreaId);
		List<IMapExploreStoryItemData> list = new List<IMapExploreStoryItemData>();
		if (storyList == null)
		{
			return list;
		}
		foreach (AreaReport areaReport in storyList)
		{
			MapExploreStoryItemData mapExploreStoryItemData = new MapExploreStoryItemData
			{
				IsOpen = (progress >= areaReport.Unlock)
			};
			if (mapExploreStoryItemData.IsOpen)
			{
				mapExploreStoryItemData.StoryContent = areaReport.Content;
				mapExploreStoryItemData.StoryTitle = areaReport.StageTitle;
			}
			mapExploreStoryItemData.LockedDesc = areaReport.LockText;
			mapExploreStoryItemData.IsNewOpen = new bool?(mapExploreStoryItemData.IsOpen && (float)areaReport.Unlock > localAreaStoryProgress);
			list.Add(mapExploreStoryItemData);
		}
		return list;
	}

	// Token: 0x0600C949 RID: 51529 RVA: 0x002DF618 File Offset: 0x002DD818
	public float GetStoryProgress(bool isPercentage = false)
	{
		IReadOnlyList<AreaReport> storyList = AreaConfig.Instance.GetStoryList(this.AreaId);
		if (storyList == null)
		{
			return 0f;
		}
		int num = isPercentage ? 100 : 1;
		int progress = this.GetProgress();
		int num2;
		if (storyList.Count <= 0)
		{
			num2 = this.MaxExploreProgress;
		}
		else
		{
			IReadOnlyList<AreaReport> readOnlyList = storyList;
			num2 = readOnlyList[readOnlyList.Count - 1].Unlock;
		}
		int num3 = num2;
		int num4 = num3;
		for (int i = 0; i < storyList.Count; i++)
		{
			if (storyList[i].Unlock > progress)
			{
				num4 = ((i > 0) ? storyList[i - 1].Unlock : 0);
				break;
			}
		}
		return (float)num4 / (float)num3 * (float)num;
	}

	// Token: 0x0600C94A RID: 51530 RVA: 0x002DF6CC File Offset: 0x002DD8CC
	public bool HasNewStoryUnlocked()
	{
		if (AreaConfig.Instance.GetStoryList(this.AreaId) == null)
		{
			return false;
		}
		float localAreaStoryProgress = this.GetLocalAreaStoryProgress();
		if (this.GetStoryProgress(true) > localAreaStoryProgress)
		{
			this.FlagSaveLocalAreaStoryProgress = true;
			return true;
		}
		return false;
	}

	// Token: 0x0600C94B RID: 51531 RVA: 0x002DF708 File Offset: 0x002DD908
	public float GetLocalAreaStoryProgress()
	{
		return (LocalStorage.GetGlobal<Dictionary<int, float>>(ELocalStorageGlobalKey.AreaStoryProgress, null) ?? new Dictionary<int, float>()).GetValueOrDefault(this.AreaId, 0f);
	}

	// Token: 0x0600C94C RID: 51532 RVA: 0x002DF72C File Offset: 0x002DD92C
	public bool SaveLocalAreaStoryProgress()
	{
		if (!this.FlagSaveLocalAreaStoryProgress)
		{
			return false;
		}
		Dictionary<int, float> dictionary = LocalStorage.GetGlobal<Dictionary<int, float>>(ELocalStorageGlobalKey.AreaStoryProgress, null) ?? new Dictionary<int, float>();
		dictionary[this.AreaId] = this.GetStoryProgress(true);
		LocalStorage.SetGlobal<Dictionary<int, float>>(ELocalStorageGlobalKey.AreaStoryProgress, dictionary);
		this.FlagSaveLocalAreaStoryProgress = true;
		EventSystem.Instance.Emit(EEventName.AreaStoryProgressSave);
		return true;
	}

	// Token: 0x0600C94D RID: 51533 RVA: 0x002DF789 File Offset: 0x002DD989
	private int GetIconPercentIndex()
	{
		return (int)((float)this.GetProgress() / 25f);
	}

	// Token: 0x0600C94E RID: 51534 RVA: 0x002DF79C File Offset: 0x002DD99C
	public IMapAreaOnlyShowItemData GetIconPercentData(ELocalStorageGlobalKey key)
	{
		int iconPercentIndex = this.GetIconPercentIndex();
		int num = Math.Min(iconPercentIndex, this.GetLocalIconPercent(key));
		int openCount = num;
		int num2 = Math.Max(0, iconPercentIndex - num);
		if (num2 > 0)
		{
			this.FlagSaveLocalIconPercent[key] = true;
		}
		return new MapAreaOnlyShowItemData
		{
			OpenCount = openCount,
			NewOpenCount = num2,
			IconPath = this.PreviewImage
		};
	}

	// Token: 0x0600C94F RID: 51535 RVA: 0x002DF7FA File Offset: 0x002DD9FA
	public IMapAreaOnlyShowItemData GetIconPercentDataAreaShow()
	{
		return this.GetIconPercentData(ELocalStorageGlobalKey.IconPercentAreaShow);
	}

	// Token: 0x0600C950 RID: 51536 RVA: 0x002DF807 File Offset: 0x002DDA07
	public void SaveLocalIconPercentAreaShow()
	{
		this.SaveLocalIconPercent(ELocalStorageGlobalKey.IconPercentAreaShow);
	}

	// Token: 0x0600C951 RID: 51537 RVA: 0x002DF814 File Offset: 0x002DDA14
	public IMapAreaOnlyShowItemData GetIconPercentDataAreaStory()
	{
		return this.GetIconPercentData(ELocalStorageGlobalKey.IconPercentAreaStory);
	}

	// Token: 0x0600C952 RID: 51538 RVA: 0x002DF821 File Offset: 0x002DDA21
	public void SaveLocalIconPercentAreaStory()
	{
		this.SaveLocalIconPercent(ELocalStorageGlobalKey.IconPercentAreaStory);
	}

	// Token: 0x0600C953 RID: 51539 RVA: 0x002DF82E File Offset: 0x002DDA2E
	private int GetLocalIconPercent(ELocalStorageGlobalKey key)
	{
		return (LocalStorage.GetGlobal<Dictionary<int, int>>(key, null) ?? new Dictionary<int, int>()).GetValueOrDefault(this.AreaId, 0);
	}

	// Token: 0x0600C954 RID: 51540 RVA: 0x002DF84C File Offset: 0x002DDA4C
	private void SaveLocalIconPercent(ELocalStorageGlobalKey key)
	{
		if (!this.FlagSaveLocalIconPercent[key])
		{
			return;
		}
		Dictionary<int, int> dictionary = LocalStorage.GetGlobal<Dictionary<int, int>>(key, null) ?? new Dictionary<int, int>();
		dictionary[this.AreaId] = this.GetIconPercentIndex();
		LocalStorage.SetGlobal<Dictionary<int, int>>(key, dictionary);
		this.FlagSaveLocalIconPercent[key] = false;
	}

	// Token: 0x0600C955 RID: 51541 RVA: 0x002DF8A0 File Offset: 0x002DDAA0
	public string GetStoryViewTitle()
	{
		string text = "AreaReportName_Text";
		string nameId = this.GetNameId();
		string multiTextByKey = TextConfig.Instance.GetMultiTextByKey(text, text);
		string multiTextByKey2 = TextConfig.Instance.GetMultiTextByKey(nameId, nameId);
		return StringUtils.Format(multiTextByKey, new string[]
		{
			multiTextByKey2
		});
	}

	// Token: 0x0600C956 RID: 51542 RVA: 0x002DF8E4 File Offset: 0x002DDAE4
	public void SaveLocalAreaExplorePlayState()
	{
		if (this.FlagSaveLocalAreaExplorePlayState)
		{
			return;
		}
		if (!this.IsShowRecommendPlayPoint())
		{
			return;
		}
		Dictionary<int, Dictionary<int, AreaExplorePlayState>> dictionary = LocalStorage.GetGlobal<Dictionary<int, Dictionary<int, AreaExplorePlayState>>>(ELocalStorageGlobalKey.AreaExplorePlayState, null) ?? new Dictionary<int, Dictionary<int, AreaExplorePlayState>>();
		dictionary[this.AreaId] = this.GetAreaExplorePlayStateMap();
		LocalStorage.SetGlobal<Dictionary<int, Dictionary<int, AreaExplorePlayState>>>(ELocalStorageGlobalKey.AreaExplorePlayState, dictionary);
		this.FlagSaveLocalAreaExplorePlayState = true;
	}

	// Token: 0x0600C957 RID: 51543 RVA: 0x002DF93D File Offset: 0x002DDB3D
	public void ClearFlagSaveLocalAreaExplorePlayState()
	{
		this.FlagSaveLocalAreaExplorePlayState = false;
	}

	// Token: 0x0600C958 RID: 51544 RVA: 0x002DF946 File Offset: 0x002DDB46
	public void ClearLocalAreaExplorePlayState()
	{
		LocalStorage.SetGlobal<Dictionary<int, Dictionary<int, AreaExplorePlayState>>>(ELocalStorageGlobalKey.AreaExplorePlayState, new Dictionary<int, Dictionary<int, AreaExplorePlayState>>());
	}

	// Token: 0x0600C959 RID: 51545 RVA: 0x002DF958 File Offset: 0x002DDB58
	private Dictionary<int, AreaExplorePlayState> GetAreaExplorePlayStateMap()
	{
		Dictionary<int, AreaExplorePlayState> dictionary = new Dictionary<int, AreaExplorePlayState>();
		foreach (ExploreAreaItemData exploreAreaItemData in this.GetRecommendExploreItemDataList(true))
		{
			AreaExplorePlayState value = new AreaExplorePlayState
			{
				ExploreType = exploreAreaItemData.ExploreType,
				PlayPointStateList = exploreAreaItemData.GetPlayPointStateList().ToList<EPlayPointState>()
			};
			dictionary[(int)exploreAreaItemData.ExploreType] = value;
		}
		return dictionary;
	}

	// Token: 0x0600C95A RID: 51546 RVA: 0x002DF9DC File Offset: 0x002DDBDC
	public Dictionary<int, AreaExplorePlayState> GetLocalAreaExplorePlayStateMap()
	{
		Dictionary<int, AreaExplorePlayState> result;
		if ((LocalStorage.GetGlobal<Dictionary<int, Dictionary<int, AreaExplorePlayState>>>(ELocalStorageGlobalKey.AreaExplorePlayState, null) ?? new Dictionary<int, Dictionary<int, AreaExplorePlayState>>()).TryGetValue(this.AreaId, out result))
		{
			return result;
		}
		return new Dictionary<int, AreaExplorePlayState>();
	}

	// Token: 0x0600C95B RID: 51547 RVA: 0x002DFA13 File Offset: 0x002DDC13
	[Conditional("DEBUG")]
	public void LogInfo()
	{
	}

	// Token: 0x0600C95C RID: 51548 RVA: 0x002DFA18 File Offset: 0x002DDC18
	public List<ExploreAreaItemData> GetLocalFinishRecommendExploreItems()
	{
		if (this.IsShowRecommendPlayPoint())
		{
			return new List<ExploreAreaItemData>();
		}
		Dictionary<int, AreaExplorePlayState> localAreaExplorePlayStateMap = this.GetLocalAreaExplorePlayStateMap();
		List<ExploreAreaItemData> list = new List<ExploreAreaItemData>();
		foreach (KeyValuePair<int, AreaExplorePlayState> keyValuePair in localAreaExplorePlayStateMap)
		{
			AreaExplorePlayState value = keyValuePair.Value;
			ExploreAreaItemData item;
			if (this.ExploreAreaItemDataMap.TryGetValue(value.ExploreType, out item))
			{
				list.Add(item);
			}
			else
			{
				this.LogNotLocalExploreItemData(value);
			}
		}
		return list;
	}

	// Token: 0x0600C95D RID: 51549 RVA: 0x002DFAA8 File Offset: 0x002DDCA8
	[Conditional("UE_BUILD_SHIPPING")]
	private void LogNotLocalExploreItemData(IAreaExplorePlayState data)
	{
	}

	// Token: 0x0600C95E RID: 51550 RVA: 0x002DFAAA File Offset: 0x002DDCAA
	[Conditional("UE_BUILD_SHIPPING")]
	private void LogUnFinishLocalExploreItemData(IAreaExplorePlayState data)
	{
	}

	// Token: 0x0600C95F RID: 51551 RVA: 0x002DFAAC File Offset: 0x002DDCAC
	public ExploreAreaData()
	{
		Dictionary<ELocalStorageGlobalKey, bool> dictionary = new Dictionary<ELocalStorageGlobalKey, bool>();
		dictionary[ELocalStorageGlobalKey.IconPercentAreaShow] = false;
		dictionary[ELocalStorageGlobalKey.IconPercentAreaStory] = false;
		this.FlagSaveLocalIconPercent = dictionary;
		this.PreviewImage = "";
		base..ctor();
	}

	// Token: 0x04005C9F RID: 23711
	public int AreaId;

	// Token: 0x04005CA0 RID: 23712
	public int CountryId;

	// Token: 0x04005CA1 RID: 23713
	public int StateId;

	// Token: 0x04005CA2 RID: 23714
	public int MapId;

	// Token: 0x04005CA3 RID: 23715
	private int ExploreProgress;

	// Token: 0x04005CA4 RID: 23716
	private int NextStageNeedProgress = 1;

	// Token: 0x04005CA5 RID: 23717
	public readonly int MaxExploreProgress = 100;

	// Token: 0x04005CA6 RID: 23718
	private readonly Dictionary<EExploreType, ExploreAreaItemData> ExploreAreaItemDataMap = new Dictionary<EExploreType, ExploreAreaItemData>();

	// Token: 0x04005CA7 RID: 23719
	private readonly List<ExploreAreaItemData> ExploreAreaItemDataList = new List<ExploreAreaItemData>();

	// Token: 0x04005CA8 RID: 23720
	private readonly Dictionary<int, int> ExploreAreaItemSubTypeMap = new Dictionary<int, int>();

	// Token: 0x04005CA9 RID: 23721
	private string TitleId = "";

	// Token: 0x04005CAA RID: 23722
	private int AreaSortIndex;

	// Token: 0x04005CAB RID: 23723
	private readonly List<DailyActivityDefine.IActivityGoalData> StageRewardDataList = new List<DailyActivityDefine.IActivityGoalData>();

	// Token: 0x04005CAC RID: 23724
	private readonly Dictionary<int, DailyActivityDefine.IActivityGoalData> StageRewardDataMap = new Dictionary<int, DailyActivityDefine.IActivityGoalData>();

	// Token: 0x04005CAD RID: 23725
	private bool FlagUpdatePlayPointData;

	// Token: 0x04005CAE RID: 23726
	private bool FlagSaveLocalAreaStoryProgress;

	// Token: 0x04005CAF RID: 23727
	private readonly Dictionary<ELocalStorageGlobalKey, bool> FlagSaveLocalIconPercent;

	// Token: 0x04005CB0 RID: 23728
	private bool FlagSaveLocalAreaExplorePlayState;

	// Token: 0x04005CB1 RID: 23729
	public string PreviewImage;
}
