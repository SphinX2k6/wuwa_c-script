using System;
using System.Runtime.CompilerServices;

// Token: 0x02000A19 RID: 2585
[NullableContext(1)]
[Nullable(0)]
[RequiredMember]
public class VersionPreheatActivityInfoData
{
	// Token: 0x060070BB RID: 28859 RVA: 0x00228CAA File Offset: 0x00226EAA
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public VersionPreheatActivityInfoData()
	{
	}

	// Token: 0x0400454F RID: 17743
	[RequiredMember]
	public VersionPreheatActivityTitleData TitleData;

	// Token: 0x04004550 RID: 17744
	[RequiredMember]
	public VersionPreheatActivityDescriptionData DescriptionData;

	// Token: 0x04004551 RID: 17745
	[RequiredMember]
	public VersionPreheatActivityRewardData RewardData;

	// Token: 0x04004552 RID: 17746
	[RequiredMember]
	public VersionPreheatActivityBottomData BottomData;
}
