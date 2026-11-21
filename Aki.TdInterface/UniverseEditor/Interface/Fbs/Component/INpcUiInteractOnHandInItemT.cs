using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C19 RID: 23577
	public class INpcUiInteractOnHandInItemT
	{
		// Token: 0x1700ACD1 RID: 44241
		// (get) Token: 0x0602700C RID: 159756 RVA: 0x00557147 File Offset: 0x00555347
		// (set) Token: 0x0602700D RID: 159757 RVA: 0x0055714F File Offset: 0x0055534F
		public ENpcUiInteractType Type { get; set; }

		// Token: 0x1700ACD2 RID: 44242
		// (get) Token: 0x0602700E RID: 159758 RVA: 0x00557158 File Offset: 0x00555358
		// (set) Token: 0x0602700F RID: 159759 RVA: 0x00557160 File Offset: 0x00555360
		public string EnterMontage { get; set; }

		// Token: 0x1700ACD3 RID: 44243
		// (get) Token: 0x06027010 RID: 159760 RVA: 0x00557169 File Offset: 0x00555369
		// (set) Token: 0x06027011 RID: 159761 RVA: 0x00557171 File Offset: 0x00555371
		public string StandByMontage { get; set; }

		// Token: 0x1700ACD4 RID: 44244
		// (get) Token: 0x06027012 RID: 159762 RVA: 0x0055717A File Offset: 0x0055537A
		// (set) Token: 0x06027013 RID: 159763 RVA: 0x00557182 File Offset: 0x00555382
		public string HandInFailedMontage { get; set; }

		// Token: 0x1700ACD5 RID: 44245
		// (get) Token: 0x06027014 RID: 159764 RVA: 0x0055718B File Offset: 0x0055538B
		// (set) Token: 0x06027015 RID: 159765 RVA: 0x00557193 File Offset: 0x00555393
		public IPlayFlowT EnterFlow { get; set; }

		// Token: 0x1700ACD6 RID: 44246
		// (get) Token: 0x06027016 RID: 159766 RVA: 0x0055719C File Offset: 0x0055539C
		// (set) Token: 0x06027017 RID: 159767 RVA: 0x005571A4 File Offset: 0x005553A4
		public IPlayFlowT HandInFailedFlow { get; set; }

		// Token: 0x06027018 RID: 159768 RVA: 0x005571AD File Offset: 0x005553AD
		public INpcUiInteractOnHandInItemT()
		{
			this.Type = ENpcUiInteractType.HandInItem;
			this.EnterMontage = null;
			this.StandByMontage = null;
			this.HandInFailedMontage = null;
			this.EnterFlow = null;
			this.HandInFailedFlow = null;
		}
	}
}
