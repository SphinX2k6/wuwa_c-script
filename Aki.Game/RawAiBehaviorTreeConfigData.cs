using System;
using System.Runtime.CompilerServices;

// Token: 0x020034EF RID: 13551
[NullableContext(1)]
[Nullable(0)]
public class RawAiBehaviorTreeConfigData
{
	// Token: 0x170028F1 RID: 10481
	// (get) Token: 0x0601DB6B RID: 121707 RVA: 0x00853EF6 File Offset: 0x008520F6
	// (set) Token: 0x0601DB6C RID: 121708 RVA: 0x00853EFE File Offset: 0x008520FE
	public int Id { get; set; }

	// Token: 0x170028F2 RID: 10482
	// (get) Token: 0x0601DB6D RID: 121709 RVA: 0x00853F07 File Offset: 0x00852107
	// (set) Token: 0x0601DB6E RID: 121710 RVA: 0x00853F0F File Offset: 0x0085210F
	public string Description { get; set; } = "";

	// Token: 0x170028F3 RID: 10483
	// (get) Token: 0x0601DB6F RID: 121711 RVA: 0x00853F18 File Offset: 0x00852118
	// (set) Token: 0x0601DB70 RID: 121712 RVA: 0x00853F20 File Offset: 0x00852120
	public string BtPath { get; set; } = "";

	// Token: 0x170028F4 RID: 10484
	// (get) Token: 0x0601DB71 RID: 121713 RVA: 0x00853F29 File Offset: 0x00852129
	// (set) Token: 0x0601DB72 RID: 121714 RVA: 0x00853F31 File Offset: 0x00852131
	public string BtType { get; set; } = "";
}
