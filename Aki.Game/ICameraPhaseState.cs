using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02000533 RID: 1331
[NullableContext(1)]
internal interface ICameraPhaseState
{
	// Token: 0x17000912 RID: 2322
	// (get) Token: 0x060040D9 RID: 16601
	// (set) Token: 0x060040DA RID: 16602
	ECameraPhaseType PhaseType { get; set; }

	// Token: 0x17000913 RID: 2323
	// (get) Token: 0x060040DB RID: 16603
	// (set) Token: 0x060040DC RID: 16604
	Vector StartPos { get; set; }

	// Token: 0x17000914 RID: 2324
	// (get) Token: 0x060040DD RID: 16605
	// (set) Token: 0x060040DE RID: 16606
	Rotator StartRot { get; set; }

	// Token: 0x17000915 RID: 2325
	// (get) Token: 0x060040DF RID: 16607
	// (set) Token: 0x060040E0 RID: 16608
	float StartFov { get; set; }

	// Token: 0x17000916 RID: 2326
	// (get) Token: 0x060040E1 RID: 16609
	// (set) Token: 0x060040E2 RID: 16610
	Vector TargetPos { get; set; }

	// Token: 0x17000917 RID: 2327
	// (get) Token: 0x060040E3 RID: 16611
	// (set) Token: 0x060040E4 RID: 16612
	Rotator TargetRot { get; set; }

	// Token: 0x17000918 RID: 2328
	// (get) Token: 0x060040E5 RID: 16613
	// (set) Token: 0x060040E6 RID: 16614
	float TargetFov { get; set; }

	// Token: 0x17000919 RID: 2329
	// (get) Token: 0x060040E7 RID: 16615
	// (set) Token: 0x060040E8 RID: 16616
	float Duration { get; set; }

	// Token: 0x1700091A RID: 2330
	// (get) Token: 0x060040E9 RID: 16617
	// (set) Token: 0x060040EA RID: 16618
	float ElapsedTime { get; set; }

	// Token: 0x1700091B RID: 2331
	// (get) Token: 0x060040EB RID: 16619
	// (set) Token: 0x060040EC RID: 16620
	FVectorDouble PerformancePos { get; set; }

	// Token: 0x1700091C RID: 2332
	// (get) Token: 0x060040ED RID: 16621
	// (set) Token: 0x060040EE RID: 16622
	FRotator PerformanceRot { get; set; }

	// Token: 0x1700091D RID: 2333
	// (get) Token: 0x060040EF RID: 16623
	// (set) Token: 0x060040F0 RID: 16624
	float PerformanceFov { get; set; }
}
