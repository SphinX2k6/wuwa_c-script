using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02001D4D RID: 7501
[NullableContext(1)]
public interface IStopGamepadShake
{
	// Token: 0x17001227 RID: 4647
	// (get) Token: 0x0600E382 RID: 58242
	// (set) Token: 0x0600E383 RID: 58243
	FName Tag { get; set; }

	// Token: 0x17001228 RID: 4648
	// (get) Token: 0x0600E384 RID: 58244
	// (set) Token: 0x0600E385 RID: 58245
	UKuroForceFeedbackEffect GamepadShakeAsset { get; set; }

	// Token: 0x17001229 RID: 4649
	// (get) Token: 0x0600E386 RID: 58246
	// (set) Token: 0x0600E387 RID: 58247
	UForceFeedbackComponent FeedbackComponent { get; set; }
}
