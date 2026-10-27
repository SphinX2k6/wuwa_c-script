using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.BossPiling
{
	// Token: 0x02005BF8 RID: 23544
	[NullableContext(1)]
	[Nullable(0)]
	public class BossPilingActivityData : ActivityBaseData
	{
		// Token: 0x0603B7FC RID: 243708 RVA: 0x00E30A98 File Offset: 0x00E2EC98
		protected override void OnInit(ActivityData data)
		{
			BossPilingActivityInfo bossPilingActivityInfo = data.BossPilingActivityInfo;
			if (bossPilingActivityInfo == null)
			{
				return;
			}
			this.UpdateTaskData(bossPilingActivityInfo.ConditionTasks.ToArray<ConditionTask>());
			this.UpdateLevelData(bossPilingActivityInfo.BossPilingLevelInfos.ToArray<BossPilingLevelInfo>());
			if (BossPilingController.Instance.CacheBuffMap != null)
			{
				this.CurLevelId = BossPilingController.Instance.CacheLevelId;
				BossPilingController.Instance.CacheLevelId = 0;
				this.CurBuffMap = BossPilingController.Instance.CacheBuffMap;
				BossPilingController.Instance.CacheBuffMap = null;
			}
		}

		// Token: 0x0603B7FD RID: 243709 RVA: 0x00E30B14 File Offset: 0x00E2ED14
		protected override void PhraseEx(ActivityData data)
		{
			BossPilingActivityInfo bossPilingActivityInfo = data.BossPilingActivityInfo;
			if (bossPilingActivityInfo == null)
			{
				return;
			}
			this.UpdateTaskData(bossPilingActivityInfo.ConditionTasks.ToArray<ConditionTask>());
			this.UpdateLevelData(bossPilingActivityInfo.BossPilingLevelInfos.ToArray<BossPilingLevelInfo>());
		}

		// Token: 0x17008D6E RID: 36206
		// (get) Token: 0x0603B7FE RID: 243710 RVA: 0x00E30B4E File Offset: 0x00E2ED4E
		public override bool RedPointShowState
		{
			get
			{
				return this.CheckIfInShowTime() && (base.GetIfFirstOpen() || this.CheckTaskRedDot() || this.CheckLevelRedDot());
			}
		}

		// Token: 0x0603B7FF RID: 243711 RVA: 0x00E30B74 File Offset: 0x00E2ED74
		protected override bool GetExDataFinishShowState()
		{
			foreach (KeyValuePair<int, BossPilingTaskInfo> keyValuePair in this.TaskMap)
			{
				int num;
				BossPilingTaskInfo bossPilingTaskInfo;
				keyValuePair.Deconstruct(out num, out bossPilingTaskInfo);
				if (bossPilingTaskInfo.Status != ConditionTaskState.ConditionTaskTaken)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0603B800 RID: 243712 RVA: 0x00E30BE0 File Offset: 0x00E2EDE0
		public void UpdateTaskData(ConditionTask[] tasks)
		{
			foreach (ConditionTask conditionTask in tasks)
			{
				if (this.TaskMap.ContainsKey(conditionTask.Id))
				{
					BossPilingTaskInfo bossPilingTaskInfo = this.TaskMap[conditionTask.Id];
					bossPilingTaskInfo.Current = conditionTask.Current;
					bossPilingTaskInfo.Target = conditionTask.Target;
					bossPilingTaskInfo.Status = conditionTask.Status;
				}
				else
				{
					BossPilingTaskInfo bossPilingTaskInfo2 = new BossPilingTaskInfo
					{
						Id = conditionTask.Id,
						Current = conditionTask.Current,
						Target = conditionTask.Target,
						Status = conditionTask.Status
					};
					this.TaskMap[conditionTask.Id] = bossPilingTaskInfo2;
					int belongLevel = BossPilingConfig.Instance.GetTaskInfo(conditionTask.Id).Value.BelongLevel;
					if (!this.TaskLevelGroup.ContainsKey(belongLevel))
					{
						this.TaskLevelGroup[belongLevel] = new HashSet<BossPilingTaskInfo>();
					}
					this.TaskLevelGroup[belongLevel].Add(bossPilingTaskInfo2);
				}
			}
			EventSystem.Instance.Emit(EEventName.OnBossPilingReward);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
		}

		// Token: 0x0603B801 RID: 243713 RVA: 0x00E30D1A File Offset: 0x00E2EF1A
		public List<BossPilingTaskInfo> GetBaseTaskGroupByLevel(int levelId)
		{
			return new List<BossPilingTaskInfo>(this.TaskLevelGroup.GetValueOrDefault(levelId) ?? new HashSet<BossPilingTaskInfo>());
		}

		// Token: 0x0603B802 RID: 243714 RVA: 0x00E30D38 File Offset: 0x00E2EF38
		public List<ActivityRewardData> GetTaskGroupByLevel(int levelId)
		{
			List<BossPilingTaskInfo> list = new List<BossPilingTaskInfo>(this.TaskLevelGroup.GetValueOrDefault(levelId) ?? new HashSet<BossPilingTaskInfo>());
			list.Sort(new Comparison<BossPilingTaskInfo>(this.TaskGroupSort));
			List<ActivityRewardData> list2 = new List<ActivityRewardData>();
			Action <>9__0;
			foreach (BossPilingTaskInfo bossPilingTaskInfo in list)
			{
				BossPilingTask value = BossPilingConfig.Instance.GetTaskInfo(bossPilingTaskInfo.Id).Value;
				List<TItem> dropPackagePreviewItemList = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(value.DropId);
				BossPilingLevelInfo levelInfo = this.GetLevelInfo(value.BelongLevel);
				ActivityRewardData activityRewardData = new ActivityRewardData();
				activityRewardData.Id = new int?(bossPilingTaskInfo.Id);
				activityRewardData.NameText = "";
				activityRewardData.NameTextId = "BossPilingActivity_Reward08";
				activityRewardData.RewardList = dropPackagePreviewItemList.ToArray();
				activityRewardData.NameTextArgs = new string[]
				{
					Math.Min(value.RewardCount, levelInfo.BossHp).ToString(),
					value.RewardCount.ToString()
				};
				activityRewardData.RewardState = BossPilingDefine.BossPilingTaskStateToRewardStateResolver[bossPilingTaskInfo.Status];
				activityRewardData.RewardButtonTextId = BossPilingDefine.BossPilingTaskStateToRewardText[bossPilingTaskInfo.Status];
				activityRewardData.RewardButtonRedDot = new bool?(bossPilingTaskInfo.Status == ConditionTaskState.ConditionTaskFinish);
				ActivityRewardData activityRewardData2 = activityRewardData;
				Action clickFunction;
				if ((clickFunction = <>9__0) == null)
				{
					clickFunction = (<>9__0 = delegate()
					{
						BossPilingController.Instance.RequestBossPilingReward(levelId);
					});
				}
				activityRewardData2.ClickFunction = clickFunction;
				ActivityRewardData item = activityRewardData;
				list2.Add(item);
			}
			return list2;
		}

		// Token: 0x0603B803 RID: 243715 RVA: 0x00E30F08 File Offset: 0x00E2F108
		public List<int> GetTaskTabList()
		{
			List<int> list = new List<int>(this.TaskLevelGroup.Keys);
			list.Sort((int a, int b) => a - b);
			return list;
		}

		// Token: 0x0603B804 RID: 243716 RVA: 0x00E30F40 File Offset: 0x00E2F140
		private int TaskGroupSort(BossPilingTaskInfo a, BossPilingTaskInfo b)
		{
			if (a.Status == b.Status)
			{
				return a.Id - b.Id;
			}
			int num = (a.Status == ConditionTaskState.ConditionTaskTaken) ? 2 : ((a.Status != ConditionTaskState.ConditionTaskFinish) ? 1 : 0);
			int num2 = (b.Status == ConditionTaskState.ConditionTaskTaken) ? 2 : ((b.Status != ConditionTaskState.ConditionTaskFinish) ? 1 : 0);
			return num - num2;
		}

		// Token: 0x0603B805 RID: 243717 RVA: 0x00E30F9C File Offset: 0x00E2F19C
		public bool CheckLevelTaskRedDot(int levelId)
		{
			HashSet<BossPilingTaskInfo> valueOrDefault = this.TaskLevelGroup.GetValueOrDefault(levelId);
			if (valueOrDefault == null)
			{
				return false;
			}
			using (HashSet<BossPilingTaskInfo>.Enumerator enumerator = valueOrDefault.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.Status == ConditionTaskState.ConditionTaskFinish)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x0603B806 RID: 243718 RVA: 0x00E31004 File Offset: 0x00E2F204
		public List<int> GetTaskNumState()
		{
			int num = 0;
			foreach (KeyValuePair<int, BossPilingTaskInfo> keyValuePair in this.TaskMap)
			{
				int num2;
				BossPilingTaskInfo bossPilingTaskInfo;
				keyValuePair.Deconstruct(out num2, out bossPilingTaskInfo);
				BossPilingTaskInfo bossPilingTaskInfo2 = bossPilingTaskInfo;
				num += ((bossPilingTaskInfo2.Status == ConditionTaskState.ConditionTaskTaken) ? 1 : 0);
			}
			return new List<int>
			{
				num,
				this.TaskMap.Count
			};
		}

		// Token: 0x0603B807 RID: 243719 RVA: 0x00E3108C File Offset: 0x00E2F28C
		public bool CheckTaskRedDot()
		{
			foreach (KeyValuePair<int, BossPilingTaskInfo> keyValuePair in this.TaskMap)
			{
				int num;
				BossPilingTaskInfo bossPilingTaskInfo;
				keyValuePair.Deconstruct(out num, out bossPilingTaskInfo);
				if (bossPilingTaskInfo.Status == ConditionTaskState.ConditionTaskFinish)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0603B808 RID: 243720 RVA: 0x00E310F8 File Offset: 0x00E2F2F8
		public void UpdateLevelData(BossPilingLevelInfo[] levels)
		{
			foreach (BossPilingLevelInfo bossPilingLevelInfo in levels)
			{
				if (this.LevelMap.ContainsKey(bossPilingLevelInfo.Id))
				{
					BossPilingLevelInfo bossPilingLevelInfo2 = this.LevelMap[bossPilingLevelInfo.Id];
					bossPilingLevelInfo2.BossHp = bossPilingLevelInfo.BossHpNum;
					bossPilingLevelInfo2.UnlockTime = this.GetUnlockTime(bossPilingLevelInfo.UnlockTime);
					bossPilingLevelInfo2.SelectedRoleIds.Clear();
					bossPilingLevelInfo2.SelectedRoleIds.AddRange(bossPilingLevelInfo.SelectRoleIds);
					bossPilingLevelInfo2.SelectedTagBranchIds.Clear();
					bossPilingLevelInfo2.SelectedTagBranchIds.AddRange(bossPilingLevelInfo.SkillBranchId);
					bossPilingLevelInfo2.IsUnlock = this.CheckTimeIsUnlock(bossPilingLevelInfo2.UnlockTime);
				}
				else
				{
					BossPilingLevelInfo value = new BossPilingLevelInfo
					{
						Id = bossPilingLevelInfo.Id,
						BossHp = bossPilingLevelInfo.BossHpNum,
						UnlockTime = this.GetUnlockTime(bossPilingLevelInfo.UnlockTime),
						SelectedRoleIds = bossPilingLevelInfo.SelectRoleIds.ToList<int>(),
						SelectedTagBranchIds = bossPilingLevelInfo.SkillBranchId.ToList<int>(),
						IsUnlock = this.CheckTimeIsUnlock(this.GetUnlockTime(bossPilingLevelInfo.UnlockTime))
					};
					this.LevelMap[bossPilingLevelInfo.Id] = value;
				}
			}
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
		}

		// Token: 0x0603B809 RID: 243721 RVA: 0x00E31242 File Offset: 0x00E2F442
		public List<BossPilingLevelInfo> GetAllLevelInfo()
		{
			List<BossPilingLevelInfo> list = new List<BossPilingLevelInfo>(this.LevelMap.Values);
			list.Sort((BossPilingLevelInfo a, BossPilingLevelInfo b) => a.Id - b.Id);
			return list;
		}

		// Token: 0x0603B80A RID: 243722 RVA: 0x00E3127C File Offset: 0x00E2F47C
		public List<int> GetStarAchievement(int level)
		{
			BossPilingLevels? levelInfo = BossPilingConfig.Instance.GetLevelInfo(level);
			BossPilingLevelInfo valueOrDefault = this.LevelMap.GetValueOrDefault(level);
			if (levelInfo == null || valueOrDefault == null)
			{
				return new List<int>
				{
					0,
					0
				};
			}
			int num = 0;
			using (IEnumerator<int> enumerator = levelInfo.Value.AchievementIter().GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current <= valueOrDefault.BossHp)
					{
						num++;
					}
				}
			}
			return new List<int>
			{
				num,
				levelInfo.Value.Achievement().Length
			};
		}

		// Token: 0x0603B80B RID: 243723 RVA: 0x00E31338 File Offset: 0x00E2F538
		public void RefreshUnlockState()
		{
			foreach (KeyValuePair<int, BossPilingLevelInfo> keyValuePair in this.LevelMap)
			{
				int num;
				BossPilingLevelInfo bossPilingLevelInfo;
				keyValuePair.Deconstruct(out num, out bossPilingLevelInfo);
				BossPilingLevelInfo bossPilingLevelInfo2 = bossPilingLevelInfo;
				bossPilingLevelInfo2.IsUnlock = this.CheckTimeIsUnlock(bossPilingLevelInfo2.UnlockTime);
			}
		}

		// Token: 0x0603B80C RID: 243724 RVA: 0x00E313A4 File Offset: 0x00E2F5A4
		public int GetFirstSelectLevel()
		{
			int num = 0;
			foreach (KeyValuePair<int, BossPilingLevelInfo> keyValuePair in this.LevelMap)
			{
				int num2;
				BossPilingLevelInfo bossPilingLevelInfo;
				keyValuePair.Deconstruct(out num2, out bossPilingLevelInfo);
				int num3 = num2;
				if (bossPilingLevelInfo.IsUnlock)
				{
					List<int> starAchievement = this.GetStarAchievement(num3);
					int num4 = starAchievement[0];
					int num5 = starAchievement[1];
					if (num4 < num5 && (num == 0 || num > num3))
					{
						num = num3;
					}
				}
			}
			if (num == 0)
			{
				foreach (KeyValuePair<int, BossPilingLevelInfo> keyValuePair in this.LevelMap)
				{
					int num2;
					BossPilingLevelInfo bossPilingLevelInfo;
					keyValuePair.Deconstruct(out num2, out bossPilingLevelInfo);
					int num6 = num2;
					if (bossPilingLevelInfo.IsUnlock)
					{
						num = num6;
						break;
					}
				}
			}
			return num;
		}

		// Token: 0x0603B80D RID: 243725 RVA: 0x00E3148C File Offset: 0x00E2F68C
		public BossPilingLevelInfo GetLevelInfo(int id)
		{
			return this.LevelMap[id];
		}

		// Token: 0x0603B80E RID: 243726 RVA: 0x00E3149A File Offset: 0x00E2F69A
		private int GetUnlockTime(long time)
		{
			return (int)((double)time * TimeUtil.Instance.Millisecond);
		}

		// Token: 0x0603B80F RID: 243727 RVA: 0x00E314AA File Offset: 0x00E2F6AA
		private bool CheckTimeIsUnlock(int time)
		{
			return (double)time <= TimeUtil.Instance.GetServerTime();
		}

		// Token: 0x0603B810 RID: 243728 RVA: 0x00E314BD File Offset: 0x00E2F6BD
		public void ClearDungeonInfo()
		{
			this.CurLevelId = 0;
			this.CurBuffMap.Clear();
			BossPilingModel.Instance.InstKeyBuffList.Clear();
		}

		// Token: 0x0603B811 RID: 243729 RVA: 0x00E314E0 File Offset: 0x00E2F6E0
		public void InitDungeon(int levelId, Dictionary<int, int> buffInfo)
		{
			this.CurLevelId = levelId;
			this.CurBuffMap.Clear();
			BossPilingModel.Instance.InstKeyBuffList.Clear();
			foreach (int key in buffInfo.Keys)
			{
				int value = buffInfo[key];
				this.CurBuffMap[key] = value;
			}
		}

		// Token: 0x0603B812 RID: 243730 RVA: 0x00E31564 File Offset: 0x00E2F764
		public void UpdateDungeonBuff(Dictionary<int, int> buffInfo)
		{
			foreach (int num in buffInfo.Keys)
			{
				int num2 = buffInfo[num];
				int oldValue;
				this.CurBuffMap.TryGetValue(num, out oldValue);
				BossPilingNewBuffInfo param = new BossPilingNewBuffInfo
				{
					BuffId = num,
					OldValue = oldValue,
					NewValue = num2,
					NeedAccelerate = (buffInfo.Count > 1)
				};
				BossPilingModel.Instance.InstBuffAcquireCount++;
				UiManager.Instance.OpenView(EUiViewName.BossPilingNewBuffTipsView, param, null);
				this.CurBuffMap[num] = num2;
			}
		}

		// Token: 0x0603B813 RID: 243731 RVA: 0x00E31628 File Offset: 0x00E2F828
		public Dictionary<int, int> GetDungeonBuff()
		{
			return this.CurBuffMap;
		}

		// Token: 0x0603B814 RID: 243732 RVA: 0x00E31630 File Offset: 0x00E2F830
		public bool CheckLevelRedDot()
		{
			if (!base.GetPreGuideQuestFinishState())
			{
				return base.IsUnLock() && !LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.BossPilingQuestClicked, false);
			}
			foreach (KeyValuePair<int, BossPilingLevelInfo> keyValuePair in this.LevelMap)
			{
				int num;
				BossPilingLevelInfo bossPilingLevelInfo;
				keyValuePair.Deconstruct(out num, out bossPilingLevelInfo);
				int levelId = num;
				if (this.CheckLevelRedDotById(levelId))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0603B815 RID: 243733 RVA: 0x00E316BC File Offset: 0x00E2F8BC
		public bool CheckLevelRedDotById(int levelId)
		{
			BossPilingLevelInfo bossPilingLevelInfo;
			this.LevelMap.TryGetValue(levelId, out bossPilingLevelInfo);
			return bossPilingLevelInfo != null && bossPilingLevelInfo.BossHp <= 0 && bossPilingLevelInfo.IsUnlock && !(LocalStorage.GetPlayer<HashSet<int>>(ELocalStoragePlayerKey.BossPilingLevelNew, null) ?? new HashSet<int>()).Contains(levelId);
		}

		// Token: 0x0603B816 RID: 243734 RVA: 0x00E3170C File Offset: 0x00E2F90C
		public void ClearLevelRedDotById(int levelId)
		{
			HashSet<int> hashSet = LocalStorage.GetPlayer<HashSet<int>>(ELocalStoragePlayerKey.BossPilingLevelNew, null) ?? new HashSet<int>();
			hashSet.Add(levelId);
			LocalStorage.SetPlayer<HashSet<int>>(ELocalStoragePlayerKey.BossPilingLevelNew, hashSet);
		}

		// Token: 0x0603B817 RID: 243735 RVA: 0x00E31744 File Offset: 0x00E2F944
		public void ClearLevelRedDot()
		{
			HashSet<int> hashSet = LocalStorage.GetPlayer<HashSet<int>>(ELocalStoragePlayerKey.BossPilingLevelNew, null) ?? new HashSet<int>();
			foreach (KeyValuePair<int, BossPilingLevelInfo> keyValuePair in this.LevelMap)
			{
				int num;
				BossPilingLevelInfo bossPilingLevelInfo;
				keyValuePair.Deconstruct(out num, out bossPilingLevelInfo);
				int item = num;
				if (bossPilingLevelInfo.IsUnlock)
				{
					hashSet.Add(item);
				}
			}
			LocalStorage.SetPlayer<HashSet<int>>(ELocalStoragePlayerKey.BossPilingLevelNew, hashSet);
		}

		// Token: 0x0401EFEB RID: 126955
		protected Dictionary<int, BossPilingTaskInfo> TaskMap = new Dictionary<int, BossPilingTaskInfo>();

		// Token: 0x0401EFEC RID: 126956
		protected Dictionary<int, HashSet<BossPilingTaskInfo>> TaskLevelGroup = new Dictionary<int, HashSet<BossPilingTaskInfo>>();

		// Token: 0x0401EFED RID: 126957
		protected Dictionary<int, BossPilingLevelInfo> LevelMap = new Dictionary<int, BossPilingLevelInfo>();

		// Token: 0x0401EFEE RID: 126958
		protected int CurLevelId;

		// Token: 0x0401EFEF RID: 126959
		protected Dictionary<int, int> CurBuffMap = new Dictionary<int, int>();
	}
}
