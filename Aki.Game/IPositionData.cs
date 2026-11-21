using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02001AB5 RID: 6837
[NullableContext(1)]
public interface IPositionData
{
	// Token: 0x1700196C RID: 6508
	// (get) Token: 0x06010EDE RID: 69342
	// (set) Token: 0x06010EDF RID: 69343
	string Id { get; set; }

	// Token: 0x1700196D RID: 6509
	// (get) Token: 0x06010EE0 RID: 69344
	// (set) Token: 0x06010EE1 RID: 69345
	FVector2D Vector { get; set; }

	// Token: 0x1700196E RID: 6510
	// (get) Token: 0x06010EE2 RID: 69346
	// (set) Token: 0x06010EE3 RID: 69347
	bool NotShow { get; set; }

	// Token: 0x1700196F RID: 6511
	// (get) Token: 0x06010EE4 RID: 69348
	// (set) Token: 0x06010EE5 RID: 69349
	bool IsOptional { get; set; }

	// Token: 0x17001970 RID: 6512
	// (get) Token: 0x06010EE6 RID: 69350
	// (set) Token: 0x06010EE7 RID: 69351
	bool IsOptionalFinished { get; set; }
}
