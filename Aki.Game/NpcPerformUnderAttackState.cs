using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.Common.Event;

// Token: 0x02003230 RID: 12848
[NullableContext(1)]
[Nullable(0)]
public class NpcPerformUnderAttackState : NpcPerformBaseState
{
	// Token: 0x0601BB57 RID: 113495 RVA: 0x007A0988 File Offset: 0x0079EB88
	public NpcPerformUnderAttackState(EntityHandle owner, ENpcPerformState state, [Nullable(new byte[]
	{
		2,
		1
	})] StateMachine<EntityHandle, ENpcPerformState> stateMachine = null) : base(owner, state, stateMachine)
	{
	}

	// Token: 0x0601BB58 RID: 113496 RVA: 0x007A09A0 File Offset: 0x0079EBA0
	public override bool CanChangeFrom(ENpcPerformState fromState)
	{
		CommonNpcPerformComponent component = this.Owner.Entity.GetComponent<CommonNpcPerformComponent>();
		return this.HaveUnderAttackConfig && fromState == ENpcPerformState.Idle && !component.IsInPlot;
	}

	// Token: 0x0601BB59 RID: 113497 RVA: 0x007A09D5 File Offset: 0x0079EBD5
	public void SetDefaultDirect(Vector direct)
	{
		this.DefaultDirect.DeepCopy(direct);
	}

	// Token: 0x0601BB5A RID: 113498 RVA: 0x007A09E4 File Offset: 0x0079EBE4
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

	// Token: 0x0601BB5B RID: 113499 RVA: 0x007A0A40 File Offset: 0x0079EC40
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

	// Token: 0x0601BB5C RID: 113500 RVA: 0x007A0B23 File Offset: 0x0079ED23
	protected override void OnExit(ENpcPerformState nextState)
	{
		EventSystem.Instance.EmitWithTarget(this.Owner, EEventName.OnNpcBeenAttackedEnd);
	}

	// Token: 0x0601BB5D RID: 113501 RVA: 0x007A0B3B File Offset: 0x0079ED3B
	protected override void OnDestroy()
	{
	}

	// Token: 0x0400DA40 RID: 55872
	private const int BUBBLE_TIME = 3;

	// Token: 0x0400DA41 RID: 55873
	private bool HaveUnderAttackConfig;

	// Token: 0x0400DA42 RID: 55874
	private int BubbleRate;

	// Token: 0x0400DA43 RID: 55875
	[Nullable(2)]
	private IBubbleIndex FlowConfig;

	// Token: 0x0400DA44 RID: 55876
	private readonly Vector DefaultDirect = Vector.Create();

	// Token: 0x0400DA45 RID: 55877
	private ENpcPerformState? LastState;
}
