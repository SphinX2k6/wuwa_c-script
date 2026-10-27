using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007071 RID: 28785
	public class ISetSpineAnimationT
	{
		// Token: 0x1700D5F4 RID: 54772
		// (get) Token: 0x06032F82 RID: 208770 RVA: 0x006E0229 File Offset: 0x006DE429
		// (set) Token: 0x06032F83 RID: 208771 RVA: 0x006E0231 File Offset: 0x006DE431
		public IPlaySpineAnimationT Config { get; set; }

		// Token: 0x06032F84 RID: 208772 RVA: 0x006E023A File Offset: 0x006DE43A
		public ISetSpineAnimationT()
		{
			this.Config = null;
		}
	}
}
