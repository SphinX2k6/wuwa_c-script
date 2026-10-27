using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008C3 RID: 2243
	public class TimelineTrackControlComponent_SetValue
	{
		// Token: 0x04002123 RID: 8483
		public bool? Disabled;

		// Token: 0x04002124 RID: 8484
		public bool? EdIsLocked;

		// Token: 0x04002125 RID: 8485
		[Nullable(1)]
		public List<ITimelineControlGroup> ControlGroups;
	}
}
