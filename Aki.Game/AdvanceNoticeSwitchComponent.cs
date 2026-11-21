using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000591 RID: 1425
[NullableContext(1)]
[Nullable(0)]
public class AdvanceNoticeSwitchComponent
{
	// Token: 0x060043FA RID: 17402 RVA: 0x0017778C File Offset: 0x0017598C
	public void Initialize(UUIButtonComponent contentLeftArrowButton, UUIButtonComponent contentRightArrowButton, UUIScrollViewWithScrollbarComponent thumbScrollView, UUIItem thumbTemplateItem)
	{
		if (this.IsInitialized)
		{
			return;
		}
		this.IsInitialized = true;
		this.ContentLeftArrowButton = contentLeftArrowButton;
		this.ContentRightArrowButton = contentRightArrowButton;
		this.ThumbScrollViewComponent = thumbScrollView;
		this.ThumbTemplateItem = thumbTemplateItem;
		this.ThumbScrollView = new GenericScrollViewNew<AdvanceNoticeThumbItem, AdvanceNoticeThumbItemData>(this.ThumbScrollViewComponent, new Func<AdvanceNoticeThumbItem>(this.CreateThumbItem), this.ThumbTemplateItem.GetOwner() as AUIBaseActor, false, null);
	}

	// Token: 0x060043FB RID: 17403 RVA: 0x001777F5 File Offset: 0x001759F5
	private AdvanceNoticeThumbItem CreateThumbItem()
	{
		return new AdvanceNoticeThumbItem
		{
			OnItemToggleClickDelegate = new Action<AdvanceNoticeThumbItemData, int>(this.OnThumbItemClicked),
			CanItemToggleChangeDelegate = new Func<AdvanceNoticeThumbItemData, int, bool>(this.CanThumbItemToggleChange)
		};
	}

	// Token: 0x060043FC RID: 17404 RVA: 0x00177820 File Offset: 0x00175A20
	public void Refresh(AdvanceNoticeViewModel viewModel)
	{
		this.ViewModel = viewModel;
		this.DataCheck();
		GenericScrollViewNew<AdvanceNoticeThumbItem, AdvanceNoticeThumbItemData> thumbScrollView = this.ThumbScrollView;
		if (thumbScrollView != null)
		{
			thumbScrollView.RefreshByData(this.ViewModel.AdvanceNoticeThumbItemDataList, new Action(this.LateScrollTo), false);
		}
		this.RefreshContent();
	}

	// Token: 0x060043FD RID: 17405 RVA: 0x00177860 File Offset: 0x00175A60
	private void LateScrollTo()
	{
		UUIScrollViewWithScrollbarComponent thumbScrollViewComponent = this.ThumbScrollViewComponent;
		if (thumbScrollViewComponent == null || !thumbScrollViewComponent.IsValid())
		{
			return;
		}
		if (this.ViewModel == null)
		{
			return;
		}
		GenericScrollViewNew<AdvanceNoticeThumbItem, AdvanceNoticeThumbItemData> thumbScrollView = this.ThumbScrollView;
		AdvanceNoticeThumbItem advanceNoticeThumbItem = (thumbScrollView != null) ? thumbScrollView.GetScrollItemByIndex(this.ViewModel.CurrentSubTabIndex) : null;
		if (advanceNoticeThumbItem != null)
		{
			GenericScrollViewNew<AdvanceNoticeThumbItem, AdvanceNoticeThumbItemData> thumbScrollView2 = this.ThumbScrollView;
			if (thumbScrollView2 == null)
			{
				return;
			}
			thumbScrollView2.LateScrollTo(advanceNoticeThumbItem.GetRootItem(), null, false);
		}
	}

	// Token: 0x060043FE RID: 17406 RVA: 0x001778C7 File Offset: 0x00175AC7
	public void RefreshContent()
	{
		this.RefreshContentArrowActive();
	}

	// Token: 0x060043FF RID: 17407 RVA: 0x001778D0 File Offset: 0x00175AD0
	public void DataCheck()
	{
		if (this.ViewModel == null)
		{
			return;
		}
		List<AdvanceNoticeThumbItemData> advanceNoticeThumbItemDataList = this.ViewModel.AdvanceNoticeThumbItemDataList;
		for (int i = 0; i < advanceNoticeThumbItemDataList.Count; i++)
		{
			advanceNoticeThumbItemDataList[i].IsSelected = (i == this.ViewModel.CurrentSubTabIndex);
		}
	}

	// Token: 0x06004400 RID: 17408 RVA: 0x0017791D File Offset: 0x00175B1D
	private void OnThumbItemClicked(AdvanceNoticeThumbItemData data, int gridIndex)
	{
		if (!this.TabIdCheck(data.TabId))
		{
			return;
		}
		this.SelectThumb(gridIndex);
		AdvanceNoticeViewModel viewModel = this.ViewModel;
		if (viewModel == null)
		{
			return;
		}
		viewModel.ClickTabLogEvent();
	}

	// Token: 0x06004401 RID: 17409 RVA: 0x00177945 File Offset: 0x00175B45
	private bool CanThumbItemToggleChange(AdvanceNoticeThumbItemData data, int gridIndex)
	{
		return this.TabIdCheck(data.TabId);
	}

	// Token: 0x06004402 RID: 17410 RVA: 0x00177953 File Offset: 0x00175B53
	private bool TabIdCheck(int tabId)
	{
		return tabId == this.ViewModel.TabId;
	}

	// Token: 0x06004403 RID: 17411 RVA: 0x00177964 File Offset: 0x00175B64
	public void SelectThumb(int gridIndex)
	{
		if (this.ViewModel == null || !this.CheckIndexInRange(gridIndex))
		{
			return;
		}
		if (this.ViewModel.CurrentSubTabIndex == gridIndex)
		{
			return;
		}
		int currentSubTabIndex = this.ViewModel.CurrentSubTabIndex;
		if (currentSubTabIndex != -1)
		{
			GenericScrollViewNew<AdvanceNoticeThumbItem, AdvanceNoticeThumbItemData> thumbScrollView = this.ThumbScrollView;
			AdvanceNoticeThumbItem advanceNoticeThumbItem = (thumbScrollView != null) ? thumbScrollView.GetScrollItemByIndex(currentSubTabIndex) : null;
			if (advanceNoticeThumbItem != null)
			{
				advanceNoticeThumbItem.RefreshToggleState(false);
			}
		}
		this.ViewModel.CurrentSubTabIndex = gridIndex;
		GenericScrollViewNew<AdvanceNoticeThumbItem, AdvanceNoticeThumbItemData> thumbScrollView2 = this.ThumbScrollView;
		AdvanceNoticeThumbItem advanceNoticeThumbItem2 = (thumbScrollView2 != null) ? thumbScrollView2.GetScrollItemByIndex(gridIndex) : null;
		if (advanceNoticeThumbItem2 != null)
		{
			advanceNoticeThumbItem2.RefreshToggleState(true);
			UUIScrollViewWithScrollbarComponent thumbScrollViewComponent = this.ThumbScrollViewComponent;
			if (thumbScrollViewComponent != null)
			{
				thumbScrollViewComponent.ScrollTo(advanceNoticeThumbItem2.GetRootItem(), true);
			}
		}
		this.RefreshContent();
		this.ViewModel.OnSwitchSubTab(gridIndex);
	}

	// Token: 0x06004404 RID: 17412 RVA: 0x00177A14 File Offset: 0x00175C14
	public void SelectPreviousThumb()
	{
		if (this.ViewModel == null)
		{
			return;
		}
		this.SelectThumb(this.ViewModel.CurrentSubTabIndex - 1);
	}

	// Token: 0x06004405 RID: 17413 RVA: 0x00177A32 File Offset: 0x00175C32
	public void SelectNextThumb()
	{
		if (this.ViewModel == null)
		{
			return;
		}
		this.SelectThumb(this.ViewModel.CurrentSubTabIndex + 1);
	}

	// Token: 0x06004406 RID: 17414 RVA: 0x00177A50 File Offset: 0x00175C50
	public bool CheckIndexInRange(int index)
	{
		return index >= 0 && index < this.ViewModel.AdvanceNoticeThumbItemDataList.Count;
	}

	// Token: 0x06004407 RID: 17415 RVA: 0x00177A6C File Offset: 0x00175C6C
	public void RefreshContentArrowActive()
	{
		if (this.ViewModel == null)
		{
			return;
		}
		int count = this.ViewModel.AdvanceNoticeThumbItemDataList.Count;
		this.ContentLeftArrowButton.RootUIComp.Get().SetUIActive(this.ViewModel.CurrentSubTabIndex > 0);
		this.ContentRightArrowButton.RootUIComp.Get().SetUIActive(this.ViewModel.CurrentSubTabIndex < count - 1);
	}

	// Token: 0x040034BA RID: 13498
	[Nullable(2)]
	private AdvanceNoticeViewModel ViewModel;

	// Token: 0x040034BB RID: 13499
	[Nullable(2)]
	private UUIButtonComponent ContentLeftArrowButton;

	// Token: 0x040034BC RID: 13500
	[Nullable(2)]
	private UUIButtonComponent ContentRightArrowButton;

	// Token: 0x040034BD RID: 13501
	[Nullable(2)]
	private UUIScrollViewWithScrollbarComponent ThumbScrollViewComponent;

	// Token: 0x040034BE RID: 13502
	[Nullable(2)]
	private UUIItem ThumbTemplateItem;

	// Token: 0x040034BF RID: 13503
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<AdvanceNoticeThumbItem, AdvanceNoticeThumbItemData> ThumbScrollView;

	// Token: 0x040034C0 RID: 13504
	private bool IsInitialized;
}
