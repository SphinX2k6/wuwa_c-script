using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.DreamLink
{
	// Token: 0x02004A8D RID: 19085
	[NullableContext(1)]
	[Nullable(0)]
	public class DreamLinkReachedData : IDreamLinkReachedData
	{
		// Token: 0x17005FE7 RID: 24551
		// (get) Token: 0x0602FC40 RID: 195648 RVA: 0x00D5393E File Offset: 0x00D51B3E
		// (set) Token: 0x0602FC41 RID: 195649 RVA: 0x00D53946 File Offset: 0x00D51B46
		public string Title { get; set; }

		// Token: 0x17005FE8 RID: 24552
		// (get) Token: 0x0602FC42 RID: 195650 RVA: 0x00D5394F File Offset: 0x00D51B4F
		// (set) Token: 0x0602FC43 RID: 195651 RVA: 0x00D53957 File Offset: 0x00D51B57
		public string Score { get; set; }

		// Token: 0x17005FE9 RID: 24553
		// (get) Token: 0x0602FC44 RID: 195652 RVA: 0x00D53960 File Offset: 0x00D51B60
		// (set) Token: 0x0602FC45 RID: 195653 RVA: 0x00D53968 File Offset: 0x00D51B68
		public bool IsReached { get; set; }
	}
}
