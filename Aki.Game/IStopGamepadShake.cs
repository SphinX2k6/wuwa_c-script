using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200120F RID: 4623
[NullableContext(1)]
public interface IStopGamepadShake
{
	// Token: 0x17001251 RID: 4689
	// (get) Token: 0x0600B79F RID: 47007
	// (set) Token: 0x0600B7A0 RID: 47008
	FName Tag { get; set; }

	// Token: 0x17001252 RID: 4690
	// (get) Token: 0x0600B7A1 RID: 47009
	// (set) Token: 0x0600B7A2 RID: 47010
	UKuroForceFeedbackEffect GamepadShakeAsset { get; set; }

	// Token: 0x17001253 RID: 4691
	// (get) Token: 0x0600B7A3 RID: 47011
	// (set) Token: 0x0600B7A4 RID: 47012
	UForceFeedbackComponent FeedbackComponent { get; set; }
}
