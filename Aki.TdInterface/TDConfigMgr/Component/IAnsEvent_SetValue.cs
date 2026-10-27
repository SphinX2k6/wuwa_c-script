using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020001CC RID: 460
	[NullableContext(1)]
	[Nullable(0)]
	public class IAnsEvent_SetValue
	{
		// Token: 0x0400089A RID: 2202
		public ESceneItemSeqEventCbType Type;

		// Token: 0x0400089B RID: 2203
		public string EventName;

		// Token: 0x0400089C RID: 2204
		public ActionInfo Action;

		// Token: 0x0400089D RID: 2205
		public float Duration;
	}
}
