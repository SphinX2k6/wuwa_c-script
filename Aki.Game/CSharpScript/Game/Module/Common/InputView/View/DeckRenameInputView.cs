using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Common.InputView.View
{
	// Token: 0x02005B77 RID: 23415
	[NullableContext(1)]
	[Nullable(0)]
	public class DeckRenameInputView : CommonInputViewBase
	{
		// Token: 0x0603B3F7 RID: 242679 RVA: 0x00E20080 File Offset: 0x00E1E280
		public DeckRenameInputView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603B3F8 RID: 242680 RVA: 0x00E20089 File Offset: 0x00E1E289
		protected override int GetMinLimit()
		{
			return ConfigCommonParamById.GetIntArrayConfig("GroupNameLimit")[0];
		}

		// Token: 0x0603B3F9 RID: 242681 RVA: 0x00E2009B File Offset: 0x00E1E29B
		protected override int GetMaxLimit()
		{
			return ConfigCommonParamById.GetIntArrayConfig("GroupNameLimit")[1];
		}

		// Token: 0x0603B3FA RID: 242682 RVA: 0x00E200AD File Offset: 0x00E1E2AD
		protected override void InitExtraParam()
		{
			this.RefreshUi();
		}

		// Token: 0x0603B3FB RID: 242683 RVA: 0x00E200B5 File Offset: 0x00E1E2B5
		protected override void RefreshDuplicateName(string inputText)
		{
			this.RefreshUi();
		}

		// Token: 0x0603B3FC RID: 242684 RVA: 0x00E200BD File Offset: 0x00E1E2BD
		protected override bool IsAllowMultiLine()
		{
			return false;
		}

		// Token: 0x0603B3FD RID: 242685 RVA: 0x00E200C0 File Offset: 0x00E1E2C0
		private void RefreshUi()
		{
			bool flag = this.InputText.Text != this.InputData.InputText;
			bool flag2 = StringUtils.GetStringRealCount(this.InputText.Text) > this.GetMaxLimit();
			this.ConfirmButton.SetSelfInteractive(flag && !flag2);
		}
	}
}
