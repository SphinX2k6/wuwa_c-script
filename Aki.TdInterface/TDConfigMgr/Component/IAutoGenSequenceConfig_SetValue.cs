using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020001E2 RID: 482
	public class IAutoGenSequenceConfig_SetValue
	{
		// Token: 0x040008C8 RID: 2248
		[Nullable(2)]
		public string SequencePath;

		// Token: 0x040008C9 RID: 2249
		[Nullable(1)]
		public PlayLevelSequence SequenceConfig;

		// Token: 0x040008CA RID: 2250
		public int Count;
	}
}
