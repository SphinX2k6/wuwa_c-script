using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020060FC RID: 24828
	public class IActorTurnToDataT
	{
		// Token: 0x1700B705 RID: 46853
		// (get) Token: 0x0602A6C5 RID: 173765 RVA: 0x005D854A File Offset: 0x005D674A
		// (set) Token: 0x0602A6C6 RID: 173766 RVA: 0x005D8552 File Offset: 0x005D6752
		public EActorTurnToMode Type { get; set; }

		// Token: 0x0602A6C7 RID: 173767 RVA: 0x005D855B File Offset: 0x005D675B
		public IActorTurnToDataT()
		{
			this.Type = EActorTurnToMode.Talker;
		}
	}
}
