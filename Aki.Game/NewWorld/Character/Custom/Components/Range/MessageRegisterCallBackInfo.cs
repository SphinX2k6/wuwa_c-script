using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.Game.NewWorld.Character.Custom.Components.Range
{
	// Token: 0x02002F70 RID: 12144
	[NullableContext(1)]
	[Nullable(0)]
	internal class MessageRegisterCallBackInfo
	{
		// Token: 0x0601CC27 RID: 117799 RVA: 0x008C72EF File Offset: 0x008C54EF
		public MessageRegisterCallBackInfo()
		{
			this.EnterCallbacks = new List<MessageRegisterCallback>();
			this.LeaveCallback = new List<MessageRegisterCallback>();
			this.InitCallback = new List<MessageRegisterCallback>();
		}

		// Token: 0x0400F25D RID: 62045
		public List<MessageRegisterCallback> EnterCallbacks;

		// Token: 0x0400F25E RID: 62046
		public List<MessageRegisterCallback> LeaveCallback;

		// Token: 0x0400F25F RID: 62047
		public List<MessageRegisterCallback> InitCallback;
	}
}
