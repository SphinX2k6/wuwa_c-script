using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001FC3 RID: 8131
[NullableContext(1)]
[Nullable(0)]
public class RoleFlySkinEquipData
{
	// Token: 0x0400AB67 RID: 43879
	public int RoleDataId;

	// Token: 0x0400AB68 RID: 43880
	public Dictionary<EFlySkinType, int> SkinEquipMap = new Dictionary<EFlySkinType, int>();

	// Token: 0x0400AB69 RID: 43881
	public HashSet<int> SkinEquipSet = new HashSet<int>();
}
