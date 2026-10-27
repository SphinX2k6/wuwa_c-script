using System;
using System.Runtime.CompilerServices;

// Token: 0x0200156E RID: 5486
[NullableContext(1)]
[Nullable(0)]
[RequiredMember]
public class VersionPreheatShareData
{
	// Token: 0x06009CEA RID: 40170 RVA: 0x0021EF62 File Offset: 0x0021D162
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public VersionPreheatShareData()
	{
	}

	// Token: 0x040044DE RID: 17630
	[RequiredMember]
	public string PhotoPath;

	// Token: 0x040044DF RID: 17631
	[RequiredMember]
	public string NameTextId;

	// Token: 0x040044E0 RID: 17632
	[RequiredMember]
	public string ThemeTextId;
}
