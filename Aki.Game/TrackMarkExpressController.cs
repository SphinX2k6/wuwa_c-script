using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Module.GeneralLogicTree.BehaviorNode.ChildQuestNode;

// Token: 0x02001D61 RID: 7521
[NullableContext(1)]
[Nullable(0)]
public class TrackMarkExpressController
{
	// Token: 0x0600E48F RID: 58511 RVA: 0x0035B507 File Offset: 0x00359707
	public TrackMarkExpressController(Blackboard Blackboard)
	{
	}

	// Token: 0x0600E490 RID: 58512 RVA: 0x0035B521 File Offset: 0x00359721
	internal static bool IsLogicBtNodeType(EBtNode type)
	{
		return type == EBtNode.ConditionSelector || type == EBtNode.ParallelSelect || type == EBtNode.Sequence || type == EBtNode.Select;
	}

	// Token: 0x0600E491 RID: 58513 RVA: 0x0035B538 File Offset: 0x00359738
	internal unsafe static bool SanitizeOverrideChild(bool requested, Blackboard blackBoard, int nodeId, int treeConfigId)
	{
		if (!requested)
		{
			return false;
		}
		IBtNode nodeConfig = blackBoard.GetNodeConfig(nodeId);
		if (nodeConfig != null && TrackMarkExpressController.IsLogicBtNodeType(nodeConfig.Type))
		{
			return true;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.GeneralLogicTree;
		ELogAuthor author = ELogAuthor.HYF;
		string message = "OverrideChildNodeTrackTarget 仅可配置在逻辑节点上，将被忽略";
		<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("行为树Id", treeConfigId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("节点Id", nodeId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("节点类型", (nodeConfig != null) ? new EBtNode?(nodeConfig.Type) : null);
		instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		return false;
	}

	// Token: 0x0600E492 RID: 58514 RVA: 0x0035B5FC File Offset: 0x003597FC
	internal static IOutOfRangeRuntime BuildOutOfRangeRuntimeFromLocations(IOutOfRangeTrackTarget cfg, Blackboard blackBoard, int nodeId, int treeConfigId)
	{
		global::Vector value = global::Vector.Create((double)cfg.TrackPos.X.GetValueOrDefault(), (double)cfg.TrackPos.Y.GetValueOrDefault(), (double)cfg.TrackPos.Z.GetValueOrDefault());
		global::Vector center = global::Vector.Create((double)cfg.Center.X.GetValueOrDefault(), (double)cfg.Center.Y.GetValueOrDefault(), (double)cfg.Center.Z.GetValueOrDefault());
		bool overrideChildNodeTrackTarget = TrackMarkExpressController.SanitizeOverrideChild(cfg.OverrideChildNodeTrackTarget.GetValueOrDefault(), blackBoard, nodeId, treeConfigId);
		return new IOutOfRangeRuntime
		{
			Targets = new List<TEntityIdOrPos>
			{
				value
			},
			Center = center,
			RadiusSq = (double)cfg.Radius * (double)cfg.Radius,
			OverrideChildNodeTrackTarget = overrideChildNodeTrackTarget
		};
	}

	// Token: 0x0600E493 RID: 58515 RVA: 0x0035B6E4 File Offset: 0x003598E4
	internal static IOutOfRangeRuntime BuildOutOfRangeRuntimeFromEntities(IOutOfRangeTrackEntity cfg, Blackboard blackBoard, int nodeId, int treeConfigId)
	{
		global::Vector center = global::Vector.Create((double)cfg.Center.X.GetValueOrDefault(), (double)cfg.Center.Y.GetValueOrDefault(), (double)cfg.Center.Z.GetValueOrDefault());
		bool overrideChildNodeTrackTarget = TrackMarkExpressController.SanitizeOverrideChild(cfg.OverrideChildNodeTrackTarget.GetValueOrDefault(), blackBoard, nodeId, treeConfigId);
		return new IOutOfRangeRuntime
		{
			Targets = new List<TEntityIdOrPos>
			{
				cfg.TrackEntityId
			},
			Center = center,
			RadiusSq = (double)cfg.Radius * (double)cfg.Radius,
			OverrideChildNodeTrackTarget = overrideChildNodeTrackTarget
		};
	}

	// Token: 0x0600E494 RID: 58516 RVA: 0x0035B790 File Offset: 0x00359990
	public void Clear()
	{
		foreach (NodeTrackMark nodeTrackMark in this.TrackMarks.Values)
		{
			nodeTrackMark.Destroy();
		}
		this.TrackMarks.Clear();
	}

	// Token: 0x0600E495 RID: 58517 RVA: 0x0035B7F0 File Offset: 0x003599F0
	[NullableContext(2)]
	public NodeTrackMark GetNodeTrackMarkCreator(int nodeId)
	{
		return this.TrackMarks.GetValueOrDefault(nodeId);
	}

	// Token: 0x0600E496 RID: 58518 RVA: 0x0035B7FE File Offset: 0x003599FE
	public Dictionary<int, NodeTrackMark> GetAllTrackMarkCreator()
	{
		return this.TrackMarks;
	}

	// Token: 0x0600E497 RID: 58519 RVA: 0x0035B808 File Offset: 0x00359A08
	public bool IsSuppressedByAncestor(int nodeId)
	{
		IBtNode nodeConfig = this.<Blackboard>P.GetNodeConfig(nodeId);
		IBtNode nodeConfig2;
		for (int? num = (nodeConfig != null) ? nodeConfig.ParentNodeId : null; num != null; num = ((nodeConfig2 != null) ? nodeConfig2.ParentNodeId : null))
		{
			int? num2 = num;
			int num3 = 0;
			if (num2.GetValueOrDefault() == num3 & num2 != null)
			{
				break;
			}
			NodeTrackMark valueOrDefault = this.TrackMarks.GetValueOrDefault(num.Value);
			if (valueOrDefault != null && valueOrDefault.HasOverrideChildNode() && valueOrDefault.IsCurrentlyOutOfRange())
			{
				return true;
			}
			nodeConfig2 = this.<Blackboard>P.GetNodeConfig(num.Value);
		}
		return false;
	}

	// Token: 0x0600E498 RID: 58520 RVA: 0x0035B8AC File Offset: 0x00359AAC
	public void NotifyDescendantsRefreshSuppression(int ancestorNodeId)
	{
		foreach (KeyValuePair<int, NodeTrackMark> keyValuePair in this.TrackMarks)
		{
			int num;
			NodeTrackMark nodeTrackMark;
			keyValuePair.Deconstruct(out num, out nodeTrackMark);
			int num2 = num;
			NodeTrackMark nodeTrackMark2 = nodeTrackMark;
			if (num2 != ancestorNodeId && this.IsDescendantOf(num2, ancestorNodeId))
			{
				bool suppressedByAncestor = this.IsSuppressedByAncestor(num2);
				nodeTrackMark2.ApplyRangeState(suppressedByAncestor);
			}
		}
	}

	// Token: 0x0600E499 RID: 58521 RVA: 0x0035B928 File Offset: 0x00359B28
	private bool IsDescendantOf(int nodeId, int ancestorNodeId)
	{
		IBtNode nodeConfig = this.<Blackboard>P.GetNodeConfig(nodeId);
		IBtNode nodeConfig2;
		for (int? num = (nodeConfig != null) ? nodeConfig.ParentNodeId : null; num != null; num = ((nodeConfig2 != null) ? nodeConfig2.ParentNodeId : null))
		{
			int? num2 = num;
			int num3 = 0;
			if (num2.GetValueOrDefault() == num3 & num2 != null)
			{
				break;
			}
			num2 = num;
			if (num2.GetValueOrDefault() == ancestorNodeId & num2 != null)
			{
				return true;
			}
			nodeConfig2 = this.<Blackboard>P.GetNodeConfig(num.Value);
		}
		return false;
	}

	// Token: 0x0600E49A RID: 58522 RVA: 0x0035B9BC File Offset: 0x00359BBC
	public void EnableTrack(bool value)
	{
		foreach (NodeTrackMark nodeTrackMark in this.TrackMarks.Values)
		{
			nodeTrackMark.EnableTrack(value);
		}
	}

	// Token: 0x0600E49B RID: 58523 RVA: 0x0035BA14 File Offset: 0x00359C14
	public void CreateMapMarks()
	{
		foreach (NodeTrackMark nodeTrackMark in this.TrackMarks.Values)
		{
			nodeTrackMark.CreateMapMarks();
		}
	}

	// Token: 0x0600E49C RID: 58524 RVA: 0x0035BA6C File Offset: 0x00359C6C
	public void UpdateLevelPlayConditionalMarks()
	{
		foreach (NodeTrackMark nodeTrackMark in this.TrackMarks.Values)
		{
			nodeTrackMark.UpdateLevelPlayConditionalMark();
		}
	}

	// Token: 0x0600E49D RID: 58525 RVA: 0x0035BAC4 File Offset: 0x00359CC4
	public void UpdateOnNodeStatusChange(Blackboard blackBoard, BehaviorNodeBase node, NodeStatus newStatus)
	{
		ITrackTarget trackTarget = node.TrackTarget;
		if (trackTarget == null)
		{
			return;
		}
		switch (newStatus)
		{
		case NodeStatus.Activated:
			if (node.NodeType != EBtNode.ChildQuest && node.ContainTag(EBehaviorTreeTag.CanShow))
			{
				this.NodeTrackMarkStart(node.NodeId, blackBoard, trackTarget, blackBoard.IsOccupied);
				return;
			}
			break;
		case NodeStatus.Completing:
		case NodeStatus.Suspend:
			break;
		case NodeStatus.CompletedSuccess:
		case NodeStatus.CompletedFailed:
			this.NodeTrackMarkEnd(node.NodeId);
			return;
		case NodeStatus.Destroy:
			this.RemoveNodeTrackMarkCreator(node.NodeId);
			break;
		default:
			return;
		}
	}

	// Token: 0x0600E49E RID: 58526 RVA: 0x0035BB40 File Offset: 0x00359D40
	public void UpdateOnChildQuestNodeStatusChange(ChildQuestNodeBase node, bool bStart, bool bEnd)
	{
		ITrackTarget trackTarget = node.TrackTarget;
		if (trackTarget == null)
		{
			return;
		}
		if (bStart)
		{
			bool isOccupied = this.<Blackboard>P.IsOccupied;
			this.NodeTrackMarkStart(node.NodeId, this.<Blackboard>P, trackTarget, isOccupied);
		}
		if (bEnd)
		{
			this.NodeTrackMarkEnd(node.NodeId);
		}
	}

	// Token: 0x0600E49F RID: 58527 RVA: 0x0035BB8C File Offset: 0x00359D8C
	public void OnBtApplyExpressionOccupation(bool bSelf)
	{
		if (bSelf)
		{
			return;
		}
		foreach (NodeTrackMark nodeTrackMark in this.TrackMarks.Values)
		{
			nodeTrackMark.OnExpressOccupied();
		}
	}

	// Token: 0x0600E4A0 RID: 58528 RVA: 0x0035BBE8 File Offset: 0x00359DE8
	public void OnBtReleaseExpressionOccupation(bool bSelf)
	{
		if (bSelf)
		{
			return;
		}
		foreach (NodeTrackMark nodeTrackMark in this.TrackMarks.Values)
		{
			nodeTrackMark.OnExpressOccupationRelease();
		}
	}

	// Token: 0x0600E4A1 RID: 58529 RVA: 0x0035BC44 File Offset: 0x00359E44
	public void OnSuspend(EBehaviorTreeSuspendType suspendType)
	{
		this.OnBtApplyExpressionOccupation(false);
	}

	// Token: 0x0600E4A2 RID: 58530 RVA: 0x0035BC4D File Offset: 0x00359E4D
	public void OnCancelSuspend()
	{
		if (!this.<Blackboard>P.IsOccupied)
		{
			this.OnBtReleaseExpressionOccupation(false);
		}
	}

	// Token: 0x0600E4A3 RID: 58531 RVA: 0x0035BC63 File Offset: 0x00359E63
	private void NodeTrackMarkStart(int nodeId, Blackboard blackBoard, ITrackTarget trackTarget, bool bOccupied)
	{
		this.TryAddNodeTrackMarkCreator(nodeId, blackBoard, trackTarget).OnNodeStart(bOccupied);
	}

	// Token: 0x0600E4A4 RID: 58532 RVA: 0x0035BC75 File Offset: 0x00359E75
	private void NodeTrackMarkEnd(int nodeId)
	{
		NodeTrackMark nodeTrackMarkCreator = this.GetNodeTrackMarkCreator(nodeId);
		if (nodeTrackMarkCreator != null)
		{
			nodeTrackMarkCreator.OnNodeEnd();
		}
		this.RemoveNodeTrackMarkCreator(nodeId);
	}

	// Token: 0x0600E4A5 RID: 58533 RVA: 0x0035BC90 File Offset: 0x00359E90
	private NodeTrackMark TryAddNodeTrackMarkCreator(int nodeId, Blackboard blackBoard, ITrackTarget trackTarget)
	{
		NodeTrackMark nodeTrackMarkCreator = this.GetNodeTrackMarkCreator(nodeId);
		if (nodeTrackMarkCreator != null)
		{
			return nodeTrackMarkCreator;
		}
		int customIconId = 0;
		ChildQuestNodeBase childQuestNodeBase = blackBoard.GetNode(new int?(nodeId)) as ChildQuestNodeBase;
		if (childQuestNodeBase != null && childQuestNodeBase.CustomTrackIconId != 0)
		{
			customIconId = childQuestNodeBase.CustomTrackIconId;
		}
		NodeTrackMark nodeTrackMark = new NodeTrackMark(this, blackBoard, blackBoard.TreeIncId, blackBoard.TreeConfigId, nodeId, customIconId, trackTarget);
		this.TrackMarks[nodeId] = nodeTrackMark;
		return nodeTrackMark;
	}

	// Token: 0x0600E4A6 RID: 58534 RVA: 0x0035BCF5 File Offset: 0x00359EF5
	private void RemoveNodeTrackMarkCreator(int nodeId)
	{
		NodeTrackMark nodeTrackMarkCreator = this.GetNodeTrackMarkCreator(nodeId);
		if (nodeTrackMarkCreator != null)
		{
			nodeTrackMarkCreator.Destroy();
		}
		this.TrackMarks.Remove(nodeId);
	}

	// Token: 0x04006969 RID: 26985
	[CompilerGenerated]
	private Blackboard <Blackboard>P = Blackboard;

	// Token: 0x0400696A RID: 26986
	private readonly Dictionary<int, NodeTrackMark> TrackMarks = new Dictionary<int, NodeTrackMark>();
}
