using System;
using System.Runtime.CompilerServices;

// Token: 0x020029D7 RID: 10711
[NullableContext(2)]
[Nullable(0)]
internal class AnimNotifyStateEffectParams
{
	// Token: 0x0601ADF6 RID: 110070 RVA: 0x00840BE8 File Offset: 0x0083EDE8
	public AnimNotifyStateEffectParams(int? effectHandle, UiEffectAnsContext uiEffectAnsContext, bool hasSeekTo, bool continuousSeek, bool isInUi)
	{
		this.EffectHandle = effectHandle;
		this.UiEffectAnsContext = uiEffectAnsContext;
		this.HasSeekTo = hasSeekTo;
		this.ContinuousSeek = continuousSeek;
		this.IsInUi = isInUi;
	}

	// Token: 0x0400E97D RID: 59773
	public string EffectPath;

	// Token: 0x0400E97E RID: 59774
	public int? EffectHandle;

	// Token: 0x0400E97F RID: 59775
	public UiEffectAnsContext UiEffectAnsContext;

	// Token: 0x0400E980 RID: 59776
	public bool HasSeekTo;

	// Token: 0x0400E981 RID: 59777
	public bool ContinuousSeek;

	// Token: 0x0400E982 RID: 59778
	public bool IsInUi;
}
