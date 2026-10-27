using System;
using System.Runtime.CompilerServices;

// Token: 0x02002E2F RID: 11823
public class AnimalPerformTakeOffState : AnimalPerformStateBase
{
	// Token: 0x06018E6C RID: 101996 RVA: 0x0066B3D5 File Offset: 0x006695D5
	[NullableContext(1)]
	public AnimalPerformTakeOffState(Entity owner, EAnimalPerformState state, [Nullable(new byte[]
	{
		2,
		1
	})] StateMachine<Entity, EAnimalPerformState> stateMachine = null) : base(owner, state, stateMachine)
	{
	}

	// Token: 0x06018E6D RID: 101997 RVA: 0x0066B3E0 File Offset: 0x006695E0
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
		this.EcologicalInterface.TakeOffStart();
		float actionTime = 0f;
		this.EcologicalInterface.GetCurrentActionTime(ref actionTime);
		this.ActionTime = actionTime;
	}

	// Token: 0x06018E6E RID: 101998 RVA: 0x0066B43E File Offset: 0x0066963E
	protected override void OnExit(EAnimalPerformState nextState)
	{
		if (this.EcologicalInterface == null)
		{
			return;
		}
		this.EcologicalInterface.TakeOffEnd();
	}
}
