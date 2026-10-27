using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02004672 RID: 18034
	[NullableContext(1)]
	[Nullable(0)]
	public class InputActionHandle : InputDistributeHandle<InputDistributeDefine.EActionType>
	{
		// Token: 0x0602E896 RID: 190614 RVA: 0x00AC6441 File Offset: 0x00AC4641
		public InputActionHandle(string inputDistributeTag, string name) : base(inputDistributeTag, name)
		{
		}

		// Token: 0x0602E897 RID: 190615 RVA: 0x00AC644B File Offset: 0x00AC464B
		public void SetIsPress(bool value)
		{
			this.IsPress = value;
		}

		// Token: 0x0602E898 RID: 190616 RVA: 0x00AC6454 File Offset: 0x00AC4654
		public bool GetIsPress()
		{
			return this.IsPress;
		}

		// Token: 0x0602E899 RID: 190617 RVA: 0x00AC645C File Offset: 0x00AC465C
		public void BindAction(TInputHandle<InputDistributeDefine.EActionType> actionCallback)
		{
			base.Bind(actionCallback);
		}

		// Token: 0x0602E89A RID: 190618 RVA: 0x00AC6465 File Offset: 0x00AC4665
		public void UnBindAction(TInputHandle<InputDistributeDefine.EActionType> actionCallback)
		{
			base.UnBind(actionCallback);
		}

		// Token: 0x0602E89B RID: 190619 RVA: 0x00AC646E File Offset: 0x00AC466E
		public void BindActionIgnoreLimit(TInputHandle<InputDistributeDefine.EActionType> actionCallback)
		{
			base.BindIgnoreLimit(actionCallback);
		}

		// Token: 0x0602E89C RID: 190620 RVA: 0x00AC6477 File Offset: 0x00AC4677
		public void UnBindActionIgnoreLimit(TInputHandle<InputDistributeDefine.EActionType> actionCallback)
		{
			base.UnBindIgnoreLimit(actionCallback);
		}

		// Token: 0x0602E89D RID: 190621 RVA: 0x00AC6480 File Offset: 0x00AC4680
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

		// Token: 0x0602E89E RID: 190622 RVA: 0x00AC649C File Offset: 0x00AC469C
		public void InputActionIgnoreLimit(bool bPress)
		{
			if (bPress)
			{
				base.CallIgnoreLimit(InputDistributeDefine.EActionType.Press);
				return;
			}
			base.CallIgnoreLimit(InputDistributeDefine.EActionType.Release);
		}

		// Token: 0x0602E89F RID: 190623 RVA: 0x00AC64B0 File Offset: 0x00AC46B0
		public void TryReleaseActionIfLimitInputDistributeTag()
		{
			if (!this.IsPressTriggerAction)
			{
				return;
			}
			this.InputAction(false);
		}

		// Token: 0x04019514 RID: 103700
		private bool IsPress;

		// Token: 0x04019515 RID: 103701
		private bool IsPressTriggerAction;
	}
}
