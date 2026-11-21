using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005092 RID: 20626
	public class ICompareFishingTechLevelT
	{
		// Token: 0x170093B2 RID: 37810
		// (get) Token: 0x06020460 RID: 132192 RVA: 0x00478B88 File Offset: 0x00476D88
		// (set) Token: 0x06020461 RID: 132193 RVA: 0x00478B90 File Offset: 0x00476D90
		public ECondition Type { get; set; }

		// Token: 0x170093B3 RID: 37811
		// (get) Token: 0x06020462 RID: 132194 RVA: 0x00478B99 File Offset: 0x00476D99
		// (set) Token: 0x06020463 RID: 132195 RVA: 0x00478BA1 File Offset: 0x00476DA1
		public int TechId { get; set; }

		// Token: 0x170093B4 RID: 37812
		// (get) Token: 0x06020464 RID: 132196 RVA: 0x00478BAA File Offset: 0x00476DAA
		// (set) Token: 0x06020465 RID: 132197 RVA: 0x00478BB2 File Offset: 0x00476DB2
		public ECompare Compare { get; set; }

		// Token: 0x170093B5 RID: 37813
		// (get) Token: 0x06020466 RID: 132198 RVA: 0x00478BBB File Offset: 0x00476DBB
		// (set) Token: 0x06020467 RID: 132199 RVA: 0x00478BC3 File Offset: 0x00476DC3
		public int TechLevel { get; set; }

		// Token: 0x06020468 RID: 132200 RVA: 0x00478BCC File Offset: 0x00476DCC
		public ICompareFishingTechLevelT()
		{
			this.Type = ECondition.CompareVar;
			this.TechId = 0;
			this.Compare = ECompare.Eq;
			this.TechLevel = 0;
		}
	}
}
