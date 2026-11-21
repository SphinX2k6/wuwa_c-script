using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001679 RID: 5753
[NullableContext(1)]
public interface IResultData
{
	// Token: 0x17001567 RID: 5479
	// (get) Token: 0x0600DFF4 RID: 57332
	EGamePlayResult Result { get; }

	// Token: 0x17001568 RID: 5480
	// (get) Token: 0x0600DFF5 RID: 57333
	int? Score { get; }

	// Token: 0x17001569 RID: 5481
	// (get) Token: 0x0600DFF6 RID: 57334
	int? PassTime { get; }

	// Token: 0x1700156A RID: 5482
	// (get) Token: 0x0600DFF7 RID: 57335
	bool IsNewRecord { get; }

	// Token: 0x1700156B RID: 5483
	// (get) Token: 0x0600DFF8 RID: 57336
	[Nullable(2)]
	TItem[] Reward { [NullableContext(2)] get; }

	// Token: 0x1700156C RID: 5484
	// (get) Token: 0x0600DFF9 RID: 57337
	int AutoCloseTime { get; }

	// Token: 0x1700156D RID: 5485
	// (get) Token: 0x0600DFFA RID: 57338
	IReadOnlyList<IButtonPreset> ButtonList { get; }
}
