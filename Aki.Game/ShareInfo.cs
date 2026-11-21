using System;
using System.Runtime.CompilerServices;

// Token: 0x020002F9 RID: 761
[NullableContext(1)]
[Nullable(0)]
public class ShareInfo : IShareInfo
{
	// Token: 0x17000681 RID: 1665
	// (get) Token: 0x06002B75 RID: 11125 RVA: 0x00105076 File Offset: 0x00103276
	// (set) Token: 0x06002B76 RID: 11126 RVA: 0x0010507E File Offset: 0x0010327E
	public string ImageData { get; set; }

	// Token: 0x17000682 RID: 1666
	// (get) Token: 0x06002B77 RID: 11127 RVA: 0x00105087 File Offset: 0x00103287
	// (set) Token: 0x06002B78 RID: 11128 RVA: 0x0010508F File Offset: 0x0010328F
	public ShareData ShareData { get; set; }
}
