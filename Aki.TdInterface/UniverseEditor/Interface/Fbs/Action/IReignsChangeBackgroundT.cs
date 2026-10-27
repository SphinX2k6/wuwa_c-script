using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E26 RID: 28198
	public class IReignsChangeBackgroundT
	{
		// Token: 0x1700D22B RID: 53803
		// (get) Token: 0x06031D35 RID: 204085 RVA: 0x006BEAD7 File Offset: 0x006BCCD7
		// (set) Token: 0x06031D36 RID: 204086 RVA: 0x006BEADF File Offset: 0x006BCCDF
		public string Background { get; set; }

		// Token: 0x1700D22C RID: 53804
		// (get) Token: 0x06031D37 RID: 204087 RVA: 0x006BEAE8 File Offset: 0x006BCCE8
		// (set) Token: 0x06031D38 RID: 204088 RVA: 0x006BEAF0 File Offset: 0x006BCCF0
		public EReignsBackgroundChangeMode ChangeMode { get; set; }

		// Token: 0x06031D39 RID: 204089 RVA: 0x006BEAF9 File Offset: 0x006BCCF9
		public IReignsChangeBackgroundT()
		{
			this.Background = null;
			this.ChangeMode = EReignsBackgroundChangeMode.Instant;
		}
	}
}
