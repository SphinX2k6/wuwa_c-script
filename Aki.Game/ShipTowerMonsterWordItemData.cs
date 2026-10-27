using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200298A RID: 10634
[NullableContext(1)]
[Nullable(0)]
[RequiredMember]
public class ShipTowerMonsterWordItemData
{
	// Token: 0x0601603C RID: 90172 RVA: 0x0058F09D File Offset: 0x0058D29D
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public ShipTowerMonsterWordItemData()
	{
	}

	// Token: 0x0400A3E5 RID: 41957
	[RequiredMember]
	public string Title;

	// Token: 0x0400A3E6 RID: 41958
	[RequiredMember]
	public List<ShipTowerMonsterWordInfoItemData> InfoList;
}
