using System;
using System.Collections.Generic;
using System.Diagnostics;
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

// Token: 0x02000F57 RID: 3927
[NullableContext(1)]
[Nullable(0)]
public class ExploreAreaData
{
	// Token: 0x1700109F RID: 4255
	// (get) Token: 0x06009D38 RID: 40248 RVA: 0x002E98F9 File Offset: 0x002E7AF9
	public bool IsReachMaxProgress
	{
		get
		{
			return this.ExploreProgress >= this.MaxExploreProgress;
		}
	}

	// Token: 0x06009D39 RID: 40249 RVA: 0x002E990C File Offset: 0x002E7B0C
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

	// Token: 0x06009D3A RID: 40250 RVA: 0x002E99D4 File Offset: 0x002E7BD4
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

	// Token: 0x06009D3B RID: 40251 RVA: 0x002E9A68 File Offset: 0x002E7C68
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

	// Token: 0x06009D3C RID: 40252 RVA: 0x002E9C08 File Offset: 0x002E7E08
	public void Clear()
	{
		this.AreaId = 0;
		this.ExploreProgress = 0;
		this.NextStageNeedProgress = 1;
		this.ExploreAreaItemDataMap.Clear();
	}

	// Token: 0x06009D3D RID: 40253 RVA: 0x002E9C2C File Offset: 0x002E7E2C
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

	// Token: 0x06009D3E RID: 40254 RVA: 0x002E9C76 File Offset: 0x002E7E76
	public void AddExploreAreaItemDataFinish()
	{
		this.SortExploreAreaItemDataList(this.ExploreAreaItemDataList);
		this.UpdateExploreAreaItemSubType();
	}

	// Token: 0x06009D3F RID: 40255 RVA: 0x002E9C8A File Offset: 0x002E7E8A
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

	// Token: 0x06009D40 RID: 40256 RVA: 0x002E9CB4 File Offset: 0x002E7EB4
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

	// Token: 0x06009D41 RID: 40257 RVA: 0x002E9D38 File Offset: 0x002E7F38
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

	// Token: 0x06009D42 RID: 40258 RVA: 0x002E9DD4 File Offset: 0x002E7FD4
	[NullableContext(2)]
	public ExploreAreaItemData GetExploreAreaItemData(EExploreType exploreType)
	{
		ExploreAreaItemData result;
		this.ExploreAreaItemDataMap.TryGetValue(exploreType, out result);
		return result;
	}

	// Token: 0x06009D43 RID: 40259 RVA: 0x002E9DF1 File Offset: 0x002E7FF1
	public List<ExploreAreaItemData> GetAllExploreAreaItemData()
	{
		return this.ExploreAreaItemDataList;
	}

	// Token: 0x06009D44 RID: 40260 RVA: 0x002E9DF9 File Offset: 0x002E7FF9
	public int GetProgress()
	{
		return this.ExploreProgress;
	}

	// Token: 0x06009D45 RID: 40261 RVA: 0x002E9E01 File Offset: 0x002E8001
	public string GetNameId()
	{
		return this.TitleId;
	}

	// Token: 0x06009D46 RID: 40262 RVA: 0x002E9E09 File Offset: 0x002E8009
	public int GetSortIndex()
	{
		return this.AreaSortIndex;
	}

	// Token: 0x06009D47 RID: 40263 RVA: 0x002E9E11 File Offset: 0x002E8011
	public int GetNextStageNeedProgress()
	{
		return this.NextStageNeedProgress;
	}

	// Token: 0x06009D48 RID: 40264 RVA: 0x002E9E1C File Offset: 0x002E801C
	public float GetStageProgress(bool isPercentage = false)
	{
		int num = isPercentage ? 100 : 1;
		return (float)this.GetProgress() / (float)this.GetNextStageNeedProgress() * (float)num;
	}

	// Token: 0x06009D49 RID: 40265 RVA: 0x002E9E44 File Offset: 0x002E8044
	public List<DailyActivityDefine.IActivityGoalData> GetStageRewardDataList()
	{
		return this.StageRewardDataList;
	}

	// Token: 0x06009D4A RID: 40266 RVA: 0x002E9E4C File Offset: 0x002E804C
	public void UpdateAchievedStageReward(int rewardId)
	{
		DailyActivityDefine.IActivityGoalData activityGoalData;
		if (this.StageRewardDataMap.TryGetValue(rewardId, out activityGoalData))
		{
			activityGoalData.Achieved = true;
			activityGoalData.State = EDailyActiveState.FinishedAndTaken;
		}
	}

	// Token: 0x06009D4B RID: 40267 RVA: 0x002E9E78 File Offset: 0x002E8078
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

	// Token: 0x06009D4C RID: 40268 RVA: 0x002E9ED4 File Offset: 0x002E80D4
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

	// Token: 0x06009D4D RID: 40269 RVA: 0x002E9F30 File Offset: 0x002E8130
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

	// Token: 0x06009D4E RID: 40270 RVA: 0x002E9F8C File Offset: 0x002E818C
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

	// Token: 0x06009D4F RID: 40271 RVA: 0x002E9FFC File Offset: 0x002E81FC
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

	// Token: 0x06009D50 RID: 40272 RVA: 0x002EA298 File Offset: 0x002E8498
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

	// Token: 0x06009D51 RID: 40273 RVA: 0x002EA434 File Offset: 0x002E8634
	public void UpdateTraceEntities(int exploratoryDegree, int[] entities)
	{
		int key;
		ExploreAreaItemData exploreAreaItemData;
		if (this.ExploreAreaItemSubTypeMap.TryGetValue(exploratoryDegree, out key) && this.ExploreAreaItemDataMap.TryGetValue((EExploreType)key, out exploreAreaItemData))
		{
			exploreAreaItemData.SetEntityList(entities);
		}
	}

	// Token: 0x06009D52 RID: 40274 RVA: 0x002EA468 File Offset: 0x002E8668
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

	// Token: 0x06009D53 RID: 40275 RVA: 0x002EA4F4 File Offset: 0x002E86F4
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

	// Token: 0x06009D54 RID: 40276 RVA: 0x002EA590 File Offset: 0x002E8790
	[Conditional("UE_BUILD_SHIPPING")]
	public void LogExploreAreaItemTypeInfo()
	{
		foreach (ExploreAreaItemData exploreAreaItemData in this.ExploreAreaItemDataList)
		{
		}
	}

	// Token: 0x06009D55 RID: 40277 RVA: 0x002EA5DC File Offset: 0x002E87DC
	public UniTask CheckUpdatePlayPointData()
	{
		ExploreAreaData.<CheckUpdatePlayPointData>d__49 <CheckUpdatePlayPointData>d__;
		<CheckUpdatePlayPointData>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CheckUpdatePlayPointData>d__.<>4__this = this;
		<CheckUpdatePlayPointData>d__.<>1__state = -1;
		<CheckUpdatePlayPointData>d__.<>t__builder.Start<ExploreAreaData.<CheckUpdatePlayPointData>d__49>(ref <CheckUpdatePlayPointData>d__);
		return <CheckUpdatePlayPointData>d__.<>t__builder.Task;
	}

	// Token: 0x06009D56 RID: 40278 RVA: 0x002EA61F File Offset: 0x002E881F
	public void ClearFlagUpdatePlayPointData()
	{
		this.FlagUpdatePlayPointData = false;
	}

	// Token: 0x06009D57 RID: 40279 RVA: 0x002EA628 File Offset: 0x002E8828
	public UniTask RequestPlayPointData()
	{
		ExploreAreaData.<RequestPlayPointData>d__51 <RequestPlayPointData>d__;
		<RequestPlayPointData>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestPlayPointData>d__.<>4__this = this;
		<RequestPlayPointData>d__.<>1__state = -1;
		<RequestPlayPointData>d__.<>t__builder.Start<ExploreAreaData.<RequestPlayPointData>d__51>(ref <RequestPlayPointData>d__);
		return <RequestPlayPointData>d__.<>t__builder.Task;
	}

	// Token: 0x06009D58 RID: 40280 RVA: 0x002EA66B File Offset: 0x002E886B
	public int GetSceneId()
	{
		return this.MapId;
	}

	// Token: 0x06009D59 RID: 40281 RVA: 0x002EA674 File Offset: 0x002E8874
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

	// Token: 0x06009D5A RID: 40282 RVA: 0x002EA764 File Offset: 0x002E8964
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

	// Token: 0x06009D5B RID: 40283 RVA: 0x002EA818 File Offset: 0x002E8A18
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

	// Token: 0x06009D5C RID: 40284 RVA: 0x002EA854 File Offset: 0x002E8A54
	public float GetLocalAreaStoryProgress()
	{
		return (LocalStorage.GetGlobal<Dictionary<int, float>>(ELocalStorageGlobalKey.AreaStoryProgress, null) ?? new Dictionary<int, float>()).GetValueOrDefault(this.AreaId, 0f);
	}

	// Token: 0x06009D5D RID: 40285 RVA: 0x002EA878 File Offset: 0x002E8A78
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

	// Token: 0x06009D5E RID: 40286 RVA: 0x002EA8D5 File Offset: 0x002E8AD5
	private int GetIconPercentIndex()
	{
		return (int)((float)this.GetProgress() / 25f);
	}

	// Token: 0x06009D5F RID: 40287 RVA: 0x002EA8E8 File Offset: 0x002E8AE8
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

	// Token: 0x06009D60 RID: 40288 RVA: 0x002EA946 File Offset: 0x002E8B46
	public IMapAreaOnlyShowItemData GetIconPercentDataAreaShow()
	{
		return this.GetIconPercentData(ELocalStorageGlobalKey.IconPercentAreaShow);
	}

	// Token: 0x06009D61 RID: 40289 RVA: 0x002EA953 File Offset: 0x002E8B53
	public void SaveLocalIconPercentAreaShow()
	{
		this.SaveLocalIconPercent(ELocalStorageGlobalKey.IconPercentAreaShow);
	}

	// Token: 0x06009D62 RID: 40290 RVA: 0x002EA960 File Offset: 0x002E8B60
	public IMapAreaOnlyShowItemData GetIconPercentDataAreaStory()
	{
		return this.GetIconPercentData(ELocalStorageGlobalKey.IconPercentAreaStory);
	}

	// Token: 0x06009D63 RID: 40291 RVA: 0x002EA96D File Offset: 0x002E8B6D
	public void SaveLocalIconPercentAreaStory()
	{
		this.SaveLocalIconPercent(ELocalStorageGlobalKey.IconPercentAreaStory);
	}

	// Token: 0x06009D64 RID: 40292 RVA: 0x002EA97A File Offset: 0x002E8B7A
	private int GetLocalIconPercent(ELocalStorageGlobalKey key)
	{
		return (LocalStorage.GetGlobal<Dictionary<int, int>>(key, null) ?? new Dictionary<int, int>()).GetValueOrDefault(this.AreaId, 0);
	}

	// Token: 0x06009D65 RID: 40293 RVA: 0x002EA998 File Offset: 0x002E8B98
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

	// Token: 0x06009D66 RID: 40294 RVA: 0x002EA9EC File Offset: 0x002E8BEC
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

	// Token: 0x06009D67 RID: 40295 RVA: 0x002EAA30 File Offset: 0x002E8C30
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

	// Token: 0x06009D68 RID: 40296 RVA: 0x002EAA89 File Offset: 0x002E8C89
	public void ClearFlagSaveLocalAreaExplorePlayState()
	{
		this.FlagSaveLocalAreaExplorePlayState = false;
	}

	// Token: 0x06009D69 RID: 40297 RVA: 0x002EAA92 File Offset: 0x002E8C92
	public void ClearLocalAreaExplorePlayState()
	{
		LocalStorage.SetGlobal<Dictionary<int, Dictionary<int, AreaExplorePlayState>>>(ELocalStorageGlobalKey.AreaExplorePlayState, new Dictionary<int, Dictionary<int, AreaExplorePlayState>>());
	}

	// Token: 0x06009D6A RID: 40298 RVA: 0x002EAAA4 File Offset: 0x002E8CA4
	private Dictionary<int, AreaExplorePlayState> GetAreaExplorePlayStateMap()
	{
		Dictionary<int, AreaExplorePlayState> dictionary = new Dictionary<int, AreaExplorePlayState>();
		foreach (ExploreAreaItemData exploreAreaItemData in this.GetRecommendExploreItemDataList(true))
		{
			AreaExplorePlayState value = new AreaExplorePlayState
			{
				ExploreType = exploreAreaItemData.ExploreType,
				PlayPointStateList = new List<EPlayPointState>(exploreAreaItemData.GetPlayPointStateList())
			};
			dictionary[(int)exploreAreaItemData.ExploreType] = value;
		}
		return dictionary;
	}

	// Token: 0x06009D6B RID: 40299 RVA: 0x002EAB28 File Offset: 0x002E8D28
	public Dictionary<int, AreaExplorePlayState> GetLocalAreaExplorePlayStateMap()
	{
		Dictionary<int, AreaExplorePlayState> result;
		if ((LocalStorage.GetGlobal<Dictionary<int, Dictionary<int, AreaExplorePlayState>>>(ELocalStorageGlobalKey.AreaExplorePlayState, null) ?? new Dictionary<int, Dictionary<int, AreaExplorePlayState>>()).TryGetValue(this.AreaId, out result))
		{
			return result;
		}
		return new Dictionary<int, AreaExplorePlayState>();
	}

	// Token: 0x06009D6C RID: 40300 RVA: 0x002EAB5F File Offset: 0x002E8D5F
	[Conditional("DEBUG")]
	public void LogInfo()
	{
	}

	// Token: 0x06009D6D RID: 40301 RVA: 0x002EAB64 File Offset: 0x002E8D64
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

	// Token: 0x06009D6E RID: 40302 RVA: 0x002EABF4 File Offset: 0x002E8DF4
	[Conditional("UE_BUILD_SHIPPING")]
	private void LogNotLocalExploreItemData(IAreaExplorePlayState data)
	{
	}

	// Token: 0x06009D6F RID: 40303 RVA: 0x002EABF6 File Offset: 0x002E8DF6
	[Conditional("UE_BUILD_SHIPPING")]
	private void LogUnFinishLocalExploreItemData(IAreaExplorePlayState data)
	{
	}

	// Token: 0x06009D70 RID: 40304 RVA: 0x002EABF8 File Offset: 0x002E8DF8
	public ExploreAreaData()
	{
		Dictionary<ELocalStorageGlobalKey, bool> dictionary = new Dictionary<ELocalStorageGlobalKey, bool>();
		dictionary[ELocalStorageGlobalKey.IconPercentAreaShow] = false;
		dictionary[ELocalStorageGlobalKey.IconPercentAreaStory] = false;
		this.FlagSaveLocalIconPercent = dictionary;
		this.PreviewImage = "";
		base..ctor();
	}

	// Token: 0x04005D6E RID: 23918
	public int AreaId;

	// Token: 0x04005D6F RID: 23919
	public int CountryId;

	// Token: 0x04005D70 RID: 23920
	public int StateId;

	// Token: 0x04005D71 RID: 23921
	public int MapId;

	// Token: 0x04005D72 RID: 23922
	private int ExploreProgress;

	// Token: 0x04005D73 RID: 23923
	private int NextStageNeedProgress = 1;

	// Token: 0x04005D74 RID: 23924
	public readonly int MaxExploreProgress = 100;

	// Token: 0x04005D75 RID: 23925
	private readonly Dictionary<EExploreType, ExploreAreaItemData> ExploreAreaItemDataMap = new Dictionary<EExploreType, ExploreAreaItemData>();

	// Token: 0x04005D76 RID: 23926
	private readonly List<ExploreAreaItemData> ExploreAreaItemDataList = new List<ExploreAreaItemData>();

	// Token: 0x04005D77 RID: 23927
	private readonly Dictionary<int, int> ExploreAreaItemSubTypeMap = new Dictionary<int, int>();

	// Token: 0x04005D78 RID: 23928
	private string TitleId = "";

	// Token: 0x04005D79 RID: 23929
	private int AreaSortIndex;

	// Token: 0x04005D7A RID: 23930
	private readonly List<DailyActivityDefine.IActivityGoalData> StageRewardDataList = new List<DailyActivityDefine.IActivityGoalData>();

	// Token: 0x04005D7B RID: 23931
	private readonly Dictionary<int, DailyActivityDefine.IActivityGoalData> StageRewardDataMap = new Dictionary<int, DailyActivityDefine.IActivityGoalData>();

	// Token: 0x04005D7C RID: 23932
	private bool FlagUpdatePlayPointData;

	// Token: 0x04005D7D RID: 23933
	private bool FlagSaveLocalAreaStoryProgress;

	// Token: 0x04005D7E RID: 23934
	private readonly Dictionary<ELocalStorageGlobalKey, bool> FlagSaveLocalIconPercent;

	// Token: 0x04005D7F RID: 23935
	private bool FlagSaveLocalAreaExplorePlayState;

	// Token: 0x04005D80 RID: 23936
	public string PreviewImage;
}
