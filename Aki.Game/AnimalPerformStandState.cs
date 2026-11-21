using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.Pawn.Component;

// Token: 0x02002387 RID: 9095
public class AnimalPerformStandState : AnimalPerformStateBase
{
	// Token: 0x06016726 RID: 91942 RVA: 0x00690E1C File Offset: 0x0068F01C
	[NullableContext(1)]
	public AnimalPerformStandState(Entity owner, EAnimalPerformState state, [Nullable(new byte[]
	{
		2,
		1
	})] StateMachine<Entity, EAnimalPerformState> stateMachine = null) : base(owner, state, stateMachine)
	{
	}

	// Token: 0x06016727 RID: 91943 RVA: 0x00690E27 File Offset: 0x0068F027
	protected override void OnEnter(EAnimalPerformState? lastState)
	{
		if (this.EcologicalInterface == null)
		{
			return;
		}
		this.EcologicalInterface.NoneStateStart();
	}

	// Token: 0x06016728 RID: 91944 RVA: 0x00690E3D File Offset: 0x0068F03D
	protected override void OnExit(EAnimalPerformState nextState)
	{
		if (this.EcologicalInterface == null)
		{
			return;
		}
		PawnInteractNewComponent component = this.Owner.GetComponent<PawnInteractNewComponent>();
		if (component != null)
		{
			component.SetInteractionState(false, "AnimalPerformStandState OnExit");
		}
		this.EcologicalInterface.NoneStateEnd();
	}
}
