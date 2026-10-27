using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005145 RID: 20805
	public class IEnrichmentAreaComponentT
	{
		// Token: 0x170097BB RID: 38843
		// (get) Token: 0x0602193C RID: 137532 RVA: 0x004A942A File Offset: 0x004A762A
		// (set) Token: 0x0602193D RID: 137533 RVA: 0x004A9432 File Offset: 0x004A7632
		public bool Disabled { get; set; }

		// Token: 0x170097BC RID: 38844
		// (get) Token: 0x0602193E RID: 137534 RVA: 0x004A943B File Offset: 0x004A763B
		// (set) Token: 0x0602193F RID: 137535 RVA: 0x004A9443 File Offset: 0x004A7643
		public EEnrichmentAreaType EnrichmentAreaType { get; set; }

		// Token: 0x170097BD RID: 38845
		// (get) Token: 0x06021940 RID: 137536 RVA: 0x004A944C File Offset: 0x004A764C
		// (set) Token: 0x06021941 RID: 137537 RVA: 0x004A9454 File Offset: 0x004A7654
		public List<int> RefEntityIds { get; set; }

		// Token: 0x170097BE RID: 38846
		// (get) Token: 0x06021942 RID: 137538 RVA: 0x004A945D File Offset: 0x004A765D
		// (set) Token: 0x06021943 RID: 137539 RVA: 0x004A9465 File Offset: 0x004A7665
		public List<int> FogIds { get; set; }

		// Token: 0x170097BF RID: 38847
		// (get) Token: 0x06021944 RID: 137540 RVA: 0x004A946E File Offset: 0x004A766E
		// (set) Token: 0x06021945 RID: 137541 RVA: 0x004A9476 File Offset: 0x004A7676
		public byte NullMask { get; set; }

		// Token: 0x06021946 RID: 137542 RVA: 0x004A947F File Offset: 0x004A767F
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
