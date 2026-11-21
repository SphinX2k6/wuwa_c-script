using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200001E RID: 30
[NullableContext(2)]
[Nullable(0)]
public struct ExecuteActionArgs
{
	// Token: 0x060000BD RID: 189 RVA: 0x000065A9 File Offset: 0x000047A9
	public ExecuteActionArgs(int? TransitionDuration, EAudioFadeCurve? TransitionFadeCurve, AActor Actor)
	{
		this.TransitionDuration = TransitionDuration;
		this.TransitionFadeCurve = TransitionFadeCurve;
		this.Actor = Actor;
	}

	// Token: 0x040000AB RID: 171
	public int? TransitionDuration;

	// Token: 0x040000AC RID: 172
	public EAudioFadeCurve? TransitionFadeCurve;

	// Token: 0x040000AD RID: 173
	public AActor Actor;
}
