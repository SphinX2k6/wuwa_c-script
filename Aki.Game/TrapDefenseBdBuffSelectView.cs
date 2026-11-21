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

// Token: 0x02002195 RID: 8597
[NullableContext(1)]
[Nullable(0)]
public class TrapDefenseBdBuffSelectView : UiViewBase
{
	// Token: 0x0601523C RID: 86588 RVA: 0x00626999 File Offset: 0x00624B99
	public TrapDefenseBdBuffSelectView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0601523D RID: 86589 RVA: 0x006269C0 File Offset: 0x00624BC0
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

	// Token: 0x0601523E RID: 86590 RVA: 0x00626B50 File Offset: 0x00624D50
	protected override UniTask OnBeforeStartAsync()
	{
		TrapDefenseBdBuffSelectView.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefenseBdBuffSelectView.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601523F RID: 86591 RVA: 0x00626B94 File Offset: 0x00624D94
	public UniTask InitGoldCostItem()
	{
		TrapDefenseBdBuffSelectView.<InitGoldCostItem>d__15 <InitGoldCostItem>d__;
		<InitGoldCostItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitGoldCostItem>d__.<>4__this = this;
		<InitGoldCostItem>d__.<>1__state = -1;
		<InitGoldCostItem>d__.<>t__builder.Start<TrapDefenseBdBuffSelectView.<InitGoldCostItem>d__15>(ref <InitGoldCostItem>d__);
		return <InitGoldCostItem>d__.<>t__builder.Task;
	}

	// Token: 0x06015240 RID: 86592 RVA: 0x00626BD8 File Offset: 0x00624DD8
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

	// Token: 0x06015241 RID: 86593 RVA: 0x00626C24 File Offset: 0x00624E24
	protected override void OnStart()
	{
		this.BtnItem.SetActive(true);
		this.BtnAndCostItem.SetActive(true);
		string refreshBuffCostIconPath = this.ViewModel.GetRefreshBuffCostIconPath(new int?(this.RefreshBuffCostId));
		this.BtnAndCostItem.UpdateCostIcon(refreshBuffCostIconPath);
		this.UpdateCostNum();
	}

	// Token: 0x06015242 RID: 86594 RVA: 0x00626C72 File Offset: 0x00624E72
	public void UpdateCostNum()
	{
		this.RefreshBuffCostNum = this.ViewModel.RefreshBuffCostNum;
		this.BtnAndCostItem.UpdateCostNum(this.RefreshBuffCostNum);
	}

	// Token: 0x06015243 RID: 86595 RVA: 0x00626C96 File Offset: 0x00624E96
	protected override void OnAddEventListener()
	{
	}

	// Token: 0x06015244 RID: 86596 RVA: 0x00626C98 File Offset: 0x00624E98
	protected override void OnRemoveEventListener()
	{
	}

	// Token: 0x06015245 RID: 86597 RVA: 0x00626C9A File Offset: 0x00624E9A
	protected override void OnBeforeShow()
	{
		this.UpdateData();
	}

	// Token: 0x06015246 RID: 86598 RVA: 0x00626CA2 File Offset: 0x00624EA2
	protected override void OnBeforeDestroy()
	{
	}

	// Token: 0x06015247 RID: 86599 RVA: 0x00626CA4 File Offset: 0x00624EA4
	protected override void OnAfterDestroy()
	{
		this.ViewModel.OnViewClose();
	}

	// Token: 0x06015248 RID: 86600 RVA: 0x00626CB4 File Offset: 0x00624EB4
	private void OnClickBtnBdSum()
	{
		this.ViewModel.Model.OpenViewBdSum(new bool?(true), new ETrapDefenseBdTabType?(ETrapDefenseBdTabType.BdProgress), null);
	}

	// Token: 0x06015249 RID: 86601 RVA: 0x00626CE8 File Offset: 0x00624EE8
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

	// Token: 0x0601524A RID: 86602 RVA: 0x00626D94 File Offset: 0x00624F94
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

	// Token: 0x0601524B RID: 86603 RVA: 0x00626E3E File Offset: 0x0062503E
	public void CheckBdActiveNewQuality()
	{
		this.BtnTagTips.SetActive(false);
	}

	// Token: 0x0601524C RID: 86604 RVA: 0x00626E4C File Offset: 0x0062504C
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

	// Token: 0x0601524D RID: 86605 RVA: 0x00626E91 File Offset: 0x00625091
	private TrapDefenseBdBuffSelectBdItem CreateItemBd()
	{
		return new TrapDefenseBdBuffSelectBdItem
		{
			ClickCallBack = new Action<TrapDefenseBdData>(this.OnClickBdItem)
		};
	}

	// Token: 0x0601524E RID: 86606 RVA: 0x00626EAA File Offset: 0x006250AA
	private void OnClickBdItem(TrapDefenseBdData data)
	{
		this.ViewModel.Model.OpenViewBdSum(new bool?(true), new ETrapDefenseBdTabType?(ETrapDefenseBdTabType.BdProgress), new int?(data.Id));
	}

	// Token: 0x0601524F RID: 86607 RVA: 0x00626ED3 File Offset: 0x006250D3
	private bool OnCanSelectBdBuff()
	{
		return true;
	}

	// Token: 0x06015250 RID: 86608 RVA: 0x00626ED6 File Offset: 0x006250D6
	private void OnSelectBdBuff(TrapDefenseBdBuffData data)
	{
		this.ViewModel.SetSelectBuff(data);
		this.UpdateCost();
		this.UpdateBuffPanelSelectState();
		this.CheckBdActiveNewQuality();
		this.UpdateSureBtnEnable();
		this.LayoutBd.RefreshWithoutDataSync();
	}

	// Token: 0x06015251 RID: 86609 RVA: 0x00626F08 File Offset: 0x00625108
	public void UpdateBuffPanelSelectState()
	{
		TrapDefenseBdBuffData curSelectBdBuffData = this.ViewModel.CurSelectBdBuffData;
		foreach (TrapDefenseBdSumBuffDescPanel trapDefenseBdSumBuffDescPanel in this.BdBuffPanelList)
		{
			trapDefenseBdSumBuffDescPanel.SetSelect(curSelectBdBuffData == trapDefenseBdSumBuffDescPanel.BdBuffData);
		}
	}

	// Token: 0x06015252 RID: 86610 RVA: 0x00626F70 File Offset: 0x00625170
	private void OnBtnClose()
	{
		if (this.ViewModel.BdBuffDataList.Count <= 0)
		{
			base.CloseMe(null);
		}
	}

	// Token: 0x06015253 RID: 86611 RVA: 0x00626F8C File Offset: 0x0062518C
	private void OnBtnHelp()
	{
		int helpIdBdBuffSelect = TrapDefenseConfig.Instance.GetHelpIdBdBuffSelect();
		HelpController.Instance.OpenHelpById(helpIdBdBuffSelect);
	}

	// Token: 0x06015254 RID: 86612 RVA: 0x00626FAF File Offset: 0x006251AF
	private void OnClickBtnSure(int _)
	{
		if (this.ViewModel.BdBuffDataList.Count <= 0)
		{
			base.CloseMe(null);
			return;
		}
		this.SureBuffSelect().Forget();
	}

	// Token: 0x06015255 RID: 86613 RVA: 0x00626FD8 File Offset: 0x006251D8
	public UniTask SureBuffSelect()
	{
		TrapDefenseBdBuffSelectView.<SureBuffSelect>d__37 <SureBuffSelect>d__;
		<SureBuffSelect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<SureBuffSelect>d__.<>4__this = this;
		<SureBuffSelect>d__.<>1__state = -1;
		<SureBuffSelect>d__.<>t__builder.Start<TrapDefenseBdBuffSelectView.<SureBuffSelect>d__37>(ref <SureBuffSelect>d__);
		return <SureBuffSelect>d__.<>t__builder.Task;
	}

	// Token: 0x06015256 RID: 86614 RVA: 0x0062701C File Offset: 0x0062521C
	public UniTask CheckPlayUpStageEffect()
	{
		TrapDefenseBdBuffSelectView.<CheckPlayUpStageEffect>d__38 <CheckPlayUpStageEffect>d__;
		<CheckPlayUpStageEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CheckPlayUpStageEffect>d__.<>4__this = this;
		<CheckPlayUpStageEffect>d__.<>1__state = -1;
		<CheckPlayUpStageEffect>d__.<>t__builder.Start<TrapDefenseBdBuffSelectView.<CheckPlayUpStageEffect>d__38>(ref <CheckPlayUpStageEffect>d__);
		return <CheckPlayUpStageEffect>d__.<>t__builder.Task;
	}

	// Token: 0x06015257 RID: 86615 RVA: 0x0062705F File Offset: 0x0062525F
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

	// Token: 0x06015258 RID: 86616 RVA: 0x00627080 File Offset: 0x00625280
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

	// Token: 0x0400B37C RID: 45948
	public PopupCaptionItem PopupCaption;

	// Token: 0x0400B37D RID: 45949
	public GenericLayout<TrapDefenseBdBuffSelectBdItem, TrapDefenseBdData> LayoutBd;

	// Token: 0x0400B37E RID: 45950
	public List<TrapDefenseBdSumBuffDescPanel> BdBuffPanelList = new List<TrapDefenseBdSumBuffDescPanel>();

	// Token: 0x0400B37F RID: 45951
	public ButtonAndCostItem BtnAndCostItem;

	// Token: 0x0400B380 RID: 45952
	public ButtonItem BtnItem;

	// Token: 0x0400B381 RID: 45953
	public TrapDefenseBtnTagTips BtnTagTips;

	// Token: 0x0400B382 RID: 45954
	public TrapDefenseBdBuffSelectViewModel ViewModel = TrapDefenseModel.Instance.ViewModeBdBuffSelect;

	// Token: 0x0400B383 RID: 45955
	public int RefreshBuffCostId;

	// Token: 0x0400B384 RID: 45956
	public int RefreshBuffCostNum;

	// Token: 0x0400B385 RID: 45957
	public int RefreshBuffMaxTimes;

	// Token: 0x0400B386 RID: 45958
	public TrapDefenseGoldCostItem GoldCostItem;

	// Token: 0x0200843E RID: 33854
	[NullableContext(0)]
	private class EChildType
	{
		// Token: 0x0402AA8A RID: 174730
		public const int ItemCaption = 0;

		// Token: 0x0402AA8B RID: 174731
		public const int LayoutBd = 1;

		// Token: 0x0402AA8C RID: 174732
		public const int BtnBdSum = 2;

		// Token: 0x0402AA8D RID: 174733
		public const int ItemBdBuff1 = 3;

		// Token: 0x0402AA8E RID: 174734
		public const int ItemBdBuff2 = 4;

		// Token: 0x0402AA8F RID: 174735
		public const int ItemBdBuff3 = 5;

		// Token: 0x0402AA90 RID: 174736
		public const int ItemBtnRefresh = 6;

		// Token: 0x0402AA91 RID: 174737
		public const int ItemBtnSure = 7;

		// Token: 0x0402AA92 RID: 174738
		public const int ItemTagTip = 8;
	}
}
