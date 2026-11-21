using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002590 RID: 9616
[NullableContext(2)]
public interface ITurnParam : IActionParamMap
{
	// Token: 0x170024F1 RID: 9457
	// (get) Token: 0x06017C62 RID: 97378
	// (set) Token: 0x06017C63 RID: 97379
	Vector TargetLocation { get; set; }

	// Token: 0x170024F2 RID: 9458
	// (get) Token: 0x06017C64 RID: 97380
	// (set) Token: 0x06017C65 RID: 97381
	Vector Direction { get; set; }

	// Token: 0x170024F3 RID: 9459
	// (get) Token: 0x06017C66 RID: 97382
	// (set) Token: 0x06017C67 RID: 97383
	float? TurnSpeed { get; set; }

	// Token: 0x170024F4 RID: 9460
	// (get) Token: 0x06017C68 RID: 97384
	// (set) Token: 0x06017C69 RID: 97385
	bool? ContainZ { get; set; }

	// Token: 0x170024F5 RID: 9461
	// (get) Token: 0x06017C6A RID: 97386
	// (set) Token: 0x06017C6B RID: 97387
	float? MinTurnTimeSeconds { get; set; }

	// Token: 0x170024F6 RID: 9462
	// (get) Token: 0x06017C6C RID: 97388
	// (set) Token: 0x06017C6D RID: 97389
	bool? UseLookAtForThisTurn { get; set; }

	// Token: 0x170024F7 RID: 9463
	// (get) Token: 0x06017C6E RID: 97390
	// (set) Token: 0x06017C6F RID: 97391
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
