using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RecallQuest.Model;
using CSharpScript.Game.Ui;
using Google.Protobuf;

// Token: 0x02002637 RID: 9783
[NullableContext(2)]
[Nullable(0)]
[Controller(0)]
public class QuestTrackAssistant : ControllerAssistantBase
{
	// Token: 0x06014070 RID: 82032 RVA: 0x0050B403 File Offset: 0x00509603
	protected override void OnDestroy()
	{
	}

	// Token: 0x06014071 RID: 82033 RVA: 0x0050B405 File Offset: 0x00509605
	public override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.TraceQuestNotify, new Action<IMessage, Net.CallbackStatus>(this.OnTraceQuestNotify));
	}

	// Token: 0x06014072 RID: 82034 RVA: 0x0050B423 File Offset: 0x00509623
	public override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.TraceQuestNotify);
	}

	// Token: 0x06014073 RID: 82035 RVA: 0x0050B438 File Offset: 0x00509638
	public override void OnAddEvents()
	{
		EventSystem.Instance.Add<long, int, EBehaviorTreeSuspendType>(EEventName.GeneralLogicTreeSuspend, new Action<long, int, EBehaviorTreeSuspendType>(this.OnGeneralLogicTreeSuspend));
		EventSystem.Instance.Add<int, bool, int>(EEventName.TsNotifyQuestTrackState, new Action<int, bool, int>(this.OnTsNotifyQuestTrackState));
		InputDistributeController.Instance.BindAction("任务追踪", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
	}

	// Token: 0x06014074 RID: 82036 RVA: 0x0050B498 File Offset: 0x00509698
	public override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove<long, int, EBehaviorTreeSuspendType>(EEventName.GeneralLogicTreeSuspend, new Action<long, int, EBehaviorTreeSuspendType>(this.OnGeneralLogicTreeSuspend));
		EventSystem.Instance.Remove<int, bool, int>(EEventName.TsNotifyQuestTrackState, new Action<int, bool, int>(this.OnTsNotifyQuestTrackState));
		InputDistributeController.Instance.UnBindAction("任务追踪", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
	}

	// Token: 0x06014075 RID: 82037 RVA: 0x0050B4F8 File Offset: 0x005096F8
	private void OnTraceQuestNotify(IMessage msg, Net.CallbackStatus _)
	{
		TraceQuestNotify traceQuestNotify = (TraceQuestNotify)msg;
		if (traceQuestNotify.QuestId == 0)
		{
			return;
		}
		QuestNewModel.Instance.SetQuestTrackState(traceQuestNotify.QuestId, true, ESetTrackReason.None);
	}

	// Token: 0x06014076 RID: 82038 RVA: 0x0050B528 File Offset: 0x00509728
	[NullableContext(1)]
	private void OnInputAction(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification _)
	{
		if (actionType != InputDistributeDefine.EActionType.Release)
		{
			return;
		}
		global::Quest curTrackedQuest = QuestNewModel.Instance.GetCurTrackedQuest();
		BtType p = (curTrackedQuest != null && curTrackedQuest.Type == EQuest.Recall) ? BtType.Recall : BtType.Quest;
		EventSystem.Instance.Emit<BtType, long?>(EEventName.OnLogicTreeTrackUpdate, p, (curTrackedQuest != null) ? curTrackedQuest.TreeId : null);
	}

	// Token: 0x06014077 RID: 82039 RVA: 0x0050B57C File Offset: 0x0050977C
	public void RefreshCurTrackQuest()
	{
		global::Quest curTrackedQuest = QuestNewModel.Instance.GetCurTrackedQuest();
		QuestNewModel.Instance.RefreshResidentQuestMapMark();
		if (curTrackedQuest != null)
		{
			curTrackedQuest.SetTrack(false, ESetTrackReason.None);
		}
		if (curTrackedQuest != null)
		{
			curTrackedQuest.SetTrack(true, ESetTrackReason.None);
		}
		int curShowUpdateTipsQuest = QuestNewModel.Instance.CurShowUpdateTipsQuest;
		if (curShowUpdateTipsQuest != 0)
		{
			this.TryChangeTrackedQuest(curShowUpdateTipsQuest);
		}
	}

	// Token: 0x06014078 RID: 82040 RVA: 0x0050B5D0 File Offset: 0x005097D0
	public ESetTrackResult RequestTrackQuest(int questId, bool bTrack, ERequestTrackOperate operate, ESetTrackReason reason = ESetTrackReason.None, Action finishCallback = null)
	{
		QuestNewModel instance = QuestNewModel.Instance;
		if (bTrack)
		{
			global::Quest quest = instance.GetQuest(questId);
			if (quest == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module = ELogModule.Quest;
				ELogAuthor author = ELogAuthor.YSQ;
				string message = "QuestTrackAssistant.RequestTrackQuest:找不到任务";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("任务Id", questId);
				instance2.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				Action finishCallback2 = finishCallback;
				if (finishCallback2 != null)
				{
					finishCallback2();
				}
				return ESetTrackResult.QuestNotExist;
			}
			if (quest.IsSuspend())
			{
				ScrollingTipsController.Instance.ShowTipsById("QuestTrackOccupiedTip", Array.Empty<object>());
				Action finishCallback3 = finishCallback;
				if (finishCallback3 != null)
				{
					finishCallback3();
				}
				return ESetTrackResult.QuestIsSuspend;
			}
			if (instance.IsInFocusMode())
			{
				if (!instance.IsInFocusOnQuest(questId))
				{
					ScrollingTipsController.Instance.ShowTipsByTextId("FocusModeCanNotTrackOtherQuest", Array.Empty<object>());
					Action finishCallback4 = finishCallback;
					if (finishCallback4 != null)
					{
						finishCallback4();
					}
					return ESetTrackResult.FocusModeCanNotTrackOtherQuest;
				}
			}
			else if (!quest.CanShowTrackExpression())
			{
				Log instance3 = Log.Instance;
				ELogModule module2 = ELogModule.Quest;
				ELogAuthor author2 = ELogAuthor.YSQ;
				string message2 = "QuestTrackAssistant.RequestTrackQuest,任务不可显示追踪表现";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("questId", questId);
				instance3.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				Action finishCallback5 = finishCallback;
				if (finishCallback5 != null)
				{
					finishCallback5();
				}
				return ESetTrackResult.QuestNotCanShowTrackExpression;
			}
		}
		QuestNewModel.Instance.SetQuestTrackState(questId, bTrack, reason);
		if (!RecallQuestModel.Instance.IsInRecallInstance())
		{
			TraceQuestRequest traceQuestRequest = TraceQuestRequest.Create();
			traceQuestRequest.QuestId = questId;
			traceQuestRequest.TraceType = (bTrack ? 1 : 2);
			traceQuestRequest.Operate = (int)operate;
			Net.Instance.Call(ERequestMessageId.TraceQuestRequest, traceQuestRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				TraceQuestResponse traceQuestResponse = (TraceQuestResponse)msg;
				if (traceQuestResponse != null && traceQuestResponse.ErrorId != ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(traceQuestResponse.ErrorId, 29698, null, true, true);
				}
				Action finishCallback6 = finishCallback;
				if (finishCallback6 == null)
				{
					return;
				}
				finishCallback6();
			}, 0);
			return ESetTrackResult.Success;
		}
		global::Quest quest2 = QuestNewModel.Instance.GetQuest(questId);
		if (quest2 == null || quest2.Type != EQuest.Recall)
		{
			return ESetTrackResult.Success;
		}
		TraceRecallQuestRequest traceRecallQuestRequest = TraceRecallQuestRequest.Create();
		traceRecallQuestRequest.RecallQuestId = questId;
		traceRecallQuestRequest.TraceType = (bTrack ? 1 : 2);
		traceRecallQuestRequest.Operate = (int)operate;
		Net.Instance.Call(ERequestMessageId.TraceRecallQuestRequest, traceRecallQuestRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			TraceRecallQuestResponse traceRecallQuestResponse = (TraceRecallQuestResponse)msg;
			if (traceRecallQuestResponse != null && traceRecallQuestResponse.ErrorId != ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(traceRecallQuestResponse.ErrorId, 27297, null, true, true);
				Action finishCallback6 = finishCallback;
				if (finishCallback6 == null)
				{
					return;
				}
				finishCallback6();
			}
		}, 0);
		return ESetTrackResult.Success;
	}

	// Token: 0x06014079 RID: 82041 RVA: 0x0050B7B4 File Offset: 0x005099B4
	public bool TryChangeTrackedQuest(int newQuestId)
	{
		QuestNewModel instance = QuestNewModel.Instance;
		if (instance.IsInFocusMode())
		{
			Log instance2 = Log.Instance;
			ELogModule module = ELogModule.Quest;
			ELogAuthor author = ELogAuthor.YSQ;
			string message = "QuestTrackAssistant.专注模式下不允许切换任务追踪";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("newQuestId", newQuestId);
			instance2.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		global::Quest quest = instance.GetQuest(newQuestId);
		if (quest == null || !quest.IsProgressing)
		{
			return false;
		}
		global::Quest curTrackedQuest = instance.GetCurTrackedQuest();
		if (curTrackedQuest != null && curTrackedQuest.Id == newQuestId)
		{
			return false;
		}
		if (quest.AutoCoverCurTrack)
		{
			this.RequestTrackQuest(newQuestId, true, ERequestTrackOperate.Auto, ESetTrackReason.None, null);
			return true;
		}
		if (curTrackedQuest != null && curTrackedQuest.AutoTrack)
		{
			return false;
		}
		if (!quest.AutoTrack)
		{
			return false;
		}
		this.RequestTrackQuest(newQuestId, true, ERequestTrackOperate.Auto, ESetTrackReason.None, null);
		return true;
	}

	// Token: 0x0601407A RID: 82042 RVA: 0x0050B864 File Offset: 0x00509A64
	public bool TryChangeTrackedQuest2(int? newQuestId)
	{
		QuestNewModel instance = QuestNewModel.Instance;
		if (instance.IsInFocusMode())
		{
			Log instance2 = Log.Instance;
			ELogModule module = ELogModule.Quest;
			ELogAuthor author = ELogAuthor.YSQ;
			string message = "QuestTrackAssistant.专注模式下不允许切换任务追踪2";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("newQuestId", newQuestId);
			instance2.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		global::Quest curTrackedQuest = instance.GetCurTrackedQuest();
		if (curTrackedQuest != null && !QuestNewModel.Instance.CheckQuestFinished(curTrackedQuest.Id))
		{
			return false;
		}
		if (newQuestId != null)
		{
			int? successiveQuestId = instance.GetSuccessiveQuestId(new int?(newQuestId.Value));
			if (successiveQuestId != null)
			{
				this.RequestTrackQuest(successiveQuestId.Value, true, ERequestTrackOperate.Auto, ESetTrackReason.None, null);
				return true;
			}
		}
		int? highestPriorityProcessingQuestId = instance.GetHighestPriorityProcessingQuestId();
		if (highestPriorityProcessingQuestId != null)
		{
			if (newQuestId != null)
			{
				this.RequestTrackQuest(highestPriorityProcessingQuestId.Value, true, ERequestTrackOperate.Auto, ESetTrackReason.None, null);
				return true;
			}
			double player = LocalStorage.GetPlayer<double>(ELocalStoragePlayerKey.AuToTrackQuestTime, 0.0);
			double serverTimeStamp = TimeUtil.Instance.GetServerTimeStamp();
			if (player == 0.0 || serverTimeStamp > player)
			{
				LocalStorage.SetPlayer<double>(ELocalStoragePlayerKey.AuToTrackQuestTime, TimeUtil.Instance.GetNextDayTimeStamp());
				this.RequestTrackQuest(highestPriorityProcessingQuestId.Value, true, ERequestTrackOperate.Auto, ESetTrackReason.None, null);
				return true;
			}
		}
		return false;
	}

	// Token: 0x0601407B RID: 82043 RVA: 0x0050B98C File Offset: 0x00509B8C
	private void OnGeneralLogicTreeSuspend(long treeIncId, int nodeId, EBehaviorTreeSuspendType suspendType)
	{
		BaseBehaviorTree behaviorTree = GeneralLogicTreeModel.Instance.GetBehaviorTree(new long?(treeIncId), false);
		BtType btType = RecallQuestModel.Instance.IsInRecallInstance() ? BtType.Recall : BtType.Quest;
		if (behaviorTree == null || behaviorTree.BtType != btType)
		{
			return;
		}
		global::Quest curTrackedQuest = QuestNewModel.Instance.GetCurTrackedQuest();
		if (curTrackedQuest != null)
		{
			long? treeId = curTrackedQuest.TreeId;
			if (treeId.GetValueOrDefault() == treeIncId & treeId != null)
			{
				if (suspendType == EBehaviorTreeSuspendType.Occupation)
				{
					this.RequestTrackQuest(curTrackedQuest.Id, false, ERequestTrackOperate.Auto, ESetTrackReason.None, null);
					return;
				}
				if (suspendType != EBehaviorTreeSuspendType.Online)
				{
					return;
				}
				curTrackedQuest.SetTrack(false, ESetTrackReason.None);
				return;
			}
		}
	}

	// Token: 0x0601407C RID: 82044 RVA: 0x0050BA1A File Offset: 0x00509C1A
	private void OnTsNotifyQuestTrackState(int questId, bool bTrack, int reason)
	{
		QuestNewModel.Instance.SetQuestTrackState(questId, bTrack, (ESetTrackReason)reason);
	}
}
