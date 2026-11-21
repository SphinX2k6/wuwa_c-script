using System;
using System.Collections.Generic;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CB7 RID: 7351
	public class IHideSpecifyEntityGroup_SetValue
	{
		// Token: 0x04005F83 RID: 24451
		public EHideType Type;

		// Token: 0x04005F84 RID: 24452
		public List<int> EntityIds;

		// Token: 0x04005F85 RID: 24453
		public bool? ForceClean;
	}
}
