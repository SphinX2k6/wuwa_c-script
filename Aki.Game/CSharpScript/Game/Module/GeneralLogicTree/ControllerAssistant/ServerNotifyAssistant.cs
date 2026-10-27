using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.Fishing;
using CSharpScript.Game.Module.Giant;
using CSharpScript.Game.Module.Infrastructure;
using CSharpScript.Game.Module.LevelLoading;
using CSharpScript.Game.Ui;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CSharpScript.Game.Module.GeneralLogicTree.ControllerAssistant
{
	// Token: 0x020059C4 RID: 22980
	[NullableContext(2)]
	[Nullable(0)]
	public class ServerNotifyAssistant : ControllerAssistantBase
	{
		// Token: 0x0603A409 RID: 238601 RVA: 0x00DD8ED1 File Offset: 0x00DD70D1
		protected override void OnDestroy()
		{
		}

		// Token: 0x0603A40A RID: 238602 RVA: 0x00DD8ED4 File Offset: 0x00DD70D4
		public override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.UpdateNodeStatusNotify, new Action<IMessage, Net.CallbackStatus>(this.OnUpdateNodeStatusNotify));
			Net.Instance.Register(ENotifyMessageId.UpdateNodeProgressNotify, new Action<IMessage, Net.CallbackStatus>(this.OnUpdateNodeProgressNotify));
			Net.Instance.Register(ENotifyMessageId.UpdateChildQuestNodeStatusNotify, new Action<IMessage, Net.CallbackStatus>(this.OnUpdateChildQuestNodeStatusNotify));
			Net.Instance.Register(ENotifyMessageId.BtRollbackNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRollbackNotify));
			Net.Instance.Register(ENotifyMessageId.BtRollbackStartNotify, new Action<IMessage, Net.CallbackStatus>(this.OnBtRollbackStartNotify));
			Net.Instance.Register(ENotifyMessageId.BtRollbackInfoNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRollbackInfoNotify));
			Net.Instance.Register(ENotifyMessageId.BtSuspendNotify, new Action<IMessage, Net.CallbackStatus>(this.OnBtSuspendNotify));
			Net.Instance.Register(ENotifyMessageId.UpdateTimerInfoNotify, new Action<IMessage, Net.CallbackStatus>(this.OnUpdateTimerInfoNotify));
			Net.Instance.Register(ENotifyMessageId.BtVarUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnBtVarUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.BehaviorTreeInfoNotify, new Action<IMessage, Net.CallbackStatus>(this.OnBehaviorTreeInfoNotify));
			Net.Instance.Register(ENotifyMessageId.BehaviorTreeDeleteNotify, new Action<IMessage, Net.CallbackStatus>(this.OnBehaviorTreeDeleteNotify));
			Net.Instance.Register(ENotifyMessageId.AutoQuestNotify, new Action<IMessage, Net.CallbackStatus>(this.OnGmStateNotify));
			Net.Instance.Register(ENotifyMessageId.ActionOpenSystemBoardNotify, new Action<IMessage, Net.CallbackStatus>(this.OnActionOpenSystemBoardNotify));
			Net.Instance.Register(ENotifyMessageId.QuestRollBackEndNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRollBackEndNotify));
		}

		// Token: 0x0603A40B RID: 238603 RVA: 0x00DD906C File Offset: 0x00DD726C
		public override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.UpdateNodeStatusNotify);
			Net.Instance.UnRegister(ENotifyMessageId.UpdateNodeProgressNotify);
			Net.Instance.UnRegister(ENotifyMessageId.UpdateChildQuestNodeStatusNotify);
			Net.Instance.UnRegister(ENotifyMessageId.BtRollbackNotify);
			Net.Instance.UnRegister(ENotifyMessageId.BtRollbackInfoNotify);
			Net.Instance.UnRegister(ENotifyMessageId.BtSuspendNotify);
			Net.Instance.UnRegister(ENotifyMessageId.UpdateTimerInfoNotify);
			Net.Instance.UnRegister(ENotifyMessageId.BtVarUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.BehaviorTreeInfoNotify);
			Net.Instance.UnRegister(ENotifyMessageId.BehaviorTreeDeleteNotify);
			Net.Instance.UnRegister(ENotifyMessageId.AutoQuestNotify);
			Net.Instance.UnRegister(ENotifyMessageId.ActionOpenSystemBoardNotify);
			Net.Instance.UnRegister(ENotifyMessageId.QuestRollBackEndNotify);
		}

		// Token: 0x0603A40C RID: 238604 RVA: 0x00DD914C File Offset: 0x00DD734C
		private unsafe void OnUpdateNodeStatusNotify(IMessage msg, Net.CallbackStatus _)
		{
			UpdateNodeStatusNotify updateNodeStatusNotify = (UpdateNodeStatusNotify)msg;
			long treeIncId = updateNodeStatusNotify.TreeIncId;
			BaseBehaviorTree behaviorTree = GeneralLogicTreeModel.Instance.GetBehaviorTree(new long?(treeIncId), false);
			if (behaviorTree == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.GeneralLogicTree;
				ELogAuthor author = ELogAuthor.YSQ;
				string message = "收到节点状态更新协议时：行为树不存在，1.检查本地配置是否正确 2.服务端检查协议下发顺序";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("treeId", treeIncId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Quest;
			ELogAuthor author2 = ELogAuthor.YSQ;
			string message2 = "行为树节点状态更新";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("树Id", behaviorTree.TreeConfigId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("节点Id", updateNodeStatusNotify.NodeId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("节点状态", GeneralLogicTreeDefine.btNodeStatusLogString[updateNodeStatusNotify.Status]);
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			behaviorTree.UpdateNodeState(ENodeStatusUpdateReason.ServerUpdateNodeStatus, updateNodeStatusNotify.NodeId, updateNodeStatusNotify.Status);
		}

		// Token: 0x0603A40D RID: 238605 RVA: 0x00DD9250 File Offset: 0x00DD7450
		private void OnUpdateNodeProgressNotify(IMessage msg, Net.CallbackStatus _)
		{
			UpdateNodeProgressNotify updateNodeProgressNotify = (UpdateNodeProgressNotify)msg;
			long treeIncId = updateNodeProgressNotify.TreeIncId;
			BaseBehaviorTree behaviorTree = GeneralLogicTreeModel.Instance.GetBehaviorTree(new long?(treeIncId), false);
			if (behaviorTree == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.GeneralLogicTree;
				ELogAuthor author = ELogAuthor.YSQ;
				string message = "收到节点进度更新协议时：行为树不存在，1.检查本地配置是否正确 2.服务端检查协议下发顺序";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("treeId", treeIncId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			behaviorTree.UpdateNodeProgress(updateNodeProgressNotify.NodeId, updateNodeProgressNotify.Progress);
		}

		// Token: 0x0603A40E RID: 238606 RVA: 0x00DD92C4 File Offset: 0x00DD74C4
		private unsafe void OnUpdateChildQuestNodeStatusNotify(IMessage msg, Net.CallbackStatus _)
		{
			UpdateChildQuestNodeStatusNotify updateChildQuestNodeStatusNotify = (UpdateChildQuestNodeStatusNotify)msg;
			long treeIncId = updateChildQuestNodeStatusNotify.TreeIncId;
			BaseBehaviorTree behaviorTree = GeneralLogicTreeModel.Instance.GetBehaviorTree(new long?(treeIncId), false);
			if (behaviorTree == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.GeneralLogicTree;
				ELogAuthor author = ELogAuthor.YSQ;
				string message = "收到子任务节点状态更新协议时：行为树不存在，1.检查本地配置是否正确 2.服务端检查协议下发顺序";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("treeId", updateChildQuestNodeStatusNotify.TreeIncId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Quest;
			ELogAuthor author2 = ELogAuthor.YSQ;
			string message2 = "行为树ChildQuest节点状态更新";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("树Id", behaviorTree.TreeConfigId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("节点Id", updateChildQuestNodeStatusNotify.NodeId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("ChildQuest子节点状态", GeneralLogicTreeDefine.btChildQuestNodeStatusLogString[updateChildQuestNodeStatusNotify.Status]);
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			behaviorTree.UpdateChildQuestNodeState(updateChildQuestNodeStatusNotify.NodeId, updateChildQuestNodeStatusNotify.Status, ENodeStatusUpdateReason.ServerUpdateNodeStatus);
		}

		// Token: 0x0603A40F RID: 238607 RVA: 0x00DD93CC File Offset: 0x00DD75CC
		private void OnRollbackNotify(IMessage msg, Net.CallbackStatus _)
		{
			BtRollbackNotify btRollbackNotify = (BtRollbackNotify)msg;
			long treeIncId = btRollbackNotify.TreeIncId;
			BaseBehaviorTree behaviorTree = GeneralLogicTreeModel.Instance.GetBehaviorTree(new long?(treeIncId), false);
			if (behaviorTree == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.GeneralLogicTree;
				ELogAuthor author = ELogAuthor.YSQ;
				string message = "服务器通知回退准备时：行为树不存在，1.检查本地配置是否正确 2.服务端检查协议下发顺序";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("treeId", btRollbackNotify.TreeIncId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.GeneralLogicTree;
			ELogAuthor author2 = ELogAuthor.YSQ;
			string message2 = "服务器通知客户端做回退准备";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("treeConfigId", behaviorTree.TreeConfigId);
			instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			EventSystem.Instance.Emit<int>(EEventName.GeneralLogicTreePrepareRollback, behaviorTree.TreeConfigId);
			behaviorTree.PrepareRollback(new FailReason?(btRollbackNotify.FailReason), new int?(btRollbackNotify.FailNodeId));
		}

		// Token: 0x0603A410 RID: 238608 RVA: 0x00DD9498 File Offset: 0x00DD7698
		private void OnBtRollbackStartNotify(IMessage msg, Net.CallbackStatus __)
		{
			BtRollbackStartNotify btRollbackStartNotify = (BtRollbackStartNotify)msg;
			if (!btRollbackStartNotify.IsRollbackSubLevel && !btRollbackStartNotify.IsRollbackPos)
			{
				return;
			}
			DelayTask task = new DelayTask("OnBtRollbackStartNotify", null, delegate()
			{
				LevelLoadingController.Instance.OpenLoading<ELoadingPerform>(ELoadingReason.BehaviorTreeRollback, ELoadingPerform.CameraFade, "BehaviorTreeRollbackNotify", null, Array.Empty<object>());
				return true;
			}, 1000, null);
			TaskSystem.Instance.AddTask(task);
			TaskSystem.Instance.Run();
		}

		// Token: 0x0603A411 RID: 238609 RVA: 0x00DD9504 File Offset: 0x00DD7704
		private void OnRollbackInfoNotify(IMessage msg, Net.CallbackStatus __)
		{
			BtRollbackInfoNotify btRollbackInfoNotify = (BtRollbackInfoNotify)msg;
			long treeIncId = btRollbackInfoNotify.TreeIncId;
			BaseBehaviorTree behaviorTree = GeneralLogicTreeModel.Instance.GetBehaviorTree(new long?(treeIncId), false);
			if (behaviorTree == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.GeneralLogicTree;
				ELogAuthor author = ELogAuthor.YSQ;
				string message = "收到服务器回退通知时：行为树不存在，1.检查本地配置是否正确 2.服务端检查协议下发顺序";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("treeId", treeIncId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				LevelLoadingController.Instance.CloseLoading(ELoadingReason.BehaviorTreeRollback, "BehaviorTreeRollbackNotify", null, null);
				return;
			}
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.GeneralLogicTree;
			ELogAuthor author2 = ELogAuthor.YSQ;
			string message2 = "服务器通知行为树回退";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("treeConfigId", behaviorTree.TreeConfigId);
			instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			GeneralLogicTreeModel instance3 = GeneralLogicTreeModel.Instance;
			bool flag = behaviorTree.IsTracking();
			instance3.RemoveBehaviorTree(treeIncId, ETreeRemoveReason.TreeRollback);
			BaseBehaviorTree newTree = instance3.CreateBehaviorTree(btRollbackInfoNotify.TreeInfo);
			if (flag)
			{
				if (behaviorTree.BtType == BtType.LevelPlay)
				{
					LevelPlayModel.Instance.SetTrackLevelPlayId(0);
				}
				else
				{
					BaseBehaviorTree newTree3 = newTree;
					if (newTree3 != null)
					{
						newTree3.SetTrack(true, ESetTrackReason.None);
					}
				}
			}
			ActionTask task = new ActionTask("OnRollbackInfoNotify", delegate()
			{
				LevelLoadingController.Instance.CloseLoading(ELoadingReason.BehaviorTreeRollback, "BehaviorTreeRollbackNotify", null, null);
				EventSystem instance4 = EventSystem.Instance;
				EEventName name = EEventName.GeneralLogicTreePrepareRollbackFinish;
				BaseBehaviorTree newTree2 = newTree;
				instance4.Emit<int>(name, (newTree2 != null) ? newTree2.TreeConfigId : 0);
				return true;
			}, null, null);
			TaskSystem.Instance.AddTask(task);
			TaskSystem.Instance.Run();
		}

		// Token: 0x0603A412 RID: 238610 RVA: 0x00DD9644 File Offset: 0x00DD7844
		private void OnRollBackEndNotify(IMessage msg, Net.CallbackStatus _)
		{
			QuestRollBackEndNotify questRollBackEndNotify = (QuestRollBackEndNotify)msg;
			EventSystem.Instance.Emit<int>(EEventName.OnQuestRedDotStateChange, questRollBackEndNotify.QuestId);
		}

		// Token: 0x0603A413 RID: 238611 RVA: 0x00DD9670 File Offset: 0x00DD7870
		private void OnBtSuspendNotify(IMessage msg, Net.CallbackStatus _)
		{
			BtSuspendNotify btSuspendNotify = (BtSuspendNotify)msg;
			long treeIncId = btSuspendNotify.TreeIncId;
			BaseBehaviorTree behaviorTree = GeneralLogicTreeModel.Instance.GetBehaviorTree(new long?(treeIncId), false);
			if (behaviorTree == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.GeneralLogicTree;
				ELogAuthor author = ELogAuthor.YSQ;
				string message = "收到服务器挂起通知时：行为树不存在，1.检查本地配置是否正确 2.服务端检查协议下发顺序";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("treeId", treeIncId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			behaviorTree.UpdateOccupations(btSuspendNotify.NodeId, btSuspendNotify.SuspendType, btSuspendNotify.OccupationInfo);
		}

		// Token: 0x0603A414 RID: 238612 RVA: 0x00DD96E8 File Offset: 0x00DD78E8
		private void OnUpdateTimerInfoNotify(IMessage msg, Net.CallbackStatus _)
		{
			UpdateTimerInfoNotify updateTimerInfoNotify = (UpdateTimerInfoNotify)msg;
			long treeIncId = updateTimerInfoNotify.TreeIncId;
			BaseBehaviorTree behaviorTree = GeneralLogicTreeModel.Instance.GetBehaviorTree(new long?(treeIncId), false);
			if (behaviorTree == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.GeneralLogicTree;
				ELogAuthor author = ELogAuthor.YSQ;
				string message = "服务器通知更新定时器时：行为树不存在，1.检查本地配置是否正确 2.服务端检查协议下发顺序";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("treeId", treeIncId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			behaviorTree.UpdateTimer(updateTimerInfoNotify.TimerInfo);
		}

		// Token: 0x0603A415 RID: 238613 RVA: 0x00DD9754 File Offset: 0x00DD7954
		private void OnBtVarUpdateNotify(IMessage msg, Net.CallbackStatus _)
		{
			BtVarUpdateNotify btVarUpdateNotify = (BtVarUpdateNotify)msg;
			long treeIncId = btVarUpdateNotify.TreeIncId;
			BaseBehaviorTree behaviorTree = GeneralLogicTreeModel.Instance.GetBehaviorTree(new long?(treeIncId), false);
			if (behaviorTree == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.GeneralLogicTree;
				ELogAuthor author = ELogAuthor.CH;
				string message = "服务器通知更新变量时：行为树不存在，1.检查本地配置是否正确 2.服务端检查协议下发顺序";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("treeId", treeIncId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			behaviorTree.UpdateTreeVars(btVarUpdateNotify);
		}

		// Token: 0x0603A416 RID: 238614 RVA: 0x00DD97BC File Offset: 0x00DD79BC
		private void OnBehaviorTreeInfoNotify(IMessage msg, Net.CallbackStatus _)
		{
			RepeatedField<TreeInfo> treeInfos = ((BehaviorTreeInfoNotify)msg).TreeInfos;
			if (treeInfos == null || treeInfos.Count == 0)
			{
				return;
			}
			foreach (TreeInfo treeInfo in treeInfos)
			{
				GeneralLogicTreeModel.Instance.CreateBehaviorTree(treeInfo);
			}
		}

		// Token: 0x0603A417 RID: 238615 RVA: 0x00DD9824 File Offset: 0x00DD7A24
		private void OnBehaviorTreeDeleteNotify(IMessage msg, Net.CallbackStatus _)
		{
			RepeatedField<long> treeIncIds = ((BehaviorTreeDeleteNotify)msg).TreeIncIds;
			if (treeIncIds == null || treeIncIds.Count == 0)
			{
				return;
			}
			foreach (long treeId in treeIncIds)
			{
				GeneralLogicTreeModel.Instance.RemoveBehaviorTree(treeId, ETreeRemoveReason.TreeDestroy);
			}
		}

		// Token: 0x0603A418 RID: 238616 RVA: 0x00DD988C File Offset: 0x00DD7A8C
		private void OnGmStateNotify(IMessage msg, Net.CallbackStatus _)
		{
			AutoQuestNotify autoQuestNotify = (AutoQuestNotify)msg;
			AutoRunModel.Instance.ShouldFastSkip = autoQuestNotify.IsAuto;
			AutoRunModel.Instance.SetAutoRunMode(autoQuestNotify.IsAuto ? EAutoRunMode.ServerControlledSkip : EAutoRunMode.Disabled, BtType.Invalid, 0, 0);
			AutoRunModel.Instance.SetAutoRunState(autoQuestNotify.IsAuto ? EAutoRunState.Running : EAutoRunState.Stopped);
		}

		// Token: 0x0603A419 RID: 238617 RVA: 0x00DD98E0 File Offset: 0x00DD7AE0
		private void OnActionOpenSystemBoardNotify(IMessage msg, Net.CallbackStatus _)
		{
			ActionOpenSystemBoardNotify actionOpenSystemBoardNotify = (ActionOpenSystemBoardNotify)msg;
			int valueOrDefault = PlayerInfoModel.Instance.GetId().GetValueOrDefault();
			if (valueOrDefault != 0 && actionOpenSystemBoardNotify.PlayerId != valueOrDefault)
			{
				return;
			}
			ActionOpenSystemParam protoParams = actionOpenSystemBoardNotify.Param;
			if (protoParams == null)
			{
				return;
			}
			switch (protoParams.ActionOpenType)
			{
			case ActionOpenSystemType.ActionOpenSystem:
			{
				OpenSystemBoardData openSystemBoardData = protoParams.OpenSystemBoardData;
				if (openSystemBoardData == null)
				{
					Log.Instance.Error(ELogModule.GeneralLogicTree, ELogAuthor.YSQ, "ActionOpenSystemBoardNotify:打开带返回值的确认框时，服务端下发参数为空", default(ReadOnlySpan<ValueTuple<string, object>>));
					return;
				}
				ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew((EConfirmBoxConfigId)openSystemBoardData.BoardId);
				confirmBoxDataNew.FunctionMap[1] = delegate()
				{
					this.OpenSystemBoardResultRequest(0, protoParams.IncId);
				};
				confirmBoxDataNew.FunctionMap[2] = delegate()
				{
					this.OpenSystemBoardResultRequest(1, protoParams.IncId);
				};
				ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
				return;
			}
			case ActionOpenSystemType.SoaringChallenge:
			{
				SoaringChallengeData soaringChallengeData = protoParams.SoaringChallengeData;
				if (soaringChallengeData == null)
				{
					Log.Instance.Error(ELogModule.GeneralLogicTree, ELogAuthor.YSQ, "ActionOpenSystemBoardNotify:打开翱翔结算时，服务端下发参数为空", default(ReadOnlySpan<ValueTuple<string, object>>));
					return;
				}
				FlySettlementViewParams param = new FlySettlementViewParams(soaringChallengeData.Score, soaringChallengeData.RankS, soaringChallengeData.RankA, soaringChallengeData.RankB, GeneralLogicTreeModel.Instance.HistorySoarScore, protoParams.IncId);
				UiManager.Instance.OpenView(EUiViewName.FlySettlementView, param, null);
				return;
			}
			case ActionOpenSystemType.FishingHandIn:
			{
				FishingHandInData fishingHandInData = protoParams.FishingHandInData;
				if (fishingHandInData == null)
				{
					Log.Instance.Error(ELogModule.GeneralLogicTree, ELogAuthor.XXJ, "ActionOpenSystemBoardNotify:打开捕鱼交付界面时，服务端下发参数为空", default(ReadOnlySpan<ValueTuple<string, object>>));
					return;
				}
				FishingController.Instance.OpenDockyardInteractView(fishingHandInData.HandInId, protoParams.IncId);
				return;
			}
			case ActionOpenSystemType.GreatSwordChallenge:
			{
				GreatSwordChallengeData greatSwordChallengeData = protoParams.GreatSwordChallengeData;
				if (greatSwordChallengeData == null)
				{
					Log.Instance.Error(ELogModule.GeneralLogicTree, ELogAuthor.WMQ, "ActionOpenSystemBoardNotify:打开大剑挑战时，服务端下发参数为空", default(ReadOnlySpan<ValueTuple<string, object>>));
					return;
				}
				GreatSwordController.Instance.RequestGreatSwordInfoAndOpenView(greatSwordChallengeData.Id, protoParams.IncId);
				return;
			}
			case ActionOpenSystemType.InfrHandIn:
			{
				InfrHandInData infrHandInData = protoParams.InfrHandInData;
				if (infrHandInData == null)
				{
					Log.Instance.Error(ELogModule.Infrastructure, ELogAuthor.LYX, "ActionOpenSystemBoardNotify:打开基建交付时，服务端下发参数为空", default(ReadOnlySpan<ValueTuple<string, object>>));
					return;
				}
				if (CreatureModel.Instance.GetIsLoadingScene())
				{
					GeneralLogicTreeController.Instance.OpenSystemBoardResultRequest(0, protoParams.IncId);
					return;
				}
				InfrastructureController.Instance.OpenMaterialDelivery(infrHandInData.Type, infrHandInData.Id, protoParams.IncId, InfrastructureDefine.EMaterialDeliveryOpenSource.BigWorld);
				return;
			}
			case ActionOpenSystemType.MotorRaceChallenge:
			{
				MotorRaceChallengeData motorRaceChallengeData = protoParams.MotorRaceChallengeData;
				if (motorRaceChallengeData == null)
				{
					Log.Instance.Error(ELogModule.Infrastructure, ELogAuthor.CXJ, "ActionOpenSystemBoardNotify:打开摩托模拟赛结算时，服务端下发参数为空", default(ReadOnlySpan<ValueTuple<string, object>>));
					return;
				}
				MotorSettlementViewParams param2 = new MotorSettlementViewParams(motorRaceChallengeData.Score, motorRaceChallengeData.RankS, motorRaceChallengeData.RankA, motorRaceChallengeData.RankB, (long)protoParams.IncId);
				UiManager.Instance.OpenView(EUiViewName.MotorRaceSettlementView, param2, null);
				return;
			}
			case ActionOpenSystemType.InfrV2HandIn:
				break;
			case ActionOpenSystemType.GiantSystem:
			{
				GiantSystemBoardData giantSystemBoardData = protoParams.GiantSystemBoardData;
				if (giantSystemBoardData == null)
				{
					Log.Instance.Error(ELogModule.GeneralLogicTree, ELogAuthor.YSQ, "ActionOpenSystemBoardNotify:打开巨人交付界面时，服务端下发参数为空", default(ReadOnlySpan<ValueTuple<string, object>>));
					return;
				}
				GiantSystemCollectOpenParam param3 = new GiantSystemCollectOpenParam
				{
					EcoType = (GiantEcoNetType)giantSystemBoardData.GiantEcoType,
					IncId = protoParams.IncId
				};
				UiManager.Instance.OpenView(EUiViewName.GiantSystemCollectView, param3, null);
				break;
			}
			default:
				return;
			}
		}

		// Token: 0x0603A41A RID: 238618 RVA: 0x00DD9C60 File Offset: 0x00DD7E60
		public void OpenSystemBoardResultRequest(int result, int incId)
		{
			int valueOrDefault = PlayerInfoModel.Instance.GetId().GetValueOrDefault();
			OpenSystemBoardResultRequest openSystemBoardResultRequest = Aki.Protocol.OpenSystemBoardResultRequest.Create();
			openSystemBoardResultRequest.PlayerId = valueOrDefault;
			openSystemBoardResultRequest.Result = result;
			openSystemBoardResultRequest.IncId = incId;
			Net.Instance.Call(ERequestMessageId.OpenSystemBoardResultRequest, openSystemBoardResultRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				OpenSystemBoardResultResponse openSystemBoardResultResponse = (OpenSystemBoardResultResponse)msg;
				if (openSystemBoardResultResponse.Code != ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(openSystemBoardResultResponse.Code, 17436, null, false, true);
				}
			}, 0);
		}
	}
}
