using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.Character.Npc.Logics;

// Token: 0x0200267C RID: 9852
[NullableContext(2)]
[Nullable(0)]
public class PerformTurn : PerformActionBase
{
	// Token: 0x17002717 RID: 10007
	// (get) Token: 0x06018AC8 RID: 101064 RVA: 0x0077BFF5 File Offset: 0x0077A1F5
	public override bool IsAtomic { get; } = 1;

	// Token: 0x06018AC9 RID: 101065 RVA: 0x0077BFFD File Offset: 0x0077A1FD
	public PerformTurn() : base(EPerformAction.Turn)
	{
	}

	// Token: 0x06018ACA RID: 101066 RVA: 0x0077C010 File Offset: 0x0077A210
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

	// Token: 0x06018ACB RID: 101067 RVA: 0x0077C0CC File Offset: 0x0077A2CC
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

	// Token: 0x06018ACC RID: 101068 RVA: 0x0077C1B8 File Offset: 0x0077A3B8
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

	// Token: 0x06018ACD RID: 101069 RVA: 0x0077C248 File Offset: 0x0077A448
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

	// Token: 0x06018ACE RID: 101070 RVA: 0x0077C2DC File Offset: 0x0077A4DC
	private void StartWaitTurnEnd()
	{
		this.Entity = this.PerformComp.Entity;
		EventSystem.Instance.AddWithTarget(this.Entity, EEventName.CharTurnEnd, new Action(this.OnTurnEnd));
		this.WatchDog = TimerSystem.Instance.Delay(delegate(float _)
		{
			this.OnTurnEnd();
		}, 3000f, null, null, true, 1f);
	}

	// Token: 0x0400D64B RID: 54859
	private const int TURN_MAX_TIME = 3000;

	// Token: 0x0400D64D RID: 54861
	private Entity Entity;

	// Token: 0x0400D64E RID: 54862
	private TimerHandle WatchDog;

	// Token: 0x0400D64F RID: 54863
	private TimerHandle BlendAnimTimer;
}
