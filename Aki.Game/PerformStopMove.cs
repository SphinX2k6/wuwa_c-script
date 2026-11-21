using System;

// Token: 0x0200267A RID: 9850
public class PerformStopMove : PerformActionBase
{
	// Token: 0x06018ABC RID: 101052 RVA: 0x0077BAFF File Offset: 0x00779CFF
	public PerformStopMove() : base(EPerformAction.StopMove)
	{
	}

	// Token: 0x06018ABD RID: 101053 RVA: 0x0077BB08 File Offset: 0x00779D08
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
