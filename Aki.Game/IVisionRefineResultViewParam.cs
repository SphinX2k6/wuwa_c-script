using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02000BEA RID: 3050
[NullableContext(2)]
public interface IVisionRefineResultViewParam
{
	// Token: 0x17000E69 RID: 3689
	// (get) Token: 0x06007F7E RID: 32638
	// (set) Token: 0x06007F7F RID: 32639
	PhantomPolishResponse Response { get; set; }

	// Token: 0x17000E6A RID: 3690
	// (get) Token: 0x06007F80 RID: 32640
	// (set) Token: 0x06007F81 RID: 32641
	PhantomBatchPolishResponse ResponseBatch { get; set; }

	// Token: 0x17000E6B RID: 3691
	// (get) Token: 0x06007F82 RID: 32642
	// (set) Token: 0x06007F83 RID: 32643
	bool ShowTips { get; set; }

	// Token: 0x17000E6C RID: 3692
	// (get) Token: 0x06007F84 RID: 32644
	// (set) Token: 0x06007F85 RID: 32645
	int? PropIndexId { get; set; }
}
