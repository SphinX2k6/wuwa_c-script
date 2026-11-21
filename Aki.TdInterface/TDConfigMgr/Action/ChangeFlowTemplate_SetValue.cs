using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200162E RID: 5678
	[NullableContext(2)]
	[Nullable(0)]
	public class ChangeFlowTemplate_SetValue
	{
		// Token: 0x04004A10 RID: 18960
		[Nullable(0)]
		public IFlowTemplateMode TemplateMode;

		// Token: 0x04004A11 RID: 18961
		public PosA TargetPos;

		// Token: 0x04004A12 RID: 18962
		public List<int> ActorIdArray;

		// Token: 0x04004A13 RID: 18963
		public List<int> TalkerIds;
	}
}
