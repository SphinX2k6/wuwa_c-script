using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001483 RID: 5251
	[NullableContext(2)]
	[Nullable(0)]
	public class ActionInfo_SetValue
	{
		// Token: 0x04004583 RID: 17795
		public EAction Name;

		// Token: 0x04004584 RID: 17796
		public bool? Async;

		// Token: 0x04004585 RID: 17797
		[Nullable(1)]
		public ActionParams Params;

		// Token: 0x04004586 RID: 17798
		public int? ActionId;

		// Token: 0x04004587 RID: 17799
		public bool? Disabled;

		// Token: 0x04004588 RID: 17800
		public string ActionGuid;

		// Token: 0x04004589 RID: 17801
		public float? Timeout;

		// Token: 0x0400458A RID: 17802
		public bool? EdLocalDisabled;

		// Token: 0x0400458B RID: 17803
		public string EdNote;
	}
}
