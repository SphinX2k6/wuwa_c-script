using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Sheriff
{
	// Token: 0x02003BEB RID: 15339
	[NullableContext(2)]
	[Nullable(0)]
	public class SheriffMapPanelParam : ISheriffMapPanelParam
	{
		// Token: 0x1700504E RID: 20558
		// (get) Token: 0x06027569 RID: 161129 RVA: 0x00B07D8E File Offset: 0x00B05F8E
		// (set) Token: 0x0602756A RID: 161130 RVA: 0x00B07D96 File Offset: 0x00B05F96
		public ESheriffMainTabType? TabType { get; set; }

		// Token: 0x1700504F RID: 20559
		// (get) Token: 0x0602756B RID: 161131 RVA: 0x00B07D9F File Offset: 0x00B05F9F
		// (set) Token: 0x0602756C RID: 161132 RVA: 0x00B07DA7 File Offset: 0x00B05FA7
		public int? TargetMarkId { get; set; }

		// Token: 0x17005050 RID: 20560
		// (get) Token: 0x0602756D RID: 161133 RVA: 0x00B07DB0 File Offset: 0x00B05FB0
		// (set) Token: 0x0602756E RID: 161134 RVA: 0x00B07DB8 File Offset: 0x00B05FB8
		public bool? IsError { get; set; }

		// Token: 0x17005051 RID: 20561
		// (get) Token: 0x0602756F RID: 161135 RVA: 0x00B07DC1 File Offset: 0x00B05FC1
		// (set) Token: 0x06027570 RID: 161136 RVA: 0x00B07DC9 File Offset: 0x00B05FC9
		public Action OnPanelOpened { get; set; }
	}
}
