using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020005A8 RID: 1448
[NullableContext(1)]
[Nullable(0)]
public class ArtemisDialogueParentItem : UiPanelBase
{
	// Token: 0x060044C1 RID: 17601 RVA: 0x0017A3CF File Offset: 0x001785CF
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x060044C2 RID: 17602 RVA: 0x0017A408 File Offset: 0x00178608
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

	// Token: 0x060044C3 RID: 17603 RVA: 0x0017A42F File Offset: 0x0017862F
	public void RefreshChatUiItem(int[] ids, bool isLockStatus, bool isShowEffect)
	{
		this.RefreshChatUiItemAsync(ids, isLockStatus, isShowEffect).Forget();
	}

	// Token: 0x060044C4 RID: 17604 RVA: 0x0017A440 File Offset: 0x00178640
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

	// Token: 0x060044C5 RID: 17605 RVA: 0x0017A49C File Offset: 0x0017869C
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

	// Token: 0x060044C6 RID: 17606 RVA: 0x0017A4F0 File Offset: 0x001786F0
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

	// Token: 0x060044C7 RID: 17607 RVA: 0x0017A5BC File Offset: 0x001787BC
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

	// Token: 0x060044C8 RID: 17608 RVA: 0x0017A5E3 File Offset: 0x001787E3
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

	// Token: 0x060044C9 RID: 17609 RVA: 0x0017A618 File Offset: 0x00178818
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

	// Token: 0x060044CA RID: 17610 RVA: 0x0017A664 File Offset: 0x00178864
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

	// Token: 0x060044CB RID: 17611 RVA: 0x0017A6B0 File Offset: 0x001788B0
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

	// Token: 0x04003501 RID: 13569
	private int LeftIndex;

	// Token: 0x04003502 RID: 13570
	private int RightIndex;

	// Token: 0x04003503 RID: 13571
	private readonly List<ArtemisChatLeftItem> LeftItemList = new List<ArtemisChatLeftItem>();

	// Token: 0x04003504 RID: 13572
	private readonly List<ArtemisChatRightItem> RightItemList = new List<ArtemisChatRightItem>();

	// Token: 0x04003505 RID: 13573
	private readonly List<UUIItem> CacheItemList = new List<UUIItem>();

	// Token: 0x04003506 RID: 13574
	[Nullable(2)]
	public Action WaitCallback;

	// Token: 0x0200684B RID: 26699
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x0402262A RID: 140842
		public const int LeftItem = 0;

		// Token: 0x0402262B RID: 140843
		public const int RightItem = 1;
	}
}
