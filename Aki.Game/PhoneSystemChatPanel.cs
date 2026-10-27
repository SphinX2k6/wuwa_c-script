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

// Token: 0x02002542 RID: 9538
[NullableContext(2)]
[Nullable(0)]
public class PhoneSystemChatPanel : UiPanelBase
{
	// Token: 0x060132CE RID: 78542 RVA: 0x004C3518 File Offset: 0x004C1718
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

	// Token: 0x170018D2 RID: 6354
	// (get) Token: 0x060132CF RID: 78543 RVA: 0x004C357F File Offset: 0x004C177F
	public bool GetIsPlaying
	{
		get
		{
			return this.IsPlaying;
		}
	}

	// Token: 0x060132D0 RID: 78544 RVA: 0x004C3588 File Offset: 0x004C1788
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

	// Token: 0x060132D1 RID: 78545 RVA: 0x004C37B8 File Offset: 0x004C19B8
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

	// Token: 0x060132D2 RID: 78546 RVA: 0x004C3960 File Offset: 0x004C1B60
	protected override void OnBeforeShow()
	{
		this.Ticker = TickSystem.Instance.Add(new Action<float>(this.OnTick), "PhoneSystemChatPanel", ETickingGroup.TG_PrePhysics, true, 0, true);
		base.GetScrollViewWithScrollbar(4).OnLateUpdate.Bind(new Action<float>(this.OnLateTick));
		this.RefreshChatBgShow();
		this.RefreshChatThemeShow();
	}

	// Token: 0x060132D3 RID: 78547 RVA: 0x004C39BB File Offset: 0x004C1BBB
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

	// Token: 0x060132D4 RID: 78548 RVA: 0x004C39F7 File Offset: 0x004C1BF7
	public void SetIsBigView(bool isbig)
	{
		this.IsBigView = isbig;
	}

	// Token: 0x060132D5 RID: 78549 RVA: 0x004C3A00 File Offset: 0x004C1C00
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

	// Token: 0x060132D6 RID: 78550 RVA: 0x004C3A69 File Offset: 0x004C1C69
	private void OnTick(float deltaTime)
	{
		if (this.ReadyToScroll)
		{
			this.ScrollToChatItem(this.NeedScrollToIndex, this.NeedScrollTween);
			this.ReadyToScroll = false;
		}
	}

	// Token: 0x060132D7 RID: 78551 RVA: 0x004C3A8C File Offset: 0x004C1C8C
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

	// Token: 0x060132D8 RID: 78552 RVA: 0x004C3B04 File Offset: 0x004C1D04
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

	// Token: 0x060132D9 RID: 78553 RVA: 0x004C3B88 File Offset: 0x004C1D88
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

	// Token: 0x060132DA RID: 78554 RVA: 0x004C3C2C File Offset: 0x004C1E2C
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

	// Token: 0x060132DB RID: 78555 RVA: 0x004C3C82 File Offset: 0x004C1E82
	private void RefreshChatThemeShow()
	{
		this.RefreshByTheme(PhoneMsgModel.Instance.CurrentUsingChatThemeId);
	}

	// Token: 0x060132DC RID: 78556 RVA: 0x004C3C94 File Offset: 0x004C1E94
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

	// Token: 0x060132DD RID: 78557 RVA: 0x004C3D1C File Offset: 0x004C1F1C
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

	// Token: 0x060132DE RID: 78558 RVA: 0x004C4000 File Offset: 0x004C2200
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

	// Token: 0x060132DF RID: 78559 RVA: 0x004C4054 File Offset: 0x004C2254
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

	// Token: 0x060132E0 RID: 78560 RVA: 0x004C40BC File Offset: 0x004C22BC
	private void CheckToRemoveTicker()
	{
		if (this.Ticker != null)
		{
			TickSystem.Instance.Remove(this.Ticker.Id);
			this.Ticker = null;
		}
	}

	// Token: 0x060132E1 RID: 78561 RVA: 0x004C40E4 File Offset: 0x004C22E4
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

	// Token: 0x060132E2 RID: 78562 RVA: 0x004C4130 File Offset: 0x004C2330
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

	// Token: 0x060132E3 RID: 78563 RVA: 0x004C41DC File Offset: 0x004C23DC
	public void RefreshChatShow()
	{
		this.UpdateChatDialogData();
		this.RefreshChatDialog();
		this.RefreshChatBg();
	}

	// Token: 0x060132E4 RID: 78564 RVA: 0x004C41F0 File Offset: 0x004C23F0
	private void RefreshChatDialog()
	{
		if (((this.DisplayData != null) ? this.DisplayData.ChatDialogId : 0) <= 0)
		{
			return;
		}
		this.ShowReadChatContents();
	}

	// Token: 0x060132E5 RID: 78565 RVA: 0x004C4214 File Offset: 0x004C2414
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

	// Token: 0x060132E6 RID: 78566 RVA: 0x004C427C File Offset: 0x004C247C
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

	// Token: 0x060132E7 RID: 78567 RVA: 0x004C432C File Offset: 0x004C252C
	private UniTask HandleLastData()
	{
		PhoneSystemChatPanel.<HandleLastData>d__54 <HandleLastData>d__;
		<HandleLastData>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<HandleLastData>d__.<>4__this = this;
		<HandleLastData>d__.<>1__state = -1;
		<HandleLastData>d__.<>t__builder.Start<PhoneSystemChatPanel.<HandleLastData>d__54>(ref <HandleLastData>d__);
		return <HandleLastData>d__.<>t__builder.Task;
	}

	// Token: 0x060132E8 RID: 78568 RVA: 0x004C4370 File Offset: 0x004C2570
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

	// Token: 0x060132E9 RID: 78569 RVA: 0x004C43FC File Offset: 0x004C25FC
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

	// Token: 0x060132EA RID: 78570 RVA: 0x004C446C File Offset: 0x004C266C
	private void AddShowMessageTask(int chatIndex)
	{
		if (this.DisplayData == null)
		{
			return;
		}
		PhoneMsgChatData phoneMsgChatData = this.DisplayData.ChatDataList[chatIndex];
		EPhoneMsgContentType chatContentType = phoneMsgChatData.ChatContentType;
		this.AddRefreshReadIndexTask(chatIndex);
		if (chatContentType == EPhoneMsgContentType.Tips && phoneMsgChatData.ContentType == EChatMsgType.Task)
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
			default:
				return;
			}
			break;
		default:
			return;
		}
	}

	// Token: 0x060132EB RID: 78571 RVA: 0x004C452C File Offset: 0x004C272C
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

	// Token: 0x060132EC RID: 78572 RVA: 0x004C468C File Offset: 0x004C288C
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
			default:
				return null;
			}
			break;
		default:
			return null;
		}
	}

	// Token: 0x060132ED RID: 78573 RVA: 0x004C474D File Offset: 0x004C294D
	private void OnRewardClick()
	{
		this.AddReceiveRewardTask();
	}

	// Token: 0x060132EE RID: 78574 RVA: 0x004C4755 File Offset: 0x004C2955
	private void ShowReadChatContents()
	{
		if (this.ChatMultiTemplateComponent == null)
		{
			return;
		}
		this.ChatMultiTemplateComponent.RefreshByData(this.DisplayedChatScrollViewDataList, false);
		this.NeedScrollToEndOnLateTick = true;
	}

	// Token: 0x060132EF RID: 78575 RVA: 0x004C477C File Offset: 0x004C297C
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

	// Token: 0x060132F0 RID: 78576 RVA: 0x004C47B8 File Offset: 0x004C29B8
	private void AddRefreshReadIndexTask(int chatIndex)
	{
		UiAsyncTask task = new UiAsyncTask("ChatPerformance", () => this.RefreshReadIndexAsync(chatIndex), null);
		base.RunAsyncTask(task);
	}

	// Token: 0x060132F1 RID: 78577 RVA: 0x004C47FC File Offset: 0x004C29FC
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

	// Token: 0x060132F2 RID: 78578 RVA: 0x004C484C File Offset: 0x004C2A4C
	private void AddRefreshChatContentTask(int chatIndex)
	{
		UiAsyncTask task = new UiAsyncTask("ChatPerformance", () => this.RefreshChatContentAsync(chatIndex), null);
		base.RunAsyncTask(task);
	}

	// Token: 0x060132F3 RID: 78579 RVA: 0x004C4890 File Offset: 0x004C2A90
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

	// Token: 0x060132F4 RID: 78580 RVA: 0x004C48F4 File Offset: 0x004C2AF4
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

	// Token: 0x060132F5 RID: 78581 RVA: 0x004C4954 File Offset: 0x004C2B54
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

	// Token: 0x060132F6 RID: 78582 RVA: 0x004C49A0 File Offset: 0x004C2BA0
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

	// Token: 0x060132F7 RID: 78583 RVA: 0x004C49F0 File Offset: 0x004C2BF0
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

	// Token: 0x060132F8 RID: 78584 RVA: 0x004C4A50 File Offset: 0x004C2C50
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

	// Token: 0x060132F9 RID: 78585 RVA: 0x004C4A9C File Offset: 0x004C2C9C
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

	// Token: 0x060132FA RID: 78586 RVA: 0x004C4AE4 File Offset: 0x004C2CE4
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

	// Token: 0x060132FB RID: 78587 RVA: 0x004C4B44 File Offset: 0x004C2D44
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

	// Token: 0x060132FC RID: 78588 RVA: 0x004C4B90 File Offset: 0x004C2D90
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

	// Token: 0x060132FD RID: 78589 RVA: 0x004C4BD4 File Offset: 0x004C2DD4
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

	// Token: 0x060132FE RID: 78590 RVA: 0x004C4C34 File Offset: 0x004C2E34
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

	// Token: 0x060132FF RID: 78591 RVA: 0x004C4C80 File Offset: 0x004C2E80
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

	// Token: 0x06013300 RID: 78592 RVA: 0x004C4CC4 File Offset: 0x004C2EC4
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

	// Token: 0x06013301 RID: 78593 RVA: 0x004C4D24 File Offset: 0x004C2F24
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

	// Token: 0x06013302 RID: 78594 RVA: 0x004C4D70 File Offset: 0x004C2F70
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

	// Token: 0x06013303 RID: 78595 RVA: 0x004C4DB4 File Offset: 0x004C2FB4
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

	// Token: 0x06013304 RID: 78596 RVA: 0x004C4E14 File Offset: 0x004C3014
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

	// Token: 0x06013305 RID: 78597 RVA: 0x004C4E60 File Offset: 0x004C3060
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

	// Token: 0x06013306 RID: 78598 RVA: 0x004C4EA4 File Offset: 0x004C30A4
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

	// Token: 0x06013307 RID: 78599 RVA: 0x004C4EFC File Offset: 0x004C30FC
	private UniTask ShowEndLineAsync()
	{
		PhoneSystemChatPanel.<ShowEndLineAsync>d__86 <ShowEndLineAsync>d__;
		<ShowEndLineAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ShowEndLineAsync>d__.<>4__this = this;
		<ShowEndLineAsync>d__.<>1__state = -1;
		<ShowEndLineAsync>d__.<>t__builder.Start<PhoneSystemChatPanel.<ShowEndLineAsync>d__86>(ref <ShowEndLineAsync>d__);
		return <ShowEndLineAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013308 RID: 78600 RVA: 0x004C4F3F File Offset: 0x004C313F
	private void OnEndLineCanceled(EUiAsyncTaskStatus status)
	{
		if (status != EUiAsyncTaskStatus.Running)
		{
			return;
		}
		this.StopScrollTweenAnimation();
	}

	// Token: 0x06013309 RID: 78601 RVA: 0x004C4F4C File Offset: 0x004C314C
	private void AddMaskEnableTask()
	{
		UiAsyncTask task = new UiAsyncTask("ChatPerformance", new Func<UniTask>(this.MaskEnableAsync), delegate()
		{
			this.OnMaskEnableCanceled(EUiAsyncTaskStatus.Running);
		});
		base.RunAsyncTask(task);
	}

	// Token: 0x0601330A RID: 78602 RVA: 0x004C4F84 File Offset: 0x004C3184
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

	// Token: 0x0601330B RID: 78603 RVA: 0x004C4FD7 File Offset: 0x004C31D7
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

	// Token: 0x0601330C RID: 78604 RVA: 0x004C5008 File Offset: 0x004C3208
	private void AddMaskDisableTask()
	{
		UiAsyncTask task = new UiAsyncTask("ChatPerformance", new Func<UniTask>(this.MaskDisableAsync), delegate()
		{
			this.OnMaskDisableCanceled(EUiAsyncTaskStatus.Running);
		});
		base.RunAsyncTask(task);
	}

	// Token: 0x0601330D RID: 78605 RVA: 0x004C5040 File Offset: 0x004C3240
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

	// Token: 0x0601330E RID: 78606 RVA: 0x004C507A File Offset: 0x004C327A
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

	// Token: 0x0601330F RID: 78607 RVA: 0x004C50B0 File Offset: 0x004C32B0
	[NullableContext(1)]
	private void AddUpdateProgressTask(ShortMessageDisplayData displayData)
	{
		UiAsyncTask task = new UiAsyncTask("ChatPerformance", () => this.UpdateProgressAsync(displayData), null);
		base.RunAsyncTask(task);
	}

	// Token: 0x06013310 RID: 78608 RVA: 0x004C50F1 File Offset: 0x004C32F1
	[NullableContext(1)]
	private UniTask UpdateProgressAsync(ShortMessageDisplayData displayData)
	{
		return this.UpdateProgressToServerAsync(displayData);
	}

	// Token: 0x06013311 RID: 78609 RVA: 0x004C50FC File Offset: 0x004C32FC
	[NullableContext(1)]
	private UniTask UpdateProgressToServerAsync(ShortMessageDisplayData displayData)
	{
		PhoneSystemChatPanel.<UpdateProgressToServerAsync>d__96 <UpdateProgressToServerAsync>d__;
		<UpdateProgressToServerAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<UpdateProgressToServerAsync>d__.displayData = displayData;
		<UpdateProgressToServerAsync>d__.<>1__state = -1;
		<UpdateProgressToServerAsync>d__.<>t__builder.Start<PhoneSystemChatPanel.<UpdateProgressToServerAsync>d__96>(ref <UpdateProgressToServerAsync>d__);
		return <UpdateProgressToServerAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013312 RID: 78610 RVA: 0x004C5140 File Offset: 0x004C3340
	private void AddExecuteEndCallBackTask()
	{
		UiAsyncTask task = new UiAsyncTask("ChatPerformance", new Func<UniTask>(this.ExecuteEndCallBackAsync), null);
		base.RunAsyncTask(task);
	}

	// Token: 0x06013313 RID: 78611 RVA: 0x004C516D File Offset: 0x004C336D
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

	// Token: 0x06013314 RID: 78612 RVA: 0x004C51A0 File Offset: 0x004C33A0
	private void AddSelectOptionTask(int chatItemIndex, int selectedIndex)
	{
		PhoneSystemChatPanel.<>c__DisplayClass99_0 CS$<>8__locals1 = new PhoneSystemChatPanel.<>c__DisplayClass99_0();
		CS$<>8__locals1.<>4__this = this;
		CS$<>8__locals1.chatItemIndex = chatItemIndex;
		CS$<>8__locals1.selectedIndex = selectedIndex;
		UiAsyncTask task = new UiAsyncTask("ChatPerformance", delegate()
		{
			PhoneSystemChatPanel.<>c__DisplayClass99_0.<<AddSelectOptionTask>b__0>d <<AddSelectOptionTask>b__0>d;
			<<AddSelectOptionTask>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<AddSelectOptionTask>b__0>d.<>4__this = CS$<>8__locals1;
			<<AddSelectOptionTask>b__0>d.<>1__state = -1;
			<<AddSelectOptionTask>b__0>d.<>t__builder.Start<PhoneSystemChatPanel.<>c__DisplayClass99_0.<<AddSelectOptionTask>b__0>d>(ref <<AddSelectOptionTask>b__0>d);
			return <<AddSelectOptionTask>b__0>d.<>t__builder.Task;
		}, null);
		base.RunAsyncTask(task);
	}

	// Token: 0x06013315 RID: 78613 RVA: 0x004C51E8 File Offset: 0x004C33E8
	private UniTask SelectOptionAsync(int chatItemIndex, int selectedIndex)
	{
		PhoneSystemChatPanel.<SelectOptionAsync>d__100 <SelectOptionAsync>d__;
		<SelectOptionAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<SelectOptionAsync>d__.<>4__this = this;
		<SelectOptionAsync>d__.chatItemIndex = chatItemIndex;
		<SelectOptionAsync>d__.selectedIndex = selectedIndex;
		<SelectOptionAsync>d__.<>1__state = -1;
		<SelectOptionAsync>d__.<>t__builder.Start<PhoneSystemChatPanel.<SelectOptionAsync>d__100>(ref <SelectOptionAsync>d__);
		return <SelectOptionAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013316 RID: 78614 RVA: 0x004C523C File Offset: 0x004C343C
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

	// Token: 0x06013317 RID: 78615 RVA: 0x004C529C File Offset: 0x004C349C
	private UniTask AnswerItemHideOptionAsync(int chatItemIndex)
	{
		PhoneSystemChatPanel.<AnswerItemHideOptionAsync>d__102 <AnswerItemHideOptionAsync>d__;
		<AnswerItemHideOptionAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<AnswerItemHideOptionAsync>d__.<>4__this = this;
		<AnswerItemHideOptionAsync>d__.chatItemIndex = chatItemIndex;
		<AnswerItemHideOptionAsync>d__.<>1__state = -1;
		<AnswerItemHideOptionAsync>d__.<>t__builder.Start<PhoneSystemChatPanel.<AnswerItemHideOptionAsync>d__102>(ref <AnswerItemHideOptionAsync>d__);
		return <AnswerItemHideOptionAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013318 RID: 78616 RVA: 0x004C52E8 File Offset: 0x004C34E8
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

	// Token: 0x06013319 RID: 78617 RVA: 0x004C5330 File Offset: 0x004C3530
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

	// Token: 0x0601331A RID: 78618 RVA: 0x004C5390 File Offset: 0x004C3590
	private UniTask AnswerItemShowChatContentAsync(int chatItemIndex)
	{
		PhoneSystemChatPanel.<AnswerItemShowChatContentAsync>d__105 <AnswerItemShowChatContentAsync>d__;
		<AnswerItemShowChatContentAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<AnswerItemShowChatContentAsync>d__.<>4__this = this;
		<AnswerItemShowChatContentAsync>d__.chatItemIndex = chatItemIndex;
		<AnswerItemShowChatContentAsync>d__.<>1__state = -1;
		<AnswerItemShowChatContentAsync>d__.<>t__builder.Start<PhoneSystemChatPanel.<AnswerItemShowChatContentAsync>d__105>(ref <AnswerItemShowChatContentAsync>d__);
		return <AnswerItemShowChatContentAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601331B RID: 78619 RVA: 0x004C53DC File Offset: 0x004C35DC
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

	// Token: 0x0601331C RID: 78620 RVA: 0x004C540C File Offset: 0x004C360C
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

	// Token: 0x0601331D RID: 78621 RVA: 0x004C5469 File Offset: 0x004C3669
	private UniTask AfterAnswerAsync(int chatItemIndex)
	{
		this.AddAnswerItemHideOptionTask(chatItemIndex);
		this.AddAnswerItemShowChatContentTask(chatItemIndex);
		this.AddAllMessageTasks();
		this.AddMaskDisableTask();
		return UniTask.CompletedTask;
	}

	// Token: 0x0601331E RID: 78622 RVA: 0x004C548A File Offset: 0x004C368A
	private void OnAfterAnswerCanceled(EUiAsyncTaskStatus status, int chatItemIndex)
	{
		if (status != EUiAsyncTaskStatus.Running)
		{
			return;
		}
		base.CancelAllAsyncTask();
	}

	// Token: 0x0601331F RID: 78623 RVA: 0x004C5498 File Offset: 0x004C3698
	private void AddReceiveRewardTask()
	{
		UiAsyncTask task = new UiAsyncTask("ChatPerformance", new Func<UniTask>(this.ReceiveRewardAsync), null);
		base.RunAsyncTask(task);
	}

	// Token: 0x06013320 RID: 78624 RVA: 0x004C54C8 File Offset: 0x004C36C8
	private UniTask ReceiveRewardAsync()
	{
		PhoneSystemChatPanel.<ReceiveRewardAsync>d__111 <ReceiveRewardAsync>d__;
		<ReceiveRewardAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ReceiveRewardAsync>d__.<>4__this = this;
		<ReceiveRewardAsync>d__.<>1__state = -1;
		<ReceiveRewardAsync>d__.<>t__builder.Start<PhoneSystemChatPanel.<ReceiveRewardAsync>d__111>(ref <ReceiveRewardAsync>d__);
		return <ReceiveRewardAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013321 RID: 78625 RVA: 0x004C550C File Offset: 0x004C370C
	private UniTask PlayScrollTweenAnimationAsync()
	{
		PhoneSystemChatPanel.<PlayScrollTweenAnimationAsync>d__112 <PlayScrollTweenAnimationAsync>d__;
		<PlayScrollTweenAnimationAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayScrollTweenAnimationAsync>d__.<>4__this = this;
		<PlayScrollTweenAnimationAsync>d__.<>1__state = -1;
		<PlayScrollTweenAnimationAsync>d__.<>t__builder.Start<PhoneSystemChatPanel.<PlayScrollTweenAnimationAsync>d__112>(ref <PlayScrollTweenAnimationAsync>d__);
		return <PlayScrollTweenAnimationAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013322 RID: 78626 RVA: 0x004C5550 File Offset: 0x004C3750
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

	// Token: 0x06013323 RID: 78627 RVA: 0x004C55AB File Offset: 0x004C37AB
	private void StopScrollTweenAnimation()
	{
		this.NeedScrollTween = false;
		this.NeedScrollOnNextTick = false;
		base.GetScrollViewWithScrollbar(4).StopMovement();
	}

	// Token: 0x06013324 RID: 78628 RVA: 0x004C55C7 File Offset: 0x004C37C7
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

	// Token: 0x06013325 RID: 78629 RVA: 0x004C55FC File Offset: 0x004C37FC
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

	// Token: 0x06013326 RID: 78630 RVA: 0x004C56BC File Offset: 0x004C38BC
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

	// Token: 0x06013327 RID: 78631 RVA: 0x004C56F0 File Offset: 0x004C38F0
	private void SetPlayerState(EFavorPlayerStatus playerStatus)
	{
		this.CurPlayerStatus = playerStatus;
	}

	// Token: 0x06013328 RID: 78632 RVA: 0x004C56FC File Offset: 0x004C38FC
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

	// Token: 0x06013329 RID: 78633 RVA: 0x004C576F File Offset: 0x004C396F
	private void StopVoice()
	{
		PhoneMsgAudioComponent voiceAudioComp = this.VoiceAudioComp;
		if (voiceAudioComp != null)
		{
			voiceAudioComp.StopAudio();
		}
		this.ResetVoicePlaying();
	}

	// Token: 0x0601332A RID: 78634 RVA: 0x004C5788 File Offset: 0x004C3988
	private EFavorPlayerStatus PlayOrStopVoiceByIndex(int index)
	{
		if (this.CurPlayerStatus == EFavorPlayerStatus.Play && this.CurPlayingVoiceItemIndex == index)
		{
			return EFavorPlayerStatus.Stop;
		}
		return EFavorPlayerStatus.Play;
	}

	// Token: 0x0601332B RID: 78635 RVA: 0x004C579E File Offset: 0x004C399E
	private void OnVoiceAudioStart()
	{
		this.SetPlayerState(EFavorPlayerStatus.Play);
	}

	// Token: 0x0601332C RID: 78636 RVA: 0x004C57A7 File Offset: 0x004C39A7
	private void OnVoiceAudioEnd()
	{
		if (!this.TryJumpToNextUnPlayedVoiceItem())
		{
			this.ResetVoicePlaying();
		}
	}

	// Token: 0x0601332D RID: 78637 RVA: 0x004C57B7 File Offset: 0x004C39B7
	private void OnVoiceAudioLoadTimeout()
	{
		this.ResetVoicePlaying();
	}

	// Token: 0x0601332E RID: 78638 RVA: 0x004C57C0 File Offset: 0x004C39C0
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

	// Token: 0x0601332F RID: 78639 RVA: 0x004C58C0 File Offset: 0x004C3AC0
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

	// Token: 0x06013330 RID: 78640 RVA: 0x004C5944 File Offset: 0x004C3B44
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

	// Token: 0x06013331 RID: 78641 RVA: 0x004C5978 File Offset: 0x004C3B78
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

	// Token: 0x040090ED RID: 37101
	private ShortMessageDisplayData DisplayData;

	// Token: 0x040090EE RID: 37102
	[Nullable(1)]
	private readonly List<IMultiTemplateGridData> DisplayedChatScrollViewDataList = new List<IMultiTemplateGridData>();

	// Token: 0x040090EF RID: 37103
	private Ticker Ticker;

	// Token: 0x040090F0 RID: 37104
	private bool NeedScrollOnNextTick;

	// Token: 0x040090F1 RID: 37105
	private bool ReadyToScroll;

	// Token: 0x040090F2 RID: 37106
	private bool NeedScrollTween;

	// Token: 0x040090F3 RID: 37107
	private bool NeedCheckAdapt;

	// Token: 0x040090F4 RID: 37108
	private bool NeedScrollToEndOnLateTick;

	// Token: 0x040090F5 RID: 37109
	private int NeedScrollToIndex = -1;

	// Token: 0x040090F6 RID: 37110
	private bool IsPlaying;

	// Token: 0x040090F7 RID: 37111
	private bool IsBigView;

	// Token: 0x040090F8 RID: 37112
	private bool IsInInputtingAnimation;

	// Token: 0x040090F9 RID: 37113
	private int InputtingAnimationChatIndex = -1;

	// Token: 0x040090FA RID: 37114
	private TimerHandle ScrollTweenHandle;

	// Token: 0x040090FB RID: 37115
	private CustomPromise<bool> ScrollTweenCustomPromise;

	// Token: 0x040090FC RID: 37116
	private EFavorPlayerStatus CurPlayerStatus = EFavorPlayerStatus.Stop;

	// Token: 0x040090FD RID: 37117
	private PhoneMsgAudioComponent VoiceAudioComp;

	// Token: 0x040090FE RID: 37118
	private UUIScrollViewWithScrollbarComponent ScrollComponent;

	// Token: 0x040090FF RID: 37119
	private int CurPlayingVoiceItemIndex = -1;

	// Token: 0x04009100 RID: 37120
	private bool IsNeedJump;

	// Token: 0x04009101 RID: 37121
	private IPhoneMsgChatItem CurPlayingChatItemProxy;

	// Token: 0x04009102 RID: 37122
	private UiPanelBase title2pre;

	// Token: 0x04009103 RID: 37123
	private string title2prepath = "";

	// Token: 0x04009104 RID: 37124
	private LevelSequencePlayer title2SeqPlayer;

	// Token: 0x04009105 RID: 37125
	private MultiTemplateComponent ChatMultiTemplateComponent;

	// Token: 0x04009106 RID: 37126
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<string> OnAfterOneMsgShow;

	// Token: 0x04009107 RID: 37127
	public Action<int> OnMsgReadFinished;

	// Token: 0x02008AD7 RID: 35543
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402D14E RID: 184654
		NameText,
		// Token: 0x0402D14F RID: 184655
		DescriptionText,
		// Token: 0x0402D150 RID: 184656
		GroupPanel,
		// Token: 0x0402D151 RID: 184657
		GroupNumberText,
		// Token: 0x0402D152 RID: 184658
		ChatScrollView,
		// Token: 0x0402D153 RID: 184659
		ChatContent,
		// Token: 0x0402D154 RID: 184660
		ChatBackgroundTexture,
		// Token: 0x0402D155 RID: 184661
		ChatLeftTemplateItem,
		// Token: 0x0402D156 RID: 184662
		ChatRightTemplateItem,
		// Token: 0x0402D157 RID: 184663
		ChatTipsTemplateItem,
		// Token: 0x0402D158 RID: 184664
		ChatTaskTemplateItem,
		// Token: 0x0402D159 RID: 184665
		ChatBirthdayTemplateItem,
		// Token: 0x0402D15A RID: 184666
		ChatRewardTemplateItem,
		// Token: 0x0402D15B RID: 184667
		ChatEndLineTemplateItem,
		// Token: 0x0402D15C RID: 184668
		BtnMask,
		// Token: 0x0402D15D RID: 184669
		TexChatBgDefault,
		// Token: 0x0402D15E RID: 184670
		NaviBtnBlank,
		// Token: 0x0402D15F RID: 184671
		TexModelT,
		// Token: 0x0402D160 RID: 184672
		SprTxtNameBg,
		// Token: 0x0402D161 RID: 184673
		SprTxtDescri,
		// Token: 0x0402D162 RID: 184674
		SprBg,
		// Token: 0x0402D163 RID: 184675
		PnlContentSkinT
	}
}
