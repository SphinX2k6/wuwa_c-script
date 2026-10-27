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

// Token: 0x02002738 RID: 10040
[NullableContext(1)]
[Nullable(0)]
public class RacingBetsRewardView : UiTickViewBase
{
	// Token: 0x06014999 RID: 84377 RVA: 0x0053695E File Offset: 0x00534B5E
	public RacingBetsRewardView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0601499A RID: 84378 RVA: 0x00536968 File Offset: 0x00534B68
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

	// Token: 0x0601499B RID: 84379 RVA: 0x00536AD6 File Offset: 0x00534CD6
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnRacingBetsRewardRefresh, new Action(this.RefreshView));
		EventSystem.Instance.Add<RacingBetsSeasonData>(EEventName.OnRacingBetsDataRefresh, new Action<RacingBetsSeasonData>(this.RefreshView));
	}

	// Token: 0x0601499C RID: 84380 RVA: 0x00536B10 File Offset: 0x00534D10
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnRacingBetsRewardRefresh, new Action(this.RefreshView));
		EventSystem.Instance.Remove<RacingBetsSeasonData>(EEventName.OnRacingBetsDataRefresh, new Action<RacingBetsSeasonData>(this.RefreshView));
	}

	// Token: 0x0601499D RID: 84381 RVA: 0x00536B4A File Offset: 0x00534D4A
	protected override void OnTick(float _)
	{
		this.RefreshTimeText();
	}

	// Token: 0x0601499E RID: 84382 RVA: 0x00536B54 File Offset: 0x00534D54
	protected override UniTask OnBeforeStartAsync()
	{
		RacingBetsRewardView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RacingBetsRewardView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601499F RID: 84383 RVA: 0x00536B98 File Offset: 0x00534D98
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

	// Token: 0x060149A0 RID: 84384 RVA: 0x00536C02 File Offset: 0x00534E02
	private void RefreshView()
	{
		this.RefreshView(null);
	}

	// Token: 0x060149A1 RID: 84385 RVA: 0x00536C0C File Offset: 0x00534E0C
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

	// Token: 0x060149A2 RID: 84386 RVA: 0x00536C84 File Offset: 0x00534E84
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

	// Token: 0x060149A3 RID: 84387 RVA: 0x00536D07 File Offset: 0x00534F07
	private RacingBetsRewardItem RewardItemProxyCreate()
	{
		RacingBetsRewardItem racingBetsRewardItem = new RacingBetsRewardItem();
		racingBetsRewardItem.BindClickGetButtonCallBack(new Action(this.OnClickGetButton));
		return racingBetsRewardItem;
	}

	// Token: 0x060149A4 RID: 84388 RVA: 0x00536D20 File Offset: 0x00534F20
	private RacingBetsRewardTabItem TabItemProxyCreate()
	{
		RacingBetsRewardTabItem racingBetsRewardTabItem = new RacingBetsRewardTabItem();
		racingBetsRewardTabItem.BindClickToggleCallBack(new Action<RacingBetsGroupRewardData>(this.OnClickTabToggle));
		return racingBetsRewardTabItem;
	}

	// Token: 0x060149A5 RID: 84389 RVA: 0x00536D3C File Offset: 0x00534F3C
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

	// Token: 0x060149A6 RID: 84390 RVA: 0x00536DB8 File Offset: 0x00534FB8
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

	// Token: 0x060149A7 RID: 84391 RVA: 0x00536E3C File Offset: 0x0053503C
	private void OnClickCloseBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x04009AD1 RID: 39633
	[Nullable(2)]
	private RacingBetsGroupRewardData CurGroupRewardData;

	// Token: 0x04009AD2 RID: 39634
	private List<RacingBetsGroupRewardData> GroupDataList;

	// Token: 0x04009AD3 RID: 39635
	private GenericLayout<RacingBetsRewardTabItem, RacingBetsGroupRewardData> TabLayout;

	// Token: 0x04009AD4 RID: 39636
	private GenericLayout<RacingBetsRewardItem, RacingBetsRewardData> RewardLayout;

	// Token: 0x02008DAC RID: 36268
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402DFD8 RID: 188376
		CloseBtn,
		// Token: 0x0402DFD9 RID: 188377
		TogLayout,
		// Token: 0x0402DFDA RID: 188378
		RewardLayout,
		// Token: 0x0402DFDB RID: 188379
		ContentItem,
		// Token: 0x0402DFDC RID: 188380
		TimeText,
		// Token: 0x0402DFDD RID: 188381
		MaskButton,
		// Token: 0x0402DFDE RID: 188382
		TitleText
	}
}
