using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A80 RID: 6784
	[NullableContext(2)]
	[Nullable(0)]
	public class IFlowActorUnit_SetValue
	{
		// Token: 0x0400599F RID: 22943
		public int EntityId;

		// Token: 0x040059A0 RID: 22944
		public int TalkerId;

		// Token: 0x040059A1 RID: 22945
		public bool IsPlayer;

		// Token: 0x040059A2 RID: 22946
		public bool IsResetPosition;

		// Token: 0x040059A3 RID: 22947
		public string SeqFacePath;

		// Token: 0x040059A4 RID: 22948
		public IActorInitialState InitialState;

		// Token: 0x040059A5 RID: 22949
		public string EdTrialCharacterTemplate;
	}
}
