using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005DEF RID: 24047
	public class IRandomInteractT
	{
		// Token: 0x1700B13B RID: 45371
		// (get) Token: 0x06028234 RID: 164404 RVA: 0x0057D53B File Offset: 0x0057B73B
		// (set) Token: 0x06028235 RID: 164405 RVA: 0x0057D543 File Offset: 0x0057B743
		public int RandomCount { get; set; }

		// Token: 0x1700B13C RID: 45372
		// (get) Token: 0x06028236 RID: 164406 RVA: 0x0057D54C File Offset: 0x0057B74C
		// (set) Token: 0x06028237 RID: 164407 RVA: 0x0057D554 File Offset: 0x0057B754
		public List<IRandomInteractOptionT> Options { get; set; }

		// Token: 0x06028238 RID: 164408 RVA: 0x0057D55D File Offset: 0x0057B75D
		public IRandomInteractT()
		{
			this.RandomCount = 0;
			this.Options = null;
		}
	}
}
