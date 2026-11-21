using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007302 RID: 29442
	public class INpcFollowConfigT
	{
		// Token: 0x1700D7E1 RID: 55265
		// (get) Token: 0x0603358D RID: 210317 RVA: 0x006ECC26 File Offset: 0x006EAE26
		// (set) Token: 0x0603358E RID: 210318 RVA: 0x006ECC2E File Offset: 0x006EAE2E
		public IPerformerRangeBoundaryActionTriggerT PerformerWhenEnter { get; set; }

		// Token: 0x1700D7E2 RID: 55266
		// (get) Token: 0x0603358F RID: 210319 RVA: 0x006ECC37 File Offset: 0x006EAE37
		// (set) Token: 0x06033590 RID: 210320 RVA: 0x006ECC3F File Offset: 0x006EAE3F
		public IPerformerRangeBoundaryActionTriggerT PerformerWhenExit { get; set; }

		// Token: 0x06033591 RID: 210321 RVA: 0x006ECC48 File Offset: 0x006EAE48
		public INpcFollowConfigT()
		{
			this.PerformerWhenEnter = null;
			this.PerformerWhenExit = null;
		}
	}
}
