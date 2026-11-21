using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200055F RID: 1375
[NullableContext(2)]
[Nullable(0)]
public class ActivityRewardDataPage : IActivityRewardDataPage
{
	// Token: 0x17000963 RID: 2403
	// (get) Token: 0x060042A5 RID: 17061 RVA: 0x00173D5F File Offset: 0x00171F5F
	// (set) Token: 0x060042A6 RID: 17062 RVA: 0x00173D67 File Offset: 0x00171F67
	public string TabName { get; set; }

	// Token: 0x17000964 RID: 2404
	// (get) Token: 0x060042A7 RID: 17063 RVA: 0x00173D70 File Offset: 0x00171F70
	// (set) Token: 0x060042A8 RID: 17064 RVA: 0x00173D78 File Offset: 0x00171F78
	[Nullable(1)]
	public List<IActivityRewardData> DataList { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x17000965 RID: 2405
	// (get) Token: 0x060042A9 RID: 17065 RVA: 0x00173D81 File Offset: 0x00171F81
	// (set) Token: 0x060042AA RID: 17066 RVA: 0x00173D89 File Offset: 0x00171F89
	public string TabTips { get; set; }

	// Token: 0x17000966 RID: 2406
	// (get) Token: 0x060042AB RID: 17067 RVA: 0x00173D92 File Offset: 0x00171F92
	// (set) Token: 0x060042AC RID: 17068 RVA: 0x00173D9A File Offset: 0x00171F9A
	public Action<int> TabExtraFunction { get; set; }
}
