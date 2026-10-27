using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020060BA RID: 24762
	public class IActorFxEmoteStopSocketsT
	{
		// Token: 0x1700B681 RID: 46721
		// (get) Token: 0x0602A482 RID: 173186 RVA: 0x005D40D7 File Offset: 0x005D22D7
		// (set) Token: 0x0602A483 RID: 173187 RVA: 0x005D40DF File Offset: 0x005D22DF
		public EActorFxEmoteStopSubType Type { get; set; }

		// Token: 0x1700B682 RID: 46722
		// (get) Token: 0x0602A484 RID: 173188 RVA: 0x005D40E8 File Offset: 0x005D22E8
		// (set) Token: 0x0602A485 RID: 173189 RVA: 0x005D40F0 File Offset: 0x005D22F0
		public List<string> Sockets { get; set; }

		// Token: 0x0602A486 RID: 173190 RVA: 0x005D40F9 File Offset: 0x005D22F9
		public IActorFxEmoteStopSocketsT()
		{
			this.Type = EActorFxEmoteStopSubType.StopAll;
			this.Sockets = null;
		}
	}
}
