using System;

namespace CSharpScript.Launcher.Ui.HotFix
{
	// Token: 0x020000D0 RID: 208
	public class HotFixDownLoadTabItemData : IHotFixDownLoadTabItemData, IHotFixLayoutData
	{
		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060006D7 RID: 1751 RVA: 0x0003943A File Offset: 0x0003763A
		// (set) Token: 0x060006D8 RID: 1752 RVA: 0x00039442 File Offset: 0x00037642
		public int? Index { get; set; }

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x060006D9 RID: 1753 RVA: 0x0003944B File Offset: 0x0003764B
		// (set) Token: 0x060006DA RID: 1754 RVA: 0x00039453 File Offset: 0x00037653
		public int TabId { get; set; }
	}
}
