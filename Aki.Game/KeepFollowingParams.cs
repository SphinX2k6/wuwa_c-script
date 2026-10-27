using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Level.KeepFollowing;
using CSharpScript.Game.LevelGamePlay;

// Token: 0x020030FE RID: 12542
[NullableContext(1)]
[Nullable(0)]
public class KeepFollowingParams
{
	// Token: 0x0601AE3A RID: 110138 RVA: 0x00748130 File Offset: 0x00746330
	public KeepFollowingParams(CharacterActorComponent leader, EHandType? handType = null)
	{
		this.Leader = leader;
		this.HandType = handType;
	}

	// Token: 0x0601AE3B RID: 110139 RVA: 0x00748146 File Offset: 0x00746346
	public void InitWithDataAsset(BP_KeepFollowingConfig_C data)
	{
		this.DebugDraw = data.DebugDraw;
		this.MoveParamsInternal = new FollowingMoveParams(data);
		this.RotatorParamsInternal = new FollowingRotatorParams(data);
	}

	// Token: 0x0601AE3C RID: 110140 RVA: 0x0074816C File Offset: 0x0074636C
	public void InitWithParams(FollowingMoveParams moveParams, FollowingRotatorParams rotParams, bool? debug = null)
	{
		this.DebugDraw = debug.GetValueOrDefault();
		this.MoveParamsInternal = moveParams;
		this.RotatorParamsInternal = rotParams;
	}

	// Token: 0x17002515 RID: 9493
	// (get) Token: 0x0601AE3D RID: 110141 RVA: 0x00748189 File Offset: 0x00746389
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

	// Token: 0x17002516 RID: 9494
	// (get) Token: 0x0601AE3E RID: 110142 RVA: 0x007481A5 File Offset: 0x007463A5
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

	// Token: 0x0400D089 RID: 53385
	public bool DebugDraw;

	// Token: 0x0400D08A RID: 53386
	[Nullable(2)]
	public CharacterActorComponent Leader;

	// Token: 0x0400D08B RID: 53387
	public EHandType? HandType;

	// Token: 0x0400D08C RID: 53388
	public bool FollowingOnce;

	// Token: 0x0400D08D RID: 53389
	[Nullable(2)]
	public Action<ELevelEventState> Callback;

	// Token: 0x0400D08E RID: 53390
	[Nullable(2)]
	private FollowingMoveParams MoveParamsInternal;

	// Token: 0x0400D08F RID: 53391
	[Nullable(2)]
	private FollowingRotatorParams RotatorParamsInternal;
}
