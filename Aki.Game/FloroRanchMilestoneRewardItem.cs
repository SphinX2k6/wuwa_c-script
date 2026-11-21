using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001055 RID: 4181
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class FloroRanchMilestoneRewardItem : GridProxyAbstract<FloroRanchMilestoneData>
{
	// Token: 0x0600A654 RID: 42580 RVA: 0x0030F524 File Offset: 0x0030D724
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600A655 RID: 42581 RVA: 0x0030F5B0 File Offset: 0x0030D7B0
	protected override void OnStart()
	{
		this.RewardItemGrid = new SmallItemGrid();
		this.RewardItemGrid.Initialize(base.GetItem(2).GetOwner());
		this.RewardItemGrid.BindOnCanExecuteChange((object _, bool _, EToggleState _) => false);
		this.RewardItemGrid.BindOnExtendToggleClicked(new Action<MediumItemGridExtendCallback>(this.OnClickedGrid));
	}

	// Token: 0x0600A656 RID: 42582 RVA: 0x0030F620 File Offset: 0x0030D820
	public override void Refresh(FloroRanchMilestoneData data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		base.GetText(1).SetText(data.Goal.ToString(), true);
		base.GetSprite(0).SetUIActive(data.IsFinished);
		if (data.RewardList != null && data.RewardList.Count > 0)
		{
			this.RewardItem = new TItem?(data.RewardList[0]);
		}
		this.RefreshGrid();
	}

	// Token: 0x0600A657 RID: 42583 RVA: 0x0030F694 File Offset: 0x0030D894
	private void RefreshGrid()
	{
		bool lockBlackVisible = !this.Data.IsFinished;
		bool value = this.Data.IsFinished && !this.Data.IsReceive;
		bool isReceive = this.Data.IsReceive;
		PropSmallItemGrid parameters = new PropSmallItemGrid
		{
			Data = this.Data,
			ItemConfigId = new int?(this.RewardItem.Value.ItemData.ItemId),
			BottomText = this.RewardItem.Value.Count.ToString(),
			IsReceivableVisible = new bool?(value),
			IsReceivedVisible = new bool?(isReceive),
			IsRedDotVisible = new bool?(value)
		};
		this.RewardItemGrid.Apply<PropSmallItemGrid>(parameters);
		this.RewardItemGrid.SetLockBlackVisible(lockBlackVisible);
	}

	// Token: 0x0600A658 RID: 42584 RVA: 0x0030F768 File Offset: 0x0030D968
	private void OnClickedGrid(MediumItemGridExtendCallback onExtendToggleClickedCallback)
	{
		if (!this.Data.IsFinished || this.Data.IsReceive)
		{
			ItemController.Instance.OpenItemTipsByItemId(this.RewardItem.Value.ItemData.ItemId, true, null, false);
			return;
		}
		Action onClickToGet = this.OnClickToGet;
		if (onClickToGet == null)
		{
			return;
		}
		onClickToGet();
	}

	// Token: 0x0400612B RID: 24875
	private FloroRanchMilestoneData Data;

	// Token: 0x0400612C RID: 24876
	[Nullable(2)]
	private SmallItemGrid RewardItemGrid;

	// Token: 0x0400612D RID: 24877
	private TItem? RewardItem;

	// Token: 0x0400612E RID: 24878
	[Nullable(2)]
	public Action OnClickToGet;

	// Token: 0x020072B1 RID: 29361
	[NullableContext(0)]
	private class EItemComponent
	{
		// Token: 0x040255A9 RID: 153001
		public const int SpriteBg = 0;

		// Token: 0x040255AA RID: 153002
		public const int TxtGoal = 1;

		// Token: 0x040255AB RID: 153003
		public const int RewardItem = 2;
	}
}
