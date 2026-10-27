using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Common.InputView.View
{
	// Token: 0x02005B78 RID: 23416
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomManageConfigRenameInputView : CommonInputViewBase
	{
		// Token: 0x0603B3FE RID: 242686 RVA: 0x00E20117 File Offset: 0x00E1E317
		public PhantomManageConfigRenameInputView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603B3FF RID: 242687 RVA: 0x00E20120 File Offset: 0x00E1E320
		protected override int GetMaxLimit()
		{
			return ConfigCommonParamById.GetIntConfig("PhantomSettingNameLength").GetValueOrDefault(20);
		}

		// Token: 0x0603B400 RID: 242688 RVA: 0x00E20141 File Offset: 0x00E1E341
		protected override void InitExtraParam()
		{
			this.RefreshUi();
		}

		// Token: 0x0603B401 RID: 242689 RVA: 0x00E20149 File Offset: 0x00E1E349
		protected override void RefreshDuplicateName(string inputText)
		{
			this.RefreshUi();
		}

		// Token: 0x0603B402 RID: 242690 RVA: 0x00E20151 File Offset: 0x00E1E351
		protected override bool IsAllowMultiLine()
		{
			return false;
		}

		// Token: 0x0603B403 RID: 242691 RVA: 0x00E20154 File Offset: 0x00E1E354
		private void RefreshUi()
		{
			bool flag = this.InputText.Text != this.InputData.InputText;
			bool flag2 = StringUtils.GetStringRealCount(this.InputText.Text) > this.GetMaxLimit();
			this.ConfirmButton.SetSelfInteractive(flag && !flag2);
		}
	}
}
