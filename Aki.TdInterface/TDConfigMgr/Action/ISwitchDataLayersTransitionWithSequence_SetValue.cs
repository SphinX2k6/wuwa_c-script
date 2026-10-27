using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001EFE RID: 7934
	public class ISwitchDataLayersTransitionWithSequence_SetValue
	{
		// Token: 0x040064E4 RID: 25828
		public ESwitchDataLayersTransitionType Type;

		// Token: 0x040064E5 RID: 25829
		[Nullable(1)]
		public string SequencePath;

		// Token: 0x040064E6 RID: 25830
		[Nullable(2)]
		public string SeqMarkBeforeModifyMat;
	}
}
