using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200051B RID: 1307
	public class IMonsterSummonInteractPoint_SetValue
	{
		// Token: 0x0400132A RID: 4906
		public EExploreSkillInteractType Type;

		// Token: 0x0400132B RID: 4907
		public float Range;

		// Token: 0x0400132C RID: 4908
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> Actions;
	}
}
