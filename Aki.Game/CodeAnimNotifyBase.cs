using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200316A RID: 12650
[NullableContext(1)]
[Nullable(0)]
public abstract class CodeAnimNotifyBase
{
	// Token: 0x0601B366 RID: 111462 RVA: 0x0076ADCA File Offset: 0x00768FCA
	public virtual void OnNotify(FKuroCodeFunctionPayload payload)
	{
	}

	// Token: 0x0601B367 RID: 111463 RVA: 0x0076ADCC File Offset: 0x00768FCC
	public virtual void OnNotifyBegin(float totalDuration, FKuroCodeFunctionPayload payload, [Nullable(2)] UAnimSequenceBase animation)
	{
	}

	// Token: 0x0601B368 RID: 111464 RVA: 0x0076ADCE File Offset: 0x00768FCE
	public virtual void OnNotifyTick(float delta, FKuroCodeFunctionPayload payload, [Nullable(2)] UAnimSequenceBase animation)
	{
	}

	// Token: 0x0601B369 RID: 111465 RVA: 0x0076ADD0 File Offset: 0x00768FD0
	public virtual void OnNotifyEnd(FKuroCodeFunctionPayload payload, [Nullable(2)] UAnimSequenceBase animation)
	{
	}
}
