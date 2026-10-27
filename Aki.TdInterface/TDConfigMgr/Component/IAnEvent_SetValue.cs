using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020001C0 RID: 448
	[NullableContext(1)]
	[Nullable(0)]
	public class IAnEvent_SetValue
	{
		// Token: 0x04000873 RID: 2163
		public ESceneItemSeqEventCbType Type;

		// Token: 0x04000874 RID: 2164
		public string EventName;

		// Token: 0x04000875 RID: 2165
		public ActionInfo Action;
	}
}
