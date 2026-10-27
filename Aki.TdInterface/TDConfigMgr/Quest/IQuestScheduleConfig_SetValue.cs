using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020010A0 RID: 4256
	[NullableContext(1)]
	[Nullable(0)]
	public class IQuestScheduleConfig_SetValue
	{
		// Token: 0x040039E8 RID: 14824
		public EQuestScheduleUiType UiType;

		// Token: 0x040039E9 RID: 14825
		public IQuestScheduleMainTitle MainTitle;

		// Token: 0x040039EA RID: 14826
		public List<IQuestScheduleSubTitle> SubTitles;

		// Token: 0x040039EB RID: 14827
		[Nullable(2)]
		public ITrackTarget TrackTarget;

		// Token: 0x040039EC RID: 14828
		[Nullable(2)]
		public ILevelPlayTrackRadius TrackRadius;
	}
}
