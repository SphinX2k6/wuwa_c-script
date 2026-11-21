using System;
using System.Collections.Generic;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E5C RID: 7772
	public class INotifyMonsterPerception_SetValue
	{
		// Token: 0x040063D1 RID: 25553
		public ESetBattleStateType Type;

		// Token: 0x040063D2 RID: 25554
		public List<int> EntityIds;

		// Token: 0x040063D3 RID: 25555
		public IBattleStatePerceptionBehaviorType PerceptionBehaviorOption;
	}
}
