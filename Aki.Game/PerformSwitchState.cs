using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x02003120 RID: 12576
[NullableContext(2)]
[Nullable(0)]
public class PerformSwitchState : PerformActionBase
{
	// Token: 0x1700256B RID: 9579
	// (get) Token: 0x0601B063 RID: 110691 RVA: 0x00755B45 File Offset: 0x00753D45
	public override bool IsAtomic { get; } = 1;

	// Token: 0x0601B064 RID: 110692 RVA: 0x00755B4D File Offset: 0x00753D4D
	public PerformSwitchState() : base(EPerformAction.SwitchState)
	{
	}

	// Token: 0x0601B065 RID: 110693 RVA: 0x00755B60 File Offset: 0x00753D60
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

	// Token: 0x0601B066 RID: 110694 RVA: 0x00755CAA File Offset: 0x00753EAA
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

	// Token: 0x0601B067 RID: 110695 RVA: 0x00755CD8 File Offset: 0x00753ED8
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

	// Token: 0x0601B068 RID: 110696 RVA: 0x00755D56 File Offset: 0x00753F56
	private void OnCharTurnEnd()
	{
		EventSystem.Instance.RemoveWithTarget(this.Entity, EEventName.CharTurnEnd, new Action(this.OnCharTurnEnd));
		this.HandleSwitchState();
	}

	// Token: 0x0601B069 RID: 110697 RVA: 0x00755D80 File Offset: 0x00753F80
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

	// Token: 0x0601B06A RID: 110698 RVA: 0x00755E58 File Offset: 0x00754058
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

	// Token: 0x0400D222 RID: 53794
	private const int SWITCH_STATE_MAX_TIME = 30000;

	// Token: 0x0400D223 RID: 53795
	private const int FORCE_DELAY_UPDATE_TIME = 100;

	// Token: 0x0400D225 RID: 53797
	private Entity Entity;

	// Token: 0x0400D226 RID: 53798
	private TimerHandle WatchDog;

	// Token: 0x0400D227 RID: 53799
	private TimerHandle BlendAnimTimer;

	// Token: 0x0400D228 RID: 53800
	private TimerHandle ForceDelayTimer;
}
