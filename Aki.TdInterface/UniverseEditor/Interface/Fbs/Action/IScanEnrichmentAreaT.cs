using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076A3 RID: 30371
	public class IScanEnrichmentAreaT
	{
		// Token: 0x1700DED3 RID: 57043
		// (get) Token: 0x06035473 RID: 218227 RVA: 0x00725F30 File Offset: 0x00724130
		// (set) Token: 0x06035474 RID: 218228 RVA: 0x00725F38 File Offset: 0x00724138
		public EEnrichmentAreaType EnrichmentAreaType { get; set; }

		// Token: 0x1700DED4 RID: 57044
		// (get) Token: 0x06035475 RID: 218229 RVA: 0x00725F41 File Offset: 0x00724141
		// (set) Token: 0x06035476 RID: 218230 RVA: 0x00725F49 File Offset: 0x00724149
		public int EnrichmentAreaEntityId { get; set; }

		// Token: 0x06035477 RID: 218231 RVA: 0x00725F52 File Offset: 0x00724152
		public IScanEnrichmentAreaT()
		{
			this.EnrichmentAreaType = EEnrichmentAreaType.BigWorld;
			this.EnrichmentAreaEntityId = 0;
		}
	}
}
