using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x02002794 RID: 10132
public class NpcPerformImpactedState : NpcPerformBaseState
{
	// Token: 0x06019672 RID: 104050 RVA: 0x007C4DA9 File Offset: 0x007C2FA9
	[NullableContext(1)]
	public NpcPerformImpactedState(EntityHandle owner, ENpcPerformState state, [Nullable(new byte[]
	{
		2,
		1
	})] StateMachine<EntityHandle, ENpcPerformState> stateMachine = null) : base(owner, state, stateMachine)
	{
	}

	// Token: 0x06019673 RID: 104051 RVA: 0x007C4DB4 File Offset: 0x007C2FB4
	protected override void OnEnter(ENpcPerformState? lastState)
	{
		CommonNpcPerformComponent component = this.Owner.Entity.GetComponent<CommonNpcPerformComponent>();
		if (component != null && component.IsMontagePlaying(EPerformGroup.DefaultGroup))
		{
			component.StopPerformMontage(EPerformMode.Ecology, new IStopMontageParam
			{
				Method = new EStopMethod?(EStopMethod.BlendOut),
				BlendOutTime = new float?(0f)
			}, null, null);
		}
		EventSystem.Instance.EmitWithTarget(this.Owner, EEventName.OnNpcBeenImpactedStart);
	}

	// Token: 0x06019674 RID: 104052 RVA: 0x007C4E1F File Offset: 0x007C301F
	protected override void OnExit(ENpcPerformState nextState)
	{
		EventSystem.Instance.EmitWithTarget(this.Owner, EEventName.OnNpcBeenImpactedEnd);
	}
}
