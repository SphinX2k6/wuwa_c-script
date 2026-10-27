using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002188 RID: 8584
	[NullableContext(1)]
	[Nullable(0)]
	public class SendClientEvent_SetValue
	{
		// Token: 0x040070A1 RID: 28833
		public string EventName;

		// Token: 0x040070A2 RID: 28834
		public IClientEventTarget Target;
	}
}
