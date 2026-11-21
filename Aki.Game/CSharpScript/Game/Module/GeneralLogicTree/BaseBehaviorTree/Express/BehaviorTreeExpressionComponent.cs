using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.Module.BattleUi.Views;
using CSharpScript.Game.Module.GeneralLogicTree.BehaviorNode.ChildQuestNode;

namespace CSharpScript.Game.Module.GeneralLogicTree.BaseBehaviorTree.Express
{
	// Token: 0x020049C6 RID: 18886
	[NullableContext(1)]
	[Nullable(0)]
	public class BehaviorTreeExpressionComponent
	{
		// Token: 0x0602F47D RID: 193661 RVA: 0x00D300D4 File Offset: 0x00D2E2D4
		public BehaviorTreeExpressionComponent(Blackboard blackboard)
		{
			this.Blackboard = blackboard;
			this.TrackTextController = new TrackTextExpressController(blackboard);
			this.TrackMarkController = new TrackMarkExpressController(blackboard);
			this.TrackEffectController = new TrackEffectExpressController(this, blackboard);
			this.CheckPointEffectController = new CheckPointEffectController(blackboard);
		}

		// Token: 0x0602F47E RID: 193662 RVA: 0x00D30114 File Offset: 0x00D2E314
		public void Init()
		{
			this.OnAddEvent();
			this.IsValidInternal = true;
		}

		// Token: 0x0602F47F RID: 193663 RVA: 0x00D30124 File Offset: 0x00D2E324
		public void Dispose()
		{
			this.EnableTrack(false, ESetTrackReason.TreeExpressionComponentDispose, false);
			this.TrackTextController.Clear();
			this.TrackMarkController.Clear();
			this.TrackEffectController.Clear();
			this.CheckPointEffectController.EnableAllEffects(false);
			this.OnRemoveEvent();
			this.IsValidInternal = false;
		}

		// Token: 0x0602F480 RID: 193664 RVA: 0x00D30174 File Offset: 0x00D2E374
		public void EnableTrack(bool bTrack, ESetTrackReason reason = ESetTrackReason.None, bool calledFromBoundTree = false)
		{
			if (this.Blackboard.IsTrackBoundToParent && !calledFromBoundTree)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.GeneralLogicTree;
				ELogAuthor author = ELogAuthor.HYF;
				string message = "当前玩法追踪绑定于父任务，不能独立设置追踪状态";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("当前玩法", this.Blackboard.TreeConfigId);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			this.TrackTextController.EnableTrack(bTrack, reason);
			this.TrackMarkController.EnableTrack(bTrack);
			this.TrackEffectController.EnableTrack(bTrack);
			this.CheckPointEffectController.EnableAllEffects(bTrack);
		}

		// Token: 0x0602F481 RID: 193665 RVA: 0x00D301FC File Offset: 0x00D2E3FC
		public void RefreshMapMark(bool bTrack)
		{
			this.TrackMarkController.EnableTrack(bTrack);
		}

		// Token: 0x0602F482 RID: 193666 RVA: 0x00D3020C File Offset: 0x00D2E40C
		public void ForceSetAllMapMarksVisible(bool visible)
		{
			foreach (NodeTrackMark nodeTrackMark in this.TrackMarkController.GetAllTrackMarkCreator().Values)
			{
				nodeTrackMark.ForceSetAllMarksVisible(visible);
			}
		}

		// Token: 0x0602F483 RID: 193667 RVA: 0x00D30268 File Offset: 0x00D2E468
		public void StartTextExpress(ETreeTextExpressReason reason = ETreeTextExpressReason.None)
		{
			this.TrackTextController.StartTextExpress(reason);
		}

		// Token: 0x0602F484 RID: 193668 RVA: 0x00D30276 File Offset: 0x00D2E476
		public void EndTextExpress(ETreeTextExpressReason reason = ETreeTextExpressReason.None)
		{
			this.TrackTextController.EndTextExpress(reason);
		}

		// Token: 0x0602F485 RID: 193669 RVA: 0x00D30284 File Offset: 0x00D2E484
		[NullableContext(2)]
		public global::Vector GetNodeTrackPosition(int nodeId)
		{
			NodeTrackMark nodeTrackMarkCreator = this.TrackMarkController.GetNodeTrackMarkCreator(nodeId);
			if (nodeTrackMarkCreator == null)
			{
				return null;
			}
			return nodeTrackMarkCreator.GetDefaultTrackPosition();
		}

		// Token: 0x0602F486 RID: 193670 RVA: 0x00D302A0 File Offset: 0x00D2E4A0
		public int GetClosestMapMarkId()
		{
			global::Vector playerLocation = GeneralLogicTreeUtil.Instance.GetPlayerLocation();
			if (playerLocation == null)
			{
				return 0;
			}
			Dictionary<int, NodeTrackMark> allTrackMarkCreator = this.TrackMarkController.GetAllTrackMarkCreator();
			double num = 3.402823466E+38;
			int result = 0;
			foreach (NodeTrackMark nodeTrackMark in allTrackMarkCreator.Values)
			{
				Dictionary<int, global::Vector> worldMapTrackPositions = nodeTrackMark.GetWorldMapTrackPositions();
				if (worldMapTrackPositions != null)
				{
					foreach (KeyValuePair<int, global::Vector> keyValuePair in worldMapTrackPositions)
					{
						int num2;
						global::Vector vector;
						keyValuePair.Deconstruct(out num2, out vector);
						int num3 = num2;
						global::Vector trackPosition = vector;
						double num4 = this.CalculateTrackDistance(playerLocation, trackPosition);
						if (num4 < num)
						{
							num = num4;
							result = num3;
						}
					}
				}
			}
			return result;
		}

		// Token: 0x0602F487 RID: 193671 RVA: 0x00D30380 File Offset: 0x00D2E580
		public int? GetTrackAreaInfo(int nodeId)
		{
			NodeTrackMark nodeTrackMarkCreator = this.TrackMarkController.GetNodeTrackMarkCreator(nodeId);
			if (nodeTrackMarkCreator == null)
			{
				return null;
			}
			return nodeTrackMarkCreator.GetTrackAreaInfo();
		}

		// Token: 0x0602F488 RID: 193672 RVA: 0x00D303AC File Offset: 0x00D2E5AC
		public int? GetDefaultMark(int nodeId)
		{
			NodeTrackMark nodeTrackMarkCreator = this.TrackMarkController.GetNodeTrackMarkCreator(nodeId);
			if (nodeTrackMarkCreator == null)
			{
				return null;
			}
			return nodeTrackMarkCreator.DefaultMapMarkId;
		}

		// Token: 0x0602F489 RID: 193673 RVA: 0x00D303D8 File Offset: 0x00D2E5D8
		public double GetTrackDistance(int nodeId)
		{
			global::Vector playerLocation = GeneralLogicTreeUtil.Instance.GetPlayerLocation();
			if (playerLocation == null)
			{
				return 0.0;
			}
			global::Vector nodeTrackPosition = this.GetNodeTrackPosition(nodeId);
			if (nodeTrackPosition == null)
			{
				return 0.0;
			}
			return this.CalculateTrackDistance(playerLocation, nodeTrackPosition);
		}

		// Token: 0x0602F48A RID: 193674 RVA: 0x00D3041C File Offset: 0x00D2E61C
		public double GetRangeMarkSize(int nodeId)
		{
			NodeTrackMark nodeTrackMarkCreator = this.TrackMarkController.GetNodeTrackMarkCreator(nodeId);
			if (nodeTrackMarkCreator == null)
			{
				return 0.0;
			}
			return (double)nodeTrackMarkCreator.MarkRange;
		}

		// Token: 0x0602F48B RID: 193675 RVA: 0x00D3044C File Offset: 0x00D2E64C
		public double? GetRangeMarkShowDis(int nodeId)
		{
			NodeTrackMark nodeTrackMarkCreator = this.TrackMarkController.GetNodeTrackMarkCreator(nodeId);
			float? num = (nodeTrackMarkCreator != null) ? new float?(nodeTrackMarkCreator.RangeMarkShowDis) : null;
			if (num == null)
			{
				return null;
			}
			return new double?((double)num.GetValueOrDefault());
		}

		// Token: 0x0602F48C RID: 193676 RVA: 0x00D304A0 File Offset: 0x00D2E6A0
		public bool CheckCanShow([Nullable(new byte[]
		{
			2,
			1
		})] Func<BehaviorNodeBase, bool> nodeExtraCondition = null)
		{
			if (this.Blackboard.ContainTag(EBehaviorTreeTag.SuspendingCanShow))
			{
				return true;
			}
			IReadOnlyDictionary<int, BehaviorNodeBase> allNodes = this.Blackboard.GetAllNodes();
			if (allNodes.Count == 0)
			{
				return false;
			}
			foreach (BehaviorNodeBase behaviorNodeBase in allNodes.Values)
			{
				if (!behaviorNodeBase.ContainTag(EBehaviorTreeTag.HideInAllView) && behaviorNodeBase.ContainTag(EBehaviorTreeTag.CanShow) && (nodeExtraCondition == null || nodeExtraCondition(behaviorNodeBase)))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0602F48D RID: 193677 RVA: 0x00D30534 File Offset: 0x00D2E734
		public bool CheckCanShowTrackExpression()
		{
			return this.CheckCanShow((BehaviorNodeBase node) => !node.ContainTag(EBehaviorTreeTag.HideTrackExpression));
		}

		// Token: 0x0602F48E RID: 193678 RVA: 0x00D3055B File Offset: 0x00D2E75B
		public void CreateMapMarks()
		{
			this.TrackMarkController.CreateMapMarks();
		}

		// Token: 0x0602F48F RID: 193679 RVA: 0x00D30568 File Offset: 0x00D2E768
		public Blackboard GetBlackBoard()
		{
			return this.Blackboard;
		}

		// Token: 0x0602F490 RID: 193680 RVA: 0x00D30570 File Offset: 0x00D2E770
		public BehaviorTreeViewShowData CreateShowData()
		{
			return this.Blackboard.CreateShowData(true);
		}

		// Token: 0x0602F491 RID: 193681 RVA: 0x00D3057E File Offset: 0x00D2E77E
		public void UpdateLevelPlayConditionalMarks()
		{
			this.TrackMarkController.UpdateLevelPlayConditionalMarks();
		}

		// Token: 0x17005F6E RID: 24430
		// (get) Token: 0x0602F492 RID: 193682 RVA: 0x00D3058B File Offset: 0x00D2E78B
		// (set) Token: 0x0602F493 RID: 193683 RVA: 0x00D30598 File Offset: 0x00D2E798
		public long? BoundParentTreeId
		{
			get
			{
				return this.Blackboard.BoundParentTreeId;
			}
			set
			{
				this.Blackboard.BoundParentTreeId = value;
			}
		}

		// Token: 0x17005F6F RID: 24431
		// (get) Token: 0x0602F494 RID: 193684 RVA: 0x00D305A6 File Offset: 0x00D2E7A6
		// (set) Token: 0x0602F495 RID: 193685 RVA: 0x00D305B3 File Offset: 0x00D2E7B3
		public int? BoundParentNodeId
		{
			get
			{
				return this.Blackboard.BoundParentNodeId;
			}
			set
			{
				this.Blackboard.BoundParentNodeId = value;
			}
		}

		// Token: 0x17005F70 RID: 24432
		// (get) Token: 0x0602F496 RID: 193686 RVA: 0x00D305C1 File Offset: 0x00D2E7C1
		public bool IsValid
		{
			get
			{
				return this.IsValidInternal;
			}
		}

		// Token: 0x0602F497 RID: 193687 RVA: 0x00D305CC File Offset: 0x00D2E7CC
		private void OnAddEvent()
		{
			EventSystem.Instance.Add(EEventName.ActiveBattleView, new Action(this.OnBattleViewActive));
			EventSystem.Instance.Add(EEventName.DisActiveBattleView, new Action(this.OnBattleViewHide));
			EventSystem.Instance.Add(EEventName.GeneralLogicTreeApplyExpressionOccupation, new Action<long>(this.OnBtApplyExpressionOccupation));
			EventSystem.Instance.Add(EEventName.GeneralLogicTreeReleaseExpressionOccupation, new Action<long>(this.OnBtReleaseExpressionOccupation));
			EventSystem.Instance.AddWithTarget<GeneralContext, ChildQuestNodeStatus, ChildQuestNodeStatus, ENodeStatusUpdateReason>(this.Blackboard, EEventName.OnLogicTreeChildQuestNodeStatusChange, new Action<GeneralContext, ChildQuestNodeStatus, ChildQuestNodeStatus, ENodeStatusUpdateReason>(this.OnChildQuestNodeStatusChange));
			EventSystem.Instance.AddWithTarget<GeneralContext, ChildQuestNodeProgress>(this.Blackboard, EEventName.OnLogicTreeNodeProgressChange, new Action<GeneralContext, ChildQuestNodeProgress>(this.OnNodeProgressChanged));
			EventSystem.Instance.AddWithTarget<GeneralContext, NodeStatus, NodeStatus, ENodeStatusUpdateReason>(this.Blackboard, EEventName.OnLogicTreeNodeStatusChange, new Action<GeneralContext, NodeStatus, NodeStatus, ENodeStatusUpdateReason>(this.OnNodeStatusUpdate));
			EventSystem.Instance.AddWithTarget<long, int, EBehaviorTreeSuspendType>(this.Blackboard, EEventName.GeneralLogicTreeSuspend, new Action<long, int, EBehaviorTreeSuspendType>(this.OnNodeSuspend));
			EventSystem.Instance.AddWithTarget(this.Blackboard, EEventName.GeneralLogicTreeCancelSuspend, new Action<long>(this.OnNodeCancelSuspend));
		}

		// Token: 0x0602F498 RID: 193688 RVA: 0x00D306F4 File Offset: 0x00D2E8F4
		private void OnRemoveEvent()
		{
			EventSystem.Instance.Remove(EEventName.ActiveBattleView, new Action(this.OnBattleViewActive));
			EventSystem.Instance.Remove(EEventName.DisActiveBattleView, new Action(this.OnBattleViewHide));
			EventSystem.Instance.Remove(EEventName.GeneralLogicTreeApplyExpressionOccupation, new Action<long>(this.OnBtApplyExpressionOccupation));
			EventSystem.Instance.Remove(EEventName.GeneralLogicTreeReleaseExpressionOccupation, new Action<long>(this.OnBtReleaseExpressionOccupation));
			EventSystem.Instance.RemoveWithTarget(this.Blackboard, EEventName.OnLogicTreeChildQuestNodeStatusChange, new Action<GeneralContext, ChildQuestNodeStatus, ChildQuestNodeStatus, ENodeStatusUpdateReason>(this.OnChildQuestNodeStatusChange));
			EventSystem.Instance.RemoveWithTarget(this.Blackboard, EEventName.OnLogicTreeNodeProgressChange, new Action<GeneralContext, ChildQuestNodeProgress>(this.OnNodeProgressChanged));
			EventSystem.Instance.RemoveWithTarget(this.Blackboard, EEventName.OnLogicTreeNodeStatusChange, new Action<GeneralContext, NodeStatus, NodeStatus, ENodeStatusUpdateReason>(this.OnNodeStatusUpdate));
			EventSystem.Instance.RemoveWithTarget(this.Blackboard, EEventName.GeneralLogicTreeSuspend, new Action<long, int, EBehaviorTreeSuspendType>(this.OnNodeSuspend));
			EventSystem.Instance.RemoveWithTarget(this.Blackboard, EEventName.GeneralLogicTreeCancelSuspend, new Action<long>(this.OnNodeCancelSuspend));
		}

		// Token: 0x0602F499 RID: 193689 RVA: 0x00D3081C File Offset: 0x00D2EA1C
		private void OnNodeStatusUpdate(GeneralContext context, NodeStatus oldStatus, NodeStatus newStatus, ENodeStatusUpdateReason reason)
		{
			if (context.Type.GetValueOrDefault() != EGeneralContextType.GeneralLogicTree)
			{
				return;
			}
			BehaviorNodeBase node = this.Blackboard.GetNode(new int?(((GeneralLogicTreeContext)context).NodeId));
			if (node == null)
			{
				return;
			}
			this.TrackTextController.UpdateOnNodeStatusChange(node, newStatus, reason);
			if (node.ContainTag(EBehaviorTreeTag.HideTrackExpression))
			{
				return;
			}
			this.TrackMarkController.UpdateOnNodeStatusChange(this.Blackboard, node, newStatus);
			if (this.Blackboard.IsTrackBoundToParent && (newStatus == NodeStatus.Activated || newStatus == NodeStatus.CompletedSuccess || newStatus == NodeStatus.CompletedFailed))
			{
				BaseBehaviorTree behaviorTree = GeneralLogicTreeModel.Instance.GetBehaviorTree(new long?(this.Blackboard.BoundParentTreeId.Value), false);
				if (behaviorTree != null)
				{
					BindingExpressionComponentHolder bindingExpressionHolder = behaviorTree.BindingExpressionHolder;
					int? num = (bindingExpressionHolder != null) ? new int?(bindingExpressionHolder.GetCurFocusLevelPlayId()) : null;
					int treeConfigId = this.Blackboard.TreeConfigId;
					if (num.GetValueOrDefault() == treeConfigId & num != null)
					{
						BindingExpressionComponentHolder bindingExpressionHolder2 = behaviorTree.BindingExpressionHolder;
						if (bindingExpressionHolder2 != null)
						{
							bindingExpressionHolder2.OnBindingNodeTextUpdate();
						}
						BindingExpressionComponentHolder bindingExpressionHolder3 = behaviorTree.BindingExpressionHolder;
						if (bindingExpressionHolder3 == null)
						{
							return;
						}
						bindingExpressionHolder3.OnBindingNodeTrackMarkUpdate();
					}
				}
			}
		}

		// Token: 0x0602F49A RID: 193690 RVA: 0x00D3092C File Offset: 0x00D2EB2C
		private void OnChildQuestNodeStatusChange(GeneralContext context, ChildQuestNodeStatus oldStatus, ChildQuestNodeStatus newStatus, ENodeStatusUpdateReason reason)
		{
			if (!(context is GeneralLogicTreeContext) || !(context.Type == EGeneralContextType.GeneralLogicTree))
			{
				return;
			}
			BehaviorNodeBase node = this.Blackboard.GetNode(new int?(((GeneralLogicTreeContext)context).NodeId));
			ChildQuestNodeBase childQuestNodeBase = node as ChildQuestNodeBase;
			if (childQuestNodeBase == null || !node.ContainTag(EBehaviorTreeTag.CanShow) || node.ContainTag(EBehaviorTreeTag.HideTrackExpression))
			{
				return;
			}
			bool flag2;
			if (reason == ENodeStatusUpdateReason.Recover)
			{
				bool flag = newStatus - ChildQuestNodeStatus.CqnsEnterAction <= 1;
				flag2 = flag;
			}
			else
			{
				flag2 = ((node.ShowTipBeforeEnterActions && newStatus == ChildQuestNodeStatus.CqnsEnterAction) || (!node.ShowTipBeforeEnterActions && newStatus == ChildQuestNodeStatus.CqnsProgress));
			}
			bool flag3 = newStatus == ChildQuestNodeStatus.CqnsFinished;
			this.TrackMarkController.UpdateOnChildQuestNodeStatusChange(childQuestNodeBase, flag2, flag3);
			this.CheckPointEffectController.UpdateOnChildQuestNodeStatusChange(childQuestNodeBase, flag2, flag3);
			this.TrackEffectController.UpdateOnChildQuestNodeStatusChange(childQuestNodeBase, flag2, flag3);
			if (this.Blackboard.IsBindingLevelPlayTrack)
			{
				this.EnableTrack(false, ESetTrackReason.None, false);
			}
			if (this.Blackboard.IsTrackBoundToParent && (flag2 || flag3))
			{
				BaseBehaviorTree behaviorTree = GeneralLogicTreeModel.Instance.GetBehaviorTree(new long?(this.Blackboard.BoundParentTreeId.Value), false);
				if (behaviorTree != null)
				{
					BindingExpressionComponentHolder bindingExpressionHolder = behaviorTree.BindingExpressionHolder;
					int? num = (bindingExpressionHolder != null) ? new int?(bindingExpressionHolder.GetCurFocusLevelPlayId()) : null;
					int treeConfigId = this.Blackboard.TreeConfigId;
					if (num.GetValueOrDefault() == treeConfigId & num != null)
					{
						BindingExpressionComponentHolder bindingExpressionHolder2 = behaviorTree.BindingExpressionHolder;
						if (bindingExpressionHolder2 == null)
						{
							return;
						}
						bindingExpressionHolder2.OnBindingNodeTrackMarkUpdate();
					}
				}
			}
		}

		// Token: 0x0602F49B RID: 193691 RVA: 0x00D30AA3 File Offset: 0x00D2ECA3
		private void OnNodeSuspend(long treeId, int nodeId, EBehaviorTreeSuspendType suspendType)
		{
			if (this.Blackboard.TreeIncId != treeId)
			{
				return;
			}
			this.TrackTextController.OnSuspend(nodeId, suspendType);
			this.TrackMarkController.OnSuspend(suspendType);
		}

		// Token: 0x0602F49C RID: 193692 RVA: 0x00D30ACD File Offset: 0x00D2ECCD
		private void OnNodeCancelSuspend(long treeId)
		{
			if (this.Blackboard.TreeIncId != treeId)
			{
				return;
			}
			this.TrackTextController.OnCancelSuspend();
			this.TrackMarkController.OnCancelSuspend();
		}

		// Token: 0x0602F49D RID: 193693 RVA: 0x00D30AF4 File Offset: 0x00D2ECF4
		private void OnBattleViewActive()
		{
			this.TrackEffectController.OnBattleViewActive();
		}

		// Token: 0x0602F49E RID: 193694 RVA: 0x00D30B01 File Offset: 0x00D2ED01
		private void OnBattleViewHide()
		{
			this.TrackEffectController.OnBattleViewHide();
		}

		// Token: 0x0602F49F RID: 193695 RVA: 0x00D30B10 File Offset: 0x00D2ED10
		private void OnNodeProgressChanged(GeneralContext context, ChildQuestNodeProgress progress)
		{
			GeneralLogicTreeContext generalLogicTreeContext = context as GeneralLogicTreeContext;
			if (generalLogicTreeContext == null || !(context.Type == EGeneralContextType.GeneralLogicTree) || progress == null)
			{
				return;
			}
			if (generalLogicTreeContext.TreeIncId != this.Blackboard.TreeIncId)
			{
				return;
			}
			IReadOnlyList<int> readOnlyList = null;
			ChildQuestNodeProgress.ProgressOneofCase progressCase = progress.ProgressCase;
			if (progressCase <= ChildQuestNodeProgress.ProgressOneofCase.MonsterCreator)
			{
				if (progressCase == ChildQuestNodeProgress.ProgressOneofCase.Kill)
				{
					readOnlyList = progress.Kill.MonId;
					goto IL_DA;
				}
				if (progressCase != ChildQuestNodeProgress.ProgressOneofCase.MonsterCreator)
				{
					goto IL_DA;
				}
				List<int> list = new List<int>();
				readOnlyList = list;
				using (IEnumerator<MonsterCreatorProgressSlot> enumerator = progress.MonsterCreator.Slots.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						MonsterCreatorProgressSlot monsterCreatorProgressSlot = enumerator.Current;
						list.AddRange(monsterCreatorProgressSlot.KillMonIds);
					}
					goto IL_DA;
				}
			}
			else
			{
				if (progressCase == ChildQuestNodeProgress.ProgressOneofCase.Interact)
				{
					readOnlyList = progress.Interact.NpcId;
					goto IL_DA;
				}
				if (progressCase != ChildQuestNodeProgress.ProgressOneofCase.EntityStateList)
				{
					goto IL_DA;
				}
			}
			readOnlyList = progress.EntityStateList.EntityId;
			IL_DA:
			NodeTrackMark nodeTrackMarkCreator = this.TrackMarkController.GetNodeTrackMarkCreator(generalLogicTreeContext.NodeId);
			if (readOnlyList != null && nodeTrackMarkCreator != null)
			{
				nodeTrackMarkCreator.OnNodeProgressChanged(readOnlyList);
			}
		}

		// Token: 0x0602F4A0 RID: 193696 RVA: 0x00D30C28 File Offset: 0x00D2EE28
		private void OnBtApplyExpressionOccupation(long treeIncId)
		{
			bool bSelf = this.Blackboard.TreeIncId == treeIncId;
			this.TrackTextController.OnBtApplyExpressionOccupation(bSelf);
			this.TrackMarkController.OnBtApplyExpressionOccupation(bSelf);
			this.TrackEffectController.OnBtApplyExpressionOccupation(bSelf);
			this.CheckPointEffectController.OnBtApplyExpressionOccupation(bSelf);
		}

		// Token: 0x0602F4A1 RID: 193697 RVA: 0x00D30C74 File Offset: 0x00D2EE74
		private void OnBtReleaseExpressionOccupation(long treeIncId)
		{
			bool bSelf = this.Blackboard.TreeIncId == treeIncId;
			this.TrackTextController.OnBtReleaseExpressionOccupation(bSelf);
			this.TrackMarkController.OnBtReleaseExpressionOccupation(bSelf);
			this.TrackEffectController.OnBtReleaseExpressionOccupation(bSelf);
			this.CheckPointEffectController.OnBtReleaseExpressionOccupation(bSelf);
		}

		// Token: 0x0602F4A2 RID: 193698 RVA: 0x00D30CC0 File Offset: 0x00D2EEC0
		private double CalculateTrackDistance(global::Vector playerLocation, global::Vector trackPosition)
		{
			return Math.Round(global::Vector.Distance(trackPosition, playerLocation) * 0.009999999776482582);
		}

		// Token: 0x04019142 RID: 102722
		private readonly TrackTextExpressController TrackTextController;

		// Token: 0x04019143 RID: 102723
		private readonly TrackEffectExpressController TrackEffectController;

		// Token: 0x04019144 RID: 102724
		private readonly TrackMarkExpressController TrackMarkController;

		// Token: 0x04019145 RID: 102725
		private readonly CheckPointEffectController CheckPointEffectController;

		// Token: 0x04019146 RID: 102726
		private bool IsValidInternal;

		// Token: 0x04019147 RID: 102727
		private readonly Blackboard Blackboard;
	}
}
