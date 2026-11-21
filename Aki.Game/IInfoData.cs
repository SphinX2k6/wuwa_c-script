using System;
using System.Runtime.CompilerServices;

// Token: 0x02001AB3 RID: 6835
[NullableContext(1)]
public interface IInfoData
{
	// Token: 0x17001966 RID: 6502
	// (get) Token: 0x06010ED1 RID: 69329
	// (set) Token: 0x06010ED2 RID: 69330
	string Text { get; set; }

	// Token: 0x17001967 RID: 6503
	// (get) Token: 0x06010ED3 RID: 69331
	// (set) Token: 0x06010ED4 RID: 69332
	bool IsFinish { get; set; }

	// Token: 0x17001968 RID: 6504
	// (get) Token: 0x06010ED5 RID: 69333
	// (set) Token: 0x06010ED6 RID: 69334
	bool IsOptionFinished { get; set; }
}
