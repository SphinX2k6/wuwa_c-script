using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020025CB RID: 9675
[NullableContext(1)]
[Nullable(0)]
public class PositionData : IPositionData
{
	// Token: 0x17001939 RID: 6457
	// (get) Token: 0x06013A08 RID: 80392 RVA: 0x004E8778 File Offset: 0x004E6978
	// (set) Token: 0x06013A09 RID: 80393 RVA: 0x004E8780 File Offset: 0x004E6980
	public string Id { get; set; } = "";

	// Token: 0x1700193A RID: 6458
	// (get) Token: 0x06013A0A RID: 80394 RVA: 0x004E8789 File Offset: 0x004E6989
	// (set) Token: 0x06013A0B RID: 80395 RVA: 0x004E8791 File Offset: 0x004E6991
	public FVector2D Vector { get; set; } = new FVector2D(0f, 0f);

	// Token: 0x1700193B RID: 6459
	// (get) Token: 0x06013A0C RID: 80396 RVA: 0x004E879A File Offset: 0x004E699A
	// (set) Token: 0x06013A0D RID: 80397 RVA: 0x004E87A2 File Offset: 0x004E69A2
	public bool NotShow { get; set; }

	// Token: 0x1700193C RID: 6460
	// (get) Token: 0x06013A0E RID: 80398 RVA: 0x004E87AB File Offset: 0x004E69AB
	// (set) Token: 0x06013A0F RID: 80399 RVA: 0x004E87B3 File Offset: 0x004E69B3
	public bool IsOptional { get; set; }

	// Token: 0x1700193D RID: 6461
	// (get) Token: 0x06013A10 RID: 80400 RVA: 0x004E87BC File Offset: 0x004E69BC
	// (set) Token: 0x06013A11 RID: 80401 RVA: 0x004E87C4 File Offset: 0x004E69C4
	public bool IsOptionalFinished { get; set; }
}
