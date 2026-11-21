using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F24 RID: 20260
	public class ICheckHonamiStoryLifeSupportLevelT
	{
		// Token: 0x170090B2 RID: 37042
		// (get) Token: 0x0601F7C7 RID: 128967 RVA: 0x00461F70 File Offset: 0x00460170
		// (set) Token: 0x0601F7C8 RID: 128968 RVA: 0x00461F78 File Offset: 0x00460178
		public ECondition Type { get; set; }

		// Token: 0x170090B3 RID: 37043
		// (get) Token: 0x0601F7C9 RID: 128969 RVA: 0x00461F81 File Offset: 0x00460181
		// (set) Token: 0x0601F7CA RID: 128970 RVA: 0x00461F89 File Offset: 0x00460189
		public int ActivityId { get; set; }

		// Token: 0x170090B4 RID: 37044
		// (get) Token: 0x0601F7CB RID: 128971 RVA: 0x00461F92 File Offset: 0x00460192
		// (set) Token: 0x0601F7CC RID: 128972 RVA: 0x00461F9A File Offset: 0x0046019A
		public ECompare Compare { get; set; }

		// Token: 0x170090B5 RID: 37045
		// (get) Token: 0x0601F7CD RID: 128973 RVA: 0x00461FA3 File Offset: 0x004601A3
		// (set) Token: 0x0601F7CE RID: 128974 RVA: 0x00461FAB File Offset: 0x004601AB
		public int Level { get; set; }

		// Token: 0x0601F7CF RID: 128975 RVA: 0x00461FB4 File Offset: 0x004601B4
		public ICheckHonamiStoryLifeSupportLevelT()
		{
			this.Type = ECondition.CompareVar;
			this.ActivityId = 0;
			this.Compare = ECompare.Eq;
			this.Level = 0;
		}
	}
}
