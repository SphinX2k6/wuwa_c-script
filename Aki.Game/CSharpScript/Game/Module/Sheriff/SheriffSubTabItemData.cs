using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Sheriff
{
	// Token: 0x02003BF1 RID: 15345
	[NullableContext(1)]
	[Nullable(0)]
	public class SheriffSubTabItemData : ISheriffSubTabItemData
	{
		// Token: 0x17005060 RID: 20576
		// (get) Token: 0x0602758F RID: 161167 RVA: 0x00B07E4D File Offset: 0x00B0604D
		// (set) Token: 0x06027590 RID: 161168 RVA: 0x00B07E55 File Offset: 0x00B06055
		public ESheriffSubTabType TabType { get; set; }

		// Token: 0x17005061 RID: 20577
		// (get) Token: 0x06027591 RID: 161169 RVA: 0x00B07E5E File Offset: 0x00B0605E
		// (set) Token: 0x06027592 RID: 161170 RVA: 0x00B07E66 File Offset: 0x00B06066
		public string TabIcon { get; set; } = "";

		// Token: 0x17005062 RID: 20578
		// (get) Token: 0x06027593 RID: 161171 RVA: 0x00B07E6F File Offset: 0x00B0606F
		// (set) Token: 0x06027594 RID: 161172 RVA: 0x00B07E77 File Offset: 0x00B06077
		public string TabTxt { get; set; } = "";

		// Token: 0x17005063 RID: 20579
		// (get) Token: 0x06027595 RID: 161173 RVA: 0x00B07E80 File Offset: 0x00B06080
		// (set) Token: 0x06027596 RID: 161174 RVA: 0x00B07E88 File Offset: 0x00B06088
		public bool IsFinished { get; set; }
	}
}
