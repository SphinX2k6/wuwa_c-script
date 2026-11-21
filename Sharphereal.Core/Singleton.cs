using System;

// Token: 0x02000002 RID: 2
public abstract class Singleton
{
	// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
	protected virtual bool OnInit()
	{
		return true;
	}

	// Token: 0x06000002 RID: 2 RVA: 0x00002053 File Offset: 0x00000253
	protected virtual bool OnClear()
	{
		return true;
	}
}
