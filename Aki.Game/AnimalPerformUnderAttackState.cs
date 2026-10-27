using System;
using System.Runtime.CompilerServices;

// Token: 0x02002E30 RID: 11824
public class AnimalPerformUnderAttackState : AnimalPerformStateBase
{
	// Token: 0x06018E6F RID: 101999 RVA: 0x0066B454 File Offset: 0x00669654
	[NullableContext(1)]
	public AnimalPerformUnderAttackState(Entity owner, EAnimalPerformState state, [Nullable(new byte[]
	{
		2,
		1
	})] StateMachine<Entity, EAnimalPerformState> stateMachine = null) : base(owner, state, stateMachine)
	{
	}

	// Token: 0x06018E70 RID: 102000 RVA: 0x0066B460 File Offset: 0x00669660
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

	// Token: 0x06018E71 RID: 102001 RVA: 0x0066B4C4 File Offset: 0x006696C4
	protected override void OnUpdate(float delta)
	{
	}

	// Token: 0x06018E72 RID: 102002 RVA: 0x0066B4C6 File Offset: 0x006696C6
	protected override void OnExit(EAnimalPerformState nextState)
	{
		if (this.EcologicalInterface == null)
		{
			return;
		}
		this.EcologicalInterface.UnderAttackEnd();
	}

	// Token: 0x0400BAE4 RID: 47844
	private const float BLEND_OUT_TIME = 0.25f;
}
