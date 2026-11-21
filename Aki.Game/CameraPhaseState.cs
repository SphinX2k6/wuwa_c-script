using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02000534 RID: 1332
[NullableContext(1)]
[Nullable(0)]
internal class CameraPhaseState : ICameraPhaseState
{
	// Token: 0x1700091E RID: 2334
	// (get) Token: 0x060040F1 RID: 16625 RVA: 0x00169DD9 File Offset: 0x00167FD9
	// (set) Token: 0x060040F2 RID: 16626 RVA: 0x00169DE1 File Offset: 0x00167FE1
	public ECameraPhaseType PhaseType { get; set; }

	// Token: 0x1700091F RID: 2335
	// (get) Token: 0x060040F3 RID: 16627 RVA: 0x00169DEA File Offset: 0x00167FEA
	// (set) Token: 0x060040F4 RID: 16628 RVA: 0x00169DF2 File Offset: 0x00167FF2
	public Vector StartPos { get; set; } = Vector.Create();

	// Token: 0x17000920 RID: 2336
	// (get) Token: 0x060040F5 RID: 16629 RVA: 0x00169DFB File Offset: 0x00167FFB
	// (set) Token: 0x060040F6 RID: 16630 RVA: 0x00169E03 File Offset: 0x00168003
	public Rotator StartRot { get; set; } = Rotator.Create();

	// Token: 0x17000921 RID: 2337
	// (get) Token: 0x060040F7 RID: 16631 RVA: 0x00169E0C File Offset: 0x0016800C
	// (set) Token: 0x060040F8 RID: 16632 RVA: 0x00169E14 File Offset: 0x00168014
	public float StartFov { get; set; }

	// Token: 0x17000922 RID: 2338
	// (get) Token: 0x060040F9 RID: 16633 RVA: 0x00169E1D File Offset: 0x0016801D
	// (set) Token: 0x060040FA RID: 16634 RVA: 0x00169E25 File Offset: 0x00168025
	public Vector TargetPos { get; set; } = Vector.Create();

	// Token: 0x17000923 RID: 2339
	// (get) Token: 0x060040FB RID: 16635 RVA: 0x00169E2E File Offset: 0x0016802E
	// (set) Token: 0x060040FC RID: 16636 RVA: 0x00169E36 File Offset: 0x00168036
	public Rotator TargetRot { get; set; } = Rotator.Create();

	// Token: 0x17000924 RID: 2340
	// (get) Token: 0x060040FD RID: 16637 RVA: 0x00169E3F File Offset: 0x0016803F
	// (set) Token: 0x060040FE RID: 16638 RVA: 0x00169E47 File Offset: 0x00168047
	public float TargetFov { get; set; }

	// Token: 0x17000925 RID: 2341
	// (get) Token: 0x060040FF RID: 16639 RVA: 0x00169E50 File Offset: 0x00168050
	// (set) Token: 0x06004100 RID: 16640 RVA: 0x00169E58 File Offset: 0x00168058
	public float Duration { get; set; }

	// Token: 0x17000926 RID: 2342
	// (get) Token: 0x06004101 RID: 16641 RVA: 0x00169E61 File Offset: 0x00168061
	// (set) Token: 0x06004102 RID: 16642 RVA: 0x00169E69 File Offset: 0x00168069
	public float ElapsedTime { get; set; }

	// Token: 0x17000927 RID: 2343
	// (get) Token: 0x06004103 RID: 16643 RVA: 0x00169E72 File Offset: 0x00168072
	// (set) Token: 0x06004104 RID: 16644 RVA: 0x00169E7A File Offset: 0x0016807A
	public FVectorDouble PerformancePos { get; set; }

	// Token: 0x17000928 RID: 2344
	// (get) Token: 0x06004105 RID: 16645 RVA: 0x00169E83 File Offset: 0x00168083
	// (set) Token: 0x06004106 RID: 16646 RVA: 0x00169E8B File Offset: 0x0016808B
	public FRotator PerformanceRot { get; set; }

	// Token: 0x17000929 RID: 2345
	// (get) Token: 0x06004107 RID: 16647 RVA: 0x00169E94 File Offset: 0x00168094
	// (set) Token: 0x06004108 RID: 16648 RVA: 0x00169E9C File Offset: 0x0016809C
	public float PerformanceFov { get; set; }
}
