using System;
using System.Runtime.CompilerServices;

// Token: 0x02000A26 RID: 2598
[NullableContext(1)]
[Nullable(0)]
[RequiredMember]
public class VersionPreheatShareData
{
	// Token: 0x060070C8 RID: 28872 RVA: 0x00228D12 File Offset: 0x00226F12
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public VersionPreheatShareData()
	{
	}

	// Token: 0x04004584 RID: 17796
	[RequiredMember]
	public string PhotoPath;

	// Token: 0x04004585 RID: 17797
	[RequiredMember]
	public string NameTextId;

	// Token: 0x04004586 RID: 17798
	[RequiredMember]
	public string ThemeTextId;
}
