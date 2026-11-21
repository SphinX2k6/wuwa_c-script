using System;

namespace CSharpScript.Game.Module.Comic
{
	// Token: 0x02004B6B RID: 19307
	public interface IComicViewOpenParam
	{
		// Token: 0x170060A8 RID: 24744
		// (get) Token: 0x060303F7 RID: 197623
		// (set) Token: 0x060303F8 RID: 197624
		int ComicId { get; set; }

		// Token: 0x170060A9 RID: 24745
		// (get) Token: 0x060303F9 RID: 197625
		// (set) Token: 0x060303FA RID: 197626
		bool? FadeBeforeHide { get; set; }
	}
}
