using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using Google.Protobuf.Collections;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MultiMotor
{
	// Token: 0x02006390 RID: 25488
	[NullableContext(1)]
	[Nullable(0)]
	public class MultiMotorData : ActivityBaseData
	{
		// Token: 0x060401A7 RID: 262567 RVA: 0x00F839E4 File Offset: 0x00F81BE4
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

		// Token: 0x060401A8 RID: 262568 RVA: 0x00F83A78 File Offset: 0x00F81C78
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

		// Token: 0x060401A9 RID: 262569 RVA: 0x00F83BE8 File Offset: 0x00F81DE8
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

		// Token: 0x060401AA RID: 262570 RVA: 0x00F83D5C File Offset: 0x00F81F5C
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

		// Token: 0x060401AB RID: 262571 RVA: 0x00F83E10 File Offset: 0x00F82010
		public void InitLevelRankData()
		{
			this.LevelBattleRankMap.Clear();
			foreach (OnlineTeamData onlineTeamData in OnlineModel.Instance.GetTeamList())
			{
				this.LevelBattleRankMap[onlineTeamData.PlayerId] = 0;
			}
		}

		// Token: 0x060401AC RID: 262572 RVA: 0x00F83E80 File Offset: 0x00F82080
		public List<MultiMotorLevelData> GetLevelDataList()
		{
			return new List<MultiMotorLevelData>(this.LevelDataMap.Values);
		}

		// Token: 0x17009355 RID: 37717
		// (get) Token: 0x060401AD RID: 262573 RVA: 0x00F83E92 File Offset: 0x00F82092
		public int TotalLevelCount
		{
			get
			{
				return this.LevelDataMap.Count;
			}
		}

		// Token: 0x17009356 RID: 37718
		// (get) Token: 0x060401AE RID: 262574 RVA: 0x00F83EA0 File Offset: 0x00F820A0
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

		// Token: 0x060401AF RID: 262575 RVA: 0x00F83F04 File Offset: 0x00F82104
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

		// Token: 0x17009357 RID: 37719
		// (get) Token: 0x060401B0 RID: 262576 RVA: 0x00F83F74 File Offset: 0x00F82174
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

		// Token: 0x17009358 RID: 37720
		// (get) Token: 0x060401B1 RID: 262577 RVA: 0x00F83FD0 File Offset: 0x00F821D0
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

		// Token: 0x17009359 RID: 37721
		// (get) Token: 0x060401B2 RID: 262578 RVA: 0x00F84038 File Offset: 0x00F82238
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

		// Token: 0x060401B3 RID: 262579 RVA: 0x00F8409C File Offset: 0x00F8229C
		public override bool GetExDataRedPointShowState()
		{
			return this.HasAnyRewardRedDot;
		}

		// Token: 0x060401B4 RID: 262580 RVA: 0x00F840A4 File Offset: 0x00F822A4
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

		// Token: 0x04021656 RID: 136790
		public readonly Dictionary<int, MultiMotorLevelData> LevelDataMap = new Dictionary<int, MultiMotorLevelData>();

		// Token: 0x04021657 RID: 136791
		public readonly Dictionary<int, int> LevelBattleRankMap = new Dictionary<int, int>();

		// Token: 0x04021658 RID: 136792
		public readonly Dictionary<int, MultiMotorTaskData> TaskDataMap = new Dictionary<int, MultiMotorTaskData>();
	}
}
