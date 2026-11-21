using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using Google.Protobuf.Collections;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower
{
	// Token: 0x02004F04 RID: 20228
	[NullableContext(1)]
	[Nullable(0)]
	public class WheelTowerData : ActivityBaseData
	{
		// Token: 0x170062CB RID: 25291
		// (get) Token: 0x06032D5F RID: 208223 RVA: 0x00E45748 File Offset: 0x00E43948
		// (set) Token: 0x06032D60 RID: 208224 RVA: 0x00E45750 File Offset: 0x00E43950
		public int CycleId { get; private set; } = -1;

		// Token: 0x170062CC RID: 25292
		// (get) Token: 0x06032D61 RID: 208225 RVA: 0x00E45759 File Offset: 0x00E43959
		// (set) Token: 0x06032D62 RID: 208226 RVA: 0x00E45761 File Offset: 0x00E43961
		public double CycleBeginTime { get; private set; } = -1.0;

		// Token: 0x170062CD RID: 25293
		// (get) Token: 0x06032D63 RID: 208227 RVA: 0x00E4576A File Offset: 0x00E4396A
		// (set) Token: 0x06032D64 RID: 208228 RVA: 0x00E45772 File Offset: 0x00E43972
		public double CycleEndTime { get; private set; } = -1.0;

		// Token: 0x170062CE RID: 25294
		// (get) Token: 0x06032D65 RID: 208229 RVA: 0x00E4577B File Offset: 0x00E4397B
		// (set) Token: 0x06032D66 RID: 208230 RVA: 0x00E45783 File Offset: 0x00E43983
		public bool IsRequestedRecommendLineUp { get; private set; }

		// Token: 0x170062CF RID: 25295
		// (get) Token: 0x06032D67 RID: 208231 RVA: 0x00E4578C File Offset: 0x00E4398C
		// (set) Token: 0x06032D68 RID: 208232 RVA: 0x00E45794 File Offset: 0x00E43994
		public int SeasonId { get; private set; } = 1;

		// Token: 0x170062D0 RID: 25296
		// (get) Token: 0x06032D69 RID: 208233 RVA: 0x00E4579D File Offset: 0x00E4399D
		// (set) Token: 0x06032D6A RID: 208234 RVA: 0x00E457A5 File Offset: 0x00E439A5
		public double SeasonBeginTime { get; private set; }

		// Token: 0x170062D1 RID: 25297
		// (get) Token: 0x06032D6B RID: 208235 RVA: 0x00E457AE File Offset: 0x00E439AE
		// (set) Token: 0x06032D6C RID: 208236 RVA: 0x00E457B6 File Offset: 0x00E439B6
		public double SeasonEndTime { get; private set; }

		// Token: 0x06032D6D RID: 208237 RVA: 0x00E457C0 File Offset: 0x00E439C0
		protected override void PhraseEx(ActivityData data)
		{
			WheelTowerModel.Instance.SetActivityId(base.Id);
			NewTowerClimbingActivityData newTowerClimbingActivityData = data.NewTowerClimbingActivityData;
			if (newTowerClimbingActivityData == null)
			{
				return;
			}
			this.ParseCycleInfo(newTowerClimbingActivityData);
			this.ParseLevelRecord(newTowerClimbingActivityData.Records);
			this.ParseEnergyInfo(newTowerClimbingActivityData.Records);
			this.ParseTaskInfo(newTowerClimbingActivityData);
			this.ParseSeasonInfo(newTowerClimbingActivityData);
		}

		// Token: 0x06032D6E RID: 208238 RVA: 0x00E45818 File Offset: 0x00E43A18
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

		// Token: 0x06032D6F RID: 208239 RVA: 0x00E45888 File Offset: 0x00E43A88
		private void ParseLevelRecord(IEnumerable<NewTowerClimbingLevelRecord> levelRecords)
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

		// Token: 0x06032D70 RID: 208240 RVA: 0x00E45918 File Offset: 0x00E43B18
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

		// Token: 0x06032D71 RID: 208241 RVA: 0x00E459E4 File Offset: 0x00E43BE4
		private void ParseEnergyInfo(IEnumerable<NewTowerClimbingLevelRecord> levelRecords)
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
					this.EnergyInfoMap[key] = this.CreateEnergyInfo(dictionary, newTowerClimbingLevelRecord.TeamChallengeInfos);
				}
			}
		}

		// Token: 0x06032D72 RID: 208242 RVA: 0x00E45ADC File Offset: 0x00E43CDC
		public EnergyInfo GetRoundEnergyInfo(bool endless, int round)
		{
			NewTowerClimbingLevelRecord levelRecord = this.GetLevelRecord(endless);
			Dictionary<int, int> dictionary = new Dictionary<int, int>(this.EnergyInfoMap[endless].RoleEnergyMap);
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
			List<TeamChallengeInfo> list = new List<TeamChallengeInfo>();
			int num3 = 0;
			while (num3 < round && num3 < levelRecord.TeamChallengeInfos.Count)
			{
				list.Add(levelRecord.TeamChallengeInfos[num3]);
				num3++;
			}
			return this.CreateEnergyInfo(dictionary, list);
		}

		// Token: 0x06032D73 RID: 208243 RVA: 0x00E45BE4 File Offset: 0x00E43DE4
		private EnergyInfo CreateEnergyInfo(Dictionary<int, int> roleEnergyDict, IEnumerable<TeamChallengeInfo> teamChallengeInfos)
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

		// Token: 0x06032D74 RID: 208244 RVA: 0x00E45D54 File Offset: 0x00E43F54
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

		// Token: 0x06032D75 RID: 208245 RVA: 0x00E45DAC File Offset: 0x00E43FAC
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

		// Token: 0x06032D76 RID: 208246 RVA: 0x00E45F0C File Offset: 0x00E4410C
		public void ParseSeasonInfo(NewTowerClimbingActivityData activityData)
		{
			this.SeasonId = activityData.SeasonId;
			this.SeasonBeginTime = (double)MathUtils.Instance.LongToNumber(activityData.SeasonBeginTime);
			this.SeasonEndTime = (double)MathUtils.Instance.LongToNumber(activityData.SeasonCloseTime);
			this.ReceivedSeasonScoreRewards.Clear();
			this.ReceivedSeasonScoreRewards.AddRange(activityData.ScoreTasks);
			this.SeasonTaskDataMap.Clear();
			this.UpdateSeasonTaskList(activityData.SeasonTasks);
		}

		// Token: 0x06032D77 RID: 208247 RVA: 0x00E45F88 File Offset: 0x00E44188
		public void UpdateSeasonTaskList(IList<ActivityTask> taskList)
		{
			foreach (ActivityTask task in taskList)
			{
				this.UpdateSeasonTask(task);
			}
		}

		// Token: 0x06032D78 RID: 208248 RVA: 0x00E45FD0 File Offset: 0x00E441D0
		public void RemoveSeasonTaskList(IList<int> taskIds)
		{
			foreach (int key in taskIds)
			{
				this.SeasonTaskDataMap.Remove(key);
			}
		}

		// Token: 0x06032D79 RID: 208249 RVA: 0x00E46020 File Offset: 0x00E44220
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

		// Token: 0x06032D7A RID: 208250 RVA: 0x00E46062 File Offset: 0x00E44262
		public bool IsInCycle()
		{
			return this.CycleId > 0;
		}

		// Token: 0x06032D7B RID: 208251 RVA: 0x00E46070 File Offset: 0x00E44270
		public bool IsInCycleTime()
		{
			double serverTime = TimeUtil.Instance.GetServerTime();
			return serverTime >= this.CycleBeginTime && serverTime <= this.CycleEndTime;
		}

		// Token: 0x06032D7C RID: 208252 RVA: 0x00E4609F File Offset: 0x00E4429F
		public double GetCycleRemainTime()
		{
			return (double)base.EndShowTime - Time.Instance.ServerTimeStamp / 1000.0;
		}

		// Token: 0x06032D7D RID: 208253 RVA: 0x00E460C0 File Offset: 0x00E442C0
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

		// Token: 0x06032D7E RID: 208254 RVA: 0x00E46144 File Offset: 0x00E44344
		public bool IsTowerUnlocked()
		{
			if (!base.IsUnLock())
			{
				return false;
			}
			using (Dictionary<bool, NewTowerClimbingLevelRecord>.ValueCollection.Enumerator enumerator = this.LevelRecordMap.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.IsUnlock)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06032D7F RID: 208255 RVA: 0x00E461AC File Offset: 0x00E443AC
		public NewTowerClimbingLevelRecord GetLevelRecord(bool isEndless)
		{
			return this.LevelRecordMap[isEndless];
		}

		// Token: 0x06032D80 RID: 208256 RVA: 0x00E461BC File Offset: 0x00E443BC
		public bool IsLevelUnlocked(bool endless)
		{
			NewTowerClimbingLevelRecord newTowerClimbingLevelRecord;
			return this.LevelRecordMap.TryGetValue(endless, out newTowerClimbingLevelRecord) && newTowerClimbingLevelRecord.IsUnlock;
		}

		// Token: 0x06032D81 RID: 208257 RVA: 0x00E461E1 File Offset: 0x00E443E1
		public int GetHistoryBestScore(bool isEndless)
		{
			return this.GetLevelRecord(isEndless).HistoryScore;
		}

		// Token: 0x06032D82 RID: 208258 RVA: 0x00E461F0 File Offset: 0x00E443F0
		public int GetRoundScore(bool isEndless, int round)
		{
			RepeatedField<TeamChallengeInfo> teamChallengeInfos = this.GetLevelRecord(isEndless).TeamChallengeInfos;
			if (round < 0 || round >= teamChallengeInfos.Count)
			{
				return 0;
			}
			TeamChallengeInfo teamChallengeInfo = teamChallengeInfos[round];
			if (teamChallengeInfo == null)
			{
				return 0;
			}
			return teamChallengeInfo.TeamScore;
		}

		// Token: 0x06032D83 RID: 208259 RVA: 0x00E4622C File Offset: 0x00E4442C
		public int GetRoundTotalScore(bool isEndless, int round)
		{
			int num = 0;
			for (int i = 0; i <= round; i++)
			{
				num += this.GetRoundScore(isEndless, i);
			}
			return num;
		}

		// Token: 0x06032D84 RID: 208260 RVA: 0x00E46253 File Offset: 0x00E44453
		public int GetTotalScore(bool isEndless)
		{
			if (this.GetLevelRecord(isEndless).TeamChallengeInfos.Count > 0)
			{
				return this.GetRoundTotalScore(isEndless, this.GetLevelRecord(isEndless).TeamChallengeInfos.Count - 1);
			}
			return 0;
		}

		// Token: 0x06032D85 RID: 208261 RVA: 0x00E46288 File Offset: 0x00E44488
		public bool IsRewardCanReceive(int rewardId)
		{
			global::ActivityTaskData activityTaskData;
			return this.TaskMap.TryGetValue(rewardId, out activityTaskData) && activityTaskData.Status == EActivityTaskState.FinishedAndUnclaimed;
		}

		// Token: 0x06032D86 RID: 208262 RVA: 0x00E462B0 File Offset: 0x00E444B0
		public bool IsRewardCompleted(int rewardId)
		{
			global::ActivityTaskData activityTaskData;
			return this.TaskMap.TryGetValue(rewardId, out activityTaskData) && activityTaskData.Status == EActivityTaskState.FinishedAndClaimed;
		}

		// Token: 0x06032D87 RID: 208263 RVA: 0x00E462D8 File Offset: 0x00E444D8
		public bool HasAnyRewardCanReceive(EFilterMode filterMode = EFilterMode.All)
		{
			return this.GetCanReceiveRewardId(filterMode).Count > 0;
		}

		// Token: 0x06032D88 RID: 208264 RVA: 0x00E462E9 File Offset: 0x00E444E9
		public EActivityTaskState GetTaskState(int taskId)
		{
			return this.TaskMap[taskId].Status;
		}

		// Token: 0x06032D89 RID: 208265 RVA: 0x00E462FC File Offset: 0x00E444FC
		public global::ActivityTaskData GetTask(int taskId)
		{
			return this.TaskMap[taskId];
		}

		// Token: 0x06032D8A RID: 208266 RVA: 0x00E4630C File Offset: 0x00E4450C
		public List<global::ActivityTaskData> GetFilterTaskList(EFilterMode filterMode = EFilterMode.All)
		{
			List<global::ActivityTaskData> list = new List<global::ActivityTaskData>(this.TaskMap.Values);
			List<global::ActivityTaskData> list2 = new List<global::ActivityTaskData>();
			foreach (global::ActivityTaskData activityTaskData in list)
			{
				if ((filterMode != EFilterMode.Normal || activityTaskData.TypeId == 0) && (filterMode != EFilterMode.Endless || activityTaskData.TypeId != 0))
				{
					list2.Add(activityTaskData);
				}
			}
			return list2;
		}

		// Token: 0x06032D8B RID: 208267 RVA: 0x00E46388 File Offset: 0x00E44588
		public List<int> GetCanReceiveRewardId(EFilterMode filterMode = EFilterMode.All)
		{
			List<int> list = new List<int>();
			foreach (global::ActivityTaskData activityTaskData in this.GetFilterTaskList(filterMode))
			{
				if (activityTaskData.Status == EActivityTaskState.FinishedAndUnclaimed)
				{
					list.Add(activityTaskData.Id);
				}
			}
			return list;
		}

		// Token: 0x06032D8C RID: 208268 RVA: 0x00E463F0 File Offset: 0x00E445F0
		public int GetCurrentRewardProgress(EFilterMode filterMode = EFilterMode.All)
		{
			int num = 0;
			using (List<global::ActivityTaskData>.Enumerator enumerator = this.GetFilterTaskList(filterMode).GetEnumerator())
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

		// Token: 0x06032D8D RID: 208269 RVA: 0x00E4644C File Offset: 0x00E4464C
		public int GetTotalRewardProgress(EFilterMode filterMode = EFilterMode.All)
		{
			return this.GetFilterTaskList(filterMode).Count;
		}

		// Token: 0x06032D8E RID: 208270 RVA: 0x00E4645C File Offset: 0x00E4465C
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

		// Token: 0x06032D8F RID: 208271 RVA: 0x00E464CC File Offset: 0x00E446CC
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

		// Token: 0x06032D90 RID: 208272 RVA: 0x00E46540 File Offset: 0x00E44740
		public List<global::ActivityTaskData> GetSeasonTaskList()
		{
			return new List<global::ActivityTaskData>(this.SeasonTaskDataMap.Values);
		}

		// Token: 0x06032D91 RID: 208273 RVA: 0x00E46554 File Offset: 0x00E44754
		public List<int> GetCanReceiveSeasonRewardIds()
		{
			List<int> list = new List<int>();
			foreach (global::ActivityTaskData activityTaskData in this.SeasonTaskDataMap.Values)
			{
				if (activityTaskData.Status == EActivityTaskState.FinishedAndUnclaimed)
				{
					list.Add(activityTaskData.Id);
				}
			}
			return list;
		}

		// Token: 0x06032D92 RID: 208274 RVA: 0x00E465C0 File Offset: 0x00E447C0
		public List<int> GetReceivedSeasonRewardIds()
		{
			List<int> list = new List<int>();
			foreach (global::ActivityTaskData activityTaskData in this.SeasonTaskDataMap.Values)
			{
				if (activityTaskData.Status == EActivityTaskState.FinishedAndClaimed)
				{
					list.Add(activityTaskData.Id);
				}
			}
			return list;
		}

		// Token: 0x06032D93 RID: 208275 RVA: 0x00E46630 File Offset: 0x00E44830
		public List<int> GetCanReceiveSeasonScoreRewardIds()
		{
			IReadOnlyList<NewTowerSeasonSAward> seasonScoreRewardConfigList = WheelTowerConfig.Instance.GetSeasonScoreRewardConfigList(this.SeasonId);
			if (seasonScoreRewardConfigList == null)
			{
				return new List<int>();
			}
			int seasonScoreItemId = WheelTowerConfig.Instance.GetSeasonScoreItemId(this.SeasonId);
			int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(seasonScoreItemId, 0);
			List<int> list = new List<int>();
			foreach (NewTowerSeasonSAward newTowerSeasonSAward in seasonScoreRewardConfigList)
			{
				if (this.ReceivedSeasonScoreRewards.IndexOf(newTowerSeasonSAward.Id) < 0 && itemCountByConfigId >= newTowerSeasonSAward.Score)
				{
					list.Add(newTowerSeasonSAward.Id);
				}
			}
			return list;
		}

		// Token: 0x06032D94 RID: 208276 RVA: 0x00E466E4 File Offset: 0x00E448E4
		public bool IsSeasonScoreRewardReceived(int rewardId)
		{
			return this.ReceivedSeasonScoreRewards.Contains(rewardId);
		}

		// Token: 0x06032D95 RID: 208277 RVA: 0x00E466F4 File Offset: 0x00E448F4
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

		// Token: 0x06032D96 RID: 208278 RVA: 0x00E46888 File Offset: 0x00E44A88
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

		// Token: 0x06032D97 RID: 208279 RVA: 0x00E468B0 File Offset: 0x00E44AB0
		public void OnRoleEnergyUpdateNotify(IList<RecordRoleEnergy> roleEnergyRecordList)
		{
			this.UpdateLevelRecordRoleId();
			foreach (RecordRoleEnergy recordRoleEnergy in roleEnergyRecordList)
			{
				NewTowerLevel? levelConfigById = WheelTowerConfig.Instance.GetLevelConfigById(recordRoleEnergy.LevelId);
				if (levelConfigById != null)
				{
					bool key = levelConfigById.Value.Diff != 0;
					Dictionary<int, int> roleEnergyDict = new Dictionary<int, int>(recordRoleEnergy.RoleEnergyDict);
					this.EnergyInfoMap[key] = this.CreateEnergyInfo(roleEnergyDict, this.LevelRecordMap[key].TeamChallengeInfos);
				}
			}
		}

		// Token: 0x06032D98 RID: 208280 RVA: 0x00E46958 File Offset: 0x00E44B58
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

		// Token: 0x06032D99 RID: 208281 RVA: 0x00E469C8 File Offset: 0x00E44BC8
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

		// Token: 0x06032D9A RID: 208282 RVA: 0x00E46A3C File Offset: 0x00E44C3C
		public bool CheckFirstOpenPage()
		{
			return !this.GetExDataFinishShowState() && ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 0, this.CycleId, 0) == 0;
		}

		// Token: 0x06032D9B RID: 208283 RVA: 0x00E46A64 File Offset: 0x00E44C64
		public void ReadRedDot()
		{
			ActivityModel.Instance.SaveActivityData(base.Id, 0, this.CycleId, 0, 1);
			EventSystem.Instance.Emit(EEventName.RedDotAdventurePeriodicityTabUpdate);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
		}

		// Token: 0x06032D9C RID: 208284 RVA: 0x00E46AB0 File Offset: 0x00E44CB0
		public bool ShouldShowSeasonRewardRedDot()
		{
			return this.CheckFirstReadSeasonReward() || this.HasAnySeasonRewardCanReceive();
		}

		// Token: 0x06032D9D RID: 208285 RVA: 0x00E46AC2 File Offset: 0x00E44CC2
		private bool CheckFirstReadSeasonReward()
		{
			return ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 2, this.SeasonId, 0) == 0;
		}

		// Token: 0x06032D9E RID: 208286 RVA: 0x00E46AE0 File Offset: 0x00E44CE0
		public void RecordReadSeasonReward()
		{
			ActivityModel.Instance.SaveActivityData(base.Id, 2, this.SeasonId, 0, 1);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
		}

		// Token: 0x06032D9F RID: 208287 RVA: 0x00E46B11 File Offset: 0x00E44D11
		public bool ShouldShowRewardRedDot()
		{
			return this.CheckFirstReadReward() || this.HasAnyRewardCanReceive(EFilterMode.All);
		}

		// Token: 0x06032DA0 RID: 208288 RVA: 0x00E46B24 File Offset: 0x00E44D24
		private bool CheckFirstReadReward()
		{
			return ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 3, this.CycleId, 0) == 0;
		}

		// Token: 0x06032DA1 RID: 208289 RVA: 0x00E46B42 File Offset: 0x00E44D42
		public void RecordReadReward()
		{
			ActivityModel.Instance.SaveActivityData(base.Id, 3, this.CycleId, 0, 1);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
		}

		// Token: 0x06032DA2 RID: 208290 RVA: 0x00E46B73 File Offset: 0x00E44D73
		public bool HasAnyLevelRedDot()
		{
			return this.HasLevelRedDot(false) || this.HasLevelRedDot(true);
		}

		// Token: 0x06032DA3 RID: 208291 RVA: 0x00E46B88 File Offset: 0x00E44D88
		public bool HasLevelRedDot(bool endless)
		{
			NewTowerClimbingLevelRecord newTowerClimbingLevelRecord;
			return this.LevelRecordMap.TryGetValue(endless, out newTowerClimbingLevelRecord) && newTowerClimbingLevelRecord.IsUnlock && this.CheckFirstEnterLevel(newTowerClimbingLevelRecord.LevelId);
		}

		// Token: 0x06032DA4 RID: 208292 RVA: 0x00E46BBB File Offset: 0x00E44DBB
		private bool CheckFirstEnterLevel(int levelId)
		{
			return ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 1, this.CycleId, levelId) == 0;
		}

		// Token: 0x06032DA5 RID: 208293 RVA: 0x00E46BDC File Offset: 0x00E44DDC
		public void RecordEnterLevel(bool endless)
		{
			NewTowerClimbingLevelRecord newTowerClimbingLevelRecord;
			int key = this.LevelRecordMap.TryGetValue(endless, out newTowerClimbingLevelRecord) ? newTowerClimbingLevelRecord.LevelId : 0;
			ActivityModel.Instance.SaveActivityData(base.Id, 1, this.CycleId, key, 1);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
		}

		// Token: 0x06032DA6 RID: 208294 RVA: 0x00E46C32 File Offset: 0x00E44E32
		public bool HasBossHandBookRedDot()
		{
			return this.CheckFirstOpenBossHandBook();
		}

		// Token: 0x06032DA7 RID: 208295 RVA: 0x00E46C3A File Offset: 0x00E44E3A
		private bool CheckFirstOpenBossHandBook()
		{
			return ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 4, this.CycleId, 0) == 0;
		}

		// Token: 0x06032DA8 RID: 208296 RVA: 0x00E46C58 File Offset: 0x00E44E58
		public void RecordOpenBossHandBook()
		{
			ActivityModel.Instance.SaveActivityData(base.Id, 4, this.CycleId, 0, 1);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
		}

		// Token: 0x06032DA9 RID: 208297 RVA: 0x00E46C89 File Offset: 0x00E44E89
		public bool HasAnySeasonRewardCanReceive()
		{
			return this.GetCanReceiveSeasonRewardIds().Count > 0 || this.GetCanReceiveSeasonScoreRewardIds().Count > 0;
		}

		// Token: 0x06032DAA RID: 208298 RVA: 0x00E46CA9 File Offset: 0x00E44EA9
		public override bool GetExDataRedPointShowState()
		{
			return this.IsInCycle() && (this.CheckFirstOpenPage() || this.ShouldShowSeasonRewardRedDot() || this.ShouldShowRewardRedDot() || WheelTowerModel.Instance.HasUnreadSeasonMedalRedDot(this.SeasonId));
		}

		// Token: 0x06032DAB RID: 208299 RVA: 0x00E46CE0 File Offset: 0x00E44EE0
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

		// Token: 0x06032DAC RID: 208300 RVA: 0x00E46D28 File Offset: 0x00E44F28
		public bool GetExDataFinishShowStateExternal()
		{
			return this.GetExDataFinishShowState();
		}

		// Token: 0x06032DAD RID: 208301 RVA: 0x00E46D30 File Offset: 0x00E44F30
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

		// Token: 0x06032DAE RID: 208302 RVA: 0x00E46DC4 File Offset: 0x00E44FC4
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

		// Token: 0x06032DAF RID: 208303 RVA: 0x00E46DF4 File Offset: 0x00E44FF4
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
			List<NewTowerMedal> list = new List<NewTowerMedal>(medalConfigListByGroupId);
			NoLinq.SortStable<NewTowerMedal>(list, (NewTowerMedal left, NewTowerMedal right) => left.Target.CompareTo(right.Target));
			this.SortedMedalConfigCache[groupId] = list;
			return list;
		}

		// Token: 0x06032DB0 RID: 208304 RVA: 0x00E46E6C File Offset: 0x00E4506C
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

		// Token: 0x06032DB1 RID: 208305 RVA: 0x00E46F64 File Offset: 0x00E45164
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

		// Token: 0x06032DB2 RID: 208306 RVA: 0x00E4708C File Offset: 0x00E4528C
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

		// Token: 0x06032DB3 RID: 208307 RVA: 0x00E470DD File Offset: 0x00E452DD
		public List<IWheelTowerMedalGroupData> GetAllMedalGroupData()
		{
			return new List<IWheelTowerMedalGroupData>(this.MedalGroupDataMap.Values);
		}

		// Token: 0x0401AFC1 RID: 110529
		private readonly Dictionary<bool, NewTowerClimbingLevelRecord> LevelRecordMap = new Dictionary<bool, NewTowerClimbingLevelRecord>();

		// Token: 0x0401AFC2 RID: 110530
		private readonly Dictionary<bool, EnergyInfo> EnergyInfoMap = new Dictionary<bool, EnergyInfo>();

		// Token: 0x0401AFC3 RID: 110531
		private readonly Dictionary<int, global::ActivityTaskData> TaskMap = new Dictionary<int, global::ActivityTaskData>();

		// Token: 0x0401AFC4 RID: 110532
		private readonly Dictionary<int, global::ActivityTaskData> SeasonTaskDataMap = new Dictionary<int, global::ActivityTaskData>();

		// Token: 0x0401AFC5 RID: 110533
		private readonly Dictionary<int, Dictionary<int, IList<NewTowerRecommendTeam>>> RecommendLineUpMap = new Dictionary<int, Dictionary<int, IList<NewTowerRecommendTeam>>>();

		// Token: 0x0401AFC6 RID: 110534
		private readonly List<int> ReceivedSeasonScoreRewards = new List<int>();

		// Token: 0x0401AFCB RID: 110539
		private readonly Dictionary<int, IWheelTowerMedalGroupData> MedalGroupDataMap = new Dictionary<int, IWheelTowerMedalGroupData>();

		// Token: 0x0401AFCC RID: 110540
		private readonly Dictionary<int, List<NewTowerMedal>> SortedMedalConfigCache = new Dictionary<int, List<NewTowerMedal>>();
	}
}
