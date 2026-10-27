using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002219 RID: 8729
	[NullableContext(1)]
	[Nullable(0)]
	public class StartFlowTemplate_SetValue
	{
		// Token: 0x04007244 RID: 29252
		public IFlowTemplateMode TemplateMode;

		// Token: 0x04007245 RID: 29253
		public PosA TargetPos;

		// Token: 0x04007246 RID: 29254
		public List<int> ActorIdArray;

		// Token: 0x04007247 RID: 29255
		[Nullable(2)]
		public List<int> TalkerIds;
	}
}
