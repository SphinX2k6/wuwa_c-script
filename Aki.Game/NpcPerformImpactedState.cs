using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x02003225 RID: 12837
public class NpcPerformImpactedState : NpcPerformBaseState
{
	// Token: 0x0601BAED RID: 113389 RVA: 0x0079C60D File Offset: 0x0079A80D
	[NullableContext(1)]
	public NpcPerformImpactedState(EntityHandle owner, ENpcPerformState state, [Nullable(new byte[]
	{
		2,
		1
	})] StateMachine<EntityHandle, ENpcPerformState> stateMachine = null) : base(owner, state, stateMachine)
	{
	}

	// Token: 0x0601BAEE RID: 113390 RVA: 0x0079C618 File Offset: 0x0079A818
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

	// Token: 0x0601BAEF RID: 113391 RVA: 0x0079C683 File Offset: 0x0079A883
	protected override void OnExit(ENpcPerformState nextState)
	{
		EventSystem.Instance.EmitWithTarget(this.Owner, EEventName.OnNpcBeenImpactedEnd);
	}
}
