using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay;

// Token: 0x02003104 RID: 12548
[NullableContext(2)]
public interface IMoveToPointConfig
{
	// Token: 0x1700252B RID: 9515
	// (get) Token: 0x0601AF06 RID: 110342
	// (set) Token: 0x0601AF07 RID: 110343
	[Nullable(1)]
	Vector Position { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x1700252C RID: 9516
	// (get) Token: 0x0601AF08 RID: 110344
	// (set) Token: 0x0601AF09 RID: 110345
	[Nullable(new byte[]
	{
		2,
		1
	})]
	Func<Vector> ReferencePosition { [return: Nullable(new byte[]
	{
		2,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1
	})] set; }

	// Token: 0x1700252D RID: 9517
	// (get) Token: 0x0601AF0A RID: 110346
	// (set) Token: 0x0601AF0B RID: 110347
	bool? IsFly { get; set; }

	// Token: 0x1700252E RID: 9518
	// (get) Token: 0x0601AF0C RID: 110348
	// (set) Token: 0x0601AF0D RID: 110349
	bool? IsForward { get; set; }

	// Token: 0x1700252F RID: 9519
	// (get) Token: 0x0601AF0E RID: 110350
	// (set) Token: 0x0601AF0F RID: 110351
	double? Distance { get; set; }

	// Token: 0x17002530 RID: 9520
	// (get) Token: 0x0601AF10 RID: 110352
	// (set) Token: 0x0601AF11 RID: 110353
	ECharMoveState? MoveState { get; set; }

	// Token: 0x17002531 RID: 9521
	// (get) Token: 0x0601AF12 RID: 110354
	// (set) Token: 0x0601AF13 RID: 110355
	float? MoveSpeed { get; set; }

	// Token: 0x17002532 RID: 9522
	// (get) Token: 0x0601AF14 RID: 110356
	// (set) Token: 0x0601AF15 RID: 110357
	float? TurnSpeed { get; set; }

	// Token: 0x17002533 RID: 9523
	// (get) Token: 0x0601AF16 RID: 110358
	// (set) Token: 0x0601AF17 RID: 110359
	[Nullable(new byte[]
	{
		2,
		1
	})]
	Queue<Vector> NextMovePointConfig { [return: Nullable(new byte[]
	{
		2,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1
	})] set; }

	// Token: 0x17002534 RID: 9524
	// (get) Token: 0x0601AF18 RID: 110360
	// (set) Token: 0x0601AF19 RID: 110361
	[Nullable(new byte[]
	{
		2,
		1
	})]
	List<Action<ELevelEventState>> CallbackList { [return: Nullable(new byte[]
	{
		2,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1
	})] set; }

	// Token: 0x17002535 RID: 9525
	// (get) Token: 0x0601AF1A RID: 110362
	// (set) Token: 0x0601AF1B RID: 110363
	Func<bool> ResetCondition { get; set; }

	// Token: 0x17002536 RID: 9526
	// (get) Token: 0x0601AF1C RID: 110364
	// (set) Token: 0x0601AF1D RID: 110365
	bool? UseNearestDirection { get; set; }

	// Token: 0x17002537 RID: 9527
	// (get) Token: 0x0601AF1E RID: 110366
	// (set) Token: 0x0601AF1F RID: 110367
	Vector FaceToPosition { get; set; }

	// Token: 0x17002538 RID: 9528
	// (get) Token: 0x0601AF20 RID: 110368
	// (set) Token: 0x0601AF21 RID: 110369
	float? ReturnTimeoutFailed { get; set; }

	// Token: 0x17002539 RID: 9529
	// (get) Token: 0x0601AF22 RID: 110370
	// (set) Token: 0x0601AF23 RID: 110371
	bool? ForceResetOnLargeDelta { get; set; }

	// Token: 0x1700253A RID: 9530
	// (get) Token: 0x0601AF24 RID: 110372
	// (set) Token: 0x0601AF25 RID: 110373
	int? LargeDeltaResetMinMove { get; set; }
}
