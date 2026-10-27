using System;

namespace CSharpScript.Game.Module.RoleUi
{
	// Token: 0x02004CE7 RID: 19687
	public interface IStarItemData
	{
		// Token: 0x17007DA0 RID: 32160
		// (get) Token: 0x06032D7B RID: 208251
		// (set) Token: 0x06032D7C RID: 208252
		bool StarOnActive { get; set; }

		// Token: 0x17007DA1 RID: 32161
		// (get) Token: 0x06032D7D RID: 208253
		// (set) Token: 0x06032D7E RID: 208254
		bool StarOffActive { get; set; }

		// Token: 0x17007DA2 RID: 32162
		// (get) Token: 0x06032D7F RID: 208255
		// (set) Token: 0x06032D80 RID: 208256
		bool StarNextActive { get; set; }

		// Token: 0x17007DA3 RID: 32163
		// (get) Token: 0x06032D81 RID: 208257
		// (set) Token: 0x06032D82 RID: 208258
		bool StarLoopActive { get; set; }

		// Token: 0x17007DA4 RID: 32164
		// (get) Token: 0x06032D83 RID: 208259
		// (set) Token: 0x06032D84 RID: 208260
		bool PlayLoopSequence { get; set; }

		// Token: 0x17007DA5 RID: 32165
		// (get) Token: 0x06032D85 RID: 208261
		// (set) Token: 0x06032D86 RID: 208262
		bool PlayActivateSequence { get; set; }
	}
}
