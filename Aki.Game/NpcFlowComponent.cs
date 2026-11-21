using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.Module.Interaction;
using UnrealEngine;

// Token: 0x02002743 RID: 10051
[NullableContext(2)]
[Nullable(0)]
public class NpcFlowComponent : CharacterFlowComponent
{
	// Token: 0x0601937F RID: 103295 RVA: 0x007B30DD File Offset: 0x007B12DD
	protected override bool OnStart()
	{
		this.SensoryComp = base.Entity.GetComponent<PawnSensoryInfoComponent>();
		base.OnStart();
		return true;
	}

	// Token: 0x06019380 RID: 103296 RVA: 0x007B30F8 File Offset: 0x007B12F8
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

	// Token: 0x06019381 RID: 103297 RVA: 0x007B3196 File Offset: 0x007B1396
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

	// Token: 0x06019382 RID: 103298 RVA: 0x007B31C4 File Offset: 0x007B13C4
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

	// Token: 0x06019383 RID: 103299 RVA: 0x007B3230 File Offset: 0x007B1430
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

	// Token: 0x06019384 RID: 103300 RVA: 0x007B32AC File Offset: 0x007B14AC
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

	// Token: 0x06019385 RID: 103301 RVA: 0x007B332B File Offset: 0x007B152B
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

	// Token: 0x06019386 RID: 103302 RVA: 0x007B3358 File Offset: 0x007B1558
	public int? GetTimberId()
	{
		BubbleComponent flowData = this.FlowData;
		if (flowData == null)
		{
			return null;
		}
		return flowData.TimberId;
	}

	// Token: 0x06019387 RID: 103303 RVA: 0x007B3380 File Offset: 0x007B1580
	[NullableContext(1)]
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		NpcFlowComponent npcFlowComponent = (NpcFlowComponent)componentTemplate;
		if (npcFlowComponent.SensoryComp == null)
		{
			this.SensoryComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.SensoryComp), "SensoryComp"))
		{
			return false;
		}
		this.MontageId = npcFlowComponent.MontageId;
		this.ActionId = npcFlowComponent.ActionId;
		return true;
	}

	// Token: 0x1700282A RID: 10282
	// (get) Token: 0x06019388 RID: 103304 RVA: 0x007B33E3 File Offset: 0x007B15E3
	public override bool NeedClearInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x1700282B RID: 10283
	// (get) Token: 0x06019389 RID: 103305 RVA: 0x007B33E6 File Offset: 0x007B15E6
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x1700282C RID: 10284
	// (get) Token: 0x0601938A RID: 103306 RVA: 0x007B33E9 File Offset: 0x007B15E9
	public override bool NeedActivateInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x1700282D RID: 10285
	// (get) Token: 0x0601938B RID: 103307 RVA: 0x007B33EC File Offset: 0x007B15EC
	public override bool NeedTickInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400DC82 RID: 56450
	private const float STOP_MONTAGE_BLEND_OUT_TIME = 0.3f;

	// Token: 0x0400DC83 RID: 56451
	private PawnSensoryInfoComponent SensoryComp;

	// Token: 0x0400DC84 RID: 56452
	private int MontageId = -1;

	// Token: 0x0400DC85 RID: 56453
	private int ActionId = -1;
}
