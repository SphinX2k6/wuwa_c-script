using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x02002678 RID: 9848
[NullableContext(2)]
[Nullable(0)]
public class PerformStartMove : PerformActionBase
{
	// Token: 0x06018AAB RID: 101035 RVA: 0x0077B35F File Offset: 0x0077955F
	public PerformStartMove() : base(EPerformAction.StartMove)
	{
	}

	// Token: 0x06018AAC RID: 101036 RVA: 0x0077B374 File Offset: 0x00779574
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

	// Token: 0x06018AAD RID: 101037 RVA: 0x0077B410 File Offset: 0x00779610
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

	// Token: 0x06018AAE RID: 101038 RVA: 0x0077B583 File Offset: 0x00779783
	private void GuaranteeMoveTo(float delta)
	{
		this.HandleMoveTo();
	}

	// Token: 0x06018AAF RID: 101039 RVA: 0x0077B58B File Offset: 0x0077978B
	private void OnMontageEnded(int handleId)
	{
		this.HandleMoveTo();
	}

	// Token: 0x06018AB0 RID: 101040 RVA: 0x0077B594 File Offset: 0x00779794
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

	// Token: 0x06018AB1 RID: 101041 RVA: 0x0077B6E9 File Offset: 0x007798E9
	private void OnMovePause()
	{
		this.PerformComp.Entity.GetComponent<CharacterPatrolComponent>().PausePatrol(this.SplineId, "PerformStartMove");
	}

	// Token: 0x06018AB2 RID: 101042 RVA: 0x0077B70B File Offset: 0x0077990B
	private void OnMoveResume()
	{
		this.PerformComp.Entity.GetComponent<CharacterPatrolComponent>().ResumePatrol(this.SplineId, "PerformStartMove");
	}

	// Token: 0x06018AB3 RID: 101043 RVA: 0x0077B72D File Offset: 0x0077992D
	private void OnMoveStop(int splineId)
	{
		if (splineId != this.SplineId)
		{
			return;
		}
		this.ClearState();
		base.FinishExecute();
	}

	// Token: 0x06018AB4 RID: 101044 RVA: 0x0077B748 File Offset: 0x00779948
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

	// Token: 0x06018AB5 RID: 101045 RVA: 0x0077B8C8 File Offset: 0x00779AC8
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

	// Token: 0x06018AB6 RID: 101046 RVA: 0x0077B9B0 File Offset: 0x00779BB0
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

	// Token: 0x06018AB7 RID: 101047 RVA: 0x0077B9FC File Offset: 0x00779BFC
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

	// Token: 0x06018AB8 RID: 101048 RVA: 0x0077BA5E File Offset: 0x00779C5E
	protected override void OnRestore()
	{
		this.ExecuteMoveTask();
	}

	// Token: 0x06018AB9 RID: 101049 RVA: 0x0077BA68 File Offset: 0x00779C68
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

	// Token: 0x0400D63D RID: 54845
	private const int MONTAGE_MAX_STOP_TIME = 10000;

	// Token: 0x0400D63E RID: 54846
	private const int IMPACTED_MAX_STOP_TIME = 20000;

	// Token: 0x0400D63F RID: 54847
	private int SplineId;

	// Token: 0x0400D640 RID: 54848
	[Nullable(1)]
	private string Context = "";

	// Token: 0x0400D641 RID: 54849
	private EntityHandle EntityHandle;

	// Token: 0x0400D642 RID: 54850
	private WorldEntity CachedEntity;

	// Token: 0x0400D643 RID: 54851
	private TimerHandle DelayTimer;
}
