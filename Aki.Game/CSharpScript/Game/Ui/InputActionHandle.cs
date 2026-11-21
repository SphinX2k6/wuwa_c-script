using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020035A3 RID: 13731
	[NullableContext(1)]
	[Nullable(0)]
	public class InputActionHandle : InputDistributeHandle<InputDistributeDefine.EActionType>
	{
		// Token: 0x06022FE0 RID: 143328 RVA: 0x009F3FA1 File Offset: 0x009F21A1
		public InputActionHandle(string inputDistributeTag, string name) : base(inputDistributeTag, name)
		{
		}

		// Token: 0x06022FE1 RID: 143329 RVA: 0x009F3FAB File Offset: 0x009F21AB
		public void SetIsPress(bool value)
		{
			this.IsPress = value;
		}

		// Token: 0x06022FE2 RID: 143330 RVA: 0x009F3FB4 File Offset: 0x009F21B4
		public bool GetIsPress()
		{
			return this.IsPress;
		}

		// Token: 0x06022FE3 RID: 143331 RVA: 0x009F3FBC File Offset: 0x009F21BC
		public void BindAction(TInputHandle<InputDistributeDefine.EActionType> actionCallback)
		{
			base.Bind(actionCallback);
		}

		// Token: 0x06022FE4 RID: 143332 RVA: 0x009F3FC5 File Offset: 0x009F21C5
		public void UnBindAction(TInputHandle<InputDistributeDefine.EActionType> actionCallback)
		{
			base.UnBind(actionCallback);
		}

		// Token: 0x06022FE5 RID: 143333 RVA: 0x009F3FCE File Offset: 0x009F21CE
		public void BindActionIgnoreLimit(TInputHandle<InputDistributeDefine.EActionType> actionCallback)
		{
			base.BindIgnoreLimit(actionCallback);
		}

		// Token: 0x06022FE6 RID: 143334 RVA: 0x009F3FD7 File Offset: 0x009F21D7
		public void UnBindActionIgnoreLimit(TInputHandle<InputDistributeDefine.EActionType> actionCallback)
		{
			base.UnBindIgnoreLimit(actionCallback);
		}

		// Token: 0x06022FE7 RID: 143335 RVA: 0x009F3FE0 File Offset: 0x009F21E0
		public void InputAction(bool bPress)
		{
			if (bPress)
			{
				base.Call(InputDistributeDefine.EActionType.Press);
			}
			else
			{
				base.Call(InputDistributeDefine.EActionType.Release);
			}
			this.IsPressTriggerAction = bPress;
		}

		// Token: 0x06022FE8 RID: 143336 RVA: 0x009F3FFC File Offset: 0x009F21FC
		public void InputActionIgnoreLimit(bool bPress)
		{
			if (bPress)
			{
				base.CallIgnoreLimit(InputDistributeDefine.EActionType.Press);
				return;
			}
			base.CallIgnoreLimit(InputDistributeDefine.EActionType.Release);
		}

		// Token: 0x06022FE9 RID: 143337 RVA: 0x009F4010 File Offset: 0x009F2210
		public void TryReleaseActionIfLimitInputDistributeTag()
		{
			if (!this.IsPressTriggerAction)
			{
				return;
			}
			this.InputAction(false);
		}

		// Token: 0x04013BBB RID: 80827
		private bool IsPress;

		// Token: 0x04013BBC RID: 80828
		private bool IsPressTriggerAction;
	}
}
