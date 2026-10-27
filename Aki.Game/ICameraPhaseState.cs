using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200107F RID: 4223
[NullableContext(1)]
internal interface ICameraPhaseState
{
	// Token: 0x170008F2 RID: 2290
	// (get) Token: 0x06006D44 RID: 27972
	// (set) Token: 0x06006D45 RID: 27973
	ECameraPhaseType PhaseType { get; set; }

	// Token: 0x170008F3 RID: 2291
	// (get) Token: 0x06006D46 RID: 27974
	// (set) Token: 0x06006D47 RID: 27975
	Vector StartPos { get; set; }

	// Token: 0x170008F4 RID: 2292
	// (get) Token: 0x06006D48 RID: 27976
	// (set) Token: 0x06006D49 RID: 27977
	Rotator StartRot { get; set; }

	// Token: 0x170008F5 RID: 2293
	// (get) Token: 0x06006D4A RID: 27978
	// (set) Token: 0x06006D4B RID: 27979
	float StartFov { get; set; }

	// Token: 0x170008F6 RID: 2294
	// (get) Token: 0x06006D4C RID: 27980
	// (set) Token: 0x06006D4D RID: 27981
	Vector TargetPos { get; set; }

	// Token: 0x170008F7 RID: 2295
	// (get) Token: 0x06006D4E RID: 27982
	// (set) Token: 0x06006D4F RID: 27983
	Rotator TargetRot { get; set; }

	// Token: 0x170008F8 RID: 2296
	// (get) Token: 0x06006D50 RID: 27984
	// (set) Token: 0x06006D51 RID: 27985
	float TargetFov { get; set; }

	// Token: 0x170008F9 RID: 2297
	// (get) Token: 0x06006D52 RID: 27986
	// (set) Token: 0x06006D53 RID: 27987
	float Duration { get; set; }

	// Token: 0x170008FA RID: 2298
	// (get) Token: 0x06006D54 RID: 27988
	// (set) Token: 0x06006D55 RID: 27989
	float ElapsedTime { get; set; }

	// Token: 0x170008FB RID: 2299
	// (get) Token: 0x06006D56 RID: 27990
	// (set) Token: 0x06006D57 RID: 27991
	FVectorDouble PerformancePos { get; set; }

	// Token: 0x170008FC RID: 2300
	// (get) Token: 0x06006D58 RID: 27992
	// (set) Token: 0x06006D59 RID: 27993
	FRotator PerformanceRot { get; set; }

	// Token: 0x170008FD RID: 2301
	// (get) Token: 0x06006D5A RID: 27994
	// (set) Token: 0x06006D5B RID: 27995
	float PerformanceFov { get; set; }
}
