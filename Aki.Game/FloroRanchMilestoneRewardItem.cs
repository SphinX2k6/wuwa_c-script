using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001B96 RID: 7062
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class FloroRanchMilestoneRewardItem : GridProxyAbstract<FloroRanchMilestoneData>
{
	// Token: 0x0600D243 RID: 53827 RVA: 0x0030444C File Offset: 0x0030264C
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

	// Token: 0x0600D244 RID: 53828 RVA: 0x003044D8 File Offset: 0x003026D8
	protected override void OnStart()
	{
		this.RewardItemGrid = new SmallItemGrid();
		this.RewardItemGrid.Initialize(base.GetItem(2).GetOwner());
		this.RewardItemGrid.BindOnCanExecuteChange((object _, bool _, EToggleState _) => false);
		this.RewardItemGrid.BindOnExtendToggleClicked(new Action<MediumItemGridExtendCallback>(this.OnClickedGrid));
	}

	// Token: 0x0600D245 RID: 53829 RVA: 0x00304548 File Offset: 0x00302748
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

	// Token: 0x0600D246 RID: 53830 RVA: 0x003045BC File Offset: 0x003027BC
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

	// Token: 0x0600D247 RID: 53831 RVA: 0x00304690 File Offset: 0x00302890
	private void OnClickedGrid(MediumItemGridExtendCallback onExtendToggleClickedCallback)
	{
		if (!this.Data.IsFinished || this.Data.IsReceive)
		{
			ItemController.Instance.OpenItemTipsByItemId(this.RewardItem.Value.ItemData.ItemId, true, null);
			return;
		}
		Action onClickToGet = this.OnClickToGet;
		if (onClickToGet == null)
		{
			return;
		}
		onClickToGet();
	}

	// Token: 0x0400605C RID: 24668
	private FloroRanchMilestoneData Data;

	// Token: 0x0400605D RID: 24669
	[Nullable(2)]
	private SmallItemGrid RewardItemGrid;

	// Token: 0x0400605E RID: 24670
	private TItem? RewardItem;

	// Token: 0x0400605F RID: 24671
	[Nullable(2)]
	public Action OnClickToGet;

	// Token: 0x02008123 RID: 33059
	[NullableContext(0)]
	private class EItemComponent
	{
		// Token: 0x0402A275 RID: 172661
		public const int SpriteBg = 0;

		// Token: 0x0402A276 RID: 172662
		public const int TxtGoal = 1;

		// Token: 0x0402A277 RID: 172663
		public const int RewardItem = 2;
	}
}
