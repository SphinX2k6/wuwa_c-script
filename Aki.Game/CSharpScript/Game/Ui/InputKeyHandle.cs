using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02004691 RID: 18065
	[NullableContext(1)]
	[Nullable(0)]
	public class InputKeyHandle : InputDistributeHandle<InputDistributeDefine.EActionType>
	{
		// Token: 0x0602E9B0 RID: 190896 RVA: 0x00ACAA51 File Offset: 0x00AC8C51
		public InputKeyHandle(string inputDistributeTag, string name) : base(inputDistributeTag, name)
		{
		}

		// Token: 0x0602E9B1 RID: 190897 RVA: 0x00ACAA5B File Offset: 0x00AC8C5B
		public void BindAction(TInputHandle<InputDistributeDefine.EActionType> actionCallback)
		{
			base.Bind(actionCallback);
		}

		// Token: 0x0602E9B2 RID: 190898 RVA: 0x00ACAA64 File Offset: 0x00AC8C64
		public void UnBindAction(TInputHandle<InputDistributeDefine.EActionType> actionCallback)
		{
			base.UnBind(actionCallback);
		}

		// Token: 0x0602E9B3 RID: 190899 RVA: 0x00ACAA6D File Offset: 0x00AC8C6D
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
