using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056AA RID: 22186
	public class IEnrichmentAreaComponentT
	{
		// Token: 0x17009FA8 RID: 40872
		// (get) Token: 0x06023890 RID: 145552 RVA: 0x004E33B6 File Offset: 0x004E15B6
		// (set) Token: 0x06023891 RID: 145553 RVA: 0x004E33BE File Offset: 0x004E15BE
		public bool Disabled { get; set; }

		// Token: 0x17009FA9 RID: 40873
		// (get) Token: 0x06023892 RID: 145554 RVA: 0x004E33C7 File Offset: 0x004E15C7
		// (set) Token: 0x06023893 RID: 145555 RVA: 0x004E33CF File Offset: 0x004E15CF
		public EEnrichmentAreaType EnrichmentAreaType { get; set; }

		// Token: 0x17009FAA RID: 40874
		// (get) Token: 0x06023894 RID: 145556 RVA: 0x004E33D8 File Offset: 0x004E15D8
		// (set) Token: 0x06023895 RID: 145557 RVA: 0x004E33E0 File Offset: 0x004E15E0
		public List<int> RefEntityIds { get; set; }

		// Token: 0x17009FAB RID: 40875
		// (get) Token: 0x06023896 RID: 145558 RVA: 0x004E33E9 File Offset: 0x004E15E9
		// (set) Token: 0x06023897 RID: 145559 RVA: 0x004E33F1 File Offset: 0x004E15F1
		public List<int> FogIds { get; set; }

		// Token: 0x17009FAC RID: 40876
		// (get) Token: 0x06023898 RID: 145560 RVA: 0x004E33FA File Offset: 0x004E15FA
		// (set) Token: 0x06023899 RID: 145561 RVA: 0x004E3402 File Offset: 0x004E1602
		public byte NullMask { get; set; }

		// Token: 0x0602389A RID: 145562 RVA: 0x004E340B File Offset: 0x004E160B
		public IEnrichmentAreaComponentT()
		{
			this.Disabled = false;
			this.EnrichmentAreaType = EEnrichmentAreaType.BigWorld;
			this.RefEntityIds = null;
			this.FogIds = null;
			this.NullMask = 0;
		}
	}
}
