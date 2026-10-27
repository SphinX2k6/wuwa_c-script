using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.Module.Interaction;
using UnrealEngine;

// Token: 0x020031D4 RID: 12756
[NullableContext(2)]
[Nullable(0)]
public class NpcFlowComponent : CharacterFlowComponent
{
	// Token: 0x0601B828 RID: 112680 RVA: 0x0078B2CC File Offset: 0x007894CC
	protected override bool OnStart()
	{
		this.SensoryComp = base.Entity.GetComponent<PawnSensoryInfoComponent>();
		base.OnStart();
		return true;
	}

	// Token: 0x0601B829 RID: 112681 RVA: 0x0078B2E8 File Offset: 0x007894E8
	protected override void InitFlowLogic(BubbleComponent flowData)
	{
		if (flowData == null)
		{
			return;
		}
		this.FlowLogic = new NpcFlowLogic(this.ActorComp, flowData);
		this.FlowRange.Init(this.ActorComp.ActorTransform);
		BubbleComponent flowData2 = this.FlowData;
		float? enterRange = (flowData2 != null) ? new float?(flowData2.EnterRange) : null;
		BubbleComponent flowData3 = this.FlowData;
		float? leaveRange = (flowData3 != null) ? new float?(flowData3.LeaveRange) : null;
		BubbleComponent flowData4 = this.FlowData;
		this.InitFlowLogicRange(enterRange, leaveRange, (flowData4 != null) ? flowData4.TriggerCylinderConfig : null);
		this.IsEnter = false;
		this.IsInit = true;
	}

	// Token: 0x0601B82A RID: 112682 RVA: 0x0078B386 File Offset: 0x00789586
	protected override bool InitFlowLogicRange(float? enterRange, float? leaveRange, IBubbleRangeCylinderConfig config)
	{
		if (!base.InitFlowLogicRange(enterRange, leaveRange, config))
		{
			return false;
		}
		PawnSensoryInfoComponent sensoryComp = this.SensoryComp;
		if (sensoryComp != null)
		{
			sensoryComp.SetLogicRange(leaveRange.GetValueOrDefault(1500f));
		}
		return true;
	}

	// Token: 0x0601B82B RID: 112683 RVA: 0x0078B3B4 File Offset: 0x007895B4
	protected override bool CheckCondition()
	{
		if (!base.CheckCondition())
		{
			return false;
		}
		if (this.SensoryComp == null)
		{
			return false;
		}
		if (!this.SensoryComp.IsInLogicRange)
		{
			base.ForceStopFlow();
			return false;
		}
		int? currentInteractEntityId = InteractionModel.Instance.CurrentInteractEntityId;
		int id = base.Entity.Id;
		if (currentInteractEntityId.GetValueOrDefault() == id & currentInteractEntityId != null)
		{
			base.ForceStopFlow();
			return false;
		}
		return true;
	}

	// Token: 0x0601B82C RID: 112684 RVA: 0x0078B420 File Offset: 0x00789620
	public bool TryPlayMontage(string montagePath)
	{
		this.ActionId = -1;
		this.MontageId = -1;
		BasePerformComponent component = base.Entity.GetComponent<BasePerformComponent>();
		if (component != null && montagePath != null && montagePath.Contains('/'))
		{
			IPlayMontageParam param = new IPlayMontageParam
			{
				MontagePath = montagePath,
				OnStartCallback = delegate(int id, EPerformGroup group)
				{
					this.MontageId = id;
				},
				OnEndCallback = delegate(UAnimMontage _, bool _)
				{
					this.MontageId = -1;
				}
			};
			this.ActionId = component.PlayPerformMontage(EPerformMode.Ecology, param, null, null, false);
		}
		return false;
	}

	// Token: 0x0601B82D RID: 112685 RVA: 0x0078B49C File Offset: 0x0078969C
	private void StopMontage()
	{
		if (this.ActorComp == null || this.ActorComp.SkeletalMesh == null)
		{
			return;
		}
		BasePerformComponent component = base.Entity.GetComponent<BasePerformComponent>();
		if (component == null)
		{
			return;
		}
		component.EnableAction(this.ActionId, false);
		IStopMontageParam param = new IStopMontageParam
		{
			Method = new EStopMethod?(EStopMethod.BlendOut),
			BlendOutTime = new float?(0.3f),
			HandleId = new int?(this.MontageId)
		};
		component.StopPerformMontage(EPerformMode.Ecology, param, null, null);
	}

	// Token: 0x0601B82E RID: 112686 RVA: 0x0078B51B File Offset: 0x0078971B
	public override void RemoveFlowActions()
	{
		NpcFlowLogic npcFlowLogic = this.FlowLogic as NpcFlowLogic;
		if (npcFlowLogic != null)
		{
			npcFlowLogic.HideDialogueText();
		}
		if (npcFlowLogic != null)
		{
			npcFlowLogic.ClearAudio();
		}
		this.StopMontage();
	}

	// Token: 0x0601B82F RID: 112687 RVA: 0x0078B548 File Offset: 0x00789748
	public int? GetTimberId()
	{
		BubbleComponent flowData = this.FlowData;
		if (flowData == null)
		{
			return null;
		}
		return flowData.TimberId;
	}

	// Token: 0x0601B830 RID: 112688 RVA: 0x0078B570 File Offset: 0x00789770
	[NullableContext(1)]
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		NpcFlowComponent npcFlowComponent = (NpcFlowComponent)componentTemplate;
		if (base.CanResetComponentProperty("SensoryComp"))
		{
			if (npcFlowComponent.SensoryComp == null)
			{
				this.SensoryComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<PawnSensoryInfoComponent>(this.SensoryComp), "SensoryComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("MontageId"))
		{
			this.MontageId = npcFlowComponent.MontageId;
		}
		if (base.CanResetComponentProperty("ActionId"))
		{
			this.ActionId = npcFlowComponent.ActionId;
		}
		return true;
	}

	// Token: 0x0400D7FB RID: 55291
	private const float STOP_MONTAGE_BLEND_OUT_TIME = 0.3f;

	// Token: 0x0400D7FC RID: 55292
	private PawnSensoryInfoComponent SensoryComp;

	// Token: 0x0400D7FD RID: 55293
	private int MontageId = -1;

	// Token: 0x0400D7FE RID: 55294
	private int ActionId = -1;
}
