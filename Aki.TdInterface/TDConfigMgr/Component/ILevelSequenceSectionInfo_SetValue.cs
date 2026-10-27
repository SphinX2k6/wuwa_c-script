using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004C5 RID: 1221
	public class ILevelSequenceSectionInfo_SetValue
	{
		// Token: 0x04001258 RID: 4696
		public ELevelSequenceSectionType Type;

		// Token: 0x04001259 RID: 4697
		[Nullable(1)]
		public string Key;

		// Token: 0x0400125A RID: 4698
		public int FrameId;

		// Token: 0x0400125B RID: 4699
		[Nullable(2)]
		public string State;

		// Token: 0x0400125C RID: 4700
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<string> LoopStates;

		// Token: 0x0400125D RID: 4701
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> ActionList;
	}
}
