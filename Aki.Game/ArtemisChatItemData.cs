using System;
using System.Runtime.CompilerServices;

// Token: 0x020010F3 RID: 4339
[NullableContext(1)]
[Nullable(0)]
public class ArtemisChatItemData : IArtemisChatItemData
{
	// Token: 0x17000992 RID: 2450
	// (get) Token: 0x06007122 RID: 28962 RVA: 0x001719B1 File Offset: 0x0016FBB1
	// (set) Token: 0x06007123 RID: 28963 RVA: 0x001719B9 File Offset: 0x0016FBB9
	public string Content { get; set; } = "";

	// Token: 0x17000993 RID: 2451
	// (get) Token: 0x06007124 RID: 28964 RVA: 0x001719C2 File Offset: 0x0016FBC2
	// (set) Token: 0x06007125 RID: 28965 RVA: 0x001719CA File Offset: 0x0016FBCA
	public string PicturePath { get; set; } = "";

	// Token: 0x17000994 RID: 2452
	// (get) Token: 0x06007126 RID: 28966 RVA: 0x001719D3 File Offset: 0x0016FBD3
	// (set) Token: 0x06007127 RID: 28967 RVA: 0x001719DB File Offset: 0x0016FBDB
	public bool IsLock { get; set; }

	// Token: 0x17000995 RID: 2453
	// (get) Token: 0x06007128 RID: 28968 RVA: 0x001719E4 File Offset: 0x0016FBE4
	// (set) Token: 0x06007129 RID: 28969 RVA: 0x001719EC File Offset: 0x0016FBEC
	public bool IsShowEffect { get; set; }
}
