using System;
using System.Runtime.CompilerServices;

// Token: 0x0200278F RID: 10127
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class NpcPerformBaseState : StateBase<EntityHandle, ENpcPerformState>
{
	// Token: 0x06019623 RID: 103971 RVA: 0x007C2C59 File Offset: 0x007C0E59
	[NullableContext(1)]
	public NpcPerformBaseState(EntityHandle owner, ENpcPerformState state, [Nullable(new byte[]
	{
		2,
		1
	})] StateMachine<EntityHandle, ENpcPerformState> stateMachine = null) : base(owner, state, stateMachine)
	{
	}

	// Token: 0x1700287E RID: 10366
	// (get) Token: 0x06019624 RID: 103972 RVA: 0x007C2C7A File Offset: 0x007C0E7A
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

	// Token: 0x06019625 RID: 103973 RVA: 0x007C2C90 File Offset: 0x007C0E90
	protected override void OnCreate(IEntityArgs config = null)
	{
		this.CreatureDataComp = this.Owner.Entity.GetComponent<CreatureDataComponent>();
		this.ActorComp = this.Owner.Entity.GetComponent<BaseCharacterComponent>();
		this.PerformComp = this.Owner.Entity.GetComponent<CommonNpcPerformComponent>();
		this.ConfigId = this.CreatureDataComp.GetPbDataId();
		this.AnimComp = this.Owner.Entity.GetComponent<BaseAnimationComponent>();
	}

	// Token: 0x06019626 RID: 103974 RVA: 0x007C2D06 File Offset: 0x007C0F06
	public virtual void OnPlayerInteractTurnActionStart()
	{
	}

	// Token: 0x06019627 RID: 103975 RVA: 0x007C2D08 File Offset: 0x007C0F08
	public virtual void OnPlayerInteractTurnActionEnd()
	{
	}

	// Token: 0x06019628 RID: 103976 RVA: 0x007C2D0A File Offset: 0x007C0F0A
	[NullableContext(1)]
	public void PlayMontage(IPlayMontageParam param)
	{
		this.PerformComp.PlayPerformMontage(EPerformMode.Ecology, param, null, null, false);
	}

	// Token: 0x06019629 RID: 103977 RVA: 0x007C2D1D File Offset: 0x007C0F1D
	[NullableContext(1)]
	public void StopMontage(IStopMontageParam param)
	{
		this.PerformComp.StopPerformMontage(EPerformMode.Ecology, param, null, null);
	}

	// Token: 0x0400DE4F RID: 56911
	protected CreatureDataComponent CreatureDataComp;

	// Token: 0x0400DE50 RID: 56912
	protected BaseCharacterComponent ActorComp;

	// Token: 0x0400DE51 RID: 56913
	protected BaseAnimationComponent AnimComp;

	// Token: 0x0400DE52 RID: 56914
	protected CommonNpcPerformComponent PerformComp;

	// Token: 0x0400DE53 RID: 56915
	protected int ConfigId;

	// Token: 0x0400DE54 RID: 56916
	protected bool InteractRequestWaiting;

	// Token: 0x0400DE55 RID: 56917
	[Nullable(1)]
	protected Transform TmpTrans = Transform.Create();

	// Token: 0x0400DE56 RID: 56918
	[Nullable(1)]
	protected Vector TmpVector = Vector.Create();
}
