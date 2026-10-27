using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002195 RID: 8597
[NullableContext(1)]
public interface IResultData
{
	// Token: 0x17001530 RID: 5424
	// (get) Token: 0x06010B63 RID: 68451
	EGamePlayResult Result { get; }

	// Token: 0x17001531 RID: 5425
	// (get) Token: 0x06010B64 RID: 68452
	int? Score { get; }

	// Token: 0x17001532 RID: 5426
	// (get) Token: 0x06010B65 RID: 68453
	int? PassTime { get; }

	// Token: 0x17001533 RID: 5427
	// (get) Token: 0x06010B66 RID: 68454
	bool IsNewRecord { get; }

	// Token: 0x17001534 RID: 5428
	// (get) Token: 0x06010B67 RID: 68455
	[Nullable(2)]
	TItem[] Reward { [NullableContext(2)] get; }

	// Token: 0x17001535 RID: 5429
	// (get) Token: 0x06010B68 RID: 68456
	int AutoCloseTime { get; }

	// Token: 0x17001536 RID: 5430
	// (get) Token: 0x06010B69 RID: 68457
	IReadOnlyList<IButtonPreset> ButtonList { get; }
}
