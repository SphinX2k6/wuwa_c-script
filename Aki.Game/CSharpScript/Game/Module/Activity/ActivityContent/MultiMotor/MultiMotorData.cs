using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using Google.Protobuf.Collections;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MultiMotor
{
	// Token: 0x0200530E RID: 21262
	[NullableContext(1)]
	[Nullable(0)]
	public class MultiMotorData : ActivityBaseData
	{
		// Token: 0x06034E68 RID: 216680 RVA: 0x00ECA958 File Offset: 0x00EC8B58
		protected override void PhraseEx(ActivityData data)
		{
			OnlineMotorActivityData onlineMotorActivityData = data.OnlineMotorActivityData;
			RepeatedField<OnlineMotorLevelInfo> levelInfoList = ((onlineMotorActivityData != null) ? onlineMotorActivityData.OnlineMotorLevelInfos : null) ?? new RepeatedField<OnlineMotorLevelInfo>();
			this.InitLevelData(levelInfoList);
			RepeatedField<OnlineMotorLevelUnLockTime> unlockTimes = ((onlineMotorActivityData != null) ? onlineMotorActivityData.UnLocks : null) ?? new RepeatedField<OnlineMotorLevelUnLockTime>();
			this.InitLevelUnlockTime(unlockTimes);
			RepeatedField<OnlineMotorTask> levelTaskList = ((onlineMotorActivityData != null) ? onlineMotorActivityData.LevelTasks : null) ?? new RepeatedField<OnlineMotorTask>();
			RepeatedField<OnlineMotorTask> globalTaskList = ((onlineMotorActivityData != null) ? onlineMotorActivityData.GlobalTasks : null) ?? new RepeatedField<OnlineMotorTask>();
			this.InitTaskData(levelTaskList, globalTaskList);
			MultiMotorController instance = MultiMotorController.Instance;
			if (instance == null)
			{
				return;
			}
			instance.OnMultiMotorDataInit();
		}

		// Token: 0x06034E69 RID: 216681 RVA: 0x00ECA9EC File Offset: 0x00EC8BEC
		private void InitLevelData(IEnumerable<OnlineMotorLevelInfo> levelInfoList)
		{
			Dictionary<int, OnlineMotorLevelInfo> dictionary = new Dictionary<int, OnlineMotorLevelInfo>();
			foreach (OnlineMotorLevelInfo onlineMotorLevelInfo in levelInfoList)
			{
				dictionary[onlineMotorLevelInfo.LevelId] = onlineMotorLevelInfo;
			}
			IReadOnlyList<OnlineMotorLevel> allMotorMultiParkourLevel = MultiMotorConfig.Instance.GetAllMotorMultiParkourLevel();
			foreach (OnlineMotorLevel onlineMotorLevel in (allMotorMultiParkourLevel ?? new List<OnlineMotorLevel>()))
			{
				MultiMotorLevelData multiMotorLevelData = new MultiMotorLevelData(onlineMotorLevel.Id);
				OnlineMotorLevelInfo levelInfo;
				if (dictionary.TryGetValue(onlineMotorLevel.Id, out levelInfo))
				{
					multiMotorLevelData.RefreshByLevelInfo(levelInfo);
				}
				this.LevelDataMap[onlineMotorLevel.Id] = multiMotorLevelData;
			}
			foreach (KeyValuePair<int, MultiMotorLevelData> keyValuePair in this.LevelDataMap)
			{
				MultiMotorLevelData value = keyValuePair.Value;
				OnlineMotorLevel? motorMultiParkourLevelById = MultiMotorConfig.Instance.GetMotorMultiParkourLevelById(value.LevelId);
				if (motorMultiParkourLevelById != null && motorMultiParkourLevelById.Value.PreLevel != 0)
				{
					this.LevelDataMap.TryGetValue(motorMultiParkourLevelById.Value.PreLevel, out value.PreMultiMotorParkourLevelData);
				}
			}
		}

		// Token: 0x06034E6A RID: 216682 RVA: 0x00ECAB5C File Offset: 0x00EC8D5C
		private void InitTaskData(IEnumerable<OnlineMotorTask> levelTaskList, IEnumerable<OnlineMotorTask> globalTaskList)
		{
			foreach (OnlineMotorTask onlineMotorTask in levelTaskList)
			{
				MultiMotorTaskData multiMotorTaskData = new MultiMotorTaskData(onlineMotorTask.TaskId);
				OnlineMotorLevelTask? motorLevelTaskByTaskId = MultiMotorConfig.Instance.GetMotorLevelTaskByTaskId(onlineMotorTask.TaskId);
				multiMotorTaskData.LevelId = ((motorLevelTaskByTaskId != null) ? motorLevelTaskByTaskId.GetValueOrDefault().LevelId : 0);
				multiMotorTaskData.RefreshByTaskInfo(onlineMotorTask);
				this.TaskDataMap[onlineMotorTask.TaskId] = multiMotorTaskData;
			}
			foreach (OnlineMotorTask onlineMotorTask2 in globalTaskList)
			{
				MultiMotorTaskData multiMotorTaskData2 = new MultiMotorTaskData(onlineMotorTask2.TaskId);
				multiMotorTaskData2.LevelId = -1;
				multiMotorTaskData2.RefreshByTaskInfo(onlineMotorTask2);
				this.TaskDataMap[-onlineMotorTask2.TaskId] = multiMotorTaskData2;
			}
			foreach (KeyValuePair<int, MultiMotorTaskData> keyValuePair in this.TaskDataMap)
			{
				MultiMotorTaskData value = keyValuePair.Value;
				MultiMotorLevelData multiMotorLevelData;
				if (!value.IsGlobalTask && this.LevelDataMap.TryGetValue(value.LevelId, out multiMotorLevelData))
				{
					multiMotorLevelData.TaskList.Add(value);
				}
			}
		}

		// Token: 0x06034E6B RID: 216683 RVA: 0x00ECACD0 File Offset: 0x00EC8ED0
		private void InitLevelUnlockTime(IEnumerable<OnlineMotorLevelUnLockTime> unlockTimes)
		{
			Dictionary<int, long> dictionary = new Dictionary<int, long>();
			foreach (OnlineMotorLevelUnLockTime onlineMotorLevelUnLockTime in unlockTimes)
			{
				dictionary[onlineMotorLevelUnLockTime.LevelId] = onlineMotorLevelUnLockTime.UnLockTime;
			}
			foreach (KeyValuePair<int, MultiMotorLevelData> keyValuePair in this.LevelDataMap)
			{
				long unlockTime;
				if (dictionary.TryGetValue(keyValuePair.Key, out unlockTime))
				{
					keyValuePair.Value.UnlockTime = unlockTime;
				}
			}
		}

		// Token: 0x06034E6C RID: 216684 RVA: 0x00ECAD84 File Offset: 0x00EC8F84
		public void InitLevelRankData()
		{
			this.LevelBattleRankMap.Clear();
			foreach (OnlineTeamData onlineTeamData in OnlineModel.Instance.GetTeamList())
			{
				this.LevelBattleRankMap[onlineTeamData.PlayerId] = 0;
			}
		}

		// Token: 0x06034E6D RID: 216685 RVA: 0x00ECADF4 File Offset: 0x00EC8FF4
		public List<MultiMotorLevelData> GetLevelDataList()
		{
			return new List<MultiMotorLevelData>(this.LevelDataMap.Values);
		}

		// Token: 0x170066B7 RID: 26295
		// (get) Token: 0x06034E6E RID: 216686 RVA: 0x00ECAE06 File Offset: 0x00EC9006
		public int TotalLevelCount
		{
			get
			{
				return this.LevelDataMap.Count;
			}
		}

		// Token: 0x170066B8 RID: 26296
		// (get) Token: 0x06034E6F RID: 216687 RVA: 0x00ECAE14 File Offset: 0x00EC9014
		public int FinishedLevelCount
		{
			get
			{
				int num = 0;
				foreach (KeyValuePair<int, MultiMotorLevelData> keyValuePair in this.LevelDataMap)
				{
					if (keyValuePair.Value.IsPass)
					{
						num++;
					}
				}
				return num;
			}
		}

		// Token: 0x06034E70 RID: 216688 RVA: 0x00ECAE78 File Offset: 0x00EC9078
		public List<MultiMotorTaskData> GetGlobalTaskList()
		{
			List<MultiMotorTaskData> list = new List<MultiMotorTaskData>();
			foreach (KeyValuePair<int, MultiMotorTaskData> keyValuePair in this.TaskDataMap)
			{
				if (keyValuePair.Value.IsGlobalTask)
				{
					list.Add(keyValuePair.Value);
				}
			}
			return list;
		}

		// Token: 0x170066B9 RID: 26297
		// (get) Token: 0x06034E71 RID: 216689 RVA: 0x00ECAEE8 File Offset: 0x00EC90E8
		public bool HasGlobalRewardRedDot
		{
			get
			{
				using (List<MultiMotorTaskData>.Enumerator enumerator = this.GetGlobalTaskList().GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (enumerator.Current.IsFinished)
						{
							return true;
						}
					}
				}
				return false;
			}
		}

		// Token: 0x170066BA RID: 26298
		// (get) Token: 0x06034E72 RID: 216690 RVA: 0x00ECAF44 File Offset: 0x00EC9144
		public bool HasAnyRewardRedDot
		{
			get
			{
				foreach (KeyValuePair<int, MultiMotorLevelData> keyValuePair in this.LevelDataMap)
				{
					if (keyValuePair.Value.HasRewardRedDot)
					{
						return true;
					}
				}
				return this.HasGlobalRewardRedDot;
			}
		}

		// Token: 0x170066BB RID: 26299
		// (get) Token: 0x06034E73 RID: 216691 RVA: 0x00ECAFAC File Offset: 0x00EC91AC
		public bool HasAnyLevelRedDot
		{
			get
			{
				foreach (KeyValuePair<int, MultiMotorLevelData> keyValuePair in this.LevelDataMap)
				{
					if (keyValuePair.Value.HasLevelRedDot)
					{
						return true;
					}
				}
				return false;
			}
		}

		// Token: 0x06034E74 RID: 216692 RVA: 0x00ECB010 File Offset: 0x00EC9210
		public override bool GetExDataRedPointShowState()
		{
			return this.HasAnyRewardRedDot;
		}

		// Token: 0x06034E75 RID: 216693 RVA: 0x00ECB018 File Offset: 0x00EC9218
		protected override bool GetExDataFinishShowState()
		{
			if (this.TaskDataMap.Count == 0)
			{
				return false;
			}
			foreach (KeyValuePair<int, MultiMotorTaskData> keyValuePair in this.TaskDataMap)
			{
				if (!keyValuePair.Value.IsReceived)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0401BF85 RID: 114565
		public readonly Dictionary<int, MultiMotorLevelData> LevelDataMap = new Dictionary<int, MultiMotorLevelData>();

		// Token: 0x0401BF86 RID: 114566
		public readonly Dictionary<int, int> LevelBattleRankMap = new Dictionary<int, int>();

		// Token: 0x0401BF87 RID: 114567
		public readonly Dictionary<int, MultiMotorTaskData> TaskDataMap = new Dictionary<int, MultiMotorTaskData>();
	}
}
