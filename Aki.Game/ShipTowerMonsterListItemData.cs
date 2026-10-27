using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200298D RID: 10637
[NullableContext(1)]
[Nullable(0)]
[RequiredMember]
public class ShipTowerMonsterListItemData
{
	// Token: 0x0601603F RID: 90175 RVA: 0x0058F0B5 File Offset: 0x0058D2B5
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public ShipTowerMonsterListItemData()
	{
	}

	// Token: 0x0400A3EE RID: 41966
	[RequiredMember]
	public string Title;

	// Token: 0x0400A3EF RID: 41967
	[RequiredMember]
	public List<ShipTowerMonsterInfoItemData> MonsterInfoList;
}
