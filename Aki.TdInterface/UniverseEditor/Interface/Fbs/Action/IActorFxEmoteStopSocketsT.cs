using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200671C RID: 26396
	public class IActorFxEmoteStopSocketsT
	{
		// Token: 0x1700BFEC RID: 49132
		// (get) Token: 0x0602CB63 RID: 183139 RVA: 0x0061E07F File Offset: 0x0061C27F
		// (set) Token: 0x0602CB64 RID: 183140 RVA: 0x0061E087 File Offset: 0x0061C287
		public EActorFxEmoteStopSubType Type { get; set; }

		// Token: 0x1700BFED RID: 49133
		// (get) Token: 0x0602CB65 RID: 183141 RVA: 0x0061E090 File Offset: 0x0061C290
		// (set) Token: 0x0602CB66 RID: 183142 RVA: 0x0061E098 File Offset: 0x0061C298
		public List<string> Sockets { get; set; }

		// Token: 0x0602CB67 RID: 183143 RVA: 0x0061E0A1 File Offset: 0x0061C2A1
		public IActorFxEmoteStopSocketsT()
		{
			this.Type = EActorFxEmoteStopSubType.StopAll;
			this.Sockets = null;
		}
	}
}
