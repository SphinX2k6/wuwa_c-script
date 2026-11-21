using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x0200267B RID: 9851
[NullableContext(2)]
[Nullable(0)]
public class PerformSwitchState : PerformActionBase
{
	// Token: 0x17002716 RID: 10006
	// (get) Token: 0x06018ABE RID: 101054 RVA: 0x0077BBB1 File Offset: 0x00779DB1
	public override bool IsAtomic { get; } = 1;

	// Token: 0x06018ABF RID: 101055 RVA: 0x0077BBB9 File Offset: 0x00779DB9
	public PerformSwitchState() : base(EPerformAction.SwitchState)
	{
	}

	// Token: 0x06018AC0 RID: 101056 RVA: 0x0077BBCC File Offset: 0x00779DCC
	protected override void OnExecute()
	{
		if (this.PerformComp.Entity.GetComponent<BaseCharacterComponent>() == null)
		{
			base.FinishExecute();
			return;
		}
		NpcPerformComponent component = this.PerformComp.Entity.GetComponent<NpcPerformComponent>();
		if (component == null || !component.CanSwitchAnimState(((ISwitchState)this.Param).TargetStateName))
		{
			base.FinishExecute();
			return;
		}
		this.Entity = this.PerformComp.Entity;
		BaseAnimationComponent component2 = this.PerformComp.Entity.GetComponent<BaseAnimationComponent>();
		if (component2.GetMontageManager(base.Group).IsMontagePlaying(null))
		{
			component2.GetMontageManager(base.Group).StopMontage(new IStopMontageParam
			{
				Method = new EStopMethod?(EStopMethod.BlendOut),
				BlendOutTime = new float?(0.5f)
			});
			this.BlendAnimTimer = TimerSystem.Instance.Delay(new TTimerAction(this.HandleSwitchStateFromMontage), 250f, null, null, true, 1f);
		}
		else
		{
			this.HandleSwitchState();
		}
		EventSystem.Instance.AddWithTarget(this.Entity, EEventName.NpcAnimStateSwitchEnd, new Action(this.OnSwitchStateEnd));
		this.WatchDog = TimerSystem.Instance.Delay(delegate(float _)
		{
			this.OnSwitchStateEnd();
		}, 30000f, null, null, true, 1f);
	}

	// Token: 0x06018AC1 RID: 101057 RVA: 0x0077BD16 File Offset: 0x00779F16
	private void HandleSwitchStateFromMontage(float delta)
	{
		this.BlendAnimTimer = null;
		NpcPerformComponent component = this.PerformComp.Entity.GetComponent<NpcPerformComponent>();
		if (component == null)
		{
			return;
		}
		component.SwitchAnimState((ISwitchState)this.Param);
	}

	// Token: 0x06018AC2 RID: 101058 RVA: 0x0077BD44 File Offset: 0x00779F44
	private void HandleSwitchState()
	{
		BasePerformComponent performComp = this.PerformComp;
		NpcMoveComponent npcMoveComponent = (performComp != null) ? performComp.Entity.GetComponent<NpcMoveComponent>() : null;
		if (npcMoveComponent != null && npcMoveComponent.IsTurning)
		{
			EventSystem.Instance.AddWithTarget(this.Entity, EEventName.CharTurnEnd, new Action(this.OnCharTurnEnd));
			return;
		}
		this.ForceDelayTimer = TimerSystem.Instance.Delay(delegate(float _)
		{
			this.ForceDelayTimer = null;
			BasePerformComponent performComp2 = this.PerformComp;
			NpcPerformComponent npcPerformComponent = (performComp2 != null) ? performComp2.Entity.GetComponent<NpcPerformComponent>() : null;
			if (npcPerformComponent == null)
			{
				return;
			}
			npcPerformComponent.SwitchAnimState((ISwitchState)this.Param);
		}, 100f, null, null, true, 1f);
	}

	// Token: 0x06018AC3 RID: 101059 RVA: 0x0077BDC2 File Offset: 0x00779FC2
	private void OnCharTurnEnd()
	{
		EventSystem.Instance.RemoveWithTarget(this.Entity, EEventName.CharTurnEnd, new Action(this.OnCharTurnEnd));
		this.HandleSwitchState();
	}

	// Token: 0x06018AC4 RID: 101060 RVA: 0x0077BDEC File Offset: 0x00779FEC
	private void OnSwitchStateEnd()
	{
		Entity entity = this.Entity;
		if (entity == null || !entity.Valid)
		{
			return;
		}
		if (EventSystem.Instance.HasWithTarget(this.Entity, EEventName.NpcAnimStateSwitchEnd, new Action(this.OnSwitchStateEnd)))
		{
			EventSystem.Instance.RemoveWithTarget(this.Entity, EEventName.NpcAnimStateSwitchEnd, new Action(this.OnSwitchStateEnd));
		}
		if (EventSystem.Instance.HasWithTarget(this.Entity, EEventName.CharTurnEnd, new Action(this.OnCharTurnEnd)))
		{
			EventSystem.Instance.RemoveWithTarget(this.Entity, EEventName.CharTurnEnd, new Action(this.OnCharTurnEnd));
		}
		TimerHandle watchDog = this.WatchDog;
		if (watchDog != null)
		{
			watchDog.Remove();
		}
		this.WatchDog = null;
		this.Entity = null;
		base.FinishExecute();
	}

	// Token: 0x06018AC5 RID: 101061 RVA: 0x0077BEC4 File Offset: 0x0077A0C4
	protected override void OnReset()
	{
		if (this.Entity != null)
		{
			if (EventSystem.Instance.HasWithTarget(this.Entity, EEventName.NpcAnimStateSwitchEnd, new Action(this.OnSwitchStateEnd)))
			{
				EventSystem.Instance.RemoveWithTarget(this.Entity, EEventName.NpcAnimStateSwitchEnd, new Action(this.OnSwitchStateEnd));
			}
			if (EventSystem.Instance.HasWithTarget(this.Entity, EEventName.CharTurnEnd, new Action(this.OnCharTurnEnd)))
			{
				EventSystem.Instance.RemoveWithTarget(this.Entity, EEventName.CharTurnEnd, new Action(this.OnCharTurnEnd));
			}
		}
		TimerHandle watchDog = this.WatchDog;
		if (watchDog != null)
		{
			watchDog.Remove();
		}
		this.WatchDog = null;
		this.Entity = null;
		TimerHandle blendAnimTimer = this.BlendAnimTimer;
		if (blendAnimTimer != null)
		{
			blendAnimTimer.Remove();
		}
		this.BlendAnimTimer = null;
		TimerHandle forceDelayTimer = this.ForceDelayTimer;
		if (forceDelayTimer != null)
		{
			forceDelayTimer.Remove();
		}
		this.ForceDelayTimer = null;
	}

	// Token: 0x0400D644 RID: 54852
	private const int SWITCH_STATE_MAX_TIME = 30000;

	// Token: 0x0400D645 RID: 54853
	private const int FORCE_DELAY_UPDATE_TIME = 100;

	// Token: 0x0400D647 RID: 54855
	private Entity Entity;

	// Token: 0x0400D648 RID: 54856
	private TimerHandle WatchDog;

	// Token: 0x0400D649 RID: 54857
	private TimerHandle BlendAnimTimer;

	// Token: 0x0400D64A RID: 54858
	private TimerHandle ForceDelayTimer;
}
