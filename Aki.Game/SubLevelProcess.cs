using System;

// Token: 0x02002A82 RID: 10882
public abstract class SubLevelProcess
{
	// Token: 0x0601B973 RID: 113011 RVA: 0x0088007C File Offset: 0x0087E27C
	protected SubLevelProcess(ESubLevelProcessType type)
	{
	}

	// Token: 0x17002C9D RID: 11421
	// (get) Token: 0x0601B974 RID: 113012 RVA: 0x0088008B File Offset: 0x0087E28B
	public ESubLevelProcessType Type { get; } = type;
}
