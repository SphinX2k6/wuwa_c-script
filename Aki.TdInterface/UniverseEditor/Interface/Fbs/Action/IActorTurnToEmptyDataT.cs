using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006102 RID: 24834
	public class IActorTurnToEmptyDataT
	{
		// Token: 0x1700B70A RID: 46858
		// (get) Token: 0x0602A6EB RID: 173803 RVA: 0x005D88D2 File Offset: 0x005D6AD2
		// (set) Token: 0x0602A6EC RID: 173804 RVA: 0x005D88DA File Offset: 0x005D6ADA
		public EActorTurnToMode Type { get; set; }

		// Token: 0x0602A6ED RID: 173805 RVA: 0x005D88E3 File Offset: 0x005D6AE3
		public IActorTurnToEmptyDataT()
		{
			this.Type = EActorTurnToMode.Talker;
		}
	}
}
