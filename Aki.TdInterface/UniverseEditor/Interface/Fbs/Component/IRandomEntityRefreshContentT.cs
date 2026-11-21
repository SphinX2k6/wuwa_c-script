using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005DEC RID: 24044
	public class IRandomEntityRefreshContentT
	{
		// Token: 0x1700B136 RID: 45366
		// (get) Token: 0x06028218 RID: 164376 RVA: 0x0057D1B3 File Offset: 0x0057B3B3
		// (set) Token: 0x06028219 RID: 164377 RVA: 0x0057D1BB File Offset: 0x0057B3BB
		public ERefreshContent Type { get; set; }

		// Token: 0x1700B137 RID: 45367
		// (get) Token: 0x0602821A RID: 164378 RVA: 0x0057D1C4 File Offset: 0x0057B3C4
		// (set) Token: 0x0602821B RID: 164379 RVA: 0x0057D1CC File Offset: 0x0057B3CC
		public List<int> EntityIds { get; set; }

		// Token: 0x0602821C RID: 164380 RVA: 0x0057D1D5 File Offset: 0x0057B3D5
		public IRandomEntityRefreshContentT()
		{
			this.Type = ERefreshContent.All;
			this.EntityIds = null;
		}
	}
}
