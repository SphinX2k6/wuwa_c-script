using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005FF1 RID: 24561
	public class ISuccessConditionCountDownStateT
	{
		// Token: 0x1700B61B RID: 46619
		// (get) Token: 0x06029624 RID: 169508 RVA: 0x005A61D6 File Offset: 0x005A43D6
		// (set) Token: 0x06029625 RID: 169509 RVA: 0x005A61DE File Offset: 0x005A43DE
		public ETargetGearGroupSuccessCondition Type { get; set; }

		// Token: 0x06029626 RID: 169510 RVA: 0x005A61E7 File Offset: 0x005A43E7
		public ISuccessConditionCountDownStateT()
		{
			this.Type = ETargetGearGroupSuccessCondition.SameSpecificState;
		}
	}
}
