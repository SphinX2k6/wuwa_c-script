using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001F09 RID: 7945
[NullableContext(1)]
[Nullable(0)]
[RequiredMember]
public class ShipTowerMonsterInfoItemData
{
	// Token: 0x06013A46 RID: 80454 RVA: 0x005BA081 File Offset: 0x005B8281
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public ShipTowerMonsterInfoItemData()
	{
	}

	// Token: 0x0400A7DA RID: 42970
	[RequiredMember]
	public string Title;

	// Token: 0x0400A7DB RID: 42971
	[RequiredMember]
	public int Level;

	// Token: 0x0400A7DC RID: 42972
	[RequiredMember]
	public string MonsterIcon;

	// Token: 0x0400A7DD RID: 42973
	[RequiredMember]
	public List<int> ElementList;
}
