using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020011CE RID: 4558
	public class IQuestScheduleConfig_SetValue
	{
		// Token: 0x04003D35 RID: 15669
		public EQuestScheduleUiType UiType;

		// Token: 0x04003D36 RID: 15670
		public IQuestScheduleMainTitle MainTitle;

		// Token: 0x04003D37 RID: 15671
		public List<IQuestScheduleSubTitle> SubTitles;

		// Token: 0x04003D38 RID: 15672
		[Nullable(2)]
		public ITrackTarget TrackTarget;

		// Token: 0x04003D39 RID: 15673
		[Nullable(2)]
		public ILevelPlayTrackRadius TrackRadius;
	}
}
