using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.NumberSelect;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020007E0 RID: 2016
public class BusinessTipsInvestModule : UiPanelBase
{
	// Token: 0x06005BEA RID: 23530 RVA: 0x001DA424 File Offset: 0x001D8624
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

	// Token: 0x06005BEB RID: 23531 RVA: 0x001DA514 File Offset: 0x001D8714
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

	// Token: 0x06005BEC RID: 23532 RVA: 0x001DA5DC File Offset: 0x001D87DC
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

	// Token: 0x06005BED RID: 23533 RVA: 0x001DA644 File Offset: 0x001D8844
	private void OnCancel()
	{
		IInvestData investData = MoonChasingBusinessModel.Instance.GetInvestData(0);
		DelegationResultData resultData = MoonChasingBusinessModel.Instance.GetResultData();
		MoonChasingController.Instance.InvestRequest(resultData.EntrustId, 0, investData.Ratio, investData.Ratio);
	}

	// Token: 0x06005BEE RID: 23534 RVA: 0x001DA688 File Offset: 0x001D8888
	private void OnConfirm()
	{
		DelegationResultData resultData = MoonChasingBusinessModel.Instance.GetResultData();
		int selectNumber = this.NumberSelect.GetSelectNumber();
		IInvestData investData = MoonChasingBusinessModel.Instance.GetInvestData(selectNumber);
		IInvestData investData2 = MoonChasingBusinessModel.Instance.GetInvestData(0);
		MoonChasingController.Instance.InvestRequest(resultData.EntrustId, selectNumber, investData.Ratio, investData2.Ratio);
	}

	// Token: 0x04003D5E RID: 15710
	[Nullable(1)]
	protected NumberSelectComponent NumberSelect;

	// Token: 0x04003D5F RID: 15711
	[Nullable(2)]
	private UUIText CostNum;

	// Token: 0x02006B0C RID: 27404
	private static class EComponentDefine
	{
		// Token: 0x0402335B RID: 144219
		public const int SuccessProbability = 0;

		// Token: 0x0402335C RID: 144220
		public const int ReturnRatio = 1;

		// Token: 0x0402335D RID: 144221
		public const int NumberSelectItem = 2;

		// Token: 0x0402335E RID: 144222
		public const int CancelBtn = 3;

		// Token: 0x0402335F RID: 144223
		public const int ConfirmBtn = 4;

		// Token: 0x04023360 RID: 144224
		public const int CostIcon = 5;

		// Token: 0x04023361 RID: 144225
		public const int CostNum = 6;
	}
}
