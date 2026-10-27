using System;
using System.Runtime.CompilerServices;

// Token: 0x0200016E RID: 366
[NullableContext(2)]
[Nullable(0)]
internal class AnimNotifyStateUiEffectParams
{
	// Token: 0x0600171A RID: 5914 RVA: 0x0007CEA7 File Offset: 0x0007B0A7
	public AnimNotifyStateUiEffectParams(int? effectHandle, UiEffectAnsContext uiEffectAnsContext, bool hasSeekTo)
	{
		this.EffectHandle = effectHandle;
		this.UiEffectAnsContext = uiEffectAnsContext;
		this.HasSeekTo = hasSeekTo;
	}

	// Token: 0x170003C5 RID: 965
	// (get) Token: 0x0600171B RID: 5915 RVA: 0x0007CEC4 File Offset: 0x0007B0C4
	// (set) Token: 0x0600171C RID: 5916 RVA: 0x0007CECC File Offset: 0x0007B0CC
	public int? EffectHandle { get; set; }

	// Token: 0x170003C6 RID: 966
	// (get) Token: 0x0600171D RID: 5917 RVA: 0x0007CED5 File Offset: 0x0007B0D5
	// (set) Token: 0x0600171E RID: 5918 RVA: 0x0007CEDD File Offset: 0x0007B0DD
	public UiEffectAnsContext UiEffectAnsContext { get; set; }

	// Token: 0x170003C7 RID: 967
	// (get) Token: 0x0600171F RID: 5919 RVA: 0x0007CEE6 File Offset: 0x0007B0E6
	// (set) Token: 0x06001720 RID: 5920 RVA: 0x0007CEEE File Offset: 0x0007B0EE
	public bool HasSeekTo { get; set; }
}
