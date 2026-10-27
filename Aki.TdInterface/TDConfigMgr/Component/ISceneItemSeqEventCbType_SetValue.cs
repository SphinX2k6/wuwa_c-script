using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006A9 RID: 1705
	[NullableContext(1)]
	[Nullable(0)]
	public class ISceneItemSeqEventCbType_SetValue
	{
		// Token: 0x04001916 RID: 6422
		public ESceneItemSeqEventCbType Type;

		// Token: 0x04001917 RID: 6423
		public string EventName;

		// Token: 0x04001918 RID: 6424
		public ActionInfo Action;
	}
}
