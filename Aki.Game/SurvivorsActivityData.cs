using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RoleUi;

// Token: 0x02002AB8 RID: 10936
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsActivityData : ActivityBaseData
{
	// Token: 0x06016C50 RID: 93264 RVA: 0x005C7AD8 File Offset: 0x005C5CD8
	protected override void OnInit(ActivityData data)
	{
		SurvivorsActivityConfig? survivorsActivityConfigByActivityId = SurvivorsRogueConfig.Instance.GetSurvivorsActivityConfigByActivityId(base.Id);
		if (survivorsActivityConfigByActivityId == null)
		{
			return;
		}
		this.ActId = survivorsActivityConfigByActivityId.Value.Id;
		this.InitRewardTaskData();
		this.InitMilestoneReward();
		this.InitRole();
		this.InitWeapon();
		this.InitItem();
		this.InitTalentTree();
	}

	// Token: 0x06016C51 RID: 93265 RVA: 0x005C7B3C File Offset: 0x005C5D3C
	protected override void PhraseEx(ActivityData data)
	{
		if (this.CheckIfInShowTime())
		{
			SurvivorsRogueModel.Instance.SetCurrentActivityId(base.Id);
		}
		Aki.Protocol.SurvivorsActivityData survivorsActivityData = data.SurvivorsActivityData;
		if (survivorsActivityData == null)
		{
			return;
		}
		foreach (SurvivorsChallengeInfo survivorsChallengeInfo in survivorsActivityData.SurvivorsChallengeInfos)
		{
			this.LevelMap[survivorsChallengeInfo.LevelId] = survivorsChallengeInfo;
		}
		if (survivorsActivityData.NormalTaskData != null)
		{
			foreach (ActivityTask task in survivorsActivityData.NormalTaskData.ActivityTasks)
			{
				this.RefreshRewardTaskData(task);
			}
		}
		foreach (int milestoneRewardId in survivorsActivityData.ScoreTaskDatas)
		{
			this.RefreshGotMilestoneReward(milestoneRewardId);
		}
		foreach (int key in survivorsActivityData.UnlockRoleHandBooks)
		{
			this.RoleMap[key] = true;
		}
		foreach (int key2 in survivorsActivityData.UnlockWeaponHandBooks)
		{
			this.WeaponMap[key2] = true;
		}
		foreach (int key3 in survivorsActivityData.UnlockItemHandBooks)
		{
			this.ItemMap[key3] = true;
		}
		foreach (KeyValuePair<int, int> keyValuePair in survivorsActivityData.TalentSkillDict)
		{
			this.RefreshTalentTreeNode(keyValuePair.Key, keyValuePair.Value);
		}
	}

	// Token: 0x06016C52 RID: 93266 RVA: 0x005C7D70 File Offset: 0x005C5F70
	public override bool GetExDataRedPointShowState()
	{
		return this.GetActivityRedDotState();
	}

	// Token: 0x06016C53 RID: 93267 RVA: 0x005C7D78 File Offset: 0x005C5F78
	public bool GetActivityRedDotState()
	{
		return this.GetActivityUnlockRedDotState() || this.GetRewardRedDotState() || this.GetLevelUnlockRedDotState();
	}

	// Token: 0x06016C54 RID: 93268 RVA: 0x005C7D94 File Offset: 0x005C5F94
	public bool GetActivityUnlockRedDotState()
	{
		foreach (SurvivorsChallengeInfo survivorsChallengeInfo in this.LevelMap.Values)
		{
			ModeInfo normalModeInfos = survivorsChallengeInfo.NormalModeInfos;
			if (normalModeInfos != null && normalModeInfos.IsFinish)
			{
				return false;
			}
		}
		return ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 0, 0, 0) == 0;
	}

	// Token: 0x06016C55 RID: 93269 RVA: 0x005C7E14 File Offset: 0x005C6014
	public bool SaveCacheState(ESurvivorsActivitySaveFlags saveFlag, int key1, int key2 = 0, int saveValue = 1)
	{
		if (ActivityModel.Instance.GetActivityCacheData(base.Id, 0, (int)saveFlag, key1, key2) == saveValue)
		{
			return true;
		}
		ActivityModel.Instance.SaveActivityData(base.Id, (int)saveFlag, key1, key2, saveValue);
		return false;
	}

	// Token: 0x06016C56 RID: 93270 RVA: 0x005C7E48 File Offset: 0x005C6048
	public void RefreshActivityRedDot()
	{
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
	}

	// Token: 0x06016C57 RID: 93271 RVA: 0x005C7E60 File Offset: 0x005C6060
	public void OnQuestStateChange(int questId, QuestState state)
	{
		int[] preShowGuideQuestArray = this.LocalConfig.Value.GetPreShowGuideQuestArray();
		bool flag = false;
		for (int i = 0; i < preShowGuideQuestArray.Length; i++)
		{
			if (preShowGuideQuestArray[i] == questId)
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			return;
		}
		if (state < QuestState.Finish)
		{
			return;
		}
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
	}

	// Token: 0x17001E4D RID: 7757
	// (get) Token: 0x06016C58 RID: 93272 RVA: 0x005C7EBA File Offset: 0x005C60BA
	// (set) Token: 0x06016C59 RID: 93273 RVA: 0x005C7ED4 File Offset: 0x005C60D4
	public bool NotTipsEnterInst
	{
		get
		{
			return ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 6, 0, 0) == 1;
		}
		set
		{
			int saveValue = (value > false) ? 1 : 0;
			this.SaveCacheState(ESurvivorsActivitySaveFlags.NotTipsEnterInst, 0, 0, saveValue);
		}
	}

	// Token: 0x06016C5A RID: 93274 RVA: 0x005C7EF4 File Offset: 0x005C60F4
	private void InitRewardTaskData()
	{
		foreach (SurvivorsTask survivorsTask in SurvivorsRogueConfig.Instance.GetSurvivorsTaskByActId(this.ActId))
		{
			this.CreateRewardTaskData(survivorsTask.Id);
		}
	}

	// Token: 0x06016C5B RID: 93275 RVA: 0x005C7F54 File Offset: 0x005C6154
	public void RefreshRewardTaskData(ActivityTask task)
	{
		global::ActivityTaskData activityTaskData;
		this.RewardTaskMap.TryGetValue(task.Id, out activityTaskData);
		global::ActivityTaskData activityTaskData2;
		if (activityTaskData == null)
		{
			activityTaskData2 = this.CreateRewardTaskData(task.Id);
		}
		else
		{
			activityTaskData2 = activityTaskData;
		}
		activityTaskData2.Refresh(task, null);
	}

	// Token: 0x06016C5C RID: 93276 RVA: 0x005C7F94 File Offset: 0x005C6194
	private global::ActivityTaskData CreateRewardTaskData(int taskId)
	{
		global::ActivityTaskData activityTaskData = new global::ActivityTaskData();
		SurvivorsTask? survivorsTask = SurvivorsRogueConfig.Instance.GetSurvivorsTask(taskId);
		int num = (survivorsTask != null) ? survivorsTask.GetValueOrDefault().PageType : 0;
		activityTaskData.TypeId = num;
		activityTaskData.Id = taskId;
		this.RewardTaskMap[taskId] = activityTaskData;
		List<int> list;
		if (!this.RewardType2TaskIdList.TryGetValue(num, out list))
		{
			list = new List<int>();
			this.RewardType2TaskIdList[num] = list;
		}
		list.Add(taskId);
		return activityTaskData;
	}

	// Token: 0x06016C5D RID: 93277 RVA: 0x005C8016 File Offset: 0x005C6216
	public void SetRewardTaskDataDone(int taskId)
	{
		this.RewardTaskMap[taskId].Status = EActivityTaskState.FinishedAndClaimed;
	}

	// Token: 0x06016C5E RID: 93278 RVA: 0x005C802C File Offset: 0x005C622C
	public int GetFinishedRewardTaskCount()
	{
		int num = 0;
		using (Dictionary<int, global::ActivityTaskData>.ValueCollection.Enumerator enumerator = this.RewardTaskMap.Values.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.Status == EActivityTaskState.FinishedAndClaimed)
				{
					num++;
				}
			}
		}
		return num;
	}

	// Token: 0x06016C5F RID: 93279 RVA: 0x005C808C File Offset: 0x005C628C
	public List<global::ActivityTaskData> GetRewardTaskDataListByTypeId(int typeId)
	{
		List<global::ActivityTaskData> list = new List<global::ActivityTaskData>();
		List<int> list2;
		if (!this.RewardType2TaskIdList.TryGetValue(typeId, out list2))
		{
			return list;
		}
		foreach (int key in list2)
		{
			global::ActivityTaskData item = this.RewardTaskMap[key];
			list.Add(item);
		}
		List<global::ActivityTaskData> list3 = list;
		Comparison<global::ActivityTaskData> comparison;
		if ((comparison = global::SurvivorsActivityData.<>O.<0>__SortTaskData) == null)
		{
			comparison = (global::SurvivorsActivityData.<>O.<0>__SortTaskData = new Comparison<global::ActivityTaskData>(global::SurvivorsActivityData.SortTaskData));
		}
		list3.Sort(comparison);
		return list;
	}

	// Token: 0x06016C60 RID: 93280 RVA: 0x005C8124 File Offset: 0x005C6324
	public bool GetTypeRedDotState(int typeId)
	{
		List<int> list;
		if (!this.RewardType2TaskIdList.TryGetValue(typeId, out list))
		{
			return false;
		}
		foreach (int key in list)
		{
			if (this.RewardTaskMap[key].Status == EActivityTaskState.FinishedAndUnclaimed)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06016C61 RID: 93281 RVA: 0x005C8198 File Offset: 0x005C6398
	public bool GetRewardRedDotState()
	{
		if (this.GetAllAvailableGetMilestoneRewardIds().Count > 0)
		{
			return true;
		}
		using (Dictionary<int, global::ActivityTaskData>.ValueCollection.Enumerator enumerator = this.RewardTaskMap.Values.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.Status == EActivityTaskState.FinishedAndUnclaimed)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x06016C62 RID: 93282 RVA: 0x005C8208 File Offset: 0x005C6408
	private static int SortTaskData(global::ActivityTaskData a, global::ActivityTaskData b)
	{
		if (a.Status != b.Status)
		{
			return a.Status - b.Status;
		}
		SurvivorsTask? survivorsTask = SurvivorsRogueConfig.Instance.GetSurvivorsTask(a.Id);
		SurvivorsTask? survivorsTask2 = SurvivorsRogueConfig.Instance.GetSurvivorsTask(b.Id);
		if (survivorsTask.Value.SortId == survivorsTask2.Value.SortId)
		{
			return a.Id - b.Id;
		}
		return survivorsTask.Value.SortId - survivorsTask2.Value.SortId;
	}

	// Token: 0x06016C63 RID: 93283 RVA: 0x005C82A0 File Offset: 0x005C64A0
	public List<int> GetAvailableGetTaskRewardIdsByType(int typeId)
	{
		List<int> list = new List<int>();
		List<int> list2;
		if (!this.RewardType2TaskIdList.TryGetValue(typeId, out list2))
		{
			return list;
		}
		foreach (int num in list2)
		{
			if (this.RewardTaskMap[num].Status == EActivityTaskState.FinishedAndUnclaimed)
			{
				list.Add(num);
			}
		}
		return list;
	}

	// Token: 0x06016C64 RID: 93284 RVA: 0x005C831C File Offset: 0x005C651C
	private void InitMilestoneReward()
	{
		this.MilestoneItemId = SurvivorsRogueConfig.Instance.GetSurvivorsActivityConfigByActivityId(base.Id).Value.ScoreItemId;
		this.MilestoneRewardMap.Clear();
		int num = -1;
		foreach (SurvivorsScoreReward survivorsScoreReward in SurvivorsRogueConfig.Instance.GetAllSurvivorsScoreRewardByActId(this.ActId))
		{
			SurvivorsMilestoneData value = new SurvivorsMilestoneData(survivorsScoreReward.Id, survivorsScoreReward.Index, survivorsScoreReward.Score, survivorsScoreReward.DropId, false);
			this.MilestoneRewardMap[survivorsScoreReward.Id] = value;
			if (survivorsScoreReward.Score > num)
			{
				num = survivorsScoreReward.Score;
			}
		}
		this.MilestoneRewardMaxCount = num;
	}

	// Token: 0x06016C65 RID: 93285 RVA: 0x005C83F4 File Offset: 0x005C65F4
	public void RefreshGotMilestoneReward(int milestoneRewardId)
	{
		SurvivorsMilestoneData survivorsMilestoneData;
		if (!this.MilestoneRewardMap.TryGetValue(milestoneRewardId, out survivorsMilestoneData))
		{
			return;
		}
		survivorsMilestoneData.IsGot = true;
	}

	// Token: 0x06016C66 RID: 93286 RVA: 0x005C8419 File Offset: 0x005C6619
	public int GetMilestoneItemCount()
	{
		return InventoryModel.Instance.GetItemCountByConfigId(this.MilestoneItemId, 0);
	}

	// Token: 0x06016C67 RID: 93287 RVA: 0x005C842C File Offset: 0x005C662C
	public List<SurvivorsMilestoneData> GetAllMilestoneReward()
	{
		List<SurvivorsMilestoneData> list = new List<SurvivorsMilestoneData>(this.MilestoneRewardMap.Values);
		list.Sort((SurvivorsMilestoneData a, SurvivorsMilestoneData b) => a.SortId - b.SortId);
		return list;
	}

	// Token: 0x06016C68 RID: 93288 RVA: 0x005C8464 File Offset: 0x005C6664
	public List<int> GetAllAvailableGetMilestoneRewardIds()
	{
		List<int> list = new List<int>();
		int milestoneItemCount = this.GetMilestoneItemCount();
		foreach (KeyValuePair<int, SurvivorsMilestoneData> keyValuePair in this.MilestoneRewardMap)
		{
			int key = keyValuePair.Key;
			if (keyValuePair.Value.IsReceivable(milestoneItemCount))
			{
				list.Add(key);
			}
		}
		return list;
	}

	// Token: 0x06016C69 RID: 93289 RVA: 0x005C84E0 File Offset: 0x005C66E0
	public List<int> GetAllLevelId()
	{
		List<int> list = new List<int>(this.LevelMap.Keys);
		list.Sort((int a, int b) => a - b);
		return list;
	}

	// Token: 0x06016C6A RID: 93290 RVA: 0x005C8518 File Offset: 0x005C6718
	[NullableContext(2)]
	public ISurvivorsLevelInfo GetCurrentLevelInfoByLevelId(int levelId)
	{
		SurvivorsChallengeInfo survivorsChallengeInfo;
		if (!this.LevelMap.TryGetValue(levelId, out survivorsChallengeInfo))
		{
			return null;
		}
		bool flag = this.IsEndlessMode(levelId);
		if (flag && survivorsChallengeInfo.InfiniteModeInfos == null)
		{
			return null;
		}
		return new SurvivorsLevelInfo
		{
			LevelId = survivorsChallengeInfo.LevelId,
			OpenTime = survivorsChallengeInfo.OpenTime,
			IsEndlessMode = flag,
			Info = (flag ? survivorsChallengeInfo.InfiniteModeInfos : survivorsChallengeInfo.NormalModeInfos)
		};
	}

	// Token: 0x06016C6B RID: 93291 RVA: 0x005C8587 File Offset: 0x005C6787
	public bool IsEndlessMode(int levelId)
	{
		return ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 3, levelId, 0) == 1;
	}

	// Token: 0x06016C6C RID: 93292 RVA: 0x005C85A0 File Offset: 0x005C67A0
	public bool GetLevelUnlockRedDotState()
	{
		if (!base.GetPreGuideQuestFinishState())
		{
			return false;
		}
		foreach (SurvivorsChallengeInfo levelInfo in this.LevelMap.Values)
		{
			if (this.GetLevelNewUnlock(levelInfo))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06016C6D RID: 93293 RVA: 0x005C860C File Offset: 0x005C680C
	private bool GetLevelNewUnlock(SurvivorsChallengeInfo levelInfo)
	{
		ModeInfo normalModeInfos = levelInfo.NormalModeInfos;
		if (normalModeInfos != null && this.GetLevelUnlockState(levelInfo.LevelId, false) && !normalModeInfos.IsFinish && ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 1, levelInfo.LevelId, 0) == 0)
		{
			return true;
		}
		ModeInfo infiniteModeInfos = levelInfo.InfiniteModeInfos;
		return infiniteModeInfos != null && this.GetLevelUnlockState(levelInfo.LevelId, true) && infiniteModeInfos.KillMonsterCount == 0 && ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 1, levelInfo.LevelId, 1) == 0;
	}

	// Token: 0x06016C6E RID: 93294 RVA: 0x005C8698 File Offset: 0x005C6898
	public bool TryRemoveLevelNewUnlock(int levelId, bool isEndless)
	{
		SurvivorsChallengeInfo survivorsChallengeInfo;
		if (!this.LevelMap.TryGetValue(levelId, out survivorsChallengeInfo))
		{
			return false;
		}
		if (isEndless)
		{
			if (this.GetLevelUnlockState(levelId, true))
			{
				return !this.SaveCacheState(ESurvivorsActivitySaveFlags.NewLevel, levelId, 1, 1);
			}
		}
		else if (this.GetLevelUnlockState(levelId, false))
		{
			return !this.SaveCacheState(ESurvivorsActivitySaveFlags.NewLevel, levelId, 0, 1);
		}
		return false;
	}

	// Token: 0x06016C6F RID: 93295 RVA: 0x005C86EC File Offset: 0x005C68EC
	public bool TryRemoveLevelNewFinished(int levelId)
	{
		SurvivorsChallengeInfo survivorsChallengeInfo;
		if (!this.LevelMap.TryGetValue(levelId, out survivorsChallengeInfo))
		{
			return false;
		}
		ModeInfo normalModeInfos = survivorsChallengeInfo.NormalModeInfos;
		return normalModeInfos != null && normalModeInfos.IsFinish && !this.SaveCacheState(ESurvivorsActivitySaveFlags.LevelFinishedCheck, levelId, 0, 1);
	}

	// Token: 0x06016C70 RID: 93296 RVA: 0x005C8730 File Offset: 0x005C6930
	public bool IsEndlessFirstOpenCheck()
	{
		bool flag = false;
		foreach (SurvivorsChallengeInfo survivorsChallengeInfo in this.LevelMap.Values)
		{
			if (this.GetLevelUnlockState(survivorsChallengeInfo.LevelId, true))
			{
				flag = true;
				break;
			}
		}
		return flag && ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 4, 0, 0) == 0;
	}

	// Token: 0x06016C71 RID: 93297 RVA: 0x005C87B4 File Offset: 0x005C69B4
	[NullableContext(2)]
	public string GetLevelUnlockRemainTime(int levelId)
	{
		SurvivorsChallengeInfo survivorsChallengeInfo;
		if (!this.LevelMap.TryGetValue(levelId, out survivorsChallengeInfo))
		{
			return null;
		}
		long openTime = survivorsChallengeInfo.OpenTime;
		if ((double)openTime <= TimeUtil.Instance.GetServerTime())
		{
			return null;
		}
		return TimeUtil.Instance.GetRemainTimeDataFormat3((double)openTime - TimeUtil.Instance.GetServerTime()).CountDownText;
	}

	// Token: 0x06016C72 RID: 93298 RVA: 0x005C8808 File Offset: 0x005C6A08
	public bool GetLevelTimeUnlockState(int levelId)
	{
		SurvivorsChallengeInfo survivorsChallengeInfo;
		return this.LevelMap.TryGetValue(levelId, out survivorsChallengeInfo) && (double)survivorsChallengeInfo.OpenTime <= TimeUtil.Instance.GetServerTime();
	}

	// Token: 0x06016C73 RID: 93299 RVA: 0x005C8840 File Offset: 0x005C6A40
	public bool GetLevelUnlockState(int levelId, bool isInfinite)
	{
		SurvivorsChallengeInfo survivorsChallengeInfo;
		if (!this.LevelMap.TryGetValue(levelId, out survivorsChallengeInfo))
		{
			return false;
		}
		bool isUnlock;
		if (isInfinite && survivorsChallengeInfo.InfiniteModeInfos != null)
		{
			isUnlock = survivorsChallengeInfo.InfiniteModeInfos.IsUnlock;
		}
		else
		{
			isUnlock = survivorsChallengeInfo.NormalModeInfos.IsUnlock;
		}
		return isUnlock && (double)survivorsChallengeInfo.OpenTime <= TimeUtil.Instance.GetServerTime();
	}

	// Token: 0x06016C74 RID: 93300 RVA: 0x005C88A4 File Offset: 0x005C6AA4
	public int GetFocusLevelId()
	{
		List<int> allLevelId = this.GetAllLevelId();
		int result = allLevelId[0];
		foreach (int num in allLevelId)
		{
			SurvivorsChallengeInfo survivorsChallengeInfo = this.LevelMap[num];
			if (this.GetLevelNewUnlock(survivorsChallengeInfo))
			{
				result = num;
				break;
			}
			ISurvivorsLevelInfo currentLevelInfoByLevelId = this.GetCurrentLevelInfoByLevelId(num);
			if (this.GetLevelUnlockState(survivorsChallengeInfo.LevelId, currentLevelInfoByLevelId.IsEndlessMode))
			{
				result = num;
				if (currentLevelInfoByLevelId.Info.WaveId == 0)
				{
					result = num;
					break;
				}
			}
		}
		return result;
	}

	// Token: 0x06016C75 RID: 93301 RVA: 0x005C8948 File Offset: 0x005C6B48
	public ESurvivorsLevelDiff GetCurrentUnlockDiffId()
	{
		int[] areaBoundLevelIdArray = SurvivorsRogueConfig.Instance.GetSurvivorsActivityConfigByActivityId(base.Id).Value.GetAreaBoundLevelIdArray();
		ESurvivorsLevelDiff esurvivorsLevelDiff = ESurvivorsLevelDiff.Easy;
		for (int i = 1; i < areaBoundLevelIdArray.Length; i++)
		{
			int key = areaBoundLevelIdArray[i];
			SurvivorsChallengeInfo survivorsChallengeInfo = this.LevelMap[key];
			if (!this.GetLevelUnlockState(survivorsChallengeInfo.LevelId, false) || this.GetLevelNewUnlock(survivorsChallengeInfo))
			{
				break;
			}
			esurvivorsLevelDiff++;
		}
		return esurvivorsLevelDiff;
	}

	// Token: 0x17001E4E RID: 7758
	// (get) Token: 0x06016C76 RID: 93302 RVA: 0x005C89C0 File Offset: 0x005C6BC0
	public List<SurvivorsTalentAreaData> AreaDataList
	{
		get
		{
			List<SurvivorsTalentAreaData> list = new List<SurvivorsTalentAreaData>();
			foreach (KeyValuePair<int, SurvivorsTalentAreaData> keyValuePair in this.TalentAreaMap)
			{
				bool key = keyValuePair.Key != 0;
				SurvivorsTalentAreaData value = keyValuePair.Value;
				if (key)
				{
					list.Add(value);
				}
			}
			return list;
		}
	}

	// Token: 0x06016C77 RID: 93303 RVA: 0x005C8A2C File Offset: 0x005C6C2C
	public bool GetTalentTreeRed()
	{
		bool result = false;
		foreach (int key in this.TalentNodeMap.Keys)
		{
			SurvivorsTalentNode survivorsTalentNode;
			if (this.TalentNodeMap.TryGetValue(key, out survivorsTalentNode))
			{
				bool flag = this.IsEnoughUpgradeNode(survivorsTalentNode);
				if (survivorsTalentNode.Status == ESurvivorsTalentNodeStatus.CanUpgrade && flag)
				{
					result = true;
					break;
				}
			}
		}
		return result;
	}

	// Token: 0x06016C78 RID: 93304 RVA: 0x005C8AAC File Offset: 0x005C6CAC
	[NullableContext(2)]
	public SurvivorsTalentNode GetTalentNodeById(int nodeId)
	{
		SurvivorsTalentNode result;
		this.TalentNodeMap.TryGetValue(nodeId, out result);
		return result;
	}

	// Token: 0x06016C79 RID: 93305 RVA: 0x005C8ACC File Offset: 0x005C6CCC
	[NullableContext(2)]
	public SurvivorsTalentNode GetFirstTalentNode()
	{
		SurvivorsTalentNode result = null;
		foreach (SurvivorsTalentNode survivorsTalentNode in this.TalentNodeMap.Values)
		{
			if (survivorsTalentNode.AreaId == 0)
			{
				result = survivorsTalentNode;
				break;
			}
		}
		return result;
	}

	// Token: 0x06016C7A RID: 93306 RVA: 0x005C8B2C File Offset: 0x005C6D2C
	public void RefreshTalentTreeNode(int nodeId, int status)
	{
		SurvivorsTalentNode talentNodeById = this.GetTalentNodeById(nodeId);
		if (talentNodeById != null)
		{
			talentNodeById.Status = (ESurvivorsTalentNodeStatus)status;
		}
	}

	// Token: 0x06016C7B RID: 93307 RVA: 0x005C8B4C File Offset: 0x005C6D4C
	public bool IsPreNodeUpgraded(SurvivorsTalentNode node)
	{
		bool flag = false;
		if (node.PreNodeIds == null || node.PreNodeIds.Length == 0)
		{
			flag = true;
		}
		if (!flag && node.PreNodeIds != null)
		{
			for (int i = 0; i < node.PreNodeIds.Length; i++)
			{
				int num = node.PreNodeIds[i];
				if (num == 0)
				{
					flag = true;
					break;
				}
				SurvivorsTalentNode talentNodeById = this.GetTalentNodeById(num);
				if (talentNodeById != null && talentNodeById.Status == ESurvivorsTalentNodeStatus.Upgraded)
				{
					flag = true;
					break;
				}
			}
		}
		return flag;
	}

	// Token: 0x06016C7C RID: 93308 RVA: 0x005C8BB8 File Offset: 0x005C6DB8
	public bool IsEnoughUpgradeNode(SurvivorsTalentNode node)
	{
		SurvivorsTalentEffect? talentTreeEffect = SurvivorsRogueConfig.Instance.GetTalentTreeEffect(node.EffectId);
		if (talentTreeEffect == null)
		{
			return false;
		}
		if (talentTreeEffect.Value.ConsumeLength <= 0)
		{
			return true;
		}
		bool result = true;
		for (int i = 0; i < talentTreeEffect.Value.ConsumeLength; i++)
		{
			int key = talentTreeEffect.Value.Consume(i).Value.Key;
			int value = talentTreeEffect.Value.Consume(i).Value.Value;
			if (InventoryModel.Instance.GetItemCountByConfigId(key, 0) < value)
			{
				result = false;
				break;
			}
		}
		return result;
	}

	// Token: 0x06016C7D RID: 93309 RVA: 0x005C8C70 File Offset: 0x005C6E70
	public void CheckCurrentTalentTreeNode()
	{
		SurvivorsTalentNode survivorsTalentNode = null;
		SurvivorsTalentNode survivorsTalentNode2 = null;
		List<SurvivorsTalentNode> list = new List<SurvivorsTalentNode>();
		List<SurvivorsTalentNode> list2 = new List<SurvivorsTalentNode>(this.TalentNodeMap.Values);
		list2.Sort((SurvivorsTalentNode a, SurvivorsTalentNode b) => a.IndexSortId - b.IndexSortId);
		foreach (SurvivorsTalentNode survivorsTalentNode3 in list2)
		{
			bool flag = survivorsTalentNode3.Status == ESurvivorsTalentNodeStatus.Lock;
			bool flag2 = survivorsTalentNode3.Status == ESurvivorsTalentNodeStatus.CanUpgrade;
			bool flag3 = this.IsEnoughUpgradeNode(survivorsTalentNode3);
			if (flag2)
			{
				if (flag3)
				{
					survivorsTalentNode = survivorsTalentNode3;
					break;
				}
				list.Add(survivorsTalentNode3);
			}
			else if (flag && survivorsTalentNode2 == null)
			{
				survivorsTalentNode2 = survivorsTalentNode3;
			}
		}
		this.CurrentSelectNode = (survivorsTalentNode2 ?? this.GetFirstTalentNode());
		if (survivorsTalentNode != null)
		{
			this.CurrentSelectNode = survivorsTalentNode;
			return;
		}
		if (list.Count > 0)
		{
			this.CurrentSelectNode = list[0];
		}
	}

	// Token: 0x06016C7E RID: 93310 RVA: 0x005C8D68 File Offset: 0x005C6F68
	private void InitTalentTree()
	{
		this.TalentNodeMap.Clear();
		this.TalentAreaMap.Clear();
		foreach (SurvivorsTalentTree survivorsTalentTree in SurvivorsRogueConfig.Instance.GetAllTalentTreeNodeByActId(this.ActId))
		{
			SurvivorsTalentAreaData survivorsTalentAreaData;
			if (!this.TalentAreaMap.TryGetValue(survivorsTalentTree.Area, out survivorsTalentAreaData))
			{
				survivorsTalentAreaData = new SurvivorsTalentAreaData();
				survivorsTalentAreaData.AreaId = survivorsTalentTree.Area;
				survivorsTalentAreaData.NodeIds = new List<int>();
				this.TalentAreaMap[survivorsTalentTree.Area] = survivorsTalentAreaData;
			}
			survivorsTalentAreaData.NodeIds.Add(survivorsTalentTree.Id);
			SurvivorsTalentNode survivorsTalentNode;
			if (!this.TalentNodeMap.TryGetValue(survivorsTalentTree.Id, out survivorsTalentNode))
			{
				survivorsTalentNode = new SurvivorsTalentNode(survivorsTalentTree.Id, survivorsTalentTree.Area, survivorsTalentTree.GetPreNodeArray(), survivorsTalentTree.Effect, survivorsTalentTree.IndexId, survivorsTalentTree.IndexSortId);
				survivorsTalentNode.Status = ESurvivorsTalentNodeStatus.Lock;
				this.TalentNodeMap[survivorsTalentTree.Id] = survivorsTalentNode;
			}
		}
	}

	// Token: 0x06016C7F RID: 93311 RVA: 0x005C8E90 File Offset: 0x005C7090
	private void InitRole()
	{
		this.RoleMap.Clear();
		foreach (Aki.Config.SurvivorsRole survivorsRole in SurvivorsRogueConfig.Instance.GetAllSurvivorsRoleByActId(this.ActId))
		{
			this.RoleMap[survivorsRole.Id] = false;
		}
	}

	// Token: 0x06016C80 RID: 93312 RVA: 0x005C8F00 File Offset: 0x005C7100
	private void InitWeapon()
	{
		this.WeaponMap.Clear();
		foreach (Aki.Config.SurvivorsWeapon survivorsWeapon in SurvivorsRogueConfig.Instance.GetAllSurvivorsWeaponByActId(this.ActId))
		{
			this.WeaponMap[survivorsWeapon.Id] = false;
		}
	}

	// Token: 0x06016C81 RID: 93313 RVA: 0x005C8F70 File Offset: 0x005C7170
	private void InitItem()
	{
		this.ItemMap.Clear();
		foreach (SurvivorsItem survivorsItem in SurvivorsRogueConfig.Instance.GetAllSurvivorsItemByActId(this.ActId))
		{
			this.ItemMap[survivorsItem.Id] = false;
		}
	}

	// Token: 0x06016C82 RID: 93314 RVA: 0x005C8FE0 File Offset: 0x005C71E0
	public List<int> GetShowRoleList()
	{
		List<int> list = new List<int>();
		foreach (int num in this.RoleMap.Keys)
		{
			if (this.IsRoleIdCanShow(num))
			{
				list.Add(num);
			}
		}
		list.Sort(delegate(int a, int b)
		{
			Aki.Config.SurvivorsRole? survivorsRole = SurvivorsRogueConfig.Instance.GetSurvivorsRole(a);
			Aki.Config.SurvivorsRole? survivorsRole2 = SurvivorsRogueConfig.Instance.GetSurvivorsRole(b);
			bool flag = this.RoleMap[a];
			bool flag2 = this.RoleMap[b];
			if (flag != flag2)
			{
				if (!flag)
				{
					return 1;
				}
				return -1;
			}
			else
			{
				if (survivorsRole.Value.SortId == survivorsRole2.Value.SortId)
				{
					return a - b;
				}
				return survivorsRole.Value.SortId - survivorsRole2.Value.SortId;
			}
		});
		return list;
	}

	// Token: 0x06016C83 RID: 93315 RVA: 0x005C905C File Offset: 0x005C725C
	public bool IsRoleIdCanShow(int survivorsRoleId)
	{
		Aki.Config.SurvivorsRole? survivorsRole = SurvivorsRogueConfig.Instance.GetSurvivorsRole(survivorsRoleId);
		if (survivorsRole == null)
		{
			return false;
		}
		int trialRoleId = survivorsRole.Value.TrialRoleId;
		RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(trialRoleId, true);
		if (roleDataById == null)
		{
			return false;
		}
		EPlayerGender playerGender = PlayerInfoModel.Instance.GetPlayerGender();
		int roleId = roleDataById.GetRoleId();
		RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(roleId);
		int roleId2 = (roleConfig.Value.ParentId != 0) ? roleConfig.Value.ParentId : roleId;
		return !RoleModel.Instance.IsMainRole(roleId2) || RoleConfig.Instance.GetTrialRoleConfig(trialRoleId).Value.Gender == (int)playerGender;
	}

	// Token: 0x06016C84 RID: 93316 RVA: 0x005C9120 File Offset: 0x005C7320
	public List<int> GetAllNeedPopupWeaponId()
	{
		List<int> list = new List<int>();
		foreach (KeyValuePair<int, bool> keyValuePair in this.WeaponMap)
		{
			int key = keyValuePair.Key;
			if (keyValuePair.Value && !this.SaveCacheState(ESurvivorsActivitySaveFlags.WeaponNewUnlockCheck, key, 0, 1))
			{
				list.Add(key);
			}
		}
		return list;
	}

	// Token: 0x06016C85 RID: 93317 RVA: 0x005C9198 File Offset: 0x005C7398
	public int GetAllItemUnlockCount()
	{
		int num = 0;
		foreach (int key in this.GetShowRoleList())
		{
			if (this.RoleMap[key])
			{
				num++;
			}
		}
		using (Dictionary<int, bool>.ValueCollection.Enumerator enumerator2 = this.WeaponMap.Values.GetEnumerator())
		{
			while (enumerator2.MoveNext())
			{
				if (enumerator2.Current)
				{
					num++;
				}
			}
		}
		using (Dictionary<int, bool>.ValueCollection.Enumerator enumerator2 = this.ItemMap.Values.GetEnumerator())
		{
			while (enumerator2.MoveNext())
			{
				if (enumerator2.Current)
				{
					num++;
				}
			}
		}
		return num;
	}

	// Token: 0x06016C86 RID: 93318 RVA: 0x005C9284 File Offset: 0x005C7484
	public int GetAllItemCount()
	{
		return 0 + this.GetShowRoleList().Count + this.WeaponMap.Count + this.ItemMap.Count;
	}

	// Token: 0x0400A914 RID: 43284
	public int ActId;

	// Token: 0x0400A915 RID: 43285
	public Dictionary<int, global::ActivityTaskData> RewardTaskMap = new Dictionary<int, global::ActivityTaskData>();

	// Token: 0x0400A916 RID: 43286
	public Dictionary<int, List<int>> RewardType2TaskIdList = new Dictionary<int, List<int>>();

	// Token: 0x0400A917 RID: 43287
	private readonly Dictionary<int, SurvivorsMilestoneData> MilestoneRewardMap = new Dictionary<int, SurvivorsMilestoneData>();

	// Token: 0x0400A918 RID: 43288
	public int MilestoneRewardMaxCount;

	// Token: 0x0400A919 RID: 43289
	public int MilestoneItemId;

	// Token: 0x0400A91A RID: 43290
	public readonly Dictionary<int, SurvivorsChallengeInfo> LevelMap = new Dictionary<int, SurvivorsChallengeInfo>();

	// Token: 0x0400A91B RID: 43291
	public Dictionary<int, SurvivorsTalentNode> TalentNodeMap = new Dictionary<int, SurvivorsTalentNode>();

	// Token: 0x0400A91C RID: 43292
	public Dictionary<int, SurvivorsTalentAreaData> TalentAreaMap = new Dictionary<int, SurvivorsTalentAreaData>();

	// Token: 0x0400A91D RID: 43293
	[Nullable(2)]
	public SurvivorsTalentNode CurrentSelectNode;

	// Token: 0x0400A91E RID: 43294
	public Dictionary<int, bool> RoleMap = new Dictionary<int, bool>();

	// Token: 0x0400A91F RID: 43295
	public Dictionary<int, bool> WeaponMap = new Dictionary<int, bool>();

	// Token: 0x0400A920 RID: 43296
	public Dictionary<int, bool> ItemMap = new Dictionary<int, bool>();

	// Token: 0x020090EB RID: 37099
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x0402EF25 RID: 192293
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static Comparison<global::ActivityTaskData> <0>__SortTaskData;
	}
}
