using System;

namespace CSharpScript.Game.Module.RoleUi
{
	// Token: 0x02004CE8 RID: 19688
	public class StarItemData : IStarItemData
	{
		// Token: 0x17007DA6 RID: 32166
		// (get) Token: 0x06032D87 RID: 208263 RVA: 0x00BD9656 File Offset: 0x00BD7856
		// (set) Token: 0x06032D88 RID: 208264 RVA: 0x00BD965E File Offset: 0x00BD785E
		public bool StarOnActive { get; set; }

		// Token: 0x17007DA7 RID: 32167
		// (get) Token: 0x06032D89 RID: 208265 RVA: 0x00BD9667 File Offset: 0x00BD7867
		// (set) Token: 0x06032D8A RID: 208266 RVA: 0x00BD966F File Offset: 0x00BD786F
		public bool StarOffActive { get; set; }

		// Token: 0x17007DA8 RID: 32168
		// (get) Token: 0x06032D8B RID: 208267 RVA: 0x00BD9678 File Offset: 0x00BD7878
		// (set) Token: 0x06032D8C RID: 208268 RVA: 0x00BD9680 File Offset: 0x00BD7880
		public bool StarNextActive { get; set; }

		// Token: 0x17007DA9 RID: 32169
		// (get) Token: 0x06032D8D RID: 208269 RVA: 0x00BD9689 File Offset: 0x00BD7889
		// (set) Token: 0x06032D8E RID: 208270 RVA: 0x00BD9691 File Offset: 0x00BD7891
		public bool StarLoopActive { get; set; }

		// Token: 0x17007DAA RID: 32170
		// (get) Token: 0x06032D8F RID: 208271 RVA: 0x00BD969A File Offset: 0x00BD789A
		// (set) Token: 0x06032D90 RID: 208272 RVA: 0x00BD96A2 File Offset: 0x00BD78A2
		public bool PlayLoopSequence { get; set; }

		// Token: 0x17007DAB RID: 32171
		// (get) Token: 0x06032D91 RID: 208273 RVA: 0x00BD96AB File Offset: 0x00BD78AB
		// (set) Token: 0x06032D92 RID: 208274 RVA: 0x00BD96B3 File Offset: 0x00BD78B3
		public bool PlayActivateSequence { get; set; }
	}
}
