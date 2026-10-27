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

// Token: 0x020014F5 RID: 5365
[NullableContext(1)]
[Nullable(0)]
public class ScratchTicketMainView : UiTickViewBase
{
	// Token: 0x060098E7 RID: 39143 RVA: 0x00210EA8 File Offset: 0x0020F0A8
	public ScratchTicketMainView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x060098E8 RID: 39144 RVA: 0x00210EE8 File Offset: 0x0020F0E8
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

	// Token: 0x060098E9 RID: 39145 RVA: 0x00211080 File Offset: 0x0020F280
	protected override UniTask OnBeforeStartAsync()
	{
		ScratchTicketMainView.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ScratchTicketMainView.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060098EA RID: 39146 RVA: 0x002110C3 File Offset: 0x0020F2C3
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
		EventSystem.Instance.Add(EEventName.OnScratchTicketConditionRefresh, new Action(this.OnScratchTicketConditionRefresh));
	}

	// Token: 0x060098EB RID: 39147 RVA: 0x002110FD File Offset: 0x0020F2FD
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
		EventSystem.Instance.Remove(EEventName.OnScratchTicketConditionRefresh, new Action(this.OnScratchTicketConditionRefresh));
	}

	// Token: 0x060098EC RID: 39148 RVA: 0x00211138 File Offset: 0x0020F338
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

	// Token: 0x060098ED RID: 39149 RVA: 0x00211180 File Offset: 0x0020F380
	private UniTask InitRoundDataList()
	{
		ScratchTicketMainView.<InitRoundDataList>d__19 <InitRoundDataList>d__;
		<InitRoundDataList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitRoundDataList>d__.<>4__this = this;
		<InitRoundDataList>d__.<>1__state = -1;
		<InitRoundDataList>d__.<>t__builder.Start<ScratchTicketMainView.<InitRoundDataList>d__19>(ref <InitRoundDataList>d__);
		return <InitRoundDataList>d__.<>t__builder.Task;
	}

	// Token: 0x060098EE RID: 39150 RVA: 0x002111C4 File Offset: 0x0020F3C4
	private UniTask InitCellLayout()
	{
		ScratchTicketMainView.<InitCellLayout>d__20 <InitCellLayout>d__;
		<InitCellLayout>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitCellLayout>d__.<>4__this = this;
		<InitCellLayout>d__.<>1__state = -1;
		<InitCellLayout>d__.<>t__builder.Start<ScratchTicketMainView.<InitCellLayout>d__20>(ref <InitCellLayout>d__);
		return <InitCellLayout>d__.<>t__builder.Task;
	}

	// Token: 0x060098EF RID: 39151 RVA: 0x00211208 File Offset: 0x0020F408
	private void ReSelectRoundTab()
	{
		int firstProgressRoundDataIndex = this.ScratchTicketData.GetFirstProgressRoundDataIndex();
		if (firstProgressRoundDataIndex < 0)
		{
			return;
		}
		this.TabLayout.GetLayoutItemByKey(firstProgressRoundDataIndex).SetSelect(true, true);
	}

	// Token: 0x060098F0 RID: 39152 RVA: 0x00211240 File Offset: 0x0020F440
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

	// Token: 0x060098F1 RID: 39153 RVA: 0x002112E8 File Offset: 0x0020F4E8
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

	// Token: 0x060098F2 RID: 39154 RVA: 0x00211454 File Offset: 0x0020F654
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

	// Token: 0x060098F3 RID: 39155 RVA: 0x00211584 File Offset: 0x0020F784
	protected override void OnTick(float delta)
	{
		this.TickTime += delta;
		if (this.TickTime >= (float)TimeUtil.Instance.InverseMillisecond)
		{
			this.RefreshTimerText();
			this.TickTime %= (float)TimeUtil.Instance.InverseMillisecond;
		}
	}

	// Token: 0x060098F4 RID: 39156 RVA: 0x002115D0 File Offset: 0x0020F7D0
	protected override void OnBeforeHide()
	{
		UiLayer.Instance.SetShowMaskLayer(EUiViewName.ScratchTicketMainView, false);
		this.ClearTimer();
		this.ClearRevealTimer();
	}

	// Token: 0x060098F5 RID: 39157 RVA: 0x002115F3 File Offset: 0x0020F7F3
	private void ClearTimer()
	{
		if (TimerSystem.GameplayTimeInstance.Has(this.TimerHandle))
		{
			TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
			this.TimerHandle = null;
		}
	}

	// Token: 0x060098F6 RID: 39158 RVA: 0x0021161F File Offset: 0x0020F81F
	private void ClearRevealTimer()
	{
		if (TimerSystem.GameplayTimeInstance.Has(this.RevealTimerHandle))
		{
			TimerSystem.GameplayTimeInstance.Remove(this.RevealTimerHandle);
			this.RevealTimerHandle = null;
		}
	}

	// Token: 0x060098F7 RID: 39159 RVA: 0x0021164B File Offset: 0x0020F84B
	private void OnActivitySequenceEmitEvent(string param)
	{
		if (param == "Refresh")
		{
			this.RefreshCellLayout(this.CurSelectRoundData);
			this.PlayFirstTabSequence(this.CurSelectRoundData);
		}
	}

	// Token: 0x060098F8 RID: 39160 RVA: 0x00211674 File Offset: 0x0020F874
	private void OnScratchTicketConditionRefresh()
	{
		List<ScratchTicketRoundData> roundDataList = this.ScratchTicketData.GetRoundDataList();
		this.TabLayout.RefreshByData(roundDataList, null, false);
		this.RefreshTipPanel();
	}

	// Token: 0x060098F9 RID: 39161 RVA: 0x002116A4 File Offset: 0x0020F8A4
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

	// Token: 0x060098FA RID: 39162 RVA: 0x00211708 File Offset: 0x0020F908
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

	// Token: 0x060098FB RID: 39163 RVA: 0x00211798 File Offset: 0x0020F998
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

	// Token: 0x060098FC RID: 39164 RVA: 0x002118D5 File Offset: 0x0020FAD5
	private void PlayShakeSequence()
	{
		TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
		{
			base.PlaySequence("Shake", null, false);
		}, 500f, null, null, true, 1f);
	}

	// Token: 0x060098FD RID: 39165 RVA: 0x002118FC File Offset: 0x0020FAFC
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

	// Token: 0x060098FE RID: 39166 RVA: 0x00211980 File Offset: 0x0020FB80
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

	// Token: 0x060098FF RID: 39167 RVA: 0x002119C7 File Offset: 0x0020FBC7
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

	// Token: 0x06009900 RID: 39168 RVA: 0x002119FC File Offset: 0x0020FBFC
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

	// Token: 0x06009901 RID: 39169 RVA: 0x00211A40 File Offset: 0x0020FC40
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

	// Token: 0x06009902 RID: 39170 RVA: 0x00211A94 File Offset: 0x0020FC94
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

	// Token: 0x06009903 RID: 39171 RVA: 0x00211B10 File Offset: 0x0020FD10
	private void OnClickCloseBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x06009904 RID: 39172 RVA: 0x00211B19 File Offset: 0x0020FD19
	private void OnClickHelpBtn()
	{
		HelpController.Instance.OpenHelpById(this.ScratchTicketData.GetHelpId());
	}

	// Token: 0x06009905 RID: 39173 RVA: 0x00211B30 File Offset: 0x0020FD30
	private ScratchTicketTabItem CreateRoundTabItem()
	{
		ScratchTicketTabItem scratchTicketTabItem = new ScratchTicketTabItem();
		scratchTicketTabItem.SetClickToggleCallback(new Action<ScratchTicketRoundData, ScratchTicketTabItem>(this.OnClickRoundTabItem));
		return scratchTicketTabItem;
	}

	// Token: 0x06009906 RID: 39174 RVA: 0x00211B49 File Offset: 0x0020FD49
	private ScratchTicketCellItem CreateCellItem()
	{
		ScratchTicketCellItem scratchTicketCellItem = new ScratchTicketCellItem();
		scratchTicketCellItem.SetClickCallback(new Action<ScratchTicketCellData>(this.OnClickCellItem));
		return scratchTicketCellItem;
	}

	// Token: 0x06009907 RID: 39175 RVA: 0x00211B62 File Offset: 0x0020FD62
	public ScratchTicketRewardItemGrid CreateRewardGridItem()
	{
		return new ScratchTicketRewardItemGrid();
	}

	// Token: 0x04004347 RID: 17223
	[Nullable(2)]
	private ActivityTitleTypeA TitleItem;

	// Token: 0x04004348 RID: 17224
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x04004349 RID: 17225
	[Nullable(2)]
	private ActivityFunctionalTypeA FunctionalItem;

	// Token: 0x0400434A RID: 17226
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<ScratchTicketConditionItem, ScratchTicketConditionData> ConditionLayout;

	// Token: 0x0400434B RID: 17227
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<ScratchTicketTabItem, ScratchTicketRoundData> TabLayout;

	// Token: 0x0400434C RID: 17228
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<ScratchTicketCellItem, ScratchTicketCellData> CellLayout;

	// Token: 0x0400434D RID: 17229
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<ScratchTicketRewardItemGrid, TItem> RewardLayout;

	// Token: 0x0400434E RID: 17230
	[Nullable(2)]
	private ScratchTicketData ScratchTicketData;

	// Token: 0x0400434F RID: 17231
	[Nullable(2)]
	private ScratchTicketTabItem CurSelectRoundTabItem;

	// Token: 0x04004350 RID: 17232
	[Nullable(2)]
	private ScratchTicketRoundData CurSelectRoundData;

	// Token: 0x04004351 RID: 17233
	[Nullable(2)]
	private TimerHandle TimerHandle;

	// Token: 0x04004352 RID: 17234
	[Nullable(2)]
	private TimerHandle RevealTimerHandle;

	// Token: 0x04004353 RID: 17235
	private float TickTime = (float)TimeUtil.Instance.InverseMillisecond;

	// Token: 0x04004354 RID: 17236
	private readonly Func<ScratchTicketConditionItem> CreateConditionItem = () => new ScratchTicketConditionItem();

	// Token: 0x02007B2A RID: 31530
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x0402881C RID: 165916
		public const int TitleItem = 0;

		// Token: 0x0402881D RID: 165917
		public const int FunctionItem = 1;

		// Token: 0x0402881E RID: 165918
		public const int ScratchTicketRootItem = 2;

		// Token: 0x0402881F RID: 165919
		public const int ScratchTicketConditionLayout = 3;

		// Token: 0x04028820 RID: 165920
		public const int ScratchTicketTabLayout = 4;

		// Token: 0x04028821 RID: 165921
		public const int ScratchTicketCellLayout = 5;

		// Token: 0x04028822 RID: 165922
		public const int CaptionItem = 6;

		// Token: 0x04028823 RID: 165923
		public const int RewardLayout = 7;

		// Token: 0x04028824 RID: 165924
		public const int EmptyItem = 8;

		// Token: 0x04028825 RID: 165925
		public const int RoundSprite = 9;

		// Token: 0x04028826 RID: 165926
		public const int ScratchTicketConditionRoot = 10;
	}
}
