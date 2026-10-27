using System;
using System.Runtime.CompilerServices;

// Token: 0x020020B0 RID: 8368
[NullableContext(1)]
[Nullable(0)]
public abstract class AssemblyLogData
{
	// Token: 0x1700145E RID: 5214
	// (get) Token: 0x06010856 RID: 67670
	// (set) Token: 0x06010857 RID: 67671
	public abstract string AssemblyId { get; set; }

	// Token: 0x1700145F RID: 5215
	// (get) Token: 0x06010858 RID: 67672
	// (set) Token: 0x06010859 RID: 67673
	public abstract CommonLogData AssemblyLogInfo { get; set; }

	// Token: 0x0601085A RID: 67674
	public abstract void SetLogDataToAssembly(IUnitLogData unitLogData);

	// Token: 0x0601085B RID: 67675
	public abstract bool CheckIsSend();

	// Token: 0x0601085C RID: 67676
	public abstract void AfterSend();

	// Token: 0x04007A32 RID: 31282
	public int SendTimePeriod;

	// Token: 0x04007A33 RID: 31283
	public double SendTimeAccumulate;
}
