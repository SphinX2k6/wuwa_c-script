using System;

// Token: 0x02001259 RID: 4697
public abstract class PendingProcess : IStaticVariableResetter
{
	// Token: 0x0600BA29 RID: 47657 RVA: 0x0036F360 File Offset: 0x0036D560
	static PendingProcess()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PendingProcess.CreateStaticDefaultValue), new Action(PendingProcess.ResetStaticDefaultValue));
	}

	// Token: 0x0600BA2A RID: 47658 RVA: 0x0036F37F File Offset: 0x0036D57F
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600BA2B RID: 47659 RVA: 0x0036F381 File Offset: 0x0036D581
	public static void ResetStaticDefaultValue()
	{
		PendingProcess.Id = 0;
	}

	// Token: 0x0600BA2C RID: 47660 RVA: 0x0036F389 File Offset: 0x0036D589
	protected PendingProcess(EProcessType processType)
	{
		this.ProcessType = processType;
		this.ProcessId = ++PendingProcess.Id;
	}

	// Token: 0x04006B4E RID: 27470
	public static int Id;

	// Token: 0x04006B4F RID: 27471
	public int ProcessId;

	// Token: 0x04006B50 RID: 27472
	public bool Finished;

	// Token: 0x04006B51 RID: 27473
	public EProcessType ProcessType;
}
