using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02001AC5 RID: 6853
[NullableContext(1)]
[Nullable(0)]
public class PhotoPositionData : IPositionData
{
	// Token: 0x17001979 RID: 6521
	// (get) Token: 0x06010FD4 RID: 69588 RVA: 0x004FC9E0 File Offset: 0x004FABE0
	// (set) Token: 0x06010FD5 RID: 69589 RVA: 0x004FC9E8 File Offset: 0x004FABE8
	public string Id { get; set; } = "";

	// Token: 0x1700197A RID: 6522
	// (get) Token: 0x06010FD6 RID: 69590 RVA: 0x004FC9F1 File Offset: 0x004FABF1
	// (set) Token: 0x06010FD7 RID: 69591 RVA: 0x004FC9F9 File Offset: 0x004FABF9
	public FVector2D Vector { get; set; } = new FVector2D(0f, 0f);

	// Token: 0x1700197B RID: 6523
	// (get) Token: 0x06010FD8 RID: 69592 RVA: 0x004FCA02 File Offset: 0x004FAC02
	// (set) Token: 0x06010FD9 RID: 69593 RVA: 0x004FCA0A File Offset: 0x004FAC0A
	public bool NotShow { get; set; }

	// Token: 0x1700197C RID: 6524
	// (get) Token: 0x06010FDA RID: 69594 RVA: 0x004FCA13 File Offset: 0x004FAC13
	// (set) Token: 0x06010FDB RID: 69595 RVA: 0x004FCA1B File Offset: 0x004FAC1B
	public bool IsOptional { get; set; }

	// Token: 0x1700197D RID: 6525
	// (get) Token: 0x06010FDC RID: 69596 RVA: 0x004FCA24 File Offset: 0x004FAC24
	// (set) Token: 0x06010FDD RID: 69597 RVA: 0x004FCA2C File Offset: 0x004FAC2C
	public bool IsOptionalFinished { get; set; }
}
