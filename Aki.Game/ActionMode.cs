using System;
using System.Runtime.CompilerServices;

// Token: 0x02002685 RID: 9861
public class ActionMode : PerformModeBase
{
	// Token: 0x06018AFB RID: 101115 RVA: 0x0077CAF9 File Offset: 0x0077ACF9
	[NullableContext(1)]
	public ActionMode(EPerformMode mode, BasePerformComponent performComp, PerformMachine machine) : base(mode, performComp, machine)
	{
	}

	// Token: 0x06018AFC RID: 101116 RVA: 0x0077CB04 File Offset: 0x0077AD04
	public override bool CheckEnter()
	{
		return this.CachePerformAction.Size > 0;
	}

	// Token: 0x06018AFD RID: 101117 RVA: 0x0077CB14 File Offset: 0x0077AD14
	public override bool CheckExit()
	{
		return this.Machine.Modes[EPerformMode.Plot].CheckEnter() || this.Machine.CurrentAction == null;
	}
}
