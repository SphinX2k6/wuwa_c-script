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

// Token: 0x020010FF RID: 4351
[NullableContext(1)]
[Nullable(0)]
public class FriendView : UiViewBase
{
	// Token: 0x0600AE11 RID: 44561 RVA: 0x0033519B File Offset: 0x0033339B
	public FriendView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600AE12 RID: 44562 RVA: 0x003351B0 File Offset: 0x003333B0
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

	// Token: 0x0600AE13 RID: 44563 RVA: 0x003353CC File Offset: 0x003335CC
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.UpdateFriendViewShow, new Action(this.CallBackUpdateFriendViewShow));
		EventSystem.Instance.Add(EEventName.FriendApplicationListUpdate, new Action(this.CallBackFriendApplyListUpdate));
		EventSystem.Instance.Add<int>(EEventName.OnAddMutePlayer, new Action<int>(this.RefreshItemMuteState));
		EventSystem.Instance.Add<int>(EEventName.OnRemoveMutePlayer, new Action<int>(this.RefreshItemMuteState));
		EventSystem.Instance.Add(EEventName.UpdateRecentlyTeamDataEvent, new Action(this.RefreshRecentlyTeamView));
	}

	// Token: 0x0600AE14 RID: 44564 RVA: 0x00335468 File Offset: 0x00333668
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.UpdateFriendViewShow, new Action(this.CallBackUpdateFriendViewShow));
		EventSystem.Instance.Remove(EEventName.FriendApplicationListUpdate, new Action(this.CallBackFriendApplyListUpdate));
		EventSystem.Instance.Remove(EEventName.OnAddMutePlayer, new Action<int>(this.RefreshItemMuteState));
		EventSystem.Instance.Remove(EEventName.OnRemoveMutePlayer, new Action<int>(this.RefreshItemMuteState));
		EventSystem.Instance.Remove(EEventName.UpdateRecentlyTeamDataEvent, new Action(this.RefreshRecentlyTeamView));
	}

	// Token: 0x0600AE15 RID: 44565 RVA: 0x00335504 File Offset: 0x00333704
	protected override UniTask OnBeforeStartAsync()
	{
		FriendView.<OnBeforeStartAsync>d__16 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FriendView.<OnBeforeStartAsync>d__16>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600AE16 RID: 44566 RVA: 0x00335547 File Offset: 0x00333747
	protected override void OnBeforeShow()
	{
		this.RefreshShow();
	}

	// Token: 0x0600AE17 RID: 44567 RVA: 0x00335550 File Offset: 0x00333750
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

	// Token: 0x0600AE18 RID: 44568 RVA: 0x003355B7 File Offset: 0x003337B7
	private FriendItem CreateFriendItem()
	{
		return new FriendItem(this.ViewInfo.Name, null);
	}

	// Token: 0x0600AE19 RID: 44569 RVA: 0x003355CC File Offset: 0x003337CC
	private UniTask InitFilter()
	{
		FriendView.<InitFilter>d__20 <InitFilter>d__;
		<InitFilter>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitFilter>d__.<>4__this = this;
		<InitFilter>d__.<>1__state = -1;
		<InitFilter>d__.<>t__builder.Start<FriendView.<InitFilter>d__20>(ref <InitFilter>d__);
		return <InitFilter>d__.<>t__builder.Task;
	}

	// Token: 0x0600AE1A RID: 44570 RVA: 0x0033560F File Offset: 0x0033380F
	protected void CloseClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600AE1B RID: 44571 RVA: 0x00335618 File Offset: 0x00333818
	private CommonTabItem ProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
	{
		return new CommonTabItem();
	}

	// Token: 0x0600AE1C RID: 44572 RVA: 0x00335620 File Offset: 0x00333820
	private void ToggleCallBack(int index)
	{
		FriendFilter friendFilter = this.FilterConfigList[index];
		FriendModel.Instance.FilterState = new EFriendFilter?((EFriendFilter)friendFilter.Id);
		this.RefreshShow();
	}

	// Token: 0x0600AE1D RID: 44573 RVA: 0x00335658 File Offset: 0x00333858
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

	// Token: 0x0600AE1E RID: 44574 RVA: 0x003356E0 File Offset: 0x003338E0
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

	// Token: 0x0600AE1F RID: 44575 RVA: 0x00335848 File Offset: 0x00333A48
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

	// Token: 0x0600AE20 RID: 44576 RVA: 0x00335954 File Offset: 0x00333B54
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

	// Token: 0x0600AE21 RID: 44577 RVA: 0x003359C4 File Offset: 0x00333BC4
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

	// Token: 0x0600AE22 RID: 44578 RVA: 0x00335A8C File Offset: 0x00333C8C
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

	// Token: 0x0600AE23 RID: 44579 RVA: 0x00335AD8 File Offset: 0x00333CD8
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

	// Token: 0x0600AE24 RID: 44580 RVA: 0x00335BD8 File Offset: 0x00333DD8
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

	// Token: 0x0600AE25 RID: 44581 RVA: 0x00335C84 File Offset: 0x00333E84
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

	// Token: 0x0600AE26 RID: 44582 RVA: 0x00335CD0 File Offset: 0x00333ED0
	private void OnClickCopyUid()
	{
		GenericPromptController.Instance.ShowPromptByCode("CopiedMyUid", Array.Empty<object>());
		ULGUIBPLibrary.ClipBoardCopy(PlayerInfoModel.Instance.GetId().ToString());
	}

	// Token: 0x0600AE27 RID: 44583 RVA: 0x00335D0E File Offset: 0x00333F0E
	private void CallBackUpdateFriendViewShow()
	{
		this.RefreshShow();
	}

	// Token: 0x0600AE28 RID: 44584 RVA: 0x00335D18 File Offset: 0x00333F18
	private void CallBackFriendApplyListUpdate()
	{
		if (FriendModel.Instance.FilterState.GetValueOrDefault() == EFriendFilter.FriendRequest)
		{
			this.RefreshShow();
		}
	}

	// Token: 0x0600AE29 RID: 44585 RVA: 0x00335D40 File Offset: 0x00333F40
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

	// Token: 0x0600AE2A RID: 44586 RVA: 0x00335D90 File Offset: 0x00333F90
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

	// Token: 0x0600AE2B RID: 44587 RVA: 0x00335DE1 File Offset: 0x00333FE1
	private void RefreshRecentlyTeamView()
	{
		this.PlayerSortedIdList = FriendController.Instance.CreateFriendItemSt(FriendModel.Instance.GetRecentlyTeamIds(), EFriendItemOperation.Default);
		this.RefreshScroller(this.PlayerSortedIdList);
		this.ShowFriendsCount();
	}

	// Token: 0x0600AE2C RID: 44588 RVA: 0x00335E10 File Offset: 0x00334010
	private void OnClickSwitchToggle(EToggleState toggleState)
	{
		bool state = !KuroSdkController.Instance.GetSdkFriendOnlyState();
		KuroSdkController.Instance.SaveSdkFriendOnlyState(state);
		this.RefreshShow();
	}

	// Token: 0x0600AE2D RID: 44589 RVA: 0x00335E3C File Offset: 0x0033403C
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

	// Token: 0x0600AE2E RID: 44590 RVA: 0x00335F04 File Offset: 0x00334104
	private void RefreshToggleBySelectState()
	{
		EToggleState state = KuroSdkController.Instance.GetSdkFriendOnlyState() ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(10).SetToggleState(state, false, false, false);
	}

	// Token: 0x04006416 RID: 25622
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<FriendItemSt> PlayerSortedIdList;

	// Token: 0x04006417 RID: 25623
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<FriendItem, FriendItemSt> FriendScrollListLayout;

	// Token: 0x04006418 RID: 25624
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<FriendItemSt> FriendApplicationItemList;

	// Token: 0x04006419 RID: 25625
	[Nullable(2)]
	private ButtonItem ConfirmButtonItem;

	// Token: 0x0400641A RID: 25626
	[Nullable(2)]
	private ButtonItem CancelButtonItem;

	// Token: 0x0400641B RID: 25627
	[Nullable(2)]
	private TimerHandle AllAgreeButtonMaskTimerId;

	// Token: 0x0400641C RID: 25628
	[Nullable(2)]
	private TimerHandle AllIgnoreButtonMaskTimerId;

	// Token: 0x0400641D RID: 25629
	[Nullable(2)]
	private List<int> RequestSendIdList;

	// Token: 0x0400641E RID: 25630
	private List<FriendFilter> FilterConfigList = new List<FriendFilter>();

	// Token: 0x0400641F RID: 25631
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TabComponentWithCaptionItem<CommonTabItem> TabComponent;

	// Token: 0x04006420 RID: 25632
	[Nullable(2)]
	private UUIItem FriendScrollView;

	// Token: 0x02007391 RID: 29585
	[NullableContext(0)]
	private class EFriendViewComponents
	{
		// Token: 0x04025A26 RID: 154150
		public const int TabComponent = 0;

		// Token: 0x04025A27 RID: 154151
		public const int FriendCountText = 1;

		// Token: 0x04025A28 RID: 154152
		public const int FriendScrollView = 2;

		// Token: 0x04025A29 RID: 154153
		public const int FriendItemModel = 3;

		// Token: 0x04025A2A RID: 154154
		public const int FriendListEmptyBox = 4;

		// Token: 0x04025A2B RID: 154155
		public const int EmptyText = 5;

		// Token: 0x04025A2C RID: 154156
		public const int ConfirmBtnItem = 6;

		// Token: 0x04025A2D RID: 154157
		public const int CancelBtnItem = 7;

		// Token: 0x04025A2E RID: 154158
		public const int MyUIDText = 8;

		// Token: 0x04025A2F RID: 154159
		public const int CopyUIDBtn = 9;

		// Token: 0x04025A30 RID: 154160
		public const int SwitchPlayStationShowToggle = 10;

		// Token: 0x04025A31 RID: 154161
		public const int SwitchPlayStationShowToggleText = 11;
	}
}
