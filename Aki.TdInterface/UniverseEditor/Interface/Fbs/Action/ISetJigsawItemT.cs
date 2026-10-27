using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007011 RID: 28689
	public class ISetJigsawItemT
	{
		// Token: 0x1700D50D RID: 54541
		// (get) Token: 0x06032BED RID: 207853 RVA: 0x006D8B55 File Offset: 0x006D6D55
		// (set) Token: 0x06032BEE RID: 207854 RVA: 0x006D8B5D File Offset: 0x006D6D5D
		public IMoveJigsawItemT Config { get; set; }

		// Token: 0x06032BEF RID: 207855 RVA: 0x006D8B66 File Offset: 0x006D6D66
		public ISetJigsawItemT()
		{
			this.Config = null;
		}
	}
}
