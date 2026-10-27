using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Module.GeneralLogicTree.BaseBehaviorTree.Express;
using CSharpScript.Game.Module.GeneralLogicTree.BehaviorNode.ChildQuestNode;

// Token: 0x02001D58 RID: 7512
[NullableContext(1)]
[Nullable(0)]
public class TrackEffectExpressController
{
	// Token: 0x0600E462 RID: 58466 RVA: 0x0035AB4F File Offset: 0x00358D4F
	public TrackEffectExpressController(BehaviorTreeExpressionComponent owner, Blackboard blackboard)
	{
	}

	// Token: 0x0600E463 RID: 58467 RVA: 0x0035AB70 File Offset: 0x00358D70
	public void Clear()
	{
		foreach (KeyValuePair<int, NodeTrackEffect> keyValuePair in this.TrackEffects)
		{
			keyValuePair.Value.Destroy();
		}
		this.TrackEffects.Clear();
		this.Owner = null;
	}

	// Token: 0x0600E464 RID: 58468 RVA: 0x0035ABDC File Offset: 0x00358DDC
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

	// Token: 0x0600E465 RID: 58469 RVA: 0x0035AC40 File Offset: 0x00358E40
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

	// Token: 0x0600E466 RID: 58470 RVA: 0x0035AC94 File Offset: 0x00358E94
	private void NodeTrackEffectStart(int nodeId, ITrackEffectAutoChange effectOption, bool bTracking)
	{
		NodeTrackEffect nodeTrackEffect = this.AddNodeTrackMarkCreator(nodeId, effectOption);
		if (bTracking)
		{
			nodeTrackEffect.Start();
		}
	}

	// Token: 0x0600E467 RID: 58471 RVA: 0x0035ACB3 File Offset: 0x00358EB3
	private void NodeTrackEffectEnd(int nodeId)
	{
		NodeTrackEffect nodeTrackMarkCreator = this.GetNodeTrackMarkCreator(nodeId);
		if (nodeTrackMarkCreator != null)
		{
			nodeTrackMarkCreator.End();
		}
		this.TrackEffects.Remove(nodeId);
	}

	// Token: 0x0600E468 RID: 58472 RVA: 0x0035ACD4 File Offset: 0x00358ED4
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

	// Token: 0x0600E469 RID: 58473 RVA: 0x0035AD0A File Offset: 0x00358F0A
	[NullableContext(2)]
	public NodeTrackEffect GetNodeTrackMarkCreator(int nodeId)
	{
		return this.TrackEffects.GetValueOrDefault(nodeId);
	}

	// Token: 0x0600E46A RID: 58474 RVA: 0x0035AD18 File Offset: 0x00358F18
	public void OnBattleViewActive()
	{
		foreach (NodeTrackEffect nodeTrackEffect in this.TrackEffects.Values)
		{
			nodeTrackEffect.OnBattleViewActive();
		}
	}

	// Token: 0x0600E46B RID: 58475 RVA: 0x0035AD70 File Offset: 0x00358F70
	public void OnBattleViewHide()
	{
		foreach (NodeTrackEffect nodeTrackEffect in this.TrackEffects.Values)
		{
			nodeTrackEffect.OnBattleViewHide();
		}
	}

	// Token: 0x0600E46C RID: 58476 RVA: 0x0035ADC8 File Offset: 0x00358FC8
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

	// Token: 0x0600E46D RID: 58477 RVA: 0x0035AE24 File Offset: 0x00359024
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

	// Token: 0x0400694A RID: 26954
	[CompilerGenerated]
	private Blackboard <blackboard>P = blackboard;

	// Token: 0x0400694B RID: 26955
	[Nullable(2)]
	private BehaviorTreeExpressionComponent Owner = owner;

	// Token: 0x0400694C RID: 26956
	private readonly Dictionary<int, NodeTrackEffect> TrackEffects = new Dictionary<int, NodeTrackEffect>();
}
