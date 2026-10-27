using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotoLinkage
{
	// Token: 0x02006447 RID: 25671
	[NullableContext(1)]
	[Nullable(0)]
	public class ActivityMotorLinkageData : ActivityBaseData
	{
		// Token: 0x06040863 RID: 264291 RVA: 0x00F9E2A0 File Offset: 0x00F9C4A0
		protected override void PhraseEx(ActivityData data)
		{
			MotorCycleIpActivityData motorCycleIpActivityData = data.MotorCycleIpActivityData;
			if (motorCycleIpActivityData == null)
			{
				return;
			}
			for (int i = 0; i < motorCycleIpActivityData.ConditionTasks.Count; i++)
			{
				ConditionTask conditionTask = motorCycleIpActivityData.ConditionTasks[i];
				global::ActivityTaskData activityTaskData = new global::ActivityTaskData();
				activityTaskData.Id = conditionTask.Id;
				activityTaskData.Current = conditionTask.Current;
				activityTaskData.Target = conditionTask.Target;
				activityTaskData.Status = this.TaskServerStatus2ClientStatus(conditionTask.Status);
				this.ActivityQuestData[conditionTask.Id] = activityTaskData;
			}
		}

		// Token: 0x06040864 RID: 264292 RVA: 0x00F9E329 File Offset: 0x00F9C529
		public bool CanSubViewPlayShowView()
		{
			if (this.CanSubViewPlayShowViewInternal)
			{
				this.CanSubViewPlayShowViewInternal = false;
				return true;
			}
			return false;
		}

		// Token: 0x06040865 RID: 264293 RVA: 0x00F9E33D File Offset: 0x00F9C53D
		public void SetCanSubViewPlayShowView(bool value)
		{
			this.CanSubViewPlayShowViewInternal = value;
		}

		// Token: 0x06040866 RID: 264294 RVA: 0x00F9E348 File Offset: 0x00F9C548
		public List<int> GetSortedQuestList(int ipId)
		{
			IEnumerable<MotorLinkageQuest> questConfigListByIpId = ActivityMotorLinkageConfig.Instance.GetQuestConfigListByIpId(ipId);
			List<List<MotorLinkageQuest>> list = new List<List<MotorLinkageQuest>>
			{
				new List<MotorLinkageQuest>(),
				new List<MotorLinkageQuest>(),
				new List<MotorLinkageQuest>()
			};
			foreach (MotorLinkageQuest item in questConfigListByIpId)
			{
				if (this.IsQuestCanReceive(item.TaskId))
				{
					list[0].Add(item);
				}
				else if (this.IsQuestRewardReceived(item.TaskId))
				{
					list[2].Add(item);
				}
				else
				{
					list[1].Add(item);
				}
			}
			List<int> list2 = new List<int>();
			foreach (List<MotorLinkageQuest> list3 in list)
			{
				list3.Sort((MotorLinkageQuest a, MotorLinkageQuest b) => a.Sort - b.Sort);
				foreach (MotorLinkageQuest motorLinkageQuest in list3)
				{
					list2.Add(motorLinkageQuest.TaskId);
				}
			}
			return list2;
		}

		// Token: 0x06040867 RID: 264295 RVA: 0x00F9E4AC File Offset: 0x00F9C6AC
		public List<int> GetSortedIpList()
		{
			List<MotorLinkageIp> list = new List<MotorLinkageIp>(ActivityMotorLinkageConfig.Instance.GetIpConfigAll());
			list.Sort((MotorLinkageIp a, MotorLinkageIp b) => a.Sort - b.Sort);
			List<int> list2 = new List<int>();
			foreach (MotorLinkageIp motorLinkageIp in list)
			{
				list2.Add(motorLinkageIp.Id);
			}
			return list2;
		}

		// Token: 0x06040868 RID: 264296 RVA: 0x00F9E53C File Offset: 0x00F9C73C
		public bool IsStickerReceived(int stickerId)
		{
			return InventoryModel.Instance.GetItemCountByConfigId(stickerId, 0) > 0;
		}

		// Token: 0x06040869 RID: 264297 RVA: 0x00F9E550 File Offset: 0x00F9C750
		public int GetQuestCurrentProgress(int questId)
		{
			global::ActivityTaskData activityTaskData;
			if (!this.ActivityQuestData.TryGetValue(questId, out activityTaskData))
			{
				return 0;
			}
			return activityTaskData.Current;
		}

		// Token: 0x0604086A RID: 264298 RVA: 0x00F9E578 File Offset: 0x00F9C778
		public int GetQuestTargetProgress(int questId)
		{
			global::ActivityTaskData activityTaskData;
			if (!this.ActivityQuestData.TryGetValue(questId, out activityTaskData))
			{
				return 0;
			}
			return activityTaskData.Target;
		}

		// Token: 0x0604086B RID: 264299 RVA: 0x00F9E5A0 File Offset: 0x00F9C7A0
		public bool IsQuestCanReceive(int questId)
		{
			global::ActivityTaskData activityTaskData;
			return this.ActivityQuestData.TryGetValue(questId, out activityTaskData) && activityTaskData.Status == EActivityTaskState.FinishedAndUnclaimed;
		}

		// Token: 0x0604086C RID: 264300 RVA: 0x00F9E5C8 File Offset: 0x00F9C7C8
		public bool IsQuestRewardReceived(int questId)
		{
			global::ActivityTaskData activityTaskData;
			return this.ActivityQuestData.TryGetValue(questId, out activityTaskData) && activityTaskData.Status == EActivityTaskState.FinishedAndClaimed;
		}

		// Token: 0x0604086D RID: 264301 RVA: 0x00F9E5F0 File Offset: 0x00F9C7F0
		public void OnQuestUpdateNotify(MotorcycleTaskUpdateNotify notify)
		{
			ConditionTask task = notify.Task;
			int? num = (task != null) ? new int?(task.Id) : null;
			global::ActivityTaskData activityTaskData = null;
			if (num != null)
			{
				this.ActivityQuestData.TryGetValue(num.Value, out activityTaskData);
			}
			if (activityTaskData != null)
			{
				activityTaskData.Current = notify.Task.Current;
				activityTaskData.Target = notify.Task.Target;
				activityTaskData.Status = this.TaskServerStatus2ClientStatus(notify.Task.Status);
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
			}
		}

		// Token: 0x0604086E RID: 264302 RVA: 0x00F9E690 File Offset: 0x00F9C890
		public void OnRewardReceiveNotify(int[] questIpList)
		{
			foreach (int key in questIpList)
			{
				global::ActivityTaskData activityTaskData;
				if (this.ActivityQuestData.TryGetValue(key, out activityTaskData))
				{
					activityTaskData.Status = EActivityTaskState.FinishedAndClaimed;
				}
			}
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
		}

		// Token: 0x0604086F RID: 264303 RVA: 0x00F9E6E0 File Offset: 0x00F9C8E0
		public bool HasAnyRewardCanReceive()
		{
			foreach (MotorLinkageIp motorLinkageIp in ActivityMotorLinkageConfig.Instance.GetIpConfigAll())
			{
				if (this.IpHasAnyRewardCanReceive(motorLinkageIp.Id))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06040870 RID: 264304 RVA: 0x00F9E740 File Offset: 0x00F9C940
		public int GetAllIpTotalProgress()
		{
			int num = 0;
			foreach (MotorLinkageIp motorLinkageIp in ActivityMotorLinkageConfig.Instance.GetIpConfigAll())
			{
				num += this.GetIpTotalProgress(motorLinkageIp.Id);
			}
			return num;
		}

		// Token: 0x06040871 RID: 264305 RVA: 0x00F9E7A0 File Offset: 0x00F9C9A0
		public int GetAllIpCurrentProgress()
		{
			int num = 0;
			foreach (MotorLinkageIp motorLinkageIp in ActivityMotorLinkageConfig.Instance.GetIpConfigAll())
			{
				num += this.GetIpCurrentProgress(motorLinkageIp.Id);
			}
			return num;
		}

		// Token: 0x06040872 RID: 264306 RVA: 0x00F9E800 File Offset: 0x00F9CA00
		public bool IpHasAnyRewardCanReceive(int ipId)
		{
			foreach (MotorLinkageQuest motorLinkageQuest in ActivityMotorLinkageConfig.Instance.GetQuestConfigListByIpId(ipId))
			{
				if (this.IsQuestCanReceive(motorLinkageQuest.TaskId))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06040873 RID: 264307 RVA: 0x00F9E864 File Offset: 0x00F9CA64
		public int GetIpTotalProgress(int ipId)
		{
			return ActivityMotorLinkageConfig.Instance.GetQuestConfigListByIpId(ipId).Count;
		}

		// Token: 0x06040874 RID: 264308 RVA: 0x00F9E878 File Offset: 0x00F9CA78
		public int GetIpCurrentProgress(int ipId)
		{
			IEnumerable<MotorLinkageQuest> questConfigListByIpId = ActivityMotorLinkageConfig.Instance.GetQuestConfigListByIpId(ipId);
			int num = 0;
			foreach (MotorLinkageQuest motorLinkageQuest in questConfigListByIpId)
			{
				if (this.IsQuestRewardReceived(motorLinkageQuest.TaskId))
				{
					num++;
				}
			}
			return num;
		}

		// Token: 0x06040875 RID: 264309 RVA: 0x00F9E8DC File Offset: 0x00F9CADC
		public bool IsActivityCompleted()
		{
			IReadOnlyList<MotorLinkageQuest> questConfigAll = ActivityMotorLinkageConfig.Instance.GetQuestConfigAll();
			int num = 0;
			foreach (MotorLinkageQuest motorLinkageQuest in questConfigAll)
			{
				if (this.IsQuestRewardReceived(motorLinkageQuest.TaskId))
				{
					num++;
				}
			}
			return num >= questConfigAll.Count;
		}

		// Token: 0x06040876 RID: 264310 RVA: 0x00F9E94C File Offset: 0x00F9CB4C
		private EActivityTaskState TaskServerStatus2ClientStatus(ConditionTaskState serverStatus)
		{
			switch (serverStatus)
			{
			case ConditionTaskState.ConditionTaskRunning:
				return EActivityTaskState.Active;
			case ConditionTaskState.ConditionTaskFinish:
				return EActivityTaskState.FinishedAndUnclaimed;
			case ConditionTaskState.ConditionTaskTaken:
				return EActivityTaskState.FinishedAndClaimed;
			default:
				return EActivityTaskState.Active;
			}
		}

		// Token: 0x06040877 RID: 264311 RVA: 0x00F9E969 File Offset: 0x00F9CB69
		public void ReadRedDot()
		{
			ActivityModel.Instance.SaveActivityData(base.Id, 0, 0, 0, 1);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
		}

		// Token: 0x06040878 RID: 264312 RVA: 0x00F9E995 File Offset: 0x00F9CB95
		public bool HasSkipRedDot()
		{
			return base.IsUnLock() && ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 1, 0, 0) == 0;
		}

		// Token: 0x06040879 RID: 264313 RVA: 0x00F9E9B8 File Offset: 0x00F9CBB8
		public void ReadSkipRedDot()
		{
			ActivityModel.Instance.SaveActivityData(base.Id, 1, 0, 0, 1);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
		}

		// Token: 0x0604087A RID: 264314 RVA: 0x00F9E9E4 File Offset: 0x00F9CBE4
		public override bool GetExDataRedPointShowState()
		{
			return ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 0, 0, 0) == 0 || this.HasSkipRedDot() || (!this.IsActivityCompleted() && this.HasAnyRewardCanReceive());
		}

		// Token: 0x0604087B RID: 264315 RVA: 0x00F9EA1D File Offset: 0x00F9CC1D
		protected override bool GetExDataFinishShowState()
		{
			return this.IsActivityCompleted();
		}

		// Token: 0x040218D9 RID: 137433
		private readonly Dictionary<int, global::ActivityTaskData> ActivityQuestData = new Dictionary<int, global::ActivityTaskData>();

		// Token: 0x040218DA RID: 137434
		private bool CanSubViewPlayShowViewInternal;
	}
}
