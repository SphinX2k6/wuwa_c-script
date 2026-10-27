using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020010F1 RID: 4337
[NullableContext(1)]
[Nullable(0)]
public class ArtemisDialogueBoxPanel : UiPanelBase
{
	// Token: 0x0600710F RID: 28943 RVA: 0x0017170C File Offset: 0x0016F90C
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

	// Token: 0x06007110 RID: 28944 RVA: 0x001717C0 File Offset: 0x0016F9C0
	protected override UniTask OnBeforeStartAsync()
	{
		ArtemisDialogueBoxPanel.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ArtemisDialogueBoxPanel.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06007111 RID: 28945 RVA: 0x00171803 File Offset: 0x0016FA03
	protected override void OnStart()
	{
		this.ItemLayout = new GenericLayout<CommonItemSmallItemGrid, TItem>(base.GetHorizontalLayout(4), new Func<CommonItemSmallItemGrid>(this.InitGridItem), null, false, true);
		this.UiScrollView = base.GetScrollViewWithScrollbar(0);
	}

	// Token: 0x06007112 RID: 28946 RVA: 0x00171833 File Offset: 0x0016FA33
	protected override void OnBeforeDestroy()
	{
		if (this.ScrollTimer != null && this.ScrollTimer.Valid())
		{
			this.ScrollTimer.Remove();
			this.ScrollTimer = null;
		}
	}

	// Token: 0x06007113 RID: 28947 RVA: 0x0017185D File Offset: 0x0016FA5D
	private CommonItemSmallItemGrid InitGridItem()
	{
		return new CommonItemSmallItemGrid
		{
			ShowReceivedCallBack = ((TItem _) => this.IsRewarded)
		};
	}

	// Token: 0x06007114 RID: 28948 RVA: 0x00171876 File Offset: 0x0016FA76
	public void SetShowRewardItems(bool isShow)
	{
		UUIItem item = base.GetItem(2);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(isShow);
	}

	// Token: 0x06007115 RID: 28949 RVA: 0x0017188C File Offset: 0x0016FA8C
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

	// Token: 0x06007116 RID: 28950 RVA: 0x001718DF File Offset: 0x0016FADF
	public void ShowDialogue(int[] ids, bool isLockStatus, bool isShowEffect)
	{
		ArtemisDialogueParentItem chatParentItem = this.ChatParentItem;
		if (chatParentItem == null)
		{
			return;
		}
		chatParentItem.RefreshChatUiItem(ids, isLockStatus, isShowEffect);
	}

	// Token: 0x06007117 RID: 28951 RVA: 0x001718F4 File Offset: 0x0016FAF4
	public void ScrollToTop(bool isTop)
	{
		this.IsScrollToTop = isTop;
	}

	// Token: 0x06007118 RID: 28952 RVA: 0x001718FD File Offset: 0x0016FAFD
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

	// Token: 0x06007119 RID: 28953 RVA: 0x00171928 File Offset: 0x0016FB28
	public void PlayFixDoneSequence()
	{
		ArtemisDialogueParentItem chatParentItem = this.ChatParentItem;
		if (chatParentItem == null)
		{
			return;
		}
		chatParentItem.LeftPlayFixDoneLevelSequence();
	}

	// Token: 0x0400345E RID: 13406
	[Nullable(2)]
	private ArtemisDialogueParentItem ChatParentItem;

	// Token: 0x0400345F RID: 13407
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<CommonItemSmallItemGrid, TItem> ItemLayout;

	// Token: 0x04003460 RID: 13408
	private bool IsRewarded;

	// Token: 0x04003461 RID: 13409
	[Nullable(2)]
	private TimerHandle ScrollTimer;

	// Token: 0x04003462 RID: 13410
	private bool IsScrollToTop;

	// Token: 0x04003463 RID: 13411
	public UUIScrollViewWithScrollbarComponent UiScrollView;

	// Token: 0x020076B5 RID: 30389
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x040272D6 RID: 160470
		public const int ChatView = 0;

		// Token: 0x040272D7 RID: 160471
		public const int DiglogueItem = 1;

		// Token: 0x040272D8 RID: 160472
		public const int PnlReward = 2;

		// Token: 0x040272D9 RID: 160473
		public const int RewardTitle = 3;

		// Token: 0x040272DA RID: 160474
		public const int RewardItemLayout = 4;

		// Token: 0x040272DB RID: 160475
		public const int RewardItem = 5;

		// Token: 0x040272DC RID: 160476
		public const int ChatScrollBar = 6;
	}
}
