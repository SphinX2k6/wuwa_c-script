using System;
using System.Runtime.CompilerServices;

// Token: 0x02002382 RID: 9090
public class AnimalPerformAlertState : AnimalPerformStateBase
{
	// Token: 0x06016701 RID: 91905 RVA: 0x0068FCE6 File Offset: 0x0068DEE6
	[NullableContext(1)]
	public AnimalPerformAlertState(Entity owner, EAnimalPerformState state, [Nullable(new byte[]
	{
		2,
		1
	})] StateMachine<Entity, EAnimalPerformState> stateMachine = null) : base(owner, state, stateMachine)
	{
	}

	// Token: 0x06016702 RID: 91906 RVA: 0x0068FCF4 File Offset: 0x0068DEF4
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
		this.EcologicalInterface.AlertStart();
		float actionTime = 0f;
		this.EcologicalInterface.GetCurrentActionTime(ref actionTime);
		this.ActionTime = actionTime;
	}

	// Token: 0x06016703 RID: 91907 RVA: 0x0068FD52 File Offset: 0x0068DF52
	protected override void OnUpdate(float delta)
	{
	}

	// Token: 0x06016704 RID: 91908 RVA: 0x0068FD54 File Offset: 0x0068DF54
	protected override void OnExit(EAnimalPerformState nextState)
	{
		if (this.EcologicalInterface == null)
		{
			return;
		}
		this.EcologicalInterface.AlertEnd();
	}
}
