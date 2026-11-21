using System;
using System.Collections.Generic;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008CD RID: 2253
	public class LevelSequenceFrameEventComponent_SetValue
	{
		// Token: 0x0400202A RID: 8234
		public bool? Disabled;

		// Token: 0x0400202B RID: 8235
		public bool? EdIsLocked;

		// Token: 0x0400202C RID: 8236
		public List<ILevelSequenceSectionInfo> ForwardSections;

		// Token: 0x0400202D RID: 8237
		public List<ILevelSequenceSectionInfo> BackWardSections;
	}
}
