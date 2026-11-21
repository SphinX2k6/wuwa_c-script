using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PhoneMessage;
using CSharpScript.Game.Module.Plot.PlotView.PlotComponent;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001A2B RID: 6699
[NullableContext(2)]
[Nullable(0)]
public class PhoneSystemChatPanel : UiPanelBase
{
	// Token: 0x060107A1 RID: 67489 RVA: 0x004D1B60 File Offset: 0x004CFD60
	private void OnClickedBtnMask()
	{
		if (this.IsPlaying)
		{
			if (!this.IsInInputtingAnimation)
			{
				return;
			}
			this.IsInInputtingAnimation = false;
			int inputtingAnimationChatIndex = this.InputtingAnimationChatIndex;
			this.InputtingAnimationChatIndex = -1;
			if (inputtingAnimationChatIndex < 0)
			{
				return;
			}
			if (this.ChatMultiTemplateComponent.GetTemplateIndexByDisplayIndex(inputtingAnimationChatIndex) != 0)
			{
				return;
			}
			ISyncGridProxy proxyByDisplayIndex = this.ChatMultiTemplateComponent.GetProxyByDisplayIndex(inputtingAnimationChatIndex);
			if (proxyByDisplayIndex != null)
			{
				PhoneMsgOtherChatItem phoneMsgOtherChatItem = proxyByDisplayIndex as PhoneMsgOtherChatItem;
				if (phoneMsgOtherChatItem != null)
				{
					phoneMsgOtherChatItem.SkipInputtingAnimationTask();
				}
			}
		}
	}

	// Token: 0x1700190C RID: 6412
	// (get) Token: 0x060107A2 RID: 67490 RVA: 0x004D1BC7 File Offset: 0x004CFDC7
	public bool GetIsPlaying
	{
		get
		{
			return this.IsPlaying;
		}
	}

	// Token: 0x060107A3 RID: 67491 RVA: 0x004D1BD0 File Offset: 0x004CFDD0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(5, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(6, typeof(UUITexture)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIItem)),
			new ValueTuple<int, Type>(12, typeof(UUIItem)),
			new ValueTuple<int, Type>(13, typeof(UUIItem)),
			new ValueTuple<int, Type>(14, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(15, typeof(UUITexture)),
			new ValueTuple<int, Type>(16, typeof(UUIItem)),
			new ValueTuple<int, Type>(17, typeof(UUITexture)),
			new ValueTuple<int, Type>(18, typeof(UUISprite)),
			new ValueTuple<int, Type>(19, typeof(UUISprite)),
			new ValueTuple<int, Type>(20, typeof(UUISprite)),
			new ValueTuple<int, Type>(21, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(14, new Action(this.OnClickedBtnMask))
		};
	}

	// Token: 0x060107A4 RID: 67492 RVA: 0x004D1E00 File Offset: 0x004D0000
	protected override void OnStart()
	{
		Dictionary<int, UUIItem> dictionary = new Dictionary<int, UUIItem>
		{
			{
				0,
				base.GetItem(0)
			}
		};
		dictionary[0] = base.GetItem(7);
		dictionary[1] = base.GetItem(8);
		dictionary[2] = base.GetItem(9);
		dictionary[3] = base.GetItem(10);
		dictionary[4] = base.GetItem(11);
		dictionary[5] = base.GetItem(12);
		dictionary[6] = base.GetItem(13);
		dictionary[7] = base.GetItem(10);
		this.ChatMultiTemplateComponent = new MultiTemplateComponent(base.GetVerticalLayout(5).RootUIComp, dictionary);
		base.GetButton(14).RootUIComp.Get().SetUIActive(true);
		EventSystem.Instance.Add(EEventName.OnPhoneMsgChatShowChange, new Action(this.RefreshChatBgShow));
		EventSystem.Instance.Add(EEventName.OnPhoneMsgChatShowChange, new Action(this.RefreshChatThemeShow));
		UUIText text = base.GetText(0);
		text.bGameRichText = true;
		text.richText = true;
		this.VoiceAudioComp = new PhoneMsgAudioComponent();
		this.VoiceAudioComp.Init(new PlotTextAudioComponentContext
		{
			OnAudioStartDelegate = new Action(this.OnVoiceAudioStart),
			OnAudioEndDelegate = new Action(this.OnVoiceAudioEnd),
			OnAudioLoadTimeoutDelegate = new Action(this.OnVoiceAudioLoadTimeout)
		});
		this.ScrollComponent = base.GetScrollViewWithScrollbar(4);
		if (this.ScrollComponent != null)
		{
			this.ScrollComponent.SetCanScroll(true);
			this.ScrollComponent.SetRayCastTargetForScrollView(true);
			this.ScrollComponent.OnScrollViewDownUpCallback.Bind(new Action<ULGUIPointerEventData>(this.OnScrollViewPointerUp));
		}
	}

	// Token: 0x060107A5 RID: 67493 RVA: 0x004D1FB8 File Offset: 0x004D01B8
	protected override void OnBeforeShow()
	{
		this.Ticker = TickSystem.Instance.Add(new Action<float>(this.OnTick), "PhoneSystemChatPanel", ETickingGroup.TG_PrePhysics, true, 0, true);
		base.GetScrollViewWithScrollbar(4).OnLateUpdate.Bind(new Action<float>(this.OnLateTick));
		this.RefreshChatBgShow();
		this.RefreshChatThemeShow();
	}

	// Token: 0x060107A6 RID: 67494 RVA: 0x004D2013 File Offset: 0x004D0213
	protected override void OnBeforeHide()
	{
		this.HandleLastData();
		this.CheckToRemoveTicker();
		base.GetScrollViewWithScrollbar(4).OnLateUpdate.Unbind();
		UUIScrollViewWithScrollbarComponent scrollComponent = this.ScrollComponent;
		if (scrollComponent != null)
		{
			scrollComponent.OnScrollViewDownUpCallback.Unbind();
		}
		this.StopVoice();
	}

	// Token: 0x060107A7 RID: 67495 RVA: 0x004D204F File Offset: 0x004D024F
	public void SetIsBigView(bool isbig)
	{
		this.IsBigView = isbig;
	}

	// Token: 0x060107A8 RID: 67496 RVA: 0x004D2058 File Offset: 0x004D0258
	protected override void OnBeforeDestroy()
	{
		this.Reset();
		EventSystem.Instance.Remove(EEventName.OnPhoneMsgChatShowChange, new Action(this.RefreshChatBgShow));
		EventSystem.Instance.Remove(EEventName.OnPhoneMsgChatShowChange, new Action(this.RefreshChatThemeShow));
		this.CheckToRemoveTicker();
		LevelSequencePlayer levelSequencePlayer = this.title2SeqPlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.Clear();
		}
		this.title2SeqPlayer = null;
	}

	// Token: 0x060107A9 RID: 67497 RVA: 0x004D20C1 File Offset: 0x004D02C1
	private void OnTick(float deltaTime)
	{
		if (this.ReadyToScroll)
		{
			this.ScrollToChatItem(this.NeedScrollToIndex, this.NeedScrollTween);
			this.ReadyToScroll = false;
		}
	}

	// Token: 0x060107AA RID: 67498 RVA: 0x004D20E4 File Offset: 0x004D02E4
	private void OnLateTick(float _)
	{
		if (this.NeedScrollToEndOnLateTick)
		{
			base.GetScrollViewWithScrollbar(4).ScrollToEnd();
			this.NeedScrollToEndOnLateTick = false;
			this.NeedScrollOnNextTick = false;
			this.ReadyToScroll = false;
		}
		if (this.NeedScrollOnNextTick)
		{
			this.ReadyToScroll = true;
			this.NeedScrollOnNextTick = false;
		}
		if (this.NeedCheckAdapt && this.CheckLastItemOutOfContent())
		{
			UUIVerticalLayout verticalLayout = base.GetVerticalLayout(5);
			if (verticalLayout != null)
			{
				verticalLayout.SetHeightFitToChildren(true);
			}
			this.NeedCheckAdapt = false;
		}
	}

	// Token: 0x060107AB RID: 67499 RVA: 0x004D215C File Offset: 0x004D035C
	private bool CompareContentAndViewPort()
	{
		UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(4);
		if (scrollViewWithScrollbar == null || !scrollViewWithScrollbar.IsValid())
		{
			return false;
		}
		UUIVerticalLayout verticalLayout = base.GetVerticalLayout(5);
		TWeakObjectPtr<UUIItem>? tweakObjectPtr = (verticalLayout != null) ? new TWeakObjectPtr<UUIItem>?(verticalLayout.RootUIComp) : null;
		if (tweakObjectPtr == null || tweakObjectPtr == null)
		{
			return false;
		}
		float height = scrollViewWithScrollbar.RootUIComp.Get().GetHeight();
		return tweakObjectPtr.Value.Get().GetHeight() < height;
	}

	// Token: 0x060107AC RID: 67500 RVA: 0x004D21E0 File Offset: 0x004D03E0
	private bool CheckLastItemOutOfContent()
	{
		UUIVerticalLayout verticalLayout = base.GetVerticalLayout(5);
		TWeakObjectPtr<UUIItem>? tweakObjectPtr = (verticalLayout != null) ? new TWeakObjectPtr<UUIItem>?(verticalLayout.RootUIComp) : null;
		if (tweakObjectPtr == null || tweakObjectPtr == null)
		{
			return false;
		}
		MultiTemplateComponent chatMultiTemplateComponent = this.ChatMultiTemplateComponent;
		UUIItem uuiitem = (chatMultiTemplateComponent != null) ? chatMultiTemplateComponent.GetItemByDisplayIndex(this.DisplayedChatScrollViewDataList.Count - 1) : null;
		if (uuiitem == null || !uuiitem.IsValid())
		{
			return false;
		}
		float height = tweakObjectPtr.Value.Get().GetHeight();
		return uuiitem.GetRelativeTransform().GetLocation().Y + uuiitem.GetLocalSpaceBottom() < -height;
	}

	// Token: 0x060107AD RID: 67501 RVA: 0x004D2284 File Offset: 0x004D0484
	private void RefreshChatBgShow()
	{
		int currentUsingChatBgId = PhoneMsgModel.Instance.CurrentUsingChatBgId;
		ChatBg? chatBgConfig = PhoneMsgConfig.Instance.GetChatBgConfig(currentUsingChatBgId);
		if (chatBgConfig != null)
		{
			string chatBgPathBig = chatBgConfig.Value.ChatBgPathBig;
			base.SetTextureByPath(chatBgPathBig, base.GetTexture(6), null, null);
		}
	}

	// Token: 0x060107AE RID: 67502 RVA: 0x004D22DA File Offset: 0x004D04DA
	private void RefreshChatThemeShow()
	{
		this.RefreshByTheme(PhoneMsgModel.Instance.CurrentUsingChatThemeId);
	}

	// Token: 0x060107AF RID: 67503 RVA: 0x004D22EC File Offset: 0x004D04EC
	private bool ShouldShowSignature()
	{
		if (this.DisplayData == null)
		{
			return false;
		}
		ShortMessage? phoneMsgConfig = PhoneMsgConfig.Instance.GetPhoneMsgConfig(this.DisplayData.ShortMsgId);
		if (phoneMsgConfig == null)
		{
			return false;
		}
		ChatPartner? chatPartnerConfigNew = PhoneMsgModel.Instance.GetChatPartnerConfigNew(phoneMsgConfig.Value.WhichChat);
		return chatPartnerConfigNew != null && !chatPartnerConfigNew.Value.IsGroupChat && !string.IsNullOrEmpty(chatPartnerConfigNew.Value.Desc);
	}

	// Token: 0x060107B0 RID: 67504 RVA: 0x004D2374 File Offset: 0x004D0574
	private void RefreshByTheme(int themeId)
	{
		ChatTheme? chatThemeConfig = PhoneMsgConfig.Instance.GetChatThemeConfig(themeId);
		string text = this.IsBigView ? chatThemeConfig.Value.BgTitle2 : chatThemeConfig.Value.BgTitleSmall2;
		string text2 = this.IsBigView ? chatThemeConfig.Value.PrefabTitle2 : chatThemeConfig.Value.PrefabTitleSmall2;
		UUITexture texture = base.GetTexture(17);
		UUIItem item = base.GetItem(21);
		if (text != "" && texture != null)
		{
			base.SetTextureByPath(text, texture, null, null);
			UiPanelBase uiPanelBase = this.title2pre;
			if (uiPanelBase != null)
			{
				uiPanelBase.SetActive(false);
			}
		}
		else if (text2 != "" && item != null)
		{
			if (this.title2prepath != text2)
			{
				UiPanelBase uiPanelBase2 = this.title2pre;
				if (uiPanelBase2 != null)
				{
					uiPanelBase2.Destroy(null);
				}
				this.title2pre = new UiPanelBase();
				this.CreateTitle2AndPlayAsync(text2, item);
				this.title2prepath = text2;
			}
			UiPanelBase uiPanelBase3 = this.title2pre;
			if (uiPanelBase3 != null)
			{
				uiPanelBase3.SetActive(true);
			}
			if (texture != null)
			{
				base.SetTextureByPath(PhoneMsgModel.Instance.GetEmptyTexturePath(), texture, null, null);
			}
		}
		string txtTitle = chatThemeConfig.Value.TxtTitle2;
		UUIText text3 = base.GetText(0);
		if (text3 != null && txtTitle != "")
		{
			text3.SetColor(FColor.FromHex(txtTitle));
		}
		string bgName = chatThemeConfig.Value.BgName;
		UUISprite sprite = base.GetSprite(18);
		if (sprite != null && bgName != "")
		{
			this.SetSpriteByPath(bgName, sprite, false, null, null);
			sprite.SetUIActive(true);
		}
		else
		{
			sprite.SetUIActive(false);
		}
		string bgDescri = chatThemeConfig.Value.BgDescri;
		UUISprite sprite2 = base.GetSprite(19);
		if (sprite2 != null && bgDescri != "")
		{
			this.SetSpriteByPath(bgDescri, sprite2, false, null, null);
			sprite2.SetUIActive(this.ShouldShowSignature());
		}
		else if (sprite2 != null)
		{
			sprite2.SetUIActive(false);
		}
		string txtDescri = chatThemeConfig.Value.TxtDescri;
		UUIText text4 = base.GetText(1);
		if (text4 != null && txtDescri != "")
		{
			text4.SetColor(FColor.FromHex(txtDescri));
		}
		string txtGroup = chatThemeConfig.Value.TxtGroup;
		UUIText text5 = base.GetText(3);
		if (text5 != null && txtGroup != "")
		{
			text5.SetColor(FColor.FromHex(txtGroup));
		}
		string bgGroupChat = chatThemeConfig.Value.BgGroupChat;
		UUISprite sprite3 = base.GetSprite(20);
		if (sprite3 != null && bgGroupChat != "")
		{
			this.SetSpriteByPath(bgGroupChat, sprite3, false, null, null);
		}
	}

	// Token: 0x060107B1 RID: 67505 RVA: 0x004D2658 File Offset: 0x004D0858
	[NullableContext(1)]
	private UniTask CreateTitle2AndPlayAsync(string prefabPath, UUIItem parentItem)
	{
		PhoneSystemChatPanel.<CreateTitle2AndPlayAsync>d__45 <CreateTitle2AndPlayAsync>d__;
		<CreateTitle2AndPlayAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateTitle2AndPlayAsync>d__.<>4__this = this;
		<CreateTitle2AndPlayAsync>d__.prefabPath = prefabPath;
		<CreateTitle2AndPlayAsync>d__.parentItem = parentItem;
		<CreateTitle2AndPlayAsync>d__.<>1__state = -1;
		<CreateTitle2AndPlayAsync>d__.<>t__builder.Start<PhoneSystemChatPanel.<CreateTitle2AndPlayAsync>d__45>(ref <CreateTitle2AndPlayAsync>d__);
		return <CreateTitle2AndPlayAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060107B2 RID: 67506 RVA: 0x004D26AC File Offset: 0x004D08AC
	private void CheckNaviBtnBlankShow()
	{
		if (this.DisplayData.ChatDataList.Count <= 0)
		{
			return;
		}
		if (this.DisplayData.ChatDataList[this.DisplayData.ChatDataList.Count - 1] == null)
		{
			return;
		}
		bool uiactive = !this.DisplayData.IsLastFocusableItem();
		UUIItem item = base.GetItem(16);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(uiactive);
	}

	// Token: 0x060107B3 RID: 67507 RVA: 0x004D2714 File Offset: 0x004D0914
	private void CheckToRemoveTicker()
	{
		if (this.Ticker != null)
		{
			TickSystem.Instance.Remove(this.Ticker.Id);
			this.Ticker = null;
		}
	}

	// Token: 0x060107B4 RID: 67508 RVA: 0x004D273C File Offset: 0x004D093C
	public void UpdateChatDialogData()
	{
		if (this.DisplayData == null)
		{
			return;
		}
		List<PhoneMsgChatData> chatDataList = this.DisplayData.ChatDataList;
		int count = chatDataList.Count;
		for (int i = 0; i < count; i++)
		{
			chatDataList[i].ChatDialogId = this.DisplayData.ChatDialogId;
		}
	}

	// Token: 0x060107B5 RID: 67509 RVA: 0x004D2788 File Offset: 0x004D0988
	public void UpdateChatScrollViewData()
	{
		if (this.DisplayData == null)
		{
			return;
		}
		List<PhoneMsgChatData> chatDataList = this.DisplayData.ChatDataList;
		this.DisplayedChatScrollViewDataList.Clear();
		int readIndex = this.DisplayData.ReadIndex;
		int num = (readIndex < 0) ? readIndex : (chatDataList.Count - 1);
		this.DisplayData.ReadIndex = num;
		if (num < 0)
		{
			return;
		}
		for (int i = 0; i <= num; i++)
		{
			PhoneMsgChatData data = chatDataList[i];
			IMultiTemplateGridData multiTemplateGridData = this.CreateChatData(data);
			if (multiTemplateGridData != null)
			{
				this.DisplayedChatScrollViewDataList.Add(multiTemplateGridData);
			}
		}
		if (this.DisplayData.IsFinished())
		{
			EndLineChatGridData item = new EndLineChatGridData(true);
			this.DisplayedChatScrollViewDataList.Add(item);
		}
	}

	// Token: 0x060107B6 RID: 67510 RVA: 0x004D2834 File Offset: 0x004D0A34
	public void RefreshChatShow()
	{
		this.UpdateChatDialogData();
		this.RefreshChatDialog();
		this.RefreshChatBg();
	}

	// Token: 0x060107B7 RID: 67511 RVA: 0x004D2848 File Offset: 0x004D0A48
	private void RefreshChatDialog()
	{
		if (((this.DisplayData != null) ? this.DisplayData.ChatDialogId : 0) <= 0)
		{
			return;
		}
		this.ShowReadChatContents();
	}

	// Token: 0x060107B8 RID: 67512 RVA: 0x004D286C File Offset: 0x004D0A6C
	private void RefreshChatBg()
	{
		int num = (this.DisplayData != null) ? this.DisplayData.ChatBgId : 0;
		if (num <= 0)
		{
			return;
		}
		ChatBg? chatBgConfig = PhoneMsgConfig.Instance.GetChatBgConfig(num);
		if (chatBgConfig == null)
		{
			return;
		}
		string chatBgPathBig = chatBgConfig.Value.ChatBgPathBig;
		base.SetTextureByPath(chatBgPathBig, base.GetTexture(6), null, null);
	}

	// Token: 0x060107B9 RID: 67513 RVA: 0x004D28D4 File Offset: 0x004D0AD4
	[NullableContext(1)]
	public void RefreshByData(ShortMessageDisplayData displayData)
	{
		if (this.DisplayData != null)
		{
			this.HandleLastData();
		}
		this.Reset();
		this.DisplayData = displayData;
		this.RefreshOtherInfo();
		this.UpdateChatScrollViewData();
		this.ShowReadChatContents();
		UUIVerticalLayout verticalLayout = base.GetVerticalLayout(5);
		if (verticalLayout != null)
		{
			verticalLayout.SetHeightFitToChildren(true);
		}
		this.UpdateProgressToServerAsync(this.DisplayData);
		bool flag = this.DisplayData.IsAllChatRead();
		if (this.DisplayData.ReadIndex < 0 && !flag)
		{
			this.AddMaskEnableTask();
			this.AddAllMessageTasks();
			this.AddMaskDisableTask();
			return;
		}
		this.DisplayData.ReadIndex = this.DisplayData.ChatDataList.Count - 1;
		this.CheckNaviBtnBlankShow();
	}

	// Token: 0x060107BA RID: 67514 RVA: 0x004D2984 File Offset: 0x004D0B84
	private UniTask HandleLastData()
	{
		PhoneSystemChatPanel.<HandleLastData>d__54 <HandleLastData>d__;
		<HandleLastData>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<HandleLastData>d__.<>4__this = this;
		<HandleLastData>d__.<>1__state = -1;
		<HandleLastData>d__.<>t__builder.Start<PhoneSystemChatPanel.<HandleLastData>d__54>(ref <HandleLastData>d__);
		return <HandleLastData>d__.<>t__builder.Task;
	}

	// Token: 0x060107BB RID: 67515 RVA: 0x004D29C8 File Offset: 0x004D0BC8
	public void Reset()
	{
		this.StopVoice();
		base.CancelAllAsyncTask();
		UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(4);
		if (scrollViewWithScrollbar != null)
		{
			scrollViewWithScrollbar.SetCanScroll(true);
		}
		UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar2 = base.GetScrollViewWithScrollbar(4);
		if (scrollViewWithScrollbar2 != null)
		{
			scrollViewWithScrollbar2.SetRayCastTargetForScrollView(true);
		}
		this.IsPlaying = false;
		this.NeedScrollOnNextTick = false;
		this.NeedScrollTween = false;
		this.ReadyToScroll = false;
		this.NeedCheckAdapt = false;
		this.NeedScrollToEndOnLateTick = false;
		this.DisplayedChatScrollViewDataList.Clear();
		MultiTemplateComponent chatMultiTemplateComponent = this.ChatMultiTemplateComponent;
		if (chatMultiTemplateComponent == null)
		{
			return;
		}
		chatMultiTemplateComponent.RefreshByData(this.DisplayedChatScrollViewDataList, false);
	}

	// Token: 0x060107BC RID: 67516 RVA: 0x004D2A54 File Offset: 0x004D0C54
	private void AddAllMessageTasks()
	{
		if (this.DisplayData == null)
		{
			return;
		}
		for (int i = this.DisplayData.ReadIndex + 1; i < this.DisplayData.ChatDataList.Count; i++)
		{
			this.AddShowMessageTask(i);
		}
		bool flag = !this.DisplayData.IsLastOption();
		if (flag)
		{
			this.AddEndLineTask();
		}
		this.AddUpdateProgressTask(this.DisplayData);
		if (flag)
		{
			this.AddExecuteEndCallBackTask();
		}
	}

	// Token: 0x060107BD RID: 67517 RVA: 0x004D2AC4 File Offset: 0x004D0CC4
	private void AddShowMessageTask(int chatIndex)
	{
		if (this.DisplayData == null)
		{
			return;
		}
		PhoneMsgChatData phoneMsgChatData = this.DisplayData.ChatDataList[chatIndex];
		EPhoneMsgContentType chatContentType = phoneMsgChatData.ChatContentType;
		this.AddRefreshReadIndexTask(chatIndex);
		if (chatContentType == EPhoneMsgContentType.Tips && (phoneMsgChatData.ContentType == EChatMsgType.Task || phoneMsgChatData.ContentType == EChatMsgType.Activity || phoneMsgChatData.ContentType == EChatMsgType.ActivityMainView))
		{
			this.AddUpdateProgressTask(this.DisplayData);
		}
		this.AddRefreshChatContentTask(chatIndex);
		switch (chatContentType)
		{
		case EPhoneMsgContentType.Other:
			this.AddShowInputtingAnimationTask(chatIndex);
			this.AddShowSpeakerContentAnimationTask(chatIndex);
			return;
		case EPhoneMsgContentType.Self:
			this.AddShowSpeakerContentAnimationTask(chatIndex);
			return;
		case EPhoneMsgContentType.Tips:
			switch (phoneMsgChatData.ContentType)
			{
			case EChatMsgType.Task:
				this.AddShowTaskAnimationTask(chatIndex);
				return;
			case EChatMsgType.Birthday:
				this.AddShowBirthdayAnimationTask(chatIndex);
				return;
			case EChatMsgType.Reward:
				this.AddShowRewardAnimationTask(chatIndex);
				return;
			case EChatMsgType.Tips:
				this.AddShowSystemTipsAnimationTask(chatIndex);
				return;
			case EChatMsgType.TextOption:
			case EChatMsgType.EmojiOption:
			case EChatMsgType.Voice:
				break;
			case EChatMsgType.Activity:
			case EChatMsgType.ActivityMainView:
				this.AddShowActivityAnimationTask(chatIndex);
				break;
			default:
				return;
			}
			return;
		default:
			return;
		}
	}

	// Token: 0x060107BE RID: 67518 RVA: 0x004D2BB4 File Offset: 0x004D0DB4
	private void RefreshOtherInfo()
	{
		if (this.DisplayData == null)
		{
			return;
		}
		ShortMessage? phoneMsgConfig = PhoneMsgConfig.Instance.GetPhoneMsgConfig(this.DisplayData.ShortMsgId);
		if (phoneMsgConfig == null)
		{
			return;
		}
		int whichChat = phoneMsgConfig.Value.WhichChat;
		ChatPartner? chatPartnerConfigNew = PhoneMsgModel.Instance.GetChatPartnerConfigNew(whichChat);
		if (chatPartnerConfigNew == null)
		{
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), chatPartnerConfigNew.Value.Name, Array.Empty<object>());
		bool isGroupChat = chatPartnerConfigNew.Value.IsGroupChat;
		base.GetText(1).SetUIActive(!isGroupChat);
		base.GetSprite(19).SetUIActive(!isGroupChat);
		base.GetItem(2).SetUIActive(isGroupChat);
		if (isGroupChat)
		{
			base.GetText(3).SetText(chatPartnerConfigNew.Value.PeopleNum.ToString(), true);
		}
		else
		{
			string desc = chatPartnerConfigNew.Value.Desc;
			if (!string.IsNullOrEmpty(desc))
			{
				base.GetText(1).SetUIActive(true);
				LguiUtil.Instance.SetLocalTextNew(base.GetText(1), desc, Array.Empty<object>());
				base.GetSprite(19).SetUIActive(true);
			}
			else
			{
				base.GetText(1).SetUIActive(false);
				base.GetSprite(19).SetUIActive(false);
			}
		}
		this.RefreshChatBg();
	}

	// Token: 0x060107BF RID: 67519 RVA: 0x004D2D14 File Offset: 0x004D0F14
	[NullableContext(1)]
	[return: Nullable(2)]
	private IMultiTemplateGridData CreateChatData(PhoneMsgChatData data)
	{
		switch (data.ChatContentType)
		{
		case EPhoneMsgContentType.Other:
			return new OtherChatGridData(data)
			{
				OnItemClickDelegate = new Action<int>(this.OnChatItemClick)
			};
		case EPhoneMsgContentType.Self:
			return new SelfChatGridData(data)
			{
				OnOptionItemClickDelegate = new Action<int, int>(this.OnOptionItemClick),
				OnItemClickDelegate = new Action<int>(this.OnChatItemClick)
			};
		case EPhoneMsgContentType.Tips:
			switch (data.ContentType)
			{
			case EChatMsgType.Task:
				return new TaskChatGridData(data);
			case EChatMsgType.Birthday:
				return new BirthdayChatGridData(data);
			case EChatMsgType.Reward:
				return new RewardChatGridData(data)
				{
					OnRewardClick = new Action(this.OnRewardClick)
				};
			case EChatMsgType.Tips:
				return new TipsChatGridData(data);
			case EChatMsgType.Activity:
			case EChatMsgType.ActivityMainView:
				return new ActivityChatGridData(data);
			}
			return null;
		default:
			return null;
		}
	}

	// Token: 0x060107C0 RID: 67520 RVA: 0x004D2DF0 File Offset: 0x004D0FF0
	private void OnRewardClick()
	{
		this.AddReceiveRewardTask();
	}

	// Token: 0x060107C1 RID: 67521 RVA: 0x004D2DF8 File Offset: 0x004D0FF8
	private void ShowReadChatContents()
	{
		if (this.ChatMultiTemplateComponent == null)
		{
			return;
		}
		this.ChatMultiTemplateComponent.RefreshByData(this.DisplayedChatScrollViewDataList, false);
		this.NeedScrollToEndOnLateTick = true;
	}

	// Token: 0x060107C2 RID: 67522 RVA: 0x004D2E1C File Offset: 0x004D101C
	private void ScrollToChatItem(int index, bool bTween = true)
	{
		if (this.ChatMultiTemplateComponent == null)
		{
			return;
		}
		UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(4);
		if (scrollViewWithScrollbar == null)
		{
			return;
		}
		UUIItem itemByDisplayIndex = this.ChatMultiTemplateComponent.GetItemByDisplayIndex(index);
		if (itemByDisplayIndex == null)
		{
			return;
		}
		scrollViewWithScrollbar.ScrollTo(itemByDisplayIndex, bTween);
	}

	// Token: 0x060107C3 RID: 67523 RVA: 0x004D2E58 File Offset: 0x004D1058
	private void AddRefreshReadIndexTask(int chatIndex)
	{
		UiAsyncTask task = new UiAsyncTask("ChatPerformance", () => this.RefreshReadIndexAsync(chatIndex), null);
		base.RunAsyncTask(task);
	}

	// Token: 0x060107C4 RID: 67524 RVA: 0x004D2E9C File Offset: 0x004D109C
	private UniTask RefreshReadIndexAsync(int chatIndex)
	{
		ShortMessageDisplayData displayData = this.DisplayData;
		if (displayData.ReadIndex >= displayData.ChatDataList.Count - 1)
		{
			displayData.ReadIndex = displayData.ChatDataList.Count - 1;
			return UniTask.CompletedTask;
		}
		displayData.ReadIndex = chatIndex;
		return UniTask.CompletedTask;
	}

	// Token: 0x060107C5 RID: 67525 RVA: 0x004D2EEC File Offset: 0x004D10EC
	private void AddRefreshChatContentTask(int chatIndex)
	{
		UiAsyncTask task = new UiAsyncTask("ChatPerformance", () => this.RefreshChatContentAsync(chatIndex), null);
		base.RunAsyncTask(task);
	}

	// Token: 0x060107C6 RID: 67526 RVA: 0x004D2F30 File Offset: 0x004D1130
	private UniTask RefreshChatContentAsync(int chatIndex)
	{
		ShortMessageDisplayData displayData = this.DisplayData;
		if (chatIndex > displayData.ChatDataList.Count - 1)
		{
			return UniTask.CompletedTask;
		}
		IMultiTemplateGridData multiTemplateGridData = this.CreateChatData(displayData.ChatDataList[chatIndex]);
		if (multiTemplateGridData == null)
		{
			return UniTask.CompletedTask;
		}
		this.DisplayedChatScrollViewDataList.Add(multiTemplateGridData);
		this.ChatMultiTemplateComponent.AddItem(multiTemplateGridData);
		return UniTask.CompletedTask;
	}

	// Token: 0x060107C7 RID: 67527 RVA: 0x004D2F94 File Offset: 0x004D1194
	private void AddShowInputtingAnimationTask(int chatIndex)
	{
		UiAsyncTask task = null;
		task = new UiAsyncTask("ChatPerformance", () => this.ShowInputtingAnimationAsync(chatIndex), delegate()
		{
			if (task != null)
			{
				this.OnShowInputtingAnimationCanceled(task.Status, chatIndex);
			}
		});
		base.RunAsyncTask(task);
	}

	// Token: 0x060107C8 RID: 67528 RVA: 0x004D2FF4 File Offset: 0x004D11F4
	private UniTask ShowInputtingAnimationAsync(int chatIndex)
	{
		PhoneSystemChatPanel.<ShowInputtingAnimationAsync>d__68 <ShowInputtingAnimationAsync>d__;
		<ShowInputtingAnimationAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ShowInputtingAnimationAsync>d__.<>4__this = this;
		<ShowInputtingAnimationAsync>d__.chatIndex = chatIndex;
		<ShowInputtingAnimationAsync>d__.<>1__state = -1;
		<ShowInputtingAnimationAsync>d__.<>t__builder.Start<PhoneSystemChatPanel.<ShowInputtingAnimationAsync>d__68>(ref <ShowInputtingAnimationAsync>d__);
		return <ShowInputtingAnimationAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060107C9 RID: 67529 RVA: 0x004D3040 File Offset: 0x004D1240
	private void OnShowInputtingAnimationCanceled(EUiAsyncTaskStatus status, int chatIndex)
	{
		this.IsInInputtingAnimation = false;
		this.InputtingAnimationChatIndex = -1;
		if (status != EUiAsyncTaskStatus.Running)
		{
			return;
		}
		if (this.ChatMultiTemplateComponent.GetTemplateIndexByDisplayIndex(chatIndex) != 0)
		{
			return;
		}
		PhoneMsgOtherChatItem phoneMsgOtherChatItem = this.ChatMultiTemplateComponent.GetProxyByDisplayIndex(chatIndex) as PhoneMsgOtherChatItem;
		if (phoneMsgOtherChatItem != null)
		{
			phoneMsgOtherChatItem.StopInputtingAnimation();
		}
		this.StopScrollTweenAnimation();
	}

	// Token: 0x060107CA RID: 67530 RVA: 0x004D3090 File Offset: 0x004D1290
	private void AddShowSpeakerContentAnimationTask(int chatIndex)
	{
		UiAsyncTask task = null;
		task = new UiAsyncTask("ChatPerformance", () => this.ShowSpeakerContentAnimationAsync(chatIndex), delegate()
		{
			if (task != null)
			{
				this.OnShowSpeakerContentAnimationCanceled(task.Status, chatIndex);
			}
		});
		base.RunAsyncTask(task);
	}

	// Token: 0x060107CB RID: 67531 RVA: 0x004D30F0 File Offset: 0x004D12F0
	private UniTask ShowSpeakerContentAnimationAsync(int chatIndex)
	{
		PhoneSystemChatPanel.<ShowSpeakerContentAnimationAsync>d__71 <ShowSpeakerContentAnimationAsync>d__;
		<ShowSpeakerContentAnimationAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ShowSpeakerContentAnimationAsync>d__.<>4__this = this;
		<ShowSpeakerContentAnimationAsync>d__.chatIndex = chatIndex;
		<ShowSpeakerContentAnimationAsync>d__.<>1__state = -1;
		<ShowSpeakerContentAnimationAsync>d__.<>t__builder.Start<PhoneSystemChatPanel.<ShowSpeakerContentAnimationAsync>d__71>(ref <ShowSpeakerContentAnimationAsync>d__);
		return <ShowSpeakerContentAnimationAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060107CC RID: 67532 RVA: 0x004D313C File Offset: 0x004D133C
	private void OnShowSpeakerContentAnimationCanceled(EUiAsyncTaskStatus status, int chatIndex)
	{
		if (status != EUiAsyncTaskStatus.Running)
		{
			return;
		}
		EChatTemplateType templateIndexByDisplayIndex = (EChatTemplateType)this.ChatMultiTemplateComponent.GetTemplateIndexByDisplayIndex(chatIndex);
		if (templateIndexByDisplayIndex != EChatTemplateType.Other && templateIndexByDisplayIndex != EChatTemplateType.Self)
		{
			return;
		}
		PhoneMsgOtherChatItem phoneMsgOtherChatItem = this.ChatMultiTemplateComponent.GetProxyByDisplayIndex(chatIndex) as PhoneMsgOtherChatItem;
		if (phoneMsgOtherChatItem != null)
		{
			phoneMsgOtherChatItem.StopChatContentAnimation();
		}
		this.StopScrollTweenAnimation();
	}

	// Token: 0x060107CD RID: 67533 RVA: 0x004D3184 File Offset: 0x004D1384
	private void AddShowSystemTipsAnimationTask(int chatIndex)
	{
		UiAsyncTask task = null;
		task = new UiAsyncTask("ChatPerformance", () => this.ShowSystemTipsAnimationAsync(chatIndex), delegate()
		{
			if (task != null)
			{
				this.OnShowSystemTipsAnimationCanceled(task.Status, chatIndex);
			}
		});
		base.RunAsyncTask(task);
	}

	// Token: 0x060107CE RID: 67534 RVA: 0x004D31E4 File Offset: 0x004D13E4
	private UniTask ShowSystemTipsAnimationAsync(int chatIndex)
	{
		PhoneSystemChatPanel.<ShowSystemTipsAnimationAsync>d__74 <ShowSystemTipsAnimationAsync>d__;
		<ShowSystemTipsAnimationAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ShowSystemTipsAnimationAsync>d__.<>4__this = this;
		<ShowSystemTipsAnimationAsync>d__.chatIndex = chatIndex;
		<ShowSystemTipsAnimationAsync>d__.<>1__state = -1;
		<ShowSystemTipsAnimationAsync>d__.<>t__builder.Start<PhoneSystemChatPanel.<ShowSystemTipsAnimationAsync>d__74>(ref <ShowSystemTipsAnimationAsync>d__);
		return <ShowSystemTipsAnimationAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060107CF RID: 67535 RVA: 0x004D3230 File Offset: 0x004D1430
	private void OnShowSystemTipsAnimationCanceled(EUiAsyncTaskStatus status, int chatIndex)
	{
		if (status != EUiAsyncTaskStatus.Running)
		{
			return;
		}
		if (this.ChatMultiTemplateComponent.GetTemplateIndexByDisplayIndex(chatIndex) != 2)
		{
			return;
		}
		TipsChatItem tipsChatItem = this.ChatMultiTemplateComponent.GetProxyByDisplayIndex(chatIndex) as TipsChatItem;
		if (tipsChatItem != null)
		{
			tipsChatItem.StopTipsAnimation();
		}
		this.StopScrollTweenAnimation();
	}

	// Token: 0x060107D0 RID: 67536 RVA: 0x004D3274 File Offset: 0x004D1474
	private void AddShowRewardAnimationTask(int chatIndex)
	{
		UiAsyncTask task = null;
		task = new UiAsyncTask("ChatPerformance", () => this.ShowRewardAnimationAsync(chatIndex), delegate()
		{
			if (task != null)
			{
				this.OnShowRewardAnimationCanceled(task.Status, chatIndex);
			}
		});
		base.RunAsyncTask(task);
	}

	// Token: 0x060107D1 RID: 67537 RVA: 0x004D32D4 File Offset: 0x004D14D4
	private UniTask ShowRewardAnimationAsync(int chatIndex)
	{
		PhoneSystemChatPanel.<ShowRewardAnimationAsync>d__77 <ShowRewardAnimationAsync>d__;
		<ShowRewardAnimationAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ShowRewardAnimationAsync>d__.<>4__this = this;
		<ShowRewardAnimationAsync>d__.chatIndex = chatIndex;
		<ShowRewardAnimationAsync>d__.<>1__state = -1;
		<ShowRewardAnimationAsync>d__.<>t__builder.Start<PhoneSystemChatPanel.<ShowRewardAnimationAsync>d__77>(ref <ShowRewardAnimationAsync>d__);
		return <ShowRewardAnimationAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060107D2 RID: 67538 RVA: 0x004D3320 File Offset: 0x004D1520
	private void OnShowRewardAnimationCanceled(EUiAsyncTaskStatus status, int chatIndex)
	{
		if (status != EUiAsyncTaskStatus.Running)
		{
			return;
		}
		if (this.ChatMultiTemplateComponent.GetTemplateIndexByDisplayIndex(chatIndex) != 5)
		{
			return;
		}
		RewardChatItem rewardChatItem = this.ChatMultiTemplateComponent.GetProxyByDisplayIndex(chatIndex) as RewardChatItem;
		if (rewardChatItem != null)
		{
			rewardChatItem.StopRewardAnimation();
		}
		this.StopScrollTweenAnimation();
	}

	// Token: 0x060107D3 RID: 67539 RVA: 0x004D3364 File Offset: 0x004D1564
	private void AddShowBirthdayAnimationTask(int chatIndex)
	{
		UiAsyncTask task = null;
		task = new UiAsyncTask("ChatPerformance", () => this.ShowBirthdayAnimationAsync(chatIndex), delegate()
		{
			if (task != null)
			{
				this.OnShowBirthdayAnimationCanceled(task.Status, chatIndex);
			}
		});
		base.RunAsyncTask(task);
	}

	// Token: 0x060107D4 RID: 67540 RVA: 0x004D33C4 File Offset: 0x004D15C4
	private UniTask ShowBirthdayAnimationAsync(int chatIndex)
	{
		PhoneSystemChatPanel.<ShowBirthdayAnimationAsync>d__80 <ShowBirthdayAnimationAsync>d__;
		<ShowBirthdayAnimationAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ShowBirthdayAnimationAsync>d__.<>4__this = this;
		<ShowBirthdayAnimationAsync>d__.chatIndex = chatIndex;
		<ShowBirthdayAnimationAsync>d__.<>1__state = -1;
		<ShowBirthdayAnimationAsync>d__.<>t__builder.Start<PhoneSystemChatPanel.<ShowBirthdayAnimationAsync>d__80>(ref <ShowBirthdayAnimationAsync>d__);
		return <ShowBirthdayAnimationAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060107D5 RID: 67541 RVA: 0x004D3410 File Offset: 0x004D1610
	private void OnShowBirthdayAnimationCanceled(EUiAsyncTaskStatus status, int chatIndex)
	{
		if (status != EUiAsyncTaskStatus.Running)
		{
			return;
		}
		if (this.ChatMultiTemplateComponent.GetTemplateIndexByDisplayIndex(chatIndex) != 4)
		{
			return;
		}
		BirthdayChatItem birthdayChatItem = this.ChatMultiTemplateComponent.GetProxyByDisplayIndex(chatIndex) as BirthdayChatItem;
		if (birthdayChatItem != null)
		{
			birthdayChatItem.StopBirthdayAnimation();
		}
		this.StopScrollTweenAnimation();
	}

	// Token: 0x060107D6 RID: 67542 RVA: 0x004D3454 File Offset: 0x004D1654
	private void AddShowTaskAnimationTask(int chatIndex)
	{
		UiAsyncTask task = null;
		task = new UiAsyncTask("ChatPerformance", () => this.ShowTaskAnimationAsync(chatIndex), delegate()
		{
			if (task != null)
			{
				this.OnShowTaskAnimationCanceled(task.Status, chatIndex);
			}
		});
		base.RunAsyncTask(task);
	}

	// Token: 0x060107D7 RID: 67543 RVA: 0x004D34B4 File Offset: 0x004D16B4
	private UniTask ShowTaskAnimationAsync(int chatIndex)
	{
		PhoneSystemChatPanel.<ShowTaskAnimationAsync>d__83 <ShowTaskAnimationAsync>d__;
		<ShowTaskAnimationAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ShowTaskAnimationAsync>d__.<>4__this = this;
		<ShowTaskAnimationAsync>d__.chatIndex = chatIndex;
		<ShowTaskAnimationAsync>d__.<>1__state = -1;
		<ShowTaskAnimationAsync>d__.<>t__builder.Start<PhoneSystemChatPanel.<ShowTaskAnimationAsync>d__83>(ref <ShowTaskAnimationAsync>d__);
		return <ShowTaskAnimationAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060107D8 RID: 67544 RVA: 0x004D3500 File Offset: 0x004D1700
	private void OnShowTaskAnimationCanceled(EUiAsyncTaskStatus status, int chatIndex)
	{
		if (status != EUiAsyncTaskStatus.Running)
		{
			return;
		}
		if (this.ChatMultiTemplateComponent.GetTemplateIndexByDisplayIndex(chatIndex) != 3)
		{
			return;
		}
		TaskChatItem taskChatItem = this.ChatMultiTemplateComponent.GetProxyByDisplayIndex(chatIndex) as TaskChatItem;
		if (taskChatItem != null)
		{
			taskChatItem.StopTaskAnimation();
		}
		this.StopScrollTweenAnimation();
	}

	// Token: 0x060107D9 RID: 67545 RVA: 0x004D3544 File Offset: 0x004D1744
	private void AddShowActivityAnimationTask(int chatIndex)
	{
		UiAsyncTask task = null;
		task = new UiAsyncTask("ChatPerformance", () => this.ShowActivityAnimationAsync(chatIndex), delegate()
		{
			if (task != null)
			{
				this.OnShowActivityAnimationCanceled(task.Status, chatIndex);
			}
		});
		base.RunAsyncTask(task);
	}

	// Token: 0x060107DA RID: 67546 RVA: 0x004D35A4 File Offset: 0x004D17A4
	private UniTask ShowActivityAnimationAsync(int chatIndex)
	{
		PhoneSystemChatPanel.<ShowActivityAnimationAsync>d__86 <ShowActivityAnimationAsync>d__;
		<ShowActivityAnimationAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ShowActivityAnimationAsync>d__.<>4__this = this;
		<ShowActivityAnimationAsync>d__.chatIndex = chatIndex;
		<ShowActivityAnimationAsync>d__.<>1__state = -1;
		<ShowActivityAnimationAsync>d__.<>t__builder.Start<PhoneSystemChatPanel.<ShowActivityAnimationAsync>d__86>(ref <ShowActivityAnimationAsync>d__);
		return <ShowActivityAnimationAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060107DB RID: 67547 RVA: 0x004D35F0 File Offset: 0x004D17F0
	private void OnShowActivityAnimationCanceled(EUiAsyncTaskStatus status, int chatIndex)
	{
		if (status != EUiAsyncTaskStatus.Running)
		{
			return;
		}
		if (this.ChatMultiTemplateComponent.GetTemplateIndexByDisplayIndex(chatIndex) != 7)
		{
			return;
		}
		ActivityChatItem activityChatItem = this.ChatMultiTemplateComponent.GetProxyByDisplayIndex(chatIndex) as ActivityChatItem;
		if (activityChatItem != null)
		{
			activityChatItem.StopActivityAnimation();
		}
		this.StopScrollTweenAnimation();
	}

	// Token: 0x060107DC RID: 67548 RVA: 0x004D3634 File Offset: 0x004D1834
	private void AddEndLineTask()
	{
		UiAsyncTask task = null;
		task = new UiAsyncTask("ChatPerformance", new Func<UniTask>(this.ShowEndLineAsync), delegate()
		{
			if (task != null)
			{
				this.OnEndLineCanceled(task.Status);
			}
		});
		base.RunAsyncTask(task);
	}

	// Token: 0x060107DD RID: 67549 RVA: 0x004D368C File Offset: 0x004D188C
	private UniTask ShowEndLineAsync()
	{
		PhoneSystemChatPanel.<ShowEndLineAsync>d__89 <ShowEndLineAsync>d__;
		<ShowEndLineAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ShowEndLineAsync>d__.<>4__this = this;
		<ShowEndLineAsync>d__.<>1__state = -1;
		<ShowEndLineAsync>d__.<>t__builder.Start<PhoneSystemChatPanel.<ShowEndLineAsync>d__89>(ref <ShowEndLineAsync>d__);
		return <ShowEndLineAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060107DE RID: 67550 RVA: 0x004D36CF File Offset: 0x004D18CF
	private void OnEndLineCanceled(EUiAsyncTaskStatus status)
	{
		if (status != EUiAsyncTaskStatus.Running)
		{
			return;
		}
		this.StopScrollTweenAnimation();
	}

	// Token: 0x060107DF RID: 67551 RVA: 0x004D36DC File Offset: 0x004D18DC
	private void AddMaskEnableTask()
	{
		UiAsyncTask task = new UiAsyncTask("ChatPerformance", new Func<UniTask>(this.MaskEnableAsync), delegate()
		{
			this.OnMaskEnableCanceled(EUiAsyncTaskStatus.Running);
		});
		base.RunAsyncTask(task);
	}

	// Token: 0x060107E0 RID: 67552 RVA: 0x004D3714 File Offset: 0x004D1914
	private UniTask MaskEnableAsync()
	{
		UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(4);
		if (scrollViewWithScrollbar != null)
		{
			scrollViewWithScrollbar.SetCanScroll(false);
		}
		UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar2 = base.GetScrollViewWithScrollbar(4);
		if (scrollViewWithScrollbar2 != null)
		{
			scrollViewWithScrollbar2.SetRayCastTargetForScrollView(false);
		}
		this.IsPlaying = true;
		UUIItem item = base.GetItem(16);
		if (item != null)
		{
			item.SetUIActive(true);
		}
		return UniTask.CompletedTask;
	}

	// Token: 0x060107E1 RID: 67553 RVA: 0x004D3767 File Offset: 0x004D1967
	private void OnMaskEnableCanceled(EUiAsyncTaskStatus status)
	{
		UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(4);
		if (scrollViewWithScrollbar != null)
		{
			scrollViewWithScrollbar.SetCanScroll(true);
		}
		UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar2 = base.GetScrollViewWithScrollbar(4);
		if (scrollViewWithScrollbar2 != null)
		{
			scrollViewWithScrollbar2.SetRayCastTargetForScrollView(true);
		}
		this.IsPlaying = false;
	}

	// Token: 0x060107E2 RID: 67554 RVA: 0x004D3798 File Offset: 0x004D1998
	private void AddMaskDisableTask()
	{
		UiAsyncTask task = new UiAsyncTask("ChatPerformance", new Func<UniTask>(this.MaskDisableAsync), delegate()
		{
			this.OnMaskDisableCanceled(EUiAsyncTaskStatus.Running);
		});
		base.RunAsyncTask(task);
	}

	// Token: 0x060107E3 RID: 67555 RVA: 0x004D37D0 File Offset: 0x004D19D0
	private UniTask MaskDisableAsync()
	{
		UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(4);
		if (scrollViewWithScrollbar != null)
		{
			scrollViewWithScrollbar.SetCanScroll(true);
		}
		UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar2 = base.GetScrollViewWithScrollbar(4);
		if (scrollViewWithScrollbar2 != null)
		{
			scrollViewWithScrollbar2.SetRayCastTargetForScrollView(true);
		}
		this.IsPlaying = false;
		this.CheckNaviBtnBlankShow();
		return UniTask.CompletedTask;
	}

	// Token: 0x060107E4 RID: 67556 RVA: 0x004D380A File Offset: 0x004D1A0A
	private void OnMaskDisableCanceled(EUiAsyncTaskStatus status)
	{
		if (status != EUiAsyncTaskStatus.Running)
		{
			return;
		}
		UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(4);
		if (scrollViewWithScrollbar != null)
		{
			scrollViewWithScrollbar.SetCanScroll(true);
		}
		UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar2 = base.GetScrollViewWithScrollbar(4);
		if (scrollViewWithScrollbar2 != null)
		{
			scrollViewWithScrollbar2.SetRayCastTargetForScrollView(true);
		}
		this.IsPlaying = false;
	}

	// Token: 0x060107E5 RID: 67557 RVA: 0x004D3840 File Offset: 0x004D1A40
	[NullableContext(1)]
	private void AddUpdateProgressTask(ShortMessageDisplayData displayData)
	{
		UiAsyncTask task = new UiAsyncTask("ChatPerformance", () => this.UpdateProgressAsync(displayData), null);
		base.RunAsyncTask(task);
	}

	// Token: 0x060107E6 RID: 67558 RVA: 0x004D3881 File Offset: 0x004D1A81
	[NullableContext(1)]
	private UniTask UpdateProgressAsync(ShortMessageDisplayData displayData)
	{
		return this.UpdateProgressToServerAsync(displayData);
	}

	// Token: 0x060107E7 RID: 67559 RVA: 0x004D388C File Offset: 0x004D1A8C
	[NullableContext(1)]
	private UniTask UpdateProgressToServerAsync(ShortMessageDisplayData displayData)
	{
		PhoneSystemChatPanel.<UpdateProgressToServerAsync>d__99 <UpdateProgressToServerAsync>d__;
		<UpdateProgressToServerAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<UpdateProgressToServerAsync>d__.displayData = displayData;
		<UpdateProgressToServerAsync>d__.<>1__state = -1;
		<UpdateProgressToServerAsync>d__.<>t__builder.Start<PhoneSystemChatPanel.<UpdateProgressToServerAsync>d__99>(ref <UpdateProgressToServerAsync>d__);
		return <UpdateProgressToServerAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060107E8 RID: 67560 RVA: 0x004D38D0 File Offset: 0x004D1AD0
	private void AddExecuteEndCallBackTask()
	{
		UiAsyncTask task = new UiAsyncTask("ChatPerformance", new Func<UniTask>(this.ExecuteEndCallBackAsync), null);
		base.RunAsyncTask(task);
	}

	// Token: 0x060107E9 RID: 67561 RVA: 0x004D38FD File Offset: 0x004D1AFD
	private UniTask ExecuteEndCallBackAsync()
	{
		if (this.DisplayData != null)
		{
			Action<int> onMsgReadFinished = this.OnMsgReadFinished;
			if (onMsgReadFinished != null)
			{
				onMsgReadFinished(this.DisplayData.ShortMsgId);
			}
			this.CheckNaviBtnBlankShow();
		}
		return UniTask.CompletedTask;
	}

	// Token: 0x060107EA RID: 67562 RVA: 0x004D3930 File Offset: 0x004D1B30
	private void AddSelectOptionTask(int chatItemIndex, int selectedIndex)
	{
		PhoneSystemChatPanel.<>c__DisplayClass102_0 CS$<>8__locals1 = new PhoneSystemChatPanel.<>c__DisplayClass102_0();
		CS$<>8__locals1.<>4__this = this;
		CS$<>8__locals1.chatItemIndex = chatItemIndex;
		CS$<>8__locals1.selectedIndex = selectedIndex;
		UiAsyncTask task = new UiAsyncTask("ChatPerformance", delegate()
		{
			PhoneSystemChatPanel.<>c__DisplayClass102_0.<<AddSelectOptionTask>b__0>d <<AddSelectOptionTask>b__0>d;
			<<AddSelectOptionTask>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<AddSelectOptionTask>b__0>d.<>4__this = CS$<>8__locals1;
			<<AddSelectOptionTask>b__0>d.<>1__state = -1;
			<<AddSelectOptionTask>b__0>d.<>t__builder.Start<PhoneSystemChatPanel.<>c__DisplayClass102_0.<<AddSelectOptionTask>b__0>d>(ref <<AddSelectOptionTask>b__0>d);
			return <<AddSelectOptionTask>b__0>d.<>t__builder.Task;
		}, null);
		base.RunAsyncTask(task);
	}

	// Token: 0x060107EB RID: 67563 RVA: 0x004D3978 File Offset: 0x004D1B78
	private UniTask SelectOptionAsync(int chatItemIndex, int selectedIndex)
	{
		PhoneSystemChatPanel.<SelectOptionAsync>d__103 <SelectOptionAsync>d__;
		<SelectOptionAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<SelectOptionAsync>d__.<>4__this = this;
		<SelectOptionAsync>d__.chatItemIndex = chatItemIndex;
		<SelectOptionAsync>d__.selectedIndex = selectedIndex;
		<SelectOptionAsync>d__.<>1__state = -1;
		<SelectOptionAsync>d__.<>t__builder.Start<PhoneSystemChatPanel.<SelectOptionAsync>d__103>(ref <SelectOptionAsync>d__);
		return <SelectOptionAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060107EC RID: 67564 RVA: 0x004D39CC File Offset: 0x004D1BCC
	private void AddAnswerItemHideOptionTask(int chatItemIndex)
	{
		UiAsyncTask task = null;
		task = new UiAsyncTask("ChatPerformance", () => this.AnswerItemHideOptionAsync(chatItemIndex), delegate()
		{
			if (task != null)
			{
				this.OnAnswerItemHideOptionCanceled(task.Status, chatItemIndex);
			}
		});
		base.RunAsyncTask(task);
	}

	// Token: 0x060107ED RID: 67565 RVA: 0x004D3A2C File Offset: 0x004D1C2C
	private UniTask AnswerItemHideOptionAsync(int chatItemIndex)
	{
		PhoneSystemChatPanel.<AnswerItemHideOptionAsync>d__105 <AnswerItemHideOptionAsync>d__;
		<AnswerItemHideOptionAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<AnswerItemHideOptionAsync>d__.<>4__this = this;
		<AnswerItemHideOptionAsync>d__.chatItemIndex = chatItemIndex;
		<AnswerItemHideOptionAsync>d__.<>1__state = -1;
		<AnswerItemHideOptionAsync>d__.<>t__builder.Start<PhoneSystemChatPanel.<AnswerItemHideOptionAsync>d__105>(ref <AnswerItemHideOptionAsync>d__);
		return <AnswerItemHideOptionAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060107EE RID: 67566 RVA: 0x004D3A78 File Offset: 0x004D1C78
	private void OnAnswerItemHideOptionCanceled(EUiAsyncTaskStatus status, int chatItemIndex)
	{
		if (status != EUiAsyncTaskStatus.Running)
		{
			return;
		}
		PhoneMsgSelfChatItem phoneMsgSelfChatItem = this.ChatMultiTemplateComponent.GetProxyByDisplayIndex(chatItemIndex) as PhoneMsgSelfChatItem;
		if (phoneMsgSelfChatItem != null)
		{
			phoneMsgSelfChatItem.StopOptionHideAnimation();
		}
		this.NeedCheckAdapt = false;
		UUIVerticalLayout verticalLayout = base.GetVerticalLayout(5);
		if (verticalLayout == null)
		{
			return;
		}
		verticalLayout.SetHeightFitToChildren(true);
	}

	// Token: 0x060107EF RID: 67567 RVA: 0x004D3AC0 File Offset: 0x004D1CC0
	private void AddAnswerItemShowChatContentTask(int chatItemIndex)
	{
		UiAsyncTask task = null;
		task = new UiAsyncTask("ChatPerformance", () => this.AnswerItemShowChatContentAsync(chatItemIndex), delegate()
		{
			if (task != null)
			{
				this.OnAnswerItemShowChatContentCanceled(task.Status, chatItemIndex);
			}
		});
		base.RunAsyncTask(task);
	}

	// Token: 0x060107F0 RID: 67568 RVA: 0x004D3B20 File Offset: 0x004D1D20
	private UniTask AnswerItemShowChatContentAsync(int chatItemIndex)
	{
		PhoneSystemChatPanel.<AnswerItemShowChatContentAsync>d__108 <AnswerItemShowChatContentAsync>d__;
		<AnswerItemShowChatContentAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<AnswerItemShowChatContentAsync>d__.<>4__this = this;
		<AnswerItemShowChatContentAsync>d__.chatItemIndex = chatItemIndex;
		<AnswerItemShowChatContentAsync>d__.<>1__state = -1;
		<AnswerItemShowChatContentAsync>d__.<>t__builder.Start<PhoneSystemChatPanel.<AnswerItemShowChatContentAsync>d__108>(ref <AnswerItemShowChatContentAsync>d__);
		return <AnswerItemShowChatContentAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060107F1 RID: 67569 RVA: 0x004D3B6C File Offset: 0x004D1D6C
	private void OnAnswerItemShowChatContentCanceled(EUiAsyncTaskStatus status, int chatItemIndex)
	{
		if (status != EUiAsyncTaskStatus.Running)
		{
			return;
		}
		PhoneMsgSelfChatItem phoneMsgSelfChatItem = this.ChatMultiTemplateComponent.GetProxyByDisplayIndex(chatItemIndex) as PhoneMsgSelfChatItem;
		if (phoneMsgSelfChatItem == null)
		{
			return;
		}
		phoneMsgSelfChatItem.StopChatContentAnimation(true);
	}

	// Token: 0x060107F2 RID: 67570 RVA: 0x004D3B9C File Offset: 0x004D1D9C
	private void AddAfterAnswerTask(int chatItemIndex)
	{
		UiAsyncTask task = null;
		task = new UiAsyncTask("ChatPerformance", () => this.AfterAnswerAsync(chatItemIndex), delegate()
		{
			if (task != null)
			{
				this.OnAfterAnswerCanceled(task.Status, chatItemIndex);
			}
		});
		base.RunAsyncTask(task);
	}

	// Token: 0x060107F3 RID: 67571 RVA: 0x004D3BF9 File Offset: 0x004D1DF9
	private UniTask AfterAnswerAsync(int chatItemIndex)
	{
		this.AddAnswerItemHideOptionTask(chatItemIndex);
		this.AddAnswerItemShowChatContentTask(chatItemIndex);
		this.AddAllMessageTasks();
		this.AddMaskDisableTask();
		return UniTask.CompletedTask;
	}

	// Token: 0x060107F4 RID: 67572 RVA: 0x004D3C1A File Offset: 0x004D1E1A
	private void OnAfterAnswerCanceled(EUiAsyncTaskStatus status, int chatItemIndex)
	{
		if (status != EUiAsyncTaskStatus.Running)
		{
			return;
		}
		base.CancelAllAsyncTask();
	}

	// Token: 0x060107F5 RID: 67573 RVA: 0x004D3C28 File Offset: 0x004D1E28
	private void AddReceiveRewardTask()
	{
		UiAsyncTask task = new UiAsyncTask("ChatPerformance", new Func<UniTask>(this.ReceiveRewardAsync), null);
		base.RunAsyncTask(task);
	}

	// Token: 0x060107F6 RID: 67574 RVA: 0x004D3C58 File Offset: 0x004D1E58
	private UniTask ReceiveRewardAsync()
	{
		PhoneSystemChatPanel.<ReceiveRewardAsync>d__114 <ReceiveRewardAsync>d__;
		<ReceiveRewardAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ReceiveRewardAsync>d__.<>4__this = this;
		<ReceiveRewardAsync>d__.<>1__state = -1;
		<ReceiveRewardAsync>d__.<>t__builder.Start<PhoneSystemChatPanel.<ReceiveRewardAsync>d__114>(ref <ReceiveRewardAsync>d__);
		return <ReceiveRewardAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060107F7 RID: 67575 RVA: 0x004D3C9C File Offset: 0x004D1E9C
	private UniTask PlayScrollTweenAnimationAsync()
	{
		PhoneSystemChatPanel.<PlayScrollTweenAnimationAsync>d__115 <PlayScrollTweenAnimationAsync>d__;
		<PlayScrollTweenAnimationAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayScrollTweenAnimationAsync>d__.<>4__this = this;
		<PlayScrollTweenAnimationAsync>d__.<>1__state = -1;
		<PlayScrollTweenAnimationAsync>d__.<>t__builder.Start<PhoneSystemChatPanel.<PlayScrollTweenAnimationAsync>d__115>(ref <PlayScrollTweenAnimationAsync>d__);
		return <PlayScrollTweenAnimationAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060107F8 RID: 67576 RVA: 0x004D3CE0 File Offset: 0x004D1EE0
	private void SkipPlayScrollTweenAnimation()
	{
		this.StopScrollTweenAnimation();
		this.ScrollToChatItem(this.DisplayedChatScrollViewDataList.Count - 1, false);
		if (this.ScrollTweenCustomPromise != null)
		{
			this.ScrollTweenCustomPromise.SetResult(true);
		}
		if (this.ScrollTweenHandle != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.ScrollTweenHandle);
		}
		this.ScrollTweenHandle = null;
	}

	// Token: 0x060107F9 RID: 67577 RVA: 0x004D3D3B File Offset: 0x004D1F3B
	private void StopScrollTweenAnimation()
	{
		this.NeedScrollTween = false;
		this.NeedScrollOnNextTick = false;
		base.GetScrollViewWithScrollbar(4).StopMovement();
	}

	// Token: 0x060107FA RID: 67578 RVA: 0x004D3D57 File Offset: 0x004D1F57
	private void OnOptionItemClick(int chatItemIndex, int selectedIndex)
	{
		if (this.IsPlaying)
		{
			return;
		}
		if (this.DisplayData.ChatDataList[chatItemIndex] == null)
		{
			return;
		}
		this.AddMaskEnableTask();
		this.AddSelectOptionTask(chatItemIndex, selectedIndex);
		this.AddAfterAnswerTask(chatItemIndex);
	}

	// Token: 0x060107FB RID: 67579 RVA: 0x004D3D8C File Offset: 0x004D1F8C
	public void LogReport(int shortMessageId, int viewType)
	{
		PhoneMsgConfig instance = PhoneMsgConfig.Instance;
		PhoneMsgModel instance2 = PhoneMsgModel.Instance;
		ShortMessage? phoneMsgConfig = instance.GetPhoneMsgConfig(shortMessageId);
		if (phoneMsgConfig == null)
		{
			return;
		}
		int whichChat = phoneMsgConfig.Value.WhichChat;
		ChatPartner? chatPartnerConfigNew = instance2.GetChatPartnerConfigNew(whichChat);
		PhoneMsgShortMsgData phoneMsgShortMsgDataByShortMsgId = instance2.GetPhoneMsgShortMsgDataByShortMsgId(shortMessageId);
		if (phoneMsgShortMsgDataByShortMsgId == null)
		{
			return;
		}
		OnSelectShortMessageLogEvent onSelectShortMessageLogEvent = new OnSelectShortMessageLogEvent();
		onSelectShortMessageLogEvent.i_id = shortMessageId;
		onSelectShortMessageLogEvent.i_type = ((chatPartnerConfigNew != null && chatPartnerConfigNew.Value.IsGroupChat) ? 1 : 2);
		onSelectShortMessageLogEvent.i_reason = viewType;
		onSelectShortMessageLogEvent.l_received_time = (long)((int)phoneMsgShortMsgDataByShortMsgId.UnLockTime);
		onSelectShortMessageLogEvent.i_role_id = phoneMsgConfig.Value.WhichChat;
		LogReportController.Instance.LogReport(onSelectShortMessageLogEvent);
	}

	// Token: 0x060107FC RID: 67580 RVA: 0x004D3E4C File Offset: 0x004D204C
	private void OnChatItemClick(int chatItemIndex)
	{
		PhoneMsgChatData phoneMsgChatData = this.DisplayData.ChatDataList[chatItemIndex];
		if (phoneMsgChatData == null)
		{
			return;
		}
		if (phoneMsgChatData.ContentType == EChatMsgType.Voice)
		{
			this.OnVoiceChatItemClick(chatItemIndex);
		}
	}

	// Token: 0x060107FD RID: 67581 RVA: 0x004D3E80 File Offset: 0x004D2080
	private void SetPlayerState(EFavorPlayerStatus playerStatus)
	{
		this.CurPlayerStatus = playerStatus;
	}

	// Token: 0x060107FE RID: 67582 RVA: 0x004D3E8C File Offset: 0x004D208C
	private void PlayVoice(int index)
	{
		if (!this.IsPlaying)
		{
			this.NeedScrollOnNextTick = true;
			this.NeedScrollToIndex = index;
			this.NeedScrollTween = true;
		}
		PhoneMsgChatData phoneMsgChatData = this.DisplayData.ChatDataList[index];
		PhoneMsgAudioComponent voiceAudioComp = this.VoiceAudioComp;
		if (voiceAudioComp != null)
		{
			voiceAudioComp.StopAudio();
		}
		PhoneMsgAudioComponent voiceAudioComp2 = this.VoiceAudioComp;
		if (voiceAudioComp2 != null)
		{
			voiceAudioComp2.TryPlayPhoneMessageVoice(phoneMsgChatData.TalkItem);
		}
		this.SetPlayerState(EFavorPlayerStatus.Play);
		this.CurPlayingVoiceItemIndex = index;
	}

	// Token: 0x060107FF RID: 67583 RVA: 0x004D3EFF File Offset: 0x004D20FF
	private void StopVoice()
	{
		PhoneMsgAudioComponent voiceAudioComp = this.VoiceAudioComp;
		if (voiceAudioComp != null)
		{
			voiceAudioComp.StopAudio();
		}
		this.ResetVoicePlaying();
	}

	// Token: 0x06010800 RID: 67584 RVA: 0x004D3F18 File Offset: 0x004D2118
	private EFavorPlayerStatus PlayOrStopVoiceByIndex(int index)
	{
		if (this.CurPlayerStatus == EFavorPlayerStatus.Play && this.CurPlayingVoiceItemIndex == index)
		{
			return EFavorPlayerStatus.Stop;
		}
		return EFavorPlayerStatus.Play;
	}

	// Token: 0x06010801 RID: 67585 RVA: 0x004D3F2E File Offset: 0x004D212E
	private void OnVoiceAudioStart()
	{
		this.SetPlayerState(EFavorPlayerStatus.Play);
	}

	// Token: 0x06010802 RID: 67586 RVA: 0x004D3F37 File Offset: 0x004D2137
	private void OnVoiceAudioEnd()
	{
		if (!this.TryJumpToNextUnPlayedVoiceItem())
		{
			this.ResetVoicePlaying();
		}
	}

	// Token: 0x06010803 RID: 67587 RVA: 0x004D3F47 File Offset: 0x004D2147
	private void OnVoiceAudioLoadTimeout()
	{
		this.ResetVoicePlaying();
	}

	// Token: 0x06010804 RID: 67588 RVA: 0x004D3F50 File Offset: 0x004D2150
	private void OnVoiceChatItemClick(int itemIndex)
	{
		if (this.VoiceAudioComp == null)
		{
			return;
		}
		PhoneMsgChatData phoneMsgChatData = this.DisplayData.ChatDataList[itemIndex];
		this.IsNeedJump = !phoneMsgChatData.IsVoicePlayed;
		ISyncGridProxy proxyByDisplayIndex = this.ChatMultiTemplateComponent.GetProxyByDisplayIndex(itemIndex);
		EPhoneMsgContentType chatContentType = phoneMsgChatData.ChatContentType;
		IPhoneMsgChatItem phoneMsgChatItem;
		if (chatContentType != EPhoneMsgContentType.Other)
		{
			if (chatContentType != EPhoneMsgContentType.Self)
			{
				return;
			}
			phoneMsgChatItem = (proxyByDisplayIndex as PhoneMsgSelfChatItem);
		}
		else
		{
			phoneMsgChatItem = (proxyByDisplayIndex as PhoneMsgOtherChatItem);
		}
		EFavorPlayerStatus efavorPlayerStatus = this.PlayOrStopVoiceByIndex(itemIndex);
		if (phoneMsgChatItem == null)
		{
			return;
		}
		if (efavorPlayerStatus == EFavorPlayerStatus.Play)
		{
			if (this.CurPlayingVoiceItemIndex >= 0)
			{
				this.StopVoice();
			}
			this.CurPlayingChatItemProxy = phoneMsgChatItem;
			this.CurPlayingChatItemProxy.ShowVoiceTextPanel(delegate
			{
				if (!this.IsPlaying)
				{
					this.NeedScrollOnNextTick = true;
					this.NeedScrollToIndex = itemIndex;
					this.NeedScrollTween = true;
				}
			});
			this.CurPlayingChatItemProxy.PlayVoicePlayingAnimationAsync();
			PhoneMsgModel.Instance.AddVoiceRedDot(phoneMsgChatData.VoiceEventHash);
			this.PlayVoice(itemIndex);
			return;
		}
		if (efavorPlayerStatus != EFavorPlayerStatus.Stop)
		{
			return;
		}
		this.StopVoice();
	}

	// Token: 0x06010805 RID: 67589 RVA: 0x004D4050 File Offset: 0x004D2250
	private bool TryJumpToNextUnPlayedVoiceItem()
	{
		if (!this.IsNeedJump)
		{
			return false;
		}
		if (this.CurPlayingVoiceItemIndex >= 0 && this.DisplayData != null)
		{
			int count = this.DisplayData.ChatDataList.Count;
			for (int i = this.CurPlayingVoiceItemIndex + 1; i < count; i++)
			{
				PhoneMsgChatData phoneMsgChatData = this.DisplayData.ChatDataList[i];
				if (phoneMsgChatData != null && phoneMsgChatData.ContentType == EChatMsgType.Voice && !phoneMsgChatData.IsVoicePlayed)
				{
					this.IsNeedJump = false;
					this.OnVoiceChatItemClick(i);
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x06010806 RID: 67590 RVA: 0x004D40D4 File Offset: 0x004D22D4
	private void OnScrollViewPointerUp(ULGUIPointerEventData eventData)
	{
		if (eventData == null || eventData.dragComponent != null)
		{
			return;
		}
		if (this.CurPlayerStatus == EFavorPlayerStatus.Play)
		{
			if (!this.IsPlaying)
			{
				return;
			}
			this.IsNeedJump = true;
			if (!this.TryJumpToNextUnPlayedVoiceItem())
			{
				this.ResetVoicePlaying();
			}
		}
	}

	// Token: 0x06010807 RID: 67591 RVA: 0x004D4108 File Offset: 0x004D2308
	private void ResetVoicePlaying()
	{
		this.SetPlayerState(EFavorPlayerStatus.Stop);
		IPhoneMsgChatItem curPlayingChatItemProxy = this.CurPlayingChatItemProxy;
		if (curPlayingChatItemProxy != null)
		{
			curPlayingChatItemProxy.SkipVoicePlayingAnimation();
		}
		this.CurPlayingVoiceItemIndex = -1;
		this.CurPlayingChatItemProxy = null;
	}

	// Token: 0x04009247 RID: 37447
	private ShortMessageDisplayData DisplayData;

	// Token: 0x04009248 RID: 37448
	[Nullable(1)]
	private readonly List<IMultiTemplateGridData> DisplayedChatScrollViewDataList = new List<IMultiTemplateGridData>();

	// Token: 0x04009249 RID: 37449
	private Ticker Ticker;

	// Token: 0x0400924A RID: 37450
	private bool NeedScrollOnNextTick;

	// Token: 0x0400924B RID: 37451
	private bool ReadyToScroll;

	// Token: 0x0400924C RID: 37452
	private bool NeedScrollTween;

	// Token: 0x0400924D RID: 37453
	private bool NeedCheckAdapt;

	// Token: 0x0400924E RID: 37454
	private bool NeedScrollToEndOnLateTick;

	// Token: 0x0400924F RID: 37455
	private int NeedScrollToIndex = -1;

	// Token: 0x04009250 RID: 37456
	private bool IsPlaying;

	// Token: 0x04009251 RID: 37457
	private bool IsBigView;

	// Token: 0x04009252 RID: 37458
	private bool IsInInputtingAnimation;

	// Token: 0x04009253 RID: 37459
	private int InputtingAnimationChatIndex = -1;

	// Token: 0x04009254 RID: 37460
	private TimerHandle ScrollTweenHandle;

	// Token: 0x04009255 RID: 37461
	private CustomPromise<bool> ScrollTweenCustomPromise;

	// Token: 0x04009256 RID: 37462
	private EFavorPlayerStatus CurPlayerStatus = EFavorPlayerStatus.Stop;

	// Token: 0x04009257 RID: 37463
	private PhoneMsgAudioComponent VoiceAudioComp;

	// Token: 0x04009258 RID: 37464
	private UUIScrollViewWithScrollbarComponent ScrollComponent;

	// Token: 0x04009259 RID: 37465
	private int CurPlayingVoiceItemIndex = -1;

	// Token: 0x0400925A RID: 37466
	private bool IsNeedJump;

	// Token: 0x0400925B RID: 37467
	private IPhoneMsgChatItem CurPlayingChatItemProxy;

	// Token: 0x0400925C RID: 37468
	private UiPanelBase title2pre;

	// Token: 0x0400925D RID: 37469
	private string title2prepath = "";

	// Token: 0x0400925E RID: 37470
	private LevelSequencePlayer title2SeqPlayer;

	// Token: 0x0400925F RID: 37471
	private MultiTemplateComponent ChatMultiTemplateComponent;

	// Token: 0x04009260 RID: 37472
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<string> OnAfterOneMsgShow;

	// Token: 0x04009261 RID: 37473
	public Action<int> OnMsgReadFinished;

	// Token: 0x02007C60 RID: 31840
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402846E RID: 164974
		NameText,
		// Token: 0x0402846F RID: 164975
		DescriptionText,
		// Token: 0x04028470 RID: 164976
		GroupPanel,
		// Token: 0x04028471 RID: 164977
		GroupNumberText,
		// Token: 0x04028472 RID: 164978
		ChatScrollView,
		// Token: 0x04028473 RID: 164979
		ChatContent,
		// Token: 0x04028474 RID: 164980
		ChatBackgroundTexture,
		// Token: 0x04028475 RID: 164981
		ChatLeftTemplateItem,
		// Token: 0x04028476 RID: 164982
		ChatRightTemplateItem,
		// Token: 0x04028477 RID: 164983
		ChatTipsTemplateItem,
		// Token: 0x04028478 RID: 164984
		ChatTaskTemplateItem,
		// Token: 0x04028479 RID: 164985
		ChatBirthdayTemplateItem,
		// Token: 0x0402847A RID: 164986
		ChatRewardTemplateItem,
		// Token: 0x0402847B RID: 164987
		ChatEndLineTemplateItem,
		// Token: 0x0402847C RID: 164988
		BtnMask,
		// Token: 0x0402847D RID: 164989
		TexChatBgDefault,
		// Token: 0x0402847E RID: 164990
		NaviBtnBlank,
		// Token: 0x0402847F RID: 164991
		TexModelT,
		// Token: 0x04028480 RID: 164992
		SprTxtNameBg,
		// Token: 0x04028481 RID: 164993
		SprTxtDescri,
		// Token: 0x04028482 RID: 164994
		SprBg,
		// Token: 0x04028483 RID: 164995
		PnlContentSkinT
	}
}
