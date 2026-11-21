using System;
using System.Runtime.CompilerServices;

// Token: 0x0200238B RID: 9099
public class AnimalPerformTakeOffState : AnimalPerformStateBase
{
	// Token: 0x06016739 RID: 91961 RVA: 0x006912C5 File Offset: 0x0068F4C5
	[NullableContext(1)]
	public AnimalPerformTakeOffState(Entity owner, EAnimalPerformState state, [Nullable(new byte[]
	{
		2,
		1
	})] StateMachine<Entity, EAnimalPerformState> stateMachine = null) : base(owner, state, stateMachine)
	{
	}

	// Token: 0x0601673A RID: 91962 RVA: 0x006912D0 File Offset: 0x0068F4D0
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

	// Token: 0x0601673B RID: 91963 RVA: 0x0069132E File Offset: 0x0068F52E
	protected override void OnExit(EAnimalPerformState nextState)
	{
		if (this.EcologicalInterface == null)
		{
			return;
		}
		this.EcologicalInterface.TakeOffEnd();
	}
}
