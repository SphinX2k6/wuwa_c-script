using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.QuickTimeAction.Condition
{
	// Token: 0x02004F4D RID: 20301
	[NullableContext(1)]
	[Nullable(0)]
	public class InputListenerHandle
	{
		// Token: 0x060340EC RID: 213228 RVA: 0x00C35326 File Offset: 0x00C33526
		public InputListenerHandle(string actionName, TInputHandle<InputDistributeDefine.EActionType> callback)
		{
			this.ActionName = actionName;
			this.Callback = callback;
		}

		// Token: 0x0401BA65 RID: 113253
		public string ActionName;

		// Token: 0x0401BA66 RID: 113254
		public TInputHandle<InputDistributeDefine.EActionType> Callback;
	}
}
