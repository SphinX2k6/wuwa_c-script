using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F09 RID: 20233
	public class ICheckHandBookPageCompleteT
	{
		// Token: 0x1700907D RID: 36989
		// (get) Token: 0x0601F6F1 RID: 128753 RVA: 0x00460ABA File Offset: 0x0045ECBA
		// (set) Token: 0x0601F6F2 RID: 128754 RVA: 0x00460AC2 File Offset: 0x0045ECC2
		public ECheckSystemStateType Type { get; set; }

		// Token: 0x1700907E RID: 36990
		// (get) Token: 0x0601F6F3 RID: 128755 RVA: 0x00460ACB File Offset: 0x0045ECCB
		// (set) Token: 0x0601F6F4 RID: 128756 RVA: 0x00460AD3 File Offset: 0x0045ECD3
		public int Id { get; set; }

		// Token: 0x1700907F RID: 36991
		// (get) Token: 0x0601F6F5 RID: 128757 RVA: 0x00460ADC File Offset: 0x0045ECDC
		// (set) Token: 0x0601F6F6 RID: 128758 RVA: 0x00460AE4 File Offset: 0x0045ECE4
		public bool IsComplete { get; set; }

		// Token: 0x0601F6F7 RID: 128759 RVA: 0x00460AED File Offset: 0x0045ECED
		public ICheckHandBookPageCompleteT()
		{
			this.Type = ECheckSystemStateType.TrackMoonBuilding;
			this.Id = 0;
			this.IsComplete = false;
		}
	}
}
