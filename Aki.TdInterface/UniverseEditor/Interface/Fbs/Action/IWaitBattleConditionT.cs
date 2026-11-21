using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E07 RID: 32263
	public class IWaitBattleConditionT
	{
		// Token: 0x1700F1AF RID: 61871
		// (get) Token: 0x0603A4EB RID: 238827 RVA: 0x007DB105 File Offset: 0x007D9305
		// (set) Token: 0x0603A4EC RID: 238828 RVA: 0x007DB10D File Offset: 0x007D930D
		public IDetectBattleTagT StateOption { get; set; }

		// Token: 0x0603A4ED RID: 238829 RVA: 0x007DB116 File Offset: 0x007D9316
		public IWaitBattleConditionT()
		{
			this.StateOption = null;
		}
	}
}
