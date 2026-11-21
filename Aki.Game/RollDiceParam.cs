using System;
using System.Runtime.CompilerServices;

// Token: 0x0200070C RID: 1804
[NullableContext(2)]
[Nullable(0)]
public class RollDiceParam : IRollDiceParam
{
	// Token: 0x17000AF9 RID: 2809
	// (get) Token: 0x0600532C RID: 21292 RVA: 0x001B8F9A File Offset: 0x001B719A
	// (set) Token: 0x0600532D RID: 21293 RVA: 0x001B8FA2 File Offset: 0x001B71A2
	public float? AniProcess { get; set; }

	// Token: 0x17000AFA RID: 2810
	// (get) Token: 0x0600532E RID: 21294 RVA: 0x001B8FAB File Offset: 0x001B71AB
	// (set) Token: 0x0600532F RID: 21295 RVA: 0x001B8FB3 File Offset: 0x001B71B3
	public int? AniNum { get; set; }

	// Token: 0x17000AFB RID: 2811
	// (get) Token: 0x06005330 RID: 21296 RVA: 0x001B8FBC File Offset: 0x001B71BC
	// (set) Token: 0x06005331 RID: 21297 RVA: 0x001B8FC4 File Offset: 0x001B71C4
	[Nullable(1)]
	public int[] DicePoints { [NullableContext(1)] get; [NullableContext(1)] set; } = Array.Empty<int>();

	// Token: 0x17000AFC RID: 2812
	// (get) Token: 0x06005332 RID: 21298 RVA: 0x001B8FCD File Offset: 0x001B71CD
	// (set) Token: 0x06005333 RID: 21299 RVA: 0x001B8FD5 File Offset: 0x001B71D5
	public bool? IsNormalTimer { get; set; }

	// Token: 0x17000AFD RID: 2813
	// (get) Token: 0x06005334 RID: 21300 RVA: 0x001B8FDE File Offset: 0x001B71DE
	// (set) Token: 0x06005335 RID: 21301 RVA: 0x001B8FE6 File Offset: 0x001B71E6
	public ERollDiceCameraMode? CameraMode { get; set; }

	// Token: 0x17000AFE RID: 2814
	// (get) Token: 0x06005336 RID: 21302 RVA: 0x001B8FEF File Offset: 0x001B71EF
	// (set) Token: 0x06005337 RID: 21303 RVA: 0x001B8FF7 File Offset: 0x001B71F7
	public string BpDiceCase { get; set; }

	// Token: 0x17000AFF RID: 2815
	// (get) Token: 0x06005338 RID: 21304 RVA: 0x001B9000 File Offset: 0x001B7200
	// (set) Token: 0x06005339 RID: 21305 RVA: 0x001B9008 File Offset: 0x001B7208
	public string DiceCameraCase { get; set; }
}
