using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001F05 RID: 7941
[NullableContext(1)]
[Nullable(0)]
[RequiredMember]
public class ShipTowerMonsterWordItemData
{
	// Token: 0x06013A42 RID: 80450 RVA: 0x005BA061 File Offset: 0x005B8261
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public ShipTowerMonsterWordItemData()
	{
	}

	// Token: 0x0400A7CF RID: 42959
	[RequiredMember]
	public string Title;

	// Token: 0x0400A7D0 RID: 42960
	[RequiredMember]
	public List<ShipTowerMonsterWordInfoItemData> InfoList;
}
