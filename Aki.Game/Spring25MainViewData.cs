using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020009C8 RID: 2504
[NullableContext(1)]
[Nullable(0)]
[RequiredMember]
public class Spring25MainViewData
{
	// Token: 0x06006DDF RID: 28127 RVA: 0x0021F1B7 File Offset: 0x0021D3B7
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public Spring25MainViewData()
	{
	}

	// Token: 0x0400444B RID: 17483
	[RequiredMember]
	public string TitleTextId;

	// Token: 0x0400444C RID: 17484
	[RequiredMember]
	public string InviteRemainCount;

	// Token: 0x0400444D RID: 17485
	[RequiredMember]
	public Dictionary<ESpring25RoleType, bool> CharacterInvitedMap;

	// Token: 0x0400444E RID: 17486
	public ESpring25RoleType? NewRoleType;
}
