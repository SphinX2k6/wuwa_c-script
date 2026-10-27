using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.Pawn.Component;

// Token: 0x02002E29 RID: 11817
public class AnimalPerformIdleState : AnimalPerformStateBase
{
	// Token: 0x06018E52 RID: 101970 RVA: 0x0066AD6E File Offset: 0x00668F6E
	[NullableContext(1)]
	public AnimalPerformIdleState(Entity owner, EAnimalPerformState state, [Nullable(new byte[]
	{
		2,
		1
	})] StateMachine<Entity, EAnimalPerformState> stateMachine = null) : base(owner, state, stateMachine)
	{
	}

	// Token: 0x06018E53 RID: 101971 RVA: 0x0066AD7C File Offset: 0x00668F7C
	protected override void OnEnter(EAnimalPerformState? lastState)
	{
		if (this.EcologicalInterface == null)
		{
			return;
		}
		EAnimalPerformState? eanimalPerformState = lastState;
		EAnimalPerformState eanimalPerformState2 = EAnimalPerformState.Born;
		if (eanimalPerformState.GetValueOrDefault() == eanimalPerformState2 & eanimalPerformState != null)
		{
			base.AnimalEcologicalInterface.StateMachineInitializationComplete();
		}
		this.EcologicalInterface.IdleStart();
		float actionTime = 0f;
		this.EcologicalInterface.GetCurrentActionTime(ref actionTime);
		this.ActionTime = actionTime;
	}

	// Token: 0x06018E54 RID: 101972 RVA: 0x0066ADDA File Offset: 0x00668FDA
	protected override void OnUpdate(float delta)
	{
	}

	// Token: 0x06018E55 RID: 101973 RVA: 0x0066ADDC File Offset: 0x00668FDC
	protected override void OnExit(EAnimalPerformState nextState)
	{
		if (this.EcologicalInterface == null)
		{
			return;
		}
		PawnInteractNewComponent component = this.Owner.GetComponent<PawnInteractNewComponent>();
		if (component != null)
		{
			component.SetInteractionState(true, "AnimalPerformIdleState OnExit");
		}
		this.EcologicalInterface.IdleEnd();
	}
}
