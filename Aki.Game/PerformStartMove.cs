using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x0200311D RID: 12573
[NullableContext(2)]
[Nullable(0)]
public class PerformStartMove : PerformActionBase
{
	// Token: 0x0601B050 RID: 110672 RVA: 0x007552F3 File Offset: 0x007534F3
	public PerformStartMove() : base(EPerformAction.StartMove)
	{
	}

	// Token: 0x0601B051 RID: 110673 RVA: 0x00755308 File Offset: 0x00753508
	protected override void OnExecute()
	{
		if (this.PerformComp.Entity.GetComponent<BaseCharacterComponent>() == null)
		{
			base.FinishExecute();
			return;
		}
		this.SplineId = ((IStartMoveParams)this.Param).SplineId;
		this.Context = (((IStartMoveParams)this.Param).Context ?? "");
		this.EntityHandle = CreatureModel.Instance.GetEntityById(this.PerformComp.Entity.Id);
		EntityHandle entityHandle = this.EntityHandle;
		this.CachedEntity = ((entityHandle != null) ? entityHandle.Entity : null);
		this.ExecuteMoveTask();
	}

	// Token: 0x0601B052 RID: 110674 RVA: 0x007553A4 File Offset: 0x007535A4
	private void ExecuteMoveTask()
	{
		CommonNpcPerformComponent component = this.PerformComp.Entity.GetComponent<CommonNpcPerformComponent>();
		BaseAnimationComponent component2 = this.PerformComp.Entity.GetComponent<BaseAnimationComponent>();
		if (component2 != null && component2.GetMontageManager(base.Group).IsMontagePlaying(null))
		{
			component2.GetMontageManager(base.Group).StopMontage(new IStopMontageParam
			{
				Method = new EStopMethod?(EStopMethod.WaitLoopToEnd)
			});
			this.DelayTimer = TimerSystem.Instance.Delay(new TTimerAction(this.GuaranteeMoveTo), 10000f, null, null, true, 1f);
			EventSystem.Instance.AddWithTarget(this.EntityHandle, EEventName.PerformMontageStop, new Action<int>(this.OnMontageEnded));
			return;
		}
		if (component != null && component.IsBeingAttacked)
		{
			this.DelayTimer = TimerSystem.Instance.Delay(new TTimerAction(this.GuaranteeMoveTo), 20000f, null, null, true, 1f);
			EventSystem.Instance.AddWithTarget(this.EntityHandle, EEventName.OnNpcBeenAttackedEnd, new Action(this.HandleMoveTo));
			return;
		}
		if (component != null && component.IsBeingImpacted)
		{
			this.DelayTimer = TimerSystem.Instance.Delay(new TTimerAction(this.GuaranteeMoveTo), 20000f, null, null, true, 1f);
			EventSystem.Instance.AddWithTarget(this.EntityHandle, EEventName.OnNpcBeenImpactedEnd, new Action(this.HandleMoveTo));
			return;
		}
		this.HandleMoveTo();
	}

	// Token: 0x0601B053 RID: 110675 RVA: 0x00755517 File Offset: 0x00753717
	private void GuaranteeMoveTo(float delta)
	{
		this.HandleMoveTo();
	}

	// Token: 0x0601B054 RID: 110676 RVA: 0x0075551F File Offset: 0x0075371F
	private void OnMontageEnded(int handleId)
	{
		this.HandleMoveTo();
	}

	// Token: 0x0601B055 RID: 110677 RVA: 0x00755528 File Offset: 0x00753728
	private void HandleMoveTo()
	{
		this.RemovePreExecuteEvents();
		TimerHandle delayTimer = this.DelayTimer;
		if (delayTimer != null)
		{
			delayTimer.Remove();
		}
		this.DelayTimer = null;
		EntityHandle entityHandle = this.EntityHandle;
		if (entityHandle == null || !entityHandle.Valid)
		{
			base.FinishExecute();
			return;
		}
		CharacterPatrolComponent component = this.PerformComp.Entity.GetComponent<CharacterPatrolComponent>();
		if (component.HasPatrolRecord(new long?((long)this.SplineId)))
		{
			component.ResumePatrol(this.SplineId, "PerformStartMove:OnReset");
			component.ResumePatrol(this.SplineId, this.Context);
		}
		else
		{
			component.StartPatrol(this.SplineId, (IStartMoveParams)this.Param);
		}
		EventSystem.Instance.AddWithTarget(this.CachedEntity, EEventName.OnPatrolStop, new Action<int>(this.OnMoveStop));
		EventSystem.Instance.AddWithTarget(this.EntityHandle, EEventName.OnNpcBeenAttackedStart, new Action(this.OnMovePause));
		EventSystem.Instance.AddWithTarget(this.EntityHandle, EEventName.OnNpcBeenImpactedStart, new Action(this.OnMovePause));
		EventSystem.Instance.AddWithTarget(this.EntityHandle, EEventName.OnNpcBeenAttackedEnd, new Action(this.OnMoveResume));
		EventSystem.Instance.AddWithTarget(this.EntityHandle, EEventName.OnNpcBeenImpactedEnd, new Action(this.OnMoveResume));
	}

	// Token: 0x0601B056 RID: 110678 RVA: 0x0075567D File Offset: 0x0075387D
	private void OnMovePause()
	{
		this.PerformComp.Entity.GetComponent<CharacterPatrolComponent>().PausePatrol(this.SplineId, "PerformStartMove");
	}

	// Token: 0x0601B057 RID: 110679 RVA: 0x0075569F File Offset: 0x0075389F
	private void OnMoveResume()
	{
		this.PerformComp.Entity.GetComponent<CharacterPatrolComponent>().ResumePatrol(this.SplineId, "PerformStartMove");
	}

	// Token: 0x0601B058 RID: 110680 RVA: 0x007556C1 File Offset: 0x007538C1
	private void OnMoveStop(int splineId)
	{
		if (splineId != this.SplineId)
		{
			return;
		}
		this.ClearState();
		base.FinishExecute();
	}

	// Token: 0x0601B059 RID: 110681 RVA: 0x007556DC File Offset: 0x007538DC
	private void RemoveEvents()
	{
		if (this.EntityHandle == null)
		{
			return;
		}
		if (this.CachedEntity != null && EventSystem.Instance.HasWithTarget(this.CachedEntity, EEventName.OnPatrolStop, new Action<int>(this.OnMoveStop)))
		{
			EventSystem.Instance.RemoveWithTarget(this.CachedEntity, EEventName.OnPatrolStop, new Action<int>(this.OnMoveStop));
		}
		if (EventSystem.Instance.HasWithTarget(this.EntityHandle, EEventName.OnNpcBeenAttackedStart, new Action(this.OnMovePause)))
		{
			EventSystem.Instance.RemoveWithTarget(this.EntityHandle, EEventName.OnNpcBeenAttackedStart, new Action(this.OnMovePause));
		}
		if (EventSystem.Instance.HasWithTarget(this.EntityHandle, EEventName.OnNpcBeenImpactedStart, new Action(this.OnMovePause)))
		{
			EventSystem.Instance.RemoveWithTarget(this.EntityHandle, EEventName.OnNpcBeenImpactedStart, new Action(this.OnMovePause));
		}
		if (EventSystem.Instance.HasWithTarget(this.EntityHandle, EEventName.OnNpcBeenAttackedEnd, new Action(this.OnMoveResume)))
		{
			EventSystem.Instance.RemoveWithTarget(this.EntityHandle, EEventName.OnNpcBeenAttackedEnd, new Action(this.OnMoveResume));
		}
		if (EventSystem.Instance.HasWithTarget(this.EntityHandle, EEventName.OnNpcBeenImpactedEnd, new Action(this.OnMoveResume)))
		{
			EventSystem.Instance.RemoveWithTarget(this.EntityHandle, EEventName.OnNpcBeenImpactedEnd, new Action(this.OnMoveResume));
		}
		this.RemovePreExecuteEvents();
	}

	// Token: 0x0601B05A RID: 110682 RVA: 0x0075585C File Offset: 0x00753A5C
	private void RemovePreExecuteEvents()
	{
		if (this.EntityHandle == null)
		{
			return;
		}
		if (EventSystem.Instance.HasWithTarget(this.EntityHandle, EEventName.PerformMontageStop, new Action<int>(this.OnMontageEnded)))
		{
			EventSystem.Instance.RemoveWithTarget(this.EntityHandle, EEventName.PerformMontageStop, new Action<int>(this.OnMontageEnded));
		}
		if (EventSystem.Instance.HasWithTarget(this.EntityHandle, EEventName.OnNpcBeenAttackedEnd, new Action(this.HandleMoveTo)))
		{
			EventSystem.Instance.RemoveWithTarget(this.EntityHandle, EEventName.OnNpcBeenAttackedEnd, new Action(this.HandleMoveTo));
		}
		if (EventSystem.Instance.HasWithTarget(this.EntityHandle, EEventName.OnNpcBeenImpactedEnd, new Action(this.HandleMoveTo)))
		{
			EventSystem.Instance.RemoveWithTarget(this.EntityHandle, EEventName.OnNpcBeenImpactedEnd, new Action(this.HandleMoveTo));
		}
	}

	// Token: 0x0601B05B RID: 110683 RVA: 0x00755944 File Offset: 0x00753B44
	protected void ClearState()
	{
		this.RemoveEvents();
		this.SplineId = 0;
		this.Context = "";
		this.EntityHandle = null;
		this.CachedEntity = null;
		TimerHandle delayTimer = this.DelayTimer;
		if (delayTimer != null)
		{
			delayTimer.Remove();
		}
		this.DelayTimer = null;
	}

	// Token: 0x0601B05C RID: 110684 RVA: 0x00755990 File Offset: 0x00753B90
	protected override void OnInterrupt()
	{
		int splineId = this.SplineId;
		EntityHandle entityHandle = this.EntityHandle;
		object obj;
		if (entityHandle == null)
		{
			obj = null;
		}
		else
		{
			WorldEntity entity = entityHandle.Entity;
			obj = ((entity != null) ? entity.GetComponent<CharacterPatrolComponent>() : null);
		}
		object obj2 = obj;
		if (obj2 != null)
		{
			obj2.PausePatrol(splineId, "PerformStartMove:OnReset");
		}
		this.RemoveEvents();
		TimerHandle delayTimer = this.DelayTimer;
		if (delayTimer != null)
		{
			delayTimer.Remove();
		}
		this.DelayTimer = null;
	}

	// Token: 0x0601B05D RID: 110685 RVA: 0x007559F2 File Offset: 0x00753BF2
	protected override void OnRestore()
	{
		this.ExecuteMoveTask();
	}

	// Token: 0x0601B05E RID: 110686 RVA: 0x007559FC File Offset: 0x00753BFC
	protected override void OnReset()
	{
		int splineId = this.SplineId;
		EntityHandle entityHandle = this.EntityHandle;
		object obj;
		if (entityHandle == null)
		{
			obj = null;
		}
		else
		{
			WorldEntity entity = entityHandle.Entity;
			obj = ((entity != null) ? entity.GetComponent<CharacterPatrolComponent>() : null);
		}
		this.ClearState();
		object obj2 = obj;
		if (obj2 == null)
		{
			return;
		}
		obj2.PausePatrol(splineId, "PerformStartMove:OnReset");
	}

	// Token: 0x0400D21B RID: 53787
	private const int MONTAGE_MAX_STOP_TIME = 10000;

	// Token: 0x0400D21C RID: 53788
	private const int IMPACTED_MAX_STOP_TIME = 20000;

	// Token: 0x0400D21D RID: 53789
	private int SplineId;

	// Token: 0x0400D21E RID: 53790
	[Nullable(1)]
	private string Context = "";

	// Token: 0x0400D21F RID: 53791
	private EntityHandle EntityHandle;

	// Token: 0x0400D220 RID: 53792
	private WorldEntity CachedEntity;

	// Token: 0x0400D221 RID: 53793
	private TimerHandle DelayTimer;
}
