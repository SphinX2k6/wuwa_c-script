using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.Common.Event;

// Token: 0x0200279F RID: 10143
[NullableContext(1)]
[Nullable(0)]
public class NpcPerformUnderAttackState : NpcPerformBaseState
{
	// Token: 0x060196DC RID: 104156 RVA: 0x007C9294 File Offset: 0x007C7494
	public NpcPerformUnderAttackState(EntityHandle owner, ENpcPerformState state, [Nullable(new byte[]
	{
		2,
		1
	})] StateMachine<EntityHandle, ENpcPerformState> stateMachine = null) : base(owner, state, stateMachine)
	{
	}

	// Token: 0x060196DD RID: 104157 RVA: 0x007C92AC File Offset: 0x007C74AC
	public override bool CanChangeFrom(ENpcPerformState fromState)
	{
		CommonNpcPerformComponent component = this.Owner.Entity.GetComponent<CommonNpcPerformComponent>();
		return this.HaveUnderAttackConfig && fromState == ENpcPerformState.Idle && !component.IsInPlot;
	}

	// Token: 0x060196DE RID: 104158 RVA: 0x007C92E1 File Offset: 0x007C74E1
	public void SetDefaultDirect(Vector direct)
	{
		this.DefaultDirect.DeepCopy(direct);
	}

	// Token: 0x060196DF RID: 104159 RVA: 0x007C92F0 File Offset: 0x007C74F0
	[NullableContext(2)]
	protected override void OnCreate(IEntityArgs args = null)
	{
		base.OnCreate(args);
		Aki.TDConfigMgr.Component.NpcPerformComponent p = args.GetP1<Aki.TDConfigMgr.Component.NpcPerformComponent>();
		if (((p != null) ? p.NpcHitShow : null) == null)
		{
			this.HaveUnderAttackConfig = false;
			return;
		}
		this.HaveUnderAttackConfig = true;
		this.BubbleRate = p.NpcHitShow.BubbleRate;
		this.FlowConfig = p.NpcHitShow.HitBubble;
	}

	// Token: 0x060196E0 RID: 104160 RVA: 0x007C934C File Offset: 0x007C754C
	protected override void OnEnter(ENpcPerformState? lastState)
	{
		this.LastState = lastState;
		CommonNpcPerformComponent component = this.Owner.Entity.GetComponent<CommonNpcPerformComponent>();
		if (component != null && component.HasBrain)
		{
			BaseMoveComponent component2 = this.Owner.Entity.GetComponent<BaseMoveComponent>();
			if (component2 != null)
			{
				component2.StopMove(false, null);
			}
		}
		if (component != null && component.IsMontagePlaying(EPerformGroup.DefaultGroup))
		{
			component.StopPerformMontage(EPerformMode.Ecology, new IStopMontageParam
			{
				Method = new EStopMethod?(EStopMethod.BlendOut),
				BlendOutTime = new float?(0f)
			}, null, null);
		}
		if (!this.HaveUnderAttackConfig)
		{
			TimerSystem.Instance.Delay(delegate(float delta)
			{
				this.StateMachine.Switch(this.LastState.Value);
			}, 3000f, null, null, true, 1f);
		}
		NpcPerceptionReactionUtil.ShowHeadDialog(this.Owner.Entity, (float)this.BubbleRate, this.FlowConfig);
		EventSystem.Instance.EmitWithTarget(this.Owner, EEventName.OnNpcBeenAttackedStart);
	}

	// Token: 0x060196E1 RID: 104161 RVA: 0x007C942F File Offset: 0x007C762F
	protected override void OnExit(ENpcPerformState nextState)
	{
		EventSystem.Instance.EmitWithTarget(this.Owner, EEventName.OnNpcBeenAttackedEnd);
	}

	// Token: 0x060196E2 RID: 104162 RVA: 0x007C9447 File Offset: 0x007C7647
	protected override void OnDestroy()
	{
	}

	// Token: 0x0400DEDF RID: 57055
	private const int BUBBLE_TIME = 3;

	// Token: 0x0400DEE0 RID: 57056
	private bool HaveUnderAttackConfig;

	// Token: 0x0400DEE1 RID: 57057
	private int BubbleRate;

	// Token: 0x0400DEE2 RID: 57058
	[Nullable(2)]
	private IBubbleIndex FlowConfig;

	// Token: 0x0400DEE3 RID: 57059
	private readonly Vector DefaultDirect = Vector.Create();

	// Token: 0x0400DEE4 RID: 57060
	private ENpcPerformState? LastState;
}
