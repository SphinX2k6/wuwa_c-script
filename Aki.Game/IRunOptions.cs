using System;

// Token: 0x02002AAB RID: 10923
public interface IRunOptions
{
	// Token: 0x17002D02 RID: 11522
	// (get) Token: 0x0601BC0D RID: 113677
	// (set) Token: 0x0601BC0E RID: 113678
	int? Concurrency { get; set; }

	// Token: 0x17002D03 RID: 11523
	// (get) Token: 0x0601BC0F RID: 113679
	// (set) Token: 0x0601BC10 RID: 113680
	bool? ContinueEvenFail { get; set; }
}
