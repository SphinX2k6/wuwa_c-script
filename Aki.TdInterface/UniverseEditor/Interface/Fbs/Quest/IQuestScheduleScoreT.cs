using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004479 RID: 17529
	public class IQuestScheduleScoreT
	{
		// Token: 0x170079AB RID: 31147
		// (get) Token: 0x06019324 RID: 103204 RVA: 0x003982EE File Offset: 0x003964EE
		// (set) Token: 0x06019325 RID: 103205 RVA: 0x003982F6 File Offset: 0x003964F6
		public EQuestScheduleType Type { get; set; }

		// Token: 0x06019326 RID: 103206 RVA: 0x003982FF File Offset: 0x003964FF
		public IQuestScheduleScoreT()
		{
			this.Type = EQuestScheduleType.None;
		}
	}
}
