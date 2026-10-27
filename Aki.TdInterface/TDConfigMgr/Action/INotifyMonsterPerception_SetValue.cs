using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C63 RID: 7267
	[NullableContext(1)]
	[Nullable(0)]
	public class INotifyMonsterPerception_SetValue
	{
		// Token: 0x04005E97 RID: 24215
		public ESetBattleStateType Type;

		// Token: 0x04005E98 RID: 24216
		public List<int> EntityIds;

		// Token: 0x04005E99 RID: 24217
		public IBattleStatePerceptionBehaviorType PerceptionBehaviorOption;
	}
}
