using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.DreamLink
{
	// Token: 0x02004A90 RID: 19088
	[NullableContext(1)]
	[Nullable(0)]
	public class DreamLinkRecordData : IDreamLinkRecordData
	{
		// Token: 0x17005FED RID: 24557
		// (get) Token: 0x0602FC50 RID: 195664 RVA: 0x00D53A3F File Offset: 0x00D51C3F
		// (set) Token: 0x0602FC51 RID: 195665 RVA: 0x00D53A47 File Offset: 0x00D51C47
		public string Title { get; set; }

		// Token: 0x17005FEE RID: 24558
		// (get) Token: 0x0602FC52 RID: 195666 RVA: 0x00D53A50 File Offset: 0x00D51C50
		// (set) Token: 0x0602FC53 RID: 195667 RVA: 0x00D53A58 File Offset: 0x00D51C58
		public string Score { get; set; }

		// Token: 0x17005FEF RID: 24559
		// (get) Token: 0x0602FC54 RID: 195668 RVA: 0x00D53A61 File Offset: 0x00D51C61
		// (set) Token: 0x0602FC55 RID: 195669 RVA: 0x00D53A69 File Offset: 0x00D51C69
		public bool IsNew { get; set; }
	}
}
