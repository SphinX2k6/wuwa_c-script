using System;
using System.Runtime.CompilerServices;

// Token: 0x0200238C RID: 9100
public class AnimalPerformUnderAttackState : AnimalPerformStateBase
{
	// Token: 0x0601673C RID: 91964 RVA: 0x00691344 File Offset: 0x0068F544
	[NullableContext(1)]
	public AnimalPerformUnderAttackState(Entity owner, EAnimalPerformState state, [Nullable(new byte[]
	{
		2,
		1
	})] StateMachine<Entity, EAnimalPerformState> stateMachine = null) : base(owner, state, stateMachine)
	{
	}

	// Token: 0x0601673D RID: 91965 RVA: 0x00691350 File Offset: 0x0068F550
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
		this.EcologicalInterface.UnderAttackStart();
		float num = 0f;
		this.EcologicalInterface.GetCurrentActionTime(ref num);
		this.ActionTime = num - 0.25f;
	}

	// Token: 0x0601673E RID: 91966 RVA: 0x006913B4 File Offset: 0x0068F5B4
	protected override void OnUpdate(float delta)
	{
	}

	// Token: 0x0601673F RID: 91967 RVA: 0x006913B6 File Offset: 0x0068F5B6
	protected override void OnExit(EAnimalPerformState nextState)
	{
		if (this.EcologicalInterface == null)
		{
			return;
		}
		this.EcologicalInterface.UnderAttackEnd();
	}

	// Token: 0x0400BE72 RID: 48754
	private const float BLEND_OUT_TIME = 0.25f;
}
