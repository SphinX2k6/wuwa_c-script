using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Personal;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.Common.InputView.View
{
	// Token: 0x02005B74 RID: 23412
	[NullableContext(1)]
	[Nullable(0)]
	public class CommonModifyNameInputView : CommonInputViewBase
	{
		// Token: 0x0603B3E7 RID: 242663 RVA: 0x00E1FEFB File Offset: 0x00E1E0FB
		public CommonModifyNameInputView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603B3E8 RID: 242664 RVA: 0x00E1FF04 File Offset: 0x00E1E104
		protected override void OnAddEventListener()
		{
			base.OnAddEventListener();
			EventSystem.Instance.Add(EEventName.OnModifyNameStateChange, new Action(this.OnModifyNameStateChange));
		}

		// Token: 0x0603B3E9 RID: 242665 RVA: 0x00E1FF28 File Offset: 0x00E1E128
		protected override void OnRemoveEventListener()
		{
			base.OnRemoveEventListener();
			EventSystem.Instance.Remove(EEventName.OnModifyNameStateChange, new Action(this.OnModifyNameStateChange));
		}

		// Token: 0x0603B3EA RID: 242666 RVA: 0x00E1FF4C File Offset: 0x00E1E14C
		protected override int GetMaxLimit()
		{
			return 12;
		}

		// Token: 0x0603B3EB RID: 242667 RVA: 0x00E1FF50 File Offset: 0x00E1E150
		protected override bool IsAllowMultiLine()
		{
			return false;
		}

		// Token: 0x0603B3EC RID: 242668 RVA: 0x00E1FF53 File Offset: 0x00E1E153
		protected override void InitExtraParam()
		{
			this.RefreshUi();
		}

		// Token: 0x0603B3ED RID: 242669 RVA: 0x00E1FF5B File Offset: 0x00E1E15B
		protected override void RefreshDuplicateName(string inputText)
		{
			this.RefreshUi();
		}

		// Token: 0x0603B3EE RID: 242670 RVA: 0x00E1FF64 File Offset: 0x00E1E164
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

		// Token: 0x0603B3EF RID: 242671 RVA: 0x00E2000B File Offset: 0x00E1E20B
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

		// Token: 0x0603B3F0 RID: 242672 RVA: 0x00E2004A File Offset: 0x00E1E24A
		private void OnModifyNameStateChange()
		{
			this.RefreshUi();
		}
	}
}
