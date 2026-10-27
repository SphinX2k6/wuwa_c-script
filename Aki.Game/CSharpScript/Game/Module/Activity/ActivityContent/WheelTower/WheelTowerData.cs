using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower
{
	// Token: 0x02005F1D RID: 24349
	[NullableContext(1)]
	[Nullable(0)]
	public class WheelTowerData : ActivityBaseData
	{
		// Token: 0x17008EF9 RID: 36601
		// (get) Token: 0x0603DDC4 RID: 253380 RVA: 0x00EF3A40 File Offset: 0x00EF1C40
		// (set) Token: 0x0603DDC5 RID: 253381 RVA: 0x00EF3A48 File Offset: 0x00EF1C48
		public int CycleId { get; private set; } = -1;

		// Token: 0x17008EFA RID: 36602
		// (get) Token: 0x0603DDC6 RID: 253382 RVA: 0x00EF3A51 File Offset: 0x00EF1C51
		// (set) Token: 0x0603DDC7 RID: 253383 RVA: 0x00EF3A59 File Offset: 0x00EF1C59
		public double CycleBeginTime { get; private set; } = -1.0;

		// Token: 0x17008EFB RID: 36603
		// (get) Token: 0x0603DDC8 RID: 253384 RVA: 0x00EF3A62 File Offset: 0x00EF1C62
		// (set) Token: 0x0603DDC9 RID: 253385 RVA: 0x00EF3A6A File Offset: 0x00EF1C6A
		public double CycleEndTime { get; private set; } = -1.0;

		// Token: 0x17008EFC RID: 36604
		// (get) Token: 0x0603DDCA RID: 253386 RVA: 0x00EF3A73 File Offset: 0x00EF1C73
		// (set) Token: 0x0603DDCB RID: 253387 RVA: 0x00EF3A7B File Offset: 0x00EF1C7B
		public bool IsRequestedRecommendLineUp { get; private set; }

		// Token: 0x17008EFD RID: 36605
		// (get) Token: 0x0603DDCC RID: 253388 RVA: 0x00EF3A84 File Offset: 0x00EF1C84
		// (set) Token: 0x0603DDCD RID: 253389 RVA: 0x00EF3A8C File Offset: 0x00EF1C8C
		public int SeasonId { get; private set; } = 1;

		// Token: 0x17008EFE RID: 36606
		// (get) Token: 0x0603DDCE RID: 253390 RVA: 0x00EF3A95 File Offset: 0x00EF1C95
		// (set) Token: 0x0603DDCF RID: 253391 RVA: 0x00EF3A9D File Offset: 0x00EF1C9D
		public double SeasonBeginTime { get; private set; }

		// Token: 0x17008EFF RID: 36607
		// (get) Token: 0x0603DDD0 RID: 253392 RVA: 0x00EF3AA6 File Offset: 0x00EF1CA6
		// (set) Token: 0x0603DDD1 RID: 253393 RVA: 0x00EF3AAE File Offset: 0x00EF1CAE
		public double SeasonEndTime { get; private set; }

		// Token: 0x0603DDD2 RID: 253394 RVA: 0x00EF3AB8 File Offset: 0x00EF1CB8
		protected override void PhraseEx(ActivityData data)
		{
			WheelTowerModel.Instance.SetActivityId(base.Id);
			NewTowerClimbingActivityData newTowerClimbingActivityData = data.NewTowerClimbingActivityData;
			if (newTowerClimbingActivityData == null)
			{
				return;
			}
			this.ParseCycleInfo(newTowerClimbingActivityData);
			this.ParseLevelRecord(newTowerClimbingActivityData.Records.ToList<NewTowerClimbingLevelRecord>());
			this.ParseEnergyInfo(newTowerClimbingActivityData.Records.ToList<NewTowerClimbingLevelRecord>());
			this.ParseTaskInfo(newTowerClimbingActivityData);
			this.ParseSeasonInfo(newTowerClimbingActivityData);
		}

		// Token: 0x0603DDD3 RID: 253395 RVA: 0x00EF3B18 File Offset: 0x00EF1D18
		private void ParseCycleInfo(NewTowerClimbingActivityData activityData)
		{
			if (this.CycleId != -1 && this.CycleId != activityData.CycleId)
			{
				EventSystem.Instance.Emit(EEventName.WheelTowerCycleChange);
			}
			this.CycleId = activityData.CycleId;
			this.CycleBeginTime = (double)MathUtils.Instance.LongToNumber(activityData.CycleBeginTime);
			this.CycleEndTime = (double)MathUtils.Instance.LongToNumber(activityData.CycleCloseTime);
		}

		// Token: 0x0603DDD4 RID: 253396 RVA: 0x00EF3B88 File Offset: 0x00EF1D88
		private void ParseLevelRecord(List<NewTowerClimbingLevelRecord> levelRecords)
		{
			this.LevelRecordMap.Clear();
			foreach (NewTowerClimbingLevelRecord newTowerClimbingLevelRecord in levelRecords)
			{
				NewTowerLevel? levelConfigById = WheelTowerConfig.Instance.GetLevelConfigById(newTowerClimbingLevelRecord.LevelId);
				if (levelConfigById != null)
				{
					bool key = levelConfigById.Value.Diff != 0;
					this.LevelRecordMap[key] = newTowerClimbingLevelRecord;
				}
			}
			this.UpdateLevelRecordRoleId();
		}

		// Token: 0x0603DDD5 RID: 253397 RVA: 0x00EF3C1C File Offset: 0x00EF1E1C
		private void UpdateLevelRecordRoleId()
		{
			foreach (NewTowerClimbingLevelRecord newTowerClimbingLevelRecord in this.LevelRecordMap.Values)
			{
				foreach (TeamChallengeInfo teamChallengeInfo in newTowerClimbingLevelRecord.TeamChallengeInfos)
				{
					foreach (RoleSaveInfo roleSaveInfo in teamChallengeInfo.RoleSaveInfos)
					{
						roleSaveInfo.RoleId = this.CheckMainCharacterCorrect(roleSaveInfo.RoleId);
					}
				}
			}
		}

		// Token: 0x0603DDD6 RID: 253398 RVA: 0x00EF3CE8 File Offset: 0x00EF1EE8
		private void ParseEnergyInfo(List<NewTowerClimbingLevelRecord> levelRecords)
		{
			this.EnergyInfoMap.Clear();
			foreach (NewTowerClimbingLevelRecord newTowerClimbingLevelRecord in levelRecords)
			{
				NewTowerLevel? levelConfigById = WheelTowerConfig.Instance.GetLevelConfigById(newTowerClimbingLevelRecord.LevelId);
				if (levelConfigById != null)
				{
					bool key = levelConfigById.Value.Diff != 0;
					Dictionary<int, int> dictionary = new Dictionary<int, int>();
					foreach (KeyValuePair<int, int> keyValuePair in newTowerClimbingLevelRecord.RoleEnergyDict)
					{
						dictionary[this.CheckMainCharacterCorrect(keyValuePair.Key)] = keyValuePair.Value;
					}
					this.EnergyInfoMap[key] = this.CreateEnergyInfo(dictionary, newTowerClimbingLevelRecord.TeamChallengeInfos.ToList<TeamChallengeInfo>());
				}
			}
		}

		// Token: 0x0603DDD7 RID: 253399 RVA: 0x00EF3DF0 File Offset: 0x00EF1FF0
		public EnergyInfo GetRoundEnergyInfo(bool endless, int round)
		{
			NewTowerClimbingLevelRecord levelRecord = this.GetLevelRecord(endless);
			Dictionary<int, int> dictionary = this.EnergyInfoMap[endless].RoleEnergyMap.ToDictionary((KeyValuePair<int, int> kv) => kv.Key, (KeyValuePair<int, int> kv) => kv.Value);
			for (int i = round; i < levelRecord.TeamChallengeInfos.Count; i++)
			{
				foreach (RoleSaveInfo roleSaveInfo in levelRecord.TeamChallengeInfos[i].RoleSaveInfos)
				{
					int num = WheelTowerModel.Instance.TryGetRealRoleId(roleSaveInfo.RoleId);
					int roleCost = WheelTowerModel.Instance.GetRoleCost(num);
					int num2 = dictionary[num];
					dictionary[num] = num2 + roleCost;
				}
			}
			return this.CreateEnergyInfo(dictionary, levelRecord.TeamChallengeInfos.Take(round).ToList<TeamChallengeInfo>());
		}

		// Token: 0x0603DDD8 RID: 253400 RVA: 0x00EF3F08 File Offset: 0x00EF2108
		private EnergyInfo CreateEnergyInfo(Dictionary<int, int> roleEnergyDict, List<TeamChallengeInfo> teamChallengeInfos)
		{
			EnergyInfo energyInfo = new EnergyInfo();
			foreach (KeyValuePair<int, int> keyValuePair in roleEnergyDict)
			{
				energyInfo.RoleEnergyMap[keyValuePair.Key] = keyValuePair.Value;
			}
			foreach (TeamChallengeInfo teamChallengeInfo in teamChallengeInfos)
			{
				foreach (RoleSaveInfo roleSaveInfo in teamChallengeInfo.RoleSaveInfos)
				{
					int num = WheelTowerModel.Instance.TryGetRealRoleId(roleSaveInfo.RoleId);
					if (roleSaveInfo.WeaponIncId != 0)
					{
						energyInfo.WeaponEnergyMap[roleSaveInfo.WeaponIncId] = num;
					}
					foreach (int num2 in roleSaveInfo.PhantomIncId)
					{
						if (num2 != 0)
						{
							energyInfo.PhantomEnergyMap[num2] = num;
						}
					}
					energyInfo.SkillBranchMap[num] = roleSaveInfo.SkillBranchId;
				}
			}
			return energyInfo;
		}

		// Token: 0x0603DDD9 RID: 253401 RVA: 0x00EF4080 File Offset: 0x00EF2280
		public int CheckMainCharacterCorrect(int roleId)
		{
			int roleId2 = WheelTowerModel.Instance.TryGetRealRoleId(roleId);
			if (!RoleModel.Instance.IsMainRole(roleId2))
			{
				return roleId;
			}
			int valueOrDefault = RoleModel.Instance.GetCurSelectMainRoleId().GetValueOrDefault();
			if (WheelTowerModel.Instance.IsTemplateRole(roleId))
			{
				return WheelTowerModel.Instance.GetTemplateRoleId(valueOrDefault);
			}
			return valueOrDefault;
		}

		// Token: 0x0603DDDA RID: 253402 RVA: 0x00EF40D8 File Offset: 0x00EF22D8
		private void ParseTaskInfo(NewTowerClimbingActivityData activityData)
		{
			Dictionary<int, int> dictionary = new Dictionary<int, int>();
			foreach (NewTowerClimbingLevelRecord newTowerClimbingLevelRecord in activityData.Records)
			{
				NewTowerLevel? levelConfigById = WheelTowerConfig.Instance.GetLevelConfigById(newTowerClimbingLevelRecord.LevelId);
				if (levelConfigById != null)
				{
					int diff = levelConfigById.Value.Diff;
					IReadOnlyList<NewTowerScoreReward> rewardConfigListByLevelId = WheelTowerConfig.Instance.GetRewardConfigListByLevelId(newTowerClimbingLevelRecord.LevelId);
					if (rewardConfigListByLevelId != null)
					{
						foreach (NewTowerScoreReward newTowerScoreReward in rewardConfigListByLevelId)
						{
							dictionary[newTowerScoreReward.Id] = diff;
						}
					}
				}
			}
			this.TaskMap.Clear();
			foreach (ActivityTask task in activityData.ActivityTasks)
			{
				global::ActivityTaskData activityTaskData = new global::ActivityTaskData();
				activityTaskData.Refresh(task, null);
				int typeId;
				if (dictionary.TryGetValue(activityTaskData.Id, out typeId))
				{
					activityTaskData.TypeId = typeId;
				}
				this.TaskMap[activityTaskData.Id] = activityTaskData;
			}
		}

		// Token: 0x0603DDDB RID: 253403 RVA: 0x00EF4238 File Offset: 0x00EF2438
		public void ParseSeasonInfo(NewTowerClimbingActivityData activityData)
		{
			this.SeasonId = activityData.SeasonId;
			this.SeasonBeginTime = (double)MathUtils.Instance.LongToNumber(activityData.SeasonBeginTime);
			this.SeasonEndTime = (double)MathUtils.Instance.LongToNumber(activityData.SeasonCloseTime);
			this.ReceivedSeasonScoreRewards.Clear();
			this.ReceivedSeasonScoreRewards.AddRange(activityData.ScoreTasks);
			this.SeasonTaskDataMap.Clear();
			this.UpdateSeasonTaskList(activityData.SeasonTasks.ToList<ActivityTask>());
		}

		// Token: 0x0603DDDC RID: 253404 RVA: 0x00EF42B8 File Offset: 0x00EF24B8
		public void UpdateSeasonTaskList(IList<ActivityTask> taskList)
		{
			foreach (ActivityTask task in taskList)
			{
				this.UpdateSeasonTask(task);
			}
		}

		// Token: 0x0603DDDD RID: 253405 RVA: 0x00EF4300 File Offset: 0x00EF2500
		public void RemoveSeasonTaskList(IList<int> taskIds)
		{
			foreach (int key in taskIds)
			{
				this.SeasonTaskDataMap.Remove(key);
			}
		}

		// Token: 0x0603DDDE RID: 253406 RVA: 0x00EF4350 File Offset: 0x00EF2550
		private void UpdateSeasonTask(ActivityTask task)
		{
			global::ActivityTaskData activityTaskData;
			if (!this.SeasonTaskDataMap.TryGetValue(task.Id, out activityTaskData))
			{
				activityTaskData = new global::ActivityTaskData();
			}
			activityTaskData.Refresh(task, null);
			this.SeasonTaskDataMap[task.Id] = activityTaskData;
		}

		// Token: 0x0603DDDF RID: 253407 RVA: 0x00EF4392 File Offset: 0x00EF2592
		public bool IsInCycle()
		{
			return this.CycleId > 0;
		}

		// Token: 0x0603DDE0 RID: 253408 RVA: 0x00EF43A0 File Offset: 0x00EF25A0
		public bool IsInCycleTime()
		{
			double serverTime = TimeUtil.Instance.GetServerTime();
			return serverTime >= this.CycleBeginTime && serverTime <= this.CycleEndTime;
		}

		// Token: 0x0603DDE1 RID: 253409 RVA: 0x00EF43CF File Offset: 0x00EF25CF
		public double GetCycleRemainTime()
		{
			return (double)base.EndShowTime - Time.Instance.ServerTimeStamp / 1000.0;
		}

		// Token: 0x0603DDE2 RID: 253410 RVA: 0x00EF43F0 File Offset: 0x00EF25F0
		public CommonDefine.ICountDown GetCycleCountDownData()
		{
			double num = this.GetCycleRemainTime();
			if (num <= 1.0)
			{
				num = 1.0;
			}
			CommonDefine.ETimeType value = (num >= 86400.0) ? CommonDefine.ETimeType.Day : ((num >= 3600.0) ? CommonDefine.ETimeType.Hour : CommonDefine.ETimeType.Minute);
			CommonDefine.ETimeType value2 = (num >= 86400.0) ? CommonDefine.ETimeType.Hour : ((num >= 3600.0) ? CommonDefine.ETimeType.Minute : CommonDefine.ETimeType.Second);
			return TimeUtil.Instance.GetCountDownDataFormat2(num, new CommonDefine.ETimeType?(value), new CommonDefine.ETimeType?(value2));
		}

		// Token: 0x0603DDE3 RID: 253411 RVA: 0x00EF4471 File Offset: 0x00EF2671
		public bool IsTowerUnlocked()
		{
			if (!base.IsUnLock())
			{
				return false;
			}
			return this.LevelRecordMap.Values.Any((NewTowerClimbingLevelRecord levelRecord) => levelRecord.IsUnlock);
		}

		// Token: 0x0603DDE4 RID: 253412 RVA: 0x00EF44AC File Offset: 0x00EF26AC
		public NewTowerClimbingLevelRecord GetLevelRecord(bool isEndless)
		{
			return this.LevelRecordMap[isEndless];
		}

		// Token: 0x0603DDE5 RID: 253413 RVA: 0x00EF44BC File Offset: 0x00EF26BC
		public bool IsLevelUnlocked(bool endless)
		{
			NewTowerClimbingLevelRecord newTowerClimbingLevelRecord;
			return this.LevelRecordMap.TryGetValue(endless, out newTowerClimbingLevelRecord) && newTowerClimbingLevelRecord.IsUnlock;
		}

		// Token: 0x0603DDE6 RID: 253414 RVA: 0x00EF44E1 File Offset: 0x00EF26E1
		public int GetHistoryBestScore(bool isEndless)
		{
			return this.GetLevelRecord(isEndless).HistoryScore;
		}

		// Token: 0x0603DDE7 RID: 253415 RVA: 0x00EF44EF File Offset: 0x00EF26EF
		public int GetRoundScore(bool isEndless, int round)
		{
			TeamChallengeInfo teamChallengeInfo = this.GetLevelRecord(isEndless).TeamChallengeInfos.ElementAtOrDefault(round);
			if (teamChallengeInfo == null)
			{
				return 0;
			}
			return teamChallengeInfo.TeamScore;
		}

		// Token: 0x0603DDE8 RID: 253416 RVA: 0x00EF4510 File Offset: 0x00EF2710
		public int GetRoundTotalScore(bool isEndless, int round)
		{
			int num = 0;
			for (int i = 0; i <= round; i++)
			{
				num += this.GetRoundScore(isEndless, i);
			}
			return num;
		}

		// Token: 0x0603DDE9 RID: 253417 RVA: 0x00EF4537 File Offset: 0x00EF2737
		public int GetTotalScore(bool isEndless)
		{
			if (this.GetLevelRecord(isEndless).TeamChallengeInfos.Count > 0)
			{
				return this.GetRoundTotalScore(isEndless, this.GetLevelRecord(isEndless).TeamChallengeInfos.Count - 1);
			}
			return 0;
		}

		// Token: 0x0603DDEA RID: 253418 RVA: 0x00EF456C File Offset: 0x00EF276C
		public bool IsRewardCanReceive(int rewardId)
		{
			global::ActivityTaskData activityTaskData;
			return this.TaskMap.TryGetValue(rewardId, out activityTaskData) && activityTaskData.Status == EActivityTaskState.FinishedAndUnclaimed;
		}

		// Token: 0x0603DDEB RID: 253419 RVA: 0x00EF4594 File Offset: 0x00EF2794
		public bool IsRewardCompleted(int rewardId)
		{
			global::ActivityTaskData activityTaskData;
			return this.TaskMap.TryGetValue(rewardId, out activityTaskData) && activityTaskData.Status == EActivityTaskState.FinishedAndClaimed;
		}

		// Token: 0x0603DDEC RID: 253420 RVA: 0x00EF45BC File Offset: 0x00EF27BC
		public bool HasAnyRewardCanReceive(EFilterMode filterMode = EFilterMode.All)
		{
			return this.GetCanReceiveRewardId(filterMode).Count > 0;
		}

		// Token: 0x0603DDED RID: 253421 RVA: 0x00EF45CD File Offset: 0x00EF27CD
		public EActivityTaskState GetTaskState(int taskId)
		{
			return this.TaskMap[taskId].Status;
		}

		// Token: 0x0603DDEE RID: 253422 RVA: 0x00EF45E0 File Offset: 0x00EF27E0
		public global::ActivityTaskData GetTask(int taskId)
		{
			return this.TaskMap[taskId];
		}

		// Token: 0x0603DDEF RID: 253423 RVA: 0x00EF45F0 File Offset: 0x00EF27F0
		public List<global::ActivityTaskData> GetFilterTaskList(EFilterMode filterMode = EFilterMode.All)
		{
			List<global::ActivityTaskData> list = this.TaskMap.Values.ToList<global::ActivityTaskData>();
			List<global::ActivityTaskData> result;
			if (filterMode != EFilterMode.Normal)
			{
				if (filterMode != EFilterMode.Endless)
				{
					result = list;
				}
				else
				{
					result = (from task in list
					where task.TypeId != 0
					select task).ToList<global::ActivityTaskData>();
				}
			}
			else
			{
				result = (from task in list
				where task.TypeId == 0
				select task).ToList<global::ActivityTaskData>();
			}
			return result;
		}

		// Token: 0x0603DDF0 RID: 253424 RVA: 0x00EF4678 File Offset: 0x00EF2878
		public List<int> GetCanReceiveRewardId(EFilterMode filterMode = EFilterMode.All)
		{
			return (from task in this.GetFilterTaskList(filterMode)
			where task.Status == EActivityTaskState.FinishedAndUnclaimed
			select task.Id).ToList<int>();
		}

		// Token: 0x0603DDF1 RID: 253425 RVA: 0x00EF46D9 File Offset: 0x00EF28D9
		public int GetCurrentRewardProgress(EFilterMode filterMode = EFilterMode.All)
		{
			return this.GetFilterTaskList(filterMode).Count((global::ActivityTaskData task) => task.Status == EActivityTaskState.FinishedAndClaimed);
		}

		// Token: 0x0603DDF2 RID: 253426 RVA: 0x00EF4706 File Offset: 0x00EF2906
		public int GetTotalRewardProgress(EFilterMode filterMode = EFilterMode.All)
		{
			return this.GetFilterTaskList(filterMode).Count;
		}

		// Token: 0x0603DDF3 RID: 253427 RVA: 0x00EF4714 File Offset: 0x00EF2914
		public void OnSeasonTaskClaim(IList<int> taskIdList)
		{
			foreach (int key in taskIdList)
			{
				global::ActivityTaskData activityTaskData;
				if (this.SeasonTaskDataMap.TryGetValue(key, out activityTaskData))
				{
					activityTaskData.Status = EActivityTaskState.FinishedAndClaimed;
				}
			}
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
		}

		// Token: 0x0603DDF4 RID: 253428 RVA: 0x00EF4784 File Offset: 0x00EF2984
		public void OnSeasonScoreClaim(IList<int> scoreIdList)
		{
			foreach (int item in scoreIdList)
			{
				if (!this.ReceivedSeasonScoreRewards.Contains(item))
				{
					this.ReceivedSeasonScoreRewards.Add(item);
				}
			}
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
		}

		// Token: 0x0603DDF5 RID: 253429 RVA: 0x00EF47F8 File Offset: 0x00EF29F8
		public List<global::ActivityTaskData> GetSeasonTaskList()
		{
			return this.SeasonTaskDataMap.Values.ToList<global::ActivityTaskData>();
		}

		// Token: 0x0603DDF6 RID: 253430 RVA: 0x00EF480C File Offset: 0x00EF2A0C
		public List<int> GetCanReceiveSeasonRewardIds()
		{
			return (from task in this.SeasonTaskDataMap.Values
			where task.Status == EActivityTaskState.FinishedAndUnclaimed
			select task.Id).ToList<int>();
		}

		// Token: 0x0603DDF7 RID: 253431 RVA: 0x00EF4874 File Offset: 0x00EF2A74
		public List<int> GetReceivedSeasonRewardIds()
		{
			return (from task in this.SeasonTaskDataMap.Values
			where task.Status == EActivityTaskState.FinishedAndClaimed
			select task.Id).ToList<int>();
		}

		// Token: 0x0603DDF8 RID: 253432 RVA: 0x00EF48DC File Offset: 0x00EF2ADC
		public List<int> GetCanReceiveSeasonScoreRewardIds()
		{
			IReadOnlyList<NewTowerSeasonSAward> seasonScoreRewardConfigList = WheelTowerConfig.Instance.GetSeasonScoreRewardConfigList(this.SeasonId);
			if (seasonScoreRewardConfigList == null)
			{
				return new List<int>();
			}
			int seasonScoreItemId = WheelTowerConfig.Instance.GetSeasonScoreItemId(this.SeasonId);
			int curScoreNum = InventoryModel.Instance.GetItemCountByConfigId(seasonScoreItemId, 0);
			return (from config in seasonScoreRewardConfigList
			where !this.ReceivedSeasonScoreRewards.Contains(config.Id) && curScoreNum >= config.Score
			select config.Id).ToList<int>();
		}

		// Token: 0x0603DDF9 RID: 253433 RVA: 0x00EF496E File Offset: 0x00EF2B6E
		public bool IsSeasonScoreRewardReceived(int rewardId)
		{
			return this.ReceivedSeasonScoreRewards.Contains(rewardId);
		}

		// Token: 0x0603DDFA RID: 253434 RVA: 0x00EF497C File Offset: 0x00EF2B7C
		public void OnAddNewRecord(NewTowerResultNotify notify)
		{
			int levelId = notify.LevelId;
			NewTowerLevel? levelConfigById = WheelTowerConfig.Instance.GetLevelConfigById(levelId);
			if (levelConfigById == null)
			{
				return;
			}
			bool flag = levelConfigById.Value.Diff != 0;
			NewTowerClimbingLevelRecord levelRecord = this.GetLevelRecord(flag);
			levelRecord.TeamChallengeInfos.Add(notify.TeamChallengeInfo);
			levelRecord.NextMonsterInfoPreview = notify.TeamChallengeInfo.LastMonsterInfoPreview;
			EnergyInfo energyInfo = this.EnergyInfoMap[flag];
			foreach (RoleSaveInfo roleSaveInfo in notify.TeamChallengeInfo.RoleSaveInfos)
			{
				int num = WheelTowerModel.Instance.TryGetRealRoleId(roleSaveInfo.RoleId);
				int roleCost = WheelTowerModel.Instance.GetRoleCost(num);
				energyInfo.RoleEnergyMap[num] = energyInfo.RoleEnergyMap[num] - roleCost;
				if (roleSaveInfo.WeaponIncId != 0)
				{
					energyInfo.WeaponEnergyMap[roleSaveInfo.WeaponIncId] = num;
				}
				foreach (int num2 in roleSaveInfo.PhantomIncId)
				{
					if (num2 != 0)
					{
						energyInfo.PhantomEnergyMap[num2] = num;
					}
				}
			}
			levelRecord.Score = notify.AfterLevelScore;
			if (levelRecord.HistoryScore < notify.AfterLevelScore)
			{
				levelRecord.HistoryScore = notify.AfterLevelScore;
			}
		}

		// Token: 0x0603DDFB RID: 253435 RVA: 0x00EF4B10 File Offset: 0x00EF2D10
		public void OnLevelRecordUpdateNotify(NewTowerClimbingLevelRecord levelRecord)
		{
			this.ParseLevelRecord(new List<NewTowerClimbingLevelRecord>
			{
				levelRecord
			});
			this.ParseEnergyInfo(new List<NewTowerClimbingLevelRecord>
			{
				levelRecord
			});
		}

		// Token: 0x0603DDFC RID: 253436 RVA: 0x00EF4B38 File Offset: 0x00EF2D38
		public void OnRoleEnergyUpdateNotify(IList<RecordRoleEnergy> roleEnergyRecordList)
		{
			this.UpdateLevelRecordRoleId();
			foreach (RecordRoleEnergy recordRoleEnergy in roleEnergyRecordList)
			{
				NewTowerLevel? levelConfigById = WheelTowerConfig.Instance.GetLevelConfigById(recordRoleEnergy.LevelId);
				if (levelConfigById != null)
				{
					bool key = levelConfigById.Value.Diff != 0;
					Dictionary<int, int> roleEnergyDict = recordRoleEnergy.RoleEnergyDict.ToDictionary((KeyValuePair<int, int> kv) => kv.Key, (KeyValuePair<int, int> kv) => kv.Value);
					this.EnergyInfoMap[key] = this.CreateEnergyInfo(roleEnergyDict, this.LevelRecordMap[key].TeamChallengeInfos.ToList<TeamChallengeInfo>());
				}
			}
		}

		// Token: 0x0603DDFD RID: 253437 RVA: 0x00EF4C2C File Offset: 0x00EF2E2C
		public void OnTaskClaim(IList<int> taskIdList)
		{
			foreach (int key in taskIdList)
			{
				global::ActivityTaskData activityTaskData;
				if (this.TaskMap.TryGetValue(key, out activityTaskData))
				{
					activityTaskData.Status = EActivityTaskState.FinishedAndClaimed;
				}
			}
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
		}

		// Token: 0x0603DDFE RID: 253438 RVA: 0x00EF4C9C File Offset: 0x00EF2E9C
		public void OnTaskUpdateNotify(IList<ActivityTask> activityTaskList)
		{
			foreach (ActivityTask activityTask in activityTaskList)
			{
				global::ActivityTaskData activityTaskData;
				if (this.TaskMap.TryGetValue(activityTask.Id, out activityTaskData))
				{
					activityTaskData.Refresh(activityTask, null);
				}
			}
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
		}

		// Token: 0x0603DDFF RID: 253439 RVA: 0x00EF4D10 File Offset: 0x00EF2F10
		public bool CheckFirstOpenPage()
		{
			return !this.GetExDataFinishShowState() && ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 0, this.CycleId, 0) == 0;
		}

		// Token: 0x0603DE00 RID: 253440 RVA: 0x00EF4D38 File Offset: 0x00EF2F38
		public void ReadRedDot()
		{
			ActivityModel.Instance.SaveActivityData(base.Id, 0, this.CycleId, 0, 1);
			EventSystem.Instance.Emit(EEventName.RedDotAdventurePeriodicityTabUpdate);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
		}

		// Token: 0x0603DE01 RID: 253441 RVA: 0x00EF4D84 File Offset: 0x00EF2F84
		public bool ShouldShowSeasonRewardRedDot()
		{
			return this.CheckFirstReadSeasonReward() || this.HasAnySeasonRewardCanReceive();
		}

		// Token: 0x0603DE02 RID: 253442 RVA: 0x00EF4D96 File Offset: 0x00EF2F96
		private bool CheckFirstReadSeasonReward()
		{
			return ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 2, this.SeasonId, 0) == 0;
		}

		// Token: 0x0603DE03 RID: 253443 RVA: 0x00EF4DB4 File Offset: 0x00EF2FB4
		public void RecordReadSeasonReward()
		{
			ActivityModel.Instance.SaveActivityData(base.Id, 2, this.SeasonId, 0, 1);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
		}

		// Token: 0x0603DE04 RID: 253444 RVA: 0x00EF4DE5 File Offset: 0x00EF2FE5
		public bool ShouldShowRewardRedDot()
		{
			return this.CheckFirstReadReward() || this.HasAnyRewardCanReceive(EFilterMode.All);
		}

		// Token: 0x0603DE05 RID: 253445 RVA: 0x00EF4DF8 File Offset: 0x00EF2FF8
		private bool CheckFirstReadReward()
		{
			return ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 3, this.CycleId, 0) == 0;
		}

		// Token: 0x0603DE06 RID: 253446 RVA: 0x00EF4E16 File Offset: 0x00EF3016
		public void RecordReadReward()
		{
			ActivityModel.Instance.SaveActivityData(base.Id, 3, this.CycleId, 0, 1);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
		}

		// Token: 0x0603DE07 RID: 253447 RVA: 0x00EF4E47 File Offset: 0x00EF3047
		public bool HasAnyLevelRedDot()
		{
			return this.HasLevelRedDot(false) || this.HasLevelRedDot(true);
		}

		// Token: 0x0603DE08 RID: 253448 RVA: 0x00EF4E5C File Offset: 0x00EF305C
		public bool HasLevelRedDot(bool endless)
		{
			NewTowerClimbingLevelRecord newTowerClimbingLevelRecord;
			return this.LevelRecordMap.TryGetValue(endless, out newTowerClimbingLevelRecord) && newTowerClimbingLevelRecord.IsUnlock && this.CheckFirstEnterLevel(newTowerClimbingLevelRecord.LevelId);
		}

		// Token: 0x0603DE09 RID: 253449 RVA: 0x00EF4E8F File Offset: 0x00EF308F
		private bool CheckFirstEnterLevel(int levelId)
		{
			return ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 1, this.CycleId, levelId) == 0;
		}

		// Token: 0x0603DE0A RID: 253450 RVA: 0x00EF4EB0 File Offset: 0x00EF30B0
		public void RecordEnterLevel(bool endless)
		{
			NewTowerClimbingLevelRecord newTowerClimbingLevelRecord;
			int key = this.LevelRecordMap.TryGetValue(endless, out newTowerClimbingLevelRecord) ? newTowerClimbingLevelRecord.LevelId : 0;
			ActivityModel.Instance.SaveActivityData(base.Id, 1, this.CycleId, key, 1);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
		}

		// Token: 0x0603DE0B RID: 253451 RVA: 0x00EF4F06 File Offset: 0x00EF3106
		public bool HasBossHandBookRedDot()
		{
			return this.CheckFirstOpenBossHandBook();
		}

		// Token: 0x0603DE0C RID: 253452 RVA: 0x00EF4F0E File Offset: 0x00EF310E
		private bool CheckFirstOpenBossHandBook()
		{
			return ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 4, this.CycleId, 0) == 0;
		}

		// Token: 0x0603DE0D RID: 253453 RVA: 0x00EF4F2C File Offset: 0x00EF312C
		public void RecordOpenBossHandBook()
		{
			ActivityModel.Instance.SaveActivityData(base.Id, 4, this.CycleId, 0, 1);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
		}

		// Token: 0x0603DE0E RID: 253454 RVA: 0x00EF4F5D File Offset: 0x00EF315D
		public bool HasAnySeasonRewardCanReceive()
		{
			return this.GetCanReceiveSeasonRewardIds().Count > 0 || this.GetCanReceiveSeasonScoreRewardIds().Count > 0;
		}

		// Token: 0x0603DE0F RID: 253455 RVA: 0x00EF4F7D File Offset: 0x00EF317D
		public override bool GetExDataRedPointShowState()
		{
			return this.IsInCycle() && (this.CheckFirstOpenPage() || this.ShouldShowSeasonRewardRedDot() || this.ShouldShowRewardRedDot() || WheelTowerModel.Instance.HasUnreadSeasonMedalRedDot(this.SeasonId));
		}

		// Token: 0x0603DE10 RID: 253456 RVA: 0x00EF4FB4 File Offset: 0x00EF31B4
		protected override bool GetExDataFinishShowState()
		{
			if (!this.IsInCycle())
			{
				return false;
			}
			bool flag = this.GetReceivedSeasonRewardIds().Count >= this.GetSeasonTaskList().Count;
			bool flag2 = this.GetCurrentRewardProgress(EFilterMode.All) >= this.GetTotalRewardProgress(EFilterMode.All);
			return flag && flag2;
		}

		// Token: 0x0603DE11 RID: 253457 RVA: 0x00EF4FFC File Offset: 0x00EF31FC
		public bool GetExDataFinishShowStateExternal()
		{
			return this.GetExDataFinishShowState();
		}

		// Token: 0x0603DE12 RID: 253458 RVA: 0x00EF5004 File Offset: 0x00EF3204
		public void UpdateRecommendLineUp(IList<NewTowerRecommendLevel> list)
		{
			foreach (NewTowerRecommendLevel newTowerRecommendLevel in list)
			{
				if (!this.RecommendLineUpMap.ContainsKey(newTowerRecommendLevel.LevelId))
				{
					this.RecommendLineUpMap[newTowerRecommendLevel.LevelId] = new Dictionary<int, IList<NewTowerRecommendTeam>>();
				}
				this.RecommendLineUpMap[newTowerRecommendLevel.LevelId][newTowerRecommendLevel.RecommendId] = newTowerRecommendLevel.RecommendTeams;
			}
			this.IsRequestedRecommendLineUp = true;
		}

		// Token: 0x0603DE13 RID: 253459 RVA: 0x00EF5098 File Offset: 0x00EF3298
		public IList<NewTowerRecommendTeam> GetLevelRecommendTeam(int levelId, int recommendId)
		{
			Dictionary<int, IList<NewTowerRecommendTeam>> dictionary;
			IList<NewTowerRecommendTeam> result;
			if (this.RecommendLineUpMap.TryGetValue(levelId, out dictionary) && dictionary.TryGetValue(recommendId, out result))
			{
				return result;
			}
			return new List<NewTowerRecommendTeam>();
		}

		// Token: 0x0603DE14 RID: 253460 RVA: 0x00EF50C8 File Offset: 0x00EF32C8
		private List<NewTowerMedal> GetSortedMedalConfigsByGroupId(int groupId)
		{
			List<NewTowerMedal> result;
			if (this.SortedMedalConfigCache.TryGetValue(groupId, out result))
			{
				return result;
			}
			IReadOnlyList<NewTowerMedal> medalConfigListByGroupId = WheelTowerConfig.Instance.GetMedalConfigListByGroupId(groupId);
			if (medalConfigListByGroupId == null || medalConfigListByGroupId.Count == 0)
			{
				return new List<NewTowerMedal>();
			}
			List<NewTowerMedal> list = (from c in medalConfigListByGroupId
			orderby c.Target
			select c).ToList<NewTowerMedal>();
			this.SortedMedalConfigCache[groupId] = list;
			return list;
		}

		// Token: 0x0603DE15 RID: 253461 RVA: 0x00EF5140 File Offset: 0x00EF3340
		private IWheelTowerMedalGroupData ResolveMedalGroupData(int groupId, int seasonId, int cycleId, int progress, long completeTime)
		{
			List<NewTowerMedal> sortedMedalConfigsByGroupId = this.GetSortedMedalConfigsByGroupId(groupId);
			int currentMedalId = 0;
			int nextMedalId = 0;
			int currentTarget = 0;
			bool isMaxLevel = false;
			if (sortedMedalConfigsByGroupId.Count > 0)
			{
				bool flag = false;
				foreach (NewTowerMedal newTowerMedal in sortedMedalConfigsByGroupId)
				{
					if (newTowerMedal.Target > progress)
					{
						nextMedalId = newTowerMedal.Id;
						currentTarget = newTowerMedal.Target;
						flag = true;
						break;
					}
					currentMedalId = newTowerMedal.Id;
				}
				if (!flag)
				{
					isMaxLevel = true;
					List<NewTowerMedal> list = sortedMedalConfigsByGroupId;
					currentTarget = list[list.Count - 1].Target;
				}
			}
			return new WheelTowerMedalGroupData
			{
				GroupId = groupId,
				SeasonId = seasonId,
				CycleId = cycleId,
				Progress = progress,
				CompleteTime = completeTime,
				CurrentMedalId = currentMedalId,
				NextMedalId = nextMedalId,
				CurrentTarget = currentTarget,
				IsMaxLevel = isMaxLevel
			};
		}

		// Token: 0x0603DE16 RID: 253462 RVA: 0x00EF5238 File Offset: 0x00EF3438
		public void ParseMedalInfos([Nullable(new byte[]
		{
			2,
			1
		})] IEnumerable<NewTowerMedalInfo> infos)
		{
			Dictionary<int, int> dictionary = new Dictionary<int, int>();
			foreach (KeyValuePair<int, IWheelTowerMedalGroupData> keyValuePair in this.MedalGroupDataMap)
			{
				dictionary[keyValuePair.Key] = keyValuePair.Value.CurrentMedalId;
			}
			this.MedalGroupDataMap.Clear();
			if (infos == null)
			{
				return;
			}
			bool flag = false;
			foreach (NewTowerMedalInfo newTowerMedalInfo in infos)
			{
				IWheelTowerMedalGroupData wheelTowerMedalGroupData = this.ResolveMedalGroupData(newTowerMedalInfo.MedalGroupId, newTowerMedalInfo.SeasonId, newTowerMedalInfo.CycleId, newTowerMedalInfo.Progress, newTowerMedalInfo.CompleteTime);
				this.MedalGroupDataMap[wheelTowerMedalGroupData.GroupId] = wheelTowerMedalGroupData;
				int valueOrDefault = dictionary.GetValueOrDefault(wheelTowerMedalGroupData.GroupId, 0);
				if (wheelTowerMedalGroupData.CurrentMedalId > valueOrDefault)
				{
					flag = true;
				}
			}
			if (flag)
			{
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
			}
		}

		// Token: 0x0603DE17 RID: 253463 RVA: 0x00EF5360 File Offset: 0x00EF3560
		[NullableContext(2)]
		public IWheelTowerMedalGroupData GetMedalGroupData(int groupId)
		{
			IWheelTowerMedalGroupData result;
			if (this.MedalGroupDataMap.TryGetValue(groupId, out result))
			{
				return result;
			}
			List<NewTowerMedal> sortedMedalConfigsByGroupId = this.GetSortedMedalConfigsByGroupId(groupId);
			if (sortedMedalConfigsByGroupId.Count == 0)
			{
				return null;
			}
			NewTowerMedal newTowerMedal = sortedMedalConfigsByGroupId[0];
			return this.ResolveMedalGroupData(groupId, newTowerMedal.SeasonId, newTowerMedal.CycleId, 0, 0L);
		}

		// Token: 0x0603DE18 RID: 253464 RVA: 0x00EF53B1 File Offset: 0x00EF35B1
		public List<IWheelTowerMedalGroupData> GetAllMedalGroupData()
		{
			return this.MedalGroupDataMap.Values.ToList<IWheelTowerMedalGroupData>();
		}

		// Token: 0x040204EF RID: 132335
		private readonly Dictionary<bool, NewTowerClimbingLevelRecord> LevelRecordMap = new Dictionary<bool, NewTowerClimbingLevelRecord>();

		// Token: 0x040204F0 RID: 132336
		private readonly Dictionary<bool, EnergyInfo> EnergyInfoMap = new Dictionary<bool, EnergyInfo>();

		// Token: 0x040204F1 RID: 132337
		private readonly Dictionary<int, global::ActivityTaskData> TaskMap = new Dictionary<int, global::ActivityTaskData>();

		// Token: 0x040204F2 RID: 132338
		private readonly Dictionary<int, global::ActivityTaskData> SeasonTaskDataMap = new Dictionary<int, global::ActivityTaskData>();

		// Token: 0x040204F3 RID: 132339
		private readonly Dictionary<int, Dictionary<int, IList<NewTowerRecommendTeam>>> RecommendLineUpMap = new Dictionary<int, Dictionary<int, IList<NewTowerRecommendTeam>>>();

		// Token: 0x040204F4 RID: 132340
		private readonly List<int> ReceivedSeasonScoreRewards = new List<int>();

		// Token: 0x040204F9 RID: 132345
		private readonly Dictionary<int, IWheelTowerMedalGroupData> MedalGroupDataMap = new Dictionary<int, IWheelTowerMedalGroupData>();

		// Token: 0x040204FA RID: 132346
		private readonly Dictionary<int, List<NewTowerMedal>> SortedMedalConfigCache = new Dictionary<int, List<NewTowerMedal>>();
	}
}
