using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001743 RID: 5955
	[NullableContext(1)]
	[Nullable(0)]
	public class HideGroup_SetValue
	{
		// Token: 0x04005055 RID: 20565
		public string GroupKey;

		// Token: 0x04005056 RID: 20566
		public IHideGroupType HideConfig;

		// Token: 0x04005057 RID: 20567
		public bool? IsHidePasserByNpc;
	}
}
