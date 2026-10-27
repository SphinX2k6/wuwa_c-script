using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001564 RID: 5476
[NullableContext(1)]
[Nullable(0)]
[RequiredMember]
public class VersionPreheatActivityRewardData
{
	// Token: 0x06009CE0 RID: 40160 RVA: 0x0021EF12 File Offset: 0x0021D112
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public VersionPreheatActivityRewardData()
	{
	}

	// Token: 0x040044B0 RID: 17584
	[RequiredMember]
	public string TitleId;

	// Token: 0x040044B1 RID: 17585
	[RequiredMember]
	public List<TItem> RewardList;
}
