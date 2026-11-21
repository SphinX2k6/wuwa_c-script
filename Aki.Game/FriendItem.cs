using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Friend;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020010FA RID: 4346
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class FriendItem : GridProxyAbstract<FriendItemSt>
{
	// Token: 0x0600ADA9 RID: 44457 RVA: 0x00331F58 File Offset: 0x00330158
	public FriendItem(EUiViewName belongView, UUIItem uiItem = null)
	{
		this.BelongView = new EUiViewName?(belongView);
		FriendModel.Instance.ShowingView = this.BelongView;
		if (uiItem != null)
		{
			this.CreateThenShowByActor(uiItem.GetOwner());
		}
	}

	// Token: 0x0600ADAA RID: 44458 RVA: 0x00331FAC File Offset: 0x003301AC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 21;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(17, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(20, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(12, new Action(this.OnClickFriendItemBtn));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600ADAB RID: 44459 RVA: 0x003322D4 File Offset: 0x003304D4
	protected override UniTask OnBeforeStartAsync()
	{
		FriendItem.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FriendItem.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600ADAC RID: 44460 RVA: 0x00332318 File Offset: 0x00330518
	protected override void OnStart()
	{
		this.ConfirmBtn = new ButtonAndTextItem(base.GetItem(11));
		this.TeamItem = new TeamItem(base.GetItem(10));
		this.ConfirmBtn.BindCallback(new Action(this.OnClickConfirmButton));
		this.HeadPhotoItem = new PlayerHeadItem(base.GetItem(0).GetOwner());
		List<UUIItem> list = new List<UUIItem>();
		list.Add(base.GetItem(6));
		list.Add(base.GetItem(7));
		list.Add(base.GetItem(14));
		list.Add(base.GetItem(15));
		list.Add(base.GetItem(16));
		int count = list.Count;
		for (int i = 0; i < count; i++)
		{
			this.ButtonList.Add(new ButtonAndSpriteItem(list[i]));
		}
		this.ButtonInfoList.Add(new FunctionButtonInfo("SP_RefuseFriend", new Func<bool>(this.GetRefuseButtonState), new Action(this.OnClickRefuseBtn)));
		this.ButtonInfoList.Add(new FunctionButtonInfo("SP_RemoveFriend", new Func<bool>(this.GetRemoveButtonState), new Action(this.OnClickRemoveBtn)));
		this.ButtonInfoList.Add(new FunctionButtonInfo("SP_AddFriend", new Func<bool>(this.GetAddButtonState), new Action(this.OnClickAddBtn)));
		this.ButtonInfoList.Add(new FunctionButtonInfo("SP_AgreeFriend", new Func<bool>(this.GetAgreeButtonState), new Action(this.OnClickAgreeBtn)));
		this.ButtonInfoList.Add(new FunctionButtonInfo("SP_ChatFriend", new Func<bool>(this.GetChatButtonState), new Action(this.OnClickChatButton)));
	}

	// Token: 0x0600ADAD RID: 44461 RVA: 0x003324CE File Offset: 0x003306CE
	private void OnClickConfirmButton()
	{
		if (this.GetPlayerData().PlayerIsOnline && this.IfCanEnterOtherWorld())
		{
			OnlineController.Instance.ApplyJoinWorldRequest(this.GetPlayerData().PlayerId, WorldEnterWay.LobbyJoin);
		}
	}

	// Token: 0x0600ADAE RID: 44462 RVA: 0x003324FB File Offset: 0x003306FB
	[NullableContext(1)]
	public override void Refresh(FriendItemSt playerData, bool isSelected, int gridIndex)
	{
		this.UpdateItem(playerData.Id);
		if (playerData.OperationType == EFriendItemOperation.SendApply)
		{
			this.RefreshOnSent();
			return;
		}
		if (playerData.OperationType == EFriendItemOperation.Approve || playerData.OperationType == EFriendItemOperation.Refuse)
		{
			this.RefreshButtonList();
		}
	}

	// Token: 0x0600ADAF RID: 44463 RVA: 0x00332534 File Offset: 0x00330734
	public void RefreshMute()
	{
		bool uiactive = ChatModel.Instance.IsInMute(this.GetPlayerData().PlayerId);
		base.GetItem(1).SetUIActive(uiactive);
	}

	// Token: 0x0600ADB0 RID: 44464 RVA: 0x00332564 File Offset: 0x00330764
	private void UpdateItem(int playerDataId)
	{
		this.FriendInstanceId = playerDataId;
		FriendData playerData = this.GetPlayerData();
		this.ShowNecessaryItem();
		if (playerData != null)
		{
			this.HeadPhotoItem.RefreshByHeadPhotoId(playerData.PlayerHeadPhoto);
			base.GetText(3).SetText("Lv." + playerData.PlayerLevel.ToString(), true);
			if (this.IsInBlackList)
			{
				PlayerTitleItem titleItem = this.TitleItem;
				if (titleItem != null)
				{
					titleItem.GetRootItem().SetUIActive(false);
				}
			}
			else
			{
				PlayerTitleItem titleItem2 = this.TitleItem;
				if (titleItem2 != null)
				{
					titleItem2.Refresh(new int?(playerData.PlayerTitleId), new int?(playerData.PlayerTitleStarLevel), new int?(playerData.PlayerSex));
				}
			}
		}
		this.RefreshOnlineStateShow();
	}

	// Token: 0x0600ADB1 RID: 44465 RVA: 0x0033261C File Offset: 0x0033081C
	private void ShowNecessaryItem()
	{
		this.RefreshMute();
		this.RefreshRedPoint();
		this.RefreshName();
		this.RefreshConfirmButtonText();
		this.RefreshConfirmButtonShowState();
		this.RefreshButtonList();
		this.RefreshTeamItem();
		this.RefreshPlayerSign();
		this.RefreshCurdCard();
		this.RefreshThirdPartyItem();
		this.RefreshPcItem();
	}

	// Token: 0x0600ADB2 RID: 44466 RVA: 0x0033266B File Offset: 0x0033086B
	private void RefreshPlayerSign()
	{
		base.GetText(9).SetText(this.GetPlayerData().Signature, true);
		base.GetItem(13).SetUIActive(this.GetPlayerData().Signature.Length > 0);
	}

	// Token: 0x0600ADB3 RID: 44467 RVA: 0x003326A8 File Offset: 0x003308A8
	private void RefreshCurdCard()
	{
		int curCard = this.GetPlayerData().CurCard;
		if (curCard > 0)
		{
			base.SetTextureByPath(ConfigBackgroundCardById.GetConfig(curCard, true).Value.LongCardPath, base.GetTexture(8), null, null);
		}
	}

	// Token: 0x0600ADB4 RID: 44468 RVA: 0x003326F4 File Offset: 0x003308F4
	private void RefreshTeamItem()
	{
		if (FriendModel.Instance.FilterState.GetValueOrDefault() != EFriendFilter.RecentMultiple)
		{
			this.TeamItem.SetActive(false);
			return;
		}
		this.TeamItem.SetActive(true);
		this.TeamItem.RefreshView(this.GetPlayerData());
	}

	// Token: 0x0600ADB5 RID: 44469 RVA: 0x00332740 File Offset: 0x00330940
	[NullableContext(1)]
	private bool UpdateButton(ButtonAndSpriteItem button, FunctionButtonInfo buttonInfo)
	{
		if (buttonInfo.StateFunc())
		{
			button.RefreshSprite(buttonInfo.SpritePath);
			button.BindCallback(buttonInfo.CallBack);
			return true;
		}
		return false;
	}

	// Token: 0x0600ADB6 RID: 44470 RVA: 0x0033276C File Offset: 0x0033096C
	private void RefreshButtonList()
	{
		for (int i = 0; i < this.ButtonList.Count; i++)
		{
			ButtonAndSpriteItem buttonAndSpriteItem = this.ButtonList[i];
			FunctionButtonInfo functionButtonInfo = this.ButtonInfoList[i];
			this.UpdateButton(buttonAndSpriteItem, functionButtonInfo);
			bool uiactive = functionButtonInfo.StateFunc();
			buttonAndSpriteItem.GetRootItem().SetUIActive(uiactive);
		}
	}

	// Token: 0x0600ADB7 RID: 44471 RVA: 0x003327CA File Offset: 0x003309CA
	private bool GetChatButtonState()
	{
		return FriendModel.Instance.IsMyFriend(this.GetPlayerData().PlayerId);
	}

	// Token: 0x0600ADB8 RID: 44472 RVA: 0x003327E4 File Offset: 0x003309E4
	private bool GetRemoveButtonState()
	{
		return this.BelongView == EUiViewName.FriendBlackListView;
	}

	// Token: 0x0600ADB9 RID: 44473 RVA: 0x00332818 File Offset: 0x00330A18
	private bool GetRefuseButtonState()
	{
		return (FriendModel.Instance.FilterState.GetValueOrDefault() == EFriendFilter.FriendRequest && this.BelongView == EUiViewName.FriendView) || (this.BelongView == EUiViewName.FriendSearchView && FriendModel.Instance.HasFriendApplication(this.GetPlayerData().PlayerId));
	}

	// Token: 0x0600ADBA RID: 44474 RVA: 0x003328A8 File Offset: 0x00330AA8
	private bool GetAddButtonState()
	{
		return !FriendModel.Instance.IsMyFriend(this.GetPlayerData().PlayerId) && !FriendModel.Instance.HasFriendApplication(this.GetPlayerData().PlayerId) && (this.BelongView == EUiViewName.FriendSearchView || (FriendModel.Instance.FilterState.GetValueOrDefault() == EFriendFilter.RecentMultiple && this.BelongView == EUiViewName.FriendView));
	}

	// Token: 0x0600ADBB RID: 44475 RVA: 0x00332954 File Offset: 0x00330B54
	private bool GetAgreeButtonState()
	{
		return (FriendModel.Instance.FilterState.GetValueOrDefault() == EFriendFilter.FriendRequest && this.BelongView == EUiViewName.FriendView) || (this.BelongView == EUiViewName.FriendSearchView && FriendModel.Instance.HasFriendApplication(this.GetPlayerData().PlayerId));
	}

	// Token: 0x0600ADBC RID: 44476 RVA: 0x003329E4 File Offset: 0x00330BE4
	private void RefreshConfirmButtonShowState()
	{
		bool flag = false;
		if (this.BelongView == EUiViewName.FriendView && (FriendModel.Instance.FilterState.GetValueOrDefault() == EFriendFilter.FriendList || FriendModel.Instance.FilterState.GetValueOrDefault() == EFriendFilter.RecentMultiple))
		{
			flag = true;
		}
		this.ConfirmBtn.SetActive(flag);
		if (flag)
		{
			this.RefreshConfirmButtonEnable();
		}
	}

	// Token: 0x0600ADBD RID: 44477 RVA: 0x00332A5C File Offset: 0x00330C5C
	private void RefreshConfirmButtonEnable()
	{
		this.ConfirmBtn.RefreshEnable(this.GetPlayerData().PlayerIsOnline && this.IfCanEnterOtherWorld() && FunctionModel.Instance.IsOpen(10021));
	}

	// Token: 0x0600ADBE RID: 44478 RVA: 0x00332A90 File Offset: 0x00330C90
	private void RefreshConfirmButtonText()
	{
		if (!FunctionModel.Instance.IsOpen(10021))
		{
			this.ConfirmBtn.RefreshText("FriendOnlineDisable", Array.Empty<object>());
			return;
		}
		if (!this.GetPlayerData().PlayerIsOnline)
		{
			this.ConfirmBtn.RefreshText("OfflineText", Array.Empty<object>());
			return;
		}
		if (!this.IfCanEnterOtherWorld())
		{
			this.ConfirmBtn.RefreshText("ApplyBtnDisable", new object[]
			{
				this.GetPlayerData().WorldLevel - OnlineModel.Instance.EnterDiff
			});
			return;
		}
		this.ConfirmBtn.RefreshText("FriendApplyJoin", Array.Empty<object>());
	}

	// Token: 0x0600ADBF RID: 44479 RVA: 0x00332B39 File Offset: 0x00330D39
	private bool IfCanEnterOtherWorld()
	{
		return OnlineModel.Instance.CanJoinOtherWorld(WorldLevelModel.Instance.OriginWorldLevel, this.GetPlayerData().WorldLevel);
	}

	// Token: 0x0600ADC0 RID: 44480 RVA: 0x00332B5C File Offset: 0x00330D5C
	private void RefreshName()
	{
		UUIText text = base.GetText(2);
		FriendController instance = FriendController.Instance;
		FriendData playerData = this.GetPlayerData();
		if (instance.CheckRemarkIsValid(((playerData != null) ? playerData.FriendRemark : null) ?? ""))
		{
			text.SetText("(" + this.GetPlayerData().FriendRemark + ")", true);
			return;
		}
		UUIText uuitext = text;
		FriendData playerData2 = this.GetPlayerData();
		uuitext.SetText(((playerData2 != null) ? playerData2.PlayerName : null) ?? "", true);
	}

	// Token: 0x0600ADC1 RID: 44481 RVA: 0x00332BDC File Offset: 0x00330DDC
	private void RefreshRedPoint()
	{
	}

	// Token: 0x0600ADC2 RID: 44482 RVA: 0x00332BE0 File Offset: 0x00330DE0
	private void RefreshOnlineStateShow()
	{
		bool playerIsOnline = this.GetPlayerData().PlayerIsOnline;
		UUIText text = base.GetText(5);
		if (this.BelongView == EUiViewName.FriendBlackListView)
		{
			text.SetText("", true);
		}
		else if (playerIsOnline)
		{
			LguiUtil.Instance.SetLocalText(text, "FriendOnline", Array.Empty<object>());
		}
		else
		{
			FriendData playerData = this.GetPlayerData();
			if (playerData.PlayerLastOfflineTime == 0L)
			{
				text.SetText("", true);
			}
			else
			{
				ValueTuple<string, int> offlineStrAndGap = FriendModel.GetOfflineStrAndGap(playerData.PlayerLastOfflineTime);
				LguiUtil.Instance.SetLocalText(text, offlineStrAndGap.Item1, new <>z__ReadOnlySingleElementList<object>(offlineStrAndGap.Item2));
			}
		}
		base.GetText(2).useChangeColor = !playerIsOnline;
		base.GetText(3).useChangeColor = !playerIsOnline;
		text.useChangeColor = !playerIsOnline;
		this.RefreshOnLinePoint();
	}

	// Token: 0x0600ADC3 RID: 44483 RVA: 0x00332CD4 File Offset: 0x00330ED4
	private void RefreshOnLinePoint()
	{
		UUISprite sprite = base.GetSprite(4);
		bool uiactive = true;
		string text = null;
		if (this.BelongView == EUiViewName.FriendBlackListView)
		{
			uiactive = false;
		}
		else if (this.GetPlayerData().PlayerIsOnline)
		{
			text = "SP_FriendOnline";
		}
		else
		{
			text = "SP_FriendOffline";
		}
		sprite.SetUIActive(uiactive);
		if (!string.IsNullOrEmpty(text))
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(text);
			this.SetSpriteByPath(resourcePath, sprite, false, null, null);
		}
	}

	// Token: 0x0600ADC4 RID: 44484 RVA: 0x00332D66 File Offset: 0x00330F66
	private FriendData GetPlayerData()
	{
		return FriendModel.Instance.GetSelectedPlayerOrItemInstance(new int?(this.FriendInstanceId), this.BelongView);
	}

	// Token: 0x0600ADC5 RID: 44485 RVA: 0x00332D84 File Offset: 0x00330F84
	private void OnClickRefuseBtn()
	{
		FriendData selectedPlayerOrItemInstance = FriendModel.Instance.GetSelectedPlayerOrItemInstance(new int?(this.FriendInstanceId), null);
		if (selectedPlayerOrItemInstance != null && selectedPlayerOrItemInstance.Debug)
		{
			return;
		}
		FriendData playerData = this.GetPlayerData();
		if (playerData != null)
		{
			this.RequestSendIdList = new List<int>();
			this.RequestSendIdList.Add(playerData.PlayerId);
			FriendController.Instance.RequestFriendApplyHandle(this.RequestSendIdList, FriendApplyOperator.Reject);
			return;
		}
		FriendController.Instance.LocalRemoveApplicationFriend(this.FriendInstanceId);
		GenericPromptController.Instance.ShowPromptByCode("FriendRequestOutOfDate", Array.Empty<object>());
	}

	// Token: 0x0600ADC6 RID: 44486 RVA: 0x00332E1C File Offset: 0x0033101C
	private void OnClickAgreeBtn()
	{
		FriendData playerData = this.GetPlayerData();
		if (FriendModel.Instance.HasFriend(this.FriendInstanceId))
		{
			FriendController.Instance.LocalRemoveApplicationFriend(this.FriendInstanceId);
			if (playerData != null)
			{
				EventSystem.Instance.Emit<EFriendItemOperation, IReadOnlyList<int>>(EEventName.ApplicationHandled, EFriendItemOperation.Approve, new <>z__ReadOnlySingleElementList<int>(playerData.PlayerId));
			}
		}
		FriendData selectedPlayerOrItemInstance = FriendModel.Instance.GetSelectedPlayerOrItemInstance(new int?(this.FriendInstanceId), null);
		if (selectedPlayerOrItemInstance != null && selectedPlayerOrItemInstance.Debug)
		{
			return;
		}
		if (playerData == null)
		{
			FriendController.Instance.LocalRemoveApplicationFriend(this.FriendInstanceId);
			GenericPromptController.Instance.ShowPromptByCode("FriendRequestOutOfDate", Array.Empty<object>());
			return;
		}
		int friendListCount = FriendModel.Instance.GetFriendListCount();
		int friendLimitByViewType = FriendConfig.Instance.GetFriendLimitByViewType(EFriendFilter.FriendList);
		if (friendListCount + 1 > friendLimitByViewType)
		{
			GenericPromptController.Instance.ShowPromptByCode("FriendListFull", Array.Empty<object>());
			return;
		}
		this.RequestSendIdList = new List<int>();
		this.RequestSendIdList.Add(playerData.PlayerId);
		FriendController.Instance.RequestFriendApplyHandle(this.RequestSendIdList, FriendApplyOperator.Approve);
	}

	// Token: 0x0600ADC7 RID: 44487 RVA: 0x00332F24 File Offset: 0x00331124
	private void OnClickAddBtn()
	{
		FriendData selectedPlayerOrItemInstance = FriendModel.Instance.GetSelectedPlayerOrItemInstance(new int?(this.FriendInstanceId), null);
		if (selectedPlayerOrItemInstance != null && selectedPlayerOrItemInstance.Debug)
		{
			return;
		}
		FriendApplyWay fromWhere = FriendApplyWay.Search;
		if (this.BelongView == EUiViewName.FriendView && FriendModel.Instance.FilterState.GetValueOrDefault() == EFriendFilter.RecentMultiple)
		{
			fromWhere = FriendApplyWay.RecentlyTeam;
		}
		FriendData playerData = this.GetPlayerData();
		if (playerData != null)
		{
			int friendListCount = FriendModel.Instance.GetFriendListCount();
			int friendLimitByViewType = FriendConfig.Instance.GetFriendLimitByViewType(EFriendFilter.FriendList);
			if (friendListCount + 1 > friendLimitByViewType)
			{
				GenericPromptController.Instance.ShowPromptByCode("FriendListFull", Array.Empty<object>());
				return;
			}
			FriendController.Instance.RequestFriendApplyAddSend(playerData.PlayerId, fromWhere);
		}
	}

	// Token: 0x0600ADC8 RID: 44488 RVA: 0x00332FF0 File Offset: 0x003311F0
	private void OnClickRemoveBtn()
	{
		FriendData selectedPlayerOrItemInstance = FriendModel.Instance.GetSelectedPlayerOrItemInstance(new int?(this.FriendInstanceId), null);
		if (selectedPlayerOrItemInstance != null && selectedPlayerOrItemInstance.Debug)
		{
			return;
		}
		FriendData playerData = this.GetPlayerData();
		if (playerData != null)
		{
			FriendController.Instance.RequestUnBlockPlayer(playerData.PlayerId);
			return;
		}
		GenericPromptController.Instance.ShowPromptByCode("IsNotBlockedPlayer", Array.Empty<object>());
	}

	// Token: 0x0600ADC9 RID: 44489 RVA: 0x0033305C File Offset: 0x0033125C
	private void OnClickChatButton()
	{
		FriendData playerData = this.GetPlayerData();
		if (playerData == null)
		{
			return;
		}
		ChatController.Instance.OpenFriendChat(playerData.PlayerId);
	}

	// Token: 0x0600ADCA RID: 44490 RVA: 0x00333084 File Offset: 0x00331284
	private void RefreshPcItem()
	{
		if (KuroSdkController.Instance.NeedShowThirdPartyId())
		{
			FriendData playerData = this.GetPlayerData();
			if (((playerData != null) ? playerData.GetSdkUserId() : null) != "")
			{
				UUIItem item = base.GetItem(19);
				if (item == null)
				{
					return;
				}
				item.SetUIActive(false);
				return;
			}
			else
			{
				UUIItem item2 = base.GetItem(19);
				if (item2 == null)
				{
					return;
				}
				item2.SetUIActive(true);
				return;
			}
		}
		else
		{
			UUIItem item3 = base.GetItem(19);
			if (item3 == null)
			{
				return;
			}
			item3.SetUIActive(false);
			return;
		}
	}

	// Token: 0x0600ADCB RID: 44491 RVA: 0x003330F8 File Offset: 0x003312F8
	private void RefreshThirdPartyItem()
	{
		if (KuroSdkController.Instance.NeedShowThirdPartyId())
		{
			FriendData playerData = this.GetPlayerData();
			bool flag = ((playerData != null) ? playerData.GetSdkUserId() : null) != "";
			UUITexture texture = base.GetTexture(17);
			if (texture != null)
			{
				texture.SetUIActive(flag);
			}
			UUIText text = base.GetText(18);
			if (text != null)
			{
				text.SetUIActive(flag);
			}
			if (flag)
			{
				FriendData playerData2 = this.GetPlayerData();
				string newText = ((playerData2 != null) ? playerData2.GetSdkOnlineId() : null) ?? "";
				UUIText text2 = base.GetText(18);
				if (text2 != null)
				{
					text2.SetText(newText, true);
				}
			}
			string thirdPartyLogoTexturePath = UiResourceConfig.Instance.GetThirdPartyLogoTexturePath(ELogoSize.Medium);
			base.SetTextureByPath(thirdPartyLogoTexturePath, base.GetTexture(17), null, null);
			string thirdPartyTextColor = UiResourceConfig.Instance.GetThirdPartyTextColor(EConsoleColorSet.Set2);
			UUIText text3 = base.GetText(18);
			if (text3 == null)
			{
				return;
			}
			text3.SetColor(FColor.FromHex(thirdPartyTextColor));
			return;
		}
		else
		{
			UUITexture texture2 = base.GetTexture(17);
			if (texture2 != null)
			{
				texture2.SetUIActive(false);
			}
			UUIText text4 = base.GetText(18);
			if (text4 == null)
			{
				return;
			}
			text4.SetUIActive(false);
			return;
		}
	}

	// Token: 0x0600ADCC RID: 44492 RVA: 0x00333200 File Offset: 0x00331400
	private void OnClickFriendItemBtn()
	{
		FriendData selectedPlayerOrItemInstance = FriendModel.Instance.GetSelectedPlayerOrItemInstance(new int?(this.FriendInstanceId), null);
		if (selectedPlayerOrItemInstance != null && selectedPlayerOrItemInstance.Debug)
		{
			return;
		}
		FriendData playerData = this.GetPlayerData();
		if (playerData == null)
		{
			this.ShowFindNullFriendTipsByViewType();
			EventSystem.Instance.Emit(EEventName.UpdateFriendViewShow);
			return;
		}
		int playerId = playerData.PlayerId;
		FriendController.Instance.RequestPlayerCurrentDeactivationState(playerId, delegate(bool deactivation)
		{
			if (deactivation)
			{
				string localTextNew = ConfigMultiTextLang.GetLocalTextNew("PlayerDeleteSelf", null);
				GenericPromptController.Instance.ShowPromptByItsType<object>(EPromptSubViewType.FloatLinePrompt, null, null, new string[]
				{
					localTextNew
				}, null, null, null, null, null, false, null);
				return;
			}
			FriendModel.Instance.SelectedPlayerId = new int?(this.FriendInstanceId);
			FriendModel.Instance.SetCurrentOperationPlayerId(this.FriendInstanceId);
			FriendModel.Instance.ShowingView = this.BelongView;
			UiManager.Instance.OpenView(EUiViewName.FriendProcessView, null, null);
		});
	}

	// Token: 0x0600ADCD RID: 44493 RVA: 0x0033327C File Offset: 0x0033147C
	private void ShowFindNullFriendTipsByViewType()
	{
		EFriendFilter? filterState = FriendModel.Instance.FilterState;
		if (filterState.GetValueOrDefault() == EFriendFilter.FriendList)
		{
			GenericPromptController.Instance.ShowPromptByCode("FriendDeleteEach", Array.Empty<object>());
			return;
		}
		if (filterState.GetValueOrDefault() == EFriendFilter.FriendRequest)
		{
			GenericPromptController.Instance.ShowPromptByCode("FriendRequestOutOfDate", Array.Empty<object>());
		}
	}

	// Token: 0x0600ADCE RID: 44494 RVA: 0x003332D1 File Offset: 0x003314D1
	private void RefreshOnSent()
	{
		if (FriendModel.Instance.CurrentApplyFriendListHasPlayer(this.FriendInstanceId))
		{
			this.RefreshButtonList();
		}
	}

	// Token: 0x0600ADCF RID: 44495 RVA: 0x003332EB File Offset: 0x003314EB
	public void SetIsInBlackList(bool isInBlackList)
	{
		this.IsInBlackList = isInBlackList;
	}

	// Token: 0x040063FA RID: 25594
	private ButtonAndTextItem ConfirmBtn;

	// Token: 0x040063FB RID: 25595
	private TeamItem TeamItem;

	// Token: 0x040063FC RID: 25596
	protected int FriendInstanceId;

	// Token: 0x040063FD RID: 25597
	protected EUiViewName? BelongView;

	// Token: 0x040063FE RID: 25598
	private List<int> RequestSendIdList;

	// Token: 0x040063FF RID: 25599
	private PlayerHeadItem HeadPhotoItem;

	// Token: 0x04006400 RID: 25600
	private PlayerTitleItem TitleItem;

	// Token: 0x04006401 RID: 25601
	[Nullable(1)]
	private readonly List<ButtonAndSpriteItem> ButtonList = new List<ButtonAndSpriteItem>();

	// Token: 0x04006402 RID: 25602
	[Nullable(1)]
	private readonly List<FunctionButtonInfo> ButtonInfoList = new List<FunctionButtonInfo>();

	// Token: 0x04006403 RID: 25603
	private bool IsInBlackList;

	// Token: 0x02007387 RID: 29575
	[NullableContext(0)]
	private class EItemComponents
	{
		// Token: 0x040259D9 RID: 154073
		public const int HeadPhotoItem = 0;

		// Token: 0x040259DA RID: 154074
		public const int ShieldNode = 1;

		// Token: 0x040259DB RID: 154075
		public const int NameText = 2;

		// Token: 0x040259DC RID: 154076
		public const int LevelText = 3;

		// Token: 0x040259DD RID: 154077
		public const int OnlineStateSprite = 4;

		// Token: 0x040259DE RID: 154078
		public const int OnlineStateText = 5;

		// Token: 0x040259DF RID: 154079
		public const int FirstButtonItem = 6;

		// Token: 0x040259E0 RID: 154080
		public const int SecondButtonItem = 7;

		// Token: 0x040259E1 RID: 154081
		public const int PlayerTextureBg = 8;

		// Token: 0x040259E2 RID: 154082
		public const int PlayerSignText = 9;

		// Token: 0x040259E3 RID: 154083
		public const int TeamItem = 10;

		// Token: 0x040259E4 RID: 154084
		public const int ConfirmBtnItem = 11;

		// Token: 0x040259E5 RID: 154085
		public const int FriendItemButton = 12;

		// Token: 0x040259E6 RID: 154086
		public const int SignItem = 13;

		// Token: 0x040259E7 RID: 154087
		public const int ThirdButtonItem = 14;

		// Token: 0x040259E8 RID: 154088
		public const int ForthButtonItem = 15;

		// Token: 0x040259E9 RID: 154089
		public const int FifthButtonItem = 16;

		// Token: 0x040259EA RID: 154090
		public const int ThirdPartyTexture = 17;

		// Token: 0x040259EB RID: 154091
		public const int ThirdPartyText = 18;

		// Token: 0x040259EC RID: 154092
		public const int PcItem = 19;

		// Token: 0x040259ED RID: 154093
		public const int PlayerTitleItem = 20;
	}
}
