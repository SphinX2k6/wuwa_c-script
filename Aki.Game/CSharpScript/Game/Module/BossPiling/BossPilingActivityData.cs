using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.BossPiling
{
	// Token: 0x02004BD8 RID: 19416
	[NullableContext(1)]
	[Nullable(0)]
	public class BossPilingActivityData : ActivityBaseData
	{
		// Token: 0x06030747 RID: 198471 RVA: 0x00D80D9C File Offset: 0x00D7EF9C
		protected override void OnInit(ActivityData data)
		{
			BossPilingActivityInfo bossPilingActivityInfo = data.BossPilingActivityInfo;
			if (bossPilingActivityInfo == null)
			{
				return;
			}
			this.UpdateTaskData(bossPilingActivityInfo.ConditionTasks);
			this.UpdateLevelData(bossPilingActivityInfo.BossPilingLevelInfos);
			if (BossPilingController.Instance.CacheBuffMap != null)
			{
				this.CurLevelId = BossPilingController.Instance.CacheLevelId;
				BossPilingController.Instance.CacheLevelId = 0;
				this.CurBuffMap = BossPilingController.Instance.CacheBuffMap;
				BossPilingController.Instance.CacheBuffMap = null;
			}
		}

		// Token: 0x06030748 RID: 198472 RVA: 0x00D80E10 File Offset: 0x00D7F010
		protected override void PhraseEx(ActivityData data)
		{
			BossPilingActivityInfo bossPilingActivityInfo = data.BossPilingActivityInfo;
			if (bossPilingActivityInfo == null)
			{
				return;
			}
			this.UpdateTaskData(bossPilingActivityInfo.ConditionTasks);
			this.UpdateLevelData(bossPilingActivityInfo.BossPilingLevelInfos);
		}

		// Token: 0x17006140 RID: 24896
		// (get) Token: 0x06030749 RID: 198473 RVA: 0x00D80E40 File Offset: 0x00D7F040
		public override bool RedPointShowState
		{
			get
			{
				return this.CheckIfInShowTime() && (base.GetIfFirstOpen() || this.CheckTaskRedDot() || this.CheckLevelRedDot());
			}
		}

		// Token: 0x0603074A RID: 198474 RVA: 0x00D80E68 File Offset: 0x00D7F068
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

		// Token: 0x0603074B RID: 198475 RVA: 0x00D80ED4 File Offset: 0x00D7F0D4
		public void UpdateTaskData(IReadOnlyList<ConditionTask> tasks)
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

		// Token: 0x0603074C RID: 198476 RVA: 0x00D8103C File Offset: 0x00D7F23C
		public List<BossPilingTaskInfo> GetBaseTaskGroupByLevel(int levelId)
		{
			return new List<BossPilingTaskInfo>(this.TaskLevelGroup.GetValueOrDefault(levelId) ?? new HashSet<BossPilingTaskInfo>());
		}

		// Token: 0x0603074D RID: 198477 RVA: 0x00D81058 File Offset: 0x00D7F258
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

		// Token: 0x0603074E RID: 198478 RVA: 0x00D81228 File Offset: 0x00D7F428
		public List<int> GetTaskTabList()
		{
			List<int> list = new List<int>(this.TaskLevelGroup.Keys);
			list.Sort((int a, int b) => a - b);
			return list;
		}

		// Token: 0x0603074F RID: 198479 RVA: 0x00D81260 File Offset: 0x00D7F460
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

		// Token: 0x06030750 RID: 198480 RVA: 0x00D812BC File Offset: 0x00D7F4BC
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

		// Token: 0x06030751 RID: 198481 RVA: 0x00D81324 File Offset: 0x00D7F524
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

		// Token: 0x06030752 RID: 198482 RVA: 0x00D813AC File Offset: 0x00D7F5AC
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

		// Token: 0x06030753 RID: 198483 RVA: 0x00D81418 File Offset: 0x00D7F618
		public void UpdateLevelData(IReadOnlyList<BossPilingLevelInfo> levels)
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
						SelectedRoleIds = new List<int>(bossPilingLevelInfo.SelectRoleIds),
						SelectedTagBranchIds = new List<int>(bossPilingLevelInfo.SkillBranchId),
						IsUnlock = this.CheckTimeIsUnlock(this.GetUnlockTime(bossPilingLevelInfo.UnlockTime))
					};
					this.LevelMap[bossPilingLevelInfo.Id] = value;
				}
			}
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
		}

		// Token: 0x06030754 RID: 198484 RVA: 0x00D8158C File Offset: 0x00D7F78C
		public List<BossPilingLevelInfo> GetAllLevelInfo()
		{
			List<BossPilingLevelInfo> list = new List<BossPilingLevelInfo>(this.LevelMap.Values);
			list.Sort((BossPilingLevelInfo a, BossPilingLevelInfo b) => a.Id - b.Id);
			return list;
		}

		// Token: 0x06030755 RID: 198485 RVA: 0x00D815C4 File Offset: 0x00D7F7C4
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

		// Token: 0x06030756 RID: 198486 RVA: 0x00D81680 File Offset: 0x00D7F880
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

		// Token: 0x06030757 RID: 198487 RVA: 0x00D816EC File Offset: 0x00D7F8EC
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

		// Token: 0x06030758 RID: 198488 RVA: 0x00D817D4 File Offset: 0x00D7F9D4
		public BossPilingLevelInfo GetLevelInfo(int id)
		{
			return this.LevelMap[id];
		}

		// Token: 0x06030759 RID: 198489 RVA: 0x00D817E2 File Offset: 0x00D7F9E2
		private int GetUnlockTime(long time)
		{
			return (int)((double)time * TimeUtil.Instance.Millisecond);
		}

		// Token: 0x0603075A RID: 198490 RVA: 0x00D817F2 File Offset: 0x00D7F9F2
		private bool CheckTimeIsUnlock(int time)
		{
			return (double)time <= TimeUtil.Instance.GetServerTime();
		}

		// Token: 0x0603075B RID: 198491 RVA: 0x00D81805 File Offset: 0x00D7FA05
		public void ClearDungeonInfo()
		{
			this.CurLevelId = 0;
			this.CurBuffMap.Clear();
			BossPilingModel.Instance.InstKeyBuffList.Clear();
		}

		// Token: 0x0603075C RID: 198492 RVA: 0x00D81828 File Offset: 0x00D7FA28
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

		// Token: 0x0603075D RID: 198493 RVA: 0x00D818AC File Offset: 0x00D7FAAC
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

		// Token: 0x0603075E RID: 198494 RVA: 0x00D81970 File Offset: 0x00D7FB70
		public Dictionary<int, int> GetDungeonBuff()
		{
			return this.CurBuffMap;
		}

		// Token: 0x0603075F RID: 198495 RVA: 0x00D81978 File Offset: 0x00D7FB78
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

		// Token: 0x06030760 RID: 198496 RVA: 0x00D81A04 File Offset: 0x00D7FC04
		public bool CheckLevelRedDotById(int levelId)
		{
			BossPilingLevelInfo bossPilingLevelInfo;
			this.LevelMap.TryGetValue(levelId, out bossPilingLevelInfo);
			return bossPilingLevelInfo != null && bossPilingLevelInfo.BossHp <= 0 && bossPilingLevelInfo.IsUnlock && !(LocalStorage.GetPlayer<HashSet<int>>(ELocalStoragePlayerKey.BossPilingLevelNew, null) ?? new HashSet<int>()).Contains(levelId);
		}

		// Token: 0x06030761 RID: 198497 RVA: 0x00D81A54 File Offset: 0x00D7FC54
		public void ClearLevelRedDotById(int levelId)
		{
			HashSet<int> hashSet = LocalStorage.GetPlayer<HashSet<int>>(ELocalStoragePlayerKey.BossPilingLevelNew, null) ?? new HashSet<int>();
			hashSet.Add(levelId);
			LocalStorage.SetPlayer<HashSet<int>>(ELocalStoragePlayerKey.BossPilingLevelNew, hashSet);
		}

		// Token: 0x06030762 RID: 198498 RVA: 0x00D81A8C File Offset: 0x00D7FC8C
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

		// Token: 0x04019A9C RID: 105116
		protected Dictionary<int, BossPilingTaskInfo> TaskMap = new Dictionary<int, BossPilingTaskInfo>();

		// Token: 0x04019A9D RID: 105117
		protected Dictionary<int, HashSet<BossPilingTaskInfo>> TaskLevelGroup = new Dictionary<int, HashSet<BossPilingTaskInfo>>();

		// Token: 0x04019A9E RID: 105118
		protected Dictionary<int, BossPilingLevelInfo> LevelMap = new Dictionary<int, BossPilingLevelInfo>();

		// Token: 0x04019A9F RID: 105119
		protected int CurLevelId;

		// Token: 0x04019AA0 RID: 105120
		protected Dictionary<int, int> CurBuffMap = new Dictionary<int, int>();
	}
}
