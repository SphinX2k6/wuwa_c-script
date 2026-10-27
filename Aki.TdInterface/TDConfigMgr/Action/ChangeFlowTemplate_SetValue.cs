using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020014D5 RID: 5333
	[NullableContext(2)]
	[Nullable(0)]
	public class ChangeFlowTemplate_SetValue
	{
		// Token: 0x04004675 RID: 18037
		[Nullable(1)]
		public IFlowTemplateMode TemplateMode;

		// Token: 0x04004676 RID: 18038
		public PosA TargetPos;

		// Token: 0x04004677 RID: 18039
		public List<int> ActorIdArray;

		// Token: 0x04004678 RID: 18040
		public List<int> TalkerIds;
	}
}
