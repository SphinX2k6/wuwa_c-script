using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Common.InputView.View
{
	// Token: 0x02004B57 RID: 19287
	[NullableContext(1)]
	[Nullable(0)]
	public class DeckRenameInputView : CommonInputViewBase
	{
		// Token: 0x06030344 RID: 197444 RVA: 0x00D705F4 File Offset: 0x00D6E7F4
		public DeckRenameInputView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06030345 RID: 197445 RVA: 0x00D705FD File Offset: 0x00D6E7FD
		protected override int GetMinLimit()
		{
			return ConfigCommonParamById.GetIntArrayConfig("GroupNameLimit")[0];
		}

		// Token: 0x06030346 RID: 197446 RVA: 0x00D7060F File Offset: 0x00D6E80F
		protected override int GetMaxLimit()
		{
			return ConfigCommonParamById.GetIntArrayConfig("GroupNameLimit")[1];
		}

		// Token: 0x06030347 RID: 197447 RVA: 0x00D70621 File Offset: 0x00D6E821
		protected override void InitExtraParam()
		{
			this.RefreshUi();
		}

		// Token: 0x06030348 RID: 197448 RVA: 0x00D70629 File Offset: 0x00D6E829
		protected override void RefreshDuplicateName(string inputText)
		{
			this.RefreshUi();
		}

		// Token: 0x06030349 RID: 197449 RVA: 0x00D70631 File Offset: 0x00D6E831
		protected override bool IsAllowMultiLine()
		{
			return false;
		}

		// Token: 0x0603034A RID: 197450 RVA: 0x00D70634 File Offset: 0x00D6E834
		private void RefreshUi()
		{
			bool flag = this.InputText.Text != this.InputData.InputText;
			bool flag2 = StringUtils.GetStringRealCount(this.InputText.Text) > this.GetMaxLimit();
			this.ConfirmButton.SetSelfInteractive(flag && !flag2);
		}
	}
}
