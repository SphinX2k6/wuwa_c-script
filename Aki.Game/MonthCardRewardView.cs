using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.ItemReward;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200234F RID: 9039
public class MonthCardRewardView : UiViewBase
{
	// Token: 0x06011FEB RID: 73707 RVA: 0x004697BE File Offset: 0x004679BE
	[NullableContext(1)]
	public MonthCardRewardView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06011FEC RID: 73708 RVA: 0x004697C8 File Offset: 0x004679C8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickedClose));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06011FED RID: 73709 RVA: 0x0046986E File Offset: 0x00467A6E
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.ReceiveMonthCardDataEvent, new Action(this.OnRefreshView));
	}

	// Token: 0x06011FEE RID: 73710 RVA: 0x0046988C File Offset: 0x00467A8C
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.ReceiveMonthCardDataEvent, new Action(this.OnRefreshView));
	}

	// Token: 0x06011FEF RID: 73711 RVA: 0x004698AC File Offset: 0x00467AAC
	private void OnClickedClose()
	{
		MonthCardRewardView.<>c__DisplayClass7_0 CS$<>8__locals1 = new MonthCardRewardView.<>c__DisplayClass7_0();
		UiInteractLogReport.ReportSpaceKeyInteract(EUiInteractSpaceKeyType.MouthCard);
		RewardItemData item = new RewardItemData(this.RewardId, this.RewardCount, null, EDropItemType.Normal);
		List<RewardItemData> rewardItemDataList = new List<RewardItemData>
		{
			item
		};
		int monthCardRewardId = PayShopConfig.Instance.GetMonthCardRewardId();
		CS$<>8__locals1.isBySplashScreen = (bool)this.OpenParam;
		ItemRewardController.Instance.OpenCommonRewardView(monthCardRewardId, rewardItemDataList, new Action(CS$<>8__locals1.<OnClickedClose>g__closeCallback|0));
		UiManager.Instance.CloseView(this.ViewInfo.Name, null);
	}

	// Token: 0x06011FF0 RID: 73712 RVA: 0x0046993C File Offset: 0x00467B3C
	protected override void OnBeforeShow()
	{
		TItem? localDailyReward = MonthCardModel.Instance.LocalDailyReward;
		this.RewardId = localDailyReward.Value.ItemData.ItemId;
		this.RewardCount = localDailyReward.Value.Count;
		this.RefreshView();
		this.UiViewSequence.PlaySequence("Loop", false, null);
	}

	// Token: 0x06011FF1 RID: 73713 RVA: 0x0046999D File Offset: 0x00467B9D
	private void OnRefreshView()
	{
		this.RefreshView();
	}

	// Token: 0x06011FF2 RID: 73714 RVA: 0x004699A8 File Offset: 0x00467BA8
	private void RefreshView()
	{
		MonthCardModel.Instance.CanShowDailyRewardView = false;
		base.GetText(1).SetText(MonthCardModel.Instance.GetRemainDays().ToString(), true);
	}

	// Token: 0x040087EF RID: 34799
	private int RewardId;

	// Token: 0x040087F0 RID: 34800
	private int RewardCount;

	// Token: 0x020088C9 RID: 35017
	private enum EMonthCardRewardViewComponents
	{
		// Token: 0x0402C75F RID: 182111
		CloseButton,
		// Token: 0x0402C760 RID: 182112
		RemainDaysText
	}
}
