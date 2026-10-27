using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006108 RID: 24840
	public class IActorTurnToPlayerDataT
	{
		// Token: 0x1700B712 RID: 46866
		// (get) Token: 0x0602A713 RID: 173843 RVA: 0x005D8C4A File Offset: 0x005D6E4A
		// (set) Token: 0x0602A714 RID: 173844 RVA: 0x005D8C52 File Offset: 0x005D6E52
		public EActorTurnToMode Type { get; set; }

		// Token: 0x0602A715 RID: 173845 RVA: 0x005D8C5B File Offset: 0x005D6E5B
		public IActorTurnToPlayerDataT()
		{
			this.Type = EActorTurnToMode.Talker;
		}
	}
}
