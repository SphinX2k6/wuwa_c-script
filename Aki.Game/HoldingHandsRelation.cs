using System;
using System.Runtime.CompilerServices;

// Token: 0x02001E63 RID: 7779
[NullableContext(2)]
[Nullable(0)]
public class HoldingHandsRelation : NpcRelation
{
	// Token: 0x1700128D RID: 4749
	// (get) Token: 0x0600EC91 RID: 60561 RVA: 0x00383CF1 File Offset: 0x00381EF1
	public override ENpcRelationType RelationType
	{
		get
		{
			return ENpcRelationType.HoldingHands;
		}
	}

	// Token: 0x0600EC92 RID: 60562 RVA: 0x00383CF4 File Offset: 0x00381EF4
	public bool IsValid()
	{
		return this.Leader != null && this.Leader.Valid && this.Follower != null && this.Follower.Valid;
	}

	// Token: 0x04006DAE RID: 28078
	public string Key;

	// Token: 0x04006DAF RID: 28079
	public CharacterHoldingHandsComponent Leader;

	// Token: 0x04006DB0 RID: 28080
	public EHandType LeaderHandType = EHandType.Right;

	// Token: 0x04006DB1 RID: 28081
	public CharacterHoldingHandsComponent Follower;

	// Token: 0x04006DB2 RID: 28082
	public EHandType FollowerHandType;
}
