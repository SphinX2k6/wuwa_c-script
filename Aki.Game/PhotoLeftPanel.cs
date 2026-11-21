using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Data.Camera.PhotoCamera;
using CSharpScript.Core.Common;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001A64 RID: 6756
[NullableContext(1)]
[Nullable(0)]
public class PhotoLeftPanel : UiPanelBase
{
	// Token: 0x06010AE2 RID: 68322 RVA: 0x004E107C File Offset: 0x004DF27C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(1, new Action(this.OnBackClick))
		};
	}

	// Token: 0x06010AE3 RID: 68323 RVA: 0x004E113C File Offset: 0x004DF33C
	protected override UniTask OnBeforeStartAsync()
	{
		PhotoLeftPanel.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PhotoLeftPanel.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010AE4 RID: 68324 RVA: 0x004E1180 File Offset: 0x004DF380
	protected override void OnStart()
	{
		PhotoMainViewModel viewModel = this.ViewModel;
		viewModel.OnModeChanged = (Action<PhotoCameraType>)Delegate.Combine(viewModel.OnModeChanged, new Action<PhotoCameraType>(this.OnModeChanged));
		PhotoMainViewModel viewModel2 = this.ViewModel;
		viewModel2.OnFilterDetailModeChanged = (Action<bool>)Delegate.Combine(viewModel2.OnFilterDetailModeChanged, new Action<bool>(this.OnFilterDetailModeChanged));
		PhotoMoveCtrlPanel moveCtrlPanel = this.MoveCtrlPanel;
		if (moveCtrlPanel != null)
		{
			moveCtrlPanel.RefreshByMode(this.ViewModel.CurrentMode);
		}
		this.SetMoveCtrlActive(true);
	}

	// Token: 0x06010AE5 RID: 68325 RVA: 0x004E11FE File Offset: 0x004DF3FE
	public void TickCurrentDetail(float delta)
	{
		PhotoDetailPanelBase currentDetailPanel = this.CurrentDetailPanel;
		if (currentDetailPanel != null)
		{
			currentDetailPanel.OnTick(delta);
		}
		this.TickPendingJump();
	}

	// Token: 0x06010AE6 RID: 68326 RVA: 0x004E1218 File Offset: 0x004DF418
	private void TickPendingJump()
	{
		if (this.PendingJumpRetryFrame <= 0)
		{
			return;
		}
		this.PendingJumpRetryFrame--;
		if (UiNavigationNewController.Instance.JumpNavigationGroupByTag(string.Empty))
		{
			this.PendingJumpRetryFrame = 0;
		}
	}

	// Token: 0x06010AE7 RID: 68327 RVA: 0x004E124A File Offset: 0x004DF44A
	public void TickMoveCtrl(float delta)
	{
		PhotoMoveCtrlPanel moveCtrlPanel = this.MoveCtrlPanel;
		if (moveCtrlPanel == null)
		{
			return;
		}
		moveCtrlPanel.TickJoystick(delta);
	}

	// Token: 0x06010AE8 RID: 68328 RVA: 0x004E125D File Offset: 0x004DF45D
	public void SetStickerEditing(bool editing)
	{
		this.SetMoveCtrlActive(!editing);
		if (editing)
		{
			this.IsStickerEditing = true;
			return;
		}
		TimerSystem.GameplayTimeInstance.Next(delegate(float _)
		{
			this.IsStickerEditing = false;
		}, null, null);
	}

	// Token: 0x06010AE9 RID: 68329 RVA: 0x004E128D File Offset: 0x004DF48D
	private void SetMoveCtrlActive(bool active)
	{
		UUIItem item = base.GetItem(5);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(active && Info.Instance.IsInTouch());
	}

	// Token: 0x06010AEA RID: 68330 RVA: 0x004E12B0 File Offset: 0x004DF4B0
	private UniTask RefreshTabScroll()
	{
		PhotoLeftPanel.<RefreshTabScroll>d__18 <RefreshTabScroll>d__;
		<RefreshTabScroll>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshTabScroll>d__.<>4__this = this;
		<RefreshTabScroll>d__.<>1__state = -1;
		<RefreshTabScroll>d__.<>t__builder.Start<PhotoLeftPanel.<RefreshTabScroll>d__18>(ref <RefreshTabScroll>d__);
		return <RefreshTabScroll>d__.<>t__builder.Task;
	}

	// Token: 0x06010AEB RID: 68331 RVA: 0x004E12F4 File Offset: 0x004DF4F4
	private UniTask LoadTabContentAsync(PhotoTab tabConfig)
	{
		PhotoLeftPanel.<LoadTabContentAsync>d__19 <LoadTabContentAsync>d__;
		<LoadTabContentAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<LoadTabContentAsync>d__.<>4__this = this;
		<LoadTabContentAsync>d__.tabConfig = tabConfig;
		<LoadTabContentAsync>d__.<>1__state = -1;
		<LoadTabContentAsync>d__.<>t__builder.Start<PhotoLeftPanel.<LoadTabContentAsync>d__19>(ref <LoadTabContentAsync>d__);
		return <LoadTabContentAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010AEC RID: 68332 RVA: 0x004E133F File Offset: 0x004DF53F
	private void ShowDetailPanel(PhotoDetailPanelBase panel)
	{
		if (this.CurrentDetailPanel != null && this.CurrentDetailPanel != panel)
		{
			this.CurrentDetailPanel.HideDetail();
		}
		this.CurrentDetailPanel = panel;
		panel.ShowDetail();
		this.JumpNavigationOnDetailPanelShown();
	}

	// Token: 0x06010AED RID: 68333 RVA: 0x004E1370 File Offset: 0x004DF570
	private void JumpNavigationOnDetailPanelShown()
	{
		if (!this.HasPendingJump)
		{
			return;
		}
		this.HasPendingJump = false;
		if (UiNavigationNewController.Instance.JumpNavigationGroupByTag(string.Empty))
		{
			return;
		}
		this.PendingJumpRetryFrame = 30;
	}

	// Token: 0x06010AEE RID: 68334 RVA: 0x004E139C File Offset: 0x004DF59C
	protected override void OnBeforeDestroy()
	{
		PhotoMainViewModel viewModel = this.ViewModel;
		viewModel.OnModeChanged = (Action<PhotoCameraType>)Delegate.Remove(viewModel.OnModeChanged, new Action<PhotoCameraType>(this.OnModeChanged));
		PhotoMainViewModel viewModel2 = this.ViewModel;
		viewModel2.OnFilterDetailModeChanged = (Action<bool>)Delegate.Remove(viewModel2.OnFilterDetailModeChanged, new Action<bool>(this.OnFilterDetailModeChanged));
	}

	// Token: 0x06010AEF RID: 68335 RVA: 0x004E13F7 File Offset: 0x004DF5F7
	private void ClearTabContent()
	{
		this.HasPendingJump = false;
		this.PendingJumpRetryFrame = 0;
		PhotoDetailPanelBase currentDetailPanel = this.CurrentDetailPanel;
		if (currentDetailPanel != null)
		{
			currentDetailPanel.HideDetail();
		}
		this.CurrentDetailPanel = null;
	}

	// Token: 0x06010AF0 RID: 68336 RVA: 0x004E1420 File Offset: 0x004DF620
	private void OnTabClick(PhotoTab data)
	{
		if (this.CurrentDetailPanel == null)
		{
			Action onDetailPanelOpened = this.ViewModel.OnDetailPanelOpened;
			if (onDetailPanelOpened != null)
			{
				onDetailPanelOpened();
			}
		}
		GenericScrollViewNew<PhotoTabItem, PhotoTab> tabScroll = this.TabScroll;
		if (tabScroll != null)
		{
			GenericLayout<PhotoTabItem, PhotoTab> genericLayout = tabScroll.GetGenericLayout();
			if (genericLayout != null)
			{
				genericLayout.SelectGridProxyByKey(data.Id, false);
			}
		}
		this.ViewModel.SetTabId(data.Id);
		this.LoadTabContentAsync(data).Forget();
	}

	// Token: 0x06010AF1 RID: 68337 RVA: 0x004E1492 File Offset: 0x004DF692
	private PhotoTabItem CreatePhotoTabItem()
	{
		return new PhotoTabItem
		{
			OnTabClick = new Action<PhotoTab>(this.OnTabClick)
		};
	}

	// Token: 0x06010AF2 RID: 68338 RVA: 0x004E14AB File Offset: 0x004DF6AB
	private void OnModeChanged(PhotoCameraType mode)
	{
		PhotoMoveCtrlPanel moveCtrlPanel = this.MoveCtrlPanel;
		if (moveCtrlPanel != null)
		{
			moveCtrlPanel.RefreshByMode(mode);
		}
		PhotoDetailPanelBase currentDetailPanel = this.CurrentDetailPanel;
		if (currentDetailPanel == null)
		{
			return;
		}
		currentDetailPanel.RefreshLockState();
	}

	// Token: 0x06010AF3 RID: 68339 RVA: 0x004E14CF File Offset: 0x004DF6CF
	private void OnFilterDetailModeChanged(bool isDetail)
	{
		UUIItem item = base.GetItem(0);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(!isDetail);
	}

	// Token: 0x06010AF4 RID: 68340 RVA: 0x004E14E8 File Offset: 0x004DF6E8
	public void OpenLastDetailPanel()
	{
		if (this.CurrentDetailPanel != null)
		{
			this.HasPendingJump = true;
			this.JumpNavigationOnDetailPanelShown();
			return;
		}
		PhotoTab? photoTab = (this.ViewModel.LastTabId > 0) ? PhotographConfig.Instance.GetPhotoTabConfigById(this.ViewModel.LastTabId) : this.GetFirstTabConfig();
		if (photoTab == null)
		{
			return;
		}
		this.HasPendingJump = true;
		this.OnTabClick(photoTab.Value);
	}

	// Token: 0x06010AF5 RID: 68341 RVA: 0x004E1558 File Offset: 0x004DF758
	private PhotoTab? GetFirstTabConfig()
	{
		IReadOnlyList<PhotoTab> allPhotoTabConfig = PhotographConfig.Instance.GetAllPhotoTabConfig();
		if (allPhotoTabConfig == null || allPhotoTabConfig.Count == 0)
		{
			return null;
		}
		List<PhotoTab> list = new List<PhotoTab>(allPhotoTabConfig);
		list.Sort((PhotoTab a, PhotoTab b) => a.SortId - b.SortId);
		return new PhotoTab?(list[0]);
	}

	// Token: 0x06010AF6 RID: 68342 RVA: 0x004E15BC File Offset: 0x004DF7BC
	private void OnBackClick()
	{
		if (this.CurrentDetailPanel == null || (this.IsStickerEditing && Info.Instance.IsInGamepad()))
		{
			return;
		}
		this.ViewModel.SetLastTabId(this.ViewModel.CurrentTabId);
		this.ViewModel.SetTabId(0);
		GenericScrollViewNew<PhotoTabItem, PhotoTab> tabScroll = this.TabScroll;
		if (tabScroll != null)
		{
			GenericLayout<PhotoTabItem, PhotoTab> genericLayout = tabScroll.GetGenericLayout();
			if (genericLayout != null)
			{
				genericLayout.DeselectCurrentGridProxy();
			}
		}
		this.ClearTabContent();
		Action onDetailPanelClosed = this.ViewModel.OnDetailPanelClosed;
		if (onDetailPanelClosed == null)
		{
			return;
		}
		onDetailPanelClosed();
	}

	// Token: 0x06010AF7 RID: 68343 RVA: 0x004E163F File Offset: 0x004DF83F
	public void SetViewModel(PhotoMainViewModel viewModel)
	{
		this.ViewModel = viewModel;
	}

	// Token: 0x0400933E RID: 37694
	private PhotoMainViewModel ViewModel;

	// Token: 0x0400933F RID: 37695
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<PhotoTabItem, PhotoTab> TabScroll;

	// Token: 0x04009340 RID: 37696
	[Nullable(2)]
	private PhotoMoveCtrlPanel MoveCtrlPanel;

	// Token: 0x04009341 RID: 37697
	private readonly Dictionary<EPhotoTabType, PhotoDetailPanelBase> DetailPanelCache = new Dictionary<EPhotoTabType, PhotoDetailPanelBase>();

	// Token: 0x04009342 RID: 37698
	private readonly HashSet<EPhotoTabType> LoadingTabSet = new HashSet<EPhotoTabType>();

	// Token: 0x04009343 RID: 37699
	[Nullable(2)]
	private PhotoDetailPanelBase CurrentDetailPanel;

	// Token: 0x04009344 RID: 37700
	private bool IsStickerEditing;

	// Token: 0x04009345 RID: 37701
	private bool HasPendingJump;

	// Token: 0x04009346 RID: 37702
	private int PendingJumpRetryFrame;

	// Token: 0x02007CF2 RID: 31986
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x04028766 RID: 165734
		ItemMenu,
		// Token: 0x04028767 RID: 165735
		BtnBack,
		// Token: 0x04028768 RID: 165736
		ScrollMenu,
		// Token: 0x04028769 RID: 165737
		ItemTypeTemplate,
		// Token: 0x0402876A RID: 165738
		ItemTempContent,
		// Token: 0x0402876B RID: 165739
		ItemMoveCtrl
	}
}
