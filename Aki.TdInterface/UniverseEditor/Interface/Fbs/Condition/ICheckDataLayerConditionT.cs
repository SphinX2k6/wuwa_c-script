using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020049C5 RID: 18885
	public class ICheckDataLayerConditionT
	{
		// Token: 0x1700888B RID: 34955
		// (get) Token: 0x0601D7C4 RID: 120772 RVA: 0x0042724E File Offset: 0x0042544E
		// (set) Token: 0x0601D7C5 RID: 120773 RVA: 0x00427256 File Offset: 0x00425456
		public int DataLayerId { get; set; }

		// Token: 0x1700888C RID: 34956
		// (get) Token: 0x0601D7C6 RID: 120774 RVA: 0x0042725F File Offset: 0x0042545F
		// (set) Token: 0x0601D7C7 RID: 120775 RVA: 0x00427267 File Offset: 0x00425467
		public bool IsLoad { get; set; }

		// Token: 0x1700888D RID: 34957
		// (get) Token: 0x0601D7C8 RID: 120776 RVA: 0x00427270 File Offset: 0x00425470
		// (set) Token: 0x0601D7C9 RID: 120777 RVA: 0x00427278 File Offset: 0x00425478
		public ECondition Type { get; set; }

		// Token: 0x0601D7CA RID: 120778 RVA: 0x00427281 File Offset: 0x00425481
		public ICheckDataLayerConditionT()
		{
			this.DataLayerId = 0;
			this.IsLoad = false;
			this.Type = ECondition.CompareVar;
		}
	}
}
