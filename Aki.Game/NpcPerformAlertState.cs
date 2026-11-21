using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game;
using CSharpScript.Game.Common.Event;

// Token: 0x0200278E RID: 10126
public class NpcPerformAlertState : NpcPerformBaseState
{
	// Token: 0x0601961E RID: 103966 RVA: 0x007C2B3D File Offset: 0x007C0D3D
	[NullableContext(1)]
	public NpcPerformAlertState(EntityHandle owner, ENpcPerformState state, [Nullable(new byte[]
	{
		2,
		1
	})] StateMachine<EntityHandle, ENpcPerformState> stateMachine = null) : base(owner, state, stateMachine)
	{
	}

	// Token: 0x0601961F RID: 103967 RVA: 0x007C2B48 File Offset: 0x007C0D48
	public override bool CanChangeFrom(ENpcPerformState fromState)
	{
		CommonNpcPerformComponent component = this.Owner.Entity.GetComponent<CommonNpcPerformComponent>();
		CharacterAiComponent component2 = this.Owner.Entity.GetComponent<CharacterAiComponent>();
		bool flag;
		if (component2 == null)
		{
			flag = false;
		}
		else
		{
			AiController aiController = component2.AiController;
			if (aiController == null)
			{
				flag = false;
			}
			else
			{
				AiAlertClass aiAlert = aiController.AiAlert;
				flag = (aiAlert != null && aiAlert.AiAlertConfig != null);
			}
		}
		return flag && fromState == ENpcPerformState.Idle && !component.IsInPlot;
	}

	// Token: 0x06019620 RID: 103968 RVA: 0x007C2BB4 File Offset: 0x007C0DB4
	protected override void OnEnter(ENpcPerformState? lastState)
	{
		if (Global.BaseCharacter == null)
		{
			return;
		}
		CharacterActorComponent characterActorComponent = Global.BaseCharacter.CharacterActorComponent;
		AiControllerLibrary.TurnToTarget(this.Owner.Entity.GetComponent<CharacterActorComponent>(), characterActorComponent.ActorLocationProxy, 20000f, false, 0f);
		EventSystem.Instance.AddWithTarget(this.Owner.Entity, EEventName.OnStalkAlertLifted, new Action(this.OnStalkAlertLifted));
	}

	// Token: 0x06019621 RID: 103969 RVA: 0x007C2C21 File Offset: 0x007C0E21
	protected override void OnExit(ENpcPerformState nextState)
	{
		EventSystem.Instance.RemoveWithTarget(this.Owner.Entity, EEventName.OnStalkAlertLifted, new Action(this.OnStalkAlertLifted));
	}

	// Token: 0x06019622 RID: 103970 RVA: 0x007C2C4A File Offset: 0x007C0E4A
	private void OnStalkAlertLifted()
	{
		this.StateMachine.Switch(ENpcPerformState.Idle);
	}

	// Token: 0x0400DE4E RID: 56910
	private const int TURN_SPEED = 20000;
}
