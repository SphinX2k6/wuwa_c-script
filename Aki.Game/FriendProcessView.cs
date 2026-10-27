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

// Token: 0x02001C3E RID: 7230
[NullableContext(2)]
[Nullable(0)]
public class FriendProcessView : UiViewBase
{
	// Token: 0x0600D9CE RID: 55758 RVA: 0x003284C3 File Offset: 0x003266C3
	[NullableContext(1)]
	public FriendProcessView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600D9CF RID: 55759 RVA: 0x003284CC File Offset: 0x003266CC
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

	// Token: 0x0600D9D0 RID: 55760 RVA: 0x003287D4 File Offset: 0x003269D4
	private void OnClickXboxButton()
	{
		FriendData selectedPlayerOrItemInstance = FriendModel.Instance.GetSelectedPlayerOrItemInstance(null, null);
		if (selectedPlayerOrItemInstance == null)
		{
			return;
		}
		KuroSdkController.Instance.OpenProfileCard(selectedPlayerOrItemInstance.GetSdkUserId());
	}

	// Token: 0x0600D9D1 RID: 55761 RVA: 0x00328814 File Offset: 0x00326A14
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.UpdateFriendViewShow, new Action(this.CallBackUpdateFriendViewShow));
		EventSystem.Instance.Add<int>(EEventName.OnAddMutePlayer, new Action<int>(this.RefreshShieldState));
		EventSystem.Instance.Add<int>(EEventName.OnRemoveMutePlayer, new Action<int>(this.RefreshShieldState));
		EventSystem.Instance.Add(EEventName.UpdateBlackListShow, new Action(this.RefreshBlackBtn));
	}

	// Token: 0x0600D9D2 RID: 55762 RVA: 0x00328894 File Offset: 0x00326A94
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.UpdateFriendViewShow, new Action(this.CallBackUpdateFriendViewShow));
		EventSystem.Instance.Remove(EEventName.OnAddMutePlayer, new Action<int>(this.RefreshShieldState));
		EventSystem.Instance.Remove(EEventName.OnRemoveMutePlayer, new Action<int>(this.RefreshShieldState));
		EventSystem.Instance.Remove(EEventName.UpdateBlackListShow, new Action(this.RefreshBlackBtn));
	}

	// Token: 0x0600D9D3 RID: 55763 RVA: 0x00328914 File Offset: 0x00326B14
	protected override UniTask OnBeforeStartAsync()
	{
		FriendProcessView.<OnBeforeStartAsync>d__16 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FriendProcessView.<OnBeforeStartAsync>d__16>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600D9D4 RID: 55764 RVA: 0x00328958 File Offset: 0x00326B58
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

	// Token: 0x0600D9D5 RID: 55765 RVA: 0x003289D0 File Offset: 0x00326BD0
	private void RefreshPersonalOptionItemLayout()
	{
		if (this.PersonalOptionItemLayout != null)
		{
			this.PersonalOptionItemLayout.ClearChildren();
		}
		this.PersonalOptionItemLayout = new GenericLayoutNew<PersonalOptionItem>(base.GetGridLayout(9), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<PersonalOptionItem>(this.InitPersonalOptionItem), null);
		this.PersonalOptionItemLayout.RebuildLayoutByDataNew<int>(this.GetOptionDataList().ToArray(), null);
	}

	// Token: 0x0600D9D6 RID: 55766 RVA: 0x00328A30 File Offset: 0x00326C30
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

	// Token: 0x0600D9D7 RID: 55767 RVA: 0x00328AA4 File Offset: 0x00326CA4
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

	// Token: 0x0600D9D8 RID: 55768 RVA: 0x00328B3C File Offset: 0x00326D3C
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

	// Token: 0x0600D9D9 RID: 55769 RVA: 0x00328BFC File Offset: 0x00326DFC
	public void RefreshMute()
	{
		FriendData selectedPlayerOrItemInstance = FriendModel.Instance.GetSelectedPlayerOrItemInstance(null, null);
		bool uiactive = ChatModel.Instance.IsInMute(selectedPlayerOrItemInstance.PlayerId);
		base.GetItem(8).SetUIActive(uiactive);
	}

	// Token: 0x0600D9DA RID: 55770 RVA: 0x00328C44 File Offset: 0x00326E44
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

	// Token: 0x0600D9DB RID: 55771 RVA: 0x00328CF0 File Offset: 0x00326EF0
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

	// Token: 0x0600D9DC RID: 55772 RVA: 0x00328E58 File Offset: 0x00327058
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

	// Token: 0x0600D9DD RID: 55773 RVA: 0x00328F30 File Offset: 0x00327130
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

	// Token: 0x0600D9DE RID: 55774 RVA: 0x00329118 File Offset: 0x00327318
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

	// Token: 0x0600D9DF RID: 55775 RVA: 0x00329168 File Offset: 0x00327368
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

	// Token: 0x0600D9E0 RID: 55776 RVA: 0x00329278 File Offset: 0x00327478
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

	// Token: 0x0600D9E1 RID: 55777 RVA: 0x003292E8 File Offset: 0x003274E8
	private void CallBackUpdateFriendViewShow()
	{
		if (FriendModel.Instance.GetSelectedPlayerOrItemInstance(null, null) == null)
		{
			base.CloseMe(null);
			return;
		}
		this.UpdatePlayerDataShow();
	}

	// Token: 0x0600D9E2 RID: 55778 RVA: 0x00329321 File Offset: 0x00327521
	protected override void OnBeforeDestroy()
	{
		if (this.PersonalOptionItemLayout != null)
		{
			this.PersonalOptionItemLayout.ClearChildren();
			this.PersonalOptionItemLayout = null;
		}
	}

	// Token: 0x04006336 RID: 25398
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayoutNew<PersonalOptionItem> PersonalOptionItemLayout;

	// Token: 0x04006337 RID: 25399
	private PersonalOptionItem UnShieldBtn;

	// Token: 0x04006338 RID: 25400
	private PersonalOptionItem ShieldBtn;

	// Token: 0x04006339 RID: 25401
	private PersonalOptionItem BlockBtn;

	// Token: 0x0400633A RID: 25402
	private PersonalOptionItem DeleteFriendBtn;

	// Token: 0x0400633B RID: 25403
	private PersonalOptionItem ReportBtn;

	// Token: 0x0400633C RID: 25404
	private PersonalOptionItem LookCardBtn;

	// Token: 0x0400633D RID: 25405
	private PersonalOptionItem ChangeRemarkBtn;

	// Token: 0x0400633E RID: 25406
	private PlayerHeadItem HeadPhotoItem;

	// Token: 0x0400633F RID: 25407
	private PlayerTitleItem TitleItem;

	// Token: 0x02008202 RID: 33282
	[NullableContext(0)]
	private class EFriendProcessViewComponents
	{
		// Token: 0x0402A6D3 RID: 173779
		public const int HeadPhotoItem = 0;

		// Token: 0x0402A6D4 RID: 173780
		public const int HeadFrameSprite = 1;

		// Token: 0x0402A6D5 RID: 173781
		public const int NameText = 2;

		// Token: 0x0402A6D6 RID: 173782
		public const int BracketNameParent = 3;

		// Token: 0x0402A6D7 RID: 173783
		public const int BracketNameText = 4;

		// Token: 0x0402A6D8 RID: 173784
		public const int LevelNumberText = 5;

		// Token: 0x0402A6D9 RID: 173785
		public const int ChatBtn = 6;

		// Token: 0x0402A6DA RID: 173786
		public const int LevelText = 7;

		// Token: 0x0402A6DB RID: 173787
		public const int BlockShowItem = 8;

		// Token: 0x0402A6DC RID: 173788
		public const int GirdLayout = 9;

		// Token: 0x0402A6DD RID: 173789
		public const int Title = 10;

		// Token: 0x0402A6DE RID: 173790
		public const int SignText = 11;

		// Token: 0x0402A6DF RID: 173791
		public const int PlayStationItem = 12;

		// Token: 0x0402A6E0 RID: 173792
		public const int PlayStationText = 13;

		// Token: 0x0402A6E1 RID: 173793
		public const int PlayerTitleItem = 14;

		// Token: 0x0402A6E2 RID: 173794
		public const int PlayStationTexture = 15;

		// Token: 0x0402A6E3 RID: 173795
		public const int PcItem = 16;

		// Token: 0x0402A6E4 RID: 173796
		public const int TexCard = 17;

		// Token: 0x0402A6E5 RID: 173797
		public const int XboxButton = 18;

		// Token: 0x0402A6E6 RID: 173798
		public const int XboxText = 19;
	}
}
