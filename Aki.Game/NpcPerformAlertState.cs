using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game;
using CSharpScript.Game.Common.Event;

// Token: 0x0200321F RID: 12831
public class NpcPerformAlertState : NpcPerformBaseState
{
	// Token: 0x0601BA99 RID: 113305 RVA: 0x0079A3A1 File Offset: 0x007985A1
	[NullableContext(1)]
	public NpcPerformAlertState(EntityHandle owner, ENpcPerformState state, [Nullable(new byte[]
	{
		2,
		1
	})] StateMachine<EntityHandle, ENpcPerformState> stateMachine = null) : base(owner, state, stateMachine)
	{
	}

	// Token: 0x0601BA9A RID: 113306 RVA: 0x0079A3AC File Offset: 0x007985AC
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

	// Token: 0x0601BA9B RID: 113307 RVA: 0x0079A418 File Offset: 0x00798618
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

	// Token: 0x0601BA9C RID: 113308 RVA: 0x0079A485 File Offset: 0x00798685
	protected override void OnExit(ENpcPerformState nextState)
	{
		EventSystem.Instance.RemoveWithTarget(this.Owner.Entity, EEventName.OnStalkAlertLifted, new Action(this.OnStalkAlertLifted));
	}

	// Token: 0x0601BA9D RID: 113309 RVA: 0x0079A4AE File Offset: 0x007986AE
	private void OnStalkAlertLifted()
	{
		this.StateMachine.Switch(ENpcPerformState.Idle);
	}

	// Token: 0x0400D9AF RID: 55727
	private const int TURN_SPEED = 20000;
}
