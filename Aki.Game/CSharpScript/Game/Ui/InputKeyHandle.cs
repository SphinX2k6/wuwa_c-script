using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020035C2 RID: 13762
	[NullableContext(1)]
	[Nullable(0)]
	public class InputKeyHandle : InputDistributeHandle<InputDistributeDefine.EActionType>
	{
		// Token: 0x060230FA RID: 143610 RVA: 0x009F8785 File Offset: 0x009F6985
		public InputKeyHandle(string inputDistributeTag, string name) : base(inputDistributeTag, name)
		{
		}

		// Token: 0x060230FB RID: 143611 RVA: 0x009F878F File Offset: 0x009F698F
		public void BindAction(TInputHandle<InputDistributeDefine.EActionType> actionCallback)
		{
			base.Bind(actionCallback);
		}

		// Token: 0x060230FC RID: 143612 RVA: 0x009F8798 File Offset: 0x009F6998
		public void UnBindAction(TInputHandle<InputDistributeDefine.EActionType> actionCallback)
		{
			base.UnBind(actionCallback);
		}

		// Token: 0x060230FD RID: 143613 RVA: 0x009F87A1 File Offset: 0x009F69A1
		public void InputKey(bool bPress)
		{
			if (bPress)
			{
				base.Call(InputDistributeDefine.EActionType.Press);
				return;
			}
			base.Call(InputDistributeDefine.EActionType.Release);
		}
	}
}
