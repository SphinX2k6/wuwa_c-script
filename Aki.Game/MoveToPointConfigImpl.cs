using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay;

// Token: 0x02003105 RID: 12549
[NullableContext(2)]
[Nullable(0)]
public class MoveToPointConfigImpl : IMoveToPointConfig
{
	// Token: 0x1700253B RID: 9531
	// (get) Token: 0x0601AF26 RID: 110374 RVA: 0x0074E787 File Offset: 0x0074C987
	// (set) Token: 0x0601AF27 RID: 110375 RVA: 0x0074E78F File Offset: 0x0074C98F
	[Nullable(1)]
	public Vector Position { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x1700253C RID: 9532
	// (get) Token: 0x0601AF28 RID: 110376 RVA: 0x0074E798 File Offset: 0x0074C998
	// (set) Token: 0x0601AF29 RID: 110377 RVA: 0x0074E7A0 File Offset: 0x0074C9A0
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Func<Vector> ReferencePosition { [return: Nullable(new byte[]
	{
		2,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1
	})] set; }

	// Token: 0x1700253D RID: 9533
	// (get) Token: 0x0601AF2A RID: 110378 RVA: 0x0074E7A9 File Offset: 0x0074C9A9
	// (set) Token: 0x0601AF2B RID: 110379 RVA: 0x0074E7B1 File Offset: 0x0074C9B1
	public bool? IsFly { get; set; }

	// Token: 0x1700253E RID: 9534
	// (get) Token: 0x0601AF2C RID: 110380 RVA: 0x0074E7BA File Offset: 0x0074C9BA
	// (set) Token: 0x0601AF2D RID: 110381 RVA: 0x0074E7C2 File Offset: 0x0074C9C2
	public bool? IsForward { get; set; }

	// Token: 0x1700253F RID: 9535
	// (get) Token: 0x0601AF2E RID: 110382 RVA: 0x0074E7CB File Offset: 0x0074C9CB
	// (set) Token: 0x0601AF2F RID: 110383 RVA: 0x0074E7D3 File Offset: 0x0074C9D3
	public double? Distance { get; set; }

	// Token: 0x17002540 RID: 9536
	// (get) Token: 0x0601AF30 RID: 110384 RVA: 0x0074E7DC File Offset: 0x0074C9DC
	// (set) Token: 0x0601AF31 RID: 110385 RVA: 0x0074E7E4 File Offset: 0x0074C9E4
	public ECharMoveState? MoveState { get; set; }

	// Token: 0x17002541 RID: 9537
	// (get) Token: 0x0601AF32 RID: 110386 RVA: 0x0074E7ED File Offset: 0x0074C9ED
	// (set) Token: 0x0601AF33 RID: 110387 RVA: 0x0074E7F5 File Offset: 0x0074C9F5
	public float? MoveSpeed { get; set; }

	// Token: 0x17002542 RID: 9538
	// (get) Token: 0x0601AF34 RID: 110388 RVA: 0x0074E7FE File Offset: 0x0074C9FE
	// (set) Token: 0x0601AF35 RID: 110389 RVA: 0x0074E806 File Offset: 0x0074CA06
	public float? TurnSpeed { get; set; }

	// Token: 0x17002543 RID: 9539
	// (get) Token: 0x0601AF36 RID: 110390 RVA: 0x0074E80F File Offset: 0x0074CA0F
	// (set) Token: 0x0601AF37 RID: 110391 RVA: 0x0074E817 File Offset: 0x0074CA17
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Queue<Vector> NextMovePointConfig { [return: Nullable(new byte[]
	{
		2,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1
	})] set; }

	// Token: 0x17002544 RID: 9540
	// (get) Token: 0x0601AF38 RID: 110392 RVA: 0x0074E820 File Offset: 0x0074CA20
	// (set) Token: 0x0601AF39 RID: 110393 RVA: 0x0074E828 File Offset: 0x0074CA28
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<Action<ELevelEventState>> CallbackList { [return: Nullable(new byte[]
	{
		2,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1
	})] set; }

	// Token: 0x17002545 RID: 9541
	// (get) Token: 0x0601AF3A RID: 110394 RVA: 0x0074E831 File Offset: 0x0074CA31
	// (set) Token: 0x0601AF3B RID: 110395 RVA: 0x0074E839 File Offset: 0x0074CA39
	public Func<bool> ResetCondition { get; set; }

	// Token: 0x17002546 RID: 9542
	// (get) Token: 0x0601AF3C RID: 110396 RVA: 0x0074E842 File Offset: 0x0074CA42
	// (set) Token: 0x0601AF3D RID: 110397 RVA: 0x0074E84A File Offset: 0x0074CA4A
	public bool? UseNearestDirection { get; set; }

	// Token: 0x17002547 RID: 9543
	// (get) Token: 0x0601AF3E RID: 110398 RVA: 0x0074E853 File Offset: 0x0074CA53
	// (set) Token: 0x0601AF3F RID: 110399 RVA: 0x0074E85B File Offset: 0x0074CA5B
	public Vector FaceToPosition { get; set; }

	// Token: 0x17002548 RID: 9544
	// (get) Token: 0x0601AF40 RID: 110400 RVA: 0x0074E864 File Offset: 0x0074CA64
	// (set) Token: 0x0601AF41 RID: 110401 RVA: 0x0074E86C File Offset: 0x0074CA6C
	public float? ReturnTimeoutFailed { get; set; }

	// Token: 0x17002549 RID: 9545
	// (get) Token: 0x0601AF42 RID: 110402 RVA: 0x0074E875 File Offset: 0x0074CA75
	// (set) Token: 0x0601AF43 RID: 110403 RVA: 0x0074E87D File Offset: 0x0074CA7D
	public bool? ForceResetOnLargeDelta { get; set; }

	// Token: 0x1700254A RID: 9546
	// (get) Token: 0x0601AF44 RID: 110404 RVA: 0x0074E886 File Offset: 0x0074CA86
	// (set) Token: 0x0601AF45 RID: 110405 RVA: 0x0074E88E File Offset: 0x0074CA8E
	public int? LargeDeltaResetMinMove { get; set; }
}
