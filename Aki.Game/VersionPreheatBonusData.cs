using System;
using System.Runtime.CompilerServices;

// Token: 0x02000A18 RID: 2584
[NullableContext(1)]
[Nullable(0)]
[RequiredMember]
public class VersionPreheatBonusData
{
	// Token: 0x060070BA RID: 28858 RVA: 0x00228CA2 File Offset: 0x00226EA2
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public VersionPreheatBonusData()
	{
	}

	// Token: 0x0400454C RID: 17740
	[RequiredMember]
	public string NumberTextId;

	// Token: 0x0400454D RID: 17741
	[RequiredMember]
	public string NumberTextArg;

	// Token: 0x0400454E RID: 17742
	[RequiredMember]
	public string ContentTextId;
}
