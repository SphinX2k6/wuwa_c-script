using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Cook
{
	// Token: 0x02004AE3 RID: 19171
	[NullableContext(1)]
	[Nullable(0)]
	public class MachiningData : IMachiningData, ICookItemData
	{
		// Token: 0x1700603D RID: 24637
		// (get) Token: 0x0602FF57 RID: 196439 RVA: 0x00D61D59 File Offset: 0x00D5FF59
		// (set) Token: 0x0602FF58 RID: 196440 RVA: 0x00D61D61 File Offset: 0x00D5FF61
		public ECookListType MainType { get; set; }

		// Token: 0x1700603E RID: 24638
		// (get) Token: 0x0602FF59 RID: 196441 RVA: 0x00D61D6A File Offset: 0x00D5FF6A
		// (set) Token: 0x0602FF5A RID: 196442 RVA: 0x00D61D72 File Offset: 0x00D5FF72
		public int ItemId { get; set; }

		// Token: 0x1700603F RID: 24639
		// (get) Token: 0x0602FF5B RID: 196443 RVA: 0x00D61D7B File Offset: 0x00D5FF7B
		// (set) Token: 0x0602FF5C RID: 196444 RVA: 0x00D61D83 File Offset: 0x00D5FF83
		public bool IsNew { get; set; }

		// Token: 0x17006040 RID: 24640
		// (get) Token: 0x0602FF5D RID: 196445 RVA: 0x00D61D8C File Offset: 0x00D5FF8C
		// (set) Token: 0x0602FF5E RID: 196446 RVA: 0x00D61D94 File Offset: 0x00D5FF94
		public int Quality { get; set; }

		// Token: 0x17006041 RID: 24641
		// (get) Token: 0x0602FF5F RID: 196447 RVA: 0x00D61D9D File Offset: 0x00D5FF9D
		// (set) Token: 0x0602FF60 RID: 196448 RVA: 0x00D61DA5 File Offset: 0x00D5FFA5
		public bool IsUnLock { get; set; }

		// Token: 0x17006042 RID: 24642
		// (get) Token: 0x0602FF61 RID: 196449 RVA: 0x00D61DAE File Offset: 0x00D5FFAE
		// (set) Token: 0x0602FF62 RID: 196450 RVA: 0x00D61DB6 File Offset: 0x00D5FFB6
		public List<int> InteractiveList { get; set; }

		// Token: 0x17006043 RID: 24643
		// (get) Token: 0x0602FF63 RID: 196451 RVA: 0x00D61DBF File Offset: 0x00D5FFBF
		// (set) Token: 0x0602FF64 RID: 196452 RVA: 0x00D61DC7 File Offset: 0x00D5FFC7
		public List<int> UnlockList { get; set; }

		// Token: 0x17006044 RID: 24644
		// (get) Token: 0x0602FF65 RID: 196453 RVA: 0x00D61DD0 File Offset: 0x00D5FFD0
		// (set) Token: 0x0602FF66 RID: 196454 RVA: 0x00D61DD8 File Offset: 0x00D5FFD8
		public int IsMachining { get; set; }
	}
}
