using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200163C RID: 5692
	public class ChangePhantomFormation_SetValue
	{
		// Token: 0x04004A31 RID: 18993
		public int FormationId;

		// Token: 0x04004A32 RID: 18994
		public bool? RetainRole;

		// Token: 0x04004A33 RID: 18995
		public int? TeleportEntityId;

		// Token: 0x04004A34 RID: 18996
		[Nullable(2)]
		public List<long> AppendBuffIds;
	}
}
