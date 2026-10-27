using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020049D1 RID: 18897
	public class ICheckDollGrabShowcaseItemComboAchievedT
	{
		// Token: 0x170088A4 RID: 34980
		// (get) Token: 0x0601D82C RID: 120876 RVA: 0x00427E8C File Offset: 0x0042608C
		// (set) Token: 0x0601D82D RID: 120877 RVA: 0x00427E94 File Offset: 0x00426094
		public ECondition Type { get; set; }

		// Token: 0x170088A5 RID: 34981
		// (get) Token: 0x0601D82E RID: 120878 RVA: 0x00427E9D File Offset: 0x0042609D
		// (set) Token: 0x0601D82F RID: 120879 RVA: 0x00427EA5 File Offset: 0x004260A5
		public int ShowcaseEntityId { get; set; }

		// Token: 0x170088A6 RID: 34982
		// (get) Token: 0x0601D830 RID: 120880 RVA: 0x00427EAE File Offset: 0x004260AE
		// (set) Token: 0x0601D831 RID: 120881 RVA: 0x00427EB6 File Offset: 0x004260B6
		public ECompare Compare { get; set; }

		// Token: 0x170088A7 RID: 34983
		// (get) Token: 0x0601D832 RID: 120882 RVA: 0x00427EBF File Offset: 0x004260BF
		// (set) Token: 0x0601D833 RID: 120883 RVA: 0x00427EC7 File Offset: 0x004260C7
		public int Count { get; set; }

		// Token: 0x0601D834 RID: 120884 RVA: 0x00427ED0 File Offset: 0x004260D0
		public ICheckDollGrabShowcaseItemComboAchievedT()
		{
			this.Type = ECondition.CompareVar;
			this.ShowcaseEntityId = 0;
			this.Compare = ECompare.Eq;
			this.Count = 0;
		}
	}
}
