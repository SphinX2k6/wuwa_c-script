using System;
using System.Runtime.CompilerServices;

// Token: 0x02000A1A RID: 2586
[NullableContext(1)]
[Nullable(0)]
[RequiredMember]
public class VersionPreheatActivityTitleData
{
	// Token: 0x060070BC RID: 28860 RVA: 0x00228CB2 File Offset: 0x00226EB2
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public VersionPreheatActivityTitleData()
	{
	}

	// Token: 0x04004553 RID: 17747
	[RequiredMember]
	public string TitleTextId;

	// Token: 0x04004554 RID: 17748
	[RequiredMember]
	public string SubTitleTextId;
}
