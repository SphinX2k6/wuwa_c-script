using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001510 RID: 5392
[NullableContext(1)]
[Nullable(0)]
[RequiredMember]
public class Spring25MainViewData
{
	// Token: 0x06009A01 RID: 39425 RVA: 0x0021541B File Offset: 0x0021361B
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public Spring25MainViewData()
	{
	}

	// Token: 0x040043A5 RID: 17317
	[RequiredMember]
	public string TitleTextId;

	// Token: 0x040043A6 RID: 17318
	[RequiredMember]
	public string InviteRemainCount;

	// Token: 0x040043A7 RID: 17319
	[RequiredMember]
	public Dictionary<ESpring25RoleType, bool> CharacterInvitedMap;

	// Token: 0x040043A8 RID: 17320
	public ESpring25RoleType? NewRoleType;
}
