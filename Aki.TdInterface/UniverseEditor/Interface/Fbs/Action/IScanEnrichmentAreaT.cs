using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F1C RID: 28444
	public class IScanEnrichmentAreaT
	{
		// Token: 0x1700D377 RID: 54135
		// (get) Token: 0x0603241B RID: 205851 RVA: 0x006C9FC8 File Offset: 0x006C81C8
		// (set) Token: 0x0603241C RID: 205852 RVA: 0x006C9FD0 File Offset: 0x006C81D0
		public EEnrichmentAreaType EnrichmentAreaType { get; set; }

		// Token: 0x1700D378 RID: 54136
		// (get) Token: 0x0603241D RID: 205853 RVA: 0x006C9FD9 File Offset: 0x006C81D9
		// (set) Token: 0x0603241E RID: 205854 RVA: 0x006C9FE1 File Offset: 0x006C81E1
		public int EnrichmentAreaEntityId { get; set; }

		// Token: 0x0603241F RID: 205855 RVA: 0x006C9FEA File Offset: 0x006C81EA
		public IScanEnrichmentAreaT()
		{
			this.EnrichmentAreaType = EEnrichmentAreaType.BigWorld;
			this.EnrichmentAreaEntityId = 0;
		}
	}
}
