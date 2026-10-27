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

// Token: 0x02001C3B RID: 7227
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class FriendItem : GridProxyAbstract<FriendItemSt>
{
	// Token: 0x0600D993 RID: 55699 RVA: 0x00326B58 File Offset: 0x00324D58
	public FriendItem(EUiViewName belongView, UUIItem uiItem = null)
	{
		this.BelongView = new EUiViewName?(belongView);
		FriendModel.Instance.ShowingView = this.BelongView;
		if (uiItem != null)
		{
			this.CreateThenShowByActor(uiItem.GetOwner());
		}
	}

	// Token: 0x0600D994 RID: 55700 RVA: 0x00326BAC File Offset: 0x00324DAC
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

	// Token: 0x0600D995 RID: 55701 RVA: 0x00326ED4 File Offset: 0x003250D4
	protected override UniTask OnBeforeStartAsync()
	{
		FriendItem.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FriendItem.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600D996 RID: 55702 RVA: 0x00326F18 File Offset: 0x00325118
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

	// Token: 0x0600D997 RID: 55703 RVA: 0x003270CE File Offset: 0x003252CE
	private void OnClickConfirmButton()
	{
		if (this.GetPlayerData().PlayerIsOnline && this.IfCanEnterOtherWorld())
		{
			OnlineController.Instance.ApplyJoinWorldRequest(this.GetPlayerData().PlayerId, WorldEnterWay.LobbyJoin);
		}
	}

	// Token: 0x0600D998 RID: 55704 RVA: 0x003270FB File Offset: 0x003252FB
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

	// Token: 0x0600D999 RID: 55705 RVA: 0x00327134 File Offset: 0x00325334
	public void RefreshMute()
	{
		bool uiactive = ChatModel.Instance.IsInMute(this.GetPlayerData().PlayerId);
		base.GetItem(1).SetUIActive(uiactive);
	}

	// Token: 0x0600D99A RID: 55706 RVA: 0x00327164 File Offset: 0x00325364
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

	// Token: 0x0600D99B RID: 55707 RVA: 0x0032721C File Offset: 0x0032541C
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

	// Token: 0x0600D99C RID: 55708 RVA: 0x0032726B File Offset: 0x0032546B
	private void RefreshPlayerSign()
	{
		base.GetText(9).SetText(this.GetPlayerData().Signature, true);
		base.GetItem(13).SetUIActive(this.GetPlayerData().Signature.Length > 0);
	}

	// Token: 0x0600D99D RID: 55709 RVA: 0x003272A8 File Offset: 0x003254A8
	private void RefreshCurdCard()
	{
		int curCard = this.GetPlayerData().CurCard;
		if (curCard > 0)
		{
			base.SetTextureByPath(ConfigBackgroundCardById.GetConfig(curCard, true).Value.LongCardPath, base.GetTexture(8), null, null);
		}
	}

	// Token: 0x0600D99E RID: 55710 RVA: 0x003272F4 File Offset: 0x003254F4
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

	// Token: 0x0600D99F RID: 55711 RVA: 0x00327340 File Offset: 0x00325540
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

	// Token: 0x0600D9A0 RID: 55712 RVA: 0x0032736C File Offset: 0x0032556C
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

	// Token: 0x0600D9A1 RID: 55713 RVA: 0x003273CA File Offset: 0x003255CA
	private bool GetChatButtonState()
	{
		return FriendModel.Instance.IsMyFriend(this.GetPlayerData().PlayerId);
	}

	// Token: 0x0600D9A2 RID: 55714 RVA: 0x003273E4 File Offset: 0x003255E4
	private bool GetRemoveButtonState()
	{
		return this.BelongView == EUiViewName.FriendBlackListView;
	}

	// Token: 0x0600D9A3 RID: 55715 RVA: 0x00327418 File Offset: 0x00325618
	private bool GetRefuseButtonState()
	{
		return (FriendModel.Instance.FilterState.GetValueOrDefault() == EFriendFilter.FriendRequest && this.BelongView == EUiViewName.FriendView) || (this.BelongView == EUiViewName.FriendSearchView && FriendModel.Instance.HasFriendApplication(this.GetPlayerData().PlayerId));
	}

	// Token: 0x0600D9A4 RID: 55716 RVA: 0x003274A8 File Offset: 0x003256A8
	private bool GetAddButtonState()
	{
		return !FriendModel.Instance.IsMyFriend(this.GetPlayerData().PlayerId) && !FriendModel.Instance.HasFriendApplication(this.GetPlayerData().PlayerId) && (this.BelongView == EUiViewName.FriendSearchView || (FriendModel.Instance.FilterState.GetValueOrDefault() == EFriendFilter.RecentMultiple && this.BelongView == EUiViewName.FriendView));
	}

	// Token: 0x0600D9A5 RID: 55717 RVA: 0x00327554 File Offset: 0x00325754
	private bool GetAgreeButtonState()
	{
		return (FriendModel.Instance.FilterState.GetValueOrDefault() == EFriendFilter.FriendRequest && this.BelongView == EUiViewName.FriendView) || (this.BelongView == EUiViewName.FriendSearchView && FriendModel.Instance.HasFriendApplication(this.GetPlayerData().PlayerId));
	}

	// Token: 0x0600D9A6 RID: 55718 RVA: 0x003275E4 File Offset: 0x003257E4
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

	// Token: 0x0600D9A7 RID: 55719 RVA: 0x0032765C File Offset: 0x0032585C
	private void RefreshConfirmButtonEnable()
	{
		this.ConfirmBtn.RefreshEnable(this.GetPlayerData().PlayerIsOnline && this.IfCanEnterOtherWorld() && FunctionModel.Instance.IsOpen(10021));
	}

	// Token: 0x0600D9A8 RID: 55720 RVA: 0x00327690 File Offset: 0x00325890
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

	// Token: 0x0600D9A9 RID: 55721 RVA: 0x00327739 File Offset: 0x00325939
	private bool IfCanEnterOtherWorld()
	{
		return OnlineModel.Instance.CanJoinOtherWorld(WorldLevelModel.Instance.OriginWorldLevel, this.GetPlayerData().WorldLevel);
	}

	// Token: 0x0600D9AA RID: 55722 RVA: 0x0032775C File Offset: 0x0032595C
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

	// Token: 0x0600D9AB RID: 55723 RVA: 0x003277DC File Offset: 0x003259DC
	private void RefreshRedPoint()
	{
	}

	// Token: 0x0600D9AC RID: 55724 RVA: 0x003277E0 File Offset: 0x003259E0
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

	// Token: 0x0600D9AD RID: 55725 RVA: 0x003278D4 File Offset: 0x00325AD4
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

	// Token: 0x0600D9AE RID: 55726 RVA: 0x00327966 File Offset: 0x00325B66
	private FriendData GetPlayerData()
	{
		return FriendModel.Instance.GetSelectedPlayerOrItemInstance(new int?(this.FriendInstanceId), this.BelongView);
	}

	// Token: 0x0600D9AF RID: 55727 RVA: 0x00327984 File Offset: 0x00325B84
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

	// Token: 0x0600D9B0 RID: 55728 RVA: 0x00327A1C File Offset: 0x00325C1C
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

	// Token: 0x0600D9B1 RID: 55729 RVA: 0x00327B24 File Offset: 0x00325D24
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

	// Token: 0x0600D9B2 RID: 55730 RVA: 0x00327BF0 File Offset: 0x00325DF0
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

	// Token: 0x0600D9B3 RID: 55731 RVA: 0x00327C5C File Offset: 0x00325E5C
	private void OnClickChatButton()
	{
		FriendData playerData = this.GetPlayerData();
		if (playerData == null)
		{
			return;
		}
		ChatController.Instance.OpenFriendChat(playerData.PlayerId);
	}

	// Token: 0x0600D9B4 RID: 55732 RVA: 0x00327C84 File Offset: 0x00325E84
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

	// Token: 0x0600D9B5 RID: 55733 RVA: 0x00327CF8 File Offset: 0x00325EF8
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

	// Token: 0x0600D9B6 RID: 55734 RVA: 0x00327E00 File Offset: 0x00326000
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

	// Token: 0x0600D9B7 RID: 55735 RVA: 0x00327E7C File Offset: 0x0032607C
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

	// Token: 0x0600D9B8 RID: 55736 RVA: 0x00327ED1 File Offset: 0x003260D1
	private void RefreshOnSent()
	{
		if (FriendModel.Instance.CurrentApplyFriendListHasPlayer(this.FriendInstanceId))
		{
			this.RefreshButtonList();
		}
	}

	// Token: 0x0600D9B9 RID: 55737 RVA: 0x00327EEB File Offset: 0x003260EB
	public void SetIsInBlackList(bool isInBlackList)
	{
		this.IsInBlackList = isInBlackList;
	}

	// Token: 0x04006328 RID: 25384
	private ButtonAndTextItem ConfirmBtn;

	// Token: 0x04006329 RID: 25385
	private TeamItem TeamItem;

	// Token: 0x0400632A RID: 25386
	protected int FriendInstanceId;

	// Token: 0x0400632B RID: 25387
	protected EUiViewName? BelongView;

	// Token: 0x0400632C RID: 25388
	private List<int> RequestSendIdList;

	// Token: 0x0400632D RID: 25389
	private PlayerHeadItem HeadPhotoItem;

	// Token: 0x0400632E RID: 25390
	private PlayerTitleItem TitleItem;

	// Token: 0x0400632F RID: 25391
	[Nullable(1)]
	private readonly List<ButtonAndSpriteItem> ButtonList = new List<ButtonAndSpriteItem>();

	// Token: 0x04006330 RID: 25392
	[Nullable(1)]
	private readonly List<FunctionButtonInfo> ButtonInfoList = new List<FunctionButtonInfo>();

	// Token: 0x04006331 RID: 25393
	private bool IsInBlackList;

	// Token: 0x020081FE RID: 33278
	[NullableContext(0)]
	private class EItemComponents
	{
		// Token: 0x0402A6B2 RID: 173746
		public const int HeadPhotoItem = 0;

		// Token: 0x0402A6B3 RID: 173747
		public const int ShieldNode = 1;

		// Token: 0x0402A6B4 RID: 173748
		public const int NameText = 2;

		// Token: 0x0402A6B5 RID: 173749
		public const int LevelText = 3;

		// Token: 0x0402A6B6 RID: 173750
		public const int OnlineStateSprite = 4;

		// Token: 0x0402A6B7 RID: 173751
		public const int OnlineStateText = 5;

		// Token: 0x0402A6B8 RID: 173752
		public const int FirstButtonItem = 6;

		// Token: 0x0402A6B9 RID: 173753
		public const int SecondButtonItem = 7;

		// Token: 0x0402A6BA RID: 173754
		public const int PlayerTextureBg = 8;

		// Token: 0x0402A6BB RID: 173755
		public const int PlayerSignText = 9;

		// Token: 0x0402A6BC RID: 173756
		public const int TeamItem = 10;

		// Token: 0x0402A6BD RID: 173757
		public const int ConfirmBtnItem = 11;

		// Token: 0x0402A6BE RID: 173758
		public const int FriendItemButton = 12;

		// Token: 0x0402A6BF RID: 173759
		public const int SignItem = 13;

		// Token: 0x0402A6C0 RID: 173760
		public const int ThirdButtonItem = 14;

		// Token: 0x0402A6C1 RID: 173761
		public const int ForthButtonItem = 15;

		// Token: 0x0402A6C2 RID: 173762
		public const int FifthButtonItem = 16;

		// Token: 0x0402A6C3 RID: 173763
		public const int ThirdPartyTexture = 17;

		// Token: 0x0402A6C4 RID: 173764
		public const int ThirdPartyText = 18;

		// Token: 0x0402A6C5 RID: 173765
		public const int PcItem = 19;

		// Token: 0x0402A6C6 RID: 173766
		public const int PlayerTitleItem = 20;
	}
}
