using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200051E RID: 1310
	public class ILevelSequenceSectionInfo_SetValue
	{
		// Token: 0x0400137A RID: 4986
		public ELevelSequenceSectionType Type;

		// Token: 0x0400137B RID: 4987
		public string Key;

		// Token: 0x0400137C RID: 4988
		public int FrameId;

		// Token: 0x0400137D RID: 4989
		[Nullable(2)]
		public string State;

		// Token: 0x0400137E RID: 4990
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<string> LoopStates;

		// Token: 0x0400137F RID: 4991
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> ActionList;
	}
}
