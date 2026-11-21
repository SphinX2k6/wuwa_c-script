using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PhoneMessage;
using CSharpScript.Game.Ui;
using CSharpScript.Game.Ui.PhoneMessage.View;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001A00 RID: 6656
[NullableContext(2)]
[Nullable(0)]
public class PhoneMsgPanelViewBig : UiViewBase
{
	// Token: 0x06010618 RID: 67096 RVA: 0x004C8B50 File Offset: 0x004C6D50
	[NullableContext(1)]
	public PhoneMsgPanelViewBig(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06010619 RID: 67097 RVA: 0x004C8BA8 File Offset: 0x004C6DA8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIMultiTemplateScrollViewComponent)),
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

	// Token: 0x0601061A RID: 67098 RVA: 0x004C8DD4 File Offset: 0x004C6FD4
	protected override UniTask OnBeforeStartAsync()
	{
		PhoneMsgPanelViewBig.<OnBeforeStartAsync>d__24 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PhoneMsgPanelViewBig.<OnBeforeStartAsync>d__24>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601061B RID: 67099 RVA: 0x004C8E17 File Offset: 0x004C7017
	protected override void OnBeforeShow()
	{
		this.RefreshRedDot();
		this.RefreshChatShow();
	}

	// Token: 0x0601061C RID: 67100 RVA: 0x004C8E28 File Offset: 0x004C7028
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnPhoneHaveMsgToRemove, new Action(this.OnHandleMessagesToDelete));
		EventSystem.Instance.Add<EInputControllerMainType, EInputControllerMainType>(EEventName.InputControllerMainTypeChange, new Action<EInputControllerMainType, EInputControllerMainType>(this.OnInputControllerMainTypeChange));
		EventSystem.Instance.Add(EEventName.PhoneMsgDialogBgThemeCharmRedDotUpdate, new Action(this.RefreshRedDot));
		EventSystem.Instance.Add(EEventName.OnPhoneMsgFilterChanged, new Action(this.OnFilterChanged));
		EventSystem.Instance.Add(EEventName.OnPhoneMsgChatShowChange, new Action(this.RefreshChatShow));
	}

	// Token: 0x0601061D RID: 67101 RVA: 0x004C8EC4 File Offset: 0x004C70C4
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnPhoneHaveMsgToRemove, new Action(this.OnHandleMessagesToDelete));
		EventSystem.Instance.Remove(EEventName.InputControllerMainTypeChange, new Action<EInputControllerMainType, EInputControllerMainType>(this.OnInputControllerMainTypeChange));
		EventSystem.Instance.Remove(EEventName.PhoneMsgDialogBgThemeCharmRedDotUpdate, new Action(this.RefreshRedDot));
		EventSystem.Instance.Remove(EEventName.OnPhoneMsgFilterChanged, new Action(this.OnFilterChanged));
		EventSystem.Instance.Remove(EEventName.OnPhoneMsgChatShowChange, new Action(this.RefreshChatShow));
	}

	// Token: 0x0601061E RID: 67102 RVA: 0x004C8F5D File Offset: 0x004C715D
	private void RefreshChatShow()
	{
		this.RefreshByTheme(PhoneMsgModel.Instance.CurrentUsingChatThemeId);
		this.SetSpineByCharmId(PhoneMsgModel.Instance.CurrentUsingChatCharmId);
	}

	// Token: 0x0601061F RID: 67103 RVA: 0x004C8F80 File Offset: 0x004C7180
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

	// Token: 0x06010620 RID: 67104 RVA: 0x004C9054 File Offset: 0x004C7254
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

	// Token: 0x06010621 RID: 67105 RVA: 0x004C90B0 File Offset: 0x004C72B0
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

	// Token: 0x06010622 RID: 67106 RVA: 0x004C94E4 File Offset: 0x004C76E4
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

	// Token: 0x06010623 RID: 67107 RVA: 0x004C9538 File Offset: 0x004C7738
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

	// Token: 0x06010624 RID: 67108 RVA: 0x004C958B File Offset: 0x004C778B
	private void RefreshRedDot()
	{
		base.GetItem(8).SetUIActive(PhoneMsgModel.Instance.IsChatShowHasRedDot());
	}

	// Token: 0x06010625 RID: 67109 RVA: 0x004C95A4 File Offset: 0x004C77A4
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
		PhoneSystemChatPartnerTabScroll chatPartnerTabScroll = this.ChatPartnerTabScroll;
		if (chatPartnerTabScroll != null)
		{
			chatPartnerTabScroll.DeselectPartner();
		}
		this.CurSelectPartnerId = 0;
		this.RefreshTabsAndReselectAsync().Forget();
	}

	// Token: 0x06010626 RID: 67110 RVA: 0x004C9684 File Offset: 0x004C7884
	private UniTask RefreshTabsAndReselectAsync()
	{
		PhoneMsgPanelViewBig.<RefreshTabsAndReselectAsync>d__36 <RefreshTabsAndReselectAsync>d__;
		<RefreshTabsAndReselectAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshTabsAndReselectAsync>d__.<>4__this = this;
		<RefreshTabsAndReselectAsync>d__.<>1__state = -1;
		<RefreshTabsAndReselectAsync>d__.<>t__builder.Start<PhoneMsgPanelViewBig.<RefreshTabsAndReselectAsync>d__36>(ref <RefreshTabsAndReselectAsync>d__);
		return <RefreshTabsAndReselectAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010627 RID: 67111 RVA: 0x004C96C8 File Offset: 0x004C78C8
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

	// Token: 0x06010628 RID: 67112 RVA: 0x004C9736 File Offset: 0x004C7936
	private void OnInputControllerMainTypeChange(EInputControllerMainType last, EInputControllerMainType now)
	{
		this.SetChatSelectPanelBlackMarkEnable(false);
	}

	// Token: 0x06010629 RID: 67113 RVA: 0x004C9740 File Offset: 0x004C7940
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

	// Token: 0x0601062A RID: 67114 RVA: 0x004C979C File Offset: 0x004C799C
	private UniTask CreateAndRefreshChatPartnerTab()
	{
		PhoneMsgPanelViewBig.<CreateAndRefreshChatPartnerTab>d__40 <CreateAndRefreshChatPartnerTab>d__;
		<CreateAndRefreshChatPartnerTab>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateAndRefreshChatPartnerTab>d__.<>4__this = this;
		<CreateAndRefreshChatPartnerTab>d__.<>1__state = -1;
		<CreateAndRefreshChatPartnerTab>d__.<>t__builder.Start<PhoneMsgPanelViewBig.<CreateAndRefreshChatPartnerTab>d__40>(ref <CreateAndRefreshChatPartnerTab>d__);
		return <CreateAndRefreshChatPartnerTab>d__.<>t__builder.Task;
	}

	// Token: 0x0601062B RID: 67115 RVA: 0x004C97DF File Offset: 0x004C79DF
	private void HandleSelectGridProxy(int partnerId)
	{
		if (this.CurSelectPartnerId == partnerId)
		{
			this.ChatPartnerTabScroll.DeselectPartner();
			this.CurSelectPartnerId = 0;
			return;
		}
		this.CurSelectPartnerId = partnerId;
		this.ChatPartnerTabScroll.SelectPartner(partnerId);
		this.ChatPartnerTabScroll.TryScrollToPartner(partnerId);
	}

	// Token: 0x0601062C RID: 67116 RVA: 0x004C981C File Offset: 0x004C7A1C
	[NullableContext(1)]
	public void OnGamepadFocusPartner(UUISelectableComponent component)
	{
		if (this.ChatPartnerTabScroll == null)
		{
			return;
		}
		int partnerIdByComponent = this.ChatPartnerTabScroll.GetPartnerIdByComponent(component);
		if (partnerIdByComponent == 0)
		{
			return;
		}
		if (this.LastFocusedPartnerId == partnerIdByComponent)
		{
			return;
		}
		this.LastFocusedPartnerId = partnerIdByComponent;
		if (this.CurSelectPartnerId == partnerIdByComponent)
		{
			return;
		}
		this.CurSelectPartnerId = partnerIdByComponent;
		this.ChatPartnerTabScroll.SelectPartner(partnerIdByComponent);
		this.ChatPartnerTabScroll.TryScrollToPartner(partnerIdByComponent);
	}

	// Token: 0x0601062D RID: 67117 RVA: 0x004C987D File Offset: 0x004C7A7D
	[NullableContext(1)]
	public void OnSelectUpdateChatPanel(int shortMessageId, TogChatTalkItem tog)
	{
		this.CurSelectTogChatItem = tog;
		PhoneSystemChatPartnerTabScroll chatPartnerTabScroll = this.ChatPartnerTabScroll;
		if (chatPartnerTabScroll != null)
		{
			chatPartnerTabScroll.SetSelectedShortMsgId(shortMessageId);
		}
		this.CheckAndCloseTips(shortMessageId);
		if (this.CurrentShowShortMessageId == shortMessageId)
		{
			return;
		}
		this.UpdateChatPanel(shortMessageId);
	}

	// Token: 0x0601062E RID: 67118 RVA: 0x004C98B1 File Offset: 0x004C7AB1
	public void CheckAndCloseTips(int shortMessageId)
	{
	}

	// Token: 0x0601062F RID: 67119 RVA: 0x004C98B3 File Offset: 0x004C7AB3
	public void OnHandleMessagesToDelete()
	{
		ScrollingTipsController.Instance.ShowTipsByTextId("Message_ForceCloseTips", Array.Empty<object>());
		base.CloseMe(null);
	}

	// Token: 0x06010630 RID: 67120 RVA: 0x004C98D0 File Offset: 0x004C7AD0
	[NullableContext(1)]
	public void RefreshCurSelectChatTabTextShow(string lastChatText)
	{
		if (this.CurSelectTogChatItem == null)
		{
			return;
		}
		if (this.CurSelectTogChatItem.ShortMsgId != this.CurrentShowShortMessageId)
		{
			return;
		}
		this.CurSelectTogChatItem.SetShowChatText(lastChatText);
	}

	// Token: 0x06010631 RID: 67121 RVA: 0x004C98FC File Offset: 0x004C7AFC
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
		PhoneSystemChatPartnerTabScroll chatPartnerTabScroll = this.ChatPartnerTabScroll;
		if (chatPartnerTabScroll != null)
		{
			chatPartnerTabScroll.RefreshPartnerChatText(num.Value, shortMessageId, EGetLastChatTextType.FromLastCanReadIndex);
		}
		this.CurrentShowShortMessageId = shortMessageId;
	}

	// Token: 0x06010632 RID: 67122 RVA: 0x004C9974 File Offset: 0x004C7B74
	public UniTask UpdateChatPanel(int shortMessageId)
	{
		PhoneMsgPanelViewBig.<UpdateChatPanel>d__50 <UpdateChatPanel>d__;
		<UpdateChatPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<UpdateChatPanel>d__.<>4__this = this;
		<UpdateChatPanel>d__.shortMessageId = shortMessageId;
		<UpdateChatPanel>d__.<>1__state = -1;
		<UpdateChatPanel>d__.<>t__builder.Start<PhoneMsgPanelViewBig.<UpdateChatPanel>d__50>(ref <UpdateChatPanel>d__);
		return <UpdateChatPanel>d__.<>t__builder.Task;
	}

	// Token: 0x06010633 RID: 67123 RVA: 0x004C99BF File Offset: 0x004C7BBF
	private void OnClickCloseBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x06010634 RID: 67124 RVA: 0x004C99C8 File Offset: 0x004C7BC8
	private void OnSetClick()
	{
		if (this.ChatPanel != null && this.ChatPanel.GetIsPlaying)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("Message_ForbidSetting", Array.Empty<object>());
			return;
		}
		UiManager.Instance.OpenView(EUiViewName.PhoneMsgSettingView, null, null);
	}

	// Token: 0x06010635 RID: 67125 RVA: 0x004C9A08 File Offset: 0x004C7C08
	private void LogReportOpenPhoneView(EPhoneMsgOpenWay openWay, EPhoneMsgViewType reason)
	{
		OnOpenPhoneViewLogEvent onOpenPhoneViewLogEvent = new OnOpenPhoneViewLogEvent();
		onOpenPhoneViewLogEvent.i_open_way = (int)openWay;
		onOpenPhoneViewLogEvent.i_reason = (int)reason;
		LogReportController.Instance.LogReport(onOpenPhoneViewLogEvent);
	}

	// Token: 0x06010636 RID: 67126 RVA: 0x004C9A34 File Offset: 0x004C7C34
	[NullableContext(1)]
	public PhoneSystemChatProxy GetProxy()
	{
		return this.Proxy;
	}

	// Token: 0x06010637 RID: 67127 RVA: 0x004C9A3C File Offset: 0x004C7C3C
	public void SetChatSelectPanelBlackMarkEnable(bool isEnable)
	{
		PhoneSystemChatPartnerTabScroll chatPartnerTabScroll = this.ChatPartnerTabScroll;
		if (chatPartnerTabScroll == null)
		{
			return;
		}
		chatPartnerTabScroll.SetAllDisplayingBlackMark(isEnable);
	}

	// Token: 0x06010638 RID: 67128 RVA: 0x004C9A4F File Offset: 0x004C7C4F
	private void SelectAndScrollToChatPartner(int chatPartnerId)
	{
		if (this.ChatPartnerTabScroll == null)
		{
			return;
		}
		if (this.ChatPartnerTabScroll.GetGridIndexByPartnerId(chatPartnerId) < 0)
		{
			return;
		}
		this.CurSelectPartnerId = chatPartnerId;
		this.ChatPartnerTabScroll.SelectPartner(chatPartnerId);
	}

	// Token: 0x04009164 RID: 37220
	private int CurrentShowShortMessageId;

	// Token: 0x04009165 RID: 37221
	private PopupCaptionItem CaptionItem;

	// Token: 0x04009166 RID: 37222
	private PhoneSystemChatPanel ChatPanel;

	// Token: 0x04009167 RID: 37223
	private TogChatTalkItem CurSelectTogChatItem;

	// Token: 0x04009168 RID: 37224
	private PhoneSystemChatPartnerTabScroll ChatPartnerTabScroll;

	// Token: 0x04009169 RID: 37225
	[Nullable(1)]
	private List<ChatPartnerTabItemData> ChatPartnerTabItemDataList = new List<ChatPartnerTabItemData>();

	// Token: 0x0400916A RID: 37226
	private LevelSequencePlayer SeqPlayer;

	// Token: 0x0400916B RID: 37227
	private LevelSequencePlayer title1SeqPlayer;

	// Token: 0x0400916C RID: 37228
	private LevelSequencePlayer rightEmptySeqPlayer;

	// Token: 0x0400916D RID: 37229
	[Nullable(1)]
	private PhoneSystemChatProxy Proxy;

	// Token: 0x0400916E RID: 37230
	private PhoneViewFilterEntry FilterPanel;

	// Token: 0x0400916F RID: 37231
	private PhoneSystemCharm CharmPanel;

	// Token: 0x04009170 RID: 37232
	private string charmPrepath = "";

	// Token: 0x04009171 RID: 37233
	private UiPanelBase title1pre;

	// Token: 0x04009172 RID: 37234
	private UiPanelBase leftchatpre;

	// Token: 0x04009173 RID: 37235
	private UiPanelBase rightchatpre;

	// Token: 0x04009174 RID: 37236
	private UiPanelBase rightemptypre;

	// Token: 0x04009175 RID: 37237
	[Nullable(1)]
	private string title1prepath = "";

	// Token: 0x04009176 RID: 37238
	private string leftchatprepath = "";

	// Token: 0x04009177 RID: 37239
	private string rightchatprepath = "";

	// Token: 0x04009178 RID: 37240
	private string rightemptyprepath = "";

	// Token: 0x04009179 RID: 37241
	private int CurSelectPartnerId;

	// Token: 0x0400917A RID: 37242
	private int LastFocusedPartnerId;

	// Token: 0x02007C24 RID: 31780
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04028334 RID: 164660
		ItemCaption,
		// Token: 0x04028335 RID: 164661
		PanelNull,
		// Token: 0x04028336 RID: 164662
		TabScroll,
		// Token: 0x04028337 RID: 164663
		Content,
		// Token: 0x04028338 RID: 164664
		ChatPartnerTabItem,
		// Token: 0x04028339 RID: 164665
		BtnSet,
		// Token: 0x0402833A RID: 164666
		PanelPhoneSystemChatPanel,
		// Token: 0x0402833B RID: 164667
		Null,
		// Token: 0x0402833C RID: 164668
		SettingBtnRedDotItem,
		// Token: 0x0402833D RID: 164669
		ItemFilter,
		// Token: 0x0402833E RID: 164670
		PartnerEmpty,
		// Token: 0x0402833F RID: 164671
		TexPanelL,
		// Token: 0x04028340 RID: 164672
		TexModelT,
		// Token: 0x04028341 RID: 164673
		TexSkinEmptyBg,
		// Token: 0x04028342 RID: 164674
		SprBg,
		// Token: 0x04028343 RID: 164675
		TxtTitle,
		// Token: 0x04028344 RID: 164676
		PnlContentSkinL,
		// Token: 0x04028345 RID: 164677
		PnlContentSkinTitle,
		// Token: 0x04028346 RID: 164678
		PnlContentSkinEmptyR,
		// Token: 0x04028347 RID: 164679
		TexSkinR,
		// Token: 0x04028348 RID: 164680
		TexSkinRTopicShow,
		// Token: 0x04028349 RID: 164681
		PnlPetContent
	}
}
