using System;

namespace CSharpScript.Game.Module.Comic
{
	// Token: 0x02005B8B RID: 23435
	public interface IComicViewOpenParam
	{
		// Token: 0x17008CD6 RID: 36054
		// (get) Token: 0x0603B4AA RID: 242858
		// (set) Token: 0x0603B4AB RID: 242859
		int ComicId { get; set; }

		// Token: 0x17008CD7 RID: 36055
		// (get) Token: 0x0603B4AC RID: 242860
		// (set) Token: 0x0603B4AD RID: 242861
		bool? FadeBeforeHide { get; set; }
	}
}
