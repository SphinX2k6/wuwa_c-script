using System;
using System.Runtime.CompilerServices;

// Token: 0x020010B2 RID: 4274
[NullableContext(2)]
[Nullable(0)]
public class ActivityFunctionAreaParams : IActivityFunctionAreaParams
{
	// Token: 0x17000955 RID: 2389
	// (get) Token: 0x06006F3E RID: 28478 RVA: 0x0016B5CE File Offset: 0x001697CE
	// (set) Token: 0x06006F3F RID: 28479 RVA: 0x0016B5D6 File Offset: 0x001697D6
	public string UnlockBtnTextId { get; set; }

	// Token: 0x17000956 RID: 2390
	// (get) Token: 0x06006F40 RID: 28480 RVA: 0x0016B5DF File Offset: 0x001697DF
	// (set) Token: 0x06006F41 RID: 28481 RVA: 0x0016B5E7 File Offset: 0x001697E7
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

	// Token: 0x17000957 RID: 2391
	// (get) Token: 0x06006F42 RID: 28482 RVA: 0x0016B5F0 File Offset: 0x001697F0
	// (set) Token: 0x06006F43 RID: 28483 RVA: 0x0016B5F8 File Offset: 0x001697F8
	public Action UnlockBtnFunction { get; set; }

	// Token: 0x17000958 RID: 2392
	// (get) Token: 0x06006F44 RID: 28484 RVA: 0x0016B601 File Offset: 0x00169801
	// (set) Token: 0x06006F45 RID: 28485 RVA: 0x0016B609 File Offset: 0x00169809
	public Func<bool> BeforePreOpenCheck { get; set; }
}
