using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001C40 RID: 7232
[NullableContext(1)]
[Nullable(0)]
public class FriendView : UiViewBase
{
	// Token: 0x0600D9FB RID: 55803 RVA: 0x00329D9B File Offset: 0x00327F9B
	public FriendView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600D9FC RID: 55804 RVA: 0x00329DB0 File Offset: 0x00327FB0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 12;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUILoopScrollViewComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(9, new Action(this.OnClickCopyUid));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(10, new Action<EToggleState>(this.OnClickSwitchToggle));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600D9FD RID: 55805 RVA: 0x00329FCC File Offset: 0x003281CC
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.UpdateFriendViewShow, new Action(this.CallBackUpdateFriendViewShow));
		EventSystem.Instance.Add(EEventName.FriendApplicationListUpdate, new Action(this.CallBackFriendApplyListUpdate));
		EventSystem.Instance.Add<int>(EEventName.OnAddMutePlayer, new Action<int>(this.RefreshItemMuteState));
		EventSystem.Instance.Add<int>(EEventName.OnRemoveMutePlayer, new Action<int>(this.RefreshItemMuteState));
		EventSystem.Instance.Add(EEventName.UpdateRecentlyTeamDataEvent, new Action(this.RefreshRecentlyTeamView));
	}

	// Token: 0x0600D9FE RID: 55806 RVA: 0x0032A068 File Offset: 0x00328268
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.UpdateFriendViewShow, new Action(this.CallBackUpdateFriendViewShow));
		EventSystem.Instance.Remove(EEventName.FriendApplicationListUpdate, new Action(this.CallBackFriendApplyListUpdate));
		EventSystem.Instance.Remove(EEventName.OnAddMutePlayer, new Action<int>(this.RefreshItemMuteState));
		EventSystem.Instance.Remove(EEventName.OnRemoveMutePlayer, new Action<int>(this.RefreshItemMuteState));
		EventSystem.Instance.Remove(EEventName.UpdateRecentlyTeamDataEvent, new Action(this.RefreshRecentlyTeamView));
	}

	// Token: 0x0600D9FF RID: 55807 RVA: 0x0032A104 File Offset: 0x00328304
	protected override UniTask OnBeforeStartAsync()
	{
		FriendView.<OnBeforeStartAsync>d__16 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FriendView.<OnBeforeStartAsync>d__16>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600DA00 RID: 55808 RVA: 0x0032A147 File Offset: 0x00328347
	protected override void OnBeforeShow()
	{
		this.RefreshShow();
	}

	// Token: 0x0600DA01 RID: 55809 RVA: 0x0032A150 File Offset: 0x00328350
	protected override void OnBeforeDestroy()
	{
		if (this.TabComponent != null)
		{
			this.TabComponent.Destroy(null);
			this.TabComponent = null;
		}
		this.FilterConfigList.Clear();
		if (this.FriendScrollListLayout != null)
		{
			this.FriendScrollListLayout = null;
		}
		FriendModel.Instance.Clear();
		EventSystem.Instance.Emit(EEventName.RefreshFriendApplicationRedDot);
		FriendModel.Instance.ClearTestFriendData();
	}

	// Token: 0x0600DA02 RID: 55810 RVA: 0x0032A1B7 File Offset: 0x003283B7
	private FriendItem CreateFriendItem()
	{
		return new FriendItem(this.ViewInfo.Name, null);
	}

	// Token: 0x0600DA03 RID: 55811 RVA: 0x0032A1CC File Offset: 0x003283CC
	private UniTask InitFilter()
	{
		FriendView.<InitFilter>d__20 <InitFilter>d__;
		<InitFilter>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitFilter>d__.<>4__this = this;
		<InitFilter>d__.<>1__state = -1;
		<InitFilter>d__.<>t__builder.Start<FriendView.<InitFilter>d__20>(ref <InitFilter>d__);
		return <InitFilter>d__.<>t__builder.Task;
	}

	// Token: 0x0600DA04 RID: 55812 RVA: 0x0032A20F File Offset: 0x0032840F
	protected void CloseClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600DA05 RID: 55813 RVA: 0x0032A218 File Offset: 0x00328418
	private CommonTabItem ProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
	{
		return new CommonTabItem();
	}

	// Token: 0x0600DA06 RID: 55814 RVA: 0x0032A220 File Offset: 0x00328420
	private void ToggleCallBack(int index)
	{
		FriendFilter friendFilter = this.FilterConfigList[index];
		FriendModel.Instance.FilterState = new EFriendFilter?((EFriendFilter)friendFilter.Id);
		this.RefreshShow();
	}

	// Token: 0x0600DA07 RID: 55815 RVA: 0x0032A258 File Offset: 0x00328458
	private CommonTabData GetCommonData(int index)
	{
		FriendFilter friendFilter = this.FilterConfigList[index];
		string textId = null;
		if (friendFilter.Id == 1)
		{
			textId = TextConfig.Instance.GetTextContentIdById("FriendFriend");
		}
		else if (friendFilter.Id == 2)
		{
			textId = TextConfig.Instance.GetTextContentIdById("FriendApplicationList");
		}
		else if (friendFilter.Id == 3)
		{
			textId = TextConfig.Instance.GetTextContentIdById("FriendRecentMultiplayerGame");
		}
		return new CommonTabData(friendFilter.IconPath, new CommonTabTitleData(textId, Array.Empty<object>()), null);
	}

	// Token: 0x0600DA08 RID: 55816 RVA: 0x0032A2E0 File Offset: 0x003284E0
	private void RefreshShow()
	{
		FriendModel instance = FriendModel.Instance;
		this.ShowCurrentStateNecessaryItem();
		EFriendFilter? filterState = instance.FilterState;
		if (filterState != null)
		{
			switch (filterState.GetValueOrDefault())
			{
			case EFriendFilter.FriendList:
				this.PlayerSortedIdList = FriendController.Instance.CreateFriendItemSt(instance.GetFriendSortedListIds(), EFriendItemOperation.Default);
				this.RefreshScroller(this.PlayerSortedIdList);
				this.ConfirmButtonItem.SetEnableClick(true);
				this.CancelButtonItem.SetEnableClick(true);
				this.ShowFriendsCount();
				break;
			case EFriendFilter.FriendRequest:
				this.PlayerSortedIdList = FriendController.Instance.CreateFriendItemSt(instance.GetFriendApplyListIds(), EFriendItemOperation.Default);
				this.FriendApplicationItemList = this.PlayerSortedIdList;
				this.RefreshScroller(this.PlayerSortedIdList);
				this.ConfirmButtonItem.SetEnableClick(this.PlayerSortedIdList.Count > 0);
				this.CancelButtonItem.SetEnableClick(this.PlayerSortedIdList.Count > 0);
				FriendModel.Instance.MarkDirtyNewApplications();
				this.ShowFriendsCount();
				break;
			case EFriendFilter.RecentMultiple:
			{
				UUIItem friendScrollView = this.FriendScrollView;
				if (friendScrollView != null)
				{
					friendScrollView.SetUIActive(false);
				}
				FriendController.Instance.RequestFriendRecentlyTeam();
				break;
			}
			}
		}
		LguiUtil.Instance.SetLocalText(base.GetText(8), "FriendMyUid", new <>z__ReadOnlySingleElementList<object>(PlayerInfoModel.Instance.GetId().ToString()));
		EventSystem.Instance.Emit(EEventName.RefreshFriendApplicationRedDot);
	}

	// Token: 0x0600DA09 RID: 55817 RVA: 0x0032A448 File Offset: 0x00328648
	private void RefreshBtnShowState()
	{
		bool active = false;
		EFriendFilter? filterState = FriendModel.Instance.FilterState;
		if (filterState != null)
		{
			EFriendFilter valueOrDefault = filterState.GetValueOrDefault();
			if (valueOrDefault != EFriendFilter.FriendList)
			{
				if (valueOrDefault == EFriendFilter.FriendRequest)
				{
					active = true;
					this.ConfirmButtonItem.SetLocalText("FriendAllAccept", Array.Empty<object>());
					this.ConfirmButtonItem.SetFunction(new Action<int>(this.OnClickAllAcceptBtn));
					this.CancelButtonItem.SetLocalText("FriendAllIgnore", Array.Empty<object>());
					this.CancelButtonItem.SetFunction(new Action<int>(this.OnClickAllIgnoreBtn));
				}
			}
			else
			{
				active = true;
				this.ConfirmButtonItem.SetLocalText("FriendAddFriend", Array.Empty<object>());
				this.ConfirmButtonItem.SetFunction(new Action<int>(this.OnClickAddFriendBtn));
				this.CancelButtonItem.SetLocalText("FriendBlackList", Array.Empty<object>());
				this.CancelButtonItem.SetFunction(new Action<int>(this.OnClickBlackListBtn));
			}
		}
		this.ConfirmButtonItem.SetActive(active);
		this.CancelButtonItem.SetActive(active);
	}

	// Token: 0x0600DA0A RID: 55818 RVA: 0x0032A554 File Offset: 0x00328754
	private void ShowCurrentStateNecessaryItem()
	{
		EFriendFilter? filterState = FriendModel.Instance.FilterState;
		string textTableId = "FriendNotAvailableFriend";
		if (filterState != null)
		{
			switch (filterState.GetValueOrDefault())
			{
			case EFriendFilter.FriendRequest:
				textTableId = "FriendNotAvailableFriendApplication";
				break;
			case EFriendFilter.RecentMultiple:
				textTableId = "FriendNotAvailableRecentTeammate";
				break;
			}
		}
		LguiUtil.Instance.SetLocalText(base.GetText(5), textTableId, Array.Empty<object>());
		this.RefreshBtnShowState();
	}

	// Token: 0x0600DA0B RID: 55819 RVA: 0x0032A5C4 File Offset: 0x003287C4
	private void ShowFriendsCount()
	{
		int friendLimitByViewType = FriendConfig.Instance.GetFriendLimitByViewType(FriendModel.Instance.FilterState.Value);
		UUIText text = base.GetText(1);
		int count = this.PlayerSortedIdList.Count;
		EFriendFilter? filterState = FriendModel.Instance.FilterState;
		string textTableId = "FriendCount";
		if (filterState != null)
		{
			switch (filterState.GetValueOrDefault())
			{
			case EFriendFilter.FriendRequest:
				textTableId = "FriendApplicationCount";
				break;
			case EFriendFilter.RecentMultiple:
				textTableId = "FriendMultiplayerCount";
				break;
			}
		}
		LguiUtil.Instance.SetLocalText(text, textTableId, new <>z__ReadOnlyArray<object>(new object[]
		{
			count,
			friendLimitByViewType
		}));
		base.GetItem(4).SetUIActive(count <= 0);
	}

	// Token: 0x0600DA0C RID: 55820 RVA: 0x0032A68C File Offset: 0x0032888C
	private void OnClickAddFriendBtn(int num)
	{
		EFriendFilter? filterState = FriendModel.Instance.FilterState;
		UiPopViewData param = new UiPopViewData();
		if (filterState != null)
		{
			EFriendFilter valueOrDefault = filterState.GetValueOrDefault();
			if (valueOrDefault != EFriendFilter.FriendList)
			{
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.FriendSearchView, param, null);
		}
	}

	// Token: 0x0600DA0D RID: 55821 RVA: 0x0032A6D8 File Offset: 0x003288D8
	private void OnClickAllAcceptBtn(int num)
	{
		this.ConfirmButtonItem.GetRootItem().SetRaycastTarget(false);
		if (this.AllAgreeButtonMaskTimerId != null && TimerSystem.GameplayTimeInstance.Has(this.AllAgreeButtonMaskTimerId))
		{
			TimerSystem.GameplayTimeInstance.Remove(this.AllAgreeButtonMaskTimerId);
		}
		this.AllAgreeButtonMaskTimerId = TimerSystem.GameplayTimeInstance.Delay(delegate(float deltaTime)
		{
			this.ConfirmButtonItem.GetRootItem().SetRaycastTarget(true);
		}, 20f, null, null, true, 1f);
		this.RequestSendIdList = new List<int>();
		foreach (FriendItemSt friendItemSt in this.FriendApplicationItemList)
		{
			FriendData friendDataInApplicationById = FriendModel.Instance.GetFriendDataInApplicationById(friendItemSt.Id);
			if (friendDataInApplicationById != null && (friendDataInApplicationById == null || !friendDataInApplicationById.Debug))
			{
				this.RequestSendIdList.Add(friendItemSt.Id);
			}
		}
		FriendController.Instance.RequestFriendApplyHandle(this.RequestSendIdList, FriendApplyOperator.Approve);
	}

	// Token: 0x0600DA0E RID: 55822 RVA: 0x0032A7D8 File Offset: 0x003289D8
	private void OnClickAllIgnoreBtn(int num)
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.IgnoreAllFriendApplication);
		this.CancelButtonItem.GetRootItem().SetRaycastTarget(false);
		if (this.AllIgnoreButtonMaskTimerId != null && TimerSystem.GameplayTimeInstance.Has(this.AllIgnoreButtonMaskTimerId))
		{
			TimerSystem.GameplayTimeInstance.Remove(this.AllIgnoreButtonMaskTimerId);
		}
		this.AllIgnoreButtonMaskTimerId = TimerSystem.GameplayTimeInstance.Delay(delegate(float deltaTime)
		{
			this.CancelButtonItem.GetRootItem().SetRaycastTarget(true);
		}, 20f, null, null, true, 1f);
		this.RequestSendIdList = new List<int>();
		confirmBoxDataNew.FunctionMap.Add(2, delegate
		{
			foreach (FriendItemSt friendItemSt in this.FriendApplicationItemList)
			{
				FriendData friendDataInApplicationById = FriendModel.Instance.GetFriendDataInApplicationById(friendItemSt.Id);
				if (friendDataInApplicationById == null || !friendDataInApplicationById.Debug)
				{
					this.RequestSendIdList.Add(friendItemSt.Id);
				}
			}
			FriendController.Instance.RequestFriendApplyHandle(this.RequestSendIdList, FriendApplyOperator.Reject);
		});
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x0600DA0F RID: 55823 RVA: 0x0032A884 File Offset: 0x00328A84
	private void OnClickBlackListBtn(int num)
	{
		EFriendFilter? filterState = FriendModel.Instance.FilterState;
		UiPopViewData param = new UiPopViewData();
		if (filterState != null)
		{
			EFriendFilter valueOrDefault = filterState.GetValueOrDefault();
			if (valueOrDefault != EFriendFilter.FriendList)
			{
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.FriendBlackListView, param, null);
		}
	}

	// Token: 0x0600DA10 RID: 55824 RVA: 0x0032A8D0 File Offset: 0x00328AD0
	private void OnClickCopyUid()
	{
		GenericPromptController.Instance.ShowPromptByCode("CopiedMyUid", Array.Empty<object>());
		ULGUIBPLibrary.ClipBoardCopy(PlayerInfoModel.Instance.GetId().ToString());
	}

	// Token: 0x0600DA11 RID: 55825 RVA: 0x0032A90E File Offset: 0x00328B0E
	private void CallBackUpdateFriendViewShow()
	{
		this.RefreshShow();
	}

	// Token: 0x0600DA12 RID: 55826 RVA: 0x0032A918 File Offset: 0x00328B18
	private void CallBackFriendApplyListUpdate()
	{
		if (FriendModel.Instance.FilterState.GetValueOrDefault() == EFriendFilter.FriendRequest)
		{
			this.RefreshShow();
		}
	}

	// Token: 0x0600DA13 RID: 55827 RVA: 0x0032A940 File Offset: 0x00328B40
	private void RefreshItemMuteState(int playerId)
	{
		int i = 0;
		while (i < this.PlayerSortedIdList.Count)
		{
			if (this.PlayerSortedIdList[i].Id == playerId)
			{
				FriendItem friendItem = this.FriendScrollListLayout.UnsafeGetGridProxy(i, false);
				if (friendItem == null)
				{
					return;
				}
				friendItem.RefreshMute();
				return;
			}
			else
			{
				i++;
			}
		}
	}

	// Token: 0x0600DA14 RID: 55828 RVA: 0x0032A990 File Offset: 0x00328B90
	private void RefreshScroller(List<FriendItemSt> friendData)
	{
		if (this.FriendScrollListLayout != null && friendData.Count > 0)
		{
			UUIItem friendScrollView = this.FriendScrollView;
			if (friendScrollView != null)
			{
				friendScrollView.SetUIActive(true);
			}
			this.FriendScrollListLayout.RefreshByData(friendData, false, null, false);
			return;
		}
		UUIItem friendScrollView2 = this.FriendScrollView;
		if (friendScrollView2 == null)
		{
			return;
		}
		friendScrollView2.SetUIActive(false);
	}

	// Token: 0x0600DA15 RID: 55829 RVA: 0x0032A9E1 File Offset: 0x00328BE1
	private void RefreshRecentlyTeamView()
	{
		this.PlayerSortedIdList = FriendController.Instance.CreateFriendItemSt(FriendModel.Instance.GetRecentlyTeamIds(), EFriendItemOperation.Default);
		this.RefreshScroller(this.PlayerSortedIdList);
		this.ShowFriendsCount();
	}

	// Token: 0x0600DA16 RID: 55830 RVA: 0x0032AA10 File Offset: 0x00328C10
	private void OnClickSwitchToggle(EToggleState toggleState)
	{
		bool state = !KuroSdkController.Instance.GetSdkFriendOnlyState();
		KuroSdkController.Instance.SaveSdkFriendOnlyState(state);
		this.RefreshShow();
	}

	// Token: 0x0600DA17 RID: 55831 RVA: 0x0032AA3C File Offset: 0x00328C3C
	private void RefreshPlayStationShowToggle()
	{
		if (KuroSdkController.Instance.SupportSwitchFriendShowType())
		{
			base.GetExtendToggle(10).RootUIComp.Get().SetUIActive(true);
			base.GetText(11).SetUIActive(true);
			if (Info.Instance.IsPs5Platform())
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(11), "PlatformFriendOnly_PlayStation", Array.Empty<object>());
			}
			else if (Info.Instance.IsXboxPlatform())
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(11), "PlatformFriendOnly_Xbox", Array.Empty<object>());
			}
			this.RefreshToggleBySelectState();
			return;
		}
		base.GetExtendToggle(10).RootUIComp.Get().SetUIActive(false);
		base.GetText(11).SetUIActive(false);
	}

	// Token: 0x0600DA18 RID: 55832 RVA: 0x0032AB04 File Offset: 0x00328D04
	private void RefreshToggleBySelectState()
	{
		EToggleState state = KuroSdkController.Instance.GetSdkFriendOnlyState() ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(10).SetToggleState(state, false, false, false);
	}

	// Token: 0x04006344 RID: 25412
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<FriendItemSt> PlayerSortedIdList;

	// Token: 0x04006345 RID: 25413
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<FriendItem, FriendItemSt> FriendScrollListLayout;

	// Token: 0x04006346 RID: 25414
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<FriendItemSt> FriendApplicationItemList;

	// Token: 0x04006347 RID: 25415
	[Nullable(2)]
	private ButtonItem ConfirmButtonItem;

	// Token: 0x04006348 RID: 25416
	[Nullable(2)]
	private ButtonItem CancelButtonItem;

	// Token: 0x04006349 RID: 25417
	[Nullable(2)]
	private TimerHandle AllAgreeButtonMaskTimerId;

	// Token: 0x0400634A RID: 25418
	[Nullable(2)]
	private TimerHandle AllIgnoreButtonMaskTimerId;

	// Token: 0x0400634B RID: 25419
	[Nullable(2)]
	private List<int> RequestSendIdList;

	// Token: 0x0400634C RID: 25420
	private List<FriendFilter> FilterConfigList = new List<FriendFilter>();

	// Token: 0x0400634D RID: 25421
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TabComponentWithCaptionItem<CommonTabItem> TabComponent;

	// Token: 0x0400634E RID: 25422
	[Nullable(2)]
	private UUIItem FriendScrollView;

	// Token: 0x02008208 RID: 33288
	[NullableContext(0)]
	private class EFriendViewComponents
	{
		// Token: 0x0402A6FF RID: 173823
		public const int TabComponent = 0;

		// Token: 0x0402A700 RID: 173824
		public const int FriendCountText = 1;

		// Token: 0x0402A701 RID: 173825
		public const int FriendScrollView = 2;

		// Token: 0x0402A702 RID: 173826
		public const int FriendItemModel = 3;

		// Token: 0x0402A703 RID: 173827
		public const int FriendListEmptyBox = 4;

		// Token: 0x0402A704 RID: 173828
		public const int EmptyText = 5;

		// Token: 0x0402A705 RID: 173829
		public const int ConfirmBtnItem = 6;

		// Token: 0x0402A706 RID: 173830
		public const int CancelBtnItem = 7;

		// Token: 0x0402A707 RID: 173831
		public const int MyUIDText = 8;

		// Token: 0x0402A708 RID: 173832
		public const int CopyUIDBtn = 9;

		// Token: 0x0402A709 RID: 173833
		public const int SwitchPlayStationShowToggle = 10;

		// Token: 0x0402A70A RID: 173834
		public const int SwitchPlayStationShowToggleText = 11;
	}
}
