using System;
using System.Runtime.CompilerServices;

// Token: 0x02003220 RID: 12832
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class NpcPerformBaseState : StateBase<EntityHandle, ENpcPerformState>
{
	// Token: 0x0601BA9E RID: 113310 RVA: 0x0079A4BD File Offset: 0x007986BD
	[NullableContext(1)]
	public NpcPerformBaseState(EntityHandle owner, ENpcPerformState state, [Nullable(new byte[]
	{
		2,
		1
	})] StateMachine<EntityHandle, ENpcPerformState> stateMachine = null) : base(owner, state, stateMachine)
	{
	}

	// Token: 0x1700263D RID: 9789
	// (get) Token: 0x0601BA9F RID: 113311 RVA: 0x0079A4DE File Offset: 0x007986DE
	protected PawnTurnActionController TurnActionController
	{
		get
		{
			CommonNpcPerformComponent performComp = this.PerformComp;
			if (performComp == null)
			{
				return null;
			}
			return performComp.TurnActionController;
		}
	}

	// Token: 0x0601BAA0 RID: 113312 RVA: 0x0079A4F4 File Offset: 0x007986F4
	protected override void OnCreate(IEntityArgs config = null)
	{
		this.CreatureDataComp = this.Owner.Entity.GetComponent<CreatureDataComponent>();
		this.ActorComp = this.Owner.Entity.GetComponent<BaseCharacterComponent>();
		this.PerformComp = this.Owner.Entity.GetComponent<CommonNpcPerformComponent>();
		this.ConfigId = this.CreatureDataComp.GetPbDataId();
		this.AnimComp = this.Owner.Entity.GetComponent<BaseAnimationComponent>();
	}

	// Token: 0x0601BAA1 RID: 113313 RVA: 0x0079A56A File Offset: 0x0079876A
	public virtual void OnPlayerInteractTurnActionStart()
	{
	}

	// Token: 0x0601BAA2 RID: 113314 RVA: 0x0079A56C File Offset: 0x0079876C
	public virtual void OnPlayerInteractTurnActionEnd()
	{
	}

	// Token: 0x0601BAA3 RID: 113315 RVA: 0x0079A56E File Offset: 0x0079876E
	[NullableContext(1)]
	public void PlayMontage(IPlayMontageParam param)
	{
		this.PerformComp.PlayPerformMontage(EPerformMode.Ecology, param, null, null, false);
	}

	// Token: 0x0601BAA4 RID: 113316 RVA: 0x0079A581 File Offset: 0x00798781
	[NullableContext(1)]
	public void StopMontage(IStopMontageParam param)
	{
		this.PerformComp.StopPerformMontage(EPerformMode.Ecology, param, null, null);
	}

	// Token: 0x0400D9B0 RID: 55728
	protected CreatureDataComponent CreatureDataComp;

	// Token: 0x0400D9B1 RID: 55729
	protected BaseCharacterComponent ActorComp;

	// Token: 0x0400D9B2 RID: 55730
	protected BaseAnimationComponent AnimComp;

	// Token: 0x0400D9B3 RID: 55731
	protected CommonNpcPerformComponent PerformComp;

	// Token: 0x0400D9B4 RID: 55732
	protected int ConfigId;

	// Token: 0x0400D9B5 RID: 55733
	protected bool InteractRequestWaiting;

	// Token: 0x0400D9B6 RID: 55734
	[Nullable(1)]
	protected Transform TmpTrans = Transform.Create();

	// Token: 0x0400D9B7 RID: 55735
	[Nullable(1)]
	protected Vector TmpVector = Vector.Create();
}
