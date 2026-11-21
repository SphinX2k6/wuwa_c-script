using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200509E RID: 20638
	public class ICompareMaxAlertValueT
	{
		// Token: 0x170093D1 RID: 37841
		// (get) Token: 0x060204CE RID: 132302 RVA: 0x00479652 File Offset: 0x00477852
		// (set) Token: 0x060204CF RID: 132303 RVA: 0x0047965A File Offset: 0x0047785A
		public EComparedAlertValueType Type { get; set; }

		// Token: 0x060204D0 RID: 132304 RVA: 0x00479663 File Offset: 0x00477863
		public ICompareMaxAlertValueT()
		{
			this.Type = EComparedAlertValueType.Min;
		}
	}
}
