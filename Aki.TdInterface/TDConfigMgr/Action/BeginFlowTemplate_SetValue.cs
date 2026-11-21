using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001605 RID: 5637
	public class BeginFlowTemplate_SetValue
	{
		// Token: 0x040049A2 RID: 18850
		public bool? _Folded;

		// Token: 0x040049A3 RID: 18851
		public List<IFlowActorUnit> Actors;

		// Token: 0x040049A4 RID: 18852
		[Nullable(2)]
		public List<int> MontageIds;

		// Token: 0x040049A5 RID: 18853
		public bool? UseFreeCamera;

		// Token: 0x040049A6 RID: 18854
		public bool? IsSwitchMainRole;

		// Token: 0x040049A7 RID: 18855
		public bool? IsUseSeqFace;
	}
}
