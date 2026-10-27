using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BF7 RID: 7159
	public class IMonsterNpcInteract_SetValue
	{
		// Token: 0x04005D5B RID: 23899
		public EExecClientBattleActionType Type;

		// Token: 0x04005D5C RID: 23900
		public int MonsterNpcEntityId;

		// Token: 0x04005D5D RID: 23901
		[Nullable(1)]
		public IMonsterNpcInteractTriggerHook Config;
	}
}
