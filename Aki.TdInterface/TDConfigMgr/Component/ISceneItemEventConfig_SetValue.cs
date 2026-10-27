using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006A3 RID: 1699
	public class ISceneItemEventConfig_SetValue
	{
		// Token: 0x04001900 RID: 6400
		[Nullable(1)]
		public string EntityStateTagName;

		// Token: 0x04001901 RID: 6401
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ISceneItemSequenceEventData> SequenceEvents;
	}
}
