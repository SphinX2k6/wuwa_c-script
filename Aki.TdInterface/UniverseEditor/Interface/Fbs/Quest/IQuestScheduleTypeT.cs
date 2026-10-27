using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004044 RID: 16452
	public class IQuestScheduleTypeT
	{
		// Token: 0x170073CF RID: 29647
		// (get) Token: 0x06017D24 RID: 97572 RVA: 0x0036FC42 File Offset: 0x0036DE42
		// (set) Token: 0x06017D25 RID: 97573 RVA: 0x0036FC4A File Offset: 0x0036DE4A
		public EQuestScheduleType Type { get; set; }

		// Token: 0x06017D26 RID: 97574 RVA: 0x0036FC53 File Offset: 0x0036DE53
		public IQuestScheduleTypeT()
		{
			this.Type = EQuestScheduleType.None;
		}
	}
}
