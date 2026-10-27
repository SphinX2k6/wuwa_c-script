using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020014AC RID: 5292
	public class BeginFlowTemplate_SetValue
	{
		// Token: 0x04004607 RID: 17927
		public bool? _Folded;

		// Token: 0x04004608 RID: 17928
		[Nullable(1)]
		public List<IFlowActorUnit> Actors;

		// Token: 0x04004609 RID: 17929
		[Nullable(2)]
		public List<int> MontageIds;

		// Token: 0x0400460A RID: 17930
		public bool? UseFreeCamera;

		// Token: 0x0400460B RID: 17931
		public bool? IsSwitchMainRole;

		// Token: 0x0400460C RID: 17932
		public bool? IsUseSeqFace;
	}
}
