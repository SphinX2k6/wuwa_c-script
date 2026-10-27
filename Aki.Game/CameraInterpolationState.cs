using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Gameplay.RhythmGame;

// Token: 0x0200107E RID: 4222
[NullableContext(1)]
[Nullable(0)]
internal class CameraInterpolationState : ICameraInterpolationState
{
	// Token: 0x170008E5 RID: 2277
	// (get) Token: 0x06006D29 RID: 27945 RVA: 0x00161373 File Offset: 0x0015F573
	// (set) Token: 0x06006D2A RID: 27946 RVA: 0x0016137B File Offset: 0x0015F57B
	public Vector StartPos { get; set; } = Vector.Create();

	// Token: 0x170008E6 RID: 2278
	// (get) Token: 0x06006D2B RID: 27947 RVA: 0x00161384 File Offset: 0x0015F584
	// (set) Token: 0x06006D2C RID: 27948 RVA: 0x0016138C File Offset: 0x0015F58C
	public Rotator StartRot { get; set; } = Rotator.Create();

	// Token: 0x170008E7 RID: 2279
	// (get) Token: 0x06006D2D RID: 27949 RVA: 0x00161395 File Offset: 0x0015F595
	// (set) Token: 0x06006D2E RID: 27950 RVA: 0x0016139D File Offset: 0x0015F59D
	public float StartFov { get; set; }

	// Token: 0x170008E8 RID: 2280
	// (get) Token: 0x06006D2F RID: 27951 RVA: 0x001613A6 File Offset: 0x0015F5A6
	// (set) Token: 0x06006D30 RID: 27952 RVA: 0x001613AE File Offset: 0x0015F5AE
	public Vector TargetPos { get; set; } = Vector.Create();

	// Token: 0x170008E9 RID: 2281
	// (get) Token: 0x06006D31 RID: 27953 RVA: 0x001613B7 File Offset: 0x0015F5B7
	// (set) Token: 0x06006D32 RID: 27954 RVA: 0x001613BF File Offset: 0x0015F5BF
	public Rotator TargetRot { get; set; } = Rotator.Create();

	// Token: 0x170008EA RID: 2282
	// (get) Token: 0x06006D33 RID: 27955 RVA: 0x001613C8 File Offset: 0x0015F5C8
	// (set) Token: 0x06006D34 RID: 27956 RVA: 0x001613D0 File Offset: 0x0015F5D0
	public float TargetFov { get; set; }

	// Token: 0x170008EB RID: 2283
	// (get) Token: 0x06006D35 RID: 27957 RVA: 0x001613D9 File Offset: 0x0015F5D9
	// (set) Token: 0x06006D36 RID: 27958 RVA: 0x001613E1 File Offset: 0x0015F5E1
	public Vector CurrentPos { get; set; } = Vector.Create();

	// Token: 0x170008EC RID: 2284
	// (get) Token: 0x06006D37 RID: 27959 RVA: 0x001613EA File Offset: 0x0015F5EA
	// (set) Token: 0x06006D38 RID: 27960 RVA: 0x001613F2 File Offset: 0x0015F5F2
	public Rotator CurrentRot { get; set; } = Rotator.Create();

	// Token: 0x170008ED RID: 2285
	// (get) Token: 0x06006D39 RID: 27961 RVA: 0x001613FB File Offset: 0x0015F5FB
	// (set) Token: 0x06006D3A RID: 27962 RVA: 0x00161403 File Offset: 0x0015F603
	public float CurrentFov { get; set; }

	// Token: 0x170008EE RID: 2286
	// (get) Token: 0x06006D3B RID: 27963 RVA: 0x0016140C File Offset: 0x0015F60C
	// (set) Token: 0x06006D3C RID: 27964 RVA: 0x00161414 File Offset: 0x0015F614
	public bool IsInterpolating { get; set; }

	// Token: 0x170008EF RID: 2287
	// (get) Token: 0x06006D3D RID: 27965 RVA: 0x0016141D File Offset: 0x0015F61D
	// (set) Token: 0x06006D3E RID: 27966 RVA: 0x00161425 File Offset: 0x0015F625
	public float InterpolationDuration { get; set; }

	// Token: 0x170008F0 RID: 2288
	// (get) Token: 0x06006D3F RID: 27967 RVA: 0x0016142E File Offset: 0x0015F62E
	// (set) Token: 0x06006D40 RID: 27968 RVA: 0x00161436 File Offset: 0x0015F636
	public float ElapsedTime { get; set; }

	// Token: 0x170008F1 RID: 2289
	// (get) Token: 0x06006D41 RID: 27969 RVA: 0x0016143F File Offset: 0x0015F63F
	// (set) Token: 0x06006D42 RID: 27970 RVA: 0x00161447 File Offset: 0x0015F647
	[Nullable(2)]
	public RhythmGameSpeedLevelConfig PrevConfig { [NullableContext(2)] get; [NullableContext(2)] set; }
}
