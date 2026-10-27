using System;
using System.Runtime.CompilerServices;

// Token: 0x02000265 RID: 613
[NullableContext(2)]
[Nullable(0)]
public class EffectAudioInfo : IEffectAudioInfo
{
	// Token: 0x170005BB RID: 1467
	// (get) Token: 0x06002585 RID: 9605 RVA: 0x000E10F0 File Offset: 0x000DF2F0
	// (set) Token: 0x06002586 RID: 9606 RVA: 0x000E10F8 File Offset: 0x000DF2F8
	public int ActorUid { get; set; }

	// Token: 0x170005BC RID: 1468
	// (get) Token: 0x06002587 RID: 9607 RVA: 0x000E1101 File Offset: 0x000DF301
	// (set) Token: 0x06002588 RID: 9608 RVA: 0x000E1109 File Offset: 0x000DF309
	public object EffectActor { get; set; }

	// Token: 0x170005BD RID: 1469
	// (get) Token: 0x06002589 RID: 9609 RVA: 0x000E1112 File Offset: 0x000DF312
	// (set) Token: 0x0600258A RID: 9610 RVA: 0x000E111A File Offset: 0x000DF31A
	public bool? IsTransform { get; set; }

	// Token: 0x170005BE RID: 1470
	// (get) Token: 0x0600258B RID: 9611 RVA: 0x000E1123 File Offset: 0x000DF323
	// (set) Token: 0x0600258C RID: 9612 RVA: 0x000E112B File Offset: 0x000DF32B
	public Action Callback { get; set; }
}
