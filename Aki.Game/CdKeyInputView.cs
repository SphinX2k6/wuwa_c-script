using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Common.InputView.Model;
using CSharpScript.Game.Module.Common.InputView.View;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;

// Token: 0x0200177F RID: 6015
[NullableContext(1)]
[Nullable(0)]
public class CdKeyInputView : CommonInputViewBase
{
	// Token: 0x0600AEE3 RID: 44771 RVA: 0x002782E5 File Offset: 0x002764E5
	public CdKeyInputView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600AEE4 RID: 44772 RVA: 0x002782F0 File Offset: 0x002764F0
	protected override void InitExtraParam()
	{
		IReadOnlyList<int> intArrayConfig = ConfigCommonParamById.GetIntArrayConfig("CdKeyLengthLimit");
		this.MinLimit = intArrayConfig[0];
		this.MaxLimit = intArrayConfig[1];
	}

	// Token: 0x0600AEE5 RID: 44773 RVA: 0x00278322 File Offset: 0x00276522
	protected override int GetMaxLimit()
	{
		return this.MaxLimit;
	}

	// Token: 0x0600AEE6 RID: 44774 RVA: 0x0027832A File Offset: 0x0027652A
	protected override int GetMinLimit()
	{
		return this.MinLimit;
	}

	// Token: 0x0600AEE7 RID: 44775 RVA: 0x00278332 File Offset: 0x00276532
	protected override bool IsAllowMultiLine()
	{
		return false;
	}

	// Token: 0x0600AEE8 RID: 44776 RVA: 0x00278335 File Offset: 0x00276535
	protected override void ExecuteInputConfirm(string inputText)
	{
		ICommonInputViewData inputData = this.InputData;
		if (((inputData != null) ? inputData.ConfirmFunc : null) != null)
		{
			this.InputData.ConfirmFunc(inputText).ContinueWith(delegate(Aki.Protocol.ErrorCode errorCode)
			{
				if (errorCode == Aki.Protocol.ErrorCode.Success)
				{
					ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.CdKeyVerifySuccess);
					ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
					base.CloseMe(null);
					return;
				}
				string textByErrorId = ErrorCodeConfig.Instance.GetTextByErrorId(errorCode);
				this.CdKeyErrorText = (textByErrorId ?? this.CdKeyErrorText);
				this.RefreshTips(ETipsType.InValidCdKey);
			});
		}
	}

	// Token: 0x0600AEE9 RID: 44777 RVA: 0x0027836E File Offset: 0x0027656E
	protected override bool ExtraConfirmCheck(int count, string text)
	{
		return !this.CheckTimeIntervalIllegal() && !this.CheckStringIllegal(text);
	}

	// Token: 0x0600AEEA RID: 44778 RVA: 0x00278386 File Offset: 0x00276586
	private bool CheckTimeIntervalIllegal()
	{
		bool flag = CdKeyInputController.Instance.CheckInCdKeyUseCd();
		if (flag)
		{
			this.RefreshTips(ETipsType.CdKeyInCd);
		}
		return flag;
	}

	// Token: 0x0600AEEB RID: 44779 RVA: 0x0027839C File Offset: 0x0027659C
	private bool CheckStringIllegal(string text)
	{
		bool flag = StringUtils.CheckIsOnlyLettersAndNumbers(text);
		if (!flag)
		{
			this.RefreshTips(ETipsType.IllegalCharacters);
		}
		return !flag;
	}

	// Token: 0x04004F63 RID: 20323
	private int MaxLimit;

	// Token: 0x04004F64 RID: 20324
	private int MinLimit;
}
