using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007CC3 RID: 31939
	public class IUnlockCookSystemTypeT
	{
		// Token: 0x1700EF1A RID: 61210
		// (get) Token: 0x060399E4 RID: 236004 RVA: 0x007C63B6 File Offset: 0x007C45B6
		// (set) Token: 0x060399E5 RID: 236005 RVA: 0x007C63BE File Offset: 0x007C45BE
		public EUnlockCookSystemType Type { get; set; }

		// Token: 0x060399E6 RID: 236006 RVA: 0x007C63C7 File Offset: 0x007C45C7
		public IUnlockCookSystemTypeT()
		{
			this.Type = EUnlockCookSystemType.UnlockCookBook;
		}
	}
}
