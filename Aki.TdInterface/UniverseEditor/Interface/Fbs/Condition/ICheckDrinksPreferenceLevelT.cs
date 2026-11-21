using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E94 RID: 20116
	public class ICheckDrinksPreferenceLevelT
	{
		// Token: 0x17008F7C RID: 36732
		// (get) Token: 0x0601F2BB RID: 127675 RVA: 0x00458DAE File Offset: 0x00456FAE
		// (set) Token: 0x0601F2BC RID: 127676 RVA: 0x00458DB6 File Offset: 0x00456FB6
		public ECondition Type { get; set; }

		// Token: 0x17008F7D RID: 36733
		// (get) Token: 0x0601F2BD RID: 127677 RVA: 0x00458DBF File Offset: 0x00456FBF
		// (set) Token: 0x0601F2BE RID: 127678 RVA: 0x00458DC7 File Offset: 0x00456FC7
		public ECompare Compare { get; set; }

		// Token: 0x17008F7E RID: 36734
		// (get) Token: 0x0601F2BF RID: 127679 RVA: 0x00458DD0 File Offset: 0x00456FD0
		// (set) Token: 0x0601F2C0 RID: 127680 RVA: 0x00458DD8 File Offset: 0x00456FD8
		public EDrinksPreferenceLevel Level { get; set; }

		// Token: 0x0601F2C1 RID: 127681 RVA: 0x00458DE1 File Offset: 0x00456FE1
		public ICheckDrinksPreferenceLevelT()
		{
			this.Type = ECondition.CompareVar;
			this.Compare = ECompare.Eq;
			this.Level = EDrinksPreferenceLevel.DisLike;
		}
	}
}
