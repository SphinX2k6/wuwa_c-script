using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200707A RID: 28794
	public class ISetSportsStateT
	{
		// Token: 0x1700D5FC RID: 54780
		// (get) Token: 0x06032FB7 RID: 208823 RVA: 0x006E07D5 File Offset: 0x006DE9D5
		// (set) Token: 0x06032FB8 RID: 208824 RVA: 0x006E07DD File Offset: 0x006DE9DD
		public TSportStateUnion Config { get; set; }

		// Token: 0x06032FB9 RID: 208825 RVA: 0x006E07E6 File Offset: 0x006DE9E6
		public ISetSportsStateT()
		{
			this.Config = null;
		}
	}
}
