using System;
using System.Runtime.CompilerServices;

// Token: 0x02002E26 RID: 11814
public class AnimalPerformAlertState : AnimalPerformStateBase
{
	// Token: 0x06018E34 RID: 101940 RVA: 0x00669DF7 File Offset: 0x00667FF7
	[NullableContext(1)]
	public AnimalPerformAlertState(Entity owner, EAnimalPerformState state, [Nullable(new byte[]
	{
		2,
		1
	})] StateMachine<Entity, EAnimalPerformState> stateMachine = null) : base(owner, state, stateMachine)
	{
	}

	// Token: 0x06018E35 RID: 101941 RVA: 0x00669E04 File Offset: 0x00668004
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

	// Token: 0x06018E36 RID: 101942 RVA: 0x00669E62 File Offset: 0x00668062
	protected override void OnUpdate(float delta)
	{
	}

	// Token: 0x06018E37 RID: 101943 RVA: 0x00669E64 File Offset: 0x00668064
	protected override void OnExit(EAnimalPerformState nextState)
	{
		if (this.EcologicalInterface == null)
		{
			return;
		}
		this.EcologicalInterface.AlertEnd();
	}
}
