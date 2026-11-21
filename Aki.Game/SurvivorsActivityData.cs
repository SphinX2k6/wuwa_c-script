using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RoleUi;

// Token: 0x02002034 RID: 8244
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsActivityData : ActivityBaseData
{
	// Token: 0x06014681 RID: 83585 RVA: 0x005F462C File Offset: 0x005F282C
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

	// Token: 0x06014682 RID: 83586 RVA: 0x005F4690 File Offset: 0x005F2890
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

	// Token: 0x06014683 RID: 83587 RVA: 0x005F48C4 File Offset: 0x005F2AC4
	public override bool GetExDataRedPointShowState()
	{
		return this.GetActivityRedDotState();
	}

	// Token: 0x06014684 RID: 83588 RVA: 0x005F48CC File Offset: 0x005F2ACC
	public bool GetActivityRedDotState()
	{
		return this.GetActivityUnlockRedDotState() || this.GetRewardRedDotState() || this.GetLevelUnlockRedDotState();
	}

	// Token: 0x06014685 RID: 83589 RVA: 0x005F48E8 File Offset: 0x005F2AE8
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

	// Token: 0x06014686 RID: 83590 RVA: 0x005F4968 File Offset: 0x005F2B68
	public bool SaveCacheState(ESurvivorsActivitySaveFlags saveFlag, int key1, int key2 = 0, int saveValue = 1)
	{
		if (ActivityModel.Instance.GetActivityCacheData(base.Id, 0, (int)saveFlag, key1, key2) == saveValue)
		{
			return true;
		}
		ActivityModel.Instance.SaveActivityData(base.Id, (int)saveFlag, key1, key2, saveValue);
		return false;
	}

	// Token: 0x06014687 RID: 83591 RVA: 0x005F499C File Offset: 0x005F2B9C
	public void RefreshActivityRedDot()
	{
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
	}

	// Token: 0x06014688 RID: 83592 RVA: 0x005F49B4 File Offset: 0x005F2BB4
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

	// Token: 0x17001EA5 RID: 7845
	// (get) Token: 0x06014689 RID: 83593 RVA: 0x005F4A0E File Offset: 0x005F2C0E
	// (set) Token: 0x0601468A RID: 83594 RVA: 0x005F4A28 File Offset: 0x005F2C28
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

	// Token: 0x0601468B RID: 83595 RVA: 0x005F4A48 File Offset: 0x005F2C48
	private void InitRewardTaskData()
	{
		foreach (SurvivorsTask survivorsTask in SurvivorsRogueConfig.Instance.GetSurvivorsTaskByActId(this.ActId))
		{
			this.CreateRewardTaskData(survivorsTask.Id);
		}
	}

	// Token: 0x0601468C RID: 83596 RVA: 0x005F4AA8 File Offset: 0x005F2CA8
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

	// Token: 0x0601468D RID: 83597 RVA: 0x005F4AE8 File Offset: 0x005F2CE8
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

	// Token: 0x0601468E RID: 83598 RVA: 0x005F4B6A File Offset: 0x005F2D6A
	public void SetRewardTaskDataDone(int taskId)
	{
		this.RewardTaskMap[taskId].Status = EActivityTaskState.FinishedAndClaimed;
	}

	// Token: 0x0601468F RID: 83599 RVA: 0x005F4B80 File Offset: 0x005F2D80
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

	// Token: 0x06014690 RID: 83600 RVA: 0x005F4BE0 File Offset: 0x005F2DE0
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

	// Token: 0x06014691 RID: 83601 RVA: 0x005F4C78 File Offset: 0x005F2E78
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

	// Token: 0x06014692 RID: 83602 RVA: 0x005F4CEC File Offset: 0x005F2EEC
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

	// Token: 0x06014693 RID: 83603 RVA: 0x005F4D5C File Offset: 0x005F2F5C
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

	// Token: 0x06014694 RID: 83604 RVA: 0x005F4DF4 File Offset: 0x005F2FF4
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

	// Token: 0x06014695 RID: 83605 RVA: 0x005F4E70 File Offset: 0x005F3070
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

	// Token: 0x06014696 RID: 83606 RVA: 0x005F4F48 File Offset: 0x005F3148
	public void RefreshGotMilestoneReward(int milestoneRewardId)
	{
		SurvivorsMilestoneData survivorsMilestoneData;
		if (!this.MilestoneRewardMap.TryGetValue(milestoneRewardId, out survivorsMilestoneData))
		{
			return;
		}
		survivorsMilestoneData.IsGot = true;
	}

	// Token: 0x06014697 RID: 83607 RVA: 0x005F4F6D File Offset: 0x005F316D
	public int GetMilestoneItemCount()
	{
		return InventoryModel.Instance.GetItemCountByConfigId(this.MilestoneItemId, 0);
	}

	// Token: 0x06014698 RID: 83608 RVA: 0x005F4F80 File Offset: 0x005F3180
	public List<SurvivorsMilestoneData> GetAllMilestoneReward()
	{
		List<SurvivorsMilestoneData> list = new List<SurvivorsMilestoneData>(this.MilestoneRewardMap.Values);
		list.Sort((SurvivorsMilestoneData a, SurvivorsMilestoneData b) => a.SortId - b.SortId);
		return list;
	}

	// Token: 0x06014699 RID: 83609 RVA: 0x005F4FB8 File Offset: 0x005F31B8
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

	// Token: 0x0601469A RID: 83610 RVA: 0x005F5034 File Offset: 0x005F3234
	public List<int> GetAllLevelId()
	{
		List<int> list = new List<int>(this.LevelMap.Keys);
		list.Sort((int a, int b) => a - b);
		return list;
	}

	// Token: 0x0601469B RID: 83611 RVA: 0x005F506C File Offset: 0x005F326C
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

	// Token: 0x0601469C RID: 83612 RVA: 0x005F50DB File Offset: 0x005F32DB
	public bool IsEndlessMode(int levelId)
	{
		return ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 3, levelId, 0) == 1;
	}

	// Token: 0x0601469D RID: 83613 RVA: 0x005F50F4 File Offset: 0x005F32F4
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

	// Token: 0x0601469E RID: 83614 RVA: 0x005F5160 File Offset: 0x005F3360
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

	// Token: 0x0601469F RID: 83615 RVA: 0x005F51EC File Offset: 0x005F33EC
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

	// Token: 0x060146A0 RID: 83616 RVA: 0x005F5240 File Offset: 0x005F3440
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

	// Token: 0x060146A1 RID: 83617 RVA: 0x005F5284 File Offset: 0x005F3484
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

	// Token: 0x060146A2 RID: 83618 RVA: 0x005F5308 File Offset: 0x005F3508
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

	// Token: 0x060146A3 RID: 83619 RVA: 0x005F535C File Offset: 0x005F355C
	public bool GetLevelTimeUnlockState(int levelId)
	{
		SurvivorsChallengeInfo survivorsChallengeInfo;
		return this.LevelMap.TryGetValue(levelId, out survivorsChallengeInfo) && (double)survivorsChallengeInfo.OpenTime <= TimeUtil.Instance.GetServerTime();
	}

	// Token: 0x060146A4 RID: 83620 RVA: 0x005F5394 File Offset: 0x005F3594
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

	// Token: 0x060146A5 RID: 83621 RVA: 0x005F53F8 File Offset: 0x005F35F8
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

	// Token: 0x060146A6 RID: 83622 RVA: 0x005F549C File Offset: 0x005F369C
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

	// Token: 0x17001EA6 RID: 7846
	// (get) Token: 0x060146A7 RID: 83623 RVA: 0x005F5514 File Offset: 0x005F3714
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

	// Token: 0x060146A8 RID: 83624 RVA: 0x005F5580 File Offset: 0x005F3780
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

	// Token: 0x060146A9 RID: 83625 RVA: 0x005F5600 File Offset: 0x005F3800
	[NullableContext(2)]
	public SurvivorsTalentNode GetTalentNodeById(int nodeId)
	{
		SurvivorsTalentNode result;
		this.TalentNodeMap.TryGetValue(nodeId, out result);
		return result;
	}

	// Token: 0x060146AA RID: 83626 RVA: 0x005F5620 File Offset: 0x005F3820
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

	// Token: 0x060146AB RID: 83627 RVA: 0x005F5680 File Offset: 0x005F3880
	public void RefreshTalentTreeNode(int nodeId, int status)
	{
		SurvivorsTalentNode talentNodeById = this.GetTalentNodeById(nodeId);
		if (talentNodeById != null)
		{
			talentNodeById.Status = (ESurvivorsTalentNodeStatus)status;
		}
	}

	// Token: 0x060146AC RID: 83628 RVA: 0x005F56A0 File Offset: 0x005F38A0
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

	// Token: 0x060146AD RID: 83629 RVA: 0x005F570C File Offset: 0x005F390C
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

	// Token: 0x060146AE RID: 83630 RVA: 0x005F57C4 File Offset: 0x005F39C4
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

	// Token: 0x060146AF RID: 83631 RVA: 0x005F58BC File Offset: 0x005F3ABC
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

	// Token: 0x060146B0 RID: 83632 RVA: 0x005F59E4 File Offset: 0x005F3BE4
	private void InitRole()
	{
		this.RoleMap.Clear();
		foreach (Aki.Config.SurvivorsRole survivorsRole in SurvivorsRogueConfig.Instance.GetAllSurvivorsRoleByActId(this.ActId))
		{
			this.RoleMap[survivorsRole.Id] = false;
		}
	}

	// Token: 0x060146B1 RID: 83633 RVA: 0x005F5A54 File Offset: 0x005F3C54
	private void InitWeapon()
	{
		this.WeaponMap.Clear();
		foreach (Aki.Config.SurvivorsWeapon survivorsWeapon in SurvivorsRogueConfig.Instance.GetAllSurvivorsWeaponByActId(this.ActId))
		{
			this.WeaponMap[survivorsWeapon.Id] = false;
		}
	}

	// Token: 0x060146B2 RID: 83634 RVA: 0x005F5AC4 File Offset: 0x005F3CC4
	private void InitItem()
	{
		this.ItemMap.Clear();
		foreach (SurvivorsItem survivorsItem in SurvivorsRogueConfig.Instance.GetAllSurvivorsItemByActId(this.ActId))
		{
			this.ItemMap[survivorsItem.Id] = false;
		}
	}

	// Token: 0x060146B3 RID: 83635 RVA: 0x005F5B34 File Offset: 0x005F3D34
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

	// Token: 0x060146B4 RID: 83636 RVA: 0x005F5BB0 File Offset: 0x005F3DB0
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

	// Token: 0x060146B5 RID: 83637 RVA: 0x005F5C74 File Offset: 0x005F3E74
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

	// Token: 0x060146B6 RID: 83638 RVA: 0x005F5CEC File Offset: 0x005F3EEC
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

	// Token: 0x060146B7 RID: 83639 RVA: 0x005F5DD8 File Offset: 0x005F3FD8
	public int GetAllItemCount()
	{
		return 0 + this.GetShowRoleList().Count + this.WeaponMap.Count + this.ItemMap.Count;
	}

	// Token: 0x0400AD1A RID: 44314
	public int ActId;

	// Token: 0x0400AD1B RID: 44315
	public Dictionary<int, global::ActivityTaskData> RewardTaskMap = new Dictionary<int, global::ActivityTaskData>();

	// Token: 0x0400AD1C RID: 44316
	public Dictionary<int, List<int>> RewardType2TaskIdList = new Dictionary<int, List<int>>();

	// Token: 0x0400AD1D RID: 44317
	private readonly Dictionary<int, SurvivorsMilestoneData> MilestoneRewardMap = new Dictionary<int, SurvivorsMilestoneData>();

	// Token: 0x0400AD1E RID: 44318
	public int MilestoneRewardMaxCount;

	// Token: 0x0400AD1F RID: 44319
	public int MilestoneItemId;

	// Token: 0x0400AD20 RID: 44320
	public readonly Dictionary<int, SurvivorsChallengeInfo> LevelMap = new Dictionary<int, SurvivorsChallengeInfo>();

	// Token: 0x0400AD21 RID: 44321
	public Dictionary<int, SurvivorsTalentNode> TalentNodeMap = new Dictionary<int, SurvivorsTalentNode>();

	// Token: 0x0400AD22 RID: 44322
	public Dictionary<int, SurvivorsTalentAreaData> TalentAreaMap = new Dictionary<int, SurvivorsTalentAreaData>();

	// Token: 0x0400AD23 RID: 44323
	[Nullable(2)]
	public SurvivorsTalentNode CurrentSelectNode;

	// Token: 0x0400AD24 RID: 44324
	public Dictionary<int, bool> RoleMap = new Dictionary<int, bool>();

	// Token: 0x0400AD25 RID: 44325
	public Dictionary<int, bool> WeaponMap = new Dictionary<int, bool>();

	// Token: 0x0400AD26 RID: 44326
	public Dictionary<int, bool> ItemMap = new Dictionary<int, bool>();

	// Token: 0x0200832F RID: 33583
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x0402A62B RID: 173611
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static Comparison<global::ActivityTaskData> <0>__SortTaskData;
	}
}
