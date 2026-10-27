using System;
using System.Runtime.CompilerServices;

// Token: 0x02000E44 RID: 3652
[NullableContext(1)]
[Nullable(0)]
public class ShareInfo : IShareInfo
{
	// Token: 0x1700065D RID: 1629
	// (get) Token: 0x060057E5 RID: 22501 RVA: 0x000FD786 File Offset: 0x000FB986
	// (set) Token: 0x060057E6 RID: 22502 RVA: 0x000FD78E File Offset: 0x000FB98E
	public string ImageData { get; set; }

	// Token: 0x1700065E RID: 1630
	// (get) Token: 0x060057E7 RID: 22503 RVA: 0x000FD797 File Offset: 0x000FB997
	// (set) Token: 0x060057E8 RID: 22504 RVA: 0x000FD79F File Offset: 0x000FB99F
	public ShareData ShareData { get; set; }
}
