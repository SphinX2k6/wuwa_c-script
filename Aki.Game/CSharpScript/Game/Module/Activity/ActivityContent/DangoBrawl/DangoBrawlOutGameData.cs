using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x020067D1 RID: 26577
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlOutGameData
	{
		// Token: 0x06042307 RID: 271111 RVA: 0x0100CF0C File Offset: 0x0100B10C
		public void PhraseEx(int activityId, DangoBrawlActivityInfo activityInfo)
		{
			this.ActivityId = activityId;
			this.UpdateTaskDataList(activityInfo.ConditionTasks.ToArray<ConditionTask>());
			this.UpdateRoleDataList(activityInfo.UnlockedRoleIds.ToArray<int>(), false);
			this.UpdateItemDataList(activityInfo.UnlockedItemIds.ToArray<int>(), false);
			this.UpdateLevelDataList(activityInfo.ChallengeInfos.ToArray<DangoBrawlChallengeInfo>());
			this.UpdateShopCoinCost(activityInfo.LimitCoinCost);
			this.UpdateSaveData(activityInfo.SaveMatchBrief);
			this.InitScoreRewardReceivedData(activityInfo.RewardScoreIds.ToArray<int>());
		}

		// Token: 0x06042308 RID: 271112 RVA: 0x0100CF94 File Offset: 0x0100B194
		public int GetRecommendQuestId()
		{
			if (DangoBrawlConfig.Instance.GetActivityConfigById(this.ActivityId) == null)
			{
				return 0;
			}
			DangoBrawlActivity? dangoBrawlActivity;
			return dangoBrawlActivity.GetValueOrDefault().RecommendQuestId;
		}

		// Token: 0x06042309 RID: 271113 RVA: 0x0100CFCC File Offset: 0x0100B1CC
		public int GetRecommendQuestNodeId()
		{
			if (DangoBrawlConfig.Instance.GetActivityConfigById(this.ActivityId) == null)
			{
				return 0;
			}
			DangoBrawlActivity? dangoBrawlActivity;
			return dangoBrawlActivity.GetValueOrDefault().RecommendQuestNodeId;
		}

		// Token: 0x0604230A RID: 271114 RVA: 0x0100D004 File Offset: 0x0100B204
		public string GetRecommendQuestTipsTextId()
		{
			DangoBrawlActivity? dangoBrawlActivity;
			return ((DangoBrawlConfig.Instance.GetActivityConfigById(this.ActivityId) != null) ? dangoBrawlActivity.GetValueOrDefault().RecommendQuestLabel : null) ?? "";
		}

		// Token: 0x0604230B RID: 271115 RVA: 0x0100D048 File Offset: 0x0100B248
		public bool IsRecommendQuestFinished()
		{
			int recommendQuestId = this.GetRecommendQuestId();
			if (recommendQuestId == 0 || QuestNewModel.Instance.CheckQuestFinished(recommendQuestId))
			{
				return true;
			}
			global::Quest quest = QuestNewModel.Instance.GetQuest(recommendQuestId);
			BehaviorNodeBase behaviorNodeBase = (quest != null) ? quest.GetNode(this.GetRecommendQuestNodeId()) : null;
			return behaviorNodeBase != null && behaviorNodeBase.IsSuccess;
		}

		// Token: 0x0604230C RID: 271116 RVA: 0x0100D098 File Offset: 0x0100B298
		public void UpdateTaskDataList(ConditionTask[] taskList)
		{
			foreach (ConditionTask taskInfo in taskList)
			{
				this.UpdateTaskData(taskInfo);
			}
		}

		// Token: 0x0604230D RID: 271117 RVA: 0x0100D0C0 File Offset: 0x0100B2C0
		public void UpdateTaskData(ConditionTask taskInfo)
		{
			DangoBrawlTaskData dangoBrawlTaskData;
			if (!this.TaskDataMap.TryGetValue(taskInfo.Id, out dangoBrawlTaskData))
			{
				dangoBrawlTaskData = new DangoBrawlTaskData(taskInfo.Id);
				this.TaskDataMap[taskInfo.Id] = dangoBrawlTaskData;
			}
			dangoBrawlTaskData.UpdateData(taskInfo);
		}

		// Token: 0x0604230E RID: 271118 RVA: 0x0100D107 File Offset: 0x0100B307
		[NullableContext(2)]
		public DangoBrawlTaskData GetTaskData(int id)
		{
			return this.TaskDataMap.GetValueOrDefault(id);
		}

		// Token: 0x0604230F RID: 271119 RVA: 0x0100D118 File Offset: 0x0100B318
		public List<DangoBrawlTaskData> GetTaskDataList(int? tabId = null)
		{
			return (from taskData in this.TaskDataMap.Values
			where tabId == null || taskData.TabId == tabId.Value
			orderby taskData.Status, taskData.Id
			select taskData).ToList<DangoBrawlTaskData>();
		}

		// Token: 0x06042310 RID: 271120 RVA: 0x0100D19B File Offset: 0x0100B39B
		public int GetTaskTotalNum(int? tabId = null)
		{
			if (tabId == null)
			{
				return this.TaskDataMap.Count;
			}
			return this.GetTaskDataList(tabId).Count;
		}

		// Token: 0x06042311 RID: 271121 RVA: 0x0100D1BE File Offset: 0x0100B3BE
		[NullableContext(0)]
		public ValueTuple<int, int> GetTaskProgress(int? tabId = null)
		{
			return new ValueTuple<int, int>(this.GetTaskDataList(tabId).Count((DangoBrawlTaskData taskData) => taskData.Status == EActivityTaskState.FinishedAndClaimed), this.GetTaskTotalNum(tabId));
		}

		// Token: 0x06042312 RID: 271122 RVA: 0x0100D1F8 File Offset: 0x0100B3F8
		public bool IsTaskHasRedDot(int? tabId = null)
		{
			return this.TaskDataMap.Values.Any((DangoBrawlTaskData taskData) => (tabId == null || taskData.TabId == tabId.Value) && taskData.Status == EActivityTaskState.FinishedAndUnclaimed);
		}

		// Token: 0x06042313 RID: 271123 RVA: 0x0100D230 File Offset: 0x0100B430
		public void SetTaskRewardReceived(List<int> idList)
		{
			foreach (int key in idList)
			{
				DangoBrawlTaskData dangoBrawlTaskData;
				if (this.TaskDataMap.TryGetValue(key, out dangoBrawlTaskData))
				{
					dangoBrawlTaskData.UpdateState(EActivityTaskState.FinishedAndClaimed);
				}
			}
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.ActivityId);
		}

		// Token: 0x06042314 RID: 271124 RVA: 0x0100D2A4 File Offset: 0x0100B4A4
		public int GetCurrentMilestone()
		{
			if (this.MilestoneItemId == 0)
			{
				DangoBrawlActivity? activityConfigById = DangoBrawlConfig.Instance.GetActivityConfigById(this.ActivityId);
				this.MilestoneItemId = ((activityConfigById != null) ? activityConfigById.GetValueOrDefault().ScoreItemId : 0);
			}
			return InventoryModel.Instance.GetItemCountByConfigId(this.MilestoneItemId, 0);
		}

		// Token: 0x06042315 RID: 271125 RVA: 0x0100D2FC File Offset: 0x0100B4FC
		private void InitScoreRewardReceivedData(IList<int> scoreTaskList)
		{
			this.ScoreRewardReceivedIdSet.Clear();
			if (scoreTaskList == null)
			{
				return;
			}
			foreach (int item in scoreTaskList)
			{
				this.ScoreRewardReceivedIdSet.Add(item);
			}
		}

		// Token: 0x06042316 RID: 271126 RVA: 0x0100D35C File Offset: 0x0100B55C
		public void SetScoreRewardReceived(List<int> idList)
		{
			foreach (int item in idList)
			{
				this.ScoreRewardReceivedIdSet.Add(item);
			}
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.ActivityId);
		}

		// Token: 0x06042317 RID: 271127 RVA: 0x0100D3C8 File Offset: 0x0100B5C8
		public bool IsScoreRewardCanReceived(int id)
		{
			DangoBrawlScoreReward? scoreRewardConfigById = DangoBrawlConfig.Instance.GetScoreRewardConfigById(id);
			return scoreRewardConfigById != null && this.GetCurrentMilestone() >= scoreRewardConfigById.Value.Score && !this.IsScoreRewardReceived(id);
		}

		// Token: 0x06042318 RID: 271128 RVA: 0x0100D40F File Offset: 0x0100B60F
		public bool IsScoreRewardReceived(int id)
		{
			return this.ScoreRewardReceivedIdSet.Contains(id);
		}

		// Token: 0x06042319 RID: 271129 RVA: 0x0100D420 File Offset: 0x0100B620
		public int GetLastNotTakenScoreRewardIndex()
		{
			IReadOnlyList<DangoBrawlScoreReward> allDangoBrawlScoreAwardConfig = DangoBrawlConfig.Instance.GetAllDangoBrawlScoreAwardConfig();
			for (int i = allDangoBrawlScoreAwardConfig.Count - 1; i >= 0; i--)
			{
				if (this.IsScoreRewardCanReceived(allDangoBrawlScoreAwardConfig[i].Id))
				{
					return i + 1;
				}
			}
			return 0;
		}

		// Token: 0x0604231A RID: 271130 RVA: 0x0100D468 File Offset: 0x0100B668
		public List<int> GetCanClaimedScoreRewardList()
		{
			List<int> list = new List<int>();
			foreach (DangoBrawlScoreReward dangoBrawlScoreReward in DangoBrawlConfig.Instance.GetAllDangoBrawlScoreAwardConfig())
			{
				if (this.IsScoreRewardCanReceived(dangoBrawlScoreReward.Id))
				{
					list.Add(dangoBrawlScoreReward.Id);
				}
			}
			return list;
		}

		// Token: 0x0604231B RID: 271131 RVA: 0x0100D4D8 File Offset: 0x0100B6D8
		public bool IsScoreRewardHasRedDot()
		{
			foreach (DangoBrawlScoreReward dangoBrawlScoreReward in DangoBrawlConfig.Instance.GetAllDangoBrawlScoreAwardConfig())
			{
				if (this.IsScoreRewardCanReceived(dangoBrawlScoreReward.Id))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0604231C RID: 271132 RVA: 0x0100D538 File Offset: 0x0100B738
		public bool IsAllLimitRewardClaimed()
		{
			if (this.TaskDataMap.Count == 0)
			{
				return false;
			}
			using (Dictionary<int, DangoBrawlTaskData>.ValueCollection.Enumerator enumerator = this.TaskDataMap.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.Status != EActivityTaskState.FinishedAndClaimed)
					{
						return false;
					}
				}
			}
			foreach (DangoBrawlScoreReward dangoBrawlScoreReward in DangoBrawlConfig.Instance.GetAllDangoBrawlScoreAwardConfig())
			{
				if (!this.IsScoreRewardReceived(dangoBrawlScoreReward.Id))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0604231D RID: 271133 RVA: 0x0100D5F4 File Offset: 0x0100B7F4
		public List<int> UpdateRoleDataList(int[] unlockRoleIdList, bool isNotify = false)
		{
			List<int> list = new List<int>();
			foreach (int item in unlockRoleIdList)
			{
				if (!this.UnlockRoleIdList.Contains(item))
				{
					if (isNotify)
					{
						this.UnlockNotifyRoleList.Add(item);
					}
					this.UnlockRoleIdList.Add(item);
					list.Add(item);
				}
			}
			return list;
		}

		// Token: 0x0604231E RID: 271134 RVA: 0x0100D64C File Offset: 0x0100B84C
		public int GetOppositePlayerRoleId(int roleId)
		{
			DangoBrawlRole? roleConfigById = DangoBrawlConfig.Instance.GetRoleConfigById(roleId);
			if (roleConfigById == null)
			{
				return 0;
			}
			EPlayerGender gender = (EPlayerGender)roleConfigById.Value.Gender;
			if (gender != EPlayerGender.Male && gender != EPlayerGender.Female)
			{
				return 0;
			}
			EPlayerGender eplayerGender = (gender == EPlayerGender.Male) ? EPlayerGender.Female : EPlayerGender.Male;
			foreach (DangoBrawlRole dangoBrawlRole in DangoBrawlConfig.Instance.GetRoleConfigList(this.ActivityId))
			{
				if (dangoBrawlRole.Id != roleId && dangoBrawlRole.OccupationId == roleConfigById.Value.OccupationId && dangoBrawlRole.Gender == (int)eplayerGender)
				{
					return dangoBrawlRole.Id;
				}
			}
			return 0;
		}

		// Token: 0x0604231F RID: 271135 RVA: 0x0100D718 File Offset: 0x0100B918
		public int? DequeueUnlockNotifyRole()
		{
			if (this.UnlockNotifyRoleList.Count == 0)
			{
				return null;
			}
			int value = this.UnlockNotifyRoleList[0];
			this.UnlockNotifyRoleList.RemoveAt(0);
			return new int?(value);
		}

		// Token: 0x06042320 RID: 271136 RVA: 0x0100D759 File Offset: 0x0100B959
		public bool IsRoleUnlocked(int roleId)
		{
			return this.UnlockRoleIdList.Contains(roleId);
		}

		// Token: 0x06042321 RID: 271137 RVA: 0x0100D767 File Offset: 0x0100B967
		public IReadOnlyList<int> GetUnlockedRoleIds()
		{
			return this.UnlockRoleIdList;
		}

		// Token: 0x06042322 RID: 271138 RVA: 0x0100D770 File Offset: 0x0100B970
		public List<int> UpdateItemDataList(int[] unlockItemIdList, bool isNotify = false)
		{
			List<int> list = new List<int>();
			foreach (int item in unlockItemIdList)
			{
				if (!this.UnlockItemIdList.Contains(item))
				{
					this.UnlockItemIdList.Add(item);
					list.Add(item);
				}
			}
			return list;
		}

		// Token: 0x06042323 RID: 271139 RVA: 0x0100D7B9 File Offset: 0x0100B9B9
		public bool IsItemUnlocked(int itemId)
		{
			return this.UnlockItemIdList.Contains(itemId);
		}

		// Token: 0x06042324 RID: 271140 RVA: 0x0100D7C7 File Offset: 0x0100B9C7
		public IReadOnlyList<int> GetUnlockedItemIds()
		{
			return this.UnlockItemIdList;
		}

		// Token: 0x06042325 RID: 271141 RVA: 0x0100D7D0 File Offset: 0x0100B9D0
		public List<int> UpdateLevelDataList(DangoBrawlChallengeInfo[] levelList)
		{
			List<int> list = new List<int>();
			foreach (DangoBrawlChallengeInfo dangoBrawlChallengeInfo in levelList)
			{
				DangoBrawlLevelData dangoBrawlLevelData;
				bool flag = !this.LevelDataMap.TryGetValue(dangoBrawlChallengeInfo.ChallengeId, out dangoBrawlLevelData) || dangoBrawlLevelData.IsLocked;
				if (dangoBrawlLevelData == null)
				{
					dangoBrawlLevelData = new DangoBrawlLevelData(dangoBrawlChallengeInfo.ChallengeId);
					this.LevelDataMap[dangoBrawlChallengeInfo.ChallengeId] = dangoBrawlLevelData;
				}
				dangoBrawlLevelData.UpdateData(dangoBrawlChallengeInfo);
				if (flag && !dangoBrawlLevelData.IsLocked)
				{
					list.Add(dangoBrawlChallengeInfo.ChallengeId);
				}
			}
			return list;
		}

		// Token: 0x06042326 RID: 271142 RVA: 0x0100D85C File Offset: 0x0100BA5C
		public List<DangoBrawlLevelData> GetLevelDataList(bool isNormalMode)
		{
			return (from levelData in this.LevelDataMap.Values
			where levelData.IsNormalMode == isNormalMode
			select levelData).ToList<DangoBrawlLevelData>();
		}

		// Token: 0x06042327 RID: 271143 RVA: 0x0100D897 File Offset: 0x0100BA97
		public List<DangoBrawlLevelData> GetAllLevelDataList()
		{
			return this.LevelDataMap.Values.ToList<DangoBrawlLevelData>();
		}

		// Token: 0x06042328 RID: 271144 RVA: 0x0100D8A9 File Offset: 0x0100BAA9
		[NullableContext(2)]
		public DangoBrawlLevelData GetLevelData(int levelId)
		{
			return this.LevelDataMap.GetValueOrDefault(levelId);
		}

		// Token: 0x06042329 RID: 271145 RVA: 0x0100D8B8 File Offset: 0x0100BAB8
		[return: TupleElementNames(new string[]
		{
			"LevelModeStr",
			"LevelNum"
		})]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public ValueTuple<string, int> GetLevelModeInfo(int levelId)
		{
			DangoBrawlLevelData levelData = this.GetLevelData(levelId);
			bool flag = levelData == null || levelData.IsNormalMode;
			string item = ConfigMultiTextLang.GetLocalTextNew(flag ? "DangoBrawlGeneral_1002" : "DangoBrawlGeneral_1003", null) ?? "";
			int num = this.GetLevelDataList(flag).FindIndex((DangoBrawlLevelData level) => level.Id == levelId);
			int item2 = (num >= 0) ? (num + 1) : 0;
			return new ValueTuple<string, int>(item, item2);
		}

		// Token: 0x0604232A RID: 271146 RVA: 0x0100D934 File Offset: 0x0100BB34
		[NullableContext(0)]
		public ValueTuple<int, int> GetLevelProgress(bool isNormalMode)
		{
			List<DangoBrawlLevelData> levelDataList = this.GetLevelDataList(isNormalMode);
			return new ValueTuple<int, int>(levelDataList.Count((DangoBrawlLevelData levelData) => levelData.IsPassed), levelDataList.Count);
		}

		// Token: 0x0604232B RID: 271147 RVA: 0x0100D979 File Offset: 0x0100BB79
		public bool IsAllNormalLevelPassed()
		{
			return this.GetLevelDataList(true).All((DangoBrawlLevelData levelData) => levelData.IsPassed);
		}

		// Token: 0x0604232C RID: 271148 RVA: 0x0100D9A6 File Offset: 0x0100BBA6
		[NullableContext(2)]
		public void UpdateSaveData(DangoBrawlSaveMatchBrief saveMatch)
		{
			this.SaveData = ((saveMatch == null) ? null : new DangoBrawlSaveData(saveMatch.ChallengeId, saveMatch.RoundNum, saveMatch.RoleId));
		}

		// Token: 0x0604232D RID: 271149 RVA: 0x0100D9CB File Offset: 0x0100BBCB
		public void ClearSaveData()
		{
			this.SaveData = null;
		}

		// Token: 0x0604232E RID: 271150 RVA: 0x0100D9D4 File Offset: 0x0100BBD4
		public void SetIsEnterSave(bool isEnterSave)
		{
			this.IsEnterSave = isEnterSave;
		}

		// Token: 0x0604232F RID: 271151 RVA: 0x0100D9DD File Offset: 0x0100BBDD
		public bool GetIsEnterSave()
		{
			return this.IsEnterSave;
		}

		// Token: 0x06042330 RID: 271152 RVA: 0x0100D9E5 File Offset: 0x0100BBE5
		[NullableContext(2)]
		public DangoBrawlSaveData GetSaveData()
		{
			return this.SaveData;
		}

		// Token: 0x06042331 RID: 271153 RVA: 0x0100D9ED File Offset: 0x0100BBED
		public bool HasSaveData()
		{
			return this.SaveData != null && this.SaveData.LevelId > 0;
		}

		// Token: 0x06042332 RID: 271154 RVA: 0x0100DA07 File Offset: 0x0100BC07
		public int GetShopCoinCost()
		{
			return this.ShopCoinCost;
		}

		// Token: 0x06042333 RID: 271155 RVA: 0x0100DA0F File Offset: 0x0100BC0F
		public void UpdateShopCoinCost(int coinCost)
		{
			this.ShopCoinCost = coinCost;
		}

		// Token: 0x06042334 RID: 271156 RVA: 0x0100DA18 File Offset: 0x0100BC18
		public bool IsAllShopGoodsSoldOut()
		{
			DangoBrawlActivity? activityConfigById = DangoBrawlConfig.Instance.GetActivityConfigById(this.ActivityId);
			if (activityConfigById == null)
			{
				return false;
			}
			int limitCoinMax = activityConfigById.Value.LimitCoinMax;
			return limitCoinMax > 0 && this.ShopCoinCost >= limitCoinMax;
		}

		// Token: 0x040228D2 RID: 141522
		private int ActivityId;

		// Token: 0x040228D3 RID: 141523
		private readonly List<int> UnlockRoleIdList = new List<int>();

		// Token: 0x040228D4 RID: 141524
		private readonly List<int> UnlockItemIdList = new List<int>();

		// Token: 0x040228D5 RID: 141525
		private readonly Dictionary<int, DangoBrawlLevelData> LevelDataMap = new Dictionary<int, DangoBrawlLevelData>();

		// Token: 0x040228D6 RID: 141526
		private bool IsEnterSave;

		// Token: 0x040228D7 RID: 141527
		[Nullable(2)]
		private DangoBrawlSaveData SaveData;

		// Token: 0x040228D8 RID: 141528
		private readonly List<int> UnlockNotifyRoleList = new List<int>();

		// Token: 0x040228D9 RID: 141529
		private readonly Dictionary<int, DangoBrawlTaskData> TaskDataMap = new Dictionary<int, DangoBrawlTaskData>();

		// Token: 0x040228DA RID: 141530
		private int MilestoneItemId;

		// Token: 0x040228DB RID: 141531
		private readonly HashSet<int> ScoreRewardReceivedIdSet = new HashSet<int>();

		// Token: 0x040228DC RID: 141532
		private int ShopCoinCost;
	}
}
