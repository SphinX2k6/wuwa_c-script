using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Sheriff
{
	// Token: 0x02004C3A RID: 19514
	[NullableContext(2)]
	[Nullable(0)]
	public class SheriffMapPanelParam : ISheriffMapPanelParam
	{
		// Token: 0x17007CA4 RID: 31908
		// (get) Token: 0x060327B6 RID: 206774 RVA: 0x00BC3176 File Offset: 0x00BC1376
		// (set) Token: 0x060327B7 RID: 206775 RVA: 0x00BC317E File Offset: 0x00BC137E
		public ESheriffMainTabType? TabType { get; set; }

		// Token: 0x17007CA5 RID: 31909
		// (get) Token: 0x060327B8 RID: 206776 RVA: 0x00BC3187 File Offset: 0x00BC1387
		// (set) Token: 0x060327B9 RID: 206777 RVA: 0x00BC318F File Offset: 0x00BC138F
		public int? TargetMarkId { get; set; }

		// Token: 0x17007CA6 RID: 31910
		// (get) Token: 0x060327BA RID: 206778 RVA: 0x00BC3198 File Offset: 0x00BC1398
		// (set) Token: 0x060327BB RID: 206779 RVA: 0x00BC31A0 File Offset: 0x00BC13A0
		public bool? IsError { get; set; }

		// Token: 0x17007CA7 RID: 31911
		// (get) Token: 0x060327BC RID: 206780 RVA: 0x00BC31A9 File Offset: 0x00BC13A9
		// (set) Token: 0x060327BD RID: 206781 RVA: 0x00BC31B1 File Offset: 0x00BC13B1
		public Action OnPanelOpened { get; set; }
	}
}
