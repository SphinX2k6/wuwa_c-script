using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.Pawn.Component;

// Token: 0x02002E2B RID: 11819
public class AnimalPerformStandState : AnimalPerformStateBase
{
	// Token: 0x06018E59 RID: 101977 RVA: 0x0066AF2C File Offset: 0x0066912C
	[NullableContext(1)]
	public AnimalPerformStandState(Entity owner, EAnimalPerformState state, [Nullable(new byte[]
	{
		2,
		1
	})] StateMachine<Entity, EAnimalPerformState> stateMachine = null) : base(owner, state, stateMachine)
	{
	}

	// Token: 0x06018E5A RID: 101978 RVA: 0x0066AF37 File Offset: 0x00669137
	protected override void OnEnter(EAnimalPerformState? lastState)
	{
		if (this.EcologicalInterface == null)
		{
			return;
		}
		this.EcologicalInterface.NoneStateStart();
	}

	// Token: 0x06018E5B RID: 101979 RVA: 0x0066AF4D File Offset: 0x0066914D
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
