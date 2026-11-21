using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Level.KeepFollowing;
using CSharpScript.Game.LevelGamePlay;

// Token: 0x02002656 RID: 9814
[NullableContext(1)]
[Nullable(0)]
public class KeepFollowingParams
{
	// Token: 0x06018862 RID: 100450 RVA: 0x0076D81C File Offset: 0x0076BA1C
	public KeepFollowingParams(CharacterActorComponent leader, EHandType? handType = null)
	{
		this.Leader = leader;
		this.HandType = handType;
	}

	// Token: 0x06018863 RID: 100451 RVA: 0x0076D832 File Offset: 0x0076BA32
	public void InitWithDataAsset(BP_KeepFollowingConfig_C data)
	{
		this.DebugDraw = data.DebugDraw;
		this.MoveParamsInternal = new FollowingMoveParams(data);
		this.RotatorParamsInternal = new FollowingRotatorParams(data);
	}

	// Token: 0x06018864 RID: 100452 RVA: 0x0076D858 File Offset: 0x0076BA58
	public void InitWithParams(FollowingMoveParams moveParams, FollowingRotatorParams rotParams, bool? debug = null)
	{
		this.DebugDraw = debug.GetValueOrDefault();
		this.MoveParamsInternal = moveParams;
		this.RotatorParamsInternal = rotParams;
	}

	// Token: 0x170026AA RID: 9898
	// (get) Token: 0x06018865 RID: 100453 RVA: 0x0076D875 File Offset: 0x0076BA75
	public FollowingMoveParams MoveParams
	{
		get
		{
			if (this.MoveParamsInternal == null)
			{
				this.MoveParamsInternal = new FollowingMoveParams(null);
			}
			return this.MoveParamsInternal;
		}
	}

	// Token: 0x170026AB RID: 9899
	// (get) Token: 0x06018866 RID: 100454 RVA: 0x0076D891 File Offset: 0x0076BA91
	public FollowingRotatorParams RotatorParams
	{
		get
		{
			if (this.RotatorParamsInternal == null)
			{
				this.RotatorParamsInternal = new FollowingRotatorParams(null);
			}
			return this.RotatorParamsInternal;
		}
	}

	// Token: 0x0400D485 RID: 54405
	public bool DebugDraw;

	// Token: 0x0400D486 RID: 54406
	[Nullable(2)]
	public CharacterActorComponent Leader;

	// Token: 0x0400D487 RID: 54407
	public EHandType? HandType;

	// Token: 0x0400D488 RID: 54408
	public bool FollowingOnce;

	// Token: 0x0400D489 RID: 54409
	[Nullable(2)]
	public Action<ELevelEventState> Callback;

	// Token: 0x0400D48A RID: 54410
	[Nullable(2)]
	private FollowingMoveParams MoveParamsInternal;

	// Token: 0x0400D48B RID: 54411
	[Nullable(2)]
	private FollowingRotatorParams RotatorParamsInternal;
}
