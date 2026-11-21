using System;
using System.Runtime.CompilerServices;

// Token: 0x02001325 RID: 4901
[NullableContext(2)]
[Nullable(0)]
public class HoldingHandsRelation : NpcRelation
{
	// Token: 0x170012B7 RID: 4791
	// (get) Token: 0x0600C0B0 RID: 49328 RVA: 0x0038F9AD File Offset: 0x0038DBAD
	public override ENpcRelationType RelationType
	{
		get
		{
			return ENpcRelationType.HoldingHands;
		}
	}

	// Token: 0x0600C0B1 RID: 49329 RVA: 0x0038F9B0 File Offset: 0x0038DBB0
	public bool IsValid()
	{
		return this.Leader != null && this.Leader.Valid && this.Follower != null && this.Follower.Valid;
	}

	// Token: 0x04006E8F RID: 28303
	public string Key;

	// Token: 0x04006E90 RID: 28304
	public CharacterHoldingHandsComponent Leader;

	// Token: 0x04006E91 RID: 28305
	public EHandType LeaderHandType = EHandType.Right;

	// Token: 0x04006E92 RID: 28306
	public CharacterHoldingHandsComponent Follower;

	// Token: 0x04006E93 RID: 28307
	public EHandType FollowerHandType;
}
