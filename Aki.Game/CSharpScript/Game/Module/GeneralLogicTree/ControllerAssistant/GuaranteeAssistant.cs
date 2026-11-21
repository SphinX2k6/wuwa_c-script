using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.LevelGamePlay.Guarantee;

namespace CSharpScript.Game.Module.GeneralLogicTree.ControllerAssistant
{
	// Token: 0x0200499B RID: 18843
	[NullableContext(1)]
	[Nullable(0)]
	public class GuaranteeAssistant : ControllerAssistantBase
	{
		// Token: 0x0602F30F RID: 193295 RVA: 0x00D2734F File Offset: 0x00D2554F
		protected override void OnDestroy()
		{
		}

		// Token: 0x0602F310 RID: 193296 RVA: 0x00D27354 File Offset: 0x00D25554
		public override void OnAddEvents()
		{
			EventSystem.Instance.Add<string, GeneralContext, GuaranteeActionInfo, bool?>(EEventName.AddGuaranteeAction, new Action<string, GeneralContext, GuaranteeActionInfo, bool?>(this.AddGuaranteeAction));
			EventSystem.Instance.Add<string, GeneralContext, GuaranteeActionInfo, bool?>(EEventName.RemGuaranteeAction, new Action<string, GeneralContext, GuaranteeActionInfo, bool?>(this.RemGuaranteeAction));
			EventSystem.Instance.Add<long, ETreeRemoveReason>(EEventName.OnGeneralLogicTreeRemove, new Action<long, ETreeRemoveReason>(this.OnGeneralLogicTreeRemove));
			EventSystem.Instance.Add<GeneralContext, NodeStatus, NodeStatus, ENodeStatusUpdateReason>(EEventName.OnLogicTreeNodeStatusChange, new Action<GeneralContext, NodeStatus, NodeStatus, ENodeStatusUpdateReason>(this.OnNodeStatusUpdate));
			EventSystem.Instance.Add<long, int, EBehaviorTreeSuspendType>(EEventName.GeneralLogicTreeSuspend, new Action<long, int, EBehaviorTreeSuspendType>(this.OnGeneralLogicTreeSuspend));
		}

		// Token: 0x0602F311 RID: 193297 RVA: 0x00D273F0 File Offset: 0x00D255F0
		public override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove<string, GeneralContext, GuaranteeActionInfo, bool?>(EEventName.AddGuaranteeAction, new Action<string, GeneralContext, GuaranteeActionInfo, bool?>(this.AddGuaranteeAction));
			EventSystem.Instance.Remove<string, GeneralContext, GuaranteeActionInfo, bool?>(EEventName.RemGuaranteeAction, new Action<string, GeneralContext, GuaranteeActionInfo, bool?>(this.RemGuaranteeAction));
			EventSystem.Instance.Remove<long, ETreeRemoveReason>(EEventName.OnGeneralLogicTreeRemove, new Action<long, ETreeRemoveReason>(this.OnGeneralLogicTreeRemove));
			EventSystem.Instance.Remove<GeneralContext, NodeStatus, NodeStatus, ENodeStatusUpdateReason>(EEventName.OnLogicTreeNodeStatusChange, new Action<GeneralContext, NodeStatus, NodeStatus, ENodeStatusUpdateReason>(this.OnNodeStatusUpdate));
			EventSystem.Instance.Remove<long, int, EBehaviorTreeSuspendType>(EEventName.GeneralLogicTreeSuspend, new Action<long, int, EBehaviorTreeSuspendType>(this.OnGeneralLogicTreeSuspend));
		}

		// Token: 0x0602F312 RID: 193298 RVA: 0x00D2748C File Offset: 0x00D2568C
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

		// Token: 0x0602F313 RID: 193299 RVA: 0x00D274FC File Offset: 0x00D256FC
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

		// Token: 0x0602F314 RID: 193300 RVA: 0x00D2757C File Offset: 0x00D2577C
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

		// Token: 0x0602F315 RID: 193301 RVA: 0x00D275EC File Offset: 0x00D257EC
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

		// Token: 0x0602F316 RID: 193302 RVA: 0x00D2766C File Offset: 0x00D2586C
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
