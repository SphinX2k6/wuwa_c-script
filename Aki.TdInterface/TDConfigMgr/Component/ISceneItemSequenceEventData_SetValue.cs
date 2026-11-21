using System;
using System.Collections.Generic;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200074C RID: 1868
	public class ISceneItemSequenceEventData_SetValue
	{
		// Token: 0x04001B18 RID: 6936
		public string SeqGuid;

		// Token: 0x04001B19 RID: 6937
		public string SeqPath;

		// Token: 0x04001B1A RID: 6938
		public List<ISceneItemSeqEventCbType> EventCallbacks;
	}
}
