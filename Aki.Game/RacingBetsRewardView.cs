using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RacingBets.Data;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001C23 RID: 7203
[NullableContext(1)]
[Nullable(0)]
public class RacingBetsRewardView : UiTickViewBase
{
	// Token: 0x06011E7B RID: 73339 RVA: 0x0054566A File Offset: 0x0054386A
	public RacingBetsRewardView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06011E7C RID: 73340 RVA: 0x00545674 File Offset: 0x00543874
	protected unsafe override void OnRegisterComponent()
	{
		int num = 7;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickCloseBtn));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.OnClickCloseBtn));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06011E7D RID: 73341 RVA: 0x005457E2 File Offset: 0x005439E2
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnRacingBetsRewardRefresh, new Action(this.RefreshView));
		EventSystem.Instance.Add<RacingBetsSeasonData>(EEventName.OnRacingBetsDataRefresh, new Action<RacingBetsSeasonData>(this.RefreshView));
	}

	// Token: 0x06011E7E RID: 73342 RVA: 0x0054581C File Offset: 0x00543A1C
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnRacingBetsRewardRefresh, new Action(this.RefreshView));
		EventSystem.Instance.Remove<RacingBetsSeasonData>(EEventName.OnRacingBetsDataRefresh, new Action<RacingBetsSeasonData>(this.RefreshView));
	}

	// Token: 0x06011E7F RID: 73343 RVA: 0x00545856 File Offset: 0x00543A56
	protected override void OnTick(float _)
	{
		this.RefreshTimeText();
	}

	// Token: 0x06011E80 RID: 73344 RVA: 0x00545860 File Offset: 0x00543A60
	protected override UniTask OnBeforeStartAsync()
	{
		RacingBetsRewardView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RacingBetsRewardView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06011E81 RID: 73345 RVA: 0x005458A4 File Offset: 0x00543AA4
	protected override void OnStart()
	{
		double num = TimeUtil.Instance.SetTimeSecond(TimeUtil.Instance.GetNextDayTimeStamp());
		double serverTime = TimeUtil.Instance.GetServerTime();
		double remainTime = num - serverTime;
		LguiUtil instance = LguiUtil.Instance;
		UUIText text = base.GetText(4);
		string textStringId = "Dango_DailyTask_Countdown";
		CommonDefine.ICountDown remainTimeDataFormat = TimeUtil.Instance.GetRemainTimeDataFormat3(remainTime);
		instance.SetLocalTextNew(text, textStringId, new <>z__ReadOnlySingleElementList<object>(((remainTimeDataFormat != null) ? remainTimeDataFormat.CountDownText : null) ?? ""));
	}

	// Token: 0x06011E82 RID: 73346 RVA: 0x0054590E File Offset: 0x00543B0E
	private void RefreshView()
	{
		this.RefreshView(null);
	}

	// Token: 0x06011E83 RID: 73347 RVA: 0x00545918 File Offset: 0x00543B18
	private void RefreshView(RacingBetsSeasonData data)
	{
		if (this.CurGroupRewardData == null)
		{
			return;
		}
		foreach (RacingBetsRewardTabItem racingBetsRewardTabItem in this.TabLayout.GetLayoutItemList())
		{
			racingBetsRewardTabItem.RefreshItem();
		}
		List<RacingBetsRewardData> rewardDataList = this.CurGroupRewardData.GetRewardDataList();
		this.RewardLayout.RefreshByData(rewardDataList, null, false);
	}

	// Token: 0x06011E84 RID: 73348 RVA: 0x00545990 File Offset: 0x00543B90
	private void RefreshTimeText()
	{
		UUIText text = base.GetText(4);
		if (this.CurGroupRewardData == null)
		{
			text.SetUIActive(false);
			return;
		}
		double num = TimeUtil.Instance.SetTimeSecond(TimeUtil.Instance.GetNextDayTimeStamp());
		double serverTime = TimeUtil.Instance.GetServerTime();
		double remainTime = num - serverTime;
		LguiUtil instance = LguiUtil.Instance;
		UUIText uiText = text;
		string textStringId = "Dango_DailyTask_Countdown";
		CommonDefine.ICountDown remainTimeDataFormat = TimeUtil.Instance.GetRemainTimeDataFormat3(remainTime);
		instance.SetLocalTextNew(uiText, textStringId, new <>z__ReadOnlySingleElementList<object>(((remainTimeDataFormat != null) ? remainTimeDataFormat.CountDownText : null) ?? ""));
		text.SetUIActive(true);
	}

	// Token: 0x06011E85 RID: 73349 RVA: 0x00545A13 File Offset: 0x00543C13
	private RacingBetsRewardItem RewardItemProxyCreate()
	{
		RacingBetsRewardItem racingBetsRewardItem = new RacingBetsRewardItem();
		racingBetsRewardItem.BindClickGetButtonCallBack(new Action(this.OnClickGetButton));
		return racingBetsRewardItem;
	}

	// Token: 0x06011E86 RID: 73350 RVA: 0x00545A2C File Offset: 0x00543C2C
	private RacingBetsRewardTabItem TabItemProxyCreate()
	{
		RacingBetsRewardTabItem racingBetsRewardTabItem = new RacingBetsRewardTabItem();
		racingBetsRewardTabItem.BindClickToggleCallBack(new Action<RacingBetsGroupRewardData>(this.OnClickTabToggle));
		return racingBetsRewardTabItem;
	}

	// Token: 0x06011E87 RID: 73351 RVA: 0x00545A48 File Offset: 0x00543C48
	private void OnClickTabToggle(RacingBetsGroupRewardData groupData)
	{
		if (this.CurGroupRewardData == groupData)
		{
			return;
		}
		this.CurGroupRewardData = groupData;
		int gridIndex = this.GroupDataList.FindIndex((RacingBetsGroupRewardData data) => data == groupData);
		this.TabLayout.SelectGridProxy(gridIndex, false);
		List<RacingBetsRewardData> rewardDataList = groupData.GetRewardDataList();
		this.RewardLayout.RefreshByData(rewardDataList, null, false);
		this.RefreshTimeText();
	}

	// Token: 0x06011E88 RID: 73352 RVA: 0x00545AC4 File Offset: 0x00543CC4
	private void OnClickGetButton()
	{
		List<int> list = new List<int>();
		RacingBetsGroupRewardData curGroupRewardData = this.CurGroupRewardData;
		List<RacingBetsRewardData> list2 = (curGroupRewardData != null) ? curGroupRewardData.GetRewardDataList() : null;
		if (list2 != null)
		{
			foreach (RacingBetsRewardData racingBetsRewardData in list2)
			{
				if (racingBetsRewardData.CanReceiveReward())
				{
					list.Add(racingBetsRewardData.Id);
				}
			}
		}
		RacingBetsController.Instance.RacingBetsRepeatedTaskRewardRequest(list);
	}

	// Token: 0x06011E89 RID: 73353 RVA: 0x00545B48 File Offset: 0x00543D48
	private void OnClickCloseBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x04009C29 RID: 39977
	[Nullable(2)]
	private RacingBetsGroupRewardData CurGroupRewardData;

	// Token: 0x04009C2A RID: 39978
	private List<RacingBetsGroupRewardData> GroupDataList;

	// Token: 0x04009C2B RID: 39979
	private GenericLayout<RacingBetsRewardTabItem, RacingBetsGroupRewardData> TabLayout;

	// Token: 0x04009C2C RID: 39980
	private GenericLayout<RacingBetsRewardItem, RacingBetsRewardData> RewardLayout;

	// Token: 0x02007F34 RID: 32564
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x040292EE RID: 168686
		CloseBtn,
		// Token: 0x040292EF RID: 168687
		TogLayout,
		// Token: 0x040292F0 RID: 168688
		RewardLayout,
		// Token: 0x040292F1 RID: 168689
		ContentItem,
		// Token: 0x040292F2 RID: 168690
		TimeText,
		// Token: 0x040292F3 RID: 168691
		MaskButton,
		// Token: 0x040292F4 RID: 168692
		TitleText
	}
}
