using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PhoneMessage;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using CSharpScript.Game.Ui.PhoneMessage.View;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002519 RID: 9497
[NullableContext(2)]
[Nullable(0)]
public class PhoneMsgPanelViewBig : UiViewBase
{
	// Token: 0x06013159 RID: 78169 RVA: 0x004BADEC File Offset: 0x004B8FEC
	[NullableContext(1)]
	public PhoneMsgPanelViewBig(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0601315A RID: 78170 RVA: 0x004BAE4C File Offset: 0x004B904C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUITexture)),
			new ValueTuple<int, Type>(12, typeof(UUITexture)),
			new ValueTuple<int, Type>(13, typeof(UUITexture)),
			new ValueTuple<int, Type>(14, typeof(UUISprite)),
			new ValueTuple<int, Type>(15, typeof(UUIText)),
			new ValueTuple<int, Type>(16, typeof(UUIItem)),
			new ValueTuple<int, Type>(17, typeof(UUIItem)),
			new ValueTuple<int, Type>(18, typeof(UUIItem)),
			new ValueTuple<int, Type>(19, typeof(UUITexture)),
			new ValueTuple<int, Type>(20, typeof(UUITexture)),
			new ValueTuple<int, Type>(21, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(5, new Action(this.OnSetClick))
		};
	}

	// Token: 0x0601315B RID: 78171 RVA: 0x004BB078 File Offset: 0x004B9278
	protected override UniTask OnBeforeStartAsync()
	{
		PhoneMsgPanelViewBig.<OnBeforeStartAsync>d__24 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PhoneMsgPanelViewBig.<OnBeforeStartAsync>d__24>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601315C RID: 78172 RVA: 0x004BB0BB File Offset: 0x004B92BB
	protected override void OnBeforeShow()
	{
		this.RefreshRedDot();
		this.RefreshChatShow();
	}

	// Token: 0x0601315D RID: 78173 RVA: 0x004BB0CC File Offset: 0x004B92CC
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnPhoneHaveMsgToRemove, new Action(this.OnHandleMessagesToDelete));
		EventSystem.Instance.Add<EInputControllerMainType, EInputControllerMainType>(EEventName.InputControllerMainTypeChange, new Action<EInputControllerMainType, EInputControllerMainType>(this.OnInputControllerMainTypeChange));
		EventSystem.Instance.Add(EEventName.PhoneMsgDialogBgThemeCharmRedDotUpdate, new Action(this.RefreshRedDot));
		EventSystem.Instance.Add(EEventName.OnPhoneMsgFilterChanged, new Action(this.OnFilterChanged));
		EventSystem.Instance.Add(EEventName.OnPhoneMsgChatShowChange, new Action(this.RefreshChatShow));
	}

	// Token: 0x0601315E RID: 78174 RVA: 0x004BB168 File Offset: 0x004B9368
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnPhoneHaveMsgToRemove, new Action(this.OnHandleMessagesToDelete));
		EventSystem.Instance.Remove(EEventName.InputControllerMainTypeChange, new Action<EInputControllerMainType, EInputControllerMainType>(this.OnInputControllerMainTypeChange));
		EventSystem.Instance.Remove(EEventName.PhoneMsgDialogBgThemeCharmRedDotUpdate, new Action(this.RefreshRedDot));
		EventSystem.Instance.Remove(EEventName.OnPhoneMsgFilterChanged, new Action(this.OnFilterChanged));
		EventSystem.Instance.Remove(EEventName.OnPhoneMsgChatShowChange, new Action(this.RefreshChatShow));
	}

	// Token: 0x0601315F RID: 78175 RVA: 0x004BB201 File Offset: 0x004B9401
	private void RefreshChatShow()
	{
		this.RefreshByTheme(PhoneMsgModel.Instance.CurrentUsingChatThemeId);
		this.SetSpineByCharmId(PhoneMsgModel.Instance.CurrentUsingChatCharmId);
	}

	// Token: 0x06013160 RID: 78176 RVA: 0x004BB224 File Offset: 0x004B9424
	public void SetSpineByCharmId(int charmId)
	{
		ChatCharm? chatCharmConfig = PhoneMsgConfig.Instance.GetChatCharmConfig(charmId);
		if (chatCharmConfig == null)
		{
			return;
		}
		string spinepre = chatCharmConfig.Value.Spinepre;
		UUIItem item = base.GetItem(21);
		if (item == null)
		{
			return;
		}
		if (spinepre == "")
		{
			if (item != null)
			{
				item.SetUIActive(false);
			}
			PhoneSystemCharm charmPanel = this.CharmPanel;
			if (charmPanel == null)
			{
				return;
			}
			charmPanel.SetActive(false);
			return;
		}
		else
		{
			if (item != null)
			{
				item.SetUIActive(true);
			}
			if (this.charmPrepath != spinepre)
			{
				PhoneSystemCharm charmPanel2 = this.CharmPanel;
				if (charmPanel2 != null)
				{
					charmPanel2.Destroy(null);
				}
				this.CharmPanel = new PhoneSystemCharm();
				this.charmPrepath = spinepre;
				this.CreateCharmAndPlayAsync(spinepre, item, charmId);
				return;
			}
			PhoneSystemCharm charmPanel3 = this.CharmPanel;
			if (charmPanel3 != null)
			{
				charmPanel3.SetActive(true);
			}
			PhoneSystemCharm charmPanel4 = this.CharmPanel;
			if (charmPanel4 == null)
			{
				return;
			}
			charmPanel4.Play(charmId);
			return;
		}
	}

	// Token: 0x06013161 RID: 78177 RVA: 0x004BB2F8 File Offset: 0x004B94F8
	[NullableContext(1)]
	private UniTask CreateCharmAndPlayAsync(string spinepre, UUIItem petItem, int charmId)
	{
		PhoneMsgPanelViewBig.<CreateCharmAndPlayAsync>d__30 <CreateCharmAndPlayAsync>d__;
		<CreateCharmAndPlayAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateCharmAndPlayAsync>d__.<>4__this = this;
		<CreateCharmAndPlayAsync>d__.spinepre = spinepre;
		<CreateCharmAndPlayAsync>d__.petItem = petItem;
		<CreateCharmAndPlayAsync>d__.charmId = charmId;
		<CreateCharmAndPlayAsync>d__.<>1__state = -1;
		<CreateCharmAndPlayAsync>d__.<>t__builder.Start<PhoneMsgPanelViewBig.<CreateCharmAndPlayAsync>d__30>(ref <CreateCharmAndPlayAsync>d__);
		return <CreateCharmAndPlayAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013162 RID: 78178 RVA: 0x004BB354 File Offset: 0x004B9554
	private void RefreshByTheme(int themeId)
	{
		ChatTheme? chatThemeConfig = PhoneMsgConfig.Instance.GetChatThemeConfig(themeId);
		string bgBlankChat = chatThemeConfig.Value.BgBlankChat;
		string prefabBlankChat = chatThemeConfig.Value.PrefabBlankChat;
		UUITexture texture = base.GetTexture(13);
		UUIItem item = base.GetItem(18);
		if (texture != null && bgBlankChat != "")
		{
			base.SetTextureByPath(bgBlankChat, texture, null, null);
			UiPanelBase uiPanelBase = this.rightemptypre;
			if (uiPanelBase != null)
			{
				uiPanelBase.SetActive(false);
			}
		}
		else if (item != null && prefabBlankChat != "")
		{
			if (this.rightemptyprepath != prefabBlankChat)
			{
				UiPanelBase uiPanelBase2 = this.rightemptypre;
				if (uiPanelBase2 != null)
				{
					uiPanelBase2.Destroy(null);
				}
				this.rightemptypre = new UiPanelBase();
				this.CreateRightEmptyAndPlayAsync(prefabBlankChat, item);
				this.rightemptyprepath = prefabBlankChat;
			}
			UiPanelBase uiPanelBase3 = this.rightemptypre;
			if (uiPanelBase3 != null)
			{
				uiPanelBase3.SetActive(true);
			}
			if (texture != null)
			{
				base.SetTextureByPath(PhoneMsgModel.Instance.GetEmptyTexturePath(), texture, null, null);
			}
		}
		string bgTitle = chatThemeConfig.Value.BgTitle1;
		string prefabTitle = chatThemeConfig.Value.PrefabTitle1;
		UUITexture texture2 = base.GetTexture(12);
		UUIItem item2 = base.GetItem(17);
		if (bgTitle != "" && texture2 != null)
		{
			base.SetTextureByPath(bgTitle, texture2, null, null);
			UiPanelBase uiPanelBase4 = this.title1pre;
			if (uiPanelBase4 != null)
			{
				uiPanelBase4.SetActive(false);
			}
		}
		else if (prefabTitle != "" && item2 != null)
		{
			if (this.title1prepath != prefabTitle)
			{
				UiPanelBase uiPanelBase5 = this.title1pre;
				if (uiPanelBase5 != null)
				{
					uiPanelBase5.Destroy(null);
				}
				this.title1pre = new UiPanelBase();
				this.CreateTitle1AndPlayAsync(prefabTitle, item2);
				this.title1prepath = prefabTitle;
			}
			UiPanelBase uiPanelBase6 = this.title1pre;
			if (uiPanelBase6 != null)
			{
				uiPanelBase6.SetActive(true);
			}
			if (texture2 != null)
			{
				base.SetTextureByPath(PhoneMsgModel.Instance.GetEmptyTexturePath(), texture2, null, null);
			}
		}
		string txtTitle = chatThemeConfig.Value.TxtTitle1;
		UUIText text = base.GetText(15);
		if (txtTitle != "" && text != null)
		{
			text.SetColor(FColor.FromHex(txtTitle));
		}
		string bgLeftChat = chatThemeConfig.Value.BgLeftChat;
		string prefabLeftChat = chatThemeConfig.Value.PrefabLeftChat;
		UUITexture texture3 = base.GetTexture(11);
		UUIItem item3 = base.GetItem(16);
		if (bgLeftChat != "" && texture3 != null)
		{
			base.SetTextureByPath(bgLeftChat, texture3, null, null);
			UiPanelBase uiPanelBase7 = this.leftchatpre;
			if (uiPanelBase7 != null)
			{
				uiPanelBase7.SetActive(false);
			}
		}
		else if (prefabLeftChat != "" && item3 != null)
		{
			if (this.leftchatprepath != prefabLeftChat)
			{
				UiPanelBase uiPanelBase8 = this.leftchatpre;
				if (uiPanelBase8 != null)
				{
					uiPanelBase8.Destroy(null);
				}
				this.leftchatpre = new UiPanelBase();
				this.leftchatpre.CreateThenShowByPathAsync(prefabLeftChat, item3, false);
				this.leftchatprepath = prefabLeftChat;
			}
			UiPanelBase uiPanelBase9 = this.leftchatpre;
			if (uiPanelBase9 != null)
			{
				uiPanelBase9.SetActive(true);
			}
			if (texture3 != null)
			{
				base.SetTextureByPath(PhoneMsgModel.Instance.GetEmptyTexturePath(), texture3, null, null);
			}
		}
		string bgFilterNml = chatThemeConfig.Value.BgFilterNml;
		string bgFilterHold = chatThemeConfig.Value.BgFilterHold;
		string bgFilterPress = chatThemeConfig.Value.BgFilterPress;
		UUISprite sprite = base.GetSprite(14);
		AActor aactor = (sprite != null) ? sprite.GetOwner() : null;
		UUISpriteTransition uuispriteTransition = ((aactor != null) ? aactor.GetComponentByClass(UUISpriteTransition.StaticClass()) : null) as UUISpriteTransition;
		if (uuispriteTransition != null && bgFilterNml != "" && bgFilterHold != "" && bgFilterPress != "")
		{
			base.SetSpriteTransitionByPath(bgFilterNml, uuispriteTransition, EUISelectableSelectionState.Normal);
			base.SetSpriteTransitionByPath(bgFilterHold, uuispriteTransition, EUISelectableSelectionState.Highlighted);
			base.SetSpriteTransitionByPath(bgFilterPress, uuispriteTransition, EUISelectableSelectionState.Pressed);
		}
		bool flag = PhoneMsgModel.Instance.IsDefaultTheme(themeId);
		UUITexture texture4 = base.GetTexture(19);
		if (texture4 != null)
		{
			texture4.SetUIActive(flag);
		}
		UUITexture texture5 = base.GetTexture(20);
		if (texture5 == null)
		{
			return;
		}
		texture5.SetUIActive(!flag);
	}

	// Token: 0x06013163 RID: 78179 RVA: 0x004BB788 File Offset: 0x004B9988
	[NullableContext(1)]
	private UniTask CreateTitle1AndPlayAsync(string prefabPath, UUIItem parentItem)
	{
		PhoneMsgPanelViewBig.<CreateTitle1AndPlayAsync>d__32 <CreateTitle1AndPlayAsync>d__;
		<CreateTitle1AndPlayAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateTitle1AndPlayAsync>d__.<>4__this = this;
		<CreateTitle1AndPlayAsync>d__.prefabPath = prefabPath;
		<CreateTitle1AndPlayAsync>d__.parentItem = parentItem;
		<CreateTitle1AndPlayAsync>d__.<>1__state = -1;
		<CreateTitle1AndPlayAsync>d__.<>t__builder.Start<PhoneMsgPanelViewBig.<CreateTitle1AndPlayAsync>d__32>(ref <CreateTitle1AndPlayAsync>d__);
		return <CreateTitle1AndPlayAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013164 RID: 78180 RVA: 0x004BB7DC File Offset: 0x004B99DC
	[NullableContext(1)]
	private UniTask CreateRightEmptyAndPlayAsync(string prefabPath, UUIItem parentItem)
	{
		PhoneMsgPanelViewBig.<CreateRightEmptyAndPlayAsync>d__33 <CreateRightEmptyAndPlayAsync>d__;
		<CreateRightEmptyAndPlayAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateRightEmptyAndPlayAsync>d__.<>4__this = this;
		<CreateRightEmptyAndPlayAsync>d__.prefabPath = prefabPath;
		<CreateRightEmptyAndPlayAsync>d__.parentItem = parentItem;
		<CreateRightEmptyAndPlayAsync>d__.<>1__state = -1;
		<CreateRightEmptyAndPlayAsync>d__.<>t__builder.Start<PhoneMsgPanelViewBig.<CreateRightEmptyAndPlayAsync>d__33>(ref <CreateRightEmptyAndPlayAsync>d__);
		return <CreateRightEmptyAndPlayAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013165 RID: 78181 RVA: 0x004BB82F File Offset: 0x004B9A2F
	private void RefreshRedDot()
	{
		base.GetItem(8).SetUIActive(PhoneMsgModel.Instance.IsChatShowHasRedDot());
	}

	// Token: 0x06013166 RID: 78182 RVA: 0x004BB848 File Offset: 0x004B9A48
	private void OnFilterChanged()
	{
		PhoneMsgModel.Instance.SortChatPartnerAndMessages();
		List<int> allChatPartnerIds = PhoneMsgModel.Instance.GetAllChatPartnerIds();
		this.ChatPartnerTabItemDataList = new List<ChatPartnerTabItemData>();
		int count = allChatPartnerIds.Count;
		for (int i = 0; i < count; i++)
		{
			int chatPartnerId = allChatPartnerIds[i];
			if (PhoneMsgModel.Instance.IsThisChatPartnerCanShow(chatPartnerId))
			{
				ChatPartnerTabItemData item = new ChatPartnerTabItemData(chatPartnerId);
				this.ChatPartnerTabItemDataList.Add(item);
			}
		}
		if (PhoneMsgModel.Instance.SelectedFilterIdSet.Count != 0)
		{
			PhoneSystemChatPanel chatPanel = this.ChatPanel;
			if (chatPanel != null)
			{
				chatPanel.SetUiActive(false);
			}
			base.GetItem(1).SetUIActive(true);
			this.CurSelectTogChatItem = null;
			this.CurrentShowShortMessageId = 0;
			EventSystem.Instance.Emit<int, int>(EEventName.OnPhoneMsgChatTabClick, 0, 0);
		}
		GenericScrollViewNew<PhoneSystemChatPartnerTabItem, ChatPartnerTabItemData> chatPartnerTabItemList = this.ChatPartnerTabItemList;
		if (chatPartnerTabItemList != null)
		{
			GenericLayout<PhoneSystemChatPartnerTabItem, ChatPartnerTabItemData> genericLayout = chatPartnerTabItemList.GetGenericLayout();
			if (genericLayout != null)
			{
				genericLayout.DeselectCurrentGridProxy();
			}
		}
		this.RefreshTabsAndReselectAsync().Forget();
	}

	// Token: 0x06013167 RID: 78183 RVA: 0x004BB92C File Offset: 0x004B9B2C
	private UniTask RefreshTabsAndReselectAsync()
	{
		PhoneMsgPanelViewBig.<RefreshTabsAndReselectAsync>d__36 <RefreshTabsAndReselectAsync>d__;
		<RefreshTabsAndReselectAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshTabsAndReselectAsync>d__.<>4__this = this;
		<RefreshTabsAndReselectAsync>d__.<>1__state = -1;
		<RefreshTabsAndReselectAsync>d__.<>t__builder.Start<PhoneMsgPanelViewBig.<RefreshTabsAndReselectAsync>d__36>(ref <RefreshTabsAndReselectAsync>d__);
		return <RefreshTabsAndReselectAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013168 RID: 78184 RVA: 0x004BB970 File Offset: 0x004B9B70
	protected override void OnBeforeDestroy()
	{
		PhoneSystemCharm charmPanel = this.CharmPanel;
		if (charmPanel != null)
		{
			charmPanel.Destroy(null);
		}
		this.CharmPanel = null;
		LevelSequencePlayer seqPlayer = this.SeqPlayer;
		if (seqPlayer != null)
		{
			seqPlayer.Clear();
		}
		this.SeqPlayer = null;
		LevelSequencePlayer levelSequencePlayer = this.title1SeqPlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.Clear();
		}
		this.title1SeqPlayer = null;
		LevelSequencePlayer levelSequencePlayer2 = this.rightEmptySeqPlayer;
		if (levelSequencePlayer2 != null)
		{
			levelSequencePlayer2.Clear();
		}
		this.rightEmptySeqPlayer = null;
	}

	// Token: 0x06013169 RID: 78185 RVA: 0x004BB9DE File Offset: 0x004B9BDE
	private void OnInputControllerMainTypeChange(EInputControllerMainType last, EInputControllerMainType now)
	{
		this.SetChatSelectPanelBlackMarkEnable(false);
	}

	// Token: 0x0601316A RID: 78186 RVA: 0x004BB9E8 File Offset: 0x004B9BE8
	private void InitChatPartnerTabDataList()
	{
		PhoneMsgModel.Instance.SortChatPartnerAndMessages();
		List<int> allChatPartnerIds = PhoneMsgModel.Instance.GetAllChatPartnerIds();
		this.ChatPartnerTabItemDataList = new List<ChatPartnerTabItemData>();
		int count = allChatPartnerIds.Count;
		for (int i = 0; i < count; i++)
		{
			ChatPartnerTabItemData item = new ChatPartnerTabItemData(allChatPartnerIds[i]);
			this.ChatPartnerTabItemDataList.Add(item);
		}
	}

	// Token: 0x0601316B RID: 78187 RVA: 0x004BBA44 File Offset: 0x004B9C44
	private UniTask CreateAndRefreshChatPartnerTab()
	{
		PhoneMsgPanelViewBig.<CreateAndRefreshChatPartnerTab>d__40 <CreateAndRefreshChatPartnerTab>d__;
		<CreateAndRefreshChatPartnerTab>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateAndRefreshChatPartnerTab>d__.<>4__this = this;
		<CreateAndRefreshChatPartnerTab>d__.<>1__state = -1;
		<CreateAndRefreshChatPartnerTab>d__.<>t__builder.Start<PhoneMsgPanelViewBig.<CreateAndRefreshChatPartnerTab>d__40>(ref <CreateAndRefreshChatPartnerTab>d__);
		return <CreateAndRefreshChatPartnerTab>d__.<>t__builder.Task;
	}

	// Token: 0x0601316C RID: 78188 RVA: 0x004BBA87 File Offset: 0x004B9C87
	[NullableContext(1)]
	private PhoneSystemChatPartnerTabItem CreateChatPartnerTabItem()
	{
		PhoneSystemChatPartnerTabItem phoneSystemChatPartnerTabItem = new PhoneSystemChatPartnerTabItem();
		phoneSystemChatPartnerTabItem.SetClickCallBack(new Action<int>(this.HandleSelectGridProxy));
		phoneSystemChatPartnerTabItem.OnSetSelectCallBack = new Action(this.AfterHandleSelectGridProxy);
		phoneSystemChatPartnerTabItem.SetRefreshMainPanelFunc(new Action<int, TogChatTalkItem>(this.OnSelectUpdateChatPanel));
		return phoneSystemChatPartnerTabItem;
	}

	// Token: 0x0601316D RID: 78189 RVA: 0x004BBAC4 File Offset: 0x004B9CC4
	private void HandleSelectGridProxy(int index)
	{
		if (this.ChatPartnerTabItemList.GetSelectedIndex() == index)
		{
			this.ChatPartnerTabItemList.GetGenericLayout().DeselectCurrentGridProxy();
			return;
		}
		this.CurrentIndex = index;
		this.ChatPartnerTabItemList.SelectGridProxy(index, false);
	}

	// Token: 0x0601316E RID: 78190 RVA: 0x004BBAF9 File Offset: 0x004B9CF9
	private void AfterHandleSelectGridProxy()
	{
		this.TryScrollToCanSee(this.CurrentIndex);
	}

	// Token: 0x0601316F RID: 78191 RVA: 0x004BBB08 File Offset: 0x004B9D08
	private void TryScrollToCanSee(int index)
	{
		UUIItem item = this.ChatPartnerTabItemList.GetItemByIndex(index);
		if (item != null)
		{
			TTimerAction <>9__1;
			this.ChatPartnerTabItemList.BindLateUpdate(delegate(float delta)
			{
				TimerSystemInstance gameplayTimeInstance = TimerSystem.GameplayTimeInstance;
				TTimerAction action;
				if ((action = <>9__1) == null)
				{
					action = (<>9__1 = delegate(float _)
					{
						if (this.ChatPartnerTabItemList.IsItemInViewport(item, 1f) != EOutOfBoundsType.NotOut)
						{
							this.ChatPartnerTabItemList.ScrollToTopByIndex(index);
						}
					});
				}
				gameplayTimeInstance.Next(action, null, null);
				this.ChatPartnerTabItemList.UnBindLateUpdate();
			});
		}
	}

	// Token: 0x06013170 RID: 78192 RVA: 0x004BBB5F File Offset: 0x004B9D5F
	[NullableContext(1)]
	public void OnSelectUpdateChatPanel(int shortMessageId, TogChatTalkItem tog)
	{
		this.CurSelectTogChatItem = tog;
		this.CheckAndCloseTips(shortMessageId);
		if (this.CurrentShowShortMessageId == shortMessageId)
		{
			return;
		}
		this.UpdateChatPanel(shortMessageId);
	}

	// Token: 0x06013171 RID: 78193 RVA: 0x004BBB81 File Offset: 0x004B9D81
	public void CheckAndCloseTips(int shortMessageId)
	{
	}

	// Token: 0x06013172 RID: 78194 RVA: 0x004BBB83 File Offset: 0x004B9D83
	public void OnHandleMessagesToDelete()
	{
		ScrollingTipsController.Instance.ShowTipsByTextId("Message_ForceCloseTips", Array.Empty<object>());
		base.CloseMe(null);
	}

	// Token: 0x06013173 RID: 78195 RVA: 0x004BBBA0 File Offset: 0x004B9DA0
	[NullableContext(1)]
	public void RefreshCurSelectChatTabTextShow(string lastChatText)
	{
		if (this.CurSelectTogChatItem == null)
		{
			return;
		}
		this.CurSelectTogChatItem.SetShowChatText(lastChatText);
	}

	// Token: 0x06013174 RID: 78196 RVA: 0x004BBBB8 File Offset: 0x004B9DB8
	public void RefreshTargetChatItemText(int shortMessageId)
	{
		if (this.CurrentShowShortMessageId == shortMessageId)
		{
			return;
		}
		ShortMessage? phoneMsgConfig = PhoneMsgConfig.Instance.GetPhoneMsgConfig(shortMessageId);
		int? num = (phoneMsgConfig != null) ? new int?(phoneMsgConfig.Value.WhichChat) : null;
		if (num == null)
		{
			return;
		}
		GenericScrollViewNew<PhoneSystemChatPartnerTabItem, ChatPartnerTabItemData> chatPartnerTabItemList = this.ChatPartnerTabItemList;
		PhoneSystemChatPartnerTabItem phoneSystemChatPartnerTabItem = (chatPartnerTabItemList != null) ? chatPartnerTabItemList.GetScrollItemByKey(num.Value) : null;
		if (phoneSystemChatPartnerTabItem == null)
		{
			return;
		}
		phoneSystemChatPartnerTabItem.RefreshShowChatText(shortMessageId, EGetLastChatTextType.FromLastCanReadIndex);
		this.CurrentShowShortMessageId = shortMessageId;
	}

	// Token: 0x06013175 RID: 78197 RVA: 0x004BBC44 File Offset: 0x004B9E44
	public UniTask UpdateChatPanel(int shortMessageId)
	{
		PhoneMsgPanelViewBig.<UpdateChatPanel>d__51 <UpdateChatPanel>d__;
		<UpdateChatPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<UpdateChatPanel>d__.<>4__this = this;
		<UpdateChatPanel>d__.shortMessageId = shortMessageId;
		<UpdateChatPanel>d__.<>1__state = -1;
		<UpdateChatPanel>d__.<>t__builder.Start<PhoneMsgPanelViewBig.<UpdateChatPanel>d__51>(ref <UpdateChatPanel>d__);
		return <UpdateChatPanel>d__.<>t__builder.Task;
	}

	// Token: 0x06013176 RID: 78198 RVA: 0x004BBC8F File Offset: 0x004B9E8F
	private void OnClickCloseBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x06013177 RID: 78199 RVA: 0x004BBC98 File Offset: 0x004B9E98
	private void OnSetClick()
	{
		if (this.ChatPanel != null && this.ChatPanel.GetIsPlaying)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("Message_ForbidSetting", Array.Empty<object>());
			return;
		}
		UiManager.Instance.OpenView(EUiViewName.PhoneMsgSettingView, null, null);
	}

	// Token: 0x06013178 RID: 78200 RVA: 0x004BBCD8 File Offset: 0x004B9ED8
	private void LogReportOpenPhoneView(EPhoneMsgOpenWay openWay, EPhoneMsgViewType reason)
	{
		OnOpenPhoneViewLogEvent onOpenPhoneViewLogEvent = new OnOpenPhoneViewLogEvent();
		onOpenPhoneViewLogEvent.i_open_way = (int)openWay;
		onOpenPhoneViewLogEvent.i_reason = (int)reason;
		LogReportController.Instance.LogReport(onOpenPhoneViewLogEvent);
	}

	// Token: 0x06013179 RID: 78201 RVA: 0x004BBD04 File Offset: 0x004B9F04
	[NullableContext(1)]
	public PhoneSystemChatProxy GetProxy()
	{
		return this.Proxy;
	}

	// Token: 0x0601317A RID: 78202 RVA: 0x004BBD0C File Offset: 0x004B9F0C
	public void SetChatSelectPanelBlackMarkEnable(bool isEnable)
	{
		foreach (PhoneSystemChatPartnerTabItem phoneSystemChatPartnerTabItem in this.ChatPartnerTabItemList.GetScrollItemList())
		{
			phoneSystemChatPartnerTabItem.SetChangeAlpha(isEnable);
		}
	}

	// Token: 0x0601317B RID: 78203 RVA: 0x004BBD64 File Offset: 0x004B9F64
	private void SelectAndScrollToChatPartner(int chatPartnerId)
	{
		for (int i = 0; i < this.ChatPartnerTabItemDataList.Count; i++)
		{
			if (this.ChatPartnerTabItemDataList[i].ChatPartnerId == chatPartnerId)
			{
				this.ChatPartnerTabItemList.SelectGridProxy(i, false);
				this.TryScrollToCanSee(i);
			}
		}
	}

	// Token: 0x04009010 RID: 36880
	private int CurrentShowShortMessageId;

	// Token: 0x04009011 RID: 36881
	private PopupCaptionItem CaptionItem;

	// Token: 0x04009012 RID: 36882
	private PhoneSystemChatPanel ChatPanel;

	// Token: 0x04009013 RID: 36883
	private TogChatTalkItem CurSelectTogChatItem;

	// Token: 0x04009014 RID: 36884
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<PhoneSystemChatPartnerTabItem, ChatPartnerTabItemData> ChatPartnerTabItemList;

	// Token: 0x04009015 RID: 36885
	[Nullable(1)]
	private List<ChatPartnerTabItemData> ChatPartnerTabItemDataList = new List<ChatPartnerTabItemData>();

	// Token: 0x04009016 RID: 36886
	private LevelSequencePlayer SeqPlayer;

	// Token: 0x04009017 RID: 36887
	private LevelSequencePlayer title1SeqPlayer;

	// Token: 0x04009018 RID: 36888
	private LevelSequencePlayer rightEmptySeqPlayer;

	// Token: 0x04009019 RID: 36889
	[Nullable(1)]
	private PhoneSystemChatProxy Proxy;

	// Token: 0x0400901A RID: 36890
	private PhoneViewFilterEntry FilterPanel;

	// Token: 0x0400901B RID: 36891
	private PhoneSystemCharm CharmPanel;

	// Token: 0x0400901C RID: 36892
	private string charmPrepath = "";

	// Token: 0x0400901D RID: 36893
	private UiPanelBase title1pre;

	// Token: 0x0400901E RID: 36894
	private UiPanelBase leftchatpre;

	// Token: 0x0400901F RID: 36895
	private UiPanelBase rightchatpre;

	// Token: 0x04009020 RID: 36896
	private UiPanelBase rightemptypre;

	// Token: 0x04009021 RID: 36897
	[Nullable(1)]
	private string title1prepath = "";

	// Token: 0x04009022 RID: 36898
	private string leftchatprepath = "";

	// Token: 0x04009023 RID: 36899
	private string rightchatprepath = "";

	// Token: 0x04009024 RID: 36900
	private string rightemptyprepath = "";

	// Token: 0x04009025 RID: 36901
	private int CurrentIndex = -1;

	// Token: 0x02008A9C RID: 35484
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402D01C RID: 184348
		ItemCaption,
		// Token: 0x0402D01D RID: 184349
		PanelNull,
		// Token: 0x0402D01E RID: 184350
		TabScroll,
		// Token: 0x0402D01F RID: 184351
		Content,
		// Token: 0x0402D020 RID: 184352
		ChatPartnerTabItem,
		// Token: 0x0402D021 RID: 184353
		BtnSet,
		// Token: 0x0402D022 RID: 184354
		PanelPhoneSystemChatPanel,
		// Token: 0x0402D023 RID: 184355
		Null,
		// Token: 0x0402D024 RID: 184356
		SettingBtnRedDotItem,
		// Token: 0x0402D025 RID: 184357
		ItemFilter,
		// Token: 0x0402D026 RID: 184358
		PartnerEmpty,
		// Token: 0x0402D027 RID: 184359
		TexPanelL,
		// Token: 0x0402D028 RID: 184360
		TexModelT,
		// Token: 0x0402D029 RID: 184361
		TexSkinEmptyBg,
		// Token: 0x0402D02A RID: 184362
		SprBg,
		// Token: 0x0402D02B RID: 184363
		TxtTitle,
		// Token: 0x0402D02C RID: 184364
		PnlContentSkinL,
		// Token: 0x0402D02D RID: 184365
		PnlContentSkinTitle,
		// Token: 0x0402D02E RID: 184366
		PnlContentSkinEmptyR,
		// Token: 0x0402D02F RID: 184367
		TexSkinR,
		// Token: 0x0402D030 RID: 184368
		TexSkinRTopicShow,
		// Token: 0x0402D031 RID: 184369
		PnlPetContent
	}
}
