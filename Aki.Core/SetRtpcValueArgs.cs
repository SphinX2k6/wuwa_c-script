using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02000020 RID: 32
[NullableContext(2)]
[Nullable(0)]
public struct SetRtpcValueArgs
{
	// Token: 0x060000BD RID: 189 RVA: 0x0000685F File Offset: 0x00004A5F
	public SetRtpcValueArgs(int? TransitionDuration, EAudioFadeCurve? TransitionFadeCurve, AActor Actor)
	{
		this.TransitionDuration = TransitionDuration;
		this.TransitionFadeCurve = TransitionFadeCurve;
		this.Actor = Actor;
	}

	// Token: 0x040000B0 RID: 176
	public int? TransitionDuration;

	// Token: 0x040000B1 RID: 177
	public EAudioFadeCurve? TransitionFadeCurve;

	// Token: 0x040000B2 RID: 178
	public AActor Actor;
}
