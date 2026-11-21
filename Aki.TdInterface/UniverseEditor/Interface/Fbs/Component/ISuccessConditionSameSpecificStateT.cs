using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005FF7 RID: 24567
	public class ISuccessConditionSameSpecificStateT
	{
		// Token: 0x1700B622 RID: 46626
		// (get) Token: 0x0602964C RID: 169548 RVA: 0x005A655F File Offset: 0x005A475F
		// (set) Token: 0x0602964D RID: 169549 RVA: 0x005A6567 File Offset: 0x005A4767
		public ETargetGearGroupSuccessCondition Type { get; set; }

		// Token: 0x1700B623 RID: 46627
		// (get) Token: 0x0602964E RID: 169550 RVA: 0x005A6570 File Offset: 0x005A4770
		// (set) Token: 0x0602964F RID: 169551 RVA: 0x005A6578 File Offset: 0x005A4778
		public string State { get; set; }

		// Token: 0x06029650 RID: 169552 RVA: 0x005A6581 File Offset: 0x005A4781
		public ISuccessConditionSameSpecificStateT()
		{
			this.Type = ETargetGearGroupSuccessCondition.SameSpecificState;
			this.State = null;
		}
	}
}
