using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BB9 RID: 7097
	[NullableContext(1)]
	[Nullable(0)]
	public class ILoopSeasonChange_SetValue
	{
		// Token: 0x04005CBD RID: 23741
		public EClientSetSeasonStateType Type;

		// Token: 0x04005CBE RID: 23742
		public bool EnableLoop;

		// Token: 0x04005CBF RID: 23743
		public ISeasonLoopConfig SpringConfig;

		// Token: 0x04005CC0 RID: 23744
		public ISeasonLoopConfig SummerConfig;

		// Token: 0x04005CC1 RID: 23745
		public ISeasonLoopConfig AutumnConfig;

		// Token: 0x04005CC2 RID: 23746
		public ISeasonLoopConfig WinterConfig;
	}
}
