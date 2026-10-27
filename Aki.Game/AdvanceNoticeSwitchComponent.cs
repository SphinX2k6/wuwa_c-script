using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020010DD RID: 4317
[NullableContext(1)]
[Nullable(0)]
public class AdvanceNoticeSwitchComponent
{
	// Token: 0x06007064 RID: 28772 RVA: 0x0016EDD0 File Offset: 0x0016CFD0
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

	// Token: 0x06007065 RID: 28773 RVA: 0x0016EE39 File Offset: 0x0016D039
	private AdvanceNoticeThumbItem CreateThumbItem()
	{
		return new AdvanceNoticeThumbItem
		{
			OnItemToggleClickDelegate = new Action<AdvanceNoticeThumbItemData, int>(this.OnThumbItemClicked),
			CanItemToggleChangeDelegate = new Func<AdvanceNoticeThumbItemData, int, bool>(this.CanThumbItemToggleChange)
		};
	}

	// Token: 0x06007066 RID: 28774 RVA: 0x0016EE64 File Offset: 0x0016D064
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

	// Token: 0x06007067 RID: 28775 RVA: 0x0016EEA4 File Offset: 0x0016D0A4
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

	// Token: 0x06007068 RID: 28776 RVA: 0x0016EF0B File Offset: 0x0016D10B
	public void RefreshContent()
	{
		this.RefreshContentArrowActive();
	}

	// Token: 0x06007069 RID: 28777 RVA: 0x0016EF14 File Offset: 0x0016D114
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

	// Token: 0x0600706A RID: 28778 RVA: 0x0016EF61 File Offset: 0x0016D161
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

	// Token: 0x0600706B RID: 28779 RVA: 0x0016EF89 File Offset: 0x0016D189
	private bool CanThumbItemToggleChange(AdvanceNoticeThumbItemData data, int gridIndex)
	{
		return this.TabIdCheck(data.TabId);
	}

	// Token: 0x0600706C RID: 28780 RVA: 0x0016EF97 File Offset: 0x0016D197
	private bool TabIdCheck(int tabId)
	{
		return tabId == this.ViewModel.TabId;
	}

	// Token: 0x0600706D RID: 28781 RVA: 0x0016EFA8 File Offset: 0x0016D1A8
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

	// Token: 0x0600706E RID: 28782 RVA: 0x0016F058 File Offset: 0x0016D258
	public void SelectPreviousThumb()
	{
		if (this.ViewModel == null)
		{
			return;
		}
		this.SelectThumb(this.ViewModel.CurrentSubTabIndex - 1);
	}

	// Token: 0x0600706F RID: 28783 RVA: 0x0016F076 File Offset: 0x0016D276
	public void SelectNextThumb()
	{
		if (this.ViewModel == null)
		{
			return;
		}
		this.SelectThumb(this.ViewModel.CurrentSubTabIndex + 1);
	}

	// Token: 0x06007070 RID: 28784 RVA: 0x0016F094 File Offset: 0x0016D294
	public bool CheckIndexInRange(int index)
	{
		return index >= 0 && index < this.ViewModel.AdvanceNoticeThumbItemDataList.Count;
	}

	// Token: 0x06007071 RID: 28785 RVA: 0x0016F0B0 File Offset: 0x0016D2B0
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

	// Token: 0x04003421 RID: 13345
	[Nullable(2)]
	private AdvanceNoticeViewModel ViewModel;

	// Token: 0x04003422 RID: 13346
	[Nullable(2)]
	private UUIButtonComponent ContentLeftArrowButton;

	// Token: 0x04003423 RID: 13347
	[Nullable(2)]
	private UUIButtonComponent ContentRightArrowButton;

	// Token: 0x04003424 RID: 13348
	[Nullable(2)]
	private UUIScrollViewWithScrollbarComponent ThumbScrollViewComponent;

	// Token: 0x04003425 RID: 13349
	[Nullable(2)]
	private UUIItem ThumbTemplateItem;

	// Token: 0x04003426 RID: 13350
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<AdvanceNoticeThumbItem, AdvanceNoticeThumbItemData> ThumbScrollView;

	// Token: 0x04003427 RID: 13351
	private bool IsInitialized;
}
