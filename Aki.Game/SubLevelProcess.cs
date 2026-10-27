using System;

// Token: 0x0200350D RID: 13581
public abstract class SubLevelProcess
{
	// Token: 0x0601DC59 RID: 121945 RVA: 0x00857AB0 File Offset: 0x00855CB0
	protected SubLevelProcess(ESubLevelProcessType type)
	{
	}

	// Token: 0x17002904 RID: 10500
	// (get) Token: 0x0601DC5A RID: 121946 RVA: 0x00857ABF File Offset: 0x00855CBF
	public ESubLevelProcessType Type { get; } = type;
}
