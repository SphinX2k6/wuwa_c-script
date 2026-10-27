using System;
using System.Runtime.CompilerServices;

// Token: 0x02001560 RID: 5472
[NullableContext(1)]
[Nullable(0)]
[RequiredMember]
public class VersionPreheatBonusData
{
	// Token: 0x06009CDC RID: 40156 RVA: 0x0021EEF2 File Offset: 0x0021D0F2
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public VersionPreheatBonusData()
	{
	}

	// Token: 0x040044A6 RID: 17574
	[RequiredMember]
	public string NumberTextId;

	// Token: 0x040044A7 RID: 17575
	[RequiredMember]
	public string NumberTextArg;

	// Token: 0x040044A8 RID: 17576
	[RequiredMember]
	public string ContentTextId;
}
