using System;
using System.Runtime.CompilerServices;

// Token: 0x02003129 RID: 12585
public class EcologyMode : PerformModeBase
{
	// Token: 0x0601B09D RID: 110749 RVA: 0x00756A23 File Offset: 0x00754C23
	[NullableContext(1)]
	public EcologyMode(EPerformMode mode, BasePerformComponent performComp, PerformMachine machine) : base(mode, performComp, machine)
	{
	}

	// Token: 0x0601B09E RID: 110750 RVA: 0x00756A2E File Offset: 0x00754C2E
	public override bool CheckEnter()
	{
		return this.CachePerformAction.Size > 0;
	}

	// Token: 0x0601B09F RID: 110751 RVA: 0x00756A40 File Offset: 0x00754C40
	public override bool CheckExit()
	{
		return this.Machine.Modes[EPerformMode.Plot].CheckEnter() || this.Machine.Modes[EPerformMode.Action].CheckEnter() || this.CachePerformAction.Size == 0;
	}
}
