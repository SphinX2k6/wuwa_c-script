using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.Character.Npc.Logics;

// Token: 0x02003121 RID: 12577
[NullableContext(2)]
[Nullable(0)]
public class PerformTurn : PerformActionBase
{
	// Token: 0x1700256C RID: 9580
	// (get) Token: 0x0601B06D RID: 110701 RVA: 0x00755F89 File Offset: 0x00754189
	public override bool IsAtomic { get; } = 1;

	// Token: 0x0601B06E RID: 110702 RVA: 0x00755F91 File Offset: 0x00754191
	public PerformTurn() : base(EPerformAction.Turn)
	{
	}

	// Token: 0x0601B06F RID: 110703 RVA: 0x00755FA4 File Offset: 0x007541A4
	protected override void OnExecute()
	{
		if (this.PerformComp.Entity.GetComponent<CharacterActorComponent>() == null)
		{
			base.FinishExecute();
			return;
		}
		BaseAnimationComponent component = this.PerformComp.Entity.GetComponent<BaseAnimationComponent>();
		if (component.GetMontageManager(base.Group).IsMontagePlaying(null))
		{
			component.GetMontageManager(base.Group).StopMontage(new IStopMontageParam
			{
				Method = new EStopMethod?(EStopMethod.BlendOut),
				BlendOutTime = new float?(0.5f)
			});
			this.BlendAnimTimer = TimerSystem.Instance.Delay(new TTimerAction(this.HandleTurn), 250f, null, null, true, 1f);
			return;
		}
		this.HandleTurn(0f);
	}

	// Token: 0x0601B070 RID: 110704 RVA: 0x00756060 File Offset: 0x00754260
	private void HandleTurn(float delta)
	{
		this.BlendAnimTimer = null;
		CharacterActorComponent component = this.PerformComp.Entity.GetComponent<CharacterActorComponent>();
		ITurnParam turnParam = (ITurnParam)this.Param;
		if (turnParam.TargetLocation != null)
		{
			if (NpcTurnToLookAtUtils.TurnToTargetOrLookAtForSmallAngle(this.PerformComp.Entity, component, turnParam.TargetLocation, turnParam.TurnSpeed.GetValueOrDefault(), turnParam.ContainZ.GetValueOrDefault(), turnParam.MinTurnTimeSeconds.GetValueOrDefault(), turnParam.UseLookAtForThisTurn.GetValueOrDefault(), turnParam.SightTarget) == ETurnToTargetResult.LookAt)
			{
				base.FinishExecute();
				return;
			}
			this.StartWaitTurnEnd();
			return;
		}
		else
		{
			if (turnParam.Direction != null)
			{
				AiControllerLibrary.TurnToDirect(component, turnParam.Direction, turnParam.TurnSpeed.GetValueOrDefault(), turnParam.ContainZ.GetValueOrDefault(), turnParam.MinTurnTimeSeconds.GetValueOrDefault());
				this.StartWaitTurnEnd();
				return;
			}
			base.FinishExecute();
			return;
		}
	}

	// Token: 0x0601B071 RID: 110705 RVA: 0x0075614C File Offset: 0x0075434C
	private void OnTurnEnd()
	{
		Entity entity = this.Entity;
		if (entity == null || !entity.Valid)
		{
			return;
		}
		if (EventSystem.Instance.HasWithTarget(this.Entity, EEventName.CharTurnEnd, new Action(this.OnTurnEnd)))
		{
			EventSystem.Instance.RemoveWithTarget(this.Entity, EEventName.CharTurnEnd, new Action(this.OnTurnEnd));
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

	// Token: 0x0601B072 RID: 110706 RVA: 0x007561DC File Offset: 0x007543DC
	protected override void OnReset()
	{
		if (this.Entity != null && EventSystem.Instance.HasWithTarget(this.Entity, EEventName.CharTurnEnd, new Action(this.OnTurnEnd)))
		{
			EventSystem.Instance.RemoveWithTarget(this.Entity, EEventName.CharTurnEnd, new Action(this.OnTurnEnd));
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
	}

	// Token: 0x0601B073 RID: 110707 RVA: 0x00756270 File Offset: 0x00754470
	private void StartWaitTurnEnd()
	{
		this.Entity = this.PerformComp.Entity;
		EventSystem.Instance.AddWithTarget(this.Entity, EEventName.CharTurnEnd, new Action(this.OnTurnEnd));
		this.WatchDog = TimerSystem.Instance.Delay(delegate(float _)
		{
			this.OnTurnEnd();
		}, 3000f, null, null, true, 1f);
	}

	// Token: 0x0400D229 RID: 53801
	private const int TURN_MAX_TIME = 3000;

	// Token: 0x0400D22B RID: 53803
	private Entity Entity;

	// Token: 0x0400D22C RID: 53804
	private TimerHandle WatchDog;

	// Token: 0x0400D22D RID: 53805
	private TimerHandle BlendAnimTimer;
}
