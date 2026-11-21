using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.ActivityCondition;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x0200597C RID: 22908
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolQuestCenter : Singleton
	{
		// Token: 0x17006C10 RID: 27664
		// (get) Token: 0x0603874F RID: 231247 RVA: 0x00FC9FC3 File Offset: 0x00FC81C3
		private static SolarSchoolQuestData QuestData
		{
			get
			{
				return SolarSchoolGamePlayModel.Instance.QuestData;
			}
		}

		// Token: 0x06038750 RID: 231248 RVA: 0x00FC9FCF File Offset: 0x00FC81CF
		public void InitQuest(int activityId)
		{
			this.UnwatchActivationConditions();
			this.ActivityId = activityId;
			SolarSchoolQuestCenter.QuestData.RefreshAllState();
			this.CheckQuestActivation(SolarSchoolGamePlayModel.Instance.TimeData.DayIndex);
			this.WatchActivationConditions();
			SolarSchoolQuestCenter.QuestData.ResetInfoPresentation();
		}

		// Token: 0x06038751 RID: 231249 RVA: 0x00FCA010 File Offset: 0x00FC8210
		public void EndQuest()
		{
			foreach (SolarSchoolSingleQuestData solarSchoolSingleQuestData in SolarSchoolQuestCenter.QuestData.GetQuestDataList())
			{
				solarSchoolSingleQuestData.StopNodeListeners();
				solarSchoolSingleQuestData.StopRewardListeners();
			}
			this.UnwatchActivationConditions();
			this.ActivityId = 0;
		}

		// Token: 0x06038752 RID: 231250 RVA: 0x00FCA074 File Offset: 0x00FC8274
		public unsafe void RestoreFromSave(int activityId)
		{
			this.UnwatchActivationConditions();
			this.ActivityId = activityId;
			SolarSchoolQuestCenter.QuestData.RefreshAllState();
			this.CheckQuestActivation(SolarSchoolGamePlayModel.Instance.TimeData.DayIndex);
			int num = 0;
			int num2 = 0;
			foreach (SolarSchoolSingleQuestData solarSchoolSingleQuestData in SolarSchoolQuestCenter.QuestData.GetQuestDataList())
			{
				if (SolarSchoolQuestCenter.QuestData.IsQuestActive(solarSchoolSingleQuestData.QuestId))
				{
					num += solarSchoolSingleQuestData.RebuildNodeListeners();
					num2 += solarSchoolSingleQuestData.RebuildRewardListeners();
				}
			}
			this.WatchActivationConditions();
			SolarSchoolQuestCenter.QuestData.ResetInfoPresentation();
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SolarSchool;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "[SolarSchool] 读档重建 Quest 运行态";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("activityId", activityId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("补注册节点数", num);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("补注册奖励数", num2);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("存档读入pending数", SolarSchoolQuestCenter.QuestData.GetPendingNodes().Count);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
		}

		// Token: 0x06038753 RID: 231251 RVA: 0x00FCA1D0 File Offset: 0x00FC83D0
		public void OnDayStart(int dayIndex)
		{
			SolarSchoolQuestCenter.QuestData.RefreshAllState();
			this.CheckQuestActivation(dayIndex);
			this.WatchActivationConditions();
		}

		// Token: 0x06038754 RID: 231252 RVA: 0x00FCA1EC File Offset: 0x00FC83EC
		private void WatchActivationConditions()
		{
			this.UnwatchActivationConditions();
			this.ListeningTimeChanges = EventSystem.Instance.Add(EEventName.SolarSchoolTimeChanged, new Action(this.OnTimeChanged));
			HashSet<int> hashSet = new HashSet<int>();
			int dayIndex = SolarSchoolGamePlayModel.Instance.TimeData.DayIndex;
			foreach (SolarSchoolQuest quest in SolarSchoolConfig.Instance.GetQuestListByActivityId(this.ActivityId))
			{
				if (!SolarSchoolQuestCenter.QuestData.IsQuestActive(quest.Id) && !this.IsClosedByDate(quest, dayIndex) && quest.PreConditionGroupId != 0)
				{
					hashSet.Add(quest.PreConditionGroupId);
				}
			}
			foreach (int num in hashSet)
			{
				long num2 = ActivityConditionCenter.Instance.RegisterGroup(num, new Action(this.OnActivationConditionReached));
				if (num2 == 0L)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.SolarSchool;
					ELogAuthor author = ELogAuthor.BB;
					string message = "[SolarSchool] Quest 激活条件监听注册失败";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("conditionId", num);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				else
				{
					this.ActivationConditionHandles.Add(num2);
				}
			}
		}

		// Token: 0x06038755 RID: 231253 RVA: 0x00FCA344 File Offset: 0x00FC8544
		private void UnwatchActivationConditions()
		{
			if (this.ListeningTimeChanges)
			{
				EventSystem.Instance.Remove(EEventName.SolarSchoolTimeChanged, new Action(this.OnTimeChanged));
				this.ListeningTimeChanges = false;
			}
			long[] array = this.ActivationConditionHandles.ToArray();
			this.ActivationConditionHandles.Clear();
			foreach (long uniqueId in array)
			{
				ActivityConditionCenter.Instance.Unregister(uniqueId);
			}
		}

		// Token: 0x06038756 RID: 231254 RVA: 0x00FCA3B0 File Offset: 0x00FC85B0
		private void OnTimeChanged()
		{
			if (this.ActivityId == 0)
			{
				return;
			}
			this.TryDeliverPending();
		}

		// Token: 0x06038757 RID: 231255 RVA: 0x00FCA3C1 File Offset: 0x00FC85C1
		private void OnActivationConditionReached()
		{
			if (this.ActivityId == 0)
			{
				return;
			}
			this.CheckQuestActivation(SolarSchoolGamePlayModel.Instance.TimeData.DayIndex);
		}

		// Token: 0x06038758 RID: 231256 RVA: 0x00FCA3E4 File Offset: 0x00FC85E4
		private void CheckQuestActivation(int dayIndex)
		{
			if (this.CheckingActivation)
			{
				return;
			}
			this.CheckingActivation = true;
			try
			{
				for (int i = 0; i < 32; i++)
				{
					bool flag = false;
					foreach (SolarSchoolQuest quest in SolarSchoolConfig.Instance.GetQuestListByActivityId(this.ActivityId))
					{
						bool flag2 = this.ShouldActivate(quest, dayIndex);
						bool flag3 = SolarSchoolQuestCenter.QuestData.IsQuestActive(quest.Id);
						if (flag2 && !flag3)
						{
							this.Activate(quest);
							flag = true;
						}
						else if (!flag2 && flag3)
						{
							this.Deactivate(quest);
							flag = true;
						}
					}
					if (!flag)
					{
						return;
					}
				}
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] Quest 激活检查超过最大轮数仍未收敛，检查任务激活条件是否互相依赖";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("dayIndex", dayIndex);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			finally
			{
				this.CheckingActivation = false;
			}
		}

		// Token: 0x06038759 RID: 231257 RVA: 0x00FCA4EC File Offset: 0x00FC86EC
		private bool ShouldActivate(SolarSchoolQuest quest, int dayIndex)
		{
			return !this.IsClosedByDate(quest, dayIndex) && (SolarSchoolQuestCenter.QuestData.IsQuestActive(quest.Id) || this.IsPreConditionMet(quest));
		}

		// Token: 0x0603875A RID: 231258 RVA: 0x00FCA516 File Offset: 0x00FC8716
		private bool IsClosedByDate(SolarSchoolQuest quest, int dayIndex)
		{
			return (quest.StartDayIndex > 0 && dayIndex < quest.StartDayIndex) || (quest.EndDayIndex > 0 && dayIndex > quest.EndDayIndex);
		}

		// Token: 0x0603875B RID: 231259 RVA: 0x00FCA544 File Offset: 0x00FC8744
		private bool IsPreConditionMet(SolarSchoolQuest quest)
		{
			return quest.PreConditionGroupId == 0 || ActivityConditionCenter.Instance.CheckGroup(quest.PreConditionGroupId);
		}

		// Token: 0x0603875C RID: 231260 RVA: 0x00FCA564 File Offset: 0x00FC8764
		private unsafe void Activate(SolarSchoolQuest quest)
		{
			SolarSchoolQuestCenter.QuestData.SetQuestActive(quest.Id, true);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SolarSchool;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "[SolarSchool] Quest 激活";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("questId", quest.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("name", quest.Name);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			if (quest.LogicNodeType == 1)
			{
				SolarSchoolGamePlayModel.Instance.LogReporter.ReportQuest(quest.Id, ESolarSchoolQuestLogResultType.Unlock);
			}
			SolarSchoolSingleQuestData questData = SolarSchoolQuestCenter.QuestData.GetQuestData(quest.Id);
			if (questData == null)
			{
				return;
			}
			questData.RebuildNodeListeners();
			questData.RebuildRewardListeners();
		}

		// Token: 0x0603875D RID: 231261 RVA: 0x00FCA630 File Offset: 0x00FC8830
		private unsafe void Deactivate(SolarSchoolQuest quest)
		{
			SolarSchoolQuestCenter.QuestData.SetQuestInactive(quest.Id);
			bool flag = !this.IsPreConditionMet(quest);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SolarSchool;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "[SolarSchool] Quest 关闭";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("questId", quest.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("resetProgress", flag);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			SolarSchoolSingleQuestData questData = SolarSchoolQuestCenter.QuestData.GetQuestData(quest.Id);
			if (questData == null)
			{
				return;
			}
			questData.StopNodeListeners();
			questData.StopRewardListeners();
			questData.ClearPendingNodes();
			if (flag)
			{
				questData.ResetAllNodeProgress();
				questData.ResetAllRewardProgress();
			}
		}

		// Token: 0x0603875E RID: 231262 RVA: 0x00FCA6F8 File Offset: 0x00FC88F8
		public void TryDeliverPending()
		{
			if (this.DeliveringPending)
			{
				return;
			}
			SolarSchoolGamePlayModel instance = SolarSchoolGamePlayModel.Instance;
			if (!instance.HasRunningTask || instance.IsInEndingStage || instance.GetCurrentStateType() == ESolarSchoolStageStateType.DayEnd)
			{
				return;
			}
			IReadOnlyList<int> pendingNodes = SolarSchoolQuestCenter.QuestData.GetPendingNodes();
			if (pendingNodes.Count == 0)
			{
				return;
			}
			this.DeliveringPending = true;
			try
			{
				this.DeliverPendingInternal(new List<int>(pendingNodes));
			}
			finally
			{
				this.DeliveringPending = false;
			}
		}

		// Token: 0x0603875F RID: 231263 RVA: 0x00FCA770 File Offset: 0x00FC8970
		private void DeliverPendingInternal(IReadOnlyList<int> pending)
		{
			List<SolarSchoolQuestNode> list = new List<SolarSchoolQuestNode>();
			foreach (int num in pending)
			{
				if (this.IsNodeDeliverable(num))
				{
					SolarSchoolQuestNode? questNode = SolarSchoolConfig.Instance.GetQuestNode(num);
					if (questNode != null && questNode.Value.TriggerTiming == 0 && this.CheckAvailable(questNode.Value))
					{
						list.Add(questNode.Value);
					}
				}
			}
			if (list.Count == 0)
			{
				return;
			}
			list.Sort((SolarSchoolQuestNode a, SolarSchoolQuestNode b) => b.Priority.CompareTo(a.Priority));
			foreach (SolarSchoolQuestNode node in list)
			{
				this.DeliverNode(node);
			}
		}

		// Token: 0x06038760 RID: 231264 RVA: 0x00FCA874 File Offset: 0x00FC8A74
		private bool IsNodeDeliverable(int nodeId)
		{
			SolarSchoolQuestNodeData nodeData = SolarSchoolQuestCenter.QuestData.GetNodeData(nodeId);
			return nodeData != null && !nodeData.IsActionRunning && SolarSchoolQuestCenter.QuestData.IsQuestActive(nodeData.QuestId);
		}

		// Token: 0x06038761 RID: 231265 RVA: 0x00FCA8AC File Offset: 0x00FC8AAC
		private unsafe bool DeliverNode(SolarSchoolQuestNode node)
		{
			SolarSchoolGamePlayModel instance = SolarSchoolGamePlayModel.Instance;
			SolarSchoolActionBase solarSchoolActionBase = instance.CreateAction(node.ActionId);
			if (solarSchoolActionBase == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] QuestNode 投递失败：ActionId 造不出 action，保持 pending";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("nodeId", node.Id);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("actionId", node.ActionId);
				instance2.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return false;
			}
			this.BindNodeFinishCallback(node.Id, solarSchoolActionBase);
			if (!instance.TryInjectActionToCurrentTask(solarSchoolActionBase))
			{
				Log instance3 = Log.Instance;
				ELogModule module2 = ELogModule.SolarSchool;
				ELogAuthor author2 = ELogAuthor.LRC;
				string message2 = "[SolarSchool] QuestNode 投递未成：当前无可注入 Task，保持 pending 待重投";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("nodeId", node.Id);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("actionId", node.ActionId);
				instance3.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
				return false;
			}
			SolarSchoolQuestNodeData nodeData = SolarSchoolQuestCenter.QuestData.GetNodeData(node.Id);
			if (nodeData != null)
			{
				nodeData.SetActionRunning(true);
			}
			Log instance4 = Log.Instance;
			ELogModule module3 = ELogModule.SolarSchool;
			ELogAuthor author3 = ELogAuthor.LRC;
			string message3 = "[SolarSchool] QuestNode 已投递";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("nodeId", node.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("actionId", node.ActionId);
			instance4.Info(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 2));
			return true;
		}

		// Token: 0x06038762 RID: 231266 RVA: 0x00FCAA50 File Offset: 0x00FC8C50
		private void BindNodeFinishCallback(int nodeId, SolarSchoolActionBase action)
		{
			action.SetFinishCallback(delegate
			{
				this.OnNodeActionFinished(nodeId);
			}, delegate
			{
				this.OnNodeActionAborted(nodeId);
			});
		}

		// Token: 0x06038763 RID: 231267 RVA: 0x00FCAA90 File Offset: 0x00FC8C90
		public unsafe void OnNodeActionFinished(int nodeId)
		{
			if (this.ActivityId == 0)
			{
				return;
			}
			SolarSchoolQuestNode? questNode = SolarSchoolConfig.Instance.GetQuestNode(nodeId);
			if (questNode == null)
			{
				return;
			}
			SolarSchoolQuestNode value = questNode.Value;
			SolarSchoolQuestCenter.QuestData.RemovePendingNode(nodeId);
			SolarSchoolQuestNodeData nodeData = SolarSchoolQuestCenter.QuestData.GetNodeData(nodeId);
			if (nodeData != null)
			{
				nodeData.SetActionRunning(false);
			}
			if (nodeData != null)
			{
				nodeData.MarkCompleted();
			}
			if (value.TriggerTiming == 1)
			{
				SolarSchoolQuestCenter.QuestData.MarkLocationTriggeredToday(value.TriggerParam);
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SolarSchool;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "[SolarSchool] QuestNode 内容执行完毕 → 标完成";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("nodeId", nodeId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("timing", (ESolarSchoolTriggerTiming)value.TriggerTiming);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("triggerParam", value.TriggerParam);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			SolarSchoolGamePlayModel.Instance.LogReporter.ReportQuestNode(nodeId);
			if (nodeData != null)
			{
				SolarSchoolSingleQuestData questData = SolarSchoolQuestCenter.QuestData.GetQuestData(nodeData.QuestId);
				if (questData == null)
				{
					return;
				}
				questData.StartNextNodeListeners(nodeId);
			}
		}

		// Token: 0x06038764 RID: 231268 RVA: 0x00FCABC0 File Offset: 0x00FC8DC0
		public void OnNodeActionAborted(int nodeId)
		{
			if (this.ActivityId == 0)
			{
				return;
			}
			SolarSchoolQuestNodeData nodeData = SolarSchoolQuestCenter.QuestData.GetNodeData(nodeId);
			if (nodeData == null || !nodeData.IsActionRunning)
			{
				return;
			}
			nodeData.SetActionRunning(false);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SolarSchool;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "[SolarSchool] QuestNode 内容未跑完被丢弃 → 退回待投递";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("nodeId", nodeId);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x06038765 RID: 231269 RVA: 0x00FCAC24 File Offset: 0x00FC8E24
		public bool HasPendingNode(ESolarSchoolTriggerTiming timing, int triggerParam)
		{
			SolarSchoolQuestNode solarSchoolQuestNode;
			return this.TryPickNode(timing, triggerParam, out solarSchoolQuestNode);
		}

		// Token: 0x06038766 RID: 231270 RVA: 0x00FCAC3C File Offset: 0x00FC8E3C
		[NullableContext(2)]
		public unsafe bool TryTakePendingNode(ESolarSchoolTriggerTiming timing, int triggerParam, out int nodeId, out SolarSchoolActionBase action)
		{
			nodeId = 0;
			action = null;
			SolarSchoolQuestNode solarSchoolQuestNode;
			if (!this.TryPickNode(timing, triggerParam, out solarSchoolQuestNode))
			{
				return false;
			}
			action = SolarSchoolGamePlayModel.Instance.CreateAction(solarSchoolQuestNode.ActionId);
			if (action == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] QuestNode ActionId 造不出 action";
				<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("nodeId", solarSchoolQuestNode.Id);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("actionId", solarSchoolQuestNode.ActionId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("timing", timing);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("triggerParam", triggerParam);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
				return false;
			}
			this.BindNodeFinishCallback(solarSchoolQuestNode.Id, action);
			nodeId = solarSchoolQuestNode.Id;
			SolarSchoolQuestNodeData nodeData = SolarSchoolQuestCenter.QuestData.GetNodeData(solarSchoolQuestNode.Id);
			if (nodeData != null)
			{
				nodeData.SetActionRunning(true);
			}
			return true;
		}

		// Token: 0x06038767 RID: 231271 RVA: 0x00FCAD5C File Offset: 0x00FC8F5C
		private bool TryPickNode(ESolarSchoolTriggerTiming timing, int triggerParam, out SolarSchoolQuestNode node)
		{
			node = default(SolarSchoolQuestNode);
			if (triggerParam == 0)
			{
				return false;
			}
			if (timing == ESolarSchoolTriggerTiming.AtLocationAffinity && SolarSchoolQuestCenter.QuestData.IsLocationTriggeredToday(triggerParam))
			{
				return false;
			}
			foreach (int num in SolarSchoolQuestCenter.QuestData.GetPendingNodes())
			{
				if (this.IsNodeDeliverable(num))
				{
					SolarSchoolQuestNode? questNode = SolarSchoolConfig.Instance.GetQuestNode(num);
					if (questNode != null && questNode.Value.TriggerTiming == (int)timing && questNode.Value.TriggerParam == triggerParam && this.CheckAvailable(questNode.Value))
					{
						node = questNode.Value;
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06038768 RID: 231272 RVA: 0x00FCAE2C File Offset: 0x00FC902C
		private bool CheckAvailable(SolarSchoolQuestNode node)
		{
			int availableConditionGroupId = node.AvailableConditionGroupId;
			return availableConditionGroupId == 0 || ActivityConditionCenter.Instance.CheckGroup(availableConditionGroupId);
		}

		// Token: 0x17006C11 RID: 27665
		// (get) Token: 0x06038769 RID: 231273 RVA: 0x00FCAE51 File Offset: 0x00FC9051
		public static SolarSchoolQuestCenter Instance
		{
			get
			{
				if (SolarSchoolQuestCenter._instance == null)
				{
					SolarSchoolQuestCenter._instance = new SolarSchoolQuestCenter();
					SolarSchoolQuestCenter._instance.OnInit();
				}
				return SolarSchoolQuestCenter._instance;
			}
		}

		// Token: 0x0603876A RID: 231274 RVA: 0x00FCAE74 File Offset: 0x00FC9074
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603876B RID: 231275 RVA: 0x00FCAE76 File Offset: 0x00FC9076
		public static void ResetStaticDefaultValue()
		{
			SolarSchoolQuestCenter instance = SolarSchoolQuestCenter._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			SolarSchoolQuestCenter._instance = null;
		}

		// Token: 0x0603876C RID: 231276 RVA: 0x00FCAE8F File Offset: 0x00FC908F
		static SolarSchoolQuestCenter()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SolarSchoolQuestCenter.CreateStaticDefaultValue), new Action(SolarSchoolQuestCenter.ResetStaticDefaultValue));
		}

		// Token: 0x0401DC33 RID: 121907
		private const int MaxActivationRounds = 32;

		// Token: 0x0401DC34 RID: 121908
		private readonly List<long> ActivationConditionHandles = new List<long>();

		// Token: 0x0401DC35 RID: 121909
		private bool CheckingActivation;

		// Token: 0x0401DC36 RID: 121910
		private bool DeliveringPending;

		// Token: 0x0401DC37 RID: 121911
		private bool ListeningTimeChanges;

		// Token: 0x0401DC38 RID: 121912
		private int ActivityId;

		// Token: 0x0401DC39 RID: 121913
		[Nullable(2)]
		private static SolarSchoolQuestCenter _instance;
	}
}
