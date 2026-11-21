using System;
using System.Runtime.CompilerServices;

// Token: 0x02002684 RID: 9860
public class EcologyMode : PerformModeBase
{
	// Token: 0x06018AF8 RID: 101112 RVA: 0x0077CA8F File Offset: 0x0077AC8F
	[NullableContext(1)]
	public EcologyMode(EPerformMode mode, BasePerformComponent performComp, PerformMachine machine) : base(mode, performComp, machine)
	{
	}

	// Token: 0x06018AF9 RID: 101113 RVA: 0x0077CA9A File Offset: 0x0077AC9A
	public override bool CheckEnter()
	{
		return this.CachePerformAction.Size > 0;
	}

	// Token: 0x06018AFA RID: 101114 RVA: 0x0077CAAC File Offset: 0x0077ACAC
	public override bool CheckExit()
	{
		return this.Machine.Modes[EPerformMode.Plot].CheckEnter() || this.Machine.Modes[EPerformMode.Action].CheckEnter() || this.CachePerformAction.Size == 0;
	}
}
