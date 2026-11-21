using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.ItemReward;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020009AD RID: 2477
[NullableContext(1)]
[Nullable(0)]
public class ScratchTicketMainView : UiTickViewBase
{
	// Token: 0x06006CC1 RID: 27841 RVA: 0x0021AB98 File Offset: 0x00218D98
	public ScratchTicketMainView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06006CC2 RID: 27842 RVA: 0x0021ABD8 File Offset: 0x00218DD8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 11;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIGridLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIMultiTemplateLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06006CC3 RID: 27843 RVA: 0x0021AD70 File Offset: 0x00218F70
	protected override UniTask OnBeforeStartAsync()
	{
		ScratchTicketMainView.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ScratchTicketMainView.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06006CC4 RID: 27844 RVA: 0x0021ADB3 File Offset: 0x00218FB3
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
		EventSystem.Instance.Add(EEventName.OnScratchTicketConditionRefresh, new Action(this.OnScratchTicketConditionRefresh));
	}

	// Token: 0x06006CC5 RID: 27845 RVA: 0x0021ADED File Offset: 0x00218FED
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
		EventSystem.Instance.Remove(EEventName.OnScratchTicketConditionRefresh, new Action(this.OnScratchTicketConditionRefresh));
	}

	// Token: 0x06006CC6 RID: 27846 RVA: 0x0021AE28 File Offset: 0x00219028
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		int index;
		if (configParams.Length == 0 || !int.TryParse(configParams[0], out index))
		{
			return null;
		}
		GenericLayout<ScratchTicketCellItem, ScratchTicketCellData> cellLayout = this.CellLayout;
		UUIItem uuiitem = (cellLayout != null) ? cellLayout.GetItemByIndex(index) : null;
		if (uuiitem == null)
		{
			return null;
		}
		return new UUIItem[]
		{
			uuiitem,
			uuiitem
		};
	}

	// Token: 0x06006CC7 RID: 27847 RVA: 0x0021AE70 File Offset: 0x00219070
	private UniTask InitRoundDataList()
	{
		ScratchTicketMainView.<InitRoundDataList>d__19 <InitRoundDataList>d__;
		<InitRoundDataList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitRoundDataList>d__.<>4__this = this;
		<InitRoundDataList>d__.<>1__state = -1;
		<InitRoundDataList>d__.<>t__builder.Start<ScratchTicketMainView.<InitRoundDataList>d__19>(ref <InitRoundDataList>d__);
		return <InitRoundDataList>d__.<>t__builder.Task;
	}

	// Token: 0x06006CC8 RID: 27848 RVA: 0x0021AEB4 File Offset: 0x002190B4
	private UniTask InitCellLayout()
	{
		ScratchTicketMainView.<InitCellLayout>d__20 <InitCellLayout>d__;
		<InitCellLayout>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitCellLayout>d__.<>4__this = this;
		<InitCellLayout>d__.<>1__state = -1;
		<InitCellLayout>d__.<>t__builder.Start<ScratchTicketMainView.<InitCellLayout>d__20>(ref <InitCellLayout>d__);
		return <InitCellLayout>d__.<>t__builder.Task;
	}

	// Token: 0x06006CC9 RID: 27849 RVA: 0x0021AEF8 File Offset: 0x002190F8
	private void ReSelectRoundTab()
	{
		int firstProgressRoundDataIndex = this.ScratchTicketData.GetFirstProgressRoundDataIndex();
		if (firstProgressRoundDataIndex < 0)
		{
			return;
		}
		this.TabLayout.GetLayoutItemByKey(firstProgressRoundDataIndex).SetSelect(true, true);
	}

	// Token: 0x06006CCA RID: 27850 RVA: 0x0021AF30 File Offset: 0x00219130
	private void RefreshCellLayout(ScratchTicketRoundData roundData)
	{
		List<ScratchTicketRoundResult> diagonalResult = roundData.GetDiagonalResultList();
		if (diagonalResult.Count <= 0)
		{
			return;
		}
		UiLayer.Instance.SetShowMaskLayer(EUiViewName.ScratchTicketMainView, true);
		this.RefreshRoundReward(diagonalResult[0]);
		this.RefreshCellReward(diagonalResult[0].RewardList);
		int time = 1;
		TTimerAction action = delegate(float _)
		{
			int time;
			if (time >= diagonalResult.Count)
			{
				UiLayer.Instance.SetShowMaskLayer(EUiViewName.ScratchTicketMainView, false);
				this.ClearRevealTimer();
				return;
			}
			this.RefreshRoundReward(diagonalResult[time]);
			time = time;
			time++;
		};
		this.RevealTimerHandle = TimerSystem.GameplayTimeInstance.Forever(action, 30f, 1f, null, null, true);
	}

	// Token: 0x06006CCB RID: 27851 RVA: 0x0021AFD8 File Offset: 0x002191D8
	private void RefreshTipPanel()
	{
		if (this.ScratchTicketData.GetScratchCardActivityConfig() == null)
		{
			return;
		}
		Activity? localConfig = this.ScratchTicketData.LocalConfig;
		if (localConfig == null)
		{
			return;
		}
		this.TitleItem.SetActivityBaseData(this.ScratchTicketData);
		this.TitleItem.SetTitleByText(this.ScratchTicketData.GetTitle());
		this.RewardLayout.RefreshByData(this.CurSelectRoundData.GetRemainRewardList(), null, false);
		this.RefreshTimerText();
		EScratchTicketRoundState roundState = this.CurSelectRoundData.GetRoundState();
		this.FunctionalItem.PanelLock.SetUiActive(roundState == EScratchTicketRoundState.Lock);
		this.FunctionalItem.PanelActivate.SetUiActive(roundState == EScratchTicketRoundState.Finish);
		this.FunctionalItem.FunctionButton.SetUiActive(false);
		this.FunctionalItem.PanelActivate.SetTextByTextId("ScratchCardActivity_CompleteDesc", Array.Empty<string>());
		string togRoundIcon = this.CurSelectRoundData.Config.Value.TogRoundIcon;
		this.SetSpriteByPath(togRoundIcon, base.GetSprite(9), false, null, null);
		bool flag = this.ScratchTicketData.IsAllRoundFinish();
		this.CaptionItem.SetCurrencyItemVisible(!flag);
		base.GetItem(10).SetUIActive(!flag);
		base.GetItem(8).SetUIActive(flag);
		List<ScratchTicketConditionData> conditionDataList = this.ScratchTicketData.GetConditionDataList();
		this.ConditionLayout.RefreshByData(conditionDataList, null, false);
	}

	// Token: 0x06006CCC RID: 27852 RVA: 0x0021B144 File Offset: 0x00219344
	private void RefreshTimerText()
	{
		double endOpenTime = (double)this.ScratchTicketData.EndOpenTime;
		double serverTime = TimeUtil.Instance.GetServerTime();
		double remainTime = Math.Max(endOpenTime - serverTime, 1.0);
		CommonDefine.ICountDown remainTimeDataFormat = TimeUtil.Instance.GetRemainTimeDataFormat3(remainTime);
		string localTextNew = ConfigMultiTextLang.GetLocalTextNew("ScratchCardActivity_TimeDesc", null);
		this.TitleItem.SetTimeTextByText(StringUtils.Format(localTextNew, new string[]
		{
			remainTimeDataFormat.CountDownText
		}));
		if (this.CurSelectRoundData.GetRoundState() == EScratchTicketRoundState.Lock)
		{
			double num = (double)this.CurSelectRoundData.GetUnlockTime() * TimeUtil.Instance.Millisecond - serverTime;
			EScratchTicketRoundState preRoundState = this.CurSelectRoundData.GetPreRoundState();
			if (num > 0.0)
			{
				CommonDefine.ICountDown remainTimeDataFormat2 = TimeUtil.Instance.GetRemainTimeDataFormat3(num);
				string textByText = StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew("ScratchCardActivity_NoJoinTips01", null), new string[]
				{
					remainTimeDataFormat2.CountDownText
				});
				this.FunctionalItem.PanelLock.SetTextByText(textByText);
				return;
			}
			if (preRoundState != EScratchTicketRoundState.Finish)
			{
				this.FunctionalItem.PanelLock.SetTextByTextId("ScratchCardActivity_NoJoinTips02", Array.Empty<string>());
				return;
			}
			this.FunctionalItem.PanelLock.SetTextByTextId("ScratchCardActivity_NoJoinTips03", Array.Empty<string>());
		}
	}

	// Token: 0x06006CCD RID: 27853 RVA: 0x0021B274 File Offset: 0x00219474
	protected override void OnTick(float delta)
	{
		this.TickTime += delta;
		if (this.TickTime >= (float)TimeUtil.Instance.InverseMillisecond)
		{
			this.RefreshTimerText();
			this.TickTime %= (float)TimeUtil.Instance.InverseMillisecond;
		}
	}

	// Token: 0x06006CCE RID: 27854 RVA: 0x0021B2C0 File Offset: 0x002194C0
	protected override void OnBeforeHide()
	{
		UiLayer.Instance.SetShowMaskLayer(EUiViewName.ScratchTicketMainView, false);
		this.ClearTimer();
		this.ClearRevealTimer();
	}

	// Token: 0x06006CCF RID: 27855 RVA: 0x0021B2E3 File Offset: 0x002194E3
	private void ClearTimer()
	{
		if (TimerSystem.GameplayTimeInstance.Has(this.TimerHandle))
		{
			TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
			this.TimerHandle = null;
		}
	}

	// Token: 0x06006CD0 RID: 27856 RVA: 0x0021B30F File Offset: 0x0021950F
	private void ClearRevealTimer()
	{
		if (TimerSystem.GameplayTimeInstance.Has(this.RevealTimerHandle))
		{
			TimerSystem.GameplayTimeInstance.Remove(this.RevealTimerHandle);
			this.RevealTimerHandle = null;
		}
	}

	// Token: 0x06006CD1 RID: 27857 RVA: 0x0021B33B File Offset: 0x0021953B
	private void OnActivitySequenceEmitEvent(string param)
	{
		if (param == "Refresh")
		{
			this.RefreshCellLayout(this.CurSelectRoundData);
			this.PlayFirstTabSequence(this.CurSelectRoundData);
		}
	}

	// Token: 0x06006CD2 RID: 27858 RVA: 0x0021B364 File Offset: 0x00219564
	private void OnScratchTicketConditionRefresh()
	{
		List<ScratchTicketRoundData> roundDataList = this.ScratchTicketData.GetRoundDataList();
		this.TabLayout.RefreshByData(roundDataList, null, false);
		this.RefreshTipPanel();
	}

	// Token: 0x06006CD3 RID: 27859 RVA: 0x0021B394 File Offset: 0x00219594
	private void OnClickRoundTabItem(ScratchTicketRoundData data, ScratchTicketTabItem item)
	{
		if (this.CurSelectRoundTabItem != null)
		{
			this.CurSelectRoundTabItem.SetSelect(false, false);
		}
		ScratchTicketRoundData curSelectRoundData = this.CurSelectRoundData;
		this.CurSelectRoundTabItem = item;
		this.CurSelectRoundTabItem.SetSelect(true, false);
		this.CurSelectRoundData = data;
		this.PlayTabSequence(this.CurSelectRoundData, curSelectRoundData);
		this.RefreshCellLayout(this.CurSelectRoundData);
		this.RefreshTipPanel();
	}

	// Token: 0x06006CD4 RID: 27860 RVA: 0x0021B3F8 File Offset: 0x002195F8
	private void OnClickCellItem(ScratchTicketCellData data)
	{
		if (!data.IsLock())
		{
			return;
		}
		if (this.CurSelectRoundData == null || this.CurSelectRoundData.GetRoundState() != EScratchTicketRoundState.InProgress)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("ScratchCardActivity_ClickTips02", Array.Empty<object>());
			return;
		}
		if (this.ScratchTicketData.GetRemainCount() <= 0)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("ScratchCardActivity_ClickTips01", Array.Empty<object>());
			return;
		}
		int id = this.CurSelectRoundData.Id;
		ActivityScratchTicketController.Instance.SendScratchCardRewardRequest(id, data.Index, new Action<EScratchTicketRewardType, int, List<ScratchTicketRoundResult>, List<RewardItemData>>(this.OnScratchRewardRefresh));
	}

	// Token: 0x06006CD5 RID: 27861 RVA: 0x0021B488 File Offset: 0x00219688
	private void OnScratchRewardRefresh(EScratchTicketRewardType rewardType, int roundId, List<ScratchTicketRoundResult> resultDataList, List<RewardItemData> rewardItemDataList)
	{
		if (roundId != this.CurSelectRoundData.Id)
		{
			return;
		}
		if (resultDataList.Count <= 0)
		{
			return;
		}
		if (resultDataList.Count == 1)
		{
			UiLayer.Instance.SetShowMaskLayer(EUiViewName.ScratchTicketMainView, true);
			TTimerAction action = delegate(float _)
			{
				UiLayer.Instance.SetShowMaskLayer(EUiViewName.ScratchTicketMainView, false);
				this.ShowRewardTip(rewardType, rewardItemDataList);
			};
			this.RefreshRoundReward(resultDataList[0]);
			this.PlayShakeSequence();
			TimerSystem.GameplayTimeInstance.Delay(action, resultDataList[0].DelayInterval, null, null, true, 1f);
			return;
		}
		this.RefreshRoundReward(resultDataList[0]);
		float delayInterval = resultDataList[0].DelayInterval;
		int time = 1;
		float deltaTime = 0f;
		this.PlayShakeSequence();
		UiLayer.Instance.SetShowMaskLayer(EUiViewName.ScratchTicketMainView, true);
		TTimerAction action2 = delegate(float delta)
		{
			deltaTime += delta;
			if (deltaTime < delayInterval)
			{
				return;
			}
			deltaTime %= delayInterval;
			int time;
			if (time >= resultDataList.Count)
			{
				UiLayer.Instance.SetShowMaskLayer(EUiViewName.ScratchTicketMainView, false);
				this.ShowRewardTip(rewardType, rewardItemDataList);
				this.ClearTimer();
			}
			else if (time == resultDataList.Count - 1)
			{
				this.RefreshRoundReward(resultDataList[time]);
				delayInterval = 700f;
			}
			else
			{
				this.RefreshRoundReward(resultDataList[time]);
				delayInterval = resultDataList[time].DelayInterval;
			}
			time = time;
			time++;
		};
		this.TimerHandle = TimerSystem.GameplayTimeInstance.Forever(action2, 50f, 1f, null, null, true);
	}

	// Token: 0x06006CD6 RID: 27862 RVA: 0x0021B5C5 File Offset: 0x002197C5
	private void PlayShakeSequence()
	{
		TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
		{
			base.PlaySequence("Shake", null, false);
		}, 500f, null, null, true, 1f);
	}

	// Token: 0x06006CD7 RID: 27863 RVA: 0x0021B5EC File Offset: 0x002197EC
	private void PlayTabSequence(ScratchTicketRoundData curRoundData, ScratchTicketRoundData lastRoundData)
	{
		int roundDataIndex = this.ScratchTicketData.GetRoundDataIndex(curRoundData);
		int roundDataIndex2 = this.ScratchTicketData.GetRoundDataIndex(lastRoundData);
		bool isReverse = roundDataIndex < roundDataIndex2;
		int num = Math.Min(roundDataIndex, roundDataIndex2);
		int num2 = Math.Max(roundDataIndex, roundDataIndex2);
		if (num2 == 1 && num == 0)
		{
			this.UiViewSequence.PlaySequencePurely("SwitchA", true, isReverse);
		}
		if (num2 == 2 && num == 0)
		{
			this.UiViewSequence.PlaySequencePurely("SwitchB", true, isReverse);
		}
		if (num2 == 2 && num == 1)
		{
			this.UiViewSequence.PlaySequencePurely("SwitchC", true, isReverse);
		}
	}

	// Token: 0x06006CD8 RID: 27864 RVA: 0x0021B670 File Offset: 0x00219870
	private void PlayFirstTabSequence(ScratchTicketRoundData curRoundData)
	{
		int roundDataIndex = this.ScratchTicketData.GetRoundDataIndex(curRoundData);
		if (roundDataIndex == 1)
		{
			this.UiViewSequence.PlaySequencePurely("SwitchA", true, false);
			return;
		}
		if (roundDataIndex == 2)
		{
			this.UiViewSequence.PlaySequencePurely("SwitchB", true, false);
		}
	}

	// Token: 0x06006CD9 RID: 27865 RVA: 0x0021B6B7 File Offset: 0x002198B7
	private void ShowRewardTip(EScratchTicketRewardType rewardType, List<RewardItemData> rewardItemDataList)
	{
		if (rewardType == EScratchTicketRewardType.Center)
		{
			ActivityScratchTicketController.Instance.ShowScratchTicketRewardTip(rewardItemDataList);
			this.OnScratchRewardRefreshUi();
			return;
		}
		ItemRewardController.Instance.OpenCommonRewardView(1009, rewardItemDataList, new Action(this.OnScratchRewardRefreshUi));
	}

	// Token: 0x06006CDA RID: 27866 RVA: 0x0021B6EC File Offset: 0x002198EC
	private void OnScratchRewardRefreshUi()
	{
		if (this.CurSelectRoundData.GetRoundState() == EScratchTicketRoundState.Finish)
		{
			List<ScratchTicketRoundData> roundDataList = this.ScratchTicketData.GetRoundDataList();
			this.TabLayout.RefreshByData(roundDataList, null, false);
			this.ReSelectRoundTab();
			return;
		}
		this.RefreshTipPanel();
	}

	// Token: 0x06006CDB RID: 27867 RVA: 0x0021B730 File Offset: 0x00219930
	private void RefreshRoundReward(IScratchTicketRoundResult roundData)
	{
		if (roundData.RewardList.Count > 0)
		{
			this.RefreshCellReward(roundData.RewardList);
		}
		if (roundData.SequenceName != "Empty")
		{
			this.UiViewSequence.PlaySequence(roundData.SequenceName, false, null);
		}
	}

	// Token: 0x06006CDC RID: 27868 RVA: 0x0021B784 File Offset: 0x00219984
	private void RefreshCellReward(List<ScratchTicketRewardResult> resultData)
	{
		foreach (ScratchTicketRewardResult scratchTicketRewardResult in resultData)
		{
			ScratchTicketCellItem layoutItemByKey = this.CellLayout.GetLayoutItemByKey(scratchTicketRewardResult.Index);
			ScratchTicketCellData cellDataByIndex = this.CurSelectRoundData.GetCellDataByIndex(scratchTicketRewardResult.Index);
			if (layoutItemByKey != null)
			{
				layoutItemByKey.RefreshByResultData(cellDataByIndex, scratchTicketRewardResult);
			}
		}
	}

	// Token: 0x06006CDD RID: 27869 RVA: 0x0021B800 File Offset: 0x00219A00
	private void OnClickCloseBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x06006CDE RID: 27870 RVA: 0x0021B809 File Offset: 0x00219A09
	private void OnClickHelpBtn()
	{
		HelpController.Instance.OpenHelpById(this.ScratchTicketData.GetHelpId());
	}

	// Token: 0x06006CDF RID: 27871 RVA: 0x0021B820 File Offset: 0x00219A20
	private ScratchTicketTabItem CreateRoundTabItem()
	{
		ScratchTicketTabItem scratchTicketTabItem = new ScratchTicketTabItem();
		scratchTicketTabItem.SetClickToggleCallback(new Action<ScratchTicketRoundData, ScratchTicketTabItem>(this.OnClickRoundTabItem));
		return scratchTicketTabItem;
	}

	// Token: 0x06006CE0 RID: 27872 RVA: 0x0021B839 File Offset: 0x00219A39
	private ScratchTicketCellItem CreateCellItem()
	{
		ScratchTicketCellItem scratchTicketCellItem = new ScratchTicketCellItem();
		scratchTicketCellItem.SetClickCallback(new Action<ScratchTicketCellData>(this.OnClickCellItem));
		return scratchTicketCellItem;
	}

	// Token: 0x06006CE1 RID: 27873 RVA: 0x0021B852 File Offset: 0x00219A52
	public ScratchTicketRewardItemGrid CreateRewardGridItem()
	{
		return new ScratchTicketRewardItemGrid();
	}

	// Token: 0x040043EC RID: 17388
	[Nullable(2)]
	private ActivityTitleTypeA TitleItem;

	// Token: 0x040043ED RID: 17389
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x040043EE RID: 17390
	[Nullable(2)]
	private ActivityFunctionalTypeA FunctionalItem;

	// Token: 0x040043EF RID: 17391
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<ScratchTicketConditionItem, ScratchTicketConditionData> ConditionLayout;

	// Token: 0x040043F0 RID: 17392
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<ScratchTicketTabItem, ScratchTicketRoundData> TabLayout;

	// Token: 0x040043F1 RID: 17393
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<ScratchTicketCellItem, ScratchTicketCellData> CellLayout;

	// Token: 0x040043F2 RID: 17394
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<ScratchTicketRewardItemGrid, TItem> RewardLayout;

	// Token: 0x040043F3 RID: 17395
	[Nullable(2)]
	private ScratchTicketData ScratchTicketData;

	// Token: 0x040043F4 RID: 17396
	[Nullable(2)]
	private ScratchTicketTabItem CurSelectRoundTabItem;

	// Token: 0x040043F5 RID: 17397
	[Nullable(2)]
	private ScratchTicketRoundData CurSelectRoundData;

	// Token: 0x040043F6 RID: 17398
	[Nullable(2)]
	private TimerHandle TimerHandle;

	// Token: 0x040043F7 RID: 17399
	[Nullable(2)]
	private TimerHandle RevealTimerHandle;

	// Token: 0x040043F8 RID: 17400
	private float TickTime = (float)TimeUtil.Instance.InverseMillisecond;

	// Token: 0x040043F9 RID: 17401
	private readonly Func<ScratchTicketConditionItem> CreateConditionItem = () => new ScratchTicketConditionItem();

	// Token: 0x02006CB6 RID: 27830
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x04023B5A RID: 146266
		public const int TitleItem = 0;

		// Token: 0x04023B5B RID: 146267
		public const int FunctionItem = 1;

		// Token: 0x04023B5C RID: 146268
		public const int ScratchTicketRootItem = 2;

		// Token: 0x04023B5D RID: 146269
		public const int ScratchTicketConditionLayout = 3;

		// Token: 0x04023B5E RID: 146270
		public const int ScratchTicketTabLayout = 4;

		// Token: 0x04023B5F RID: 146271
		public const int ScratchTicketCellLayout = 5;

		// Token: 0x04023B60 RID: 146272
		public const int CaptionItem = 6;

		// Token: 0x04023B61 RID: 146273
		public const int RewardLayout = 7;

		// Token: 0x04023B62 RID: 146274
		public const int EmptyItem = 8;

		// Token: 0x04023B63 RID: 146275
		public const int RoundSprite = 9;

		// Token: 0x04023B64 RID: 146276
		public const int ScratchTicketConditionRoot = 10;
	}
}
