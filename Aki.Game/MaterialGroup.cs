using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001D5D RID: 7517
[NullableContext(1)]
[Nullable(0)]
public class MaterialGroup : IMaterialGroup
{
	// Token: 0x17001BC0 RID: 7104
	// (get) Token: 0x0601296E RID: 76142 RVA: 0x0057BED8 File Offset: 0x0057A0D8
	// (set) Token: 0x0601296F RID: 76143 RVA: 0x0057BEE0 File Offset: 0x0057A0E0
	public int Type { get; set; }

	// Token: 0x17001BC1 RID: 7105
	// (get) Token: 0x06012970 RID: 76144 RVA: 0x0057BEE9 File Offset: 0x0057A0E9
	// (set) Token: 0x06012971 RID: 76145 RVA: 0x0057BEF1 File Offset: 0x0057A0F1
	public List<IItemMaterial> Materials { get; set; }
}
