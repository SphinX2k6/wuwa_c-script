using System;
using System.Runtime.CompilerServices;

// Token: 0x02000268 RID: 616
[NullableContext(2)]
public interface IEffectAudioInfo
{
	// Token: 0x170005DE RID: 1502
	// (get) Token: 0x06002634 RID: 9780
	// (set) Token: 0x06002635 RID: 9781
	int ActorUid { get; set; }

	// Token: 0x170005DF RID: 1503
	// (get) Token: 0x06002636 RID: 9782
	// (set) Token: 0x06002637 RID: 9783
	object EffectActor { get; set; }

	// Token: 0x170005E0 RID: 1504
	// (get) Token: 0x06002638 RID: 9784
	// (set) Token: 0x06002639 RID: 9785
	bool? IsTransform { get; set; }

	// Token: 0x170005E1 RID: 1505
	// (get) Token: 0x0600263A RID: 9786
	// (set) Token: 0x0600263B RID: 9787
	Action Callback { get; set; }
}
