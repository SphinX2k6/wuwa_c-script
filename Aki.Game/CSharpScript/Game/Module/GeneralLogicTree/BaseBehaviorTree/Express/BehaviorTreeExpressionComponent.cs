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
	// Token: 0x020059ED RID: 23021
	[NullableContext(1)]
	[Nullable(0)]
	public class BehaviorTreeExpressionComponent
	{
		// Token: 0x0603A556 RID: 238934 RVA: 0x00DE0868 File Offset: 0x00DDEA68
		public BehaviorTreeExpressionComponent(Blackboard blackboard)
		{
			this.Blackboard = blackboard;
			this.TrackTextController = new TrackTextExpressController(blackboard);
			this.TrackMarkController = new TrackMarkExpressController(blackboard);
			this.TrackEffectController = new TrackEffectExpressController(this, blackboard);
			this.CheckPointEffectController = new CheckPointEffectController(blackboard);
		}

		// Token: 0x0603A557 RID: 238935 RVA: 0x00DE08A8 File Offset: 0x00DDEAA8
		public void Init()
		{
			this.OnAddEvent();
			this.IsValidInternal = true;
		}

		// Token: 0x0603A558 RID: 238936 RVA: 0x00DE08B8 File Offset: 0x00DDEAB8
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

		// Token: 0x0603A559 RID: 238937 RVA: 0x00DE0908 File Offset: 0x00DDEB08
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

		// Token: 0x0603A55A RID: 238938 RVA: 0x00DE0990 File Offset: 0x00DDEB90
		public void RefreshMapMark(bool bTrack)
		{
			this.TrackMarkController.EnableTrack(bTrack);
		}

		// Token: 0x0603A55B RID: 238939 RVA: 0x00DE09A0 File Offset: 0x00DDEBA0
		public void ForceSetAllMapMarksVisible(bool visible)
		{
			foreach (NodeTrackMark nodeTrackMark in this.TrackMarkController.GetAllTrackMarkCreator().Values)
			{
				nodeTrackMark.ForceSetAllMarksVisible(visible);
			}
		}

		// Token: 0x0603A55C RID: 238940 RVA: 0x00DE09FC File Offset: 0x00DDEBFC
		public void StartTextExpress(ETreeTextExpressReason reason = ETreeTextExpressReason.None)
		{
			this.TrackTextController.StartTextExpress(reason);
		}

		// Token: 0x0603A55D RID: 238941 RVA: 0x00DE0A0A File Offset: 0x00DDEC0A
		public void EndTextExpress(ETreeTextExpressReason reason = ETreeTextExpressReason.None)
		{
			this.TrackTextController.EndTextExpress(reason);
		}

		// Token: 0x0603A55E RID: 238942 RVA: 0x00DE0A18 File Offset: 0x00DDEC18
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

		// Token: 0x0603A55F RID: 238943 RVA: 0x00DE0A34 File Offset: 0x00DDEC34
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

		// Token: 0x0603A560 RID: 238944 RVA: 0x00DE0B14 File Offset: 0x00DDED14
		public int? GetTrackAreaInfo(int nodeId)
		{
			NodeTrackMark nodeTrackMarkCreator = this.TrackMarkController.GetNodeTrackMarkCreator(nodeId);
			if (nodeTrackMarkCreator == null)
			{
				return null;
			}
			return nodeTrackMarkCreator.GetTrackAreaInfo();
		}

		// Token: 0x0603A561 RID: 238945 RVA: 0x00DE0B40 File Offset: 0x00DDED40
		public int? GetDefaultMark(int nodeId)
		{
			NodeTrackMark nodeTrackMarkCreator = this.TrackMarkController.GetNodeTrackMarkCreator(nodeId);
			if (nodeTrackMarkCreator == null)
			{
				return null;
			}
			return nodeTrackMarkCreator.DefaultMapMarkId;
		}

		// Token: 0x0603A562 RID: 238946 RVA: 0x00DE0B6C File Offset: 0x00DDED6C
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

		// Token: 0x0603A563 RID: 238947 RVA: 0x00DE0BB0 File Offset: 0x00DDEDB0
		public double GetRangeMarkSize(int nodeId)
		{
			NodeTrackMark nodeTrackMarkCreator = this.TrackMarkController.GetNodeTrackMarkCreator(nodeId);
			if (nodeTrackMarkCreator == null)
			{
				return 0.0;
			}
			return (double)nodeTrackMarkCreator.MarkRange;
		}

		// Token: 0x0603A564 RID: 238948 RVA: 0x00DE0BE0 File Offset: 0x00DDEDE0
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

		// Token: 0x0603A565 RID: 238949 RVA: 0x00DE0C34 File Offset: 0x00DDEE34
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

		// Token: 0x0603A566 RID: 238950 RVA: 0x00DE0CC8 File Offset: 0x00DDEEC8
		public bool CheckCanShowTrackExpression()
		{
			return this.CheckCanShow((BehaviorNodeBase node) => !node.ContainTag(EBehaviorTreeTag.HideTrackExpression));
		}

		// Token: 0x0603A567 RID: 238951 RVA: 0x00DE0CEF File Offset: 0x00DDEEEF
		public void CreateMapMarks()
		{
			this.TrackMarkController.CreateMapMarks();
		}

		// Token: 0x0603A568 RID: 238952 RVA: 0x00DE0CFC File Offset: 0x00DDEEFC
		public Blackboard GetBlackBoard()
		{
			return this.Blackboard;
		}

		// Token: 0x0603A569 RID: 238953 RVA: 0x00DE0D04 File Offset: 0x00DDEF04
		public BehaviorTreeViewShowData CreateShowData()
		{
			return this.Blackboard.CreateShowData(true);
		}

		// Token: 0x0603A56A RID: 238954 RVA: 0x00DE0D12 File Offset: 0x00DDEF12
		public void UpdateLevelPlayConditionalMarks()
		{
			this.TrackMarkController.UpdateLevelPlayConditionalMarks();
		}

		// Token: 0x17008BA1 RID: 35745
		// (get) Token: 0x0603A56B RID: 238955 RVA: 0x00DE0D1F File Offset: 0x00DDEF1F
		// (set) Token: 0x0603A56C RID: 238956 RVA: 0x00DE0D2C File Offset: 0x00DDEF2C
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

		// Token: 0x17008BA2 RID: 35746
		// (get) Token: 0x0603A56D RID: 238957 RVA: 0x00DE0D3A File Offset: 0x00DDEF3A
		// (set) Token: 0x0603A56E RID: 238958 RVA: 0x00DE0D47 File Offset: 0x00DDEF47
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

		// Token: 0x17008BA3 RID: 35747
		// (get) Token: 0x0603A56F RID: 238959 RVA: 0x00DE0D55 File Offset: 0x00DDEF55
		public bool IsValid
		{
			get
			{
				return this.IsValidInternal;
			}
		}

		// Token: 0x0603A570 RID: 238960 RVA: 0x00DE0D60 File Offset: 0x00DDEF60
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

		// Token: 0x0603A571 RID: 238961 RVA: 0x00DE0E88 File Offset: 0x00DDF088
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

		// Token: 0x0603A572 RID: 238962 RVA: 0x00DE0FB0 File Offset: 0x00DDF1B0
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

		// Token: 0x0603A573 RID: 238963 RVA: 0x00DE10C0 File Offset: 0x00DDF2C0
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

		// Token: 0x0603A574 RID: 238964 RVA: 0x00DE1237 File Offset: 0x00DDF437
		private void OnNodeSuspend(long treeId, int nodeId, EBehaviorTreeSuspendType suspendType)
		{
			if (this.Blackboard.TreeIncId != treeId)
			{
				return;
			}
			this.TrackTextController.OnSuspend(nodeId, suspendType);
			this.TrackMarkController.OnSuspend(suspendType);
		}

		// Token: 0x0603A575 RID: 238965 RVA: 0x00DE1261 File Offset: 0x00DDF461
		private void OnNodeCancelSuspend(long treeId)
		{
			if (this.Blackboard.TreeIncId != treeId)
			{
				return;
			}
			this.TrackTextController.OnCancelSuspend();
			this.TrackMarkController.OnCancelSuspend();
		}

		// Token: 0x0603A576 RID: 238966 RVA: 0x00DE1288 File Offset: 0x00DDF488
		private void OnBattleViewActive()
		{
			this.TrackEffectController.OnBattleViewActive();
		}

		// Token: 0x0603A577 RID: 238967 RVA: 0x00DE1295 File Offset: 0x00DDF495
		private void OnBattleViewHide()
		{
			this.TrackEffectController.OnBattleViewHide();
		}

		// Token: 0x0603A578 RID: 238968 RVA: 0x00DE12A4 File Offset: 0x00DDF4A4
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

		// Token: 0x0603A579 RID: 238969 RVA: 0x00DE13BC File Offset: 0x00DDF5BC
		private void OnBtApplyExpressionOccupation(long treeIncId)
		{
			bool bSelf = this.Blackboard.TreeIncId == treeIncId;
			this.TrackTextController.OnBtApplyExpressionOccupation(bSelf);
			this.TrackMarkController.OnBtApplyExpressionOccupation(bSelf);
			this.TrackEffectController.OnBtApplyExpressionOccupation(bSelf);
			this.CheckPointEffectController.OnBtApplyExpressionOccupation(bSelf);
		}

		// Token: 0x0603A57A RID: 238970 RVA: 0x00DE1408 File Offset: 0x00DDF608
		private void OnBtReleaseExpressionOccupation(long treeIncId)
		{
			bool bSelf = this.Blackboard.TreeIncId == treeIncId;
			this.TrackTextController.OnBtReleaseExpressionOccupation(bSelf);
			this.TrackMarkController.OnBtReleaseExpressionOccupation(bSelf);
			this.TrackEffectController.OnBtReleaseExpressionOccupation(bSelf);
			this.CheckPointEffectController.OnBtReleaseExpressionOccupation(bSelf);
		}

		// Token: 0x0603A57B RID: 238971 RVA: 0x00DE1454 File Offset: 0x00DDF654
		private double CalculateTrackDistance(global::Vector playerLocation, global::Vector trackPosition)
		{
			return Math.Round(global::Vector.Distance(trackPosition, playerLocation) * 0.009999999776482582);
		}

		// Token: 0x0401E6A3 RID: 124579
		private readonly TrackTextExpressController TrackTextController;

		// Token: 0x0401E6A4 RID: 124580
		private readonly TrackEffectExpressController TrackEffectController;

		// Token: 0x0401E6A5 RID: 124581
		private readonly TrackMarkExpressController TrackMarkController;

		// Token: 0x0401E6A6 RID: 124582
		private readonly CheckPointEffectController CheckPointEffectController;

		// Token: 0x0401E6A7 RID: 124583
		private bool IsValidInternal;

		// Token: 0x0401E6A8 RID: 124584
		private readonly Blackboard Blackboard;
	}
}
