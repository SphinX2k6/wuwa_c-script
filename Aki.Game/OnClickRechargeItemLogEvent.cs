using System;
using System.Runtime.CompilerServices;

// Token: 0x020015CE RID: 5582
[NullableContext(1)]
[Nullable(0)]
public class OnClickRechargeItemLogEvent : PlayerCommonLogData
{
	// Token: 0x170014CA RID: 5322
	// (get) Token: 0x0600DD91 RID: 56721 RVA: 0x004177AF File Offset: 0x004159AF
	// (set) Token: 0x0600DD92 RID: 56722 RVA: 0x004177B7 File Offset: 0x004159B7
	public override string event_id { get; set; } = "1830";

	// Token: 0x04007D48 RID: 32072
	public int i_id;

	// Token: 0x04007D49 RID: 32073
	public int i_shop_id;
}
