using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Common.InputView.View
{
	// Token: 0x02004B5E RID: 19294
	[NullableContext(1)]
	[Nullable(0)]
	public class VisionAssembleInputView : CommonInputViewBase
	{
		// Token: 0x06030382 RID: 197506 RVA: 0x00D70CEC File Offset: 0x00D6EEEC
		public VisionAssembleInputView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06030383 RID: 197507 RVA: 0x00D70CF5 File Offset: 0x00D6EEF5
		protected override void OnAddEventListener()
		{
			base.OnAddEventListener();
		}

		// Token: 0x06030384 RID: 197508 RVA: 0x00D70CFD File Offset: 0x00D6EEFD
		protected override void OnRemoveEventListener()
		{
			base.OnRemoveEventListener();
		}

		// Token: 0x06030385 RID: 197509 RVA: 0x00D70D05 File Offset: 0x00D6EF05
		protected override int GetMaxLimit()
		{
			return 20;
		}

		// Token: 0x06030386 RID: 197510 RVA: 0x00D70D09 File Offset: 0x00D6EF09
		protected override void InitExtraParam()
		{
			this.RefreshUi();
		}

		// Token: 0x06030387 RID: 197511 RVA: 0x00D70D11 File Offset: 0x00D6EF11
		protected override void RefreshDuplicateName(string inputText)
		{
			this.RefreshUi();
		}

		// Token: 0x06030388 RID: 197512 RVA: 0x00D70D19 File Offset: 0x00D6EF19
		protected override bool IsAllowMultiLine()
		{
			return false;
		}

		// Token: 0x06030389 RID: 197513 RVA: 0x00D70D1C File Offset: 0x00D6EF1C
		private void RefreshUi()
		{
			bool flag = this.InputText.Text != this.InputData.InputText;
			bool flag2 = StringUtils.GetStringRealCount(this.InputText.Text) > this.GetMaxLimit();
			this.ConfirmButton.SetSelfInteractive(flag && !flag2);
		}
	}
}
