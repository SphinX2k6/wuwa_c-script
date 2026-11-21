using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Common.InputView.View
{
	// Token: 0x02004B58 RID: 19288
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomManageConfigRenameInputView : CommonInputViewBase
	{
		// Token: 0x0603034B RID: 197451 RVA: 0x00D7068B File Offset: 0x00D6E88B
		public PhantomManageConfigRenameInputView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603034C RID: 197452 RVA: 0x00D70694 File Offset: 0x00D6E894
		protected override int GetMaxLimit()
		{
			return ConfigCommonParamById.GetIntConfig("PhantomSettingNameLength").GetValueOrDefault(20);
		}

		// Token: 0x0603034D RID: 197453 RVA: 0x00D706B5 File Offset: 0x00D6E8B5
		protected override void InitExtraParam()
		{
			this.RefreshUi();
		}

		// Token: 0x0603034E RID: 197454 RVA: 0x00D706BD File Offset: 0x00D6E8BD
		protected override void RefreshDuplicateName(string inputText)
		{
			this.RefreshUi();
		}

		// Token: 0x0603034F RID: 197455 RVA: 0x00D706C5 File Offset: 0x00D6E8C5
		protected override bool IsAllowMultiLine()
		{
			return false;
		}

		// Token: 0x06030350 RID: 197456 RVA: 0x00D706C8 File Offset: 0x00D6E8C8
		private void RefreshUi()
		{
			bool flag = this.InputText.Text != this.InputData.InputText;
			bool flag2 = StringUtils.GetStringRealCount(this.InputText.Text) > this.GetMaxLimit();
			this.ConfirmButton.SetSelfInteractive(flag && !flag2);
		}
	}
}
