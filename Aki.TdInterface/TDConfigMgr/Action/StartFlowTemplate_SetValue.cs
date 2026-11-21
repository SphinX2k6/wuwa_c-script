using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002484 RID: 9348
	public class StartFlowTemplate_SetValue
	{
		// Token: 0x0400788E RID: 30862
		public IFlowTemplateMode TemplateMode;

		// Token: 0x0400788F RID: 30863
		public PosA TargetPos;

		// Token: 0x04007890 RID: 30864
		public List<int> ActorIdArray;

		// Token: 0x04007891 RID: 30865
		[Nullable(2)]
		public List<int> TalkerIds;
	}
}
