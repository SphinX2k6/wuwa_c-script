using System;
using System.Runtime.CompilerServices;

// Token: 0x02000566 RID: 1382
[NullableContext(2)]
[Nullable(0)]
public class ActivityFunctionAreaParams : IActivityFunctionAreaParams
{
	// Token: 0x17000975 RID: 2421
	// (get) Token: 0x060042D4 RID: 17108 RVA: 0x00173F46 File Offset: 0x00172146
	// (set) Token: 0x060042D5 RID: 17109 RVA: 0x00173F4E File Offset: 0x0017214E
	public string UnlockBtnTextId { get; set; }

	// Token: 0x17000976 RID: 2422
	// (get) Token: 0x060042D6 RID: 17110 RVA: 0x00173F57 File Offset: 0x00172157
	// (set) Token: 0x060042D7 RID: 17111 RVA: 0x00173F5F File Offset: 0x0017215F
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public string[] UnlockBtnTextArgs { [return: Nullable(new byte[]
	{
		2,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1
	})] set; }

	// Token: 0x17000977 RID: 2423
	// (get) Token: 0x060042D8 RID: 17112 RVA: 0x00173F68 File Offset: 0x00172168
	// (set) Token: 0x060042D9 RID: 17113 RVA: 0x00173F70 File Offset: 0x00172170
	public Action UnlockBtnFunction { get; set; }

	// Token: 0x17000978 RID: 2424
	// (get) Token: 0x060042DA RID: 17114 RVA: 0x00173F79 File Offset: 0x00172179
	// (set) Token: 0x060042DB RID: 17115 RVA: 0x00173F81 File Offset: 0x00172181
	public Func<bool> BeforePreOpenCheck { get; set; }
}
