using System;
using System.Runtime.CompilerServices;

// Token: 0x02002683 RID: 9859
public class PlotMode : PerformModeBase
{
	// Token: 0x06018AF5 RID: 101109 RVA: 0x0077CA58 File Offset: 0x0077AC58
	[NullableContext(1)]
	public PlotMode(EPerformMode mode, BasePerformComponent performComp, PerformMachine machine) : base(mode, performComp, machine)
	{
	}

	// Token: 0x06018AF6 RID: 101110 RVA: 0x0077CA63 File Offset: 0x0077AC63
	public override bool CheckEnter()
	{
		return this.PerformComp.IsInPlot;
	}

	// Token: 0x06018AF7 RID: 101111 RVA: 0x0077CA70 File Offset: 0x0077AC70
	public override bool CheckExit()
	{
		return !this.PerformComp.IsInPlot && this.CachePerformAction.Size == 0;
	}
}
