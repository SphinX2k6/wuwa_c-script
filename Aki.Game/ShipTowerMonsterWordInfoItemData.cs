using System;
using System.Runtime.CompilerServices;

// Token: 0x02001F06 RID: 7942
[NullableContext(2)]
[Nullable(0)]
[RequiredMember]
public class ShipTowerMonsterWordInfoItemData
{
	// Token: 0x06013A43 RID: 80451 RVA: 0x005BA069 File Offset: 0x005B8269
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public ShipTowerMonsterWordInfoItemData()
	{
	}

	// Token: 0x0400A7D1 RID: 42961
	public string Title;

	// Token: 0x0400A7D2 RID: 42962
	public string TitleColor;

	// Token: 0x0400A7D3 RID: 42963
	public string IconPath;

	// Token: 0x0400A7D4 RID: 42964
	[Nullable(1)]
	[RequiredMember]
	public string Desc;
}
