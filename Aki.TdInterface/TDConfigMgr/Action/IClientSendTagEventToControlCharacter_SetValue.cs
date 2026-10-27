using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018C7 RID: 6343
	public class IClientSendTagEventToControlCharacter_SetValue
	{
		// Token: 0x04005581 RID: 21889
		public EExecClientBattleActionType Type;

		// Token: 0x04005582 RID: 21890
		[Nullable(1)]
		public List<string> EventTags;
	}
}
