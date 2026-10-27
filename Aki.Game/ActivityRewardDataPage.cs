using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020010AB RID: 4267
[NullableContext(2)]
[Nullable(0)]
public class ActivityRewardDataPage : IActivityRewardDataPage
{
	// Token: 0x17000943 RID: 2371
	// (get) Token: 0x06006F0F RID: 28431 RVA: 0x0016B3E7 File Offset: 0x001695E7
	// (set) Token: 0x06006F10 RID: 28432 RVA: 0x0016B3EF File Offset: 0x001695EF
	public string TabName { get; set; }

	// Token: 0x17000944 RID: 2372
	// (get) Token: 0x06006F11 RID: 28433 RVA: 0x0016B3F8 File Offset: 0x001695F8
	// (set) Token: 0x06006F12 RID: 28434 RVA: 0x0016B400 File Offset: 0x00169600
	[Nullable(1)]
	public List<IActivityRewardData> DataList { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x17000945 RID: 2373
	// (get) Token: 0x06006F13 RID: 28435 RVA: 0x0016B409 File Offset: 0x00169609
	// (set) Token: 0x06006F14 RID: 28436 RVA: 0x0016B411 File Offset: 0x00169611
	public string TabTips { get; set; }

	// Token: 0x17000946 RID: 2374
	// (get) Token: 0x06006F15 RID: 28437 RVA: 0x0016B41A File Offset: 0x0016961A
	// (set) Token: 0x06006F16 RID: 28438 RVA: 0x0016B422 File Offset: 0x00169622
	public Action<int> TabExtraFunction { get; set; }
}
