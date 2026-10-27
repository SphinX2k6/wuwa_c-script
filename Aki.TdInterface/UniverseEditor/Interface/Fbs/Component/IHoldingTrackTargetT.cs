using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053B1 RID: 21425
	public class IHoldingTrackTargetT
	{
		// Token: 0x17009D73 RID: 40307
		// (get) Token: 0x060231AA RID: 143786 RVA: 0x004DC005 File Offset: 0x004DA205
		// (set) Token: 0x060231AB RID: 143787 RVA: 0x004DC00D File Offset: 0x004DA20D
		public string EffectPath { get; set; }

		// Token: 0x17009D74 RID: 40308
		// (get) Token: 0x060231AC RID: 143788 RVA: 0x004DC016 File Offset: 0x004DA216
		// (set) Token: 0x060231AD RID: 143789 RVA: 0x004DC01E File Offset: 0x004DA21E
		public int EffectLength { get; set; }

		// Token: 0x17009D75 RID: 40309
		// (get) Token: 0x060231AE RID: 143790 RVA: 0x004DC027 File Offset: 0x004DA227
		// (set) Token: 0x060231AF RID: 143791 RVA: 0x004DC02F File Offset: 0x004DA22F
		public int EntityId { get; set; }

		// Token: 0x060231B0 RID: 143792 RVA: 0x004DC038 File Offset: 0x004DA238
		public IHoldingTrackTargetT()
		{
			this.EffectPath = null;
			this.EffectLength = 0;
			this.EntityId = 0;
		}
	}
}
