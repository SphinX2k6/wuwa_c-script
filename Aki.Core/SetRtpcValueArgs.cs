using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02000020 RID: 32
[NullableContext(2)]
[Nullable(0)]
public struct SetRtpcValueArgs
{
	// Token: 0x060000BF RID: 191 RVA: 0x000065D7 File Offset: 0x000047D7
	public SetRtpcValueArgs(int? TransitionDuration, EAudioFadeCurve? TransitionFadeCurve, AActor Actor)
	{
		this.TransitionDuration = TransitionDuration;
		this.TransitionFadeCurve = TransitionFadeCurve;
		this.Actor = Actor;
	}

	// Token: 0x040000B1 RID: 177
	public int? TransitionDuration;

	// Token: 0x040000B2 RID: 178
	public EAudioFadeCurve? TransitionFadeCurve;

	// Token: 0x040000B3 RID: 179
	public AActor Actor;
}
