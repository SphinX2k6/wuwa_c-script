using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004041 RID: 16449
	public class IQuestScheduleTowerChallengeTitleT
	{
		// Token: 0x170073CC RID: 29644
		// (get) Token: 0x06017D12 RID: 97554 RVA: 0x0036FACA File Offset: 0x0036DCCA
		// (set) Token: 0x06017D13 RID: 97555 RVA: 0x0036FAD2 File Offset: 0x0036DCD2
		public EQuestScheduleType Type { get; set; }

		// Token: 0x06017D14 RID: 97556 RVA: 0x0036FADB File Offset: 0x0036DCDB
		public IQuestScheduleTowerChallengeTitleT()
		{
			this.Type = EQuestScheduleType.None;
		}
	}
}
