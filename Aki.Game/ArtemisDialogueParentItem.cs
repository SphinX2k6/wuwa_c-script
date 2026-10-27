using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020010F4 RID: 4340
[NullableContext(1)]
[Nullable(0)]
public class ArtemisDialogueParentItem : UiPanelBase
{
	// Token: 0x0600712B RID: 28971 RVA: 0x00171A13 File Offset: 0x0016FC13
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x0600712C RID: 28972 RVA: 0x00171A4C File Offset: 0x0016FC4C
	protected override void OnBeforeShow()
	{
		UUIItem item = base.GetItem(0);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		UUIItem item2 = base.GetItem(1);
		if (item2 == null)
		{
			return;
		}
		item2.SetUIActive(false);
	}

	// Token: 0x0600712D RID: 28973 RVA: 0x00171A73 File Offset: 0x0016FC73
	public void RefreshChatUiItem(int[] ids, bool isLockStatus, bool isShowEffect)
	{
		this.RefreshChatUiItemAsync(ids, isLockStatus, isShowEffect).Forget();
	}

	// Token: 0x0600712E RID: 28974 RVA: 0x00171A84 File Offset: 0x0016FC84
	public UniTask RefreshChatUiItemAsync(int[] ids, bool isLockStatus, bool isShowEffect)
	{
		ArtemisDialogueParentItem.<RefreshChatUiItemAsync>d__10 <RefreshChatUiItemAsync>d__;
		<RefreshChatUiItemAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshChatUiItemAsync>d__.<>4__this = this;
		<RefreshChatUiItemAsync>d__.ids = ids;
		<RefreshChatUiItemAsync>d__.isLockStatus = isLockStatus;
		<RefreshChatUiItemAsync>d__.isShowEffect = isShowEffect;
		<RefreshChatUiItemAsync>d__.<>1__state = -1;
		<RefreshChatUiItemAsync>d__.<>t__builder.Start<ArtemisDialogueParentItem.<RefreshChatUiItemAsync>d__10>(ref <RefreshChatUiItemAsync>d__);
		return <RefreshChatUiItemAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600712F RID: 28975 RVA: 0x00171AE0 File Offset: 0x0016FCE0
	public UniTask AddDialogueItem(bool isLeft, IArtemisChatItemData data)
	{
		ArtemisDialogueParentItem.<AddDialogueItem>d__11 <AddDialogueItem>d__;
		<AddDialogueItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<AddDialogueItem>d__.<>4__this = this;
		<AddDialogueItem>d__.isLeft = isLeft;
		<AddDialogueItem>d__.data = data;
		<AddDialogueItem>d__.<>1__state = -1;
		<AddDialogueItem>d__.<>t__builder.Start<ArtemisDialogueParentItem.<AddDialogueItem>d__11>(ref <AddDialogueItem>d__);
		return <AddDialogueItem>d__.<>t__builder.Task;
	}

	// Token: 0x06007130 RID: 28976 RVA: 0x00171B34 File Offset: 0x0016FD34
	private void HideAllChatItem()
	{
		List<ArtemisChatLeftItem> leftItemList = this.LeftItemList;
		if (leftItemList != null && leftItemList.Count > 0)
		{
			foreach (ArtemisChatLeftItem artemisChatLeftItem in this.LeftItemList)
			{
				if (artemisChatLeftItem != null)
				{
					artemisChatLeftItem.SetUiActive(false);
				}
			}
		}
		List<ArtemisChatRightItem> rightItemList = this.RightItemList;
		if (rightItemList != null && rightItemList.Count > 0)
		{
			foreach (ArtemisChatRightItem artemisChatRightItem in this.RightItemList)
			{
				if (artemisChatRightItem != null)
				{
					artemisChatRightItem.SetUiActive(false);
				}
			}
		}
	}

	// Token: 0x06007131 RID: 28977 RVA: 0x00171C00 File Offset: 0x0016FE00
	[NullableContext(2)]
	public UUIItem GetFirstItem()
	{
		List<UUIItem> cacheItemList = this.CacheItemList;
		if (cacheItemList != null && cacheItemList.Count > 0)
		{
			return this.CacheItemList[0];
		}
		return null;
	}

	// Token: 0x06007132 RID: 28978 RVA: 0x00171C27 File Offset: 0x0016FE27
	[NullableContext(2)]
	public UUIItem GetLastItem()
	{
		List<UUIItem> cacheItemList = this.CacheItemList;
		if (cacheItemList != null && cacheItemList.Count > 0)
		{
			return this.CacheItemList[this.CacheItemList.Count - 1];
		}
		return null;
	}

	// Token: 0x06007133 RID: 28979 RVA: 0x00171C5C File Offset: 0x0016FE5C
	private UniTask AddLeftItem(IArtemisChatItemData data)
	{
		ArtemisDialogueParentItem.<AddLeftItem>d__15 <AddLeftItem>d__;
		<AddLeftItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<AddLeftItem>d__.<>4__this = this;
		<AddLeftItem>d__.data = data;
		<AddLeftItem>d__.<>1__state = -1;
		<AddLeftItem>d__.<>t__builder.Start<ArtemisDialogueParentItem.<AddLeftItem>d__15>(ref <AddLeftItem>d__);
		return <AddLeftItem>d__.<>t__builder.Task;
	}

	// Token: 0x06007134 RID: 28980 RVA: 0x00171CA8 File Offset: 0x0016FEA8
	private UniTask AddRightItem(IArtemisChatItemData data)
	{
		ArtemisDialogueParentItem.<AddRightItem>d__16 <AddRightItem>d__;
		<AddRightItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<AddRightItem>d__.<>4__this = this;
		<AddRightItem>d__.data = data;
		<AddRightItem>d__.<>1__state = -1;
		<AddRightItem>d__.<>t__builder.Start<ArtemisDialogueParentItem.<AddRightItem>d__16>(ref <AddRightItem>d__);
		return <AddRightItem>d__.<>t__builder.Task;
	}

	// Token: 0x06007135 RID: 28981 RVA: 0x00171CF4 File Offset: 0x0016FEF4
	public void LeftPlayFixDoneLevelSequence()
	{
		List<ArtemisChatLeftItem> leftItemList = this.LeftItemList;
		if (leftItemList != null && leftItemList.Count > 0)
		{
			foreach (ArtemisChatLeftItem artemisChatLeftItem in this.LeftItemList)
			{
				if (artemisChatLeftItem != null && artemisChatLeftItem.GetActive())
				{
					artemisChatLeftItem.PlayFixDoneLevelSequence();
				}
			}
		}
	}

	// Token: 0x04003468 RID: 13416
	private int LeftIndex;

	// Token: 0x04003469 RID: 13417
	private int RightIndex;

	// Token: 0x0400346A RID: 13418
	private readonly List<ArtemisChatLeftItem> LeftItemList = new List<ArtemisChatLeftItem>();

	// Token: 0x0400346B RID: 13419
	private readonly List<ArtemisChatRightItem> RightItemList = new List<ArtemisChatRightItem>();

	// Token: 0x0400346C RID: 13420
	private readonly List<UUIItem> CacheItemList = new List<UUIItem>();

	// Token: 0x0400346D RID: 13421
	[Nullable(2)]
	public Action WaitCallback;

	// Token: 0x020076B7 RID: 30391
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x040272E1 RID: 160481
		public const int LeftItem = 0;

		// Token: 0x040272E2 RID: 160482
		public const int RightItem = 1;
	}
}
