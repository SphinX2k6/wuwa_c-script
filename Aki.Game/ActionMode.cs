using System;
using System.Runtime.CompilerServices;

// Token: 0x0200312A RID: 12586
public class ActionMode : PerformModeBase
{
	// Token: 0x0601B0A0 RID: 110752 RVA: 0x00756A8D File Offset: 0x00754C8D
	[NullableContext(1)]
	public ActionMode(EPerformMode mode, BasePerformComponent performComp, PerformMachine machine) : base(mode, performComp, machine)
	{
	}

	// Token: 0x0601B0A1 RID: 110753 RVA: 0x00756A98 File Offset: 0x00754C98
	public override bool CheckEnter()
	{
		return this.CachePerformAction.Size > 0;
	}

	// Token: 0x0601B0A2 RID: 110754 RVA: 0x00756AA8 File Offset: 0x00754CA8
	public override bool CheckExit()
	{
		return this.Machine.Modes[EPerformMode.Plot].CheckEnter() || this.Machine.CurrentAction == null;
	}
}
