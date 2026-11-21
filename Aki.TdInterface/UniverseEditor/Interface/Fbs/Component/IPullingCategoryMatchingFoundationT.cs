using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005DB3 RID: 23987
	public class IPullingCategoryMatchingFoundationT
	{
		// Token: 0x1700B0B1 RID: 45233
		// (get) Token: 0x06027FD2 RID: 163794 RVA: 0x0057853B File Offset: 0x0057673B
		// (set) Token: 0x06027FD3 RID: 163795 RVA: 0x00578543 File Offset: 0x00576743
		public EPullingFoundation Type { get; set; }

		// Token: 0x1700B0B2 RID: 45234
		// (get) Token: 0x06027FD4 RID: 163796 RVA: 0x0057854C File Offset: 0x0057674C
		// (set) Token: 0x06027FD5 RID: 163797 RVA: 0x00578554 File Offset: 0x00576754
		public int InitMatchEntity { get; set; }

		// Token: 0x1700B0B3 RID: 45235
		// (get) Token: 0x06027FD6 RID: 163798 RVA: 0x0057855D File Offset: 0x0057675D
		// (set) Token: 0x06027FD7 RID: 163799 RVA: 0x00578565 File Offset: 0x00576765
		public List<ICategoryMatchingConfigBaseT> MatchingConfigs { get; set; }

		// Token: 0x1700B0B4 RID: 45236
		// (get) Token: 0x06027FD8 RID: 163800 RVA: 0x0057856E File Offset: 0x0057676E
		// (set) Token: 0x06027FD9 RID: 163801 RVA: 0x00578576 File Offset: 0x00576776
		public byte NullMask { get; set; }

		// Token: 0x06027FDA RID: 163802 RVA: 0x0057857F File Offset: 0x0057677F
		public IPullingCategoryMatchingFoundationT()
		{
			this.Type = EPullingFoundation.CategoryMatching;
			this.InitMatchEntity = 0;
			this.MatchingConfigs = null;
			this.NullMask = 0;
		}
	}
}
