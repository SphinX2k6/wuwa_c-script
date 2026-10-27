using System;
using System.Runtime.CompilerServices;

// Token: 0x02003463 RID: 13411
[NullableContext(2)]
[Nullable(0)]
internal class AnimNotifyStateEffectParams
{
	// Token: 0x0601D0F8 RID: 119032 RVA: 0x00819D64 File Offset: 0x00817F64
	public AnimNotifyStateEffectParams(int? effectHandle, UiEffectAnsContext uiEffectAnsContext, bool hasSeekTo, bool continuousSeek, bool isInUi)
	{
		this.EffectHandle = effectHandle;
		this.UiEffectAnsContext = uiEffectAnsContext;
		this.HasSeekTo = hasSeekTo;
		this.ContinuousSeek = continuousSeek;
		this.IsInUi = isInUi;
	}

	// Token: 0x0400E4CC RID: 58572
	public int? EffectHandle;

	// Token: 0x0400E4CD RID: 58573
	public UiEffectAnsContext UiEffectAnsContext;

	// Token: 0x0400E4CE RID: 58574
	public bool HasSeekTo;

	// Token: 0x0400E4CF RID: 58575
	public bool ContinuousSeek;

	// Token: 0x0400E4D0 RID: 58576
	public bool IsInUi;
}
