using System;
using System.Runtime.CompilerServices;

// Token: 0x02002753 RID: 10067
[NullableContext(2)]
[Nullable(0)]
public class NpcSitOnChairParams : INpcSitOnChairParams
{
	// Token: 0x17002847 RID: 10311
	// (get) Token: 0x06019437 RID: 103479 RVA: 0x007B72AF File Offset: 0x007B54AF
	// (set) Token: 0x06019438 RID: 103480 RVA: 0x007B72B7 File Offset: 0x007B54B7
	public int ChairEntityId { get; set; }

	// Token: 0x17002848 RID: 10312
	// (get) Token: 0x06019439 RID: 103481 RVA: 0x007B72C0 File Offset: 0x007B54C0
	// (set) Token: 0x0601943A RID: 103482 RVA: 0x007B72C8 File Offset: 0x007B54C8
	public string MontagePath { get; set; }

	// Token: 0x17002849 RID: 10313
	// (get) Token: 0x0601943B RID: 103483 RVA: 0x007B72D1 File Offset: 0x007B54D1
	// (set) Token: 0x0601943C RID: 103484 RVA: 0x007B72D9 File Offset: 0x007B54D9
	[Nullable(1)]
	public Func<bool> InterruptCondition { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x1700284A RID: 10314
	// (get) Token: 0x0601943D RID: 103485 RVA: 0x007B72E2 File Offset: 0x007B54E2
	// (set) Token: 0x0601943E RID: 103486 RVA: 0x007B72EA File Offset: 0x007B54EA
	public Action Finish { get; set; }

	// Token: 0x1700284B RID: 10315
	// (get) Token: 0x0601943F RID: 103487 RVA: 0x007B72F3 File Offset: 0x007B54F3
	// (set) Token: 0x06019440 RID: 103488 RVA: 0x007B72FB File Offset: 0x007B54FB
	public Action Abort { get; set; }

	// Token: 0x1700284C RID: 10316
	// (get) Token: 0x06019441 RID: 103489 RVA: 0x007B7304 File Offset: 0x007B5504
	// (set) Token: 0x06019442 RID: 103490 RVA: 0x007B730C File Offset: 0x007B550C
	public int[] TeleportEffect { get; set; }
}
