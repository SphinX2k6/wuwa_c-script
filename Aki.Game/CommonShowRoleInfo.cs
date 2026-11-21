using System;
using System.Runtime.CompilerServices;

// Token: 0x02001159 RID: 4441
[NullableContext(1)]
[Nullable(0)]
public class CommonShowRoleInfo : ICommonShowRoleInfo
{
	// Token: 0x17001222 RID: 4642
	// (get) Token: 0x0600B113 RID: 45331 RVA: 0x00344659 File Offset: 0x00342859
	// (set) Token: 0x0600B114 RID: 45332 RVA: 0x00344661 File Offset: 0x00342861
	public IGachaViewOpenData ResultViewData { get; set; }

	// Token: 0x17001223 RID: 4643
	// (get) Token: 0x0600B115 RID: 45333 RVA: 0x0034466A File Offset: 0x0034286A
	// (set) Token: 0x0600B116 RID: 45334 RVA: 0x00344672 File Offset: 0x00342872
	public GachaResult[] GachaResult { get; set; }
}
