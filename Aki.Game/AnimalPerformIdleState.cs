using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.Pawn.Component;

// Token: 0x02002385 RID: 9093
public class AnimalPerformIdleState : AnimalPerformStateBase
{
	// Token: 0x0601671F RID: 91935 RVA: 0x00690C5E File Offset: 0x0068EE5E
	[NullableContext(1)]
	public AnimalPerformIdleState(Entity owner, EAnimalPerformState state, [Nullable(new byte[]
	{
		2,
		1
	})] StateMachine<Entity, EAnimalPerformState> stateMachine = null) : base(owner, state, stateMachine)
	{
	}

	// Token: 0x06016720 RID: 91936 RVA: 0x00690C6C File Offset: 0x0068EE6C
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

	// Token: 0x06016721 RID: 91937 RVA: 0x00690CCA File Offset: 0x0068EECA
	protected override void OnUpdate(float delta)
	{
	}

	// Token: 0x06016722 RID: 91938 RVA: 0x00690CCC File Offset: 0x0068EECC
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
