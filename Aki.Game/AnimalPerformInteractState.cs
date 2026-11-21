using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.Pawn.Component;

// Token: 0x02002386 RID: 9094
public class AnimalPerformInteractState : AnimalPerformStateBase
{
	// Token: 0x06016723 RID: 91939 RVA: 0x00690CFE File Offset: 0x0068EEFE
	[NullableContext(1)]
	public AnimalPerformInteractState(Entity owner, EAnimalPerformState state, [Nullable(new byte[]
	{
		2,
		1
	})] StateMachine<Entity, EAnimalPerformState> stateMachine = null) : base(owner, state, stateMachine)
	{
	}

	// Token: 0x06016724 RID: 91940 RVA: 0x00690D0C File Offset: 0x0068EF0C
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

	// Token: 0x06016725 RID: 91941 RVA: 0x00690D6C File Offset: 0x0068EF6C
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
