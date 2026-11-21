using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Common.InputView.Model;
using CSharpScript.Game.Module.Common.InputView.View;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;

// Token: 0x02000C38 RID: 3128
[NullableContext(1)]
[Nullable(0)]
public class CdKeyInputView : CommonInputViewBase
{
	// Token: 0x060082CA RID: 33482 RVA: 0x002827A9 File Offset: 0x002809A9
	public CdKeyInputView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060082CB RID: 33483 RVA: 0x002827B4 File Offset: 0x002809B4
	protected override void InitExtraParam()
	{
		IReadOnlyList<int> intArrayConfig = ConfigCommonParamById.GetIntArrayConfig("CdKeyLengthLimit");
		this.MinLimit = intArrayConfig[0];
		this.MaxLimit = intArrayConfig[1];
	}

	// Token: 0x060082CC RID: 33484 RVA: 0x002827E6 File Offset: 0x002809E6
	protected override int GetMaxLimit()
	{
		return this.MaxLimit;
	}

	// Token: 0x060082CD RID: 33485 RVA: 0x002827EE File Offset: 0x002809EE
	protected override int GetMinLimit()
	{
		return this.MinLimit;
	}

	// Token: 0x060082CE RID: 33486 RVA: 0x002827F6 File Offset: 0x002809F6
	protected override bool IsAllowMultiLine()
	{
		return false;
	}

	// Token: 0x060082CF RID: 33487 RVA: 0x002827F9 File Offset: 0x002809F9
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

	// Token: 0x060082D0 RID: 33488 RVA: 0x00282832 File Offset: 0x00280A32
	protected override bool ExtraConfirmCheck(int count, string text)
	{
		return !this.CheckTimeIntervalIllegal() && !this.CheckStringIllegal(text);
	}

	// Token: 0x060082D1 RID: 33489 RVA: 0x0028284A File Offset: 0x00280A4A
	private bool CheckTimeIntervalIllegal()
	{
		bool flag = CdKeyInputController.Instance.CheckInCdKeyUseCd();
		if (flag)
		{
			this.RefreshTips(ETipsType.CdKeyInCd);
		}
		return flag;
	}

	// Token: 0x060082D2 RID: 33490 RVA: 0x00282860 File Offset: 0x00280A60
	private bool CheckStringIllegal(string text)
	{
		bool flag = StringUtils.CheckIsOnlyLettersAndNumbers(text);
		if (!flag)
		{
			this.RefreshTips(ETipsType.IllegalCharacters);
		}
		return !flag;
	}

	// Token: 0x0400500D RID: 20493
	private int MaxLimit;

	// Token: 0x0400500E RID: 20494
	private int MinLimit;
}
