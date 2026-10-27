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

// Token: 0x02002579 RID: 9593
[NullableContext(1)]
[Nullable(0)]
public class PhotoLeftPanel : UiPanelBase
{
	// Token: 0x060135FF RID: 79359 RVA: 0x004D2414 File Offset: 0x004D0614
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

	// Token: 0x06013600 RID: 79360 RVA: 0x004D24D4 File Offset: 0x004D06D4
	protected override UniTask OnBeforeStartAsync()
	{
		PhotoLeftPanel.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PhotoLeftPanel.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013601 RID: 79361 RVA: 0x004D2518 File Offset: 0x004D0718
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

	// Token: 0x06013602 RID: 79362 RVA: 0x004D2596 File Offset: 0x004D0796
	public void TickCurrentDetail(float delta)
	{
		PhotoDetailPanelBase currentDetailPanel = this.CurrentDetailPanel;
		if (currentDetailPanel != null)
		{
			currentDetailPanel.OnTick(delta);
		}
		this.TickPendingJump();
	}

	// Token: 0x06013603 RID: 79363 RVA: 0x004D25B0 File Offset: 0x004D07B0
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

	// Token: 0x06013604 RID: 79364 RVA: 0x004D25E2 File Offset: 0x004D07E2
	public void TickMoveCtrl(float delta)
	{
		PhotoMoveCtrlPanel moveCtrlPanel = this.MoveCtrlPanel;
		if (moveCtrlPanel == null)
		{
			return;
		}
		moveCtrlPanel.TickJoystick(delta);
	}

	// Token: 0x06013605 RID: 79365 RVA: 0x004D25F5 File Offset: 0x004D07F5
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

	// Token: 0x06013606 RID: 79366 RVA: 0x004D2625 File Offset: 0x004D0825
	private void SetMoveCtrlActive(bool active)
	{
		UUIItem item = base.GetItem(5);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(active && Info.Instance.IsMobilePlatform());
	}

	// Token: 0x06013607 RID: 79367 RVA: 0x004D2648 File Offset: 0x004D0848
	private UniTask RefreshTabScroll()
	{
		PhotoLeftPanel.<RefreshTabScroll>d__18 <RefreshTabScroll>d__;
		<RefreshTabScroll>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshTabScroll>d__.<>4__this = this;
		<RefreshTabScroll>d__.<>1__state = -1;
		<RefreshTabScroll>d__.<>t__builder.Start<PhotoLeftPanel.<RefreshTabScroll>d__18>(ref <RefreshTabScroll>d__);
		return <RefreshTabScroll>d__.<>t__builder.Task;
	}

	// Token: 0x06013608 RID: 79368 RVA: 0x004D268C File Offset: 0x004D088C
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

	// Token: 0x06013609 RID: 79369 RVA: 0x004D26D7 File Offset: 0x004D08D7
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

	// Token: 0x0601360A RID: 79370 RVA: 0x004D2708 File Offset: 0x004D0908
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

	// Token: 0x0601360B RID: 79371 RVA: 0x004D2734 File Offset: 0x004D0934
	protected override void OnBeforeDestroy()
	{
		PhotoMainViewModel viewModel = this.ViewModel;
		viewModel.OnModeChanged = (Action<PhotoCameraType>)Delegate.Remove(viewModel.OnModeChanged, new Action<PhotoCameraType>(this.OnModeChanged));
		PhotoMainViewModel viewModel2 = this.ViewModel;
		viewModel2.OnFilterDetailModeChanged = (Action<bool>)Delegate.Remove(viewModel2.OnFilterDetailModeChanged, new Action<bool>(this.OnFilterDetailModeChanged));
	}

	// Token: 0x0601360C RID: 79372 RVA: 0x004D278F File Offset: 0x004D098F
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

	// Token: 0x0601360D RID: 79373 RVA: 0x004D27B8 File Offset: 0x004D09B8
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

	// Token: 0x0601360E RID: 79374 RVA: 0x004D282A File Offset: 0x004D0A2A
	private PhotoTabItem CreatePhotoTabItem()
	{
		return new PhotoTabItem
		{
			OnTabClick = new Action<PhotoTab>(this.OnTabClick)
		};
	}

	// Token: 0x0601360F RID: 79375 RVA: 0x004D2843 File Offset: 0x004D0A43
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

	// Token: 0x06013610 RID: 79376 RVA: 0x004D2867 File Offset: 0x004D0A67
	private void OnFilterDetailModeChanged(bool isDetail)
	{
		UUIItem item = base.GetItem(0);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(!isDetail);
	}

	// Token: 0x06013611 RID: 79377 RVA: 0x004D2880 File Offset: 0x004D0A80
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

	// Token: 0x06013612 RID: 79378 RVA: 0x004D28F0 File Offset: 0x004D0AF0
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

	// Token: 0x06013613 RID: 79379 RVA: 0x004D2954 File Offset: 0x004D0B54
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

	// Token: 0x06013614 RID: 79380 RVA: 0x004D29D7 File Offset: 0x004D0BD7
	public void SetViewModel(PhotoMainViewModel viewModel)
	{
		this.ViewModel = viewModel;
	}

	// Token: 0x040091E5 RID: 37349
	private PhotoMainViewModel ViewModel;

	// Token: 0x040091E6 RID: 37350
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<PhotoTabItem, PhotoTab> TabScroll;

	// Token: 0x040091E7 RID: 37351
	[Nullable(2)]
	private PhotoMoveCtrlPanel MoveCtrlPanel;

	// Token: 0x040091E8 RID: 37352
	private readonly Dictionary<EPhotoTabType, PhotoDetailPanelBase> DetailPanelCache = new Dictionary<EPhotoTabType, PhotoDetailPanelBase>();

	// Token: 0x040091E9 RID: 37353
	private readonly HashSet<EPhotoTabType> LoadingTabSet = new HashSet<EPhotoTabType>();

	// Token: 0x040091EA RID: 37354
	[Nullable(2)]
	private PhotoDetailPanelBase CurrentDetailPanel;

	// Token: 0x040091EB RID: 37355
	private bool IsStickerEditing;

	// Token: 0x040091EC RID: 37356
	private bool HasPendingJump;

	// Token: 0x040091ED RID: 37357
	private int PendingJumpRetryFrame;

	// Token: 0x02008B6C RID: 35692
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x0402D459 RID: 185433
		ItemMenu,
		// Token: 0x0402D45A RID: 185434
		BtnBack,
		// Token: 0x0402D45B RID: 185435
		ScrollMenu,
		// Token: 0x0402D45C RID: 185436
		ItemTypeTemplate,
		// Token: 0x0402D45D RID: 185437
		ItemTempContent,
		// Token: 0x0402D45E RID: 185438
		ItemMoveCtrl
	}
}
