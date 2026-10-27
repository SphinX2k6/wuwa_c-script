using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020003F5 RID: 1013
	public class IGroupAiMonsterEcology_SetValue
	{
		// Token: 0x04001009 RID: 4105
		public EGroupAiMode Type;

		// Token: 0x0400100A RID: 4106
		public int Leader;

		// Token: 0x0400100B RID: 4107
		[Nullable(1)]
		public List<IGroupAiMonsterMember> Members;
	}
}
