using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200303B RID: 12347
[NullableContext(2)]
[Nullable(0)]
public class TurnParam : ITurnParam, IActionParamMap
{
	// Token: 0x1700240C RID: 9228
	// (get) Token: 0x0601A306 RID: 107270 RVA: 0x006E388B File Offset: 0x006E1A8B
	// (set) Token: 0x0601A307 RID: 107271 RVA: 0x006E3893 File Offset: 0x006E1A93
	public Vector TargetLocation { get; set; }

	// Token: 0x1700240D RID: 9229
	// (get) Token: 0x0601A308 RID: 107272 RVA: 0x006E389C File Offset: 0x006E1A9C
	// (set) Token: 0x0601A309 RID: 107273 RVA: 0x006E38A4 File Offset: 0x006E1AA4
	public Vector Direction { get; set; }

	// Token: 0x1700240E RID: 9230
	// (get) Token: 0x0601A30A RID: 107274 RVA: 0x006E38AD File Offset: 0x006E1AAD
	// (set) Token: 0x0601A30B RID: 107275 RVA: 0x006E38B5 File Offset: 0x006E1AB5
	public float? TurnSpeed { get; set; }

	// Token: 0x1700240F RID: 9231
	// (get) Token: 0x0601A30C RID: 107276 RVA: 0x006E38BE File Offset: 0x006E1ABE
	// (set) Token: 0x0601A30D RID: 107277 RVA: 0x006E38C6 File Offset: 0x006E1AC6
	public bool? ContainZ { get; set; }

	// Token: 0x17002410 RID: 9232
	// (get) Token: 0x0601A30E RID: 107278 RVA: 0x006E38CF File Offset: 0x006E1ACF
	// (set) Token: 0x0601A30F RID: 107279 RVA: 0x006E38D7 File Offset: 0x006E1AD7
	public float? MinTurnTimeSeconds { get; set; }

	// Token: 0x17002411 RID: 9233
	// (get) Token: 0x0601A310 RID: 107280 RVA: 0x006E38E0 File Offset: 0x006E1AE0
	// (set) Token: 0x0601A311 RID: 107281 RVA: 0x006E38E8 File Offset: 0x006E1AE8
	public bool? UseLookAtForThisTurn { get; set; }

	// Token: 0x17002412 RID: 9234
	// (get) Token: 0x0601A312 RID: 107282 RVA: 0x006E38F1 File Offset: 0x006E1AF1
	// (set) Token: 0x0601A313 RID: 107283 RVA: 0x006E38F9 File Offset: 0x006E1AF9
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
