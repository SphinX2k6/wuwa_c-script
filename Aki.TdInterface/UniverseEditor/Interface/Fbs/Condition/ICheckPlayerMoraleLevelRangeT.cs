using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004FCF RID: 20431
	public class ICheckPlayerMoraleLevelRangeT
	{
		// Token: 0x17009224 RID: 37412
		// (get) Token: 0x0601FDBD RID: 130493 RVA: 0x0046CA4E File Offset: 0x0046AC4E
		// (set) Token: 0x0601FDBE RID: 130494 RVA: 0x0046CA56 File Offset: 0x0046AC56
		public ECondition Type { get; set; }

		// Token: 0x17009225 RID: 37413
		// (get) Token: 0x0601FDBF RID: 130495 RVA: 0x0046CA5F File Offset: 0x0046AC5F
		// (set) Token: 0x0601FDC0 RID: 130496 RVA: 0x0046CA67 File Offset: 0x0046AC67
		public int MinMoraleLevel { get; set; }

		// Token: 0x17009226 RID: 37414
		// (get) Token: 0x0601FDC1 RID: 130497 RVA: 0x0046CA70 File Offset: 0x0046AC70
		// (set) Token: 0x0601FDC2 RID: 130498 RVA: 0x0046CA78 File Offset: 0x0046AC78
		public int MaxMoraleLevel { get; set; }

		// Token: 0x0601FDC3 RID: 130499 RVA: 0x0046CA81 File Offset: 0x0046AC81
		public ICheckPlayerMoraleLevelRangeT()
		{
			this.Type = ECondition.CompareVar;
			this.MinMoraleLevel = 0;
			this.MaxMoraleLevel = 0;
		}
	}
}
