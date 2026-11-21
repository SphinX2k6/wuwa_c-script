using System;

namespace CSharpScript.Launcher.Ui.HotFix
{
	// Token: 0x020000D3 RID: 211
	public class HotFixDownLoadTabItemData : IHotFixDownLoadTabItemData, IHotFixLayoutData
	{
		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x060006F3 RID: 1779 RVA: 0x0003AF6A File Offset: 0x0003916A
		// (set) Token: 0x060006F4 RID: 1780 RVA: 0x0003AF72 File Offset: 0x00039172
		public int? Index { get; set; }

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x060006F5 RID: 1781 RVA: 0x0003AF7B File Offset: 0x0003917B
		// (set) Token: 0x060006F6 RID: 1782 RVA: 0x0003AF83 File Offset: 0x00039183
		public int TabId { get; set; }
	}
}
