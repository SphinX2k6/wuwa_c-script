using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001999 RID: 6553
	public class IDetectBattleTag_SetValue
	{
		// Token: 0x04005756 RID: 22358
		public EDetectBattleConditionType Type;

		// Token: 0x04005757 RID: 22359
		public int EntityId;

		// Token: 0x04005758 RID: 22360
		[Nullable(1)]
		public IDetectBattleMonsterOnGround TagOption;

		// Token: 0x04005759 RID: 22361
		public float MaxWaitTime;
	}
}
