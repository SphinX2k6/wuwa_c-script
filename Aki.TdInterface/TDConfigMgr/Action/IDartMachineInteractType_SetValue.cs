using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200196D RID: 6509
	public class IDartMachineInteractType_SetValue
	{
		// Token: 0x040056FB RID: 22267
		public EDartInteractType Type;

		// Token: 0x040056FC RID: 22268
		[Nullable(1)]
		public List<int> CanInviteCompetitorIds;

		// Token: 0x040056FD RID: 22269
		public int? ChampionId;
	}
}
