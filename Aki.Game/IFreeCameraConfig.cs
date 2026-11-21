using System;
using UnrealEngine;

// Token: 0x0200052F RID: 1327
public interface IFreeCameraConfig
{
	// Token: 0x170008EC RID: 2284
	// (get) Token: 0x06004091 RID: 16529
	FVectorDouble Pos { get; }

	// Token: 0x170008ED RID: 2285
	// (get) Token: 0x06004092 RID: 16530
	FRotator Rot { get; }

	// Token: 0x170008EE RID: 2286
	// (get) Token: 0x06004093 RID: 16531
	float Fov { get; }

	// Token: 0x170008EF RID: 2287
	// (get) Token: 0x06004094 RID: 16532
	float Radius { get; }

	// Token: 0x170008F0 RID: 2288
	// (get) Token: 0x06004095 RID: 16533
	float Interval { get; }

	// Token: 0x170008F1 RID: 2289
	// (get) Token: 0x06004096 RID: 16534
	float InterpDuration { get; }
}
