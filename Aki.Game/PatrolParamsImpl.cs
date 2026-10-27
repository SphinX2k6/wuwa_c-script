using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.LevelGamePlay;

// Token: 0x020030F4 RID: 12532
[NullableContext(2)]
[Nullable(0)]
public class PatrolParamsImpl : IPatrolParams
{
	// Token: 0x17002503 RID: 9475
	// (get) Token: 0x0601ADB3 RID: 110003 RVA: 0x00740F7E File Offset: 0x0073F17E
	// (set) Token: 0x0601ADB4 RID: 110004 RVA: 0x00740F86 File Offset: 0x0073F186
	public bool? DebugMode { get; set; }

	// Token: 0x17002504 RID: 9476
	// (get) Token: 0x0601ADB5 RID: 110005 RVA: 0x00740F8F File Offset: 0x0073F18F
	// (set) Token: 0x0601ADB6 RID: 110006 RVA: 0x00740F97 File Offset: 0x0073F197
	public bool? ReturnFalseWhenNavigationFailed { get; set; }

	// Token: 0x17002505 RID: 9477
	// (get) Token: 0x0601ADB7 RID: 110007 RVA: 0x00740FA0 File Offset: 0x0073F1A0
	// (set) Token: 0x0601ADB8 RID: 110008 RVA: 0x00740FA8 File Offset: 0x0073F1A8
	public EPatrolStartMode? StartMode { get; set; }

	// Token: 0x17002506 RID: 9478
	// (get) Token: 0x0601ADB9 RID: 110009 RVA: 0x00740FB1 File Offset: 0x0073F1B1
	// (set) Token: 0x0601ADBA RID: 110010 RVA: 0x00740FB9 File Offset: 0x0073F1B9
	public List<double> RandomDistanceRange { get; set; }

	// Token: 0x17002507 RID: 9479
	// (get) Token: 0x0601ADBB RID: 110011 RVA: 0x00740FC2 File Offset: 0x0073F1C2
	// (set) Token: 0x0601ADBC RID: 110012 RVA: 0x00740FCA File Offset: 0x0073F1CA
	public bool? IsFollowStrictly { get; set; }

	// Token: 0x17002508 RID: 9480
	// (get) Token: 0x0601ADBD RID: 110013 RVA: 0x00740FD3 File Offset: 0x0073F1D3
	// (set) Token: 0x0601ADBE RID: 110014 RVA: 0x00740FDB File Offset: 0x0073F1DB
	public int? StartPointIndex { get; set; }

	// Token: 0x17002509 RID: 9481
	// (get) Token: 0x0601ADBF RID: 110015 RVA: 0x00740FE4 File Offset: 0x0073F1E4
	// (set) Token: 0x0601ADC0 RID: 110016 RVA: 0x00740FEC File Offset: 0x0073F1EC
	public int? EndPointIndex { get; set; }

	// Token: 0x1700250A RID: 9482
	// (get) Token: 0x0601ADC1 RID: 110017 RVA: 0x00740FF5 File Offset: 0x0073F1F5
	// (set) Token: 0x0601ADC2 RID: 110018 RVA: 0x00740FFD File Offset: 0x0073F1FD
	public bool? NoRequestServer { get; set; }

	// Token: 0x1700250B RID: 9483
	// (get) Token: 0x0601ADC3 RID: 110019 RVA: 0x00741006 File Offset: 0x0073F206
	// (set) Token: 0x0601ADC4 RID: 110020 RVA: 0x0074100E File Offset: 0x0073F20E
	public bool? NoSyncPoint { get; set; }

	// Token: 0x1700250C RID: 9484
	// (get) Token: 0x0601ADC5 RID: 110021 RVA: 0x00741017 File Offset: 0x0073F217
	// (set) Token: 0x0601ADC6 RID: 110022 RVA: 0x0074101F File Offset: 0x0073F21F
	public float? TurnSpeed { get; set; }

	// Token: 0x1700250D RID: 9485
	// (get) Token: 0x0601ADC7 RID: 110023 RVA: 0x00741028 File Offset: 0x0073F228
	// (set) Token: 0x0601ADC8 RID: 110024 RVA: 0x00741030 File Offset: 0x0073F230
	public Action<int> OnArrivePointHandle { get; set; }

	// Token: 0x1700250E RID: 9486
	// (get) Token: 0x0601ADC9 RID: 110025 RVA: 0x00741039 File Offset: 0x0073F239
	// (set) Token: 0x0601ADCA RID: 110026 RVA: 0x00741041 File Offset: 0x0073F241
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public Action<IList<ActionInfo>> OnTriggerActionsHandle { [return: Nullable(new byte[]
	{
		2,
		1,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1,
		1
	})] set; }

	// Token: 0x1700250F RID: 9487
	// (get) Token: 0x0601ADCB RID: 110027 RVA: 0x0074104A File Offset: 0x0073F24A
	// (set) Token: 0x0601ADCC RID: 110028 RVA: 0x00741052 File Offset: 0x0073F252
	public Action<ELevelEventState> OnPatrolEndHandle { get; set; }

	// Token: 0x17002510 RID: 9488
	// (get) Token: 0x0601ADCD RID: 110029 RVA: 0x0074105B File Offset: 0x0073F25B
	// (set) Token: 0x0601ADCE RID: 110030 RVA: 0x00741063 File Offset: 0x0073F263
	public Action OnResetLocationCallback { get; set; }
}
