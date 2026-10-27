using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component;

// Token: 0x02003228 RID: 12840
[NullableContext(2)]
[Nullable(0)]
public class NpcPerformMonsterNearbyState : NpcPerformBaseState
{
	// Token: 0x0601BAFB RID: 113403 RVA: 0x0079CA55 File Offset: 0x0079AC55
	[NullableContext(1)]
	public NpcPerformMonsterNearbyState(EntityHandle owner, ENpcPerformState state, [Nullable(new byte[]
	{
		2,
		1
	})] StateMachine<EntityHandle, ENpcPerformState> stateMachine = null) : base(owner, state, stateMachine)
	{
	}

	// Token: 0x0601BAFC RID: 113404 RVA: 0x0079CA60 File Offset: 0x0079AC60
	public override bool CanChangeFrom(ENpcPerformState fromState)
	{
		CommonNpcPerformComponent component = this.Owner.Entity.GetComponent<CommonNpcPerformComponent>();
		return this.HaveConfig && fromState == ENpcPerformState.Idle && !component.IsInPlot;
	}

	// Token: 0x0601BAFD RID: 113405 RVA: 0x0079CA98 File Offset: 0x0079AC98
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

	// Token: 0x0601BAFE RID: 113406 RVA: 0x0079CB04 File Offset: 0x0079AD04
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

	// Token: 0x0601BAFF RID: 113407 RVA: 0x0079CBCE File Offset: 0x0079ADCE
	protected override void OnExit(ENpcPerformState nextState)
	{
		base.StopMontage(new IStopMontageParam
		{
			Method = new EStopMethod?(EStopMethod.BlendOut)
		});
	}

	// Token: 0x0601BB00 RID: 113408 RVA: 0x0079CBE7 File Offset: 0x0079ADE7
	protected override void OnDestroy()
	{
	}

	// Token: 0x0400D9FC RID: 55804
	private const int BUBBLE_TIME = 3;

	// Token: 0x0400D9FD RID: 55805
	private readonly int PlayingMontageId;

	// Token: 0x0400D9FE RID: 55806
	private bool HaveConfig;

	// Token: 0x0400D9FF RID: 55807
	private IMontageId MontageInfo;

	// Token: 0x0400DA00 RID: 55808
	private float BubbleRate;

	// Token: 0x0400DA01 RID: 55809
	private IBubbleIndex FlowConfig;

	// Token: 0x0400DA02 RID: 55810
	private ENpcPerformState? LastState;
}
