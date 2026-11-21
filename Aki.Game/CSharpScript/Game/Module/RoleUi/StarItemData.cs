using System;

namespace CSharpScript.Game.Module.RoleUi
{
	// Token: 0x02003C9A RID: 15514
	public class StarItemData : IStarItemData
	{
		// Token: 0x17005150 RID: 20816
		// (get) Token: 0x06027B62 RID: 162658 RVA: 0x00B1EF5E File Offset: 0x00B1D15E
		// (set) Token: 0x06027B63 RID: 162659 RVA: 0x00B1EF66 File Offset: 0x00B1D166
		public bool StarOnActive { get; set; }

		// Token: 0x17005151 RID: 20817
		// (get) Token: 0x06027B64 RID: 162660 RVA: 0x00B1EF6F File Offset: 0x00B1D16F
		// (set) Token: 0x06027B65 RID: 162661 RVA: 0x00B1EF77 File Offset: 0x00B1D177
		public bool StarOffActive { get; set; }

		// Token: 0x17005152 RID: 20818
		// (get) Token: 0x06027B66 RID: 162662 RVA: 0x00B1EF80 File Offset: 0x00B1D180
		// (set) Token: 0x06027B67 RID: 162663 RVA: 0x00B1EF88 File Offset: 0x00B1D188
		public bool StarNextActive { get; set; }

		// Token: 0x17005153 RID: 20819
		// (get) Token: 0x06027B68 RID: 162664 RVA: 0x00B1EF91 File Offset: 0x00B1D191
		// (set) Token: 0x06027B69 RID: 162665 RVA: 0x00B1EF99 File Offset: 0x00B1D199
		public bool StarLoopActive { get; set; }

		// Token: 0x17005154 RID: 20820
		// (get) Token: 0x06027B6A RID: 162666 RVA: 0x00B1EFA2 File Offset: 0x00B1D1A2
		// (set) Token: 0x06027B6B RID: 162667 RVA: 0x00B1EFAA File Offset: 0x00B1D1AA
		public bool PlayLoopSequence { get; set; }

		// Token: 0x17005155 RID: 20821
		// (get) Token: 0x06027B6C RID: 162668 RVA: 0x00B1EFB3 File Offset: 0x00B1D1B3
		// (set) Token: 0x06027B6D RID: 162669 RVA: 0x00B1EFBB File Offset: 0x00B1D1BB
		public bool PlayActivateSequence { get; set; }
	}
}
