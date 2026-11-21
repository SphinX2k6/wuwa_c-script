using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Module.GeneralLogicTree.BehaviorNode.ChildQuestNode;

// Token: 0x02001223 RID: 4643
[NullableContext(1)]
[Nullable(0)]
public class TrackMarkExpressController
{
	// Token: 0x0600B8AC RID: 47276 RVA: 0x003670B7 File Offset: 0x003652B7
	public TrackMarkExpressController(Blackboard Blackboard)
	{
	}

	// Token: 0x0600B8AD RID: 47277 RVA: 0x003670D1 File Offset: 0x003652D1
	internal static bool IsLogicBtNodeType(EBtNode type)
	{
		return type == EBtNode.ConditionSelector || type == EBtNode.ParallelSelect || type == EBtNode.Sequence || type == EBtNode.Select;
	}

	// Token: 0x0600B8AE RID: 47278 RVA: 0x003670E8 File Offset: 0x003652E8
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

	// Token: 0x0600B8AF RID: 47279 RVA: 0x003671AC File Offset: 0x003653AC
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

	// Token: 0x0600B8B0 RID: 47280 RVA: 0x00367294 File Offset: 0x00365494
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

	// Token: 0x0600B8B1 RID: 47281 RVA: 0x00367340 File Offset: 0x00365540
	public void Clear()
	{
		foreach (NodeTrackMark nodeTrackMark in this.TrackMarks.Values)
		{
			nodeTrackMark.Destroy();
		}
		this.TrackMarks.Clear();
	}

	// Token: 0x0600B8B2 RID: 47282 RVA: 0x003673A0 File Offset: 0x003655A0
	[NullableContext(2)]
	public NodeTrackMark GetNodeTrackMarkCreator(int nodeId)
	{
		return this.TrackMarks.GetValueOrDefault(nodeId);
	}

	// Token: 0x0600B8B3 RID: 47283 RVA: 0x003673AE File Offset: 0x003655AE
	public Dictionary<int, NodeTrackMark> GetAllTrackMarkCreator()
	{
		return this.TrackMarks;
	}

	// Token: 0x0600B8B4 RID: 47284 RVA: 0x003673B8 File Offset: 0x003655B8
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

	// Token: 0x0600B8B5 RID: 47285 RVA: 0x0036745C File Offset: 0x0036565C
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

	// Token: 0x0600B8B6 RID: 47286 RVA: 0x003674D8 File Offset: 0x003656D8
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

	// Token: 0x0600B8B7 RID: 47287 RVA: 0x0036756C File Offset: 0x0036576C
	public void EnableTrack(bool value)
	{
		foreach (NodeTrackMark nodeTrackMark in this.TrackMarks.Values)
		{
			nodeTrackMark.EnableTrack(value);
		}
	}

	// Token: 0x0600B8B8 RID: 47288 RVA: 0x003675C4 File Offset: 0x003657C4
	public void CreateMapMarks()
	{
		foreach (NodeTrackMark nodeTrackMark in this.TrackMarks.Values)
		{
			nodeTrackMark.CreateMapMarks();
		}
	}

	// Token: 0x0600B8B9 RID: 47289 RVA: 0x0036761C File Offset: 0x0036581C
	public void UpdateLevelPlayConditionalMarks()
	{
		foreach (NodeTrackMark nodeTrackMark in this.TrackMarks.Values)
		{
			nodeTrackMark.UpdateLevelPlayConditionalMark();
		}
	}

	// Token: 0x0600B8BA RID: 47290 RVA: 0x00367674 File Offset: 0x00365874
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

	// Token: 0x0600B8BB RID: 47291 RVA: 0x003676F0 File Offset: 0x003658F0
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

	// Token: 0x0600B8BC RID: 47292 RVA: 0x0036773C File Offset: 0x0036593C
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

	// Token: 0x0600B8BD RID: 47293 RVA: 0x00367798 File Offset: 0x00365998
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

	// Token: 0x0600B8BE RID: 47294 RVA: 0x003677F4 File Offset: 0x003659F4
	public void OnSuspend(EBehaviorTreeSuspendType suspendType)
	{
		this.OnBtApplyExpressionOccupation(false);
	}

	// Token: 0x0600B8BF RID: 47295 RVA: 0x003677FD File Offset: 0x003659FD
	public void OnCancelSuspend()
	{
		if (!this.<Blackboard>P.IsOccupied)
		{
			this.OnBtReleaseExpressionOccupation(false);
		}
	}

	// Token: 0x0600B8C0 RID: 47296 RVA: 0x00367813 File Offset: 0x00365A13
	private void NodeTrackMarkStart(int nodeId, Blackboard blackBoard, ITrackTarget trackTarget, bool bOccupied)
	{
		this.TryAddNodeTrackMarkCreator(nodeId, blackBoard, trackTarget).OnNodeStart(bOccupied);
	}

	// Token: 0x0600B8C1 RID: 47297 RVA: 0x00367825 File Offset: 0x00365A25
	private void NodeTrackMarkEnd(int nodeId)
	{
		NodeTrackMark nodeTrackMarkCreator = this.GetNodeTrackMarkCreator(nodeId);
		if (nodeTrackMarkCreator != null)
		{
			nodeTrackMarkCreator.OnNodeEnd();
		}
		this.RemoveNodeTrackMarkCreator(nodeId);
	}

	// Token: 0x0600B8C2 RID: 47298 RVA: 0x00367840 File Offset: 0x00365A40
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

	// Token: 0x0600B8C3 RID: 47299 RVA: 0x003678A5 File Offset: 0x00365AA5
	private void RemoveNodeTrackMarkCreator(int nodeId)
	{
		NodeTrackMark nodeTrackMarkCreator = this.GetNodeTrackMarkCreator(nodeId);
		if (nodeTrackMarkCreator != null)
		{
			nodeTrackMarkCreator.Destroy();
		}
		this.TrackMarks.Remove(nodeId);
	}

	// Token: 0x04006A49 RID: 27209
	[CompilerGenerated]
	private Blackboard <Blackboard>P = Blackboard;

	// Token: 0x04006A4A RID: 27210
	private readonly Dictionary<int, NodeTrackMark> TrackMarks = new Dictionary<int, NodeTrackMark>();
}
