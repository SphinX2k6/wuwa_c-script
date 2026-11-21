using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E43 RID: 20035
	public class ICheckBvbActivityRankT
	{
		// Token: 0x17008EBC RID: 36540
		// (get) Token: 0x0601EFE3 RID: 126947 RVA: 0x00453F66 File Offset: 0x00452166
		// (set) Token: 0x0601EFE4 RID: 126948 RVA: 0x00453F6E File Offset: 0x0045216E
		public ECondition Type { get; set; }

		// Token: 0x17008EBD RID: 36541
		// (get) Token: 0x0601EFE5 RID: 126949 RVA: 0x00453F77 File Offset: 0x00452177
		// (set) Token: 0x0601EFE6 RID: 126950 RVA: 0x00453F7F File Offset: 0x0045217F
		public ECompare Compare { get; set; }

		// Token: 0x17008EBE RID: 36542
		// (get) Token: 0x0601EFE7 RID: 126951 RVA: 0x00453F88 File Offset: 0x00452188
		// (set) Token: 0x0601EFE8 RID: 126952 RVA: 0x00453F90 File Offset: 0x00452190
		public int Rank { get; set; }

		// Token: 0x0601EFE9 RID: 126953 RVA: 0x00453F99 File Offset: 0x00452199
		public ICheckBvbActivityRankT()
		{
			this.Type = ECondition.CompareVar;
			this.Compare = ECompare.Eq;
			this.Rank = 0;
		}
	}
}
