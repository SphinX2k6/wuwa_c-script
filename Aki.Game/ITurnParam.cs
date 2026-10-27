using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200303A RID: 12346
[NullableContext(2)]
public interface ITurnParam : IActionParamMap
{
	// Token: 0x17002405 RID: 9221
	// (get) Token: 0x0601A2F8 RID: 107256
	// (set) Token: 0x0601A2F9 RID: 107257
	Vector TargetLocation { get; set; }

	// Token: 0x17002406 RID: 9222
	// (get) Token: 0x0601A2FA RID: 107258
	// (set) Token: 0x0601A2FB RID: 107259
	Vector Direction { get; set; }

	// Token: 0x17002407 RID: 9223
	// (get) Token: 0x0601A2FC RID: 107260
	// (set) Token: 0x0601A2FD RID: 107261
	float? TurnSpeed { get; set; }

	// Token: 0x17002408 RID: 9224
	// (get) Token: 0x0601A2FE RID: 107262
	// (set) Token: 0x0601A2FF RID: 107263
	bool? ContainZ { get; set; }

	// Token: 0x17002409 RID: 9225
	// (get) Token: 0x0601A300 RID: 107264
	// (set) Token: 0x0601A301 RID: 107265
	float? MinTurnTimeSeconds { get; set; }

	// Token: 0x1700240A RID: 9226
	// (get) Token: 0x0601A302 RID: 107266
	// (set) Token: 0x0601A303 RID: 107267
	bool? UseLookAtForThisTurn { get; set; }

	// Token: 0x1700240B RID: 9227
	// (get) Token: 0x0601A304 RID: 107268
	// (set) Token: 0x0601A305 RID: 107269
	[Nullable(new byte[]
	{
		0,
		1,
		1,
		1
	})]
	OneOf<BaseActorComponent, Vector, AActor>? SightTarget { [return: Nullable(new byte[]
	{
		0,
		1,
		1,
		1
	})] get; [param: Nullable(new byte[]
	{
		0,
		1,
		1,
		1
	})] set; }
}
