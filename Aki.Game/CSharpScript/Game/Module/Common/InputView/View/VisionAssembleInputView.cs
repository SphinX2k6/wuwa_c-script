using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Common.InputView.View
{
	// Token: 0x02005B7E RID: 23422
	[NullableContext(1)]
	[Nullable(0)]
	public class VisionAssembleInputView : CommonInputViewBase
	{
		// Token: 0x0603B435 RID: 242741 RVA: 0x00E20778 File Offset: 0x00E1E978
		public VisionAssembleInputView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603B436 RID: 242742 RVA: 0x00E20781 File Offset: 0x00E1E981
		protected override void OnAddEventListener()
		{
			base.OnAddEventListener();
		}

		// Token: 0x0603B437 RID: 242743 RVA: 0x00E20789 File Offset: 0x00E1E989
		protected override void OnRemoveEventListener()
		{
			base.OnRemoveEventListener();
		}

		// Token: 0x0603B438 RID: 242744 RVA: 0x00E20791 File Offset: 0x00E1E991
		protected override int GetMaxLimit()
		{
			return 20;
		}

		// Token: 0x0603B439 RID: 242745 RVA: 0x00E20795 File Offset: 0x00E1E995
		protected override void InitExtraParam()
		{
			this.RefreshUi();
		}

		// Token: 0x0603B43A RID: 242746 RVA: 0x00E2079D File Offset: 0x00E1E99D
		protected override void RefreshDuplicateName(string inputText)
		{
			this.RefreshUi();
		}

		// Token: 0x0603B43B RID: 242747 RVA: 0x00E207A5 File Offset: 0x00E1E9A5
		protected override bool IsAllowMultiLine()
		{
			return false;
		}

		// Token: 0x0603B43C RID: 242748 RVA: 0x00E207A8 File Offset: 0x00E1E9A8
		private void RefreshUi()
		{
			bool flag = this.InputText.Text != this.InputData.InputText;
			bool flag2 = StringUtils.GetStringRealCount(this.InputText.Text) > this.GetMaxLimit();
			this.ConfirmButton.SetSelfInteractive(flag && !flag2);
		}
	}
}
