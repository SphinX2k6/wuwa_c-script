using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.ItemReward;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001834 RID: 6196
public class MonthCardRewardView : UiViewBase
{
	// Token: 0x0600F49B RID: 62619 RVA: 0x00476886 File Offset: 0x00474A86
	[NullableContext(1)]
	public MonthCardRewardView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600F49C RID: 62620 RVA: 0x00476890 File Offset: 0x00474A90
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

	// Token: 0x0600F49D RID: 62621 RVA: 0x00476936 File Offset: 0x00474B36
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.ReceiveMonthCardDataEvent, new Action(this.OnRefreshView));
	}

	// Token: 0x0600F49E RID: 62622 RVA: 0x00476954 File Offset: 0x00474B54
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.ReceiveMonthCardDataEvent, new Action(this.OnRefreshView));
	}

	// Token: 0x0600F49F RID: 62623 RVA: 0x00476974 File Offset: 0x00474B74
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

	// Token: 0x0600F4A0 RID: 62624 RVA: 0x00476A04 File Offset: 0x00474C04
	protected override void OnBeforeShow()
	{
		TItem? localDailyReward = MonthCardModel.Instance.LocalDailyReward;
		this.RewardId = localDailyReward.Value.ItemData.ItemId;
		this.RewardCount = localDailyReward.Value.Count;
		this.RefreshView();
		this.UiViewSequence.PlaySequence("Loop", false, null);
	}

	// Token: 0x0600F4A1 RID: 62625 RVA: 0x00476A65 File Offset: 0x00474C65
	private void OnRefreshView()
	{
		this.RefreshView();
	}

	// Token: 0x0600F4A2 RID: 62626 RVA: 0x00476A70 File Offset: 0x00474C70
	private void RefreshView()
	{
		MonthCardModel.Instance.CanShowDailyRewardView = false;
		base.GetText(1).SetText(MonthCardModel.Instance.GetRemainDays().ToString(), true);
	}

	// Token: 0x04008932 RID: 35122
	private int RewardId;

	// Token: 0x04008933 RID: 35123
	private int RewardCount;

	// Token: 0x02007A52 RID: 31314
	private enum EMonthCardRewardViewComponents
	{
		// Token: 0x04027A73 RID: 162419
		CloseButton,
		// Token: 0x04027A74 RID: 162420
		RemainDaysText
	}
}
