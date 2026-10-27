using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RoadBook
{
	// Token: 0x020061BF RID: 25023
	[NullableContext(1)]
	[Nullable(0)]
	public class ActivityRoadBookData : ActivityBaseData
	{
		// Token: 0x0603F366 RID: 258918 RVA: 0x00F45E80 File Offset: 0x00F44080
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

		// Token: 0x0603F367 RID: 258919 RVA: 0x00F45EE0 File Offset: 0x00F440E0
		protected override void PhraseEx(ActivityData data)
		{
			RoadBookActivityInfo roadBookActivityInfo = data.RoadBookActivityInfo;
			if (roadBookActivityInfo == null)
			{
				return;
			}
			this.RefreshRoadBookData(roadBookActivityInfo);
		}

		// Token: 0x0603F368 RID: 258920 RVA: 0x00F45F00 File Offset: 0x00F44100
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

		// Token: 0x0603F369 RID: 258921 RVA: 0x00F45FD5 File Offset: 0x00F441D5
		public override bool GetExDataRedPointShowState()
		{
			return this.CanTravelLevelUp() || this.GetTaskRedDotState(true) || this.GetAllMotorItemRedDot();
		}

		// Token: 0x0603F36A RID: 258922 RVA: 0x00F45FF8 File Offset: 0x00F441F8
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

		// Token: 0x0603F36B RID: 258923 RVA: 0x00F460CC File Offset: 0x00F442CC
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

		// Token: 0x0603F36C RID: 258924 RVA: 0x00F46104 File Offset: 0x00F44304
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

		// Token: 0x0603F36D RID: 258925 RVA: 0x00F46200 File Offset: 0x00F44400
		public bool GetTypeRedDotState(ERoadBookSubType subType)
		{
			if (subType != ERoadBookSubType.TravelTask)
			{
				return subType == ERoadBookSubType.MotorChallenge && this.GetAllMotorItemRedDot();
			}
			return this.GetTaskRedDotState(false);
		}

		// Token: 0x0603F36E RID: 258926 RVA: 0x00F4621C File Offset: 0x00F4441C
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

		// Token: 0x0603F36F RID: 258927 RVA: 0x00F4624E File Offset: 0x00F4444E
		public void RefreshActivityRedDotState()
		{
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
		}

		// Token: 0x0603F370 RID: 258928 RVA: 0x00F46268 File Offset: 0x00F44468
		public RoadBookConfig GetActivityConfig()
		{
			return ActivityRoadBookConfig.Instance.GetActivityConfig(base.Id).Value;
		}

		// Token: 0x0603F371 RID: 258929 RVA: 0x00F4628D File Offset: 0x00F4448D
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

		// Token: 0x1700921A RID: 37402
		// (get) Token: 0x0603F372 RID: 258930 RVA: 0x00F462AE File Offset: 0x00F444AE
		public int LastTravelLevel
		{
			get
			{
				int lastTravelLevelInternal = this.LastTravelLevelInternal;
				this.LastTravelLevelInternal = this.TravelLevel;
				return lastTravelLevelInternal;
			}
		}

		// Token: 0x1700921B RID: 37403
		// (get) Token: 0x0603F373 RID: 258931 RVA: 0x00F462C2 File Offset: 0x00F444C2
		public int LastCurrentExpCount
		{
			get
			{
				int lastCurrentExpCountInternal = this.LastCurrentExpCountInternal;
				this.LastCurrentExpCountInternal = this.GetCurrentExp();
				return lastCurrentExpCountInternal;
			}
		}

		// Token: 0x1700921C RID: 37404
		// (get) Token: 0x0603F374 RID: 258932 RVA: 0x00F462D6 File Offset: 0x00F444D6
		public int LastExpCount
		{
			get
			{
				int lastExpCountInternal = this.LastExpCountInternal;
				this.LastExpCountInternal = this.GetExpItemCount();
				return lastExpCountInternal;
			}
		}

		// Token: 0x1700921D RID: 37405
		// (get) Token: 0x0603F375 RID: 258933 RVA: 0x00F462EC File Offset: 0x00F444EC
		public int MaxTravelLevel
		{
			get
			{
				return this.GetActivityConfig().MaxLevel;
			}
		}

		// Token: 0x0603F376 RID: 258934 RVA: 0x00F46308 File Offset: 0x00F44508
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

		// Token: 0x0603F377 RID: 258935 RVA: 0x00F463B8 File Offset: 0x00F445B8
		public int GetExpItemCount()
		{
			int expItemId = this.GetActivityConfig().ExpItemId;
			return InventoryModel.Instance.GetItemCountByConfigId(expItemId, 0);
		}

		// Token: 0x0603F378 RID: 258936 RVA: 0x00F463E0 File Offset: 0x00F445E0
		public int GetCurrentExp()
		{
			int expItemCount = this.GetExpItemCount();
			int accumulateExp = this.TravelLevelData[this.TravelLevel].AccumulateExp;
			return expItemCount - accumulateExp;
		}

		// Token: 0x0603F379 RID: 258937 RVA: 0x00F4640C File Offset: 0x00F4460C
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

		// Token: 0x0603F37A RID: 258938 RVA: 0x00F46448 File Offset: 0x00F44648
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

		// Token: 0x0603F37B RID: 258939 RVA: 0x00F46494 File Offset: 0x00F44694
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

		// Token: 0x0603F37C RID: 258940 RVA: 0x00F4653C File Offset: 0x00F4473C
		public void UnlockAreaData(int areaId)
		{
			RoadBookAreaData roadBookAreaData;
			if (!this.AreaDataMap.TryGetValue(areaId, out roadBookAreaData))
			{
				return;
			}
			roadBookAreaData.IsUnlock = true;
		}

		// Token: 0x0603F37D RID: 258941 RVA: 0x00F46561 File Offset: 0x00F44761
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

		// Token: 0x0603F37E RID: 258942 RVA: 0x00F46598 File Offset: 0x00F44798
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

		// Token: 0x0603F37F RID: 258943 RVA: 0x00F465FC File Offset: 0x00F447FC
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

		// Token: 0x0603F380 RID: 258944 RVA: 0x00F466B2 File Offset: 0x00F448B2
		public void SetTravelTaskDataDone(int taskId)
		{
			this.AreaTaskMap[taskId].Status = EActivityTaskState.FinishedAndClaimed;
			this.TaskFinalRewardData.FinishedIdSet.Add(taskId);
		}

		// Token: 0x0603F381 RID: 258945 RVA: 0x00F466D8 File Offset: 0x00F448D8
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

		// Token: 0x0603F382 RID: 258946 RVA: 0x00F4674C File Offset: 0x00F4494C
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

		// Token: 0x0603F383 RID: 258947 RVA: 0x00F467AC File Offset: 0x00F449AC
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

		// Token: 0x0603F384 RID: 258948 RVA: 0x00F4682C File Offset: 0x00F44A2C
		public bool GetAreaNewUnlockState(int areaId)
		{
			bool isUnlock = this.AreaDataMap[areaId].IsUnlock;
			bool flag = this.AreaDataMap[areaId].TravelTaskIdSet.Count > 0;
			bool flag2 = this.IsAreaTaskFinish(areaId);
			return isUnlock && !flag2 && flag && ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 5, areaId, 0) == 0;
		}

		// Token: 0x0603F385 RID: 258949 RVA: 0x00F46894 File Offset: 0x00F44A94
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

		// Token: 0x0603F386 RID: 258950 RVA: 0x00F46914 File Offset: 0x00F44B14
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

		// Token: 0x0603F387 RID: 258951 RVA: 0x00F4699C File Offset: 0x00F44B9C
		private void InitPhantomData()
		{
			this.PhantomDataMap.Clear();
			foreach (RoadBookPhantomGain roadBookPhantomGain in ActivityRoadBookConfig.Instance.GetAllPhantomConfig(base.Id))
			{
				this.PhantomDataMap[roadBookPhantomGain.Id] = false;
			}
		}

		// Token: 0x0603F388 RID: 258952 RVA: 0x00F46A0C File Offset: 0x00F44C0C
		public void UnlockPhantom(int phantomId)
		{
			this.PhantomDataMap[phantomId] = true;
		}

		// Token: 0x0603F389 RID: 258953 RVA: 0x00F46A1C File Offset: 0x00F44C1C
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

		// Token: 0x0603F38A RID: 258954 RVA: 0x00F46A88 File Offset: 0x00F44C88
		public bool GetPhantomNewUnlockState(int phantomId)
		{
			int key = phantomId - 6000000;
			return ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 4, key, 0) == 0;
		}

		// Token: 0x0603F38B RID: 258955 RVA: 0x00F46AB8 File Offset: 0x00F44CB8
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

		// Token: 0x0603F38C RID: 258956 RVA: 0x00F46BFC File Offset: 0x00F44DFC
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

		// Token: 0x0603F38D RID: 258957 RVA: 0x00F46CE4 File Offset: 0x00F44EE4
		public void SetMotorChallengeRewardDone(int rewardId)
		{
			this.MotorChallengeRewardDataMap[rewardId].Status = EActivityTaskState.FinishedAndClaimed;
		}

		// Token: 0x0603F38E RID: 258958 RVA: 0x00F46CF8 File Offset: 0x00F44EF8
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

		// Token: 0x0603F38F RID: 258959 RVA: 0x00F46D80 File Offset: 0x00F44F80
		public string GetMotorPlayLockTips(int playId)
		{
			MotorChallengePlayData motorChallengePlayData = this.MotorChallengePlayDataMap[playId];
			return ActivityRoadBookConfig.Instance.GetMotorChallengeConfig(motorChallengePlayData.RewardIds[0]).Value.LockTips;
		}

		// Token: 0x0603F390 RID: 258960 RVA: 0x00F46DC0 File Offset: 0x00F44FC0
		public List<MotorChallengePlayData> GetAllMotorTabData()
		{
			return new List<MotorChallengePlayData>(this.MotorChallengePlayDataMap.Values);
		}

		// Token: 0x0603F391 RID: 258961 RVA: 0x00F46DD4 File Offset: 0x00F44FD4
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

		// Token: 0x0603F392 RID: 258962 RVA: 0x00F46E48 File Offset: 0x00F45048
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

		// Token: 0x0603F393 RID: 258963 RVA: 0x00F46EA8 File Offset: 0x00F450A8
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

		// Token: 0x0603F394 RID: 258964 RVA: 0x00F46F14 File Offset: 0x00F45114
		public bool GetMotorItemNewUnlockState(int playId)
		{
			MotorChallengePlayData motorChallengePlayData = this.MotorChallengePlayDataMap[playId];
			return motorChallengePlayData.IsUnlock && ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 7, motorChallengePlayData.TabIndex, 0) == 0;
		}

		// Token: 0x0603F395 RID: 258965 RVA: 0x00F46F54 File Offset: 0x00F45154
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

		// Token: 0x0603F396 RID: 258966 RVA: 0x00F46F90 File Offset: 0x00F45190
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

		// Token: 0x04020F0C RID: 134924
		public const int PHANTOM_ID_OFFSET = 6000000;

		// Token: 0x04020F0D RID: 134925
		public readonly Dictionary<int, IRoadBookLevelData> TravelLevelData = new Dictionary<int, IRoadBookLevelData>();

		// Token: 0x04020F0E RID: 134926
		public int TravelLevel;

		// Token: 0x04020F0F RID: 134927
		private int LastTravelLevelInternal;

		// Token: 0x04020F10 RID: 134928
		private int LastExpCountInternal;

		// Token: 0x04020F11 RID: 134929
		private int LastCurrentExpCountInternal;

		// Token: 0x04020F12 RID: 134930
		protected Dictionary<int, RoadBookAreaData> AreaDataMap = new Dictionary<int, RoadBookAreaData>();

		// Token: 0x04020F13 RID: 134931
		public Dictionary<int, global::ActivityTaskData> AreaTaskMap = new Dictionary<int, global::ActivityTaskData>();

		// Token: 0x04020F14 RID: 134932
		[Nullable(2)]
		public FinalTravelTaskData TaskFinalRewardData;

		// Token: 0x04020F15 RID: 134933
		public Dictionary<int, bool> PhantomDataMap = new Dictionary<int, bool>();

		// Token: 0x04020F16 RID: 134934
		public Dictionary<int, global::ActivityTaskData> MotorChallengeRewardDataMap = new Dictionary<int, global::ActivityTaskData>();

		// Token: 0x04020F17 RID: 134935
		public Dictionary<int, MotorChallengePlayData> MotorChallengePlayDataMap = new Dictionary<int, MotorChallengePlayData>();
	}
}
