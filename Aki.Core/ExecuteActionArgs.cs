using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200001E RID: 30
[NullableContext(2)]
[Nullable(0)]
public struct ExecuteActionArgs
{
	// Token: 0x060000BB RID: 187 RVA: 0x00006831 File Offset: 0x00004A31
	public ExecuteActionArgs(int? TransitionDuration, EAudioFadeCurve? TransitionFadeCurve, AActor Actor)
	{
		this.TransitionDuration = TransitionDuration;
		this.TransitionFadeCurve = TransitionFadeCurve;
		this.Actor = Actor;
	}

	// Token: 0x040000AA RID: 170
	public int? TransitionDuration;

	// Token: 0x040000AB RID: 171
	public EAudioFadeCurve? TransitionFadeCurve;

	// Token: 0x040000AC RID: 172
	public AActor Actor;
}
