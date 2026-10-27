using System;

// Token: 0x02003536 RID: 13622
public interface IRunOptions
{
	// Token: 0x17002969 RID: 10601
	// (get) Token: 0x0601DEE5 RID: 122597
	// (set) Token: 0x0601DEE6 RID: 122598
	int? Concurrency { get; set; }

	// Token: 0x1700296A RID: 10602
	// (get) Token: 0x0601DEE7 RID: 122599
	// (set) Token: 0x0601DEE8 RID: 122600
	bool? ContinueEvenFail { get; set; }
}
