using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RealmBetween
{
	// Token: 0x02006261 RID: 25185
	[NullableContext(1)]
	[Nullable(0)]
	public class ActivityRealmBetweenData : ActivityBaseData
	{
		// Token: 0x0603F6DC RID: 259804 RVA: 0x00F5552C File Offset: 0x00F5372C
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

		// Token: 0x0603F6DD RID: 259805 RVA: 0x00F5558C File Offset: 0x00F5378C
		protected override void PhraseEx(ActivityData data)
		{
			RealmBetweenActivityInfo realmBetweenActivityInfo = data.RealmBetweenActivityInfo;
			if (realmBetweenActivityInfo == null)
			{
				return;
			}
			this.RefreshRealmBetweenData(realmBetweenActivityInfo);
		}

		// Token: 0x0603F6DE RID: 259806 RVA: 0x00F555AC File Offset: 0x00F537AC
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

		// Token: 0x0603F6DF RID: 259807 RVA: 0x00F556D0 File Offset: 0x00F538D0
		public override bool GetExDataRedPointShowState()
		{
			return this.CanTravelLevelUp() || this.GetTaskRedDotState(true) || this.GetAllMotorItemRedDot();
		}

		// Token: 0x0603F6E0 RID: 259808 RVA: 0x00F556F4 File Offset: 0x00F538F4
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

		// Token: 0x0603F6E1 RID: 259809 RVA: 0x00F557C8 File Offset: 0x00F539C8
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

		// Token: 0x0603F6E2 RID: 259810 RVA: 0x00F55800 File Offset: 0x00F53A00
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

		// Token: 0x0603F6E3 RID: 259811 RVA: 0x00F558FC File Offset: 0x00F53AFC
		public bool GetTypeRedDotState(ERealmBetweenSubType subType)
		{
			if (subType != ERealmBetweenSubType.TravelTask)
			{
				return subType == ERealmBetweenSubType.MotorChallenge && this.GetAllMotorItemRedDot();
			}
			return this.GetTaskRedDotState(false);
		}

		// Token: 0x0603F6E4 RID: 259812 RVA: 0x00F55918 File Offset: 0x00F53B18
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

		// Token: 0x0603F6E5 RID: 259813 RVA: 0x00F5594A File Offset: 0x00F53B4A
		public void RefreshActivityRedDotState()
		{
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
		}

		// Token: 0x0603F6E6 RID: 259814 RVA: 0x00F55964 File Offset: 0x00F53B64
		public RealmBetweenConfig GetActivityConfig()
		{
			return ActivityRealmBetweenConfig.Instance.GetActivityConfig(base.Id).Value;
		}

		// Token: 0x0603F6E7 RID: 259815 RVA: 0x00F55989 File Offset: 0x00F53B89
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

		// Token: 0x1700925D RID: 37469
		// (get) Token: 0x0603F6E8 RID: 259816 RVA: 0x00F559AA File Offset: 0x00F53BAA
		public int LastTravelLevel
		{
			get
			{
				int lastTravelLevelInternal = this.LastTravelLevelInternal;
				this.LastTravelLevelInternal = this.TravelLevel;
				return lastTravelLevelInternal;
			}
		}

		// Token: 0x1700925E RID: 37470
		// (get) Token: 0x0603F6E9 RID: 259817 RVA: 0x00F559BE File Offset: 0x00F53BBE
		public int LastCurrentExpCount
		{
			get
			{
				int lastCurrentExpCountInternal = this.LastCurrentExpCountInternal;
				this.LastCurrentExpCountInternal = this.GetCurrentExp();
				return lastCurrentExpCountInternal;
			}
		}

		// Token: 0x1700925F RID: 37471
		// (get) Token: 0x0603F6EA RID: 259818 RVA: 0x00F559D2 File Offset: 0x00F53BD2
		public int LastExpCount
		{
			get
			{
				int lastExpCountInternal = this.LastExpCountInternal;
				this.LastExpCountInternal = this.GetExpItemCount();
				return lastExpCountInternal;
			}
		}

		// Token: 0x17009260 RID: 37472
		// (get) Token: 0x0603F6EB RID: 259819 RVA: 0x00F559E8 File Offset: 0x00F53BE8
		public int MaxTravelLevel
		{
			get
			{
				return this.GetActivityConfig().MaxLevel;
			}
		}

		// Token: 0x0603F6EC RID: 259820 RVA: 0x00F55A04 File Offset: 0x00F53C04
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

		// Token: 0x0603F6ED RID: 259821 RVA: 0x00F55AB4 File Offset: 0x00F53CB4
		public int GetExpItemCount()
		{
			int expItemId = this.GetActivityConfig().ExpItemId;
			return InventoryModel.Instance.GetItemCountByConfigId(expItemId, 0);
		}

		// Token: 0x0603F6EE RID: 259822 RVA: 0x00F55ADC File Offset: 0x00F53CDC
		public int GetCurrentExp()
		{
			int expItemCount = this.GetExpItemCount();
			IRealmBetweenLevelData realmBetweenLevelData;
			int num = this.TravelLevelData.TryGetValue(this.TravelLevel, out realmBetweenLevelData) ? realmBetweenLevelData.AccumulateExp : 0;
			return expItemCount - num;
		}

		// Token: 0x0603F6EF RID: 259823 RVA: 0x00F55B10 File Offset: 0x00F53D10
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

		// Token: 0x0603F6F0 RID: 259824 RVA: 0x00F55B4C File Offset: 0x00F53D4C
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

		// Token: 0x0603F6F1 RID: 259825 RVA: 0x00F55BA0 File Offset: 0x00F53DA0
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

		// Token: 0x0603F6F2 RID: 259826 RVA: 0x00F55C48 File Offset: 0x00F53E48
		public void UnlockAreaData(int areaId)
		{
			RealmBetweenAreaData realmBetweenAreaData;
			if (!this.AreaDataMap.TryGetValue(areaId, out realmBetweenAreaData))
			{
				return;
			}
			realmBetweenAreaData.IsUnlock = true;
		}

		// Token: 0x0603F6F3 RID: 259827 RVA: 0x00F55C6D File Offset: 0x00F53E6D
		public void OnNewAreaUnlocked(int areaId)
		{
			this.UnlockAreaData(areaId);
			ActivityModel.Instance.SaveActivityData(base.Id, 5, areaId, 0, 0);
		}

		// Token: 0x0603F6F4 RID: 259828 RVA: 0x00F55C8A File Offset: 0x00F53E8A
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

		// Token: 0x0603F6F5 RID: 259829 RVA: 0x00F55CC4 File Offset: 0x00F53EC4
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

		// Token: 0x0603F6F6 RID: 259830 RVA: 0x00F55D28 File Offset: 0x00F53F28
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

		// Token: 0x0603F6F7 RID: 259831 RVA: 0x00F55DDE File Offset: 0x00F53FDE
		public void SetTravelTaskDataDone(int taskId)
		{
			this.AreaTaskMap[taskId].Status = EActivityTaskState.FinishedAndClaimed;
			this.TaskFinalRewardData.FinishedIdSet.Add(taskId);
		}

		// Token: 0x0603F6F8 RID: 259832 RVA: 0x00F55E04 File Offset: 0x00F54004
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

		// Token: 0x0603F6F9 RID: 259833 RVA: 0x00F55E78 File Offset: 0x00F54078
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

		// Token: 0x0603F6FA RID: 259834 RVA: 0x00F55ED8 File Offset: 0x00F540D8
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

		// Token: 0x0603F6FB RID: 259835 RVA: 0x00F55F58 File Offset: 0x00F54158
		public bool GetAreaNewUnlockState(int areaId)
		{
			bool isUnlock = this.AreaDataMap[areaId].IsUnlock;
			bool flag = this.AreaDataMap[areaId].TravelTaskIdSet.Count > 0;
			bool flag2 = this.IsAreaTaskFinish(areaId);
			return isUnlock && !flag2 && flag && ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 5, areaId, 0) == 0;
		}

		// Token: 0x0603F6FC RID: 259836 RVA: 0x00F55FC0 File Offset: 0x00F541C0
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

		// Token: 0x0603F6FD RID: 259837 RVA: 0x00F56040 File Offset: 0x00F54240
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

		// Token: 0x0603F6FE RID: 259838 RVA: 0x00F560C8 File Offset: 0x00F542C8
		private void InitPhantomData()
		{
			this.PhantomDataMap.Clear();
			foreach (RealmBetweenPhantomGain realmBetweenPhantomGain in ActivityRealmBetweenConfig.Instance.GetAllPhantomConfig(base.Id))
			{
				this.PhantomDataMap[realmBetweenPhantomGain.Id] = false;
			}
		}

		// Token: 0x0603F6FF RID: 259839 RVA: 0x00F56138 File Offset: 0x00F54338
		public void UnlockPhantom(int phantomId)
		{
			this.PhantomDataMap[phantomId] = true;
		}

		// Token: 0x0603F700 RID: 259840 RVA: 0x00F56148 File Offset: 0x00F54348
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

		// Token: 0x0603F701 RID: 259841 RVA: 0x00F561B4 File Offset: 0x00F543B4
		public bool GetPhantomNewUnlockState(int phantomId)
		{
			int key = phantomId - 6000000;
			return ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 4, key, 0) == 0;
		}

		// Token: 0x0603F702 RID: 259842 RVA: 0x00F561E0 File Offset: 0x00F543E0
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

		// Token: 0x0603F703 RID: 259843 RVA: 0x00F56324 File Offset: 0x00F54524
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

		// Token: 0x0603F704 RID: 259844 RVA: 0x00F56414 File Offset: 0x00F54614
		public void SetMotorChallengeRewardDone(int rewardId)
		{
			this.MotorChallengeRewardDataMap[rewardId].Status = EActivityTaskState.FinishedAndClaimed;
		}

		// Token: 0x0603F705 RID: 259845 RVA: 0x00F56428 File Offset: 0x00F54628
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

		// Token: 0x0603F706 RID: 259846 RVA: 0x00F564B0 File Offset: 0x00F546B0
		public string GetMotorPlayLockTips(int playId)
		{
			MotorChallengePlayData motorChallengePlayData = this.MotorChallengePlayDataMap[playId];
			return ActivityRealmBetweenConfig.Instance.GetMotorChallengeConfig(motorChallengePlayData.RewardIds[0]).Value.LockTips;
		}

		// Token: 0x0603F707 RID: 259847 RVA: 0x00F564F0 File Offset: 0x00F546F0
		public List<MotorChallengePlayData> GetAllMotorTabData()
		{
			return new List<MotorChallengePlayData>(this.MotorChallengePlayDataMap.Values);
		}

		// Token: 0x0603F708 RID: 259848 RVA: 0x00F56504 File Offset: 0x00F54704
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

		// Token: 0x0603F709 RID: 259849 RVA: 0x00F56578 File Offset: 0x00F54778
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

		// Token: 0x0603F70A RID: 259850 RVA: 0x00F565D8 File Offset: 0x00F547D8
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

		// Token: 0x0603F70B RID: 259851 RVA: 0x00F56644 File Offset: 0x00F54844
		public bool GetMotorItemNewUnlockState(int playId)
		{
			MotorChallengePlayData motorChallengePlayData = this.MotorChallengePlayDataMap[playId];
			return motorChallengePlayData.IsUnlock && ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 7, motorChallengePlayData.TabIndex, 0) == 0;
		}

		// Token: 0x0603F70C RID: 259852 RVA: 0x00F56684 File Offset: 0x00F54884
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

		// Token: 0x0603F70D RID: 259853 RVA: 0x00F566C0 File Offset: 0x00F548C0
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

		// Token: 0x04021216 RID: 135702
		public const int PHANTOM_ID_OFFSET = 6000000;

		// Token: 0x04021217 RID: 135703
		public readonly Dictionary<int, IRealmBetweenLevelData> TravelLevelData = new Dictionary<int, IRealmBetweenLevelData>();

		// Token: 0x04021218 RID: 135704
		public int TravelLevel;

		// Token: 0x04021219 RID: 135705
		private int LastTravelLevelInternal;

		// Token: 0x0402121A RID: 135706
		private int LastExpCountInternal;

		// Token: 0x0402121B RID: 135707
		private int LastCurrentExpCountInternal;

		// Token: 0x0402121C RID: 135708
		protected Dictionary<int, RealmBetweenAreaData> AreaDataMap = new Dictionary<int, RealmBetweenAreaData>();

		// Token: 0x0402121D RID: 135709
		public Dictionary<int, global::ActivityTaskData> AreaTaskMap = new Dictionary<int, global::ActivityTaskData>();

		// Token: 0x0402121E RID: 135710
		[Nullable(2)]
		public FinalTravelTaskData TaskFinalRewardData;

		// Token: 0x0402121F RID: 135711
		public Dictionary<int, bool> PhantomDataMap = new Dictionary<int, bool>();

		// Token: 0x04021220 RID: 135712
		public Dictionary<int, global::ActivityTaskData> MotorChallengeRewardDataMap = new Dictionary<int, global::ActivityTaskData>();

		// Token: 0x04021221 RID: 135713
		public Dictionary<int, MotorChallengePlayData> MotorChallengePlayDataMap = new Dictionary<int, MotorChallengePlayData>();
	}
}
