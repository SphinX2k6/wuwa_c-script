using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020060BD RID: 24765
	public class IActorFxEmoteStopSubTypeT
	{
		// Token: 0x1700B685 RID: 46725
		// (get) Token: 0x0602A496 RID: 173206 RVA: 0x005D4272 File Offset: 0x005D2472
		// (set) Token: 0x0602A497 RID: 173207 RVA: 0x005D427A File Offset: 0x005D247A
		public EActorFxEmoteStopSubType Type { get; set; }

		// Token: 0x0602A498 RID: 173208 RVA: 0x005D4283 File Offset: 0x005D2483
		public IActorFxEmoteStopSubTypeT()
		{
			this.Type = EActorFxEmoteStopSubType.StopAll;
		}
	}
}
