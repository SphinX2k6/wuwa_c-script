using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.LevelGamePlay.Guarantee;

namespace CSharpScript.Game.Module.GeneralLogicTree.ControllerAssistant
{
	// Token: 0x020059C2 RID: 22978
	[NullableContext(1)]
	[Nullable(0)]
	public class GuaranteeAssistant : ControllerAssistantBase
	{
		// Token: 0x0603A3E8 RID: 238568 RVA: 0x00DD7E77 File Offset: 0x00DD6077
		protected override void OnDestroy()
		{
		}

		// Token: 0x0603A3E9 RID: 238569 RVA: 0x00DD7E7C File Offset: 0x00DD607C
		public override void OnAddEvents()
		{
			EventSystem.Instance.Add<string, GeneralContext, GuaranteeActionInfo, bool?>(EEventName.AddGuaranteeAction, new Action<string, GeneralContext, GuaranteeActionInfo, bool?>(this.AddGuaranteeAction));
			EventSystem.Instance.Add<string, GeneralContext, GuaranteeActionInfo, bool?>(EEventName.RemGuaranteeAction, new Action<string, GeneralContext, GuaranteeActionInfo, bool?>(this.RemGuaranteeAction));
			EventSystem.Instance.Add<long, ETreeRemoveReason>(EEventName.OnGeneralLogicTreeRemove, new Action<long, ETreeRemoveReason>(this.OnGeneralLogicTreeRemove));
			EventSystem.Instance.Add<GeneralContext, NodeStatus, NodeStatus, ENodeStatusUpdateReason>(EEventName.OnLogicTreeNodeStatusChange, new Action<GeneralContext, NodeStatus, NodeStatus, ENodeStatusUpdateReason>(this.OnNodeStatusUpdate));
			EventSystem.Instance.Add<long, int, EBehaviorTreeSuspendType>(EEventName.GeneralLogicTreeSuspend, new Action<long, int, EBehaviorTreeSuspendType>(this.OnGeneralLogicTreeSuspend));
		}

		// Token: 0x0603A3EA RID: 238570 RVA: 0x00DD7F18 File Offset: 0x00DD6118
		public override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove<string, GeneralContext, GuaranteeActionInfo, bool?>(EEventName.AddGuaranteeAction, new Action<string, GeneralContext, GuaranteeActionInfo, bool?>(this.AddGuaranteeAction));
			EventSystem.Instance.Remove<string, GeneralContext, GuaranteeActionInfo, bool?>(EEventName.RemGuaranteeAction, new Action<string, GeneralContext, GuaranteeActionInfo, bool?>(this.RemGuaranteeAction));
			EventSystem.Instance.Remove<long, ETreeRemoveReason>(EEventName.OnGeneralLogicTreeRemove, new Action<long, ETreeRemoveReason>(this.OnGeneralLogicTreeRemove));
			EventSystem.Instance.Remove<GeneralContext, NodeStatus, NodeStatus, ENodeStatusUpdateReason>(EEventName.OnLogicTreeNodeStatusChange, new Action<GeneralContext, NodeStatus, NodeStatus, ENodeStatusUpdateReason>(this.OnNodeStatusUpdate));
			EventSystem.Instance.Remove<long, int, EBehaviorTreeSuspendType>(EEventName.GeneralLogicTreeSuspend, new Action<long, int, EBehaviorTreeSuspendType>(this.OnGeneralLogicTreeSuspend));
		}

		// Token: 0x0603A3EB RID: 238571 RVA: 0x00DD7FB4 File Offset: 0x00DD61B4
		private void AddGuaranteeAction(string instigatorName, [Nullable(2)] GeneralContext instigatorContext, GuaranteeActionInfo guaranteeActionInfo, bool? bNeedGuaranteeInQuest = false)
		{
			GeneralContext generalContext = instigatorContext;
			DynamicInteractContext dynamicInteractContext = instigatorContext as DynamicInteractContext;
			if (dynamicInteractContext != null)
			{
				generalContext = dynamicInteractContext.FinalContext;
			}
			GeneralLogicTreeContext generalLogicTreeContext = generalContext as GeneralLogicTreeContext;
			if (generalLogicTreeContext == null || generalLogicTreeContext.TreeIncId == 0L)
			{
				return;
			}
			BaseBehaviorTree behaviorTree = GeneralLogicTreeModel.Instance.GetBehaviorTree(new long?(generalLogicTreeContext.TreeIncId), false);
			if (behaviorTree == null)
			{
				return;
			}
			EActionFilterMode actionFilterMode = GuaranteeActionCenter.Instance.GetActionFilterMode(guaranteeActionInfo.Name);
			behaviorTree.AddGuaranteeActionInfo(instigatorName, generalLogicTreeContext.NodeId, guaranteeActionInfo, actionFilterMode);
		}

		// Token: 0x0603A3EC RID: 238572 RVA: 0x00DD8024 File Offset: 0x00DD6224
		private void RemGuaranteeAction(string instigatorName, [Nullable(2)] GeneralContext instigatorContext, GuaranteeActionInfo guaranteeActionInfo, bool? bNeedGuaranteeInQuest = false)
		{
			GeneralContext generalContext = instigatorContext;
			DynamicInteractContext dynamicInteractContext = instigatorContext as DynamicInteractContext;
			if (dynamicInteractContext != null)
			{
				generalContext = dynamicInteractContext.FinalContext;
			}
			GeneralLogicTreeContext generalLogicTreeContext = generalContext as GeneralLogicTreeContext;
			if (generalLogicTreeContext == null || generalLogicTreeContext.TreeIncId == 0L)
			{
				return;
			}
			BaseBehaviorTree behaviorTree = GeneralLogicTreeModel.Instance.GetBehaviorTree(new long?(generalLogicTreeContext.TreeIncId), false);
			if (behaviorTree == null)
			{
				return;
			}
			EActionFilterMode actionFilterMode = GuaranteeActionCenter.Instance.GetActionFilterMode(guaranteeActionInfo.Name);
			behaviorTree.PopGuaranteeActionInfo(instigatorName, guaranteeActionInfo, actionFilterMode);
			GeneralLogicTreeModel.Instance.PopGuaranteeActionsWhenLogicTreeRemove(generalLogicTreeContext.TreeIncId, guaranteeActionInfo);
		}

		// Token: 0x0603A3ED RID: 238573 RVA: 0x00DD80A4 File Offset: 0x00DD62A4
		private void OnNodeStatusUpdate(GeneralContext context, NodeStatus oldStatus, NodeStatus newStatus, ENodeStatusUpdateReason reason)
		{
			GeneralLogicTreeContext generalLogicTreeContext = context as GeneralLogicTreeContext;
			if (generalLogicTreeContext == null || generalLogicTreeContext.TreeIncId == 0L)
			{
				return;
			}
			BaseBehaviorTree behaviorTree = GeneralLogicTreeModel.Instance.GetBehaviorTree(new long?(generalLogicTreeContext.TreeIncId), false);
			if (behaviorTree == null)
			{
				return;
			}
			int rollbackPoint = behaviorTree.GetRollbackPoint();
			if (newStatus != NodeStatus.Activated)
			{
				if (newStatus - NodeStatus.CompletedSuccess > 1)
				{
					return;
				}
				if (rollbackPoint == 0)
				{
					behaviorTree.ClearGuaranteeActions(generalLogicTreeContext.NodeId);
				}
			}
			else if (rollbackPoint != 0 && generalLogicTreeContext.NodeId == rollbackPoint)
			{
				behaviorTree.ClearGuaranteeActions(0);
				return;
			}
		}

		// Token: 0x0603A3EE RID: 238574 RVA: 0x00DD8114 File Offset: 0x00DD6314
		private void OnGeneralLogicTreeRemove(long treeIncId, ETreeRemoveReason removeReason)
		{
			BaseBehaviorTree behaviorTree = GeneralLogicTreeModel.Instance.GetBehaviorTree(new long?(treeIncId), false);
			if (behaviorTree == null)
			{
				return;
			}
			behaviorTree.ExecuteTreeGuaranteeActions(removeReason);
			Dictionary<long, List<GuaranteeActionInfo>> guaranteeActionsWhenLogicTreeRemove = GeneralLogicTreeModel.Instance.GuaranteeActionsWhenLogicTreeRemove;
			List<GuaranteeActionInfo> list;
			if (guaranteeActionsWhenLogicTreeRemove != null && guaranteeActionsWhenLogicTreeRemove.Remove(treeIncId, out list))
			{
				if (list.Count == 0)
				{
					return;
				}
				GuaranteeContext context = (removeReason == ETreeRemoveReason.TreeRollback) ? GuaranteeContext.Create(null, EGuaranteeReason.TreeRollback) : GuaranteeContext.Create(null, EGuaranteeReason.TreeDestroy);
				GuaranteeController.Instance.ExecuteActions(list, context);
			}
		}

		// Token: 0x0603A3EF RID: 238575 RVA: 0x00DD8194 File Offset: 0x00DD6394
		private void OnGeneralLogicTreeSuspend(long treeId, int nodeId, EBehaviorTreeSuspendType suspendType)
		{
			BaseBehaviorTree behaviorTree = GeneralLogicTreeModel.Instance.GetBehaviorTree(new long?(treeId), false);
			if (behaviorTree == null)
			{
				return;
			}
			foreach (int sessionId in behaviorTree.GetBlackBoard().GetCurrentExecuteActions())
			{
				LevelGeneralController.Instance.StopActionsExecute(sessionId);
			}
			behaviorTree.ExecuteTreeGuaranteeActions(ETreeRemoveReason.TreeDestroy);
		}
	}
}
