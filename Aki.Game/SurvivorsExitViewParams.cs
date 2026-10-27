using System;

// Token: 0x02002B73 RID: 11123
public class SurvivorsExitViewParams : ISurvivorsExitViewParams
{
	// Token: 0x17001EBD RID: 7869
	// (get) Token: 0x060170A0 RID: 94368 RVA: 0x005D995B File Offset: 0x005D7B5B
	// (set) Token: 0x060170A1 RID: 94369 RVA: 0x005D9963 File Offset: 0x005D7B63
	public bool IsExternal { get; set; }

	// Token: 0x17001EBE RID: 7870
	// (get) Token: 0x060170A2 RID: 94370 RVA: 0x005D996C File Offset: 0x005D7B6C
	// (set) Token: 0x060170A3 RID: 94371 RVA: 0x005D9974 File Offset: 0x005D7B74
	public int Batch { get; set; }

	// Token: 0x17001EBF RID: 7871
	// (get) Token: 0x060170A4 RID: 94372 RVA: 0x005D997D File Offset: 0x005D7B7D
	// (set) Token: 0x060170A5 RID: 94373 RVA: 0x005D9985 File Offset: 0x005D7B85
	public int MaxBatch { get; set; }
}
