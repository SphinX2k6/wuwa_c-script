using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020017D9 RID: 6105
	public class IAssistCharacterMoveToPoint_SetValue
	{
		// Token: 0x0400533E RID: 21310
		public EExecClientBattleActionType Type;

		// Token: 0x0400533F RID: 21311
		public int AssistCharacterId;

		// Token: 0x04005340 RID: 21312
		[Nullable(1)]
		public IAssistCharacterMoveType MoveType;
	}
}
