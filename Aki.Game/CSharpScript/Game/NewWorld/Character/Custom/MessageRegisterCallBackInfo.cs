using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.Character.Custom
{
	// Token: 0x020070A7 RID: 28839
	[NullableContext(1)]
	[Nullable(0)]
	internal class MessageRegisterCallBackInfo
	{
		// Token: 0x06046436 RID: 287798 RVA: 0x01195650 File Offset: 0x01193850
		public MessageRegisterCallBackInfo()
		{
			this.EnterCallbacks = new List<TMessageRegisterCallback>();
			this.LeaveCallback = new List<TMessageRegisterCallback>();
			this.InitCallback = new List<TMessageRegisterCallback>();
		}

		// Token: 0x04024D19 RID: 150809
		public List<TMessageRegisterCallback> EnterCallbacks;

		// Token: 0x04024D1A RID: 150810
		public List<TMessageRegisterCallback> LeaveCallback;

		// Token: 0x04024D1B RID: 150811
		public List<TMessageRegisterCallback> InitCallback;
	}
}
