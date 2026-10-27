using System;
using System.Runtime.CompilerServices;

// Token: 0x02001082 RID: 4226
[NullableContext(2)]
[Nullable(0)]
internal class FreeCameraState : IFreeCameraState
{
	// Token: 0x17000915 RID: 2325
	// (get) Token: 0x06006D8B RID: 28043 RVA: 0x001615A5 File Offset: 0x0015F7A5
	// (set) Token: 0x06006D8C RID: 28044 RVA: 0x001615AD File Offset: 0x0015F7AD
	[Nullable(1)]
	public IFreeCameraConfig Config { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x17000916 RID: 2326
	// (get) Token: 0x06006D8D RID: 28045 RVA: 0x001615B6 File Offset: 0x0015F7B6
	// (set) Token: 0x06006D8E RID: 28046 RVA: 0x001615BE File Offset: 0x0015F7BE
	public float Timer { get; set; }

	// Token: 0x17000917 RID: 2327
	// (get) Token: 0x06006D8F RID: 28047 RVA: 0x001615C7 File Offset: 0x0015F7C7
	// (set) Token: 0x06006D90 RID: 28048 RVA: 0x001615CF File Offset: 0x0015F7CF
	public int LastDirection { get; set; }

	// Token: 0x17000918 RID: 2328
	// (get) Token: 0x06006D91 RID: 28049 RVA: 0x001615D8 File Offset: 0x0015F7D8
	// (set) Token: 0x06006D92 RID: 28050 RVA: 0x001615E0 File Offset: 0x0015F7E0
	public bool IsInterpolating { get; set; }

	// Token: 0x17000919 RID: 2329
	// (get) Token: 0x06006D93 RID: 28051 RVA: 0x001615E9 File Offset: 0x0015F7E9
	// (set) Token: 0x06006D94 RID: 28052 RVA: 0x001615F1 File Offset: 0x0015F7F1
	public float InterpolationElapsedTime { get; set; }

	// Token: 0x1700091A RID: 2330
	// (get) Token: 0x06006D95 RID: 28053 RVA: 0x001615FA File Offset: 0x0015F7FA
	// (set) Token: 0x06006D96 RID: 28054 RVA: 0x00161602 File Offset: 0x0015F802
	public int StartDirection { get; set; }

	// Token: 0x1700091B RID: 2331
	// (get) Token: 0x06006D97 RID: 28055 RVA: 0x0016160B File Offset: 0x0015F80B
	// (set) Token: 0x06006D98 RID: 28056 RVA: 0x00161613 File Offset: 0x0015F813
	public int TargetDirection { get; set; }

	// Token: 0x1700091C RID: 2332
	// (get) Token: 0x06006D99 RID: 28057 RVA: 0x0016161C File Offset: 0x0015F81C
	// (set) Token: 0x06006D9A RID: 28058 RVA: 0x00161624 File Offset: 0x0015F824
	public bool? IsExiting { get; set; }

	// Token: 0x1700091D RID: 2333
	// (get) Token: 0x06006D9B RID: 28059 RVA: 0x0016162D File Offset: 0x0015F82D
	// (set) Token: 0x06006D9C RID: 28060 RVA: 0x00161635 File Offset: 0x0015F835
	public Vector ExitRelativePos { get; set; }

	// Token: 0x1700091E RID: 2334
	// (get) Token: 0x06006D9D RID: 28061 RVA: 0x0016163E File Offset: 0x0015F83E
	// (set) Token: 0x06006D9E RID: 28062 RVA: 0x00161646 File Offset: 0x0015F846
	public Rotator ExitRelativeRot { get; set; }

	// Token: 0x1700091F RID: 2335
	// (get) Token: 0x06006D9F RID: 28063 RVA: 0x0016164F File Offset: 0x0015F84F
	// (set) Token: 0x06006DA0 RID: 28064 RVA: 0x00161657 File Offset: 0x0015F857
	public int? ExitFollowConfigIndex { get; set; }
}
