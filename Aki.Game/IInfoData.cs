using System;
using System.Runtime.CompilerServices;

// Token: 0x020025C8 RID: 9672
[NullableContext(1)]
public interface IInfoData
{
	// Token: 0x1700192E RID: 6446
	// (get) Token: 0x060139F1 RID: 80369
	// (set) Token: 0x060139F2 RID: 80370
	string Text { get; set; }

	// Token: 0x1700192F RID: 6447
	// (get) Token: 0x060139F3 RID: 80371
	// (set) Token: 0x060139F4 RID: 80372
	bool IsFinish { get; set; }

	// Token: 0x17001930 RID: 6448
	// (get) Token: 0x060139F5 RID: 80373
	// (set) Token: 0x060139F6 RID: 80374
	bool IsOptionFinished { get; set; }
}
