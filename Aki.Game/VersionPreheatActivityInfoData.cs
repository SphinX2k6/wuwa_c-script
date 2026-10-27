using System;
using System.Runtime.CompilerServices;

// Token: 0x02001561 RID: 5473
[NullableContext(1)]
[Nullable(0)]
[RequiredMember]
public class VersionPreheatActivityInfoData
{
	// Token: 0x06009CDD RID: 40157 RVA: 0x0021EEFA File Offset: 0x0021D0FA
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public VersionPreheatActivityInfoData()
	{
	}

	// Token: 0x040044A9 RID: 17577
	[RequiredMember]
	public VersionPreheatActivityTitleData TitleData;

	// Token: 0x040044AA RID: 17578
	[RequiredMember]
	public VersionPreheatActivityDescriptionData DescriptionData;

	// Token: 0x040044AB RID: 17579
	[RequiredMember]
	public VersionPreheatActivityRewardData RewardData;

	// Token: 0x040044AC RID: 17580
	[RequiredMember]
	public VersionPreheatActivityBottomData BottomData;
}
