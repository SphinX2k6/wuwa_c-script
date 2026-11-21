using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075A4 RID: 30116
	public class IReignsChangeBackgroundT
	{
		// Token: 0x1700DD7A RID: 56698
		// (get) Token: 0x06034D4B RID: 216395 RVA: 0x0071A45F File Offset: 0x0071865F
		// (set) Token: 0x06034D4C RID: 216396 RVA: 0x0071A467 File Offset: 0x00718667
		public string Background { get; set; }

		// Token: 0x1700DD7B RID: 56699
		// (get) Token: 0x06034D4D RID: 216397 RVA: 0x0071A470 File Offset: 0x00718670
		// (set) Token: 0x06034D4E RID: 216398 RVA: 0x0071A478 File Offset: 0x00718678
		public EReignsBackgroundChangeMode ChangeMode { get; set; }

		// Token: 0x06034D4F RID: 216399 RVA: 0x0071A481 File Offset: 0x00718681
		public IReignsChangeBackgroundT()
		{
			this.Background = null;
			this.ChangeMode = EReignsBackgroundChangeMode.Instant;
		}
	}
}
