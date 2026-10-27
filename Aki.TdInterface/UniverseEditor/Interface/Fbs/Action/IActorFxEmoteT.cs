using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020060AB RID: 24747
	public class IActorFxEmoteT
	{
		// Token: 0x1700B658 RID: 46680
		// (get) Token: 0x0602A3E8 RID: 173032 RVA: 0x005D2CFB File Offset: 0x005D0EFB
		// (set) Token: 0x0602A3E9 RID: 173033 RVA: 0x005D2D03 File Offset: 0x005D0F03
		public int ActorIndex { get; set; }

		// Token: 0x1700B659 RID: 46681
		// (get) Token: 0x0602A3EA RID: 173034 RVA: 0x005D2D0C File Offset: 0x005D0F0C
		// (set) Token: 0x0602A3EB RID: 173035 RVA: 0x005D2D14 File Offset: 0x005D0F14
		public TActorFxEmoteUnion FxEmote { get; set; }

		// Token: 0x0602A3EC RID: 173036 RVA: 0x005D2D1D File Offset: 0x005D0F1D
		public IActorFxEmoteT()
		{
			this.ActorIndex = 0;
			this.FxEmote = null;
		}
	}
}
