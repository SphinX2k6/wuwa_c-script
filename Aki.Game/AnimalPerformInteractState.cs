using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.Pawn.Component;

// Token: 0x02002E2A RID: 11818
public class AnimalPerformInteractState : AnimalPerformStateBase
{
	// Token: 0x06018E56 RID: 101974 RVA: 0x0066AE0E File Offset: 0x0066900E
	[NullableContext(1)]
	public AnimalPerformInteractState(Entity owner, EAnimalPerformState state, [Nullable(new byte[]
	{
		2,
		1
	})] StateMachine<Entity, EAnimalPerformState> stateMachine = null) : base(owner, state, stateMachine)
	{
	}

	// Token: 0x06018E57 RID: 101975 RVA: 0x0066AE1C File Offset: 0x0066901C
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
		this.EcologicalInterface.InteractStart();
		float actionTime = 0f;
		this.EcologicalInterface.GetCurrentActionTime(ref actionTime);
		this.ActionTime = actionTime;
	}

	// Token: 0x06018E58 RID: 101976 RVA: 0x0066AE7C File Offset: 0x0066907C
	protected override void OnExit(EAnimalPerformState nextState)
	{
		if (this.EcologicalInterface == null)
		{
			return;
		}
		BaseTagComponent component = this.Owner.GetComponent<BaseTagComponent>();
		if (component.HasTag(GameplayTagDefine.EGameplayTagId["动物.Common.状态标识.交互.随机表演"]))
		{
			component.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["动物.Common.状态标识.交互.随机表演"]));
			component.AddTag(new int?(GameplayTagDefine.EGameplayTagId["动物.Common.状态标识.交互.站起"]));
		}
		component.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["动物.Common.通知标识.交互"]));
		PawnInteractNewComponent component2 = this.Owner.GetComponent<PawnInteractNewComponent>();
		if (component2 != null)
		{
			component2.SetInteractionState(true, "AnimalPerformInteractState OnExit");
		}
		this.EcologicalInterface.InteractEnd();
	}
}
