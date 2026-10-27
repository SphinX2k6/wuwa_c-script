using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020049D4 RID: 18900
	public class ICheckDrinksPreferenceLevelT
	{
		// Token: 0x170088AC RID: 34988
		// (get) Token: 0x0601D848 RID: 120904 RVA: 0x00428142 File Offset: 0x00426342
		// (set) Token: 0x0601D849 RID: 120905 RVA: 0x0042814A File Offset: 0x0042634A
		public ECondition Type { get; set; }

		// Token: 0x170088AD RID: 34989
		// (get) Token: 0x0601D84A RID: 120906 RVA: 0x00428153 File Offset: 0x00426353
		// (set) Token: 0x0601D84B RID: 120907 RVA: 0x0042815B File Offset: 0x0042635B
		public ECompare Compare { get; set; }

		// Token: 0x170088AE RID: 34990
		// (get) Token: 0x0601D84C RID: 120908 RVA: 0x00428164 File Offset: 0x00426364
		// (set) Token: 0x0601D84D RID: 120909 RVA: 0x0042816C File Offset: 0x0042636C
		public EDrinksPreferenceLevel Level { get; set; }

		// Token: 0x0601D84E RID: 120910 RVA: 0x00428175 File Offset: 0x00426375
		public ICheckDrinksPreferenceLevelT()
		{
			this.Type = ECondition.CompareVar;
			this.Compare = ECompare.Eq;
			this.Level = EDrinksPreferenceLevel.DisLike;
		}
	}
}
