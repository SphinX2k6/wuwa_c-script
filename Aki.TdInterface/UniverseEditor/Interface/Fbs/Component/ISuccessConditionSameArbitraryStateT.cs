using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005FF4 RID: 24564
	public class ISuccessConditionSameArbitraryStateT
	{
		// Token: 0x1700B61E RID: 46622
		// (get) Token: 0x06029636 RID: 169526 RVA: 0x005A634E File Offset: 0x005A454E
		// (set) Token: 0x06029637 RID: 169527 RVA: 0x005A6356 File Offset: 0x005A4556
		public ETargetGearGroupSuccessCondition Type { get; set; }

		// Token: 0x06029638 RID: 169528 RVA: 0x005A635F File Offset: 0x005A455F
		public ISuccessConditionSameArbitraryStateT()
		{
			this.Type = ETargetGearGroupSuccessCondition.SameSpecificState;
		}
	}
}
