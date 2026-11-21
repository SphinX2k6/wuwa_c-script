using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000A1C RID: 2588
[NullableContext(1)]
[Nullable(0)]
[RequiredMember]
public class VersionPreheatActivityRewardData
{
	// Token: 0x060070BE RID: 28862 RVA: 0x00228CC2 File Offset: 0x00226EC2
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public VersionPreheatActivityRewardData()
	{
	}

	// Token: 0x04004556 RID: 17750
	[RequiredMember]
	public string TitleId;

	// Token: 0x04004557 RID: 17751
	[RequiredMember]
	public List<TItem> RewardList;
}
