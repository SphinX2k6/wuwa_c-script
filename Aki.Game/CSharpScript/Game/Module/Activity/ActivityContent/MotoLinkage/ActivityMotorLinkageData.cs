using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotoLinkage
{
	// Token: 0x020053C5 RID: 21445
	[NullableContext(1)]
	[Nullable(0)]
	public class ActivityMotorLinkageData : ActivityBaseData
	{
		// Token: 0x06035524 RID: 218404 RVA: 0x00EE521C File Offset: 0x00EE341C
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

		// Token: 0x06035525 RID: 218405 RVA: 0x00EE52A5 File Offset: 0x00EE34A5
		public bool CanSubViewPlayShowView()
		{
			if (this.CanSubViewPlayShowViewInternal)
			{
				this.CanSubViewPlayShowViewInternal = false;
				return true;
			}
			return false;
		}

		// Token: 0x06035526 RID: 218406 RVA: 0x00EE52B9 File Offset: 0x00EE34B9
		public void SetCanSubViewPlayShowView(bool value)
		{
			this.CanSubViewPlayShowViewInternal = value;
		}

		// Token: 0x06035527 RID: 218407 RVA: 0x00EE52C4 File Offset: 0x00EE34C4
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

		// Token: 0x06035528 RID: 218408 RVA: 0x00EE5428 File Offset: 0x00EE3628
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

		// Token: 0x06035529 RID: 218409 RVA: 0x00EE54B8 File Offset: 0x00EE36B8
		public bool IsStickerReceived(int stickerId)
		{
			return InventoryModel.Instance.GetItemCountByConfigId(stickerId, 0) > 0;
		}

		// Token: 0x0603552A RID: 218410 RVA: 0x00EE54CC File Offset: 0x00EE36CC
		public int GetQuestCurrentProgress(int questId)
		{
			global::ActivityTaskData activityTaskData;
			if (!this.ActivityQuestData.TryGetValue(questId, out activityTaskData))
			{
				return 0;
			}
			return activityTaskData.Current;
		}

		// Token: 0x0603552B RID: 218411 RVA: 0x00EE54F4 File Offset: 0x00EE36F4
		public int GetQuestTargetProgress(int questId)
		{
			global::ActivityTaskData activityTaskData;
			if (!this.ActivityQuestData.TryGetValue(questId, out activityTaskData))
			{
				return 0;
			}
			return activityTaskData.Target;
		}

		// Token: 0x0603552C RID: 218412 RVA: 0x00EE551C File Offset: 0x00EE371C
		public bool IsQuestCanReceive(int questId)
		{
			global::ActivityTaskData activityTaskData;
			return this.ActivityQuestData.TryGetValue(questId, out activityTaskData) && activityTaskData.Status == EActivityTaskState.FinishedAndUnclaimed;
		}

		// Token: 0x0603552D RID: 218413 RVA: 0x00EE5544 File Offset: 0x00EE3744
		public bool IsQuestRewardReceived(int questId)
		{
			global::ActivityTaskData activityTaskData;
			return this.ActivityQuestData.TryGetValue(questId, out activityTaskData) && activityTaskData.Status == EActivityTaskState.FinishedAndClaimed;
		}

		// Token: 0x0603552E RID: 218414 RVA: 0x00EE556C File Offset: 0x00EE376C
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

		// Token: 0x0603552F RID: 218415 RVA: 0x00EE560C File Offset: 0x00EE380C
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

		// Token: 0x06035530 RID: 218416 RVA: 0x00EE565C File Offset: 0x00EE385C
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

		// Token: 0x06035531 RID: 218417 RVA: 0x00EE56BC File Offset: 0x00EE38BC
		public int GetAllIpTotalProgress()
		{
			int num = 0;
			foreach (MotorLinkageIp motorLinkageIp in ActivityMotorLinkageConfig.Instance.GetIpConfigAll())
			{
				num += this.GetIpTotalProgress(motorLinkageIp.Id);
			}
			return num;
		}

		// Token: 0x06035532 RID: 218418 RVA: 0x00EE571C File Offset: 0x00EE391C
		public int GetAllIpCurrentProgress()
		{
			int num = 0;
			foreach (MotorLinkageIp motorLinkageIp in ActivityMotorLinkageConfig.Instance.GetIpConfigAll())
			{
				num += this.GetIpCurrentProgress(motorLinkageIp.Id);
			}
			return num;
		}

		// Token: 0x06035533 RID: 218419 RVA: 0x00EE577C File Offset: 0x00EE397C
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

		// Token: 0x06035534 RID: 218420 RVA: 0x00EE57E0 File Offset: 0x00EE39E0
		public int GetIpTotalProgress(int ipId)
		{
			return ActivityMotorLinkageConfig.Instance.GetQuestConfigListByIpId(ipId).Count;
		}

		// Token: 0x06035535 RID: 218421 RVA: 0x00EE57F4 File Offset: 0x00EE39F4
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

		// Token: 0x06035536 RID: 218422 RVA: 0x00EE5858 File Offset: 0x00EE3A58
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

		// Token: 0x06035537 RID: 218423 RVA: 0x00EE58C8 File Offset: 0x00EE3AC8
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

		// Token: 0x06035538 RID: 218424 RVA: 0x00EE58E5 File Offset: 0x00EE3AE5
		public void ReadRedDot()
		{
			ActivityModel.Instance.SaveActivityData(base.Id, 0, 0, 0, 1);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
		}

		// Token: 0x06035539 RID: 218425 RVA: 0x00EE5911 File Offset: 0x00EE3B11
		public bool HasSkipRedDot()
		{
			return base.IsUnLock() && ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 1, 0, 0) == 0;
		}

		// Token: 0x0603553A RID: 218426 RVA: 0x00EE5934 File Offset: 0x00EE3B34
		public void ReadSkipRedDot()
		{
			ActivityModel.Instance.SaveActivityData(base.Id, 1, 0, 0, 1);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
		}

		// Token: 0x0603553B RID: 218427 RVA: 0x00EE5960 File Offset: 0x00EE3B60
		public override bool GetExDataRedPointShowState()
		{
			return ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 0, 0, 0) == 0 || this.HasSkipRedDot() || (!this.IsActivityCompleted() && this.HasAnyRewardCanReceive());
		}

		// Token: 0x0603553C RID: 218428 RVA: 0x00EE5999 File Offset: 0x00EE3B99
		protected override bool GetExDataFinishShowState()
		{
			return this.IsActivityCompleted();
		}

		// Token: 0x0401C208 RID: 115208
		private readonly Dictionary<int, global::ActivityTaskData> ActivityQuestData = new Dictionary<int, global::ActivityTaskData>();

		// Token: 0x0401C209 RID: 115209
		private bool CanSubViewPlayShowViewInternal;
	}
}
