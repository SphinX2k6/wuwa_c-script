using System;

// Token: 0x02001D97 RID: 7575
public abstract class PendingProcess : IStaticVariableResetter
{
	// Token: 0x0600E60B RID: 58891 RVA: 0x00363700 File Offset: 0x00361900
	static PendingProcess()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PendingProcess.CreateStaticDefaultValue), new Action(PendingProcess.ResetStaticDefaultValue));
	}

	// Token: 0x0600E60C RID: 58892 RVA: 0x0036371F File Offset: 0x0036191F
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600E60D RID: 58893 RVA: 0x00363721 File Offset: 0x00361921
	public static void ResetStaticDefaultValue()
	{
		PendingProcess.Id = 0;
	}

	// Token: 0x0600E60E RID: 58894 RVA: 0x00363729 File Offset: 0x00361929
	protected PendingProcess(EProcessType processType)
	{
		this.ProcessType = processType;
		this.ProcessId = ++PendingProcess.Id;
	}

	// Token: 0x04006A6D RID: 27245
	public static int Id;

	// Token: 0x04006A6E RID: 27246
	public int ProcessId;

	// Token: 0x04006A6F RID: 27247
	public bool Finished;

	// Token: 0x04006A70 RID: 27248
	public EProcessType ProcessType;
}
