using System;

// Token: 0x0200311F RID: 12575
public class PerformStopMove : PerformActionBase
{
	// Token: 0x0601B061 RID: 110689 RVA: 0x00755A93 File Offset: 0x00753C93
	public PerformStopMove() : base(EPerformAction.StopMove)
	{
	}

	// Token: 0x0601B062 RID: 110690 RVA: 0x00755A9C File Offset: 0x00753C9C
	protected override void OnExecute()
	{
		if (this.PerformComp.Entity.GetComponent<BaseCharacterComponent>() == null)
		{
			base.FinishExecute();
			return;
		}
		CharacterPatrolComponent component = this.PerformComp.Entity.GetComponent<CharacterPatrolComponent>();
		if (component == null)
		{
			base.FinishExecute();
			return;
		}
		if ((((IStopMoveParams)this.Param).Method ?? EStopMoveMethod.Stop) == EStopMoveMethod.Pause)
		{
			component.PausePatrol(((IStopMoveParams)this.Param).SplineId, ((IStopMoveParams)this.Param).Context);
		}
		else
		{
			component.StopPatrol(((IStopMoveParams)this.Param).SplineId, false);
		}
		base.FinishExecute();
	}
}
