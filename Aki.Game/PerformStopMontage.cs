using System;

// Token: 0x02002679 RID: 9849
public class PerformStopMontage : PerformActionBase
{
	// Token: 0x06018ABA RID: 101050 RVA: 0x0077BAB0 File Offset: 0x00779CB0
	public PerformStopMontage() : base(EPerformAction.StopMontage)
	{
	}

	// Token: 0x06018ABB RID: 101051 RVA: 0x0077BABC File Offset: 0x00779CBC
	protected override void OnExecute()
	{
		BaseAnimationComponent component = this.PerformComp.Entity.GetComponent<BaseAnimationComponent>();
		if (component != null)
		{
			component.GetMontageManager(base.Group).StopMontage(this.Param as IStopMontageParam);
		}
		base.FinishExecute();
	}
}
