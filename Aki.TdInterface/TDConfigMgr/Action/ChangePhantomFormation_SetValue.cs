using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020014E3 RID: 5347
	public class ChangePhantomFormation_SetValue
	{
		// Token: 0x04004696 RID: 18070
		public int FormationId;

		// Token: 0x04004697 RID: 18071
		public bool? RetainRole;

		// Token: 0x04004698 RID: 18072
		public int? TeleportEntityId;

		// Token: 0x04004699 RID: 18073
		[Nullable(2)]
		public List<long> AppendBuffIds;
	}
}
