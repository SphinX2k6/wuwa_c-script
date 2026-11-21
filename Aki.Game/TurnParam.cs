using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002591 RID: 9617
[NullableContext(2)]
[Nullable(0)]
public class TurnParam : ITurnParam, IActionParamMap
{
	// Token: 0x170024F8 RID: 9464
	// (get) Token: 0x06017C70 RID: 97392 RVA: 0x0070B413 File Offset: 0x00709613
	// (set) Token: 0x06017C71 RID: 97393 RVA: 0x0070B41B File Offset: 0x0070961B
	public Vector TargetLocation { get; set; }

	// Token: 0x170024F9 RID: 9465
	// (get) Token: 0x06017C72 RID: 97394 RVA: 0x0070B424 File Offset: 0x00709624
	// (set) Token: 0x06017C73 RID: 97395 RVA: 0x0070B42C File Offset: 0x0070962C
	public Vector Direction { get; set; }

	// Token: 0x170024FA RID: 9466
	// (get) Token: 0x06017C74 RID: 97396 RVA: 0x0070B435 File Offset: 0x00709635
	// (set) Token: 0x06017C75 RID: 97397 RVA: 0x0070B43D File Offset: 0x0070963D
	public float? TurnSpeed { get; set; }

	// Token: 0x170024FB RID: 9467
	// (get) Token: 0x06017C76 RID: 97398 RVA: 0x0070B446 File Offset: 0x00709646
	// (set) Token: 0x06017C77 RID: 97399 RVA: 0x0070B44E File Offset: 0x0070964E
	public bool? ContainZ { get; set; }

	// Token: 0x170024FC RID: 9468
	// (get) Token: 0x06017C78 RID: 97400 RVA: 0x0070B457 File Offset: 0x00709657
	// (set) Token: 0x06017C79 RID: 97401 RVA: 0x0070B45F File Offset: 0x0070965F
	public float? MinTurnTimeSeconds { get; set; }

	// Token: 0x170024FD RID: 9469
	// (get) Token: 0x06017C7A RID: 97402 RVA: 0x0070B468 File Offset: 0x00709668
	// (set) Token: 0x06017C7B RID: 97403 RVA: 0x0070B470 File Offset: 0x00709670
	public bool? UseLookAtForThisTurn { get; set; }

	// Token: 0x170024FE RID: 9470
	// (get) Token: 0x06017C7C RID: 97404 RVA: 0x0070B479 File Offset: 0x00709679
	// (set) Token: 0x06017C7D RID: 97405 RVA: 0x0070B481 File Offset: 0x00709681
	[Nullable(new byte[]
	{
		0,
		1,
		1,
		1
	})]
	public OneOf<BaseActorComponent, Vector, AActor>? SightTarget { [return: Nullable(new byte[]
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
