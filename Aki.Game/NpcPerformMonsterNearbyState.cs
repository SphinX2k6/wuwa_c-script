using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component;

// Token: 0x02002797 RID: 10135
[NullableContext(2)]
[Nullable(0)]
public class NpcPerformMonsterNearbyState : NpcPerformBaseState
{
	// Token: 0x06019680 RID: 104064 RVA: 0x007C51F1 File Offset: 0x007C33F1
	[NullableContext(1)]
	public NpcPerformMonsterNearbyState(EntityHandle owner, ENpcPerformState state, [Nullable(new byte[]
	{
		2,
		1
	})] StateMachine<EntityHandle, ENpcPerformState> stateMachine = null) : base(owner, state, stateMachine)
	{
	}

	// Token: 0x06019681 RID: 104065 RVA: 0x007C51FC File Offset: 0x007C33FC
	public override bool CanChangeFrom(ENpcPerformState fromState)
	{
		CommonNpcPerformComponent component = this.Owner.Entity.GetComponent<CommonNpcPerformComponent>();
		return this.HaveConfig && fromState == ENpcPerformState.Idle && !component.IsInPlot;
	}

	// Token: 0x06019682 RID: 104066 RVA: 0x007C5234 File Offset: 0x007C3434
	protected override void OnCreate(IEntityArgs args = null)
	{
		base.OnCreate(args);
		Aki.TDConfigMgr.Component.NpcPerformComponent p = args.GetP1<Aki.TDConfigMgr.Component.NpcPerformComponent>();
		if (((p != null) ? p.NpcMonsterClosePerform : null) == null)
		{
			this.HaveConfig = false;
			return;
		}
		this.HaveConfig = true;
		this.MontageInfo = p.NpcMonsterClosePerform.Montage;
		this.BubbleRate = (float)p.NpcMonsterClosePerform.BubbleRate;
		this.FlowConfig = p.NpcMonsterClosePerform.Bubble;
	}

	// Token: 0x06019683 RID: 104067 RVA: 0x007C52A0 File Offset: 0x007C34A0
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
		string montagePath = (component != null) ? component.GetMontagePath(this.MontageInfo) : null;
		base.PlayMontage(new IPlayMontageParam
		{
			MontagePath = montagePath,
			IsLoop = new bool?(true)
		});
		if (this.PlayingMontageId < 0)
		{
			TimerSystem.Instance.Delay(delegate(float delta)
			{
				this.StateMachine.Switch(this.LastState.Value);
			}, 3000f, null, null, true, 1f);
		}
		NpcPerceptionReactionUtil.ShowHeadDialog(this.Owner.Entity, this.BubbleRate, this.FlowConfig);
	}

	// Token: 0x06019684 RID: 104068 RVA: 0x007C536A File Offset: 0x007C356A
	protected override void OnExit(ENpcPerformState nextState)
	{
		base.StopMontage(new IStopMontageParam
		{
			Method = new EStopMethod?(EStopMethod.BlendOut)
		});
	}

	// Token: 0x06019685 RID: 104069 RVA: 0x007C5383 File Offset: 0x007C3583
	protected override void OnDestroy()
	{
	}

	// Token: 0x0400DE9B RID: 56987
	private const int BUBBLE_TIME = 3;

	// Token: 0x0400DE9C RID: 56988
	private readonly int PlayingMontageId;

	// Token: 0x0400DE9D RID: 56989
	private bool HaveConfig;

	// Token: 0x0400DE9E RID: 56990
	private IMontageId MontageInfo;

	// Token: 0x0400DE9F RID: 56991
	private float BubbleRate;

	// Token: 0x0400DEA0 RID: 56992
	private IBubbleIndex FlowConfig;

	// Token: 0x0400DEA1 RID: 56993
	private ENpcPerformState? LastState;
}
