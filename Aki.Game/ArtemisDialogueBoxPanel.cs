using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020005A5 RID: 1445
[NullableContext(1)]
[Nullable(0)]
public class ArtemisDialogueBoxPanel : UiPanelBase
{
	// Token: 0x060044A5 RID: 17573 RVA: 0x0017A0C8 File Offset: 0x001782C8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIScrollbarComponent))
		};
	}

	// Token: 0x060044A6 RID: 17574 RVA: 0x0017A17C File Offset: 0x0017837C
	protected override UniTask OnBeforeStartAsync()
	{
		ArtemisDialogueBoxPanel.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ArtemisDialogueBoxPanel.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060044A7 RID: 17575 RVA: 0x0017A1BF File Offset: 0x001783BF
	protected override void OnStart()
	{
		this.ItemLayout = new GenericLayout<CommonItemSmallItemGrid, TItem>(base.GetHorizontalLayout(4), new Func<CommonItemSmallItemGrid>(this.InitGridItem), null, false, true);
		this.UiScrollView = base.GetScrollViewWithScrollbar(0);
	}

	// Token: 0x060044A8 RID: 17576 RVA: 0x0017A1EF File Offset: 0x001783EF
	protected override void OnBeforeDestroy()
	{
		if (this.ScrollTimer != null && this.ScrollTimer.Valid())
		{
			this.ScrollTimer.Remove();
			this.ScrollTimer = null;
		}
	}

	// Token: 0x060044A9 RID: 17577 RVA: 0x0017A219 File Offset: 0x00178419
	private CommonItemSmallItemGrid InitGridItem()
	{
		return new CommonItemSmallItemGrid
		{
			ShowReceivedCallBack = ((TItem _) => this.IsRewarded)
		};
	}

	// Token: 0x060044AA RID: 17578 RVA: 0x0017A232 File Offset: 0x00178432
	public void SetShowRewardItems(bool isShow)
	{
		UUIItem item = base.GetItem(2);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(isShow);
	}

	// Token: 0x060044AB RID: 17579 RVA: 0x0017A248 File Offset: 0x00178448
	public void SetRewardItems(List<TItem> rewardItems, bool isRewarded)
	{
		this.IsRewarded = isRewarded;
		GenericLayout<CommonItemSmallItemGrid, TItem> itemLayout = this.ItemLayout;
		if (itemLayout != null)
		{
			itemLayout.SetActive(rewardItems == null || rewardItems.Count != 0);
		}
		if (rewardItems == null || rewardItems.Count == 0)
		{
			return;
		}
		GenericLayout<CommonItemSmallItemGrid, TItem> itemLayout2 = this.ItemLayout;
		if (itemLayout2 == null)
		{
			return;
		}
		itemLayout2.RefreshByData(rewardItems, null, false);
	}

	// Token: 0x060044AC RID: 17580 RVA: 0x0017A29B File Offset: 0x0017849B
	public void ShowDialogue(int[] ids, bool isLockStatus, bool isShowEffect)
	{
		ArtemisDialogueParentItem chatParentItem = this.ChatParentItem;
		if (chatParentItem == null)
		{
			return;
		}
		chatParentItem.RefreshChatUiItem(ids, isLockStatus, isShowEffect);
	}

	// Token: 0x060044AD RID: 17581 RVA: 0x0017A2B0 File Offset: 0x001784B0
	public void ScrollToTop(bool isTop)
	{
		this.IsScrollToTop = isTop;
	}

	// Token: 0x060044AE RID: 17582 RVA: 0x0017A2B9 File Offset: 0x001784B9
	public void DelayScrollToBotttom()
	{
		this.ScrollTimer = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
		{
			UUIItem uuiitem;
			if (!this.IsScrollToTop)
			{
				ArtemisDialogueParentItem chatParentItem = this.ChatParentItem;
				uuiitem = ((chatParentItem != null) ? chatParentItem.GetLastItem() : null);
			}
			else
			{
				ArtemisDialogueParentItem chatParentItem2 = this.ChatParentItem;
				uuiitem = ((chatParentItem2 != null) ? chatParentItem2.GetFirstItem() : null);
			}
			UUIItem uuiitem2 = uuiitem;
			if (uuiitem2 != null)
			{
				UUIScrollViewWithScrollbarComponent uiScrollView = this.UiScrollView;
				if (uiScrollView != null)
				{
					uiScrollView.StopMovement();
				}
				this.UiScrollView.ScrollTo(uuiitem2, false);
			}
		}, 100f, null, null, true, 1f);
	}

	// Token: 0x060044AF RID: 17583 RVA: 0x0017A2E4 File Offset: 0x001784E4
	public void PlayFixDoneSequence()
	{
		ArtemisDialogueParentItem chatParentItem = this.ChatParentItem;
		if (chatParentItem == null)
		{
			return;
		}
		chatParentItem.LeftPlayFixDoneLevelSequence();
	}

	// Token: 0x040034F7 RID: 13559
	[Nullable(2)]
	private ArtemisDialogueParentItem ChatParentItem;

	// Token: 0x040034F8 RID: 13560
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<CommonItemSmallItemGrid, TItem> ItemLayout;

	// Token: 0x040034F9 RID: 13561
	private bool IsRewarded;

	// Token: 0x040034FA RID: 13562
	[Nullable(2)]
	private TimerHandle ScrollTimer;

	// Token: 0x040034FB RID: 13563
	private bool IsScrollToTop;

	// Token: 0x040034FC RID: 13564
	public UUIScrollViewWithScrollbarComponent UiScrollView;

	// Token: 0x02006849 RID: 26697
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x0402261F RID: 140831
		public const int ChatView = 0;

		// Token: 0x04022620 RID: 140832
		public const int DiglogueItem = 1;

		// Token: 0x04022621 RID: 140833
		public const int PnlReward = 2;

		// Token: 0x04022622 RID: 140834
		public const int RewardTitle = 3;

		// Token: 0x04022623 RID: 140835
		public const int RewardItemLayout = 4;

		// Token: 0x04022624 RID: 140836
		public const int RewardItem = 5;

		// Token: 0x04022625 RID: 140837
		public const int ChatScrollBar = 6;
	}
}
