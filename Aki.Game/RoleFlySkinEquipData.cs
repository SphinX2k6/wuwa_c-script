using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002A48 RID: 10824
[NullableContext(1)]
[Nullable(0)]
public class RoleFlySkinEquipData
{
	// Token: 0x0400A763 RID: 42851
	public int RoleDataId;

	// Token: 0x0400A764 RID: 42852
	public Dictionary<EFlySkinType, int> SkinEquipMap = new Dictionary<EFlySkinType, int>();

	// Token: 0x0400A765 RID: 42853
	public HashSet<int> SkinEquipSet = new HashSet<int>();
}
