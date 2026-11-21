using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02005721 RID: 22305
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlOutGameData
	{
		// Token: 0x06036E5D RID: 224861 RVA: 0x00F4E2D8 File Offset: 0x00F4C4D8
		public void PhraseEx(int activityId, DangoBrawlActivityInfo activityInfo)
		{
			this.ActivityId = activityId;
			this.UpdateTaskDataList(activityInfo.ConditionTasks);
			this.UpdateRoleDataList(activityInfo.UnlockedRoleIds, false);
			this.UpdateItemDataList(activityInfo.UnlockedItemIds, false);
			this.UpdateLevelDataList(activityInfo.ChallengeInfos);
			this.UpdateShopCoinCost(activityInfo.LimitCoinCost);
			this.UpdateSaveData(activityInfo.SaveMatchBrief);
			this.InitScoreRewardReceivedData(activityInfo.RewardScoreIds);
		}

		// Token: 0x06036E5E RID: 224862 RVA: 0x00F4E348 File Offset: 0x00F4C548
		public int GetRecommendQuestId()
		{
			if (DangoBrawlConfig.Instance.GetActivityConfigById(this.ActivityId) == null)
			{
				return 0;
			}
			DangoBrawlActivity? dangoBrawlActivity;
			return dangoBrawlActivity.GetValueOrDefault().RecommendQuestId;
		}

		// Token: 0x06036E5F RID: 224863 RVA: 0x00F4E380 File Offset: 0x00F4C580
		public int GetRecommendQuestNodeId()
		{
			if (DangoBrawlConfig.Instance.GetActivityConfigById(this.ActivityId) == null)
			{
				return 0;
			}
			DangoBrawlActivity? dangoBrawlActivity;
			return dangoBrawlActivity.GetValueOrDefault().RecommendQuestNodeId;
		}

		// Token: 0x06036E60 RID: 224864 RVA: 0x00F4E3B8 File Offset: 0x00F4C5B8
		public string GetRecommendQuestTipsTextId()
		{
			DangoBrawlActivity? dangoBrawlActivity;
			return ((DangoBrawlConfig.Instance.GetActivityConfigById(this.ActivityId) != null) ? dangoBrawlActivity.GetValueOrDefault().RecommendQuestLabel : null) ?? "";
		}

		// Token: 0x06036E61 RID: 224865 RVA: 0x00F4E3FC File Offset: 0x00F4C5FC
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

		// Token: 0x06036E62 RID: 224866 RVA: 0x00F4E44C File Offset: 0x00F4C64C
		public void UpdateTaskDataList(IReadOnlyList<ConditionTask> taskList)
		{
			foreach (ConditionTask taskInfo in taskList)
			{
				this.UpdateTaskData(taskInfo);
			}
		}

		// Token: 0x06036E63 RID: 224867 RVA: 0x00F4E494 File Offset: 0x00F4C694
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

		// Token: 0x06036E64 RID: 224868 RVA: 0x00F4E4DB File Offset: 0x00F4C6DB
		[NullableContext(2)]
		public DangoBrawlTaskData GetTaskData(int id)
		{
			return this.TaskDataMap.GetValueOrDefault(id);
		}

		// Token: 0x06036E65 RID: 224869 RVA: 0x00F4E4EC File Offset: 0x00F4C6EC
		public List<DangoBrawlTaskData> GetTaskDataList(int? tabId = null)
		{
			return NoLinq.WhereSortToList<DangoBrawlTaskData>(this.TaskDataMap.Values, (DangoBrawlTaskData task) => tabId == null || task.TabId == tabId.Value, delegate(DangoBrawlTaskData left, DangoBrawlTaskData right)
			{
				int num = left.Status.CompareTo(right.Status);
				if (num == 0)
				{
					return left.Id.CompareTo(right.Id);
				}
				return num;
			});
		}

		// Token: 0x06036E66 RID: 224870 RVA: 0x00F4E544 File Offset: 0x00F4C744
		public int GetTaskTotalNum(int? tabId = null)
		{
			if (tabId == null)
			{
				return this.TaskDataMap.Count;
			}
			return NoLinq.Count<DangoBrawlTaskData>(this.TaskDataMap.Values, (DangoBrawlTaskData task) => task.TabId == tabId.Value);
		}

		// Token: 0x06036E67 RID: 224871 RVA: 0x00F4E594 File Offset: 0x00F4C794
		[NullableContext(0)]
		public ValueTuple<int, int> GetTaskProgress(int? tabId = null)
		{
			return NoLinq.CountWhere<DangoBrawlTaskData>(this.TaskDataMap.Values, (DangoBrawlTaskData task) => tabId == null || task.TabId == tabId.Value, (DangoBrawlTaskData task) => task.Status == EActivityTaskState.FinishedAndClaimed);
		}

		// Token: 0x06036E68 RID: 224872 RVA: 0x00F4E5EC File Offset: 0x00F4C7EC
		public bool IsTaskHasRedDot(int? tabId = null)
		{
			foreach (DangoBrawlTaskData dangoBrawlTaskData in this.TaskDataMap.Values)
			{
				if ((tabId == null || dangoBrawlTaskData.TabId == tabId.Value) && dangoBrawlTaskData.Status == EActivityTaskState.FinishedAndUnclaimed)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06036E69 RID: 224873 RVA: 0x00F4E664 File Offset: 0x00F4C864
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

		// Token: 0x06036E6A RID: 224874 RVA: 0x00F4E6D8 File Offset: 0x00F4C8D8
		public int GetCurrentMilestone()
		{
			if (this.MilestoneItemId == 0)
			{
				DangoBrawlActivity? activityConfigById = DangoBrawlConfig.Instance.GetActivityConfigById(this.ActivityId);
				this.MilestoneItemId = ((activityConfigById != null) ? activityConfigById.GetValueOrDefault().ScoreItemId : 0);
			}
			return InventoryModel.Instance.GetItemCountByConfigId(this.MilestoneItemId, 0);
		}

		// Token: 0x06036E6B RID: 224875 RVA: 0x00F4E730 File Offset: 0x00F4C930
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

		// Token: 0x06036E6C RID: 224876 RVA: 0x00F4E790 File Offset: 0x00F4C990
		public void SetScoreRewardReceived(List<int> idList)
		{
			foreach (int item in idList)
			{
				this.ScoreRewardReceivedIdSet.Add(item);
			}
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.ActivityId);
		}

		// Token: 0x06036E6D RID: 224877 RVA: 0x00F4E7FC File Offset: 0x00F4C9FC
		public bool IsScoreRewardCanReceived(int id)
		{
			DangoBrawlScoreReward? scoreRewardConfigById = DangoBrawlConfig.Instance.GetScoreRewardConfigById(id);
			return scoreRewardConfigById != null && this.GetCurrentMilestone() >= scoreRewardConfigById.Value.Score && !this.IsScoreRewardReceived(id);
		}

		// Token: 0x06036E6E RID: 224878 RVA: 0x00F4E843 File Offset: 0x00F4CA43
		public bool IsScoreRewardReceived(int id)
		{
			return this.ScoreRewardReceivedIdSet.Contains(id);
		}

		// Token: 0x06036E6F RID: 224879 RVA: 0x00F4E854 File Offset: 0x00F4CA54
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

		// Token: 0x06036E70 RID: 224880 RVA: 0x00F4E89C File Offset: 0x00F4CA9C
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

		// Token: 0x06036E71 RID: 224881 RVA: 0x00F4E90C File Offset: 0x00F4CB0C
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

		// Token: 0x06036E72 RID: 224882 RVA: 0x00F4E96C File Offset: 0x00F4CB6C
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

		// Token: 0x06036E73 RID: 224883 RVA: 0x00F4EA28 File Offset: 0x00F4CC28
		public List<int> UpdateRoleDataList(IReadOnlyList<int> unlockRoleIdList, bool isNotify = false)
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

		// Token: 0x06036E74 RID: 224884 RVA: 0x00F4EAA0 File Offset: 0x00F4CCA0
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

		// Token: 0x06036E75 RID: 224885 RVA: 0x00F4EB6C File Offset: 0x00F4CD6C
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

		// Token: 0x06036E76 RID: 224886 RVA: 0x00F4EBAD File Offset: 0x00F4CDAD
		public bool IsRoleUnlocked(int roleId)
		{
			return this.UnlockRoleIdList.Contains(roleId);
		}

		// Token: 0x06036E77 RID: 224887 RVA: 0x00F4EBBB File Offset: 0x00F4CDBB
		public IReadOnlyList<int> GetUnlockedRoleIds()
		{
			return this.UnlockRoleIdList;
		}

		// Token: 0x06036E78 RID: 224888 RVA: 0x00F4EBC4 File Offset: 0x00F4CDC4
		public List<int> UpdateItemDataList(IReadOnlyList<int> unlockItemIdList, bool isNotify = false)
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

		// Token: 0x06036E79 RID: 224889 RVA: 0x00F4EC30 File Offset: 0x00F4CE30
		public bool IsItemUnlocked(int itemId)
		{
			return this.UnlockItemIdList.Contains(itemId);
		}

		// Token: 0x06036E7A RID: 224890 RVA: 0x00F4EC3E File Offset: 0x00F4CE3E
		public IReadOnlyList<int> GetUnlockedItemIds()
		{
			return this.UnlockItemIdList;
		}

		// Token: 0x06036E7B RID: 224891 RVA: 0x00F4EC48 File Offset: 0x00F4CE48
		public List<int> UpdateLevelDataList(IReadOnlyList<DangoBrawlChallengeInfo> levelList)
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

		// Token: 0x06036E7C RID: 224892 RVA: 0x00F4ECEC File Offset: 0x00F4CEEC
		public List<DangoBrawlLevelData> GetLevelDataList(bool isNormalMode)
		{
			List<DangoBrawlLevelData> list = new List<DangoBrawlLevelData>();
			foreach (DangoBrawlLevelData dangoBrawlLevelData in this.LevelDataMap.Values)
			{
				if (dangoBrawlLevelData.IsNormalMode == isNormalMode)
				{
					list.Add(dangoBrawlLevelData);
				}
			}
			return list;
		}

		// Token: 0x06036E7D RID: 224893 RVA: 0x00F4ED54 File Offset: 0x00F4CF54
		public List<DangoBrawlLevelData> GetAllLevelDataList()
		{
			return new List<DangoBrawlLevelData>(this.LevelDataMap.Values);
		}

		// Token: 0x06036E7E RID: 224894 RVA: 0x00F4ED66 File Offset: 0x00F4CF66
		[NullableContext(2)]
		public DangoBrawlLevelData GetLevelData(int levelId)
		{
			return this.LevelDataMap.GetValueOrDefault(levelId);
		}

		// Token: 0x06036E7F RID: 224895 RVA: 0x00F4ED74 File Offset: 0x00F4CF74
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

		// Token: 0x06036E80 RID: 224896 RVA: 0x00F4EDF0 File Offset: 0x00F4CFF0
		[NullableContext(0)]
		public ValueTuple<int, int> GetLevelProgress(bool isNormalMode)
		{
			return NoLinq.CountWhere<DangoBrawlLevelData>(this.LevelDataMap.Values, (DangoBrawlLevelData level) => level.IsNormalMode == isNormalMode, (DangoBrawlLevelData level) => level.IsPassed);
		}

		// Token: 0x06036E81 RID: 224897 RVA: 0x00F4EE45 File Offset: 0x00F4D045
		public bool IsAllNormalLevelPassed()
		{
			return NoLinq.All<DangoBrawlLevelData>(this.LevelDataMap.Values, (DangoBrawlLevelData level) => !level.IsNormalMode || level.IsPassed);
		}

		// Token: 0x06036E82 RID: 224898 RVA: 0x00F4EE76 File Offset: 0x00F4D076
		[NullableContext(2)]
		public void UpdateSaveData(DangoBrawlSaveMatchBrief saveMatch)
		{
			this.SaveData = ((saveMatch == null) ? null : new DangoBrawlSaveData(saveMatch.ChallengeId, saveMatch.RoundNum, saveMatch.RoleId));
		}

		// Token: 0x06036E83 RID: 224899 RVA: 0x00F4EE9B File Offset: 0x00F4D09B
		public void ClearSaveData()
		{
			this.SaveData = null;
		}

		// Token: 0x06036E84 RID: 224900 RVA: 0x00F4EEA4 File Offset: 0x00F4D0A4
		public void SetIsEnterSave(bool isEnterSave)
		{
			this.IsEnterSave = isEnterSave;
		}

		// Token: 0x06036E85 RID: 224901 RVA: 0x00F4EEAD File Offset: 0x00F4D0AD
		public bool GetIsEnterSave()
		{
			return this.IsEnterSave;
		}

		// Token: 0x06036E86 RID: 224902 RVA: 0x00F4EEB5 File Offset: 0x00F4D0B5
		[NullableContext(2)]
		public DangoBrawlSaveData GetSaveData()
		{
			return this.SaveData;
		}

		// Token: 0x06036E87 RID: 224903 RVA: 0x00F4EEBD File Offset: 0x00F4D0BD
		public bool HasSaveData()
		{
			return this.SaveData != null && this.SaveData.LevelId > 0;
		}

		// Token: 0x06036E88 RID: 224904 RVA: 0x00F4EED7 File Offset: 0x00F4D0D7
		public int GetShopCoinCost()
		{
			return this.ShopCoinCost;
		}

		// Token: 0x06036E89 RID: 224905 RVA: 0x00F4EEDF File Offset: 0x00F4D0DF
		public void UpdateShopCoinCost(int coinCost)
		{
			this.ShopCoinCost = coinCost;
		}

		// Token: 0x06036E8A RID: 224906 RVA: 0x00F4EEE8 File Offset: 0x00F4D0E8
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

		// Token: 0x0401D12F RID: 119087
		private int ActivityId;

		// Token: 0x0401D130 RID: 119088
		private readonly List<int> UnlockRoleIdList = new List<int>();

		// Token: 0x0401D131 RID: 119089
		private readonly List<int> UnlockItemIdList = new List<int>();

		// Token: 0x0401D132 RID: 119090
		private readonly Dictionary<int, DangoBrawlLevelData> LevelDataMap = new Dictionary<int, DangoBrawlLevelData>();

		// Token: 0x0401D133 RID: 119091
		private bool IsEnterSave;

		// Token: 0x0401D134 RID: 119092
		[Nullable(2)]
		private DangoBrawlSaveData SaveData;

		// Token: 0x0401D135 RID: 119093
		private readonly List<int> UnlockNotifyRoleList = new List<int>();

		// Token: 0x0401D136 RID: 119094
		private readonly Dictionary<int, DangoBrawlTaskData> TaskDataMap = new Dictionary<int, DangoBrawlTaskData>();

		// Token: 0x0401D137 RID: 119095
		private int MilestoneItemId;

		// Token: 0x0401D138 RID: 119096
		private readonly HashSet<int> ScoreRewardReceivedIdSet = new HashSet<int>();

		// Token: 0x0401D139 RID: 119097
		private int ShopCoinCost;
	}
}
