using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020022BB RID: 8891
[NullableContext(1)]
[Nullable(0)]
public class AlbumTimeInfo : IAlbumTimeInfo
{
	// Token: 0x1700162D RID: 5677
	// (get) Token: 0x060116F9 RID: 71417 RVA: 0x004457AF File Offset: 0x004439AF
	// (set) Token: 0x060116FA RID: 71418 RVA: 0x004457B7 File Offset: 0x004439B7
	public int AlbumId { get; set; }

	// Token: 0x1700162E RID: 5678
	// (get) Token: 0x060116FB RID: 71419 RVA: 0x004457C0 File Offset: 0x004439C0
	// (set) Token: 0x060116FC RID: 71420 RVA: 0x004457C8 File Offset: 0x004439C8
	public long BeginTime { get; set; }

	// Token: 0x1700162F RID: 5679
	// (get) Token: 0x060116FD RID: 71421 RVA: 0x004457D1 File Offset: 0x004439D1
	// (set) Token: 0x060116FE RID: 71422 RVA: 0x004457D9 File Offset: 0x004439D9
	public long EndTime { get; set; }

	// Token: 0x17001630 RID: 5680
	// (get) Token: 0x060116FF RID: 71423 RVA: 0x004457E2 File Offset: 0x004439E2
	// (set) Token: 0x06011700 RID: 71424 RVA: 0x004457EA File Offset: 0x004439EA
	public HashSet<int> MusicIds { get; set; } = new HashSet<int>();
}
