using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.NumberSelect;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200132C RID: 4908
public class BusinessTipsInvestModule : UiPanelBase
{
	// Token: 0x0600884F RID: 34895 RVA: 0x001D15B8 File Offset: 0x001CF7B8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(5, typeof(UUITexture)),
			new ValueTuple<int, Type>(6, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(3, new Action(this.OnCancel)),
			new ValueTuple<int, Delegate>(4, new Action(this.OnConfirm))
		};
	}

	// Token: 0x06008850 RID: 34896 RVA: 0x001D16A8 File Offset: 0x001CF8A8
	protected override void OnStart()
	{
		int coinItemId = BusinessConfig.Instance.GetCoinItemId();
		base.SetItemIcon(base.GetTexture(5), coinItemId, null, null);
		this.CostNum = base.GetText(6);
		DelegationResultData resultData = MoonChasingBusinessModel.Instance.GetResultData();
		TrackMoonEntrust delegationConfig = BusinessConfig.Instance.GetDelegationConfig(resultData.EntrustId);
		int coinValue = MoonChasingModel.Instance.GetCoinValue();
		int num = (coinValue > delegationConfig.InvestLimit) ? delegationConfig.InvestLimit : coinValue;
		this.NumberSelect = new NumberSelectComponent(base.GetItem(2));
		this.NumberSelect.SetLimitMaxValueForce(num);
		INumberSelectData data = new INumberSelectData
		{
			MaxNumber = num,
			ValueChangeFunction = new Action<int>(this.ValueChangeFunction)
		};
		this.NumberSelect.Init(data);
	}

	// Token: 0x06008851 RID: 34897 RVA: 0x001D1770 File Offset: 0x001CF970
	private void ValueChangeFunction(int invest)
	{
		IInvestData investData = MoonChasingBusinessModel.Instance.GetInvestData(invest);
		base.GetText(0).SetText(investData.SuccessProbability.ToString(), true);
		base.GetText(1).SetText(investData.Ratio.ToString(), true);
		UUIText costNum = this.CostNum;
		if (costNum == null)
		{
			return;
		}
		costNum.SetText(invest.ToString(), true);
	}

	// Token: 0x06008852 RID: 34898 RVA: 0x001D17D8 File Offset: 0x001CF9D8
	private void OnCancel()
	{
		IInvestData investData = MoonChasingBusinessModel.Instance.GetInvestData(0);
		DelegationResultData resultData = MoonChasingBusinessModel.Instance.GetResultData();
		MoonChasingController.Instance.InvestRequest(resultData.EntrustId, 0, investData.Ratio, investData.Ratio);
	}

	// Token: 0x06008853 RID: 34899 RVA: 0x001D181C File Offset: 0x001CFA1C
	private void OnConfirm()
	{
		DelegationResultData resultData = MoonChasingBusinessModel.Instance.GetResultData();
		int selectNumber = this.NumberSelect.GetSelectNumber();
		IInvestData investData = MoonChasingBusinessModel.Instance.GetInvestData(selectNumber);
		IInvestData investData2 = MoonChasingBusinessModel.Instance.GetInvestData(0);
		MoonChasingController.Instance.InvestRequest(resultData.EntrustId, selectNumber, investData.Ratio, investData2.Ratio);
	}

	// Token: 0x04003CC6 RID: 15558
	[Nullable(1)]
	protected NumberSelectComponent NumberSelect;

	// Token: 0x04003CC7 RID: 15559
	[Nullable(2)]
	private UUIText CostNum;

	// Token: 0x02007982 RID: 31106
	private static class EComponentDefine
	{
		// Token: 0x0402802E RID: 163886
		public const int SuccessProbability = 0;

		// Token: 0x0402802F RID: 163887
		public const int ReturnRatio = 1;

		// Token: 0x04028030 RID: 163888
		public const int NumberSelectItem = 2;

		// Token: 0x04028031 RID: 163889
		public const int CancelBtn = 3;

		// Token: 0x04028032 RID: 163890
		public const int ConfirmBtn = 4;

		// Token: 0x04028033 RID: 163891
		public const int CostIcon = 5;

		// Token: 0x04028034 RID: 163892
		public const int CostNum = 6;
	}
}
