using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Gameplay.RhythmGame;

// Token: 0x02000531 RID: 1329
[NullableContext(1)]
internal interface ICameraInterpolationState
{
	// Token: 0x170008F8 RID: 2296
	// (get) Token: 0x060040A4 RID: 16548
	// (set) Token: 0x060040A5 RID: 16549
	Vector StartPos { get; set; }

	// Token: 0x170008F9 RID: 2297
	// (get) Token: 0x060040A6 RID: 16550
	// (set) Token: 0x060040A7 RID: 16551
	Rotator StartRot { get; set; }

	// Token: 0x170008FA RID: 2298
	// (get) Token: 0x060040A8 RID: 16552
	// (set) Token: 0x060040A9 RID: 16553
	float StartFov { get; set; }

	// Token: 0x170008FB RID: 2299
	// (get) Token: 0x060040AA RID: 16554
	// (set) Token: 0x060040AB RID: 16555
	Vector TargetPos { get; set; }

	// Token: 0x170008FC RID: 2300
	// (get) Token: 0x060040AC RID: 16556
	// (set) Token: 0x060040AD RID: 16557
	Rotator TargetRot { get; set; }

	// Token: 0x170008FD RID: 2301
	// (get) Token: 0x060040AE RID: 16558
	// (set) Token: 0x060040AF RID: 16559
	float TargetFov { get; set; }

	// Token: 0x170008FE RID: 2302
	// (get) Token: 0x060040B0 RID: 16560
	// (set) Token: 0x060040B1 RID: 16561
	Vector CurrentPos { get; set; }

	// Token: 0x170008FF RID: 2303
	// (get) Token: 0x060040B2 RID: 16562
	// (set) Token: 0x060040B3 RID: 16563
	Rotator CurrentRot { get; set; }

	// Token: 0x17000900 RID: 2304
	// (get) Token: 0x060040B4 RID: 16564
	// (set) Token: 0x060040B5 RID: 16565
	float CurrentFov { get; set; }

	// Token: 0x17000901 RID: 2305
	// (get) Token: 0x060040B6 RID: 16566
	// (set) Token: 0x060040B7 RID: 16567
	bool IsInterpolating { get; set; }

	// Token: 0x17000902 RID: 2306
	// (get) Token: 0x060040B8 RID: 16568
	// (set) Token: 0x060040B9 RID: 16569
	float InterpolationDuration { get; set; }

	// Token: 0x17000903 RID: 2307
	// (get) Token: 0x060040BA RID: 16570
	// (set) Token: 0x060040BB RID: 16571
	float ElapsedTime { get; set; }

	// Token: 0x17000904 RID: 2308
	// (get) Token: 0x060040BC RID: 16572
	// (set) Token: 0x060040BD RID: 16573
	[Nullable(2)]
	RhythmGameSpeedLevelConfig PrevConfig { [NullableContext(2)] get; [NullableContext(2)] set; }
}
