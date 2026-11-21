using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C15 RID: 7189
	[NullableContext(2)]
	[Nullable(0)]
	public class IFlowActorUnit_SetValue
	{
		// Token: 0x04005E04 RID: 24068
		public int EntityId;

		// Token: 0x04005E05 RID: 24069
		public int TalkerId;

		// Token: 0x04005E06 RID: 24070
		public bool IsPlayer;

		// Token: 0x04005E07 RID: 24071
		public bool IsResetPosition;

		// Token: 0x04005E08 RID: 24072
		public string SeqFacePath;

		// Token: 0x04005E09 RID: 24073
		public IActorInitialState InitialState;

		// Token: 0x04005E0A RID: 24074
		public string EdTrialCharacterTemplate;
	}
}
