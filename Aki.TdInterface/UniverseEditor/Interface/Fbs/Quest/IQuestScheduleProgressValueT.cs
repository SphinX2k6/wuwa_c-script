using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004032 RID: 16434
	public class IQuestScheduleProgressValueT
	{
		// Token: 0x170073A0 RID: 29600
		// (get) Token: 0x06017C5C RID: 97372 RVA: 0x0036DF80 File Offset: 0x0036C180
		// (set) Token: 0x06017C5D RID: 97373 RVA: 0x0036DF88 File Offset: 0x0036C188
		public EQuestScheduleType Type { get; set; }

		// Token: 0x170073A1 RID: 29601
		// (get) Token: 0x06017C5E RID: 97374 RVA: 0x0036DF91 File Offset: 0x0036C191
		// (set) Token: 0x06017C5F RID: 97375 RVA: 0x0036DF99 File Offset: 0x0036C199
		public int TargetProgressEntity { get; set; }

		// Token: 0x06017C60 RID: 97376 RVA: 0x0036DFA2 File Offset: 0x0036C1A2
		public IQuestScheduleProgressValueT()
		{
			this.Type = EQuestScheduleType.None;
			this.TargetProgressEntity = 0;
		}
	}
}
