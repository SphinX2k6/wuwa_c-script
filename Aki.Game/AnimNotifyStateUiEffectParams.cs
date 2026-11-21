using System;
using System.Runtime.CompilerServices;

// Token: 0x02000172 RID: 370
[NullableContext(2)]
[Nullable(0)]
internal class AnimNotifyStateUiEffectParams
{
	// Token: 0x060017B7 RID: 6071 RVA: 0x00082A8F File Offset: 0x00080C8F
	public AnimNotifyStateUiEffectParams(int? effectHandle, UiEffectAnsContext uiEffectAnsContext, bool hasSeekTo)
	{
		this.EffectHandle = effectHandle;
		this.UiEffectAnsContext = uiEffectAnsContext;
		this.HasSeekTo = hasSeekTo;
	}

	// Token: 0x170003E7 RID: 999
	// (get) Token: 0x060017B8 RID: 6072 RVA: 0x00082AAC File Offset: 0x00080CAC
	// (set) Token: 0x060017B9 RID: 6073 RVA: 0x00082AB4 File Offset: 0x00080CB4
	public int? EffectHandle { get; set; }

	// Token: 0x170003E8 RID: 1000
	// (get) Token: 0x060017BA RID: 6074 RVA: 0x00082ABD File Offset: 0x00080CBD
	// (set) Token: 0x060017BB RID: 6075 RVA: 0x00082AC5 File Offset: 0x00080CC5
	public UiEffectAnsContext UiEffectAnsContext { get; set; }

	// Token: 0x170003E9 RID: 1001
	// (get) Token: 0x060017BC RID: 6076 RVA: 0x00082ACE File Offset: 0x00080CCE
	// (set) Token: 0x060017BD RID: 6077 RVA: 0x00082AD6 File Offset: 0x00080CD6
	public bool HasSeekTo { get; set; }
}
