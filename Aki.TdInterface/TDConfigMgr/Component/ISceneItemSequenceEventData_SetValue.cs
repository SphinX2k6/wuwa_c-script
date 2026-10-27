using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006AB RID: 1707
	[NullableContext(1)]
	[Nullable(0)]
	public class ISceneItemSequenceEventData_SetValue
	{
		// Token: 0x0400191B RID: 6427
		public string SeqGuid;

		// Token: 0x0400191C RID: 6428
		public string SeqPath;

		// Token: 0x0400191D RID: 6429
		public List<ISceneItemSeqEventCbType> EventCallbacks;
	}
}
