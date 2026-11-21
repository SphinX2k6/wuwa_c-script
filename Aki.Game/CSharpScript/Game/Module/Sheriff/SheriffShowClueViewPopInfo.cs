using System;

namespace CSharpScript.Game.Module.Sheriff
{
	// Token: 0x02003C01 RID: 15361
	public class SheriffShowClueViewPopInfo : ISheriffShowClueViewPopInfo
	{
		// Token: 0x17005076 RID: 20598
		// (get) Token: 0x060275C3 RID: 161219 RVA: 0x00B08076 File Offset: 0x00B06276
		// (set) Token: 0x060275C4 RID: 161220 RVA: 0x00B0807E File Offset: 0x00B0627E
		public int AnomalyId { get; set; }

		// Token: 0x17005077 RID: 20599
		// (get) Token: 0x060275C5 RID: 161221 RVA: 0x00B08087 File Offset: 0x00B06287
		// (set) Token: 0x060275C6 RID: 161222 RVA: 0x00B0808F File Offset: 0x00B0628F
		public int? ClueId { get; set; }
	}
}
