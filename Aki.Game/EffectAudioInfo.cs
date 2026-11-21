using System;
using System.Runtime.CompilerServices;

// Token: 0x02000269 RID: 617
[NullableContext(2)]
[Nullable(0)]
public class EffectAudioInfo : IEffectAudioInfo
{
	// Token: 0x170005E2 RID: 1506
	// (get) Token: 0x0600263C RID: 9788 RVA: 0x000E748C File Offset: 0x000E568C
	// (set) Token: 0x0600263D RID: 9789 RVA: 0x000E7494 File Offset: 0x000E5694
	public int ActorUid { get; set; }

	// Token: 0x170005E3 RID: 1507
	// (get) Token: 0x0600263E RID: 9790 RVA: 0x000E749D File Offset: 0x000E569D
	// (set) Token: 0x0600263F RID: 9791 RVA: 0x000E74A5 File Offset: 0x000E56A5
	public object EffectActor { get; set; }

	// Token: 0x170005E4 RID: 1508
	// (get) Token: 0x06002640 RID: 9792 RVA: 0x000E74AE File Offset: 0x000E56AE
	// (set) Token: 0x06002641 RID: 9793 RVA: 0x000E74B6 File Offset: 0x000E56B6
	public bool? IsTransform { get; set; }

	// Token: 0x170005E5 RID: 1509
	// (get) Token: 0x06002642 RID: 9794 RVA: 0x000E74BF File Offset: 0x000E56BF
	// (set) Token: 0x06002643 RID: 9795 RVA: 0x000E74C7 File Offset: 0x000E56C7
	public Action Callback { get; set; }
}
