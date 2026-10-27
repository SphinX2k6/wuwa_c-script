using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.TrapDefense;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002C1A RID: 11290
[NullableContext(1)]
[Nullable(0)]
public class TrapDefenseBdBuffSelectView : UiViewBase
{
	// Token: 0x0601780A RID: 96266 RVA: 0x005F9F75 File Offset: 0x005F8175
	public TrapDefenseBdBuffSelectView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0601780B RID: 96267 RVA: 0x005F9F9C File Offset: 0x005F819C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 9;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUILayoutBase));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnClickBtnBdSum));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0601780C RID: 96268 RVA: 0x005FA12C File Offset: 0x005F832C
	protected override UniTask OnBeforeStartAsync()
	{
		TrapDefenseBdBuffSelectView.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefenseBdBuffSelectView.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601780D RID: 96269 RVA: 0x005FA170 File Offset: 0x005F8370
	public UniTask InitGoldCostItem()
	{
		TrapDefenseBdBuffSelectView.<InitGoldCostItem>d__15 <InitGoldCostItem>d__;
		<InitGoldCostItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitGoldCostItem>d__.<>4__this = this;
		<InitGoldCostItem>d__.<>1__state = -1;
		<InitGoldCostItem>d__.<>t__builder.Start<TrapDefenseBdBuffSelectView.<InitGoldCostItem>d__15>(ref <InitGoldCostItem>d__);
		return <InitGoldCostItem>d__.<>t__builder.Task;
	}

	// Token: 0x0601780E RID: 96270 RVA: 0x005FA1B4 File Offset: 0x005F83B4
	public UniTask CreateBdBuffPanel(int key)
	{
		TrapDefenseBdBuffSelectView.<CreateBdBuffPanel>d__16 <CreateBdBuffPanel>d__;
		<CreateBdBuffPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateBdBuffPanel>d__.<>4__this = this;
		<CreateBdBuffPanel>d__.key = key;
		<CreateBdBuffPanel>d__.<>1__state = -1;
		<CreateBdBuffPanel>d__.<>t__builder.Start<TrapDefenseBdBuffSelectView.<CreateBdBuffPanel>d__16>(ref <CreateBdBuffPanel>d__);
		return <CreateBdBuffPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0601780F RID: 96271 RVA: 0x005FA200 File Offset: 0x005F8400
	protected override void OnStart()
	{
		this.BtnItem.SetActive(true);
		this.BtnAndCostItem.SetActive(true);
		string refreshBuffCostIconPath = this.ViewModel.GetRefreshBuffCostIconPath(new int?(this.RefreshBuffCostId));
		this.BtnAndCostItem.UpdateCostIcon(refreshBuffCostIconPath);
		this.UpdateCostNum();
	}

	// Token: 0x06017810 RID: 96272 RVA: 0x005FA24E File Offset: 0x005F844E
	public void UpdateCostNum()
	{
		this.RefreshBuffCostNum = this.ViewModel.RefreshBuffCostNum;
		this.BtnAndCostItem.UpdateCostNum(this.RefreshBuffCostNum);
	}

	// Token: 0x06017811 RID: 96273 RVA: 0x005FA272 File Offset: 0x005F8472
	protected override void OnAddEventListener()
	{
	}

	// Token: 0x06017812 RID: 96274 RVA: 0x005FA274 File Offset: 0x005F8474
	protected override void OnRemoveEventListener()
	{
	}

	// Token: 0x06017813 RID: 96275 RVA: 0x005FA276 File Offset: 0x005F8476
	protected override void OnBeforeShow()
	{
		this.UpdateData();
	}

	// Token: 0x06017814 RID: 96276 RVA: 0x005FA27E File Offset: 0x005F847E
	protected override void OnBeforeDestroy()
	{
	}

	// Token: 0x06017815 RID: 96277 RVA: 0x005FA280 File Offset: 0x005F8480
	protected override void OnAfterDestroy()
	{
		this.ViewModel.OnViewClose();
	}

	// Token: 0x06017816 RID: 96278 RVA: 0x005FA290 File Offset: 0x005F8490
	private void OnClickBtnBdSum()
	{
		this.ViewModel.Model.OpenViewBdSum(new bool?(true), new ETrapDefenseBdTabType?(ETrapDefenseBdTabType.BdProgress), null);
	}

	// Token: 0x06017817 RID: 96279 RVA: 0x005FA2C4 File Offset: 0x005F84C4
	public void UpdateData()
	{
		this.LayoutBd.RefreshByData(this.ViewModel.GetShowBdDataList(), null, true);
		List<TrapDefenseBdBuffData> bdBuffDataList = this.ViewModel.BdBuffDataList;
		TrapDefenseBdBuffData curSelectBdBuffData = this.ViewModel.CurSelectBdBuffData;
		for (int i = 0; i < this.BdBuffPanelList.Count; i++)
		{
			TrapDefenseBdSumBuffDescPanel trapDefenseBdSumBuffDescPanel = this.BdBuffPanelList[i];
			TrapDefenseBdBuffData trapDefenseBdBuffData = (i < bdBuffDataList.Count) ? bdBuffDataList[i] : null;
			trapDefenseBdSumBuffDescPanel.SetActive(trapDefenseBdBuffData != null);
			if (trapDefenseBdBuffData != null)
			{
				trapDefenseBdSumBuffDescPanel.UpdateDataSelectMode(trapDefenseBdBuffData);
				trapDefenseBdSumBuffDescPanel.SetSelect(trapDefenseBdBuffData == curSelectBdBuffData);
			}
		}
		this.UpdateCost();
		this.CheckBdActiveNewQuality();
		this.UpdateSureBtnEnable();
	}

	// Token: 0x06017818 RID: 96280 RVA: 0x005FA370 File Offset: 0x005F8570
	public void UpdateCost()
	{
		this.RefreshBuffMaxTimes = this.ViewModel.MaxRefreshCount;
		ETrapDefenseTextKey bdBuffSelectRefreshDesc = ETrapDefenseTextKey.BdBuffSelectRefreshDesc;
		int remainRefreshCount = this.ViewModel.RemainRefreshCount;
		this.BtnAndCostItem.SetLocalTextNew(bdBuffSelectRefreshDesc.ToString(), new object[]
		{
			remainRefreshCount,
			this.RefreshBuffMaxTimes
		});
		this.BtnAndCostItem.UpdateCostColor(!this.ViewModel.RefreshBuffIsEnoughCost(null));
		this.BtnAndCostItem.SetEnableClick(remainRefreshCount > 0);
		this.BtnAndCostItem.SetActive(this.RefreshBuffMaxTimes > 0);
	}

	// Token: 0x06017819 RID: 96281 RVA: 0x005FA41A File Offset: 0x005F861A
	public void CheckBdActiveNewQuality()
	{
		this.BtnTagTips.SetActive(false);
	}

	// Token: 0x0601781A RID: 96282 RVA: 0x005FA428 File Offset: 0x005F8628
	public void UpdateSureBtnEnable()
	{
		bool enableClick = this.ViewModel.CurSelectBdBuffData != null || this.ViewModel.BdBuffDataList.Count <= 0;
		ButtonItem btnItem = this.BtnItem;
		if (btnItem == null)
		{
			return;
		}
		btnItem.SetEnableClick(enableClick);
	}

	// Token: 0x0601781B RID: 96283 RVA: 0x005FA46D File Offset: 0x005F866D
	private TrapDefenseBdBuffSelectBdItem CreateItemBd()
	{
		return new TrapDefenseBdBuffSelectBdItem
		{
			ClickCallBack = new Action<TrapDefenseBdData>(this.OnClickBdItem)
		};
	}

	// Token: 0x0601781C RID: 96284 RVA: 0x005FA486 File Offset: 0x005F8686
	private void OnClickBdItem(TrapDefenseBdData data)
	{
		this.ViewModel.Model.OpenViewBdSum(new bool?(true), new ETrapDefenseBdTabType?(ETrapDefenseBdTabType.BdProgress), new int?(data.Id));
	}

	// Token: 0x0601781D RID: 96285 RVA: 0x005FA4AF File Offset: 0x005F86AF
	private bool OnCanSelectBdBuff()
	{
		return true;
	}

	// Token: 0x0601781E RID: 96286 RVA: 0x005FA4B2 File Offset: 0x005F86B2
	private void OnSelectBdBuff(TrapDefenseBdBuffData data)
	{
		this.ViewModel.SetSelectBuff(data);
		this.UpdateCost();
		this.UpdateBuffPanelSelectState();
		this.CheckBdActiveNewQuality();
		this.UpdateSureBtnEnable();
		this.LayoutBd.RefreshWithoutDataSync();
	}

	// Token: 0x0601781F RID: 96287 RVA: 0x005FA4E4 File Offset: 0x005F86E4
	public void UpdateBuffPanelSelectState()
	{
		TrapDefenseBdBuffData curSelectBdBuffData = this.ViewModel.CurSelectBdBuffData;
		foreach (TrapDefenseBdSumBuffDescPanel trapDefenseBdSumBuffDescPanel in this.BdBuffPanelList)
		{
			trapDefenseBdSumBuffDescPanel.SetSelect(curSelectBdBuffData == trapDefenseBdSumBuffDescPanel.BdBuffData);
		}
	}

	// Token: 0x06017820 RID: 96288 RVA: 0x005FA54C File Offset: 0x005F874C
	private void OnBtnClose()
	{
		if (this.ViewModel.BdBuffDataList.Count <= 0)
		{
			base.CloseMe(null);
		}
	}

	// Token: 0x06017821 RID: 96289 RVA: 0x005FA568 File Offset: 0x005F8768
	private void OnBtnHelp()
	{
		int helpIdBdBuffSelect = TrapDefenseConfig.Instance.GetHelpIdBdBuffSelect();
		HelpController.Instance.OpenHelpById(helpIdBdBuffSelect);
	}

	// Token: 0x06017822 RID: 96290 RVA: 0x005FA58B File Offset: 0x005F878B
	private void OnClickBtnSure(int _)
	{
		if (this.ViewModel.BdBuffDataList.Count <= 0)
		{
			base.CloseMe(null);
			return;
		}
		this.SureBuffSelect().Forget();
	}

	// Token: 0x06017823 RID: 96291 RVA: 0x005FA5B4 File Offset: 0x005F87B4
	public UniTask SureBuffSelect()
	{
		TrapDefenseBdBuffSelectView.<SureBuffSelect>d__37 <SureBuffSelect>d__;
		<SureBuffSelect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<SureBuffSelect>d__.<>4__this = this;
		<SureBuffSelect>d__.<>1__state = -1;
		<SureBuffSelect>d__.<>t__builder.Start<TrapDefenseBdBuffSelectView.<SureBuffSelect>d__37>(ref <SureBuffSelect>d__);
		return <SureBuffSelect>d__.<>t__builder.Task;
	}

	// Token: 0x06017824 RID: 96292 RVA: 0x005FA5F8 File Offset: 0x005F87F8
	public UniTask CheckPlayUpStageEffect()
	{
		TrapDefenseBdBuffSelectView.<CheckPlayUpStageEffect>d__38 <CheckPlayUpStageEffect>d__;
		<CheckPlayUpStageEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CheckPlayUpStageEffect>d__.<>4__this = this;
		<CheckPlayUpStageEffect>d__.<>1__state = -1;
		<CheckPlayUpStageEffect>d__.<>t__builder.Start<TrapDefenseBdBuffSelectView.<CheckPlayUpStageEffect>d__38>(ref <CheckPlayUpStageEffect>d__);
		return <CheckPlayUpStageEffect>d__.<>t__builder.Task;
	}

	// Token: 0x06017825 RID: 96293 RVA: 0x005FA63B File Offset: 0x005F883B
	private void OnClickRefreshBuff(int _)
	{
		this.ViewModel.RequestUpdateBdBuffList().ContinueWith(delegate(bool ok)
		{
			if (ok)
			{
				this.UpdateCostNum();
				this.UpdateData();
				base.PlaySequence("Start", null, false);
			}
		});
	}

	// Token: 0x06017826 RID: 96294 RVA: 0x005FA65C File Offset: 0x005F885C
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		if (configParams.Length == 0)
		{
			return null;
		}
		if (!(configParams[0] == "BdList"))
		{
			return null;
		}
		if (configParams.Length < 2)
		{
			return null;
		}
		int num;
		if (!int.TryParse(configParams[1], out num))
		{
			return null;
		}
		if (num < 0 || num >= this.LayoutBd.GetDatas().Count)
		{
			return null;
		}
		UUIItem itemByIndex = this.LayoutBd.GetItemByIndex(num);
		if (itemByIndex == null)
		{
			return null;
		}
		return new UUIItem[]
		{
			itemByIndex,
			itemByIndex
		};
	}

	// Token: 0x0400AF77 RID: 44919
	public PopupCaptionItem PopupCaption;

	// Token: 0x0400AF78 RID: 44920
	public GenericLayout<TrapDefenseBdBuffSelectBdItem, TrapDefenseBdData> LayoutBd;

	// Token: 0x0400AF79 RID: 44921
	public List<TrapDefenseBdSumBuffDescPanel> BdBuffPanelList = new List<TrapDefenseBdSumBuffDescPanel>();

	// Token: 0x0400AF7A RID: 44922
	public ButtonAndCostItem BtnAndCostItem;

	// Token: 0x0400AF7B RID: 44923
	public ButtonItem BtnItem;

	// Token: 0x0400AF7C RID: 44924
	public TrapDefenseBtnTagTips BtnTagTips;

	// Token: 0x0400AF7D RID: 44925
	public TrapDefenseBdBuffSelectViewModel ViewModel = TrapDefenseModel.Instance.ViewModeBdBuffSelect;

	// Token: 0x0400AF7E RID: 44926
	public int RefreshBuffCostId;

	// Token: 0x0400AF7F RID: 44927
	public int RefreshBuffCostNum;

	// Token: 0x0400AF80 RID: 44928
	public int RefreshBuffMaxTimes;

	// Token: 0x0400AF81 RID: 44929
	public TrapDefenseGoldCostItem GoldCostItem;

	// Token: 0x020091FB RID: 37371
	[NullableContext(0)]
	private class EChildType
	{
		// Token: 0x0402F389 RID: 193417
		public const int ItemCaption = 0;

		// Token: 0x0402F38A RID: 193418
		public const int LayoutBd = 1;

		// Token: 0x0402F38B RID: 193419
		public const int BtnBdSum = 2;

		// Token: 0x0402F38C RID: 193420
		public const int ItemBdBuff1 = 3;

		// Token: 0x0402F38D RID: 193421
		public const int ItemBdBuff2 = 4;

		// Token: 0x0402F38E RID: 193422
		public const int ItemBdBuff3 = 5;

		// Token: 0x0402F38F RID: 193423
		public const int ItemBtnRefresh = 6;

		// Token: 0x0402F390 RID: 193424
		public const int ItemBtnSure = 7;

		// Token: 0x0402F391 RID: 193425
		public const int ItemTagTip = 8;
	}
}
