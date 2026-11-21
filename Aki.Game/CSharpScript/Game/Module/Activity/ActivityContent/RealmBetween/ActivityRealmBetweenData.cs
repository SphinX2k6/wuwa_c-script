using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RealmBetween
{
	// Token: 0x020051DF RID: 20959
	[NullableContext(1)]
	[Nullable(0)]
	public class ActivityRealmBetweenData : ActivityBaseData
	{
		// Token: 0x0603439D RID: 213917 RVA: 0x00E9C488 File Offset: 0x00E9A688
		protected override void OnInit(ActivityData data)
		{
			this.InitTravelLevelData();
			this.InitTravelAreaData();
			this.InitPhantomData();
			this.InitMotorChallengeData();
			RealmBetweenActivityInfo realmBetweenActivityInfo = data.RealmBetweenActivityInfo;
			if (realmBetweenActivityInfo == null)
			{
				return;
			}
			this.TravelLevel = realmBetweenActivityInfo.RealmBetweenLevel;
			this.LastTravelLevelInternal = realmBetweenActivityInfo.RealmBetweenLevel;
			this.LastCurrentExpCountInternal = this.GetCurrentExp();
			this.LastExpCountInternal = this.GetExpItemCount();
		}

		// Token: 0x0603439E RID: 213918 RVA: 0x00E9C4E8 File Offset: 0x00E9A6E8
		protected override void PhraseEx(ActivityData data)
		{
			RealmBetweenActivityInfo realmBetweenActivityInfo = data.RealmBetweenActivityInfo;
			if (realmBetweenActivityInfo == null)
			{
				return;
			}
			this.RefreshRealmBetweenData(realmBetweenActivityInfo);
		}

		// Token: 0x0603439F RID: 213919 RVA: 0x00E9C508 File Offset: 0x00E9A708
		protected void RefreshRealmBetweenData(RealmBetweenActivityInfo info)
		{
			this.TravelLevel = info.RealmBetweenLevel;
			for (int i = 0; i < info.UnLockAreas.Count; i++)
			{
				this.UnlockAreaData(info.UnLockAreas[i]);
			}
			for (int j = 0; j < info.ActivityTasks.Count; j++)
			{
				ConditionTask task = info.ActivityTasks[j];
				this.RefreshTravelTaskData(task);
			}
			this.TaskFinalRewardData.IsReceived = info.GetFullReward;
			for (int k = 0; k < info.MonsterGain.Count; k++)
			{
				this.UnlockPhantom(info.MonsterGain[k]);
			}
			for (int l = 0; l < info.SoarLevels.Count; l++)
			{
				RealmBetweenMotorcycleInfo challengeInfo = info.SoarLevels[l];
				this.RefreshMotorChallengePlayData(challengeInfo);
			}
			foreach (int playId in this.MotorChallengePlayDataMap.Keys)
			{
				this.RefreshMotorChallengeUnlockState(playId);
			}
		}

		// Token: 0x060343A0 RID: 213920 RVA: 0x00E9C62C File Offset: 0x00E9A82C
		public override bool GetExDataRedPointShowState()
		{
			return this.CanTravelLevelUp() || this.GetTaskRedDotState(true) || this.GetAllMotorItemRedDot();
		}

		// Token: 0x060343A1 RID: 213921 RVA: 0x00E9C650 File Offset: 0x00E9A850
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

		// Token: 0x060343A2 RID: 213922 RVA: 0x00E9C724 File Offset: 0x00E9A924
		public bool SaveFirstCheckRedDotState(ERealmBetweenSaveFlag saveFlag, int id = 0)
		{
			if (ActivityModel.Instance.GetActivityCacheData(base.Id, 0, (int)saveFlag, id, 0) == 1)
			{
				return true;
			}
			ActivityModel.Instance.SaveActivityData(base.Id, (int)saveFlag, id, 0, 1);
			this.RefreshActivityRedDotState();
			return false;
		}

		// Token: 0x060343A3 RID: 213923 RVA: 0x00E9C75C File Offset: 0x00E9A95C
		[NullableContext(0)]
		[return: TupleElementNames(new string[]
		{
			"current",
			"total"
		})]
		public ValueTuple<int, int> GetTypeProgress(ERealmBetweenSubType subType)
		{
			int num = 0;
			int item = 1;
			switch (subType)
			{
			case ERealmBetweenSubType.TravelTask:
				num = this.GetFinishedAreaTaskCount();
				item = this.AreaTaskMap.Count;
				break;
			case ERealmBetweenSubType.PhantomCollect:
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
			case ERealmBetweenSubType.MotorChallenge:
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

		// Token: 0x060343A4 RID: 213924 RVA: 0x00E9C858 File Offset: 0x00E9AA58
		public bool GetTypeRedDotState(ERealmBetweenSubType subType)
		{
			if (subType != ERealmBetweenSubType.TravelTask)
			{
				return subType == ERealmBetweenSubType.MotorChallenge && this.GetAllMotorItemRedDot();
			}
			return this.GetTaskRedDotState(false);
		}

		// Token: 0x060343A5 RID: 213925 RVA: 0x00E9C874 File Offset: 0x00E9AA74
		public bool GetTypeNewState(ERealmBetweenSubType subType)
		{
			switch (subType)
			{
			case ERealmBetweenSubType.TravelTask:
				return this.GetAllAreaNewUnlockState();
			case ERealmBetweenSubType.PhantomCollect:
				return this.GetAllPhantomNewUnlockState();
			case ERealmBetweenSubType.MotorChallenge:
				return this.RefreshAndGetAllMotorItemNewUnlock();
			}
			return false;
		}

		// Token: 0x060343A6 RID: 213926 RVA: 0x00E9C8A6 File Offset: 0x00E9AAA6
		public void RefreshActivityRedDotState()
		{
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
		}

		// Token: 0x060343A7 RID: 213927 RVA: 0x00E9C8C0 File Offset: 0x00E9AAC0
		public RealmBetweenConfig GetActivityConfig()
		{
			return ActivityRealmBetweenConfig.Instance.GetActivityConfig(base.Id).Value;
		}

		// Token: 0x060343A8 RID: 213928 RVA: 0x00E9C8E5 File Offset: 0x00E9AAE5
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

		// Token: 0x170065BF RID: 26047
		// (get) Token: 0x060343A9 RID: 213929 RVA: 0x00E9C906 File Offset: 0x00E9AB06
		public int LastTravelLevel
		{
			get
			{
				int lastTravelLevelInternal = this.LastTravelLevelInternal;
				this.LastTravelLevelInternal = this.TravelLevel;
				return lastTravelLevelInternal;
			}
		}

		// Token: 0x170065C0 RID: 26048
		// (get) Token: 0x060343AA RID: 213930 RVA: 0x00E9C91A File Offset: 0x00E9AB1A
		public int LastCurrentExpCount
		{
			get
			{
				int lastCurrentExpCountInternal = this.LastCurrentExpCountInternal;
				this.LastCurrentExpCountInternal = this.GetCurrentExp();
				return lastCurrentExpCountInternal;
			}
		}

		// Token: 0x170065C1 RID: 26049
		// (get) Token: 0x060343AB RID: 213931 RVA: 0x00E9C92E File Offset: 0x00E9AB2E
		public int LastExpCount
		{
			get
			{
				int lastExpCountInternal = this.LastExpCountInternal;
				this.LastExpCountInternal = this.GetExpItemCount();
				return lastExpCountInternal;
			}
		}

		// Token: 0x170065C2 RID: 26050
		// (get) Token: 0x060343AC RID: 213932 RVA: 0x00E9C944 File Offset: 0x00E9AB44
		public int MaxTravelLevel
		{
			get
			{
				return this.GetActivityConfig().MaxLevel;
			}
		}

		// Token: 0x060343AD RID: 213933 RVA: 0x00E9C960 File Offset: 0x00E9AB60
		private void InitTravelLevelData()
		{
			this.TravelLevelData.Clear();
			IEnumerable<RealmBetweenLevelExp> allLevelExpConfig = ActivityRealmBetweenConfig.Instance.GetAllLevelExpConfig(base.Id);
			int num = 0;
			foreach (RealmBetweenLevelExp realmBetweenLevelExp in allLevelExpConfig)
			{
				RealmBetweenLevelData value = new RealmBetweenLevelData
				{
					Id = realmBetweenLevelExp.Id,
					Level = realmBetweenLevelExp.Level,
					AccumulateExp = num,
					TargetExp = realmBetweenLevelExp.NeedExp
				};
				this.TravelLevelData[realmBetweenLevelExp.Level] = value;
				num += realmBetweenLevelExp.NeedExp;
			}
		}

		// Token: 0x060343AE RID: 213934 RVA: 0x00E9CA10 File Offset: 0x00E9AC10
		public int GetExpItemCount()
		{
			int expItemId = this.GetActivityConfig().ExpItemId;
			return InventoryModel.Instance.GetItemCountByConfigId(expItemId, 0);
		}

		// Token: 0x060343AF RID: 213935 RVA: 0x00E9CA38 File Offset: 0x00E9AC38
		public int GetCurrentExp()
		{
			int expItemCount = this.GetExpItemCount();
			IRealmBetweenLevelData realmBetweenLevelData;
			int num = this.TravelLevelData.TryGetValue(this.TravelLevel, out realmBetweenLevelData) ? realmBetweenLevelData.AccumulateExp : 0;
			return expItemCount - num;
		}

		// Token: 0x060343B0 RID: 213936 RVA: 0x00E9CA6C File Offset: 0x00E9AC6C
		public int GetCurrentTargetExp()
		{
			bool flag = this.MaxTravelLevel == this.TravelLevel;
			IRealmBetweenLevelData realmBetweenLevelData = this.TravelLevelData[this.TravelLevel];
			if (!flag)
			{
				return realmBetweenLevelData.TargetExp;
			}
			return realmBetweenLevelData.AccumulateExp;
		}

		// Token: 0x060343B1 RID: 213937 RVA: 0x00E9CAA8 File Offset: 0x00E9ACA8
		public bool CanTravelLevelUp()
		{
			if (this.MaxTravelLevel == this.TravelLevel)
			{
				return false;
			}
			int expItemCount = this.GetExpItemCount();
			IRealmBetweenLevelData realmBetweenLevelData;
			if (!this.TravelLevelData.TryGetValue(this.TravelLevel, out realmBetweenLevelData))
			{
				return false;
			}
			int num = realmBetweenLevelData.AccumulateExp + realmBetweenLevelData.TargetExp;
			return expItemCount >= num;
		}

		// Token: 0x060343B2 RID: 213938 RVA: 0x00E9CAFC File Offset: 0x00E9ACFC
		private void InitTravelAreaData()
		{
			this.AreaDataMap.Clear();
			this.TaskFinalRewardData = new FinalTravelTaskData();
			IReadOnlyList<RealmBetweenTask> allRealmBetweenTaskConfig = ActivityRealmBetweenConfig.Instance.GetAllRealmBetweenTaskConfig(base.Id);
			this.TaskFinalRewardData.Target = allRealmBetweenTaskConfig.Count;
			foreach (RealmBetweenArea realmBetweenArea in ActivityRealmBetweenConfig.Instance.GetAllAreaConfig(base.Id))
			{
				RealmBetweenAreaData value = new RealmBetweenAreaData(realmBetweenArea.Id);
				this.AreaDataMap[realmBetweenArea.Id] = value;
			}
		}

		// Token: 0x060343B3 RID: 213939 RVA: 0x00E9CBA4 File Offset: 0x00E9ADA4
		public void UnlockAreaData(int areaId)
		{
			RealmBetweenAreaData realmBetweenAreaData;
			if (!this.AreaDataMap.TryGetValue(areaId, out realmBetweenAreaData))
			{
				return;
			}
			realmBetweenAreaData.IsUnlock = true;
		}

		// Token: 0x060343B4 RID: 213940 RVA: 0x00E9CBC9 File Offset: 0x00E9ADC9
		public void OnNewAreaUnlocked(int areaId)
		{
			this.UnlockAreaData(areaId);
			ActivityModel.Instance.SaveActivityData(base.Id, 5, areaId, 0, 0);
		}

		// Token: 0x060343B5 RID: 213941 RVA: 0x00E9CBE6 File Offset: 0x00E9ADE6
		public List<RealmBetweenAreaData> GetAllAreaData()
		{
			List<RealmBetweenAreaData> list = new List<RealmBetweenAreaData>(this.AreaDataMap.Values);
			list.Sort(delegate(RealmBetweenAreaData a, RealmBetweenAreaData b)
			{
				RealmBetweenArea value = ActivityRealmBetweenConfig.Instance.GetAreaConfig(a.AreaId).Value;
				RealmBetweenArea value2 = ActivityRealmBetweenConfig.Instance.GetAreaConfig(b.AreaId).Value;
				if (value.Sort == value2.Sort)
				{
					return a.AreaId - b.AreaId;
				}
				return value.Sort - value2.Sort;
			});
			return list;
		}

		// Token: 0x060343B6 RID: 213942 RVA: 0x00E9CC20 File Offset: 0x00E9AE20
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

		// Token: 0x060343B7 RID: 213943 RVA: 0x00E9CC84 File Offset: 0x00E9AE84
		public void RefreshTravelTaskData(ConditionTask task)
		{
			global::ActivityTaskData activityTaskData;
			if (!this.AreaTaskMap.TryGetValue(task.Id, out activityTaskData))
			{
				activityTaskData = new global::ActivityTaskData();
				RealmBetweenTask value = ActivityRealmBetweenConfig.Instance.GetRealmBetweenTaskConfig(task.Id).Value;
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

		// Token: 0x060343B8 RID: 213944 RVA: 0x00E9CD3A File Offset: 0x00E9AF3A
		public void SetTravelTaskDataDone(int taskId)
		{
			this.AreaTaskMap[taskId].Status = EActivityTaskState.FinishedAndClaimed;
			this.TaskFinalRewardData.FinishedIdSet.Add(taskId);
		}

		// Token: 0x060343B9 RID: 213945 RVA: 0x00E9CD60 File Offset: 0x00E9AF60
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

		// Token: 0x060343BA RID: 213946 RVA: 0x00E9CDD4 File Offset: 0x00E9AFD4
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

		// Token: 0x060343BB RID: 213947 RVA: 0x00E9CE34 File Offset: 0x00E9B034
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

		// Token: 0x060343BC RID: 213948 RVA: 0x00E9CEB4 File Offset: 0x00E9B0B4
		public bool GetAreaNewUnlockState(int areaId)
		{
			bool isUnlock = this.AreaDataMap[areaId].IsUnlock;
			bool flag = this.AreaDataMap[areaId].TravelTaskIdSet.Count > 0;
			bool flag2 = this.IsAreaTaskFinish(areaId);
			return isUnlock && !flag2 && flag && ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 5, areaId, 0) == 0;
		}

		// Token: 0x060343BD RID: 213949 RVA: 0x00E9CF1C File Offset: 0x00E9B11C
		public bool GetAreaRewardState(int areaId)
		{
			RealmBetweenAreaData realmBetweenAreaData = this.AreaDataMap[areaId];
			if (!realmBetweenAreaData.IsUnlock)
			{
				return false;
			}
			foreach (int key in realmBetweenAreaData.TravelTaskIdSet)
			{
				if (this.AreaTaskMap[key].Status == EActivityTaskState.FinishedAndUnclaimed)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060343BE RID: 213950 RVA: 0x00E9CF9C File Offset: 0x00E9B19C
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

		// Token: 0x060343BF RID: 213951 RVA: 0x00E9D024 File Offset: 0x00E9B224
		private void InitPhantomData()
		{
			this.PhantomDataMap.Clear();
			foreach (RealmBetweenPhantomGain realmBetweenPhantomGain in ActivityRealmBetweenConfig.Instance.GetAllPhantomConfig(base.Id))
			{
				this.PhantomDataMap[realmBetweenPhantomGain.Id] = false;
			}
		}

		// Token: 0x060343C0 RID: 213952 RVA: 0x00E9D094 File Offset: 0x00E9B294
		public void UnlockPhantom(int phantomId)
		{
			this.PhantomDataMap[phantomId] = true;
		}

		// Token: 0x060343C1 RID: 213953 RVA: 0x00E9D0A4 File Offset: 0x00E9B2A4
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

		// Token: 0x060343C2 RID: 213954 RVA: 0x00E9D110 File Offset: 0x00E9B310
		public bool GetPhantomNewUnlockState(int phantomId)
		{
			int key = phantomId - 6000000;
			return ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 4, key, 0) == 0;
		}

		// Token: 0x060343C3 RID: 213955 RVA: 0x00E9D13C File Offset: 0x00E9B33C
		private void InitMotorChallengeData()
		{
			this.MotorChallengeRewardDataMap.Clear();
			int num = 0;
			foreach (RealmBetweenChallenge realmBetweenChallenge in ActivityRealmBetweenConfig.Instance.GetAllMotorChallengeConfig())
			{
				global::ActivityTaskData activityTaskData = new global::ActivityTaskData();
				activityTaskData.Id = realmBetweenChallenge.Id;
				activityTaskData.Target = realmBetweenChallenge.NeedScore;
				this.MotorChallengeRewardDataMap[realmBetweenChallenge.Id] = activityTaskData;
				MotorChallengePlayData motorChallengePlayData;
				if (!this.MotorChallengePlayDataMap.TryGetValue(realmBetweenChallenge.LevelPlayId, out motorChallengePlayData))
				{
					motorChallengePlayData = new MotorChallengePlayData();
					motorChallengePlayData.TabIndex = num;
					motorChallengePlayData.PlayId = realmBetweenChallenge.LevelPlayId;
					motorChallengePlayData.NameTextId = realmBetweenChallenge.Name;
					motorChallengePlayData.CheckRedDot = new Func<int[], bool>(this.CheckMotorItemRedDot);
					motorChallengePlayData.CheckFinished = new Func<int[], bool>(this.CheckMotorItemFinished);
					motorChallengePlayData.JumpId = realmBetweenChallenge.JumpId;
					motorChallengePlayData.ClassId = realmBetweenChallenge.ClassificationId;
					this.MotorChallengePlayDataMap[realmBetweenChallenge.LevelPlayId] = motorChallengePlayData;
					num++;
				}
				motorChallengePlayData.RewardIds.Add(realmBetweenChallenge.Id);
			}
		}

		// Token: 0x060343C4 RID: 213956 RVA: 0x00E9D280 File Offset: 0x00E9B480
		public void RefreshMotorChallengePlayData(RealmBetweenMotorcycleInfo challengeInfo)
		{
			MotorChallengePlayData motorChallengePlayData;
			if (!this.MotorChallengePlayDataMap.TryGetValue(challengeInfo.MotorcyclePlayId, out motorChallengePlayData))
			{
				return;
			}
			motorChallengePlayData.IsUnlock = true;
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

		// Token: 0x060343C5 RID: 213957 RVA: 0x00E9D370 File Offset: 0x00E9B570
		public void SetMotorChallengeRewardDone(int rewardId)
		{
			this.MotorChallengeRewardDataMap[rewardId].Status = EActivityTaskState.FinishedAndClaimed;
		}

		// Token: 0x060343C6 RID: 213958 RVA: 0x00E9D384 File Offset: 0x00E9B584
		protected void RefreshMotorChallengeUnlockState(int playId)
		{
			MotorChallengePlayData motorChallengePlayData = this.MotorChallengePlayDataMap[playId];
			RealmBetweenChallenge value = ActivityRealmBetweenConfig.Instance.GetMotorChallengeConfig(motorChallengePlayData.RewardIds[0]).Value;
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

		// Token: 0x060343C7 RID: 213959 RVA: 0x00E9D40C File Offset: 0x00E9B60C
		public string GetMotorPlayLockTips(int playId)
		{
			MotorChallengePlayData motorChallengePlayData = this.MotorChallengePlayDataMap[playId];
			return ActivityRealmBetweenConfig.Instance.GetMotorChallengeConfig(motorChallengePlayData.RewardIds[0]).Value.LockTips;
		}

		// Token: 0x060343C8 RID: 213960 RVA: 0x00E9D44C File Offset: 0x00E9B64C
		public List<MotorChallengePlayData> GetAllMotorTabData()
		{
			return new List<MotorChallengePlayData>(this.MotorChallengePlayDataMap.Values);
		}

		// Token: 0x060343C9 RID: 213961 RVA: 0x00E9D460 File Offset: 0x00E9B660
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

		// Token: 0x060343CA RID: 213962 RVA: 0x00E9D4D4 File Offset: 0x00E9B6D4
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

		// Token: 0x060343CB RID: 213963 RVA: 0x00E9D534 File Offset: 0x00E9B734
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

		// Token: 0x060343CC RID: 213964 RVA: 0x00E9D5A0 File Offset: 0x00E9B7A0
		public bool GetMotorItemNewUnlockState(int playId)
		{
			MotorChallengePlayData motorChallengePlayData = this.MotorChallengePlayDataMap[playId];
			return motorChallengePlayData.IsUnlock && ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 7, motorChallengePlayData.TabIndex, 0) == 0;
		}

		// Token: 0x060343CD RID: 213965 RVA: 0x00E9D5E0 File Offset: 0x00E9B7E0
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

		// Token: 0x060343CE RID: 213966 RVA: 0x00E9D61C File Offset: 0x00E9B81C
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

		// Token: 0x0401BB45 RID: 113477
		public const int PHANTOM_ID_OFFSET = 6000000;

		// Token: 0x0401BB46 RID: 113478
		public readonly Dictionary<int, IRealmBetweenLevelData> TravelLevelData = new Dictionary<int, IRealmBetweenLevelData>();

		// Token: 0x0401BB47 RID: 113479
		public int TravelLevel;

		// Token: 0x0401BB48 RID: 113480
		private int LastTravelLevelInternal;

		// Token: 0x0401BB49 RID: 113481
		private int LastExpCountInternal;

		// Token: 0x0401BB4A RID: 113482
		private int LastCurrentExpCountInternal;

		// Token: 0x0401BB4B RID: 113483
		protected Dictionary<int, RealmBetweenAreaData> AreaDataMap = new Dictionary<int, RealmBetweenAreaData>();

		// Token: 0x0401BB4C RID: 113484
		public Dictionary<int, global::ActivityTaskData> AreaTaskMap = new Dictionary<int, global::ActivityTaskData>();

		// Token: 0x0401BB4D RID: 113485
		[Nullable(2)]
		public FinalTravelTaskData TaskFinalRewardData;

		// Token: 0x0401BB4E RID: 113486
		public Dictionary<int, bool> PhantomDataMap = new Dictionary<int, bool>();

		// Token: 0x0401BB4F RID: 113487
		public Dictionary<int, global::ActivityTaskData> MotorChallengeRewardDataMap = new Dictionary<int, global::ActivityTaskData>();

		// Token: 0x0401BB50 RID: 113488
		public Dictionary<int, MotorChallengePlayData> MotorChallengePlayDataMap = new Dictionary<int, MotorChallengePlayData>();
	}
}
