using System;
using System.Runtime.CompilerServices;

// Token: 0x0200155D RID: 5469
[NullableContext(1)]
[Nullable(0)]
public class LoginInfo : ILoginInfo
{
	// Token: 0x1700146F RID: 5231
	// (get) Token: 0x0600DAB7 RID: 55991 RVA: 0x0040B71D File Offset: 0x0040991D
	// (set) Token: 0x0600DAB8 RID: 55992 RVA: 0x0040B725 File Offset: 0x00409925
	public int LoginCode { get; set; }

	// Token: 0x17001470 RID: 5232
	// (get) Token: 0x0600DAB9 RID: 55993 RVA: 0x0040B72E File Offset: 0x0040992E
	// (set) Token: 0x0600DABA RID: 55994 RVA: 0x0040B736 File Offset: 0x00409936
	public string Uid { get; set; }

	// Token: 0x17001471 RID: 5233
	// (get) Token: 0x0600DABB RID: 55995 RVA: 0x0040B73F File Offset: 0x0040993F
	// (set) Token: 0x0600DABC RID: 55996 RVA: 0x0040B747 File Offset: 0x00409947
	public string UserName { get; set; }

	// Token: 0x17001472 RID: 5234
	// (get) Token: 0x0600DABD RID: 55997 RVA: 0x0040B750 File Offset: 0x00409950
	// (set) Token: 0x0600DABE RID: 55998 RVA: 0x0040B758 File Offset: 0x00409958
	public string Token { get; set; }
}
