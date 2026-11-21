using System;
using System.Runtime.CompilerServices;

// Token: 0x02000536 RID: 1334
[NullableContext(2)]
[Nullable(0)]
internal class FreeCameraState : IFreeCameraState
{
	// Token: 0x17000935 RID: 2357
	// (get) Token: 0x06004120 RID: 16672 RVA: 0x00169ED9 File Offset: 0x001680D9
	// (set) Token: 0x06004121 RID: 16673 RVA: 0x00169EE1 File Offset: 0x001680E1
	[Nullable(1)]
	public IFreeCameraConfig Config { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x17000936 RID: 2358
	// (get) Token: 0x06004122 RID: 16674 RVA: 0x00169EEA File Offset: 0x001680EA
	// (set) Token: 0x06004123 RID: 16675 RVA: 0x00169EF2 File Offset: 0x001680F2
	public float Timer { get; set; }

	// Token: 0x17000937 RID: 2359
	// (get) Token: 0x06004124 RID: 16676 RVA: 0x00169EFB File Offset: 0x001680FB
	// (set) Token: 0x06004125 RID: 16677 RVA: 0x00169F03 File Offset: 0x00168103
	public int LastDirection { get; set; }

	// Token: 0x17000938 RID: 2360
	// (get) Token: 0x06004126 RID: 16678 RVA: 0x00169F0C File Offset: 0x0016810C
	// (set) Token: 0x06004127 RID: 16679 RVA: 0x00169F14 File Offset: 0x00168114
	public bool IsInterpolating { get; set; }

	// Token: 0x17000939 RID: 2361
	// (get) Token: 0x06004128 RID: 16680 RVA: 0x00169F1D File Offset: 0x0016811D
	// (set) Token: 0x06004129 RID: 16681 RVA: 0x00169F25 File Offset: 0x00168125
	public float InterpolationElapsedTime { get; set; }

	// Token: 0x1700093A RID: 2362
	// (get) Token: 0x0600412A RID: 16682 RVA: 0x00169F2E File Offset: 0x0016812E
	// (set) Token: 0x0600412B RID: 16683 RVA: 0x00169F36 File Offset: 0x00168136
	public int StartDirection { get; set; }

	// Token: 0x1700093B RID: 2363
	// (get) Token: 0x0600412C RID: 16684 RVA: 0x00169F3F File Offset: 0x0016813F
	// (set) Token: 0x0600412D RID: 16685 RVA: 0x00169F47 File Offset: 0x00168147
	public int TargetDirection { get; set; }

	// Token: 0x1700093C RID: 2364
	// (get) Token: 0x0600412E RID: 16686 RVA: 0x00169F50 File Offset: 0x00168150
	// (set) Token: 0x0600412F RID: 16687 RVA: 0x00169F58 File Offset: 0x00168158
	public bool? IsExiting { get; set; }

	// Token: 0x1700093D RID: 2365
	// (get) Token: 0x06004130 RID: 16688 RVA: 0x00169F61 File Offset: 0x00168161
	// (set) Token: 0x06004131 RID: 16689 RVA: 0x00169F69 File Offset: 0x00168169
	public Vector ExitRelativePos { get; set; }

	// Token: 0x1700093E RID: 2366
	// (get) Token: 0x06004132 RID: 16690 RVA: 0x00169F72 File Offset: 0x00168172
	// (set) Token: 0x06004133 RID: 16691 RVA: 0x00169F7A File Offset: 0x0016817A
	public Rotator ExitRelativeRot { get; set; }

	// Token: 0x1700093F RID: 2367
	// (get) Token: 0x06004134 RID: 16692 RVA: 0x00169F83 File Offset: 0x00168183
	// (set) Token: 0x06004135 RID: 16693 RVA: 0x00169F8B File Offset: 0x0016818B
	public int? ExitFollowConfigIndex { get; set; }
}
