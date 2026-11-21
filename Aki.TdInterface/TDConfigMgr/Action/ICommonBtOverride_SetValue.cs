using System;
using System.Collections.Generic;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A86 RID: 6790
	public class ICommonBtOverride_SetValue
	{
		// Token: 0x04005A42 RID: 23106
		public int CommonBtId;

		// Token: 0x04005A43 RID: 23107
		public List<ICommonBtPlaceholder> OverridePlaceholders;

		// Token: 0x04005A44 RID: 23108
		public List<ICommonBtClientOverrideData> ClientOverrideData;
	}
}
