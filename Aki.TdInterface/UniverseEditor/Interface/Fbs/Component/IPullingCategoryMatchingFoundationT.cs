using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057AC RID: 22444
	public class IPullingCategoryMatchingFoundationT
	{
		// Token: 0x1700A78D RID: 42893
		// (get) Token: 0x06025AB2 RID: 154290 RVA: 0x005323AF File Offset: 0x005305AF
		// (set) Token: 0x06025AB3 RID: 154291 RVA: 0x005323B7 File Offset: 0x005305B7
		public EPullingFoundation Type { get; set; }

		// Token: 0x1700A78E RID: 42894
		// (get) Token: 0x06025AB4 RID: 154292 RVA: 0x005323C0 File Offset: 0x005305C0
		// (set) Token: 0x06025AB5 RID: 154293 RVA: 0x005323C8 File Offset: 0x005305C8
		public int InitMatchEntity { get; set; }

		// Token: 0x1700A78F RID: 42895
		// (get) Token: 0x06025AB6 RID: 154294 RVA: 0x005323D1 File Offset: 0x005305D1
		// (set) Token: 0x06025AB7 RID: 154295 RVA: 0x005323D9 File Offset: 0x005305D9
		public List<ICategoryMatchingConfigBaseT> MatchingConfigs { get; set; }

		// Token: 0x1700A790 RID: 42896
		// (get) Token: 0x06025AB8 RID: 154296 RVA: 0x005323E2 File Offset: 0x005305E2
		// (set) Token: 0x06025AB9 RID: 154297 RVA: 0x005323EA File Offset: 0x005305EA
		public byte NullMask { get; set; }

		// Token: 0x06025ABA RID: 154298 RVA: 0x005323F3 File Offset: 0x005305F3
		public IPullingCategoryMatchingFoundationT()
		{
			this.Type = EPullingFoundation.CategoryMatching;
			this.InitMatchEntity = 0;
			this.MatchingConfigs = null;
			this.NullMask = 0;
		}
	}
}
