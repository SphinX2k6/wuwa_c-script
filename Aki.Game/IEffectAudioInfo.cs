using System;
using System.Runtime.CompilerServices;

// Token: 0x02000264 RID: 612
[NullableContext(2)]
public interface IEffectAudioInfo
{
	// Token: 0x170005B7 RID: 1463
	// (get) Token: 0x0600257D RID: 9597
	// (set) Token: 0x0600257E RID: 9598
	int ActorUid { get; set; }

	// Token: 0x170005B8 RID: 1464
	// (get) Token: 0x0600257F RID: 9599
	// (set) Token: 0x06002580 RID: 9600
	object EffectActor { get; set; }

	// Token: 0x170005B9 RID: 1465
	// (get) Token: 0x06002581 RID: 9601
	// (set) Token: 0x06002582 RID: 9602
	bool? IsTransform { get; set; }

	// Token: 0x170005BA RID: 1466
	// (get) Token: 0x06002583 RID: 9603
	// (set) Token: 0x06002584 RID: 9604
	Action Callback { get; set; }
}
