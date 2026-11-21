using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Gameplay.RhythmGame;

// Token: 0x02000532 RID: 1330
[NullableContext(1)]
[Nullable(0)]
internal class CameraInterpolationState : ICameraInterpolationState
{
	// Token: 0x17000905 RID: 2309
	// (get) Token: 0x060040BE RID: 16574 RVA: 0x00169CA7 File Offset: 0x00167EA7
	// (set) Token: 0x060040BF RID: 16575 RVA: 0x00169CAF File Offset: 0x00167EAF
	public Vector StartPos { get; set; } = Vector.Create();

	// Token: 0x17000906 RID: 2310
	// (get) Token: 0x060040C0 RID: 16576 RVA: 0x00169CB8 File Offset: 0x00167EB8
	// (set) Token: 0x060040C1 RID: 16577 RVA: 0x00169CC0 File Offset: 0x00167EC0
	public Rotator StartRot { get; set; } = Rotator.Create();

	// Token: 0x17000907 RID: 2311
	// (get) Token: 0x060040C2 RID: 16578 RVA: 0x00169CC9 File Offset: 0x00167EC9
	// (set) Token: 0x060040C3 RID: 16579 RVA: 0x00169CD1 File Offset: 0x00167ED1
	public float StartFov { get; set; }

	// Token: 0x17000908 RID: 2312
	// (get) Token: 0x060040C4 RID: 16580 RVA: 0x00169CDA File Offset: 0x00167EDA
	// (set) Token: 0x060040C5 RID: 16581 RVA: 0x00169CE2 File Offset: 0x00167EE2
	public Vector TargetPos { get; set; } = Vector.Create();

	// Token: 0x17000909 RID: 2313
	// (get) Token: 0x060040C6 RID: 16582 RVA: 0x00169CEB File Offset: 0x00167EEB
	// (set) Token: 0x060040C7 RID: 16583 RVA: 0x00169CF3 File Offset: 0x00167EF3
	public Rotator TargetRot { get; set; } = Rotator.Create();

	// Token: 0x1700090A RID: 2314
	// (get) Token: 0x060040C8 RID: 16584 RVA: 0x00169CFC File Offset: 0x00167EFC
	// (set) Token: 0x060040C9 RID: 16585 RVA: 0x00169D04 File Offset: 0x00167F04
	public float TargetFov { get; set; }

	// Token: 0x1700090B RID: 2315
	// (get) Token: 0x060040CA RID: 16586 RVA: 0x00169D0D File Offset: 0x00167F0D
	// (set) Token: 0x060040CB RID: 16587 RVA: 0x00169D15 File Offset: 0x00167F15
	public Vector CurrentPos { get; set; } = Vector.Create();

	// Token: 0x1700090C RID: 2316
	// (get) Token: 0x060040CC RID: 16588 RVA: 0x00169D1E File Offset: 0x00167F1E
	// (set) Token: 0x060040CD RID: 16589 RVA: 0x00169D26 File Offset: 0x00167F26
	public Rotator CurrentRot { get; set; } = Rotator.Create();

	// Token: 0x1700090D RID: 2317
	// (get) Token: 0x060040CE RID: 16590 RVA: 0x00169D2F File Offset: 0x00167F2F
	// (set) Token: 0x060040CF RID: 16591 RVA: 0x00169D37 File Offset: 0x00167F37
	public float CurrentFov { get; set; }

	// Token: 0x1700090E RID: 2318
	// (get) Token: 0x060040D0 RID: 16592 RVA: 0x00169D40 File Offset: 0x00167F40
	// (set) Token: 0x060040D1 RID: 16593 RVA: 0x00169D48 File Offset: 0x00167F48
	public bool IsInterpolating { get; set; }

	// Token: 0x1700090F RID: 2319
	// (get) Token: 0x060040D2 RID: 16594 RVA: 0x00169D51 File Offset: 0x00167F51
	// (set) Token: 0x060040D3 RID: 16595 RVA: 0x00169D59 File Offset: 0x00167F59
	public float InterpolationDuration { get; set; }

	// Token: 0x17000910 RID: 2320
	// (get) Token: 0x060040D4 RID: 16596 RVA: 0x00169D62 File Offset: 0x00167F62
	// (set) Token: 0x060040D5 RID: 16597 RVA: 0x00169D6A File Offset: 0x00167F6A
	public float ElapsedTime { get; set; }

	// Token: 0x17000911 RID: 2321
	// (get) Token: 0x060040D6 RID: 16598 RVA: 0x00169D73 File Offset: 0x00167F73
	// (set) Token: 0x060040D7 RID: 16599 RVA: 0x00169D7B File Offset: 0x00167F7B
	[Nullable(2)]
	public RhythmGameSpeedLevelConfig PrevConfig { [NullableContext(2)] get; [NullableContext(2)] set; }
}
