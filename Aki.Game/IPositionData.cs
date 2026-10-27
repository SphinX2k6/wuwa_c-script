using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020025CA RID: 9674
[NullableContext(1)]
public interface IPositionData
{
	// Token: 0x17001934 RID: 6452
	// (get) Token: 0x060139FE RID: 80382
	// (set) Token: 0x060139FF RID: 80383
	string Id { get; set; }

	// Token: 0x17001935 RID: 6453
	// (get) Token: 0x06013A00 RID: 80384
	// (set) Token: 0x06013A01 RID: 80385
	FVector2D Vector { get; set; }

	// Token: 0x17001936 RID: 6454
	// (get) Token: 0x06013A02 RID: 80386
	// (set) Token: 0x06013A03 RID: 80387
	bool NotShow { get; set; }

	// Token: 0x17001937 RID: 6455
	// (get) Token: 0x06013A04 RID: 80388
	// (set) Token: 0x06013A05 RID: 80389
	bool IsOptional { get; set; }

	// Token: 0x17001938 RID: 6456
	// (get) Token: 0x06013A06 RID: 80390
	// (set) Token: 0x06013A07 RID: 80391
	bool IsOptionalFinished { get; set; }
}
