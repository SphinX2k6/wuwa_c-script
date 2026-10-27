using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020010AA RID: 4266
[NullableContext(2)]
public interface IActivityRewardDataPage
{
	// Token: 0x1700093F RID: 2367
	// (get) Token: 0x06006F07 RID: 28423
	// (set) Token: 0x06006F08 RID: 28424
	string TabName { get; set; }

	// Token: 0x17000940 RID: 2368
	// (get) Token: 0x06006F09 RID: 28425
	// (set) Token: 0x06006F0A RID: 28426
	[Nullable(1)]
	List<IActivityRewardData> DataList { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x17000941 RID: 2369
	// (get) Token: 0x06006F0B RID: 28427
	// (set) Token: 0x06006F0C RID: 28428
	string TabTips { get; set; }

	// Token: 0x17000942 RID: 2370
	// (get) Token: 0x06006F0D RID: 28429
	// (set) Token: 0x06006F0E RID: 28430
	Action<int> TabExtraFunction { get; set; }
}
