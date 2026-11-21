using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.QuickTimeAction.Condition
{
	// Token: 0x02003F16 RID: 16150
	[NullableContext(1)]
	[Nullable(0)]
	public class InputListenerHandle
	{
		// Token: 0x06028F5A RID: 167770 RVA: 0x00B7EAC6 File Offset: 0x00B7CCC6
		public InputListenerHandle(string actionName, TInputHandle<InputDistributeDefine.EActionType> callback)
		{
			this.ActionName = actionName;
			this.Callback = callback;
		}

		// Token: 0x0401643A RID: 91194
		public string ActionName;

		// Token: 0x0401643B RID: 91195
		public TInputHandle<InputDistributeDefine.EActionType> Callback;
	}
}
