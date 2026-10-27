using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001865 RID: 6245
	[NullableContext(1)]
	[Nullable(0)]
	public class IChangeAnimalEmotionBubble_SetValue
	{
		// Token: 0x040054AD RID: 21677
		public EExecClientBattleActionType Type;

		// Token: 0x040054AE RID: 21678
		public List<int> AnimalEntityIds;

		// Token: 0x040054AF RID: 21679
		public string MontagePath;

		// Token: 0x040054B0 RID: 21680
		public string EmotionName;
	}
}
