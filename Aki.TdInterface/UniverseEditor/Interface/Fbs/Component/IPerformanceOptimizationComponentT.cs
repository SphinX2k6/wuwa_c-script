using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D23 RID: 23843
	public class IPerformanceOptimizationComponentT
	{
		// Token: 0x1700AF47 RID: 44871
		// (get) Token: 0x06027A0B RID: 162315 RVA: 0x0056BEC9 File Offset: 0x0056A0C9
		// (set) Token: 0x06027A0C RID: 162316 RVA: 0x0056BED1 File Offset: 0x0056A0D1
		public bool Disabled { get; set; }

		// Token: 0x1700AF48 RID: 44872
		// (get) Token: 0x06027A0D RID: 162317 RVA: 0x0056BEDA File Offset: 0x0056A0DA
		// (set) Token: 0x06027A0E RID: 162318 RVA: 0x0056BEE2 File Offset: 0x0056A0E2
		public List<TPerformanceOptimizationTypeUnion> PerformanceOptimizationList { get; set; }

		// Token: 0x1700AF49 RID: 44873
		// (get) Token: 0x06027A0F RID: 162319 RVA: 0x0056BEEB File Offset: 0x0056A0EB
		// (set) Token: 0x06027A10 RID: 162320 RVA: 0x0056BEF3 File Offset: 0x0056A0F3
		public byte NullMask { get; set; }

		// Token: 0x06027A11 RID: 162321 RVA: 0x0056BEFC File Offset: 0x0056A0FC
		public IPerformanceOptimizationComponentT()
		{
			this.Disabled = false;
			this.PerformanceOptimizationList = null;
			this.NullMask = 0;
		}
	}
}
