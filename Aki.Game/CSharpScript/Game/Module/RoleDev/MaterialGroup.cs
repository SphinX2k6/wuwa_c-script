using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleDev
{
	// Token: 0x02004CBD RID: 19645
	[NullableContext(1)]
	[Nullable(0)]
	public class MaterialGroup : IMaterialGroup
	{
		// Token: 0x17007D23 RID: 32035
		// (get) Token: 0x06032B8A RID: 207754 RVA: 0x00BD511B File Offset: 0x00BD331B
		// (set) Token: 0x06032B8B RID: 207755 RVA: 0x00BD5123 File Offset: 0x00BD3323
		public int Type { get; set; }

		// Token: 0x17007D24 RID: 32036
		// (get) Token: 0x06032B8C RID: 207756 RVA: 0x00BD512C File Offset: 0x00BD332C
		// (set) Token: 0x06032B8D RID: 207757 RVA: 0x00BD5134 File Offset: 0x00BD3334
		public List<IItemMaterial> Materials { get; set; }
	}
}
