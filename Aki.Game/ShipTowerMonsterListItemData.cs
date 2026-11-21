using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001F08 RID: 7944
[NullableContext(1)]
[Nullable(0)]
[RequiredMember]
public class ShipTowerMonsterListItemData
{
	// Token: 0x06013A45 RID: 80453 RVA: 0x005BA079 File Offset: 0x005B8279
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public ShipTowerMonsterListItemData()
	{
	}

	// Token: 0x0400A7D8 RID: 42968
	[RequiredMember]
	public string Title;

	// Token: 0x0400A7D9 RID: 42969
	[RequiredMember]
	public List<ShipTowerMonsterInfoItemData> MonsterInfoList;
}
