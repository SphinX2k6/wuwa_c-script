using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using Google.Protobuf.Collections;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorDecalLink
{
	// Token: 0x02006434 RID: 25652
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorDecalLinkData : ActivityBaseData
	{
		// Token: 0x060407F1 RID: 264177 RVA: 0x00F9BED8 File Offset: 0x00F9A0D8
		public MotorDecalLinkData(int activityId)
		{
			foreach (MotorDecalIp motorDecalIp in MotorDecalLinkConfig.Instance.GetIpConfigListByActivityId(activityId))
			{
				foreach (MotorDecalQuest motorDecalQuest in MotorDecalLinkConfig.Instance.GetTaskConfigListByIpId(motorDecalIp.Id))
				{
					if (!this.ActivityQuestData.ContainsKey(motorDecalQuest.TaskId))
					{
						global::ActivityTaskData activityTaskData = new global::ActivityTaskData();
						activityTaskData.Id = motorDecalQuest.TaskId;
						this.ActivityQuestData[motorDecalQuest.TaskId] = activityTaskData;
					}
				}
			}
		}

		// Token: 0x060407F2 RID: 264178 RVA: 0x00F9BFBC File Offset: 0x00F9A1BC
		protected unsafe override void PhraseEx(ActivityData data)
		{
			this.MainViewModel.InitFromActivityDataIfNot(this);
			MotorDecalActivityData motorDecalActivityData = (data != null) ? data.MotorDecalActivityData : null;
			if (motorDecalActivityData == null)
			{
				MotorDecalLinkUtil.Debug("活动协议未推送活动信息", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			string message = "活动协议推送活动信息";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", base.Id);
			MotorDecalLinkUtil.Debug(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.HasFirstRead = (ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 1, 0, 0) == 1);
			RepeatedField<ConditionTask> conditionTasks = motorDecalActivityData.ConditionTasks;
			for (int i = 0; i < conditionTasks.Count; i++)
			{
				ConditionTask conditionTask = conditionTasks[i];
				global::ActivityTaskData activityTaskData;
				if (this.ActivityQuestData.TryGetValue(conditionTask.Id, out activityTaskData))
				{
					activityTaskData.Refresh(conditionTask, null);
					activityTaskData.Status = this.TaskServerStatus2ClientStatus(conditionTask.Status);
				}
			}
			this.MainViewModel.RefreshIpTaskStates(this.ActivityQuestData);
			this.MainViewModel.HasFirstRead = this.HasFirstRead;
			this.MainViewModel.HasRewardCanReceive = this.HasAnyRewardCanReceive();
			string message2 = "活动已读状态";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Id", base.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("HasFirstRead", this.HasFirstRead);
			MotorDecalLinkUtil.Debug(message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			EventSystem.Instance.Emit<int>(EEventName.ActivityViewRefreshCurrent, base.Id);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
		}

		// Token: 0x060407F3 RID: 264179 RVA: 0x00F9C158 File Offset: 0x00F9A358
		public void OnRewardReceiveByTaskIds(IReadOnlyList<int> taskIds)
		{
			string message = "领奖成功";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("taskIds", taskIds);
			MotorDecalLinkUtil.Debug(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			foreach (int key in taskIds)
			{
				global::ActivityTaskData activityTaskData;
				if (this.ActivityQuestData.TryGetValue(key, out activityTaskData))
				{
					activityTaskData.Status = EActivityTaskState.FinishedAndClaimed;
				}
			}
			this.MainViewModel.RefreshIpTaskStates(this.ActivityQuestData);
			this.MainViewModel.HasRewardCanReceive = this.HasAnyRewardCanReceive();
		}

		// Token: 0x060407F4 RID: 264180 RVA: 0x00F9C1F0 File Offset: 0x00F9A3F0
		public bool ContainsTaskId(int taskId)
		{
			return this.ActivityQuestData.ContainsKey(taskId);
		}

		// Token: 0x060407F5 RID: 264181 RVA: 0x00F9C200 File Offset: 0x00F9A400
		public unsafe void OnTaskUpdateNotify(MotorDecalUpdateNotify notify)
		{
			ConditionTask task = notify.Task;
			if (task == null)
			{
				return;
			}
			int id = task.Id;
			global::ActivityTaskData activityTaskData;
			if (!this.ActivityQuestData.TryGetValue(id, out activityTaskData))
			{
				return;
			}
			string message = "OnTaskUpdateNotify";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("taskId", id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("taskData", activityTaskData);
			MotorDecalLinkUtil.Debug(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			activityTaskData.Id = task.Id;
			activityTaskData.Current = task.Current;
			activityTaskData.Target = task.Target;
			activityTaskData.Status = this.TaskServerStatus2ClientStatus(task.Status);
			this.MainViewModel.RefreshIpTaskStates(this.ActivityQuestData);
			this.MainViewModel.HasRewardCanReceive = this.HasAnyRewardCanReceive();
		}

		// Token: 0x060407F6 RID: 264182 RVA: 0x00F9C2D7 File Offset: 0x00F9A4D7
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

		// Token: 0x060407F7 RID: 264183 RVA: 0x00F9C2F4 File Offset: 0x00F9A4F4
		public bool HasAnyRewardCanReceive()
		{
			foreach (KeyValuePair<int, global::ActivityTaskData> keyValuePair in this.ActivityQuestData)
			{
				if (keyValuePair.Value.Status == EActivityTaskState.FinishedAndUnclaimed)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060407F8 RID: 264184 RVA: 0x00F9C358 File Offset: 0x00F9A558
		public override bool GetExDataRedPointShowState()
		{
			return !this.GetExDataFinishShowState() && (this.HasAnyRewardCanReceive() || !this.HasFirstRead);
		}

		// Token: 0x060407F9 RID: 264185 RVA: 0x00F9C378 File Offset: 0x00F9A578
		protected override bool GetExDataFinishShowState()
		{
			foreach (KeyValuePair<int, global::ActivityTaskData> keyValuePair in this.ActivityQuestData)
			{
				if (keyValuePair.Value.Status != EActivityTaskState.FinishedAndClaimed)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060407FA RID: 264186 RVA: 0x00F9C3DC File Offset: 0x00F9A5DC
		public void SetHasFirstRead()
		{
			string message = "设置活动已读";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", base.Id);
			MotorDecalLinkUtil.Debug(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			ActivityModel.Instance.SaveActivityData(base.Id, 1, 0, 0, 1);
			this.HasFirstRead = true;
			this.MainViewModel.HasFirstRead = true;
		}

		// Token: 0x0402186D RID: 137325
		private readonly Dictionary<int, global::ActivityTaskData> ActivityQuestData = new Dictionary<int, global::ActivityTaskData>();

		// Token: 0x0402186E RID: 137326
		public readonly MotorDecalLinkMainViewModel MainViewModel = new MotorDecalLinkMainViewModel();

		// Token: 0x0402186F RID: 137327
		private bool HasFirstRead;
	}
}
