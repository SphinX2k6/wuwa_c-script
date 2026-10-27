using System;
using System.Runtime.CompilerServices;

// Token: 0x02001C9A RID: 7322
[NullableContext(1)]
[Nullable(0)]
public class CommonShowRoleInfo : ICommonShowRoleInfo
{
	// Token: 0x170011FC RID: 4604
	// (get) Token: 0x0600DCFD RID: 56573 RVA: 0x00339111 File Offset: 0x00337311
	// (set) Token: 0x0600DCFE RID: 56574 RVA: 0x00339119 File Offset: 0x00337319
	public IGachaViewOpenData ResultViewData { get; set; }

	// Token: 0x170011FD RID: 4605
	// (get) Token: 0x0600DCFF RID: 56575 RVA: 0x00339122 File Offset: 0x00337322
	// (set) Token: 0x0600DD00 RID: 56576 RVA: 0x0033912A File Offset: 0x0033732A
	public GachaResult[] GachaResult { get; set; }
}
