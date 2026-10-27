using System;
using System.Runtime.CompilerServices;

// Token: 0x02003128 RID: 12584
public class PlotMode : PerformModeBase
{
	// Token: 0x0601B09A RID: 110746 RVA: 0x007569EC File Offset: 0x00754BEC
	[NullableContext(1)]
	public PlotMode(EPerformMode mode, BasePerformComponent performComp, PerformMachine machine) : base(mode, performComp, machine)
	{
	}

	// Token: 0x0601B09B RID: 110747 RVA: 0x007569F7 File Offset: 0x00754BF7
	public override bool CheckEnter()
	{
		return this.PerformComp.IsInPlot;
	}

	// Token: 0x0601B09C RID: 110748 RVA: 0x00756A04 File Offset: 0x00754C04
	public override bool CheckExit()
	{
		return !this.PerformComp.IsInPlot && this.CachePerformAction.Size == 0;
	}
}
