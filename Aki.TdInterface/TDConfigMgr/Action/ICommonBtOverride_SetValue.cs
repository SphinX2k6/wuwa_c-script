using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018FF RID: 6399
	[NullableContext(1)]
	[Nullable(0)]
	public class ICommonBtOverride_SetValue
	{
		// Token: 0x040055F8 RID: 22008
		public int CommonBtId;

		// Token: 0x040055F9 RID: 22009
		public List<ICommonBtPlaceholder> OverridePlaceholders;

		// Token: 0x040055FA RID: 22010
		public List<ICommonBtClientOverrideData> ClientOverrideData;
	}
}
