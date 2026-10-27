using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02001080 RID: 4224
[NullableContext(1)]
[Nullable(0)]
internal class CameraPhaseState : ICameraPhaseState
{
	// Token: 0x170008FE RID: 2302
	// (get) Token: 0x06006D5C RID: 27996 RVA: 0x001614A5 File Offset: 0x0015F6A5
	// (set) Token: 0x06006D5D RID: 27997 RVA: 0x001614AD File Offset: 0x0015F6AD
	public ECameraPhaseType PhaseType { get; set; }

	// Token: 0x170008FF RID: 2303
	// (get) Token: 0x06006D5E RID: 27998 RVA: 0x001614B6 File Offset: 0x0015F6B6
	// (set) Token: 0x06006D5F RID: 27999 RVA: 0x001614BE File Offset: 0x0015F6BE
	public Vector StartPos { get; set; } = Vector.Create();

	// Token: 0x17000900 RID: 2304
	// (get) Token: 0x06006D60 RID: 28000 RVA: 0x001614C7 File Offset: 0x0015F6C7
	// (set) Token: 0x06006D61 RID: 28001 RVA: 0x001614CF File Offset: 0x0015F6CF
	public Rotator StartRot { get; set; } = Rotator.Create();

	// Token: 0x17000901 RID: 2305
	// (get) Token: 0x06006D62 RID: 28002 RVA: 0x001614D8 File Offset: 0x0015F6D8
	// (set) Token: 0x06006D63 RID: 28003 RVA: 0x001614E0 File Offset: 0x0015F6E0
	public float StartFov { get; set; }

	// Token: 0x17000902 RID: 2306
	// (get) Token: 0x06006D64 RID: 28004 RVA: 0x001614E9 File Offset: 0x0015F6E9
	// (set) Token: 0x06006D65 RID: 28005 RVA: 0x001614F1 File Offset: 0x0015F6F1
	public Vector TargetPos { get; set; } = Vector.Create();

	// Token: 0x17000903 RID: 2307
	// (get) Token: 0x06006D66 RID: 28006 RVA: 0x001614FA File Offset: 0x0015F6FA
	// (set) Token: 0x06006D67 RID: 28007 RVA: 0x00161502 File Offset: 0x0015F702
	public Rotator TargetRot { get; set; } = Rotator.Create();

	// Token: 0x17000904 RID: 2308
	// (get) Token: 0x06006D68 RID: 28008 RVA: 0x0016150B File Offset: 0x0015F70B
	// (set) Token: 0x06006D69 RID: 28009 RVA: 0x00161513 File Offset: 0x0015F713
	public float TargetFov { get; set; }

	// Token: 0x17000905 RID: 2309
	// (get) Token: 0x06006D6A RID: 28010 RVA: 0x0016151C File Offset: 0x0015F71C
	// (set) Token: 0x06006D6B RID: 28011 RVA: 0x00161524 File Offset: 0x0015F724
	public float Duration { get; set; }

	// Token: 0x17000906 RID: 2310
	// (get) Token: 0x06006D6C RID: 28012 RVA: 0x0016152D File Offset: 0x0015F72D
	// (set) Token: 0x06006D6D RID: 28013 RVA: 0x00161535 File Offset: 0x0015F735
	public float ElapsedTime { get; set; }

	// Token: 0x17000907 RID: 2311
	// (get) Token: 0x06006D6E RID: 28014 RVA: 0x0016153E File Offset: 0x0015F73E
	// (set) Token: 0x06006D6F RID: 28015 RVA: 0x00161546 File Offset: 0x0015F746
	public FVectorDouble PerformancePos { get; set; }

	// Token: 0x17000908 RID: 2312
	// (get) Token: 0x06006D70 RID: 28016 RVA: 0x0016154F File Offset: 0x0015F74F
	// (set) Token: 0x06006D71 RID: 28017 RVA: 0x00161557 File Offset: 0x0015F757
	public FRotator PerformanceRot { get; set; }

	// Token: 0x17000909 RID: 2313
	// (get) Token: 0x06006D72 RID: 28018 RVA: 0x00161560 File Offset: 0x0015F760
	// (set) Token: 0x06006D73 RID: 28019 RVA: 0x00161568 File Offset: 0x0015F768
	public float PerformanceFov { get; set; }
}
