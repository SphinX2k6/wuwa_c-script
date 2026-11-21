using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020015DC RID: 5596
	public class ActionInfo_SetValue
	{
		// Token: 0x0400491E RID: 18718
		public EAction Name;

		// Token: 0x0400491F RID: 18719
		public bool? Async;

		// Token: 0x04004920 RID: 18720
		public ActionParams Params;

		// Token: 0x04004921 RID: 18721
		public int? ActionId;

		// Token: 0x04004922 RID: 18722
		public bool? Disabled;

		// Token: 0x04004923 RID: 18723
		[Nullable(2)]
		public string ActionGuid;

		// Token: 0x04004924 RID: 18724
		public float? Timeout;

		// Token: 0x04004925 RID: 18725
		public bool? EdLocalDisabled;

		// Token: 0x04004926 RID: 18726
		[Nullable(2)]
		public string EdNote;
	}
}
