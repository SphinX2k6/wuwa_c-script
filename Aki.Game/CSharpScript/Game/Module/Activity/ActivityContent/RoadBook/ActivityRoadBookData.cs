using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RoadBook
{
	// Token: 0x0200513D RID: 20797
	[NullableContext(1)]
	[Nullable(0)]
	public class ActivityRoadBookData : ActivityBaseData
	{
		// Token: 0x06034027 RID: 213031 RVA: 0x00E8CDD8 File Offset: 0x00E8AFD8
		protected override void OnInit(ActivityData data)
		{
			this.InitTravelLevelData();
			this.InitTravelAreaData();
			this.InitPhantomData();
			this.InitMotorChallengeData();
			RoadBookActivityInfo roadBookActivityInfo = data.RoadBookActivityInfo;
			if (roadBookActivityInfo == null)
			{
				return;
			}
			this.TravelLevel = roadBookActivityInfo.RoadBookLevel;
			this.LastTravelLevelInternal = roadBookActivityInfo.RoadBookLevel;
			this.LastCurrentExpCountInternal = this.GetCurrentExp();
			this.LastExpCountInternal = this.GetExpItemCount();
		}

		// Token: 0x06034028 RID: 213032 RVA: 0x00E8CE38 File Offset: 0x00E8B038
		protected override void PhraseEx(ActivityData data)
		{
			RoadBookActivityInfo roadBookActivityInfo = data.RoadBookActivityInfo;
			if (roadBookActivityInfo == null)
			{
				return;
			}
			this.RefreshRoadBookData(roadBookActivityInfo);
		}

		// Token: 0x06034029 RID: 213033 RVA: 0x00E8CE58 File Offset: 0x00E8B058
		protected void RefreshRoadBookData(RoadBookActivityInfo roadBookInfo)
		{
			this.TravelLevel = roadBookInfo.RoadBookLevel;
			for (int i = 0; i < roadBookInfo.UnLockAreas.Count; i++)
			{
				this.UnlockAreaData(roadBookInfo.UnLockAreas[i]);
			}
			for (int j = 0; j < roadBookInfo.ActivityTasks.Count; j++)
			{
				ConditionTask task = roadBookInfo.ActivityTasks[j];
				this.RefreshTravelTaskData(task);
			}
			this.TaskFinalRewardData.IsReceived = roadBookInfo.GetFullReward;
			for (int k = 0; k < roadBookInfo.MonsterGain.Count; k++)
			{
				this.UnlockPhantom(roadBookInfo.MonsterGain[k]);
			}
			for (int l = 0; l < roadBookInfo.SoarLevels.Count; l++)
			{
				RoadBookMotorcycleInfo challengeInfo = roadBookInfo.SoarLevels[l];
				this.RefreshMotorChallengePlayData(challengeInfo);
			}
		}

		// Token: 0x0603402A RID: 213034 RVA: 0x00E8CF2D File Offset: 0x00E8B12D
		public override bool GetExDataRedPointShowState()
		{
			return this.CanTravelLevelUp() || this.GetTaskRedDotState(true) || this.GetAllMotorItemRedDot();
		}

		// Token: 0x0603402B RID: 213035 RVA: 0x00E8CF50 File Offset: 0x00E8B150
		protected override bool GetExDataFinishShowState()
		{
			if (this.MaxTravelLevel != this.TravelLevel)
			{
				return false;
			}
			if (this.TaskFinalRewardData != null && !this.TaskFinalRewardData.IsReceived)
			{
				return false;
			}
			using (Dictionary<int, global::ActivityTaskData>.ValueCollection.Enumerator enumerator = this.AreaTaskMap.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.Status != EActivityTaskState.FinishedAndClaimed)
					{
						return false;
					}
				}
			}
			using (Dictionary<int, global::ActivityTaskData>.ValueCollection.Enumerator enumerator = this.MotorChallengeRewardDataMap.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.Status != EActivityTaskState.FinishedAndClaimed)
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x0603402C RID: 213036 RVA: 0x00E8D024 File Offset: 0x00E8B224
		public bool SaveFirstCheckRedDotState(ERoadBookSaveFlag saveFlag, int id = 0)
		{
			if (ActivityModel.Instance.GetActivityCacheData(base.Id, 0, (int)saveFlag, id, 0) == 1)
			{
				return true;
			}
			ActivityModel.Instance.SaveActivityData(base.Id, (int)saveFlag, id, 0, 1);
			this.RefreshActivityRedDotState();
			return false;
		}

		// Token: 0x0603402D RID: 213037 RVA: 0x00E8D05C File Offset: 0x00E8B25C
		[NullableContext(0)]
		[return: TupleElementNames(new string[]
		{
			"current",
			"total"
		})]
		public ValueTuple<int, int> GetTypeProgress(ERoadBookSubType subType)
		{
			int num = 0;
			int item = 1;
			switch (subType)
			{
			case ERoadBookSubType.TravelTask:
				num = this.GetFinishedAreaTaskCount();
				item = this.AreaTaskMap.Count;
				break;
			case ERoadBookSubType.PhantomCollect:
				using (Dictionary<int, bool>.ValueCollection.Enumerator enumerator = this.PhantomDataMap.Values.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (enumerator.Current)
						{
							num++;
						}
					}
				}
				item = this.PhantomDataMap.Count;
				break;
			case ERoadBookSubType.MotorChallenge:
				using (Dictionary<int, global::ActivityTaskData>.ValueCollection.Enumerator enumerator2 = this.MotorChallengeRewardDataMap.Values.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						if (enumerator2.Current.Status == EActivityTaskState.FinishedAndClaimed)
						{
							num++;
						}
					}
				}
				item = this.MotorChallengeRewardDataMap.Count;
				break;
			}
			return new ValueTuple<int, int>(num, item);
		}

		// Token: 0x0603402E RID: 213038 RVA: 0x00E8D158 File Offset: 0x00E8B358
		public bool GetTypeRedDotState(ERoadBookSubType subType)
		{
			if (subType != ERoadBookSubType.TravelTask)
			{
				return subType == ERoadBookSubType.MotorChallenge && this.GetAllMotorItemRedDot();
			}
			return this.GetTaskRedDotState(false);
		}

		// Token: 0x0603402F RID: 213039 RVA: 0x00E8D174 File Offset: 0x00E8B374
		public bool GetTypeNewState(ERoadBookSubType subType)
		{
			switch (subType)
			{
			case ERoadBookSubType.TravelTask:
				return this.GetAllAreaNewUnlockState();
			case ERoadBookSubType.PhantomCollect:
				return this.GetAllPhantomNewUnlockState();
			case ERoadBookSubType.MotorChallenge:
				return this.RefreshAndGetAllMotorItemNewUnlock();
			}
			return false;
		}

		// Token: 0x06034030 RID: 213040 RVA: 0x00E8D1A6 File Offset: 0x00E8B3A6
		public void RefreshActivityRedDotState()
		{
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
		}

		// Token: 0x06034031 RID: 213041 RVA: 0x00E8D1C0 File Offset: 0x00E8B3C0
		public RoadBookConfig GetActivityConfig()
		{
			return ActivityRoadBookConfig.Instance.GetActivityConfig(base.Id).Value;
		}

		// Token: 0x06034032 RID: 213042 RVA: 0x00E8D1E5 File Offset: 0x00E8B3E5
		private Comparison<global::ActivityTaskData> SortTaskData()
		{
			return delegate(global::ActivityTaskData a, global::ActivityTaskData b)
			{
				if (a.Status == b.Status)
				{
					return a.Id - b.Id;
				}
				return a.Status - b.Status;
			};
		}

		// Token: 0x1700657C RID: 25980
		// (get) Token: 0x06034033 RID: 213043 RVA: 0x00E8D206 File Offset: 0x00E8B406
		public int LastTravelLevel
		{
			get
			{
				int lastTravelLevelInternal = this.LastTravelLevelInternal;
				this.LastTravelLevelInternal = this.TravelLevel;
				return lastTravelLevelInternal;
			}
		}

		// Token: 0x1700657D RID: 25981
		// (get) Token: 0x06034034 RID: 213044 RVA: 0x00E8D21A File Offset: 0x00E8B41A
		public int LastCurrentExpCount
		{
			get
			{
				int lastCurrentExpCountInternal = this.LastCurrentExpCountInternal;
				this.LastCurrentExpCountInternal = this.GetCurrentExp();
				return lastCurrentExpCountInternal;
			}
		}

		// Token: 0x1700657E RID: 25982
		// (get) Token: 0x06034035 RID: 213045 RVA: 0x00E8D22E File Offset: 0x00E8B42E
		public int LastExpCount
		{
			get
			{
				int lastExpCountInternal = this.LastExpCountInternal;
				this.LastExpCountInternal = this.GetExpItemCount();
				return lastExpCountInternal;
			}
		}

		// Token: 0x1700657F RID: 25983
		// (get) Token: 0x06034036 RID: 213046 RVA: 0x00E8D244 File Offset: 0x00E8B444
		public int MaxTravelLevel
		{
			get
			{
				return this.GetActivityConfig().MaxLevel;
			}
		}

		// Token: 0x06034037 RID: 213047 RVA: 0x00E8D260 File Offset: 0x00E8B460
		private void InitTravelLevelData()
		{
			this.TravelLevelData.Clear();
			IEnumerable<RoadBookLevelExp> allLevelExpConfig = ActivityRoadBookConfig.Instance.GetAllLevelExpConfig(base.Id);
			int num = 0;
			foreach (RoadBookLevelExp roadBookLevelExp in allLevelExpConfig)
			{
				RoadBookLevelData value = new RoadBookLevelData
				{
					Id = roadBookLevelExp.Id,
					Level = roadBookLevelExp.Level,
					AccumulateExp = num,
					TargetExp = roadBookLevelExp.NeedExp
				};
				this.TravelLevelData[roadBookLevelExp.Level] = value;
				num += roadBookLevelExp.NeedExp;
			}
		}

		// Token: 0x06034038 RID: 213048 RVA: 0x00E8D310 File Offset: 0x00E8B510
		public int GetExpItemCount()
		{
			int expItemId = this.GetActivityConfig().ExpItemId;
			return InventoryModel.Instance.GetItemCountByConfigId(expItemId, 0);
		}

		// Token: 0x06034039 RID: 213049 RVA: 0x00E8D338 File Offset: 0x00E8B538
		public int GetCurrentExp()
		{
			int expItemCount = this.GetExpItemCount();
			int accumulateExp = this.TravelLevelData[this.TravelLevel].AccumulateExp;
			return expItemCount - accumulateExp;
		}

		// Token: 0x0603403A RID: 213050 RVA: 0x00E8D364 File Offset: 0x00E8B564
		public int GetCurrentTargetExp()
		{
			bool flag = this.MaxTravelLevel == this.TravelLevel;
			IRoadBookLevelData roadBookLevelData = this.TravelLevelData[this.TravelLevel];
			if (!flag)
			{
				return roadBookLevelData.TargetExp;
			}
			return roadBookLevelData.AccumulateExp;
		}

		// Token: 0x0603403B RID: 213051 RVA: 0x00E8D3A0 File Offset: 0x00E8B5A0
		public bool CanTravelLevelUp()
		{
			if (this.MaxTravelLevel == this.TravelLevel)
			{
				return false;
			}
			int expItemCount = this.GetExpItemCount();
			IRoadBookLevelData roadBookLevelData = this.TravelLevelData[this.TravelLevel];
			int num = roadBookLevelData.AccumulateExp + roadBookLevelData.TargetExp;
			return expItemCount >= num;
		}

		// Token: 0x0603403C RID: 213052 RVA: 0x00E8D3EC File Offset: 0x00E8B5EC
		private void InitTravelAreaData()
		{
			this.AreaDataMap.Clear();
			this.TaskFinalRewardData = new FinalTravelTaskData();
			IReadOnlyList<RoadBookTask> allRoadBookTaskConfig = ActivityRoadBookConfig.Instance.GetAllRoadBookTaskConfig(base.Id);
			this.TaskFinalRewardData.Target = allRoadBookTaskConfig.Count;
			foreach (RoadBookArea roadBookArea in ActivityRoadBookConfig.Instance.GetAllAreaConfig(base.Id))
			{
				RoadBookAreaData value = new RoadBookAreaData(roadBookArea.Id);
				this.AreaDataMap[roadBookArea.Id] = value;
			}
		}

		// Token: 0x0603403D RID: 213053 RVA: 0x00E8D494 File Offset: 0x00E8B694
		public void UnlockAreaData(int areaId)
		{
			RoadBookAreaData roadBookAreaData;
			if (!this.AreaDataMap.TryGetValue(areaId, out roadBookAreaData))
			{
				return;
			}
			roadBookAreaData.IsUnlock = true;
		}

		// Token: 0x0603403E RID: 213054 RVA: 0x00E8D4B9 File Offset: 0x00E8B6B9
		public List<RoadBookAreaData> GetAllAreaData()
		{
			List<RoadBookAreaData> list = new List<RoadBookAreaData>(this.AreaDataMap.Values);
			list.Sort(delegate(RoadBookAreaData a, RoadBookAreaData b)
			{
				RoadBookArea value = ActivityRoadBookConfig.Instance.GetAreaConfig(a.AreaId).Value;
				RoadBookArea value2 = ActivityRoadBookConfig.Instance.GetAreaConfig(b.AreaId).Value;
				if (value.Sort == value2.Sort)
				{
					return a.AreaId - b.AreaId;
				}
				return value.Sort - value2.Sort;
			});
			return list;
		}

		// Token: 0x0603403F RID: 213055 RVA: 0x00E8D4F0 File Offset: 0x00E8B6F0
		public bool GetAllAreaNewUnlockState()
		{
			foreach (int areaId in this.AreaDataMap.Keys)
			{
				if (this.GetAreaNewUnlockState(areaId))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06034040 RID: 213056 RVA: 0x00E8D554 File Offset: 0x00E8B754
		public void RefreshTravelTaskData(ConditionTask task)
		{
			global::ActivityTaskData activityTaskData;
			if (!this.AreaTaskMap.TryGetValue(task.Id, out activityTaskData))
			{
				activityTaskData = new global::ActivityTaskData();
				RoadBookTask value = ActivityRoadBookConfig.Instance.GetRoadBookTaskConfig(task.Id).Value;
				this.AreaDataMap[value.AreaId].TravelTaskIdSet.Add(task.Id);
				this.AreaTaskMap[task.Id] = activityTaskData;
			}
			activityTaskData.Refresh(task, delegate(bool isChanged, EActivityTaskState former, EActivityTaskState after)
			{
				if (!isChanged)
				{
					return;
				}
				if (after == EActivityTaskState.FinishedAndClaimed)
				{
					this.TaskFinalRewardData.FinishedIdSet.Add(task.Id);
				}
			});
		}

		// Token: 0x06034041 RID: 213057 RVA: 0x00E8D60A File Offset: 0x00E8B80A
		public void SetTravelTaskDataDone(int taskId)
		{
			this.AreaTaskMap[taskId].Status = EActivityTaskState.FinishedAndClaimed;
			this.TaskFinalRewardData.FinishedIdSet.Add(taskId);
		}

		// Token: 0x06034042 RID: 213058 RVA: 0x00E8D630 File Offset: 0x00E8B830
		public bool IsAreaTaskFinish(int areaId)
		{
			foreach (int key in this.AreaDataMap[areaId].TravelTaskIdSet)
			{
				if (this.AreaTaskMap[key].Status != EActivityTaskState.FinishedAndClaimed)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06034043 RID: 213059 RVA: 0x00E8D6A4 File Offset: 0x00E8B8A4
		public int GetFinishedAreaTaskCount()
		{
			int num = 0;
			using (Dictionary<int, global::ActivityTaskData>.ValueCollection.Enumerator enumerator = this.AreaTaskMap.Values.GetEnumerator())
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

		// Token: 0x06034044 RID: 213060 RVA: 0x00E8D704 File Offset: 0x00E8B904
		public List<global::ActivityTaskData> GetAreaTaskDataList(int areaId)
		{
			List<global::ActivityTaskData> list = new List<global::ActivityTaskData>();
			foreach (int key in this.AreaDataMap[areaId].TravelTaskIdSet)
			{
				global::ActivityTaskData item = this.AreaTaskMap[key];
				list.Add(item);
			}
			list.Sort(this.SortTaskData());
			return list;
		}

		// Token: 0x06034045 RID: 213061 RVA: 0x00E8D784 File Offset: 0x00E8B984
		public bool GetAreaNewUnlockState(int areaId)
		{
			bool isUnlock = this.AreaDataMap[areaId].IsUnlock;
			bool flag = this.AreaDataMap[areaId].TravelTaskIdSet.Count > 0;
			bool flag2 = this.IsAreaTaskFinish(areaId);
			return isUnlock && !flag2 && flag && ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 5, areaId, 0) == 0;
		}

		// Token: 0x06034046 RID: 213062 RVA: 0x00E8D7EC File Offset: 0x00E8B9EC
		public bool GetAreaRewardState(int areaId)
		{
			RoadBookAreaData roadBookAreaData = this.AreaDataMap[areaId];
			if (!roadBookAreaData.IsUnlock)
			{
				return false;
			}
			foreach (int key in roadBookAreaData.TravelTaskIdSet)
			{
				if (this.AreaTaskMap[key].Status == EActivityTaskState.FinishedAndUnclaimed)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06034047 RID: 213063 RVA: 0x00E8D86C File Offset: 0x00E8BA6C
		public bool GetTaskRedDotState(bool checkAreaUnlock = false)
		{
			if (this.TaskFinalRewardData != null && this.TaskFinalRewardData.CanReceive())
			{
				return true;
			}
			foreach (int areaId in this.AreaDataMap.Keys)
			{
				if (checkAreaUnlock && this.GetAreaNewUnlockState(areaId))
				{
					return true;
				}
				if (this.GetAreaRewardState(areaId))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06034048 RID: 213064 RVA: 0x00E8D8F4 File Offset: 0x00E8BAF4
		private void InitPhantomData()
		{
			this.PhantomDataMap.Clear();
			foreach (RoadBookPhantomGain roadBookPhantomGain in ActivityRoadBookConfig.Instance.GetAllPhantomConfig(base.Id))
			{
				this.PhantomDataMap[roadBookPhantomGain.Id] = false;
			}
		}

		// Token: 0x06034049 RID: 213065 RVA: 0x00E8D964 File Offset: 0x00E8BB64
		public void UnlockPhantom(int phantomId)
		{
			this.PhantomDataMap[phantomId] = true;
		}

		// Token: 0x0603404A RID: 213066 RVA: 0x00E8D974 File Offset: 0x00E8BB74
		public bool GetAllPhantomNewUnlockState()
		{
			foreach (KeyValuePair<int, bool> keyValuePair in this.PhantomDataMap)
			{
				if (keyValuePair.Value && this.GetPhantomNewUnlockState(keyValuePair.Key))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0603404B RID: 213067 RVA: 0x00E8D9E0 File Offset: 0x00E8BBE0
		public bool GetPhantomNewUnlockState(int phantomId)
		{
			int key = phantomId - 6000000;
			return ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 4, key, 0) == 0;
		}

		// Token: 0x0603404C RID: 213068 RVA: 0x00E8DA10 File Offset: 0x00E8BC10
		private void InitMotorChallengeData()
		{
			this.MotorChallengeRewardDataMap.Clear();
			int num = 0;
			foreach (MotorcycleChallenge motorcycleChallenge in ActivityRoadBookConfig.Instance.GetAllMotorChallengeConfig())
			{
				global::ActivityTaskData activityTaskData = new global::ActivityTaskData();
				activityTaskData.Id = motorcycleChallenge.Id;
				activityTaskData.Target = motorcycleChallenge.NeedScore;
				this.MotorChallengeRewardDataMap[motorcycleChallenge.Id] = activityTaskData;
				MotorChallengePlayData motorChallengePlayData;
				if (!this.MotorChallengePlayDataMap.TryGetValue(motorcycleChallenge.LevelPlayId, out motorChallengePlayData))
				{
					motorChallengePlayData = new MotorChallengePlayData();
					motorChallengePlayData.TabIndex = num;
					motorChallengePlayData.PlayId = motorcycleChallenge.LevelPlayId;
					motorChallengePlayData.NameTextId = motorcycleChallenge.Name;
					motorChallengePlayData.CheckRedDot = new Func<int[], bool>(this.CheckMotorItemRedDot);
					motorChallengePlayData.CheckFinished = new Func<int[], bool>(this.CheckMotorItemFinished);
					motorChallengePlayData.JumpId = motorcycleChallenge.JumpId;
					motorChallengePlayData.ClassId = motorcycleChallenge.ClassificationId;
					this.MotorChallengePlayDataMap[motorcycleChallenge.LevelPlayId] = motorChallengePlayData;
					num++;
				}
				motorChallengePlayData.RewardIds.Add(motorcycleChallenge.Id);
			}
		}

		// Token: 0x0603404D RID: 213069 RVA: 0x00E8DB54 File Offset: 0x00E8BD54
		public void RefreshMotorChallengePlayData(RoadBookMotorcycleInfo challengeInfo)
		{
			MotorChallengePlayData motorChallengePlayData;
			if (!this.MotorChallengePlayDataMap.TryGetValue(challengeInfo.MotorcyclePlayId, out motorChallengePlayData))
			{
				return;
			}
			motorChallengePlayData.HighestPoint = challengeInfo.HistorySoarScore;
			foreach (int num in motorChallengePlayData.RewardIds)
			{
				global::ActivityTaskData activityTaskData = this.MotorChallengeRewardDataMap[num];
				activityTaskData.Current = motorChallengePlayData.HighestPoint;
				bool flag = false;
				for (int i = 0; i < challengeInfo.ReceiveIds.Count; i++)
				{
					if (challengeInfo.ReceiveIds[i] == num)
					{
						flag = true;
						break;
					}
				}
				if (flag)
				{
					activityTaskData.Status = EActivityTaskState.FinishedAndClaimed;
				}
				else if (activityTaskData.Current >= activityTaskData.Target)
				{
					activityTaskData.Status = EActivityTaskState.FinishedAndUnclaimed;
				}
				else
				{
					activityTaskData.Status = EActivityTaskState.Active;
				}
			}
		}

		// Token: 0x0603404E RID: 213070 RVA: 0x00E8DC3C File Offset: 0x00E8BE3C
		public void SetMotorChallengeRewardDone(int rewardId)
		{
			this.MotorChallengeRewardDataMap[rewardId].Status = EActivityTaskState.FinishedAndClaimed;
		}

		// Token: 0x0603404F RID: 213071 RVA: 0x00E8DC50 File Offset: 0x00E8BE50
		protected void RefreshMotorChallengeUnlockState(int playId)
		{
			MotorChallengePlayData motorChallengePlayData = this.MotorChallengePlayDataMap[playId];
			MotorcycleChallenge value = ActivityRoadBookConfig.Instance.GetMotorChallengeConfig(motorChallengePlayData.RewardIds[0]).Value;
			motorChallengePlayData.IsNew = false;
			if (this.TravelLevel < value.UnlockTravelLevel)
			{
				return;
			}
			if (value.UnlockQuestId != 0)
			{
				bool isUnlock = QuestNewModel.Instance.CheckQuestFinished(value.UnlockQuestId);
				motorChallengePlayData.IsUnlock = isUnlock;
			}
			else
			{
				motorChallengePlayData.IsUnlock = true;
			}
			motorChallengePlayData.IsNew = this.GetMotorItemNewUnlockState(playId);
		}

		// Token: 0x06034050 RID: 213072 RVA: 0x00E8DCD8 File Offset: 0x00E8BED8
		public string GetMotorPlayLockTips(int playId)
		{
			MotorChallengePlayData motorChallengePlayData = this.MotorChallengePlayDataMap[playId];
			return ActivityRoadBookConfig.Instance.GetMotorChallengeConfig(motorChallengePlayData.RewardIds[0]).Value.LockTips;
		}

		// Token: 0x06034051 RID: 213073 RVA: 0x00E8DD18 File Offset: 0x00E8BF18
		public List<MotorChallengePlayData> GetAllMotorTabData()
		{
			return new List<MotorChallengePlayData>(this.MotorChallengePlayDataMap.Values);
		}

		// Token: 0x06034052 RID: 213074 RVA: 0x00E8DD2C File Offset: 0x00E8BF2C
		public List<global::ActivityTaskData> GetMotorItemDataList(List<int> ids)
		{
			List<global::ActivityTaskData> list = new List<global::ActivityTaskData>();
			foreach (int key in ids)
			{
				global::ActivityTaskData item;
				if (this.MotorChallengeRewardDataMap.TryGetValue(key, out item))
				{
					list.Add(item);
				}
			}
			list.Sort(this.SortTaskData());
			return list;
		}

		// Token: 0x06034053 RID: 213075 RVA: 0x00E8DDA0 File Offset: 0x00E8BFA0
		protected bool GetAllMotorItemRedDot()
		{
			using (Dictionary<int, global::ActivityTaskData>.ValueCollection.Enumerator enumerator = this.MotorChallengeRewardDataMap.Values.GetEnumerator())
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

		// Token: 0x06034054 RID: 213076 RVA: 0x00E8DE00 File Offset: 0x00E8C000
		protected bool RefreshAndGetAllMotorItemNewUnlock()
		{
			bool flag = false;
			foreach (int playId in this.MotorChallengePlayDataMap.Keys)
			{
				this.RefreshMotorChallengeUnlockState(playId);
				if (!flag && this.GetMotorItemNewUnlockState(playId))
				{
					flag = true;
				}
			}
			return flag;
		}

		// Token: 0x06034055 RID: 213077 RVA: 0x00E8DE6C File Offset: 0x00E8C06C
		public bool GetMotorItemNewUnlockState(int playId)
		{
			MotorChallengePlayData motorChallengePlayData = this.MotorChallengePlayDataMap[playId];
			return motorChallengePlayData.IsUnlock && ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 7, motorChallengePlayData.TabIndex, 0) == 0;
		}

		// Token: 0x06034056 RID: 213078 RVA: 0x00E8DEAC File Offset: 0x00E8C0AC
		protected bool CheckMotorItemRedDot(int[] ids)
		{
			foreach (int key in ids)
			{
				global::ActivityTaskData activityTaskData;
				if (this.MotorChallengeRewardDataMap.TryGetValue(key, out activityTaskData) && activityTaskData.Status == EActivityTaskState.FinishedAndUnclaimed)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06034057 RID: 213079 RVA: 0x00E8DEE8 File Offset: 0x00E8C0E8
		protected bool CheckMotorItemFinished(int[] ids)
		{
			foreach (int key in ids)
			{
				global::ActivityTaskData activityTaskData;
				if (this.MotorChallengeRewardDataMap.TryGetValue(key, out activityTaskData) && activityTaskData.Status != EActivityTaskState.FinishedAndClaimed)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0401B83B RID: 112699
		public const int PHANTOM_ID_OFFSET = 6000000;

		// Token: 0x0401B83C RID: 112700
		public readonly Dictionary<int, IRoadBookLevelData> TravelLevelData = new Dictionary<int, IRoadBookLevelData>();

		// Token: 0x0401B83D RID: 112701
		public int TravelLevel;

		// Token: 0x0401B83E RID: 112702
		private int LastTravelLevelInternal;

		// Token: 0x0401B83F RID: 112703
		private int LastExpCountInternal;

		// Token: 0x0401B840 RID: 112704
		private int LastCurrentExpCountInternal;

		// Token: 0x0401B841 RID: 112705
		protected Dictionary<int, RoadBookAreaData> AreaDataMap = new Dictionary<int, RoadBookAreaData>();

		// Token: 0x0401B842 RID: 112706
		public Dictionary<int, global::ActivityTaskData> AreaTaskMap = new Dictionary<int, global::ActivityTaskData>();

		// Token: 0x0401B843 RID: 112707
		[Nullable(2)]
		public FinalTravelTaskData TaskFinalRewardData;

		// Token: 0x0401B844 RID: 112708
		public Dictionary<int, bool> PhantomDataMap = new Dictionary<int, bool>();

		// Token: 0x0401B845 RID: 112709
		public Dictionary<int, global::ActivityTaskData> MotorChallengeRewardDataMap = new Dictionary<int, global::ActivityTaskData>();

		// Token: 0x0401B846 RID: 112710
		public Dictionary<int, MotorChallengePlayData> MotorChallengePlayDataMap = new Dictionary<int, MotorChallengePlayData>();
	}
}
