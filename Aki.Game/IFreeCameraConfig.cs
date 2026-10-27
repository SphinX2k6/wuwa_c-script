using System;
using UnrealEngine;

// Token: 0x0200107B RID: 4219
public interface IFreeCameraConfig
{
	// Token: 0x170008CC RID: 2252
	// (get) Token: 0x06006CFC RID: 27900
	FVectorDouble Pos { get; }

	// Token: 0x170008CD RID: 2253
	// (get) Token: 0x06006CFD RID: 27901
	FRotator Rot { get; }

	// Token: 0x170008CE RID: 2254
	// (get) Token: 0x06006CFE RID: 27902
	float Fov { get; }

	// Token: 0x170008CF RID: 2255
	// (get) Token: 0x06006CFF RID: 27903
	float Radius { get; }

	// Token: 0x170008D0 RID: 2256
	// (get) Token: 0x06006D00 RID: 27904
	float Interval { get; }

	// Token: 0x170008D1 RID: 2257
	// (get) Token: 0x06006D01 RID: 27905
	float InterpDuration { get; }
}
