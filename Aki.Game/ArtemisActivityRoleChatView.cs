using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200059F RID: 1439
[NullableContext(1)]
[Nullable(0)]
public class ArtemisActivityRoleChatView : UiViewBase
{
	// Token: 0x06004461 RID: 17505 RVA: 0x001789EA File Offset: 0x00176BEA
	public ArtemisActivityRoleChatView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06004462 RID: 17506 RVA: 0x001789F4 File Offset: 0x00176BF4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIArtText)),
			new ValueTuple<int, Type>(2, typeof(UUIArtText)),
			new ValueTuple<int, Type>(3, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUITexture)),
			new ValueTuple<int, Type>(7, typeof(UUIText))
		};
	}

	// Token: 0x06004463 RID: 17507 RVA: 0x00178ABC File Offset: 0x00176CBC
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnArtemisStateRefresh, new Action(this.OnStateRefresh));
		EventSystem.Instance.Add(EEventName.OnCloseRewardView, new Action(this.OnCloseRewardView));
	}

	// Token: 0x06004464 RID: 17508 RVA: 0x00178AF6 File Offset: 0x00176CF6
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnArtemisStateRefresh, new Action(this.OnStateRefresh));
		EventSystem.Instance.Remove(EEventName.OnCloseRewardView, new Action(this.OnCloseRewardView));
	}

	// Token: 0x06004465 RID: 17509 RVA: 0x00178B30 File Offset: 0x00176D30
	private void OnStateRefresh()
	{
		this.UpdateShowDayContent(ArtemisActivityController.Instance.CurrentDayIndex);
		this.RefreshDayTabsState();
	}

	// Token: 0x06004466 RID: 17510 RVA: 0x00178B48 File Offset: 0x00176D48
	protected override UniTask OnBeforeStartAsync()
	{
		ArtemisActivityRoleChatView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ArtemisActivityRoleChatView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06004467 RID: 17511 RVA: 0x00178B8B File Offset: 0x00176D8B
	protected override void OnBeforeShow()
	{
		this.RefreshDays();
		this.UpdateShowDayContent(ArtemisActivityController.Instance.CurrentDayIndex);
		this.SetCurrentContentBg(ArtemisActivityController.Instance.CurrentDayIndex + 1);
	}

	// Token: 0x06004468 RID: 17512 RVA: 0x00178BB5 File Offset: 0x00176DB5
	protected override void OnBeforeDestroy()
	{
		AUIBaseActor rootActor = this.RootActor;
		if (rootActor == null)
		{
			return;
		}
		rootActor.OnSequencePlayEvent.Unbind();
	}

	// Token: 0x06004469 RID: 17513 RVA: 0x00178BCC File Offset: 0x00176DCC
	private void OnPlaySequenceEvent(string sequenceName, string eventName)
	{
		if (eventName == "Dele_M")
		{
			UiLayer.Instance.SetShowMaskLayer(EUiViewName.ArtemisActivityRoleChatView, false);
		}
	}

	// Token: 0x0600446A RID: 17514 RVA: 0x00178BF0 File Offset: 0x00176DF0
	private void InitCaption()
	{
		UUIItem item = base.GetItem(0);
		if (item != null)
		{
			this.CaptionItem = new PopupCaptionItem(item);
			this.CaptionItem.SetCloseCallBack(delegate
			{
				base.CloseMe(null);
			});
			this.CaptionItem.SetTitle(this.ArtemisData.GetTitle());
		}
	}

	// Token: 0x0600446B RID: 17515 RVA: 0x00178C44 File Offset: 0x00176E44
	private void InitDaysScrollView()
	{
		if (this.DaysScroll != null)
		{
			return;
		}
		UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(3);
		if (scrollViewWithScrollbar != null)
		{
			this.DaysScroll = new GenericScrollViewNew<ArtemisDaysItem, IArtemisDayItemData>(scrollViewWithScrollbar, new Func<ArtemisDaysItem>(this.CreateDaysItem), null, false, null);
		}
	}

	// Token: 0x0600446C RID: 17516 RVA: 0x00178C80 File Offset: 0x00176E80
	private ArtemisDaysItem CreateDaysItem()
	{
		ArtemisDaysItem artemisDaysItem = new ArtemisDaysItem();
		artemisDaysItem.SetClickCallback(new Action<int>(this.OnDayItemClick));
		return artemisDaysItem;
	}

	// Token: 0x0600446D RID: 17517 RVA: 0x00178C99 File Offset: 0x00176E99
	private void RefreshDays()
	{
		this.RefreshDayTabsState();
	}

	// Token: 0x0600446E RID: 17518 RVA: 0x00178CA4 File Offset: 0x00176EA4
	private void RefreshDayTabsState()
	{
		ArtemisActivityConfig instance = ArtemisActivityConfig.Instance;
		IReadOnlyList<Artemis> readOnlyList = (instance != null) ? instance.GetArtemisGroupByActivityId(this.ArtemisData.GetCacheActivityId) : null;
		if (readOnlyList == null || readOnlyList.Count == 0 || this.DaysScroll == null)
		{
			return;
		}
		List<IArtemisDayItemData> list = new List<IArtemisDayItemData>();
		foreach (Artemis artemis in readOnlyList)
		{
			ArtemisDayItemData artemisDayItemData = new ArtemisDayItemData();
			artemisDayItemData.Index = artemis.OpenDay;
			ArtemisActivityData artemisData = this.ArtemisData;
			artemisDayItemData.State = ((artemisData != null) ? artemisData.GetArtemisStatus(artemis.OpenDay) : null);
			ArtemisDayItemData item = artemisDayItemData;
			list.Add(item);
		}
		GenericScrollViewNew<ArtemisDaysItem, IArtemisDayItemData> daysScroll = this.DaysScroll;
		if (daysScroll == null)
		{
			return;
		}
		daysScroll.RefreshByData(list, delegate
		{
			GenericScrollViewNew<ArtemisDaysItem, IArtemisDayItemData> daysScroll2 = this.DaysScroll;
			UUIItem uuiitem = (daysScroll2 != null) ? daysScroll2.GetItemByIndex(ArtemisActivityController.Instance.CurrentDayIndex) : null;
			if (uuiitem != null)
			{
				GenericScrollViewNew<ArtemisDaysItem, IArtemisDayItemData> daysScroll3 = this.DaysScroll;
				if (daysScroll3 == null)
				{
					return;
				}
				daysScroll3.LateScrollTo(uuiitem, null, false);
			}
		}, false);
	}

	// Token: 0x0600446F RID: 17519 RVA: 0x00178D80 File Offset: 0x00176F80
	private void OnDayItemClick(int index)
	{
		if (!this.CheckUnlockDayItem(index))
		{
			return;
		}
		if (ArtemisActivityController.Instance.CurrentDayIndex != index)
		{
			ArtemisActivityController.Instance.CurrentDayIndex = index;
			this.UpdateShowDayContent(index);
			this.SetCurrentContentBg(index + 1);
		}
		this.RefreshDayTabsState();
	}

	// Token: 0x06004470 RID: 17520 RVA: 0x00178DBC File Offset: 0x00176FBC
	private void SetCurrentContentBg(int index)
	{
		UiResourceConfig instance = UiResourceConfig.Instance;
		string text;
		if (instance == null)
		{
			text = null;
		}
		else
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 1);
			defaultInterpolatedStringHandler.AppendLiteral("T_ChatBallBg_");
			defaultInterpolatedStringHandler.AppendFormatted<int>(index);
			text = instance.GetResourcePath(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		string path = text;
		base.TrySetTextureByPath(path, base.GetTexture(6), null, null);
	}

	// Token: 0x06004471 RID: 17521 RVA: 0x00178E18 File Offset: 0x00177018
	private bool CheckUnlockDayItem(int index)
	{
		ArtemisActivityData artemisData = this.ArtemisData;
		EArtemisState? eartemisState = (artemisData != null) ? artemisData.GetArtemisStatus(index) : null;
		EArtemisState eartemisState2 = EArtemisState.Lock;
		if (!(eartemisState.GetValueOrDefault() == eartemisState2 & eartemisState != null))
		{
			return true;
		}
		ArtemisActivityData artemisData2 = this.ArtemisData;
		int num = (artemisData2 != null) ? artemisData2.GetUnlockIndex : 0;
		ArtemisActivityData artemisData3 = this.ArtemisData;
		int num2 = (artemisData3 != null) ? artemisData3.GetRewardedIndex : 0;
		if (index > num2 && index < num)
		{
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew("Activity_ArtemisChatLockedTips_1", null);
			ScrollingTipsController.Instance.ShowTipsByText(localTextNew);
			return false;
		}
		string localTextNew2 = ConfigMultiTextLang.GetLocalTextNew("Activity_ArtemisChatLockedTips_2", null);
		ScrollingTipsController.Instance.ShowTipsByText(localTextNew2);
		return false;
	}

	// Token: 0x06004472 RID: 17522 RVA: 0x00178EBC File Offset: 0x001770BC
	private void UpdateShowDayContent(int index)
	{
		GenericScrollViewNew<ArtemisDaysItem, IArtemisDayItemData> daysScroll = this.DaysScroll;
		if (daysScroll != null)
		{
			daysScroll.SelectGridProxy(index, false);
		}
		this.SwitchChatContent(index);
		this.SetUnlockDayLogEvent();
	}

	// Token: 0x06004473 RID: 17523 RVA: 0x00178EE0 File Offset: 0x001770E0
	private void SwitchChatContent(int index)
	{
		if (index < 0)
		{
			return;
		}
		this.SetTitleCurrentDayIndex();
		ArtemisActivityData artemisData = this.ArtemisData;
		EArtemisState? eartemisState = (artemisData != null) ? artemisData.GetArtemisStatus(index) : null;
		if (eartemisState != null)
		{
			EArtemisState valueOrDefault = eartemisState.GetValueOrDefault();
			if (valueOrDefault != EArtemisState.Unlock)
			{
				if (valueOrDefault != EArtemisState.Rewarded)
				{
					return;
				}
				ArtemisDialogueBoxPanel dialoguePanel = this.DialoguePanel;
				if (dialoguePanel != null)
				{
					dialoguePanel.SetShowRewardItems(true);
				}
				ArtemisActivityConfig instance = ArtemisActivityConfig.Instance;
				ArtemisActivityData artemisData2 = this.ArtemisData;
				Artemis? artemisByActivityIdAndDay = instance.GetArtemisByActivityIdAndDay((artemisData2 != null) ? artemisData2.GetCacheActivityId : 0, index);
				List<TItem> list = (artemisByActivityIdAndDay != null) ? this.GetRewardItem(artemisByActivityIdAndDay.Value.DropId) : new List<TItem>();
				ArtemisDialogueBoxPanel dialoguePanel2 = this.DialoguePanel;
				if (dialoguePanel2 != null)
				{
					dialoguePanel2.SetRewardItems(list ?? new List<TItem>(), true);
				}
				ArtemisDialogueBoxPanel dialoguePanel3 = this.DialoguePanel;
				if (dialoguePanel3 != null)
				{
					dialoguePanel3.ScrollToTop(false);
				}
				bool isLockStatus = false;
				bool isShowEffect = false;
				ArtemisActivityData artemisData3 = this.ArtemisData;
				this.ShowDialogue(isLockStatus, isShowEffect, (artemisData3 != null) ? artemisData3.GetCacheActivityId : 0, index);
			}
			else
			{
				ArtemisDialogueBoxPanel dialoguePanel4 = this.DialoguePanel;
				if (dialoguePanel4 != null)
				{
					dialoguePanel4.SetShowRewardItems(false);
				}
				ArtemisDialogueBoxPanel dialoguePanel5 = this.DialoguePanel;
				if (dialoguePanel5 != null)
				{
					dialoguePanel5.ScrollToTop(true);
				}
				bool isLockStatus2 = true;
				bool isShowEffect2 = true;
				ArtemisActivityData artemisData4 = this.ArtemisData;
				this.ShowDialogue(isLockStatus2, isShowEffect2, (artemisData4 != null) ? artemisData4.GetCacheActivityId : 0, index);
				if (!this.WaitFixedFinish)
				{
					this.WaitFixedFinish = true;
					int value = ConfigCommonParamById.GetIntConfig("ArtemisWaitFixedTime").Value;
					if (!UiManager.Instance.IsViewOpen(EUiViewName.ArtemisActivityCertificationView))
					{
						UiLayer.Instance.SetShowMaskLayer(EUiViewName.ArtemisActivityRoleChatView, true);
						TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
						{
							UiLayer.Instance.SetShowMaskLayer(EUiViewName.ArtemisActivityRoleChatView, false);
							ArtemisActivityCertificationViewParams param = new ArtemisActivityCertificationViewParams
							{
								IsPlayFixedDone = false,
								Callback = new Action(this.FinishCertificationView)
							};
							UiManager.Instance.OpenView(EUiViewName.ArtemisActivityCertificationView, param, null);
						}, (float)(value * 1000), null, null, true, 1f);
						return;
					}
				}
			}
		}
	}

	// Token: 0x06004474 RID: 17524 RVA: 0x00179090 File Offset: 0x00177290
	private void FinishCertificationView()
	{
		int currentDayIndex = ArtemisActivityController.Instance.CurrentDayIndex;
		ArtemisActivityConfig instance = ArtemisActivityConfig.Instance;
		Artemis? artemis = (instance != null) ? instance.GetArtemisByActivityIdAndDay(this.ArtemisData.GetCacheActivityId, currentDayIndex) : null;
		if (artemis == null)
		{
			return;
		}
		ArtemisQteViewParams param = new ArtemisQteViewParams
		{
			GamePlayId = artemis.Value.QteId,
			Index = currentDayIndex,
			CallBack = new Action(this.FinishFixed)
		};
		UiManager.Instance.OpenView(EUiViewName.ArtemisQteView, param, delegate(bool _, int _)
		{
			UiManager.Instance.CloseView(EUiViewName.ArtemisActivityCertificationView, null);
		});
	}

	// Token: 0x06004475 RID: 17525 RVA: 0x0017913C File Offset: 0x0017733C
	private void FinishFixed()
	{
		ArtemisActivityCertificationViewParams param = new ArtemisActivityCertificationViewParams
		{
			Callback = new Action(this.FinishFixedSuccess),
			IsPlayFixedDone = true
		};
		UiManager.Instance.OpenView(EUiViewName.ArtemisActivityCertificationView, param, null);
	}

	// Token: 0x06004476 RID: 17526 RVA: 0x0017917C File Offset: 0x0017737C
	private void FinishFixedSuccess()
	{
		int currentDayIndex = ArtemisActivityController.Instance.CurrentDayIndex;
		GenericScrollViewNew<ArtemisDaysItem, IArtemisDayItemData> daysScroll = this.DaysScroll;
		ArtemisDaysItem artemisDaysItem = (daysScroll != null) ? daysScroll.GetScrollItemByIndex(currentDayIndex) : null;
		if (artemisDaysItem != null && artemisDaysItem != null)
		{
			artemisDaysItem.LoadMaterial(false);
		}
		ArtemisActivityController.Instance.RequestArtemisStatus(this.ArtemisData, currentDayIndex + 1, delegate(bool isError)
		{
			this.WaitFixedFinish = false;
			if (isError)
			{
				base.CloseMe(null);
			}
		});
	}

	// Token: 0x06004477 RID: 17527 RVA: 0x001791D4 File Offset: 0x001773D4
	private void OnCloseRewardView()
	{
		base.PlaySequence("Fix_Done", null, false);
		ArtemisDialogueBoxPanel dialoguePanel = this.DialoguePanel;
		if (dialoguePanel != null)
		{
			dialoguePanel.PlayFixDoneSequence();
		}
		UiLayer.Instance.SetShowMaskLayer(EUiViewName.ArtemisActivityRoleChatView, true);
	}

	// Token: 0x06004478 RID: 17528 RVA: 0x0017920C File Offset: 0x0017740C
	private void SetTitleCurrentDayIndex()
	{
		UUIArtText artText = base.GetArtText(1);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
		if (artText != null)
		{
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
			defaultInterpolatedStringHandler.AppendLiteral("0");
			defaultInterpolatedStringHandler.AppendFormatted<int>(ArtemisActivityController.Instance.CurrentDayIndex + 1);
			artText.SetText(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		ArtemisActivityConfig instance = ArtemisActivityConfig.Instance;
		IReadOnlyList<Artemis> readOnlyList = (instance != null) ? instance.GetArtemisGroupByActivityId(this.ArtemisData.GetCacheActivityId) : null;
		UUIArtText artText2 = base.GetArtText(2);
		if (artText2 == null)
		{
			return;
		}
		defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 1);
		defaultInterpolatedStringHandler.AppendLiteral("/0");
		defaultInterpolatedStringHandler.AppendFormatted<int>((readOnlyList != null) ? readOnlyList.Count : 0);
		artText2.SetText(defaultInterpolatedStringHandler.ToStringAndClear());
	}

	// Token: 0x06004479 RID: 17529 RVA: 0x001792B8 File Offset: 0x001774B8
	[NullableContext(2)]
	public List<TItem> GetRewardItem(int dropId)
	{
		if (dropId == 0)
		{
			return new List<TItem>();
		}
		CSharpScript.Game.Module.Reward.RewardConfig instance = CSharpScript.Game.Module.Reward.RewardConfig.Instance;
		List<TItem> list = (instance != null) ? instance.GetDropPackagePreviewItemList(dropId) : null;
		if (list == null || list.Count == 0)
		{
			return new List<TItem>();
		}
		return list;
	}

	// Token: 0x0600447A RID: 17530 RVA: 0x001792F3 File Offset: 0x001774F3
	private void SetDialogueUiActive(bool isShow)
	{
		UUIItem item = base.GetItem(5);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(isShow);
	}

	// Token: 0x0600447B RID: 17531 RVA: 0x00179308 File Offset: 0x00177508
	private void ShowDialogue(bool isLockStatus, bool isShowEffect, int activityId, int index)
	{
		this.SetDialogueUiActive(true);
		ArtemisActivityConfig instance = ArtemisActivityConfig.Instance;
		Artemis? artemis = (instance != null) ? instance.GetArtemisByActivityIdAndDay(activityId, index) : null;
		int[] ids = (artemis != null) ? (artemis.Value.GetChatIdsArray() ?? Array.Empty<int>()) : Array.Empty<int>();
		ArtemisDialogueBoxPanel dialoguePanel = this.DialoguePanel;
		if (dialoguePanel == null)
		{
			return;
		}
		dialoguePanel.ShowDialogue(ids, isLockStatus, isShowEffect);
	}

	// Token: 0x0600447C RID: 17532 RVA: 0x00179378 File Offset: 0x00177578
	private void SetUnlockDayLogEvent()
	{
		ArtemisActivityConfig instance = ArtemisActivityConfig.Instance;
		Artemis? artemis = (instance != null) ? instance.GetArtemisByActivityIdAndDay(this.ArtemisData.GetCacheActivityId, ArtemisActivityController.Instance.CurrentDayIndex) : null;
		if (artemis == null)
		{
			return;
		}
		int getCacheActivityId = this.ArtemisData.GetCacheActivityId;
		Dictionary<int, int> dictionary = LocalStorage.GetPlayer<Dictionary<int, int>>(ELocalStoragePlayerKey.FirstUnlockArtemisDayMap, null) ?? new Dictionary<int, int>();
		int num;
		if (dictionary.TryGetValue(getCacheActivityId, out num) && num >= artemis.Value.Id)
		{
			return;
		}
		dictionary[getCacheActivityId] = artemis.Value.Id;
		LocalStorage.SetPlayer<Dictionary<int, int>>(ELocalStoragePlayerKey.FirstUnlockArtemisDayMap, dictionary);
		ArtemisLevelUnlockLogEvent artemisLevelUnlockLogEvent = new ArtemisLevelUnlockLogEvent();
		artemisLevelUnlockLogEvent.i_id = artemis.Value.Id;
		LogReportController.Instance.LogReport(artemisLevelUnlockLogEvent);
	}

	// Token: 0x040034E6 RID: 13542
	protected ArtemisActivityData ArtemisData;

	// Token: 0x040034E7 RID: 13543
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x040034E8 RID: 13544
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<ArtemisDaysItem, IArtemisDayItemData> DaysScroll;

	// Token: 0x040034E9 RID: 13545
	[Nullable(2)]
	private ArtemisDialogueBoxPanel DialoguePanel;

	// Token: 0x040034EA RID: 13546
	private bool WaitFixedFinish;

	// Token: 0x02006840 RID: 26688
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x040225ED RID: 140781
		public const int CaptionItem = 0;

		// Token: 0x040225EE RID: 140782
		public const int ArtisticText1 = 1;

		// Token: 0x040225EF RID: 140783
		public const int ArtisticText2 = 2;

		// Token: 0x040225F0 RID: 140784
		public const int DaysScroll = 3;

		// Token: 0x040225F1 RID: 140785
		public const int DaysItem = 4;

		// Token: 0x040225F2 RID: 140786
		public const int DialogBoxParent = 5;

		// Token: 0x040225F3 RID: 140787
		public const int PlaneTexture = 6;

		// Token: 0x040225F4 RID: 140788
		public const int TitleText = 7;
	}
}
