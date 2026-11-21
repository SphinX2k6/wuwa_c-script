using System;
using System.Runtime.CompilerServices;

// Token: 0x02001587 RID: 5511
[NullableContext(1)]
[Nullable(0)]
public abstract class AssemblyLogData
{
	// Token: 0x1700148B RID: 5259
	// (get) Token: 0x0600DCC6 RID: 56518
	// (set) Token: 0x0600DCC7 RID: 56519
	public abstract string AssemblyId { get; set; }

	// Token: 0x1700148C RID: 5260
	// (get) Token: 0x0600DCC8 RID: 56520
	// (set) Token: 0x0600DCC9 RID: 56521
	public abstract CommonLogData AssemblyLogInfo { get; set; }

	// Token: 0x0600DCCA RID: 56522
	public abstract void SetLogDataToAssembly(IUnitLogData unitLogData);

	// Token: 0x0600DCCB RID: 56523
	public abstract bool CheckIsSend();

	// Token: 0x0600DCCC RID: 56524
	public abstract void AfterSend();

	// Token: 0x04007B30 RID: 31536
	public int SendTimePeriod;

	// Token: 0x04007B31 RID: 31537
	public double SendTimeAccumulate;
}
