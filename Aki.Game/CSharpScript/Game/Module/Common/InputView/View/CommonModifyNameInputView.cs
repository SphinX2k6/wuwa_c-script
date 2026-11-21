using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Personal;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.Common.InputView.View
{
	// Token: 0x02004B54 RID: 19284
	[NullableContext(1)]
	[Nullable(0)]
	public class CommonModifyNameInputView : CommonInputViewBase
	{
		// Token: 0x06030334 RID: 197428 RVA: 0x00D7046F File Offset: 0x00D6E66F
		public CommonModifyNameInputView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06030335 RID: 197429 RVA: 0x00D70478 File Offset: 0x00D6E678
		protected override void OnAddEventListener()
		{
			base.OnAddEventListener();
			EventSystem.Instance.Add(EEventName.OnModifyNameStateChange, new Action(this.OnModifyNameStateChange));
		}

		// Token: 0x06030336 RID: 197430 RVA: 0x00D7049C File Offset: 0x00D6E69C
		protected override void OnRemoveEventListener()
		{
			base.OnRemoveEventListener();
			EventSystem.Instance.Remove(EEventName.OnModifyNameStateChange, new Action(this.OnModifyNameStateChange));
		}

		// Token: 0x06030337 RID: 197431 RVA: 0x00D704C0 File Offset: 0x00D6E6C0
		protected override int GetMaxLimit()
		{
			return 12;
		}

		// Token: 0x06030338 RID: 197432 RVA: 0x00D704C4 File Offset: 0x00D6E6C4
		protected override bool IsAllowMultiLine()
		{
			return false;
		}

		// Token: 0x06030339 RID: 197433 RVA: 0x00D704C7 File Offset: 0x00D6E6C7
		protected override void InitExtraParam()
		{
			this.RefreshUi();
		}

		// Token: 0x0603033A RID: 197434 RVA: 0x00D704CF File Offset: 0x00D6E6CF
		protected override void RefreshDuplicateName(string inputText)
		{
			this.RefreshUi();
		}

		// Token: 0x0603033B RID: 197435 RVA: 0x00D704D8 File Offset: 0x00D6E6D8
		private void RefreshUi()
		{
			EModifyNameState personalModifyNameState = PersonalModel.Instance.GetPersonalModifyNameState();
			base.SetBottomTipsShowState(true);
			if (personalModifyNameState == EModifyNameState.CanBeModified || personalModifyNameState == EModifyNameState.UnModifiable)
			{
				base.SetBottomTipsTextAndColor("PersonalProfile_ChangeNameLimit", FColor.FromHex("6E6A62FF"));
			}
			else if (personalModifyNameState == EModifyNameState.UnderModification)
			{
				base.SetBottomTipsTextAndColor("PersonalProfile_ChangeNameProcess", FColor.FromHex("C25757FF"));
			}
			bool flag = personalModifyNameState == EModifyNameState.CanBeModified;
			bool flag2 = this.InputText.Text != this.InputData.InputText;
			bool flag3 = StringUtils.GetStringRealCount(this.InputText.Text) > this.GetMaxLimit();
			this.ConfirmButton.SetSelfInteractive(flag && flag2 && !flag3);
		}

		// Token: 0x0603033C RID: 197436 RVA: 0x00D7057F File Offset: 0x00D6E77F
		protected override void ExecuteInputConfirm(string inputText)
		{
			CommonModifyNameInputView.<>c__DisplayClass8_0 CS$<>8__locals1 = new CommonModifyNameInputView.<>c__DisplayClass8_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.inputText = inputText;
			CS$<>8__locals1.<ExecuteInputConfirm>g__Temp|0().Forget(delegate(Exception exception)
			{
				Log.Instance.Error(ELogModule.UiCommon, ELogAuthor.XXJ, "通用输入框执行出现未知错误", default(ReadOnlySpan<ValueTuple<string, object>>));
			}, true);
		}

		// Token: 0x0603033D RID: 197437 RVA: 0x00D705BE File Offset: 0x00D6E7BE
		private void OnModifyNameStateChange()
		{
			this.RefreshUi();
		}
	}
}
