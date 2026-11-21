using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020010FD RID: 4349
[NullableContext(2)]
[Nullable(0)]
public class FriendProcessView : UiViewBase
{
	// Token: 0x0600ADE4 RID: 44516 RVA: 0x003338C3 File Offset: 0x00331AC3
	[NullableContext(1)]
	public FriendProcessView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600ADE5 RID: 44517 RVA: 0x003338CC File Offset: 0x00331ACC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 19;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIGridLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(17, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnClickChatBtn));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(18, new Action(this.OnClickXboxButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600ADE6 RID: 44518 RVA: 0x00333BD4 File Offset: 0x00331DD4
	private void OnClickXboxButton()
	{
		FriendData selectedPlayerOrItemInstance = FriendModel.Instance.GetSelectedPlayerOrItemInstance(null, null);
		if (selectedPlayerOrItemInstance == null)
		{
			return;
		}
		KuroSdkController.Instance.OpenProfileCard(selectedPlayerOrItemInstance.GetSdkUserId());
	}

	// Token: 0x0600ADE7 RID: 44519 RVA: 0x00333C14 File Offset: 0x00331E14
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.UpdateFriendViewShow, new Action(this.CallBackUpdateFriendViewShow));
		EventSystem.Instance.Add<int>(EEventName.OnAddMutePlayer, new Action<int>(this.RefreshShieldState));
		EventSystem.Instance.Add<int>(EEventName.OnRemoveMutePlayer, new Action<int>(this.RefreshShieldState));
		EventSystem.Instance.Add(EEventName.UpdateBlackListShow, new Action(this.RefreshBlackBtn));
	}

	// Token: 0x0600ADE8 RID: 44520 RVA: 0x00333C94 File Offset: 0x00331E94
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.UpdateFriendViewShow, new Action(this.CallBackUpdateFriendViewShow));
		EventSystem.Instance.Remove(EEventName.OnAddMutePlayer, new Action<int>(this.RefreshShieldState));
		EventSystem.Instance.Remove(EEventName.OnRemoveMutePlayer, new Action<int>(this.RefreshShieldState));
		EventSystem.Instance.Remove(EEventName.UpdateBlackListShow, new Action(this.RefreshBlackBtn));
	}

	// Token: 0x0600ADE9 RID: 44521 RVA: 0x00333D14 File Offset: 0x00331F14
	protected override UniTask OnBeforeStartAsync()
	{
		FriendProcessView.<OnBeforeStartAsync>d__16 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FriendProcessView.<OnBeforeStartAsync>d__16>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600ADEA RID: 44522 RVA: 0x00333D58 File Offset: 0x00331F58
	protected override void OnStart()
	{
		this.HeadPhotoItem = new PlayerHeadItem(base.GetItem(0).GetOwner());
		base.GetText(4).SetText("", true);
		this.RefreshPersonalOptionItemLayout();
		FriendModel instance = FriendModel.Instance;
		FriendData selectedPlayerOrItemInstance = instance.GetSelectedPlayerOrItemInstance(null, null);
		instance.CachePlayerData = selectedPlayerOrItemInstance;
		EventSystem.Instance.Emit(EEventName.CsSyncCachePlayerData);
		this.UpdatePlayerDataShow();
	}

	// Token: 0x0600ADEB RID: 44523 RVA: 0x00333DD0 File Offset: 0x00331FD0
	private void RefreshPersonalOptionItemLayout()
	{
		if (this.PersonalOptionItemLayout != null)
		{
			this.PersonalOptionItemLayout.ClearChildren();
		}
		this.PersonalOptionItemLayout = new GenericLayoutNew<PersonalOptionItem>(base.GetGridLayout(9), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<PersonalOptionItem>(this.InitPersonalOptionItem), null);
		this.PersonalOptionItemLayout.RebuildLayoutByDataNew<int>(this.GetOptionDataList().ToArray(), null);
	}

	// Token: 0x0600ADEC RID: 44524 RVA: 0x00333E30 File Offset: 0x00332030
	[NullableContext(1)]
	private List<int> GetOptionDataList()
	{
		List<int> processViewFunctionList = FriendConfig.Instance.GetProcessViewFunctionList();
		List<int> list = new List<int>();
		foreach (int num in processViewFunctionList)
		{
			if (num != 12 || FunctionModel.Instance.IsOpen(10060))
			{
				list.Add(num);
			}
		}
		return list;
	}

	// Token: 0x0600ADED RID: 44525 RVA: 0x00333EA4 File Offset: 0x003320A4
	[NullableContext(1)]
	private ILayoutItem<PersonalOptionItem> InitPersonalOptionItem(object optionIntId, UUIItem uiItem, int index)
	{
		int num = (int)optionIntId;
		PersonalOptionItem personalOptionItem = new PersonalOptionItem(uiItem);
		personalOptionItem.Refresh(num, false, index);
		if (num == 1)
		{
			this.UnShieldBtn = personalOptionItem;
		}
		else if (num == 2)
		{
			this.ShieldBtn = personalOptionItem;
		}
		else if (num == 3)
		{
			this.BlockBtn = personalOptionItem;
		}
		else if (num == 4)
		{
			this.DeleteFriendBtn = personalOptionItem;
		}
		else if (num == 5)
		{
			this.ReportBtn = personalOptionItem;
		}
		else if (num == 12)
		{
			this.LookCardBtn = personalOptionItem;
		}
		else if (num == 13)
		{
			this.ChangeRemarkBtn = personalOptionItem;
		}
		return new LayoutItem<PersonalOptionItem>
		{
			Key = index,
			Value = personalOptionItem
		};
	}

	// Token: 0x0600ADEE RID: 44526 RVA: 0x00333F3C File Offset: 0x0033213C
	private void UpdatePlayerDataShow()
	{
		FriendData cachePlayerData = FriendModel.Instance.CachePlayerData;
		this.ShowNecessaryItem();
		this.HeadPhotoItem.RefreshByHeadPhotoId(cachePlayerData.PlayerHeadPhoto);
		base.GetText(5).SetText(cachePlayerData.PlayerLevel.ToString(), true);
		this.RefreshShieldState(cachePlayerData.PlayerId);
		this.TitleItem.Refresh(new int?(cachePlayerData.PlayerTitleId), new int?(cachePlayerData.PlayerTitleStarLevel), new int?(cachePlayerData.PlayerSex));
		int curCard = cachePlayerData.CurCard;
		if (curCard > 0)
		{
			base.SetTextureByPath(ConfigBackgroundCardById.GetConfig(curCard, true).Value.FunctionViewCardPath, base.GetTexture(17), null, null);
		}
	}

	// Token: 0x0600ADEF RID: 44527 RVA: 0x00333FFC File Offset: 0x003321FC
	public void RefreshMute()
	{
		FriendData selectedPlayerOrItemInstance = FriendModel.Instance.GetSelectedPlayerOrItemInstance(null, null);
		bool uiactive = ChatModel.Instance.IsInMute(selectedPlayerOrItemInstance.PlayerId);
		base.GetItem(8).SetUIActive(uiactive);
	}

	// Token: 0x0600ADF0 RID: 44528 RVA: 0x00334044 File Offset: 0x00332244
	private void RefreshName()
	{
		FriendModel instance = FriendModel.Instance;
		UUIText text = base.GetText(2);
		if (FriendController.Instance.CheckRemarkIsValid(instance.GetSelectedPlayerOrItemInstance(null, null).FriendRemark))
		{
			text.SetText("(" + instance.GetSelectedPlayerOrItemInstance(null, null).FriendRemark + ")", true);
			text.useChangeColor = true;
			return;
		}
		text.SetText(instance.GetSelectedPlayerOrItemInstance(null, null).PlayerName, true);
		text.useChangeColor = false;
	}

	// Token: 0x0600ADF1 RID: 44529 RVA: 0x003340F0 File Offset: 0x003322F0
	private void RefreshPlayStationItem()
	{
		KuroSdkController instance = KuroSdkController.Instance;
		if (((instance != null) ? new bool?(instance.NeedShowThirdPartyId()) : null).GetValueOrDefault())
		{
			bool flag = FriendModel.Instance.GetSelectedPlayerOrItemInstance(null, null).GetSdkUserId() != "";
			UUIItem item = base.GetItem(12);
			if (item != null)
			{
				item.SetUIActive(flag && Info.Instance.IsPs5Platform());
			}
			UUIButtonComponent button = base.GetButton(18);
			if (button != null)
			{
				button.RootUIComp.Get().SetUIActive(flag && Info.Instance.IsXboxPlatform());
			}
			string sdkOnlineId = FriendModel.Instance.GetSelectedPlayerOrItemInstance(null, null).GetSdkOnlineId();
			if (flag && Info.Instance.IsPs5Platform())
			{
				UUIText text = base.GetText(13);
				if (text != null)
				{
					text.SetText(sdkOnlineId, true);
				}
			}
			else if (flag && Info.Instance.IsXboxPlatform())
			{
				UUIText text2 = base.GetText(19);
				if (text2 != null)
				{
					text2.SetText(sdkOnlineId, true);
				}
			}
			UUIItem item2 = base.GetItem(16);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(!flag);
			return;
		}
		else
		{
			UUIItem item3 = base.GetItem(12);
			if (item3 != null)
			{
				item3.SetUIActive(false);
			}
			UUIItem item4 = base.GetItem(16);
			if (item4 == null)
			{
				return;
			}
			item4.SetUIActive(false);
			return;
		}
	}

	// Token: 0x0600ADF2 RID: 44530 RVA: 0x00334258 File Offset: 0x00332458
	private void RefreshSign()
	{
		FriendModel instance = FriendModel.Instance;
		FriendData selectedPlayerOrItemInstance = instance.GetSelectedPlayerOrItemInstance(null, null);
		string text = (selectedPlayerOrItemInstance != null) ? selectedPlayerOrItemInstance.Signature : null;
		UUIText text2 = base.GetText(11);
		if (text != null && text != "")
		{
			text2.SetText(text, true);
			return;
		}
		FriendData selectedPlayerOrItemInstance2 = instance.GetSelectedPlayerOrItemInstance(null, null);
		int? num = (selectedPlayerOrItemInstance2 != null) ? new int?(selectedPlayerOrItemInstance2.PlayerId) : null;
		int playerId = FunctionModel.Instance.PlayerId;
		if (!(num.GetValueOrDefault() == playerId & num != null))
		{
			if (text2 != null)
			{
				text2.SetText("", true);
				return;
			}
		}
		else
		{
			LguiUtil.Instance.SetLocalText(text2, "EmptySign", Array.Empty<object>());
		}
	}

	// Token: 0x0600ADF3 RID: 44531 RVA: 0x00334330 File Offset: 0x00332530
	private void ShowNecessaryItem()
	{
		FriendModel instance = FriendModel.Instance;
		EFriendFilter? filterState = instance.FilterState;
		EUiViewName? showingView = instance.ShowingView;
		this.RefreshName();
		this.RefreshSign();
		this.RefreshPlayStationItem();
		this.ChangeRemarkBtn.GetRootItem().SetUIActive(instance.IsMyFriend(instance.GetSelectedPlayerOrItemInstance(null, null).PlayerId));
		this.ShieldBtn.GetRootItem().SetUIActive(((showingView == EUiViewName.FriendView || showingView == EUiViewName.FriendSearchView) && filterState.GetValueOrDefault() == EFriendFilter.FriendList) || filterState.GetValueOrDefault() == EFriendFilter.FriendRequest);
		this.ReportBtn.GetRootItem().SetUIActive(true);
		if (showingView == EUiViewName.FriendView || showingView == EUiViewName.FriendSearchView || showingView == EUiViewName.FriendBlackListView)
		{
			this.RefreshBlackBtn();
		}
		this.DeleteFriendBtn.GetRootItem().SetUIActive(instance.IsMyFriend(instance.GetSelectedPlayerOrItemInstance(null, null).PlayerId));
		base.GetButton(6).RootUIComp.Get().SetUIActive(instance.IsMyFriend(instance.GetSelectedPlayerOrItemInstance(null, null).PlayerId));
		PersonalOptionItem lookCardBtn = this.LookCardBtn;
		if (lookCardBtn == null)
		{
			return;
		}
		lookCardBtn.SetActive(true);
	}

	// Token: 0x0600ADF4 RID: 44532 RVA: 0x00334518 File Offset: 0x00332718
	private void RefreshBlackBtn()
	{
		FriendData cachePlayerData = FriendModel.Instance.CachePlayerData;
		if (!FriendModel.Instance.HasBlockedPlayer(cachePlayerData.PlayerId))
		{
			this.BlockBtn.GetRootItem().SetUIActive(true);
			return;
		}
		this.BlockBtn.GetRootItem().SetUIActive(false);
	}

	// Token: 0x0600ADF5 RID: 44533 RVA: 0x00334568 File Offset: 0x00332768
	private void RefreshShieldState(int playerId)
	{
		this.UnShieldBtn.GetRootItem().SetUIActive(false);
		this.ShieldBtn.GetRootItem().SetUIActive(false);
		EUiViewName? showingView = FriendModel.Instance.ShowingView;
		if (showingView == EUiViewName.FriendView || showingView == EUiViewName.FriendSearchView)
		{
			FriendData selectedPlayerOrItemInstance = FriendModel.Instance.GetSelectedPlayerOrItemInstance(null, null);
			int? num = (selectedPlayerOrItemInstance != null) ? new int?(selectedPlayerOrItemInstance.PlayerId) : null;
			if (playerId == num.GetValueOrDefault() & num != null)
			{
				if (ChatModel.Instance.IsInMute(selectedPlayerOrItemInstance.PlayerId))
				{
					this.UnShieldBtn.GetRootItem().SetUIActive(true);
				}
				else
				{
					this.ShieldBtn.GetRootItem().SetUIActive(true);
				}
			}
		}
		this.RefreshMute();
	}

	// Token: 0x0600ADF6 RID: 44534 RVA: 0x00334678 File Offset: 0x00332878
	private void OnClickChatBtn()
	{
		FriendData selectedPlayerOrItemInstance = FriendModel.Instance.GetSelectedPlayerOrItemInstance(null, null);
		if (selectedPlayerOrItemInstance == null)
		{
			return;
		}
		UiManager.Instance.CloseView(EUiViewName.FriendProcessView, null);
		if (UiManager.Instance.IsViewShow(EUiViewName.FriendSearchView))
		{
			UiManager.Instance.CloseView(EUiViewName.FriendSearchView, null);
		}
		ChatController.Instance.OpenFriendChat(selectedPlayerOrItemInstance.PlayerId);
	}

	// Token: 0x0600ADF7 RID: 44535 RVA: 0x003346E8 File Offset: 0x003328E8
	private void CallBackUpdateFriendViewShow()
	{
		if (FriendModel.Instance.GetSelectedPlayerOrItemInstance(null, null) == null)
		{
			base.CloseMe(null);
			return;
		}
		this.UpdatePlayerDataShow();
	}

	// Token: 0x0600ADF8 RID: 44536 RVA: 0x00334721 File Offset: 0x00332921
	protected override void OnBeforeDestroy()
	{
		if (this.PersonalOptionItemLayout != null)
		{
			this.PersonalOptionItemLayout.ClearChildren();
			this.PersonalOptionItemLayout = null;
		}
	}

	// Token: 0x04006408 RID: 25608
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayoutNew<PersonalOptionItem> PersonalOptionItemLayout;

	// Token: 0x04006409 RID: 25609
	private PersonalOptionItem UnShieldBtn;

	// Token: 0x0400640A RID: 25610
	private PersonalOptionItem ShieldBtn;

	// Token: 0x0400640B RID: 25611
	private PersonalOptionItem BlockBtn;

	// Token: 0x0400640C RID: 25612
	private PersonalOptionItem DeleteFriendBtn;

	// Token: 0x0400640D RID: 25613
	private PersonalOptionItem ReportBtn;

	// Token: 0x0400640E RID: 25614
	private PersonalOptionItem LookCardBtn;

	// Token: 0x0400640F RID: 25615
	private PersonalOptionItem ChangeRemarkBtn;

	// Token: 0x04006410 RID: 25616
	private PlayerHeadItem HeadPhotoItem;

	// Token: 0x04006411 RID: 25617
	private PlayerTitleItem TitleItem;

	// Token: 0x0200738B RID: 29579
	[NullableContext(0)]
	private class EFriendProcessViewComponents
	{
		// Token: 0x040259FA RID: 154106
		public const int HeadPhotoItem = 0;

		// Token: 0x040259FB RID: 154107
		public const int HeadFrameSprite = 1;

		// Token: 0x040259FC RID: 154108
		public const int NameText = 2;

		// Token: 0x040259FD RID: 154109
		public const int BracketNameParent = 3;

		// Token: 0x040259FE RID: 154110
		public const int BracketNameText = 4;

		// Token: 0x040259FF RID: 154111
		public const int LevelNumberText = 5;

		// Token: 0x04025A00 RID: 154112
		public const int ChatBtn = 6;

		// Token: 0x04025A01 RID: 154113
		public const int LevelText = 7;

		// Token: 0x04025A02 RID: 154114
		public const int BlockShowItem = 8;

		// Token: 0x04025A03 RID: 154115
		public const int GirdLayout = 9;

		// Token: 0x04025A04 RID: 154116
		public const int Title = 10;

		// Token: 0x04025A05 RID: 154117
		public const int SignText = 11;

		// Token: 0x04025A06 RID: 154118
		public const int PlayStationItem = 12;

		// Token: 0x04025A07 RID: 154119
		public const int PlayStationText = 13;

		// Token: 0x04025A08 RID: 154120
		public const int PlayerTitleItem = 14;

		// Token: 0x04025A09 RID: 154121
		public const int PlayStationTexture = 15;

		// Token: 0x04025A0A RID: 154122
		public const int PcItem = 16;

		// Token: 0x04025A0B RID: 154123
		public const int TexCard = 17;

		// Token: 0x04025A0C RID: 154124
		public const int XboxButton = 18;

		// Token: 0x04025A0D RID: 154125
		public const int XboxText = 19;
	}
}
