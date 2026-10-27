using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200082A RID: 2090
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelSequenceFrameEventComponent_SetValue
	{
		// Token: 0x04001E1E RID: 7710
		public bool? Disabled;

		// Token: 0x04001E1F RID: 7711
		public bool? EdIsLocked;

		// Token: 0x04001E20 RID: 7712
		public List<ILevelSequenceSectionInfo> ForwardSections;

		// Token: 0x04001E21 RID: 7713
		public List<ILevelSequenceSectionInfo> BackWardSections;
	}
}
