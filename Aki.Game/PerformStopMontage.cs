using System;

// Token: 0x0200311E RID: 12574
public class PerformStopMontage : PerformActionBase
{
	// Token: 0x0601B05F RID: 110687 RVA: 0x00755A44 File Offset: 0x00753C44
	public PerformStopMontage() : base(EPerformAction.StopMontage)
	{
	}

	// Token: 0x0601B060 RID: 110688 RVA: 0x00755A50 File Offset: 0x00753C50
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
