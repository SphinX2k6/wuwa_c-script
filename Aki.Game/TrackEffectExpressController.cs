using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Module.GeneralLogicTree.BaseBehaviorTree.Express;
using CSharpScript.Game.Module.GeneralLogicTree.BehaviorNode.ChildQuestNode;

// Token: 0x0200121A RID: 4634
[NullableContext(1)]
[Nullable(0)]
public class TrackEffectExpressController
{
	// Token: 0x0600B87F RID: 47231 RVA: 0x003666FF File Offset: 0x003648FF
	public TrackEffectExpressController(BehaviorTreeExpressionComponent owner, Blackboard blackboard)
	{
	}

	// Token: 0x0600B880 RID: 47232 RVA: 0x00366720 File Offset: 0x00364920
	public void Clear()
	{
		foreach (KeyValuePair<int, NodeTrackEffect> keyValuePair in this.TrackEffects)
		{
			keyValuePair.Value.Destroy();
		}
		this.TrackEffects.Clear();
		this.Owner = null;
	}

	// Token: 0x0600B881 RID: 47233 RVA: 0x0036678C File Offset: 0x0036498C
	public void EnableTrack(bool value)
	{
		foreach (NodeTrackEffect nodeTrackEffect in this.TrackEffects.Values)
		{
			if (value)
			{
				nodeTrackEffect.Start();
			}
			else
			{
				nodeTrackEffect.End();
			}
		}
	}

	// Token: 0x0600B882 RID: 47234 RVA: 0x003667F0 File Offset: 0x003649F0
	public void UpdateOnChildQuestNodeStatusChange(ChildQuestNodeBase node, bool bStart, bool bEnd)
	{
		ITrackTarget trackTarget = node.TrackTarget;
		if (((trackTarget != null) ? trackTarget.EffectOption : null) == null)
		{
			return;
		}
		if (bStart)
		{
			this.NodeTrackEffectStart(node.NodeId, trackTarget.EffectOption, this.<blackboard>P.IsTracking);
		}
		if (bEnd)
		{
			this.NodeTrackEffectEnd(node.NodeId);
		}
	}

	// Token: 0x0600B883 RID: 47235 RVA: 0x00366844 File Offset: 0x00364A44
	private void NodeTrackEffectStart(int nodeId, ITrackEffectAutoChange effectOption, bool bTracking)
	{
		NodeTrackEffect nodeTrackEffect = this.AddNodeTrackMarkCreator(nodeId, effectOption);
		if (bTracking)
		{
			nodeTrackEffect.Start();
		}
	}

	// Token: 0x0600B884 RID: 47236 RVA: 0x00366863 File Offset: 0x00364A63
	private void NodeTrackEffectEnd(int nodeId)
	{
		NodeTrackEffect nodeTrackMarkCreator = this.GetNodeTrackMarkCreator(nodeId);
		if (nodeTrackMarkCreator != null)
		{
			nodeTrackMarkCreator.End();
		}
		this.TrackEffects.Remove(nodeId);
	}

	// Token: 0x0600B885 RID: 47237 RVA: 0x00366884 File Offset: 0x00364A84
	private NodeTrackEffect AddNodeTrackMarkCreator(int nodeId, ITrackEffectAutoChange effectOption)
	{
		NodeTrackEffect nodeTrackMarkCreator = this.GetNodeTrackMarkCreator(nodeId);
		if (nodeTrackMarkCreator != null)
		{
			return nodeTrackMarkCreator;
		}
		NodeTrackEffect nodeTrackEffect = new NodeTrackEffect(this.Owner, nodeId, effectOption);
		this.TrackEffects[nodeId] = nodeTrackEffect;
		return nodeTrackEffect;
	}

	// Token: 0x0600B886 RID: 47238 RVA: 0x003668BA File Offset: 0x00364ABA
	[NullableContext(2)]
	public NodeTrackEffect GetNodeTrackMarkCreator(int nodeId)
	{
		return this.TrackEffects.GetValueOrDefault(nodeId);
	}

	// Token: 0x0600B887 RID: 47239 RVA: 0x003668C8 File Offset: 0x00364AC8
	public void OnBattleViewActive()
	{
		foreach (NodeTrackEffect nodeTrackEffect in this.TrackEffects.Values)
		{
			nodeTrackEffect.OnBattleViewActive();
		}
	}

	// Token: 0x0600B888 RID: 47240 RVA: 0x00366920 File Offset: 0x00364B20
	public void OnBattleViewHide()
	{
		foreach (NodeTrackEffect nodeTrackEffect in this.TrackEffects.Values)
		{
			nodeTrackEffect.OnBattleViewHide();
		}
	}

	// Token: 0x0600B889 RID: 47241 RVA: 0x00366978 File Offset: 0x00364B78
	public void OnBtApplyExpressionOccupation(bool bSelf)
	{
		if (bSelf)
		{
			return;
		}
		foreach (NodeTrackEffect nodeTrackEffect in this.TrackEffects.Values)
		{
			nodeTrackEffect.OnExpressOccupied();
		}
	}

	// Token: 0x0600B88A RID: 47242 RVA: 0x003669D4 File Offset: 0x00364BD4
	public void OnBtReleaseExpressionOccupation(bool bSelf)
	{
		if (bSelf)
		{
			return;
		}
		foreach (NodeTrackEffect nodeTrackEffect in this.TrackEffects.Values)
		{
			nodeTrackEffect.OnExpressOccupationRelease();
		}
	}

	// Token: 0x04006A2A RID: 27178
	[CompilerGenerated]
	private Blackboard <blackboard>P = blackboard;

	// Token: 0x04006A2B RID: 27179
	[Nullable(2)]
	private BehaviorTreeExpressionComponent Owner = owner;

	// Token: 0x04006A2C RID: 27180
	private readonly Dictionary<int, NodeTrackEffect> TrackEffects = new Dictionary<int, NodeTrackEffect>();
}
