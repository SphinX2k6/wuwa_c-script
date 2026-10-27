using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001921 RID: 6433
	public class ICommonTipMissionCompleteNew_SetValue
	{
		// Token: 0x04005650 RID: 22096
		public ECommonTipType Type;

		// Token: 0x04005651 RID: 22097
		public EQuestCommonTipType QuestType;

		// Token: 0x04005652 RID: 22098
		[Nullable(1)]
		public string TipTextKey;
	}
}
