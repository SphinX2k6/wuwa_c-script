using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Gameplay.RhythmGame;

// Token: 0x0200107D RID: 4221
[NullableContext(1)]
internal interface ICameraInterpolationState
{
	// Token: 0x170008D8 RID: 2264
	// (get) Token: 0x06006D0F RID: 27919
	// (set) Token: 0x06006D10 RID: 27920
	Vector StartPos { get; set; }

	// Token: 0x170008D9 RID: 2265
	// (get) Token: 0x06006D11 RID: 27921
	// (set) Token: 0x06006D12 RID: 27922
	Rotator StartRot { get; set; }

	// Token: 0x170008DA RID: 2266
	// (get) Token: 0x06006D13 RID: 27923
	// (set) Token: 0x06006D14 RID: 27924
	float StartFov { get; set; }

	// Token: 0x170008DB RID: 2267
	// (get) Token: 0x06006D15 RID: 27925
	// (set) Token: 0x06006D16 RID: 27926
	Vector TargetPos { get; set; }

	// Token: 0x170008DC RID: 2268
	// (get) Token: 0x06006D17 RID: 27927
	// (set) Token: 0x06006D18 RID: 27928
	Rotator TargetRot { get; set; }

	// Token: 0x170008DD RID: 2269
	// (get) Token: 0x06006D19 RID: 27929
	// (set) Token: 0x06006D1A RID: 27930
	float TargetFov { get; set; }

	// Token: 0x170008DE RID: 2270
	// (get) Token: 0x06006D1B RID: 27931
	// (set) Token: 0x06006D1C RID: 27932
	Vector CurrentPos { get; set; }

	// Token: 0x170008DF RID: 2271
	// (get) Token: 0x06006D1D RID: 27933
	// (set) Token: 0x06006D1E RID: 27934
	Rotator CurrentRot { get; set; }

	// Token: 0x170008E0 RID: 2272
	// (get) Token: 0x06006D1F RID: 27935
	// (set) Token: 0x06006D20 RID: 27936
	float CurrentFov { get; set; }

	// Token: 0x170008E1 RID: 2273
	// (get) Token: 0x06006D21 RID: 27937
	// (set) Token: 0x06006D22 RID: 27938
	bool IsInterpolating { get; set; }

	// Token: 0x170008E2 RID: 2274
	// (get) Token: 0x06006D23 RID: 27939
	// (set) Token: 0x06006D24 RID: 27940
	float InterpolationDuration { get; set; }

	// Token: 0x170008E3 RID: 2275
	// (get) Token: 0x06006D25 RID: 27941
	// (set) Token: 0x06006D26 RID: 27942
	float ElapsedTime { get; set; }

	// Token: 0x170008E4 RID: 2276
	// (get) Token: 0x06006D27 RID: 27943
	// (set) Token: 0x06006D28 RID: 27944
	[Nullable(2)]
	RhythmGameSpeedLevelConfig PrevConfig { [NullableContext(2)] get; [NullableContext(2)] set; }
}
