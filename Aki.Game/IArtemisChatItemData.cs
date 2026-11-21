using System;
using System.Runtime.CompilerServices;

// Token: 0x020005A6 RID: 1446
[NullableContext(1)]
public interface IArtemisChatItemData
{
	// Token: 0x170009AE RID: 2478
	// (get) Token: 0x060044B4 RID: 17588
	string Content { get; }

	// Token: 0x170009AF RID: 2479
	// (get) Token: 0x060044B5 RID: 17589
	string PicturePath { get; }

	// Token: 0x170009B0 RID: 2480
	// (get) Token: 0x060044B6 RID: 17590
	bool IsLock { get; }

	// Token: 0x170009B1 RID: 2481
	// (get) Token: 0x060044B7 RID: 17591
	bool IsShowEffect { get; }
}
