using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018BF RID: 6335
	public class IClientGroupAiCommunicate_SetValue
	{
		// Token: 0x04005573 RID: 21875
		public EExecClientBattleActionType Type;

		// Token: 0x04005574 RID: 21876
		public int GroupEntityId;

		// Token: 0x04005575 RID: 21877
		[Nullable(1)]
		public IGroupAiCommunicateMode Option;
	}
}
