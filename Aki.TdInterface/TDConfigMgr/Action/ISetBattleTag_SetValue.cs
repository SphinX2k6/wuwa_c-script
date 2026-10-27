using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E13 RID: 7699
	public class ISetBattleTag_SetValue
	{
		// Token: 0x04006298 RID: 25240
		public ESetBattleStateType Type;

		// Token: 0x04006299 RID: 25241
		[Nullable(1)]
		public List<ISetEntityTag> SetTags;
	}
}
