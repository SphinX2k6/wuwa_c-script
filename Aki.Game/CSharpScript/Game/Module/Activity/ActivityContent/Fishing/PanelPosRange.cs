using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02005574 RID: 21876
	public class PanelPosRange : IPanelPosRange
	{
		// Token: 0x17006924 RID: 26916
		// (get) Token: 0x0603639B RID: 222107 RVA: 0x00F20A67 File Offset: 0x00F1EC67
		// (set) Token: 0x0603639C RID: 222108 RVA: 0x00F20A6F File Offset: 0x00F1EC6F
		public int RowStartIndex { get; set; }

		// Token: 0x17006925 RID: 26917
		// (get) Token: 0x0603639D RID: 222109 RVA: 0x00F20A78 File Offset: 0x00F1EC78
		// (set) Token: 0x0603639E RID: 222110 RVA: 0x00F20A80 File Offset: 0x00F1EC80
		public int RowEndIndex { get; set; }

		// Token: 0x17006926 RID: 26918
		// (get) Token: 0x0603639F RID: 222111 RVA: 0x00F20A89 File Offset: 0x00F1EC89
		// (set) Token: 0x060363A0 RID: 222112 RVA: 0x00F20A91 File Offset: 0x00F1EC91
		public int ColStartIndex { get; set; }

		// Token: 0x17006927 RID: 26919
		// (get) Token: 0x060363A1 RID: 222113 RVA: 0x00F20A9A File Offset: 0x00F1EC9A
		// (set) Token: 0x060363A2 RID: 222114 RVA: 0x00F20AA2 File Offset: 0x00F1ECA2
		public int ColEndIndex { get; set; }
	}
}
