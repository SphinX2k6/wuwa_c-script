using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02001AB6 RID: 6838
[NullableContext(1)]
[Nullable(0)]
public class PositionData : IPositionData
{
	// Token: 0x17001971 RID: 6513
	// (get) Token: 0x06010EE8 RID: 69352 RVA: 0x004F7378 File Offset: 0x004F5578
	// (set) Token: 0x06010EE9 RID: 69353 RVA: 0x004F7380 File Offset: 0x004F5580
	public string Id { get; set; } = "";

	// Token: 0x17001972 RID: 6514
	// (get) Token: 0x06010EEA RID: 69354 RVA: 0x004F7389 File Offset: 0x004F5589
	// (set) Token: 0x06010EEB RID: 69355 RVA: 0x004F7391 File Offset: 0x004F5591
	public FVector2D Vector { get; set; } = new FVector2D(0f, 0f);

	// Token: 0x17001973 RID: 6515
	// (get) Token: 0x06010EEC RID: 69356 RVA: 0x004F739A File Offset: 0x004F559A
	// (set) Token: 0x06010EED RID: 69357 RVA: 0x004F73A2 File Offset: 0x004F55A2
	public bool NotShow { get; set; }

	// Token: 0x17001974 RID: 6516
	// (get) Token: 0x06010EEE RID: 69358 RVA: 0x004F73AB File Offset: 0x004F55AB
	// (set) Token: 0x06010EEF RID: 69359 RVA: 0x004F73B3 File Offset: 0x004F55B3
	public bool IsOptional { get; set; }

	// Token: 0x17001975 RID: 6517
	// (get) Token: 0x06010EF0 RID: 69360 RVA: 0x004F73BC File Offset: 0x004F55BC
	// (set) Token: 0x06010EF1 RID: 69361 RVA: 0x004F73C4 File Offset: 0x004F55C4
	public bool IsOptionalFinished { get; set; }
}
