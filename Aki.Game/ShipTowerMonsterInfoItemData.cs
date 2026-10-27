using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200298E RID: 10638
[NullableContext(1)]
[Nullable(0)]
[RequiredMember]
public class ShipTowerMonsterInfoItemData
{
	// Token: 0x06016040 RID: 90176 RVA: 0x0058F0BD File Offset: 0x0058D2BD
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public ShipTowerMonsterInfoItemData()
	{
	}

	// Token: 0x0400A3F0 RID: 41968
	[RequiredMember]
	public string Title;

	// Token: 0x0400A3F1 RID: 41969
	[RequiredMember]
	public int Level;

	// Token: 0x0400A3F2 RID: 41970
	[RequiredMember]
	public string MonsterIcon;

	// Token: 0x0400A3F3 RID: 41971
	[RequiredMember]
	public List<int> ElementList;
}
