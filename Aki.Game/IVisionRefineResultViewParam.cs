using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02001731 RID: 5937
[NullableContext(2)]
public interface IVisionRefineResultViewParam
{
	// Token: 0x17000E46 RID: 3654
	// (get) Token: 0x0600AB97 RID: 43927
	// (set) Token: 0x0600AB98 RID: 43928
	PhantomPolishResponse Response { get; set; }

	// Token: 0x17000E47 RID: 3655
	// (get) Token: 0x0600AB99 RID: 43929
	// (set) Token: 0x0600AB9A RID: 43930
	PhantomBatchPolishResponse ResponseBatch { get; set; }

	// Token: 0x17000E48 RID: 3656
	// (get) Token: 0x0600AB9B RID: 43931
	// (set) Token: 0x0600AB9C RID: 43932
	bool ShowTips { get; set; }

	// Token: 0x17000E49 RID: 3657
	// (get) Token: 0x0600AB9D RID: 43933
	// (set) Token: 0x0600AB9E RID: 43934
	int? PropIndexId { get; set; }
}
