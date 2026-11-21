using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020026D7 RID: 9943
[NullableContext(1)]
[Nullable(0)]
public abstract class CodeAnimNotifyBase
{
	// Token: 0x06018E6B RID: 101995 RVA: 0x0079272E File Offset: 0x0079092E
	public virtual void OnNotify(FKuroCodeFunctionPayload payload)
	{
	}

	// Token: 0x06018E6C RID: 101996 RVA: 0x00792730 File Offset: 0x00790930
	public virtual void OnNotifyBegin(float totalDuration, FKuroCodeFunctionPayload payload, [Nullable(2)] UAnimSequenceBase animation)
	{
	}

	// Token: 0x06018E6D RID: 101997 RVA: 0x00792732 File Offset: 0x00790932
	public virtual void OnNotifyTick(float delta, FKuroCodeFunctionPayload payload, [Nullable(2)] UAnimSequenceBase animation)
	{
	}

	// Token: 0x06018E6E RID: 101998 RVA: 0x00792734 File Offset: 0x00790934
	public virtual void OnNotifyEnd(FKuroCodeFunctionPayload payload, [Nullable(2)] UAnimSequenceBase animation)
	{
	}
}
