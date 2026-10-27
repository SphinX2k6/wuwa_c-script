using System;
using System.Runtime.CompilerServices;

// Token: 0x02001562 RID: 5474
[NullableContext(1)]
[Nullable(0)]
[RequiredMember]
public class VersionPreheatActivityTitleData
{
	// Token: 0x06009CDE RID: 40158 RVA: 0x0021EF02 File Offset: 0x0021D102
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public VersionPreheatActivityTitleData()
	{
	}

	// Token: 0x040044AD RID: 17581
	[RequiredMember]
	public string TitleTextId;

	// Token: 0x040044AE RID: 17582
	[RequiredMember]
	public string SubTitleTextId;
}
