using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleDev
{
	// Token: 0x02003C6E RID: 15470
	[NullableContext(1)]
	[Nullable(0)]
	public class MaterialGroup : IMaterialGroup
	{
		// Token: 0x170050CD RID: 20685
		// (get) Token: 0x0602793E RID: 162110 RVA: 0x00B19EB3 File Offset: 0x00B180B3
		// (set) Token: 0x0602793F RID: 162111 RVA: 0x00B19EBB File Offset: 0x00B180BB
		public int Type { get; set; }

		// Token: 0x170050CE RID: 20686
		// (get) Token: 0x06027940 RID: 162112 RVA: 0x00B19EC4 File Offset: 0x00B180C4
		// (set) Token: 0x06027941 RID: 162113 RVA: 0x00B19ECC File Offset: 0x00B180CC
		public List<IItemMaterial> Materials { get; set; }
	}
}
