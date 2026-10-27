using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001521 RID: 5409
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class TimePointRewardItem : GridProxyAbstract<TimePointRewardData>
{
	// Token: 0x06009A40 RID: 39488 RVA: 0x00215E50 File Offset: 0x00214050
	protected unsafe override void OnRegisterComponent()
	{
		int num = 6;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickedButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06009A41 RID: 39489 RVA: 0x00215F7C File Offset: 0x0021417C
	protected override void OnStart()
	{
		this.RewardItemGrid = new SmallItemGrid();
		this.RewardItemGrid.Initialize(base.GetItem(1).GetOwner());
		this.RewardItemGrid.BindOnCanExecuteChange((object _, bool _, EToggleState _) => false);
		this.RewardItemGrid.BindOnExtendToggleClicked(new Action<MediumItemGridExtendCallback>(this.OnClickedGrid));
	}

	// Token: 0x06009A42 RID: 39490 RVA: 0x00215FEC File Offset: 0x002141EC
	[NullableContext(1)]
	public override void Refresh(TimePointRewardData data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		TimePointRewardActivity? timePointRewardById = ActivityTimePointRewardConfig.Instance.GetTimePointRewardById(this.Data.Id);
		if (timePointRewardById == null)
		{
			return;
		}
		List<TItem> list = new List<TItem>();
		for (int i = 0; i < timePointRewardById.Value.RewardItemLength; i++)
		{
			DicIntInt value = timePointRewardById.Value.RewardItem(i).Value;
			TItem item = new TItem
			{
				ItemData = new InventoryDefine.GetItemData(value.Key, 0),
				Count = value.Value
			};
			list.Add(item);
		}
		this.RewardItem = new TItem?(list[0]);
		UUIItem item2 = base.GetItem(3);
		UUIText text = base.GetText(4);
		switch (data.RewardState)
		{
		case ETimePointRewardState.Lock:
			item2.SetUIActive(false);
			text.ShowTextNew("TimePointRewardActivity_RewardDesc01");
			this.SetTextStateChangeColor(false);
			break;
		case ETimePointRewardState.UnlockAndUnClaimed:
			item2.SetUIActive(true);
			text.ShowTextNew("TimePointRewardActivity_RewardDesc02");
			this.SetTextStateChangeColor(false);
			break;
		case ETimePointRewardState.UnlockAndClaimed:
			item2.SetUIActive(false);
			text.ShowTextNew("TimePointRewardActivity_RewardDesc03");
			this.SetTextStateChangeColor(true);
			break;
		}
		this.SetIndex(gridIndex + 1);
		this.SetTime((double)this.Data.RewardTime);
		this.RefreshGrid();
	}

	// Token: 0x06009A43 RID: 39491 RVA: 0x00216148 File Offset: 0x00214348
	private void RefreshGrid()
	{
		PropSmallItemGrid parameters = new PropSmallItemGrid
		{
			Data = this.Data,
			ItemConfigId = new int?(this.RewardItem.Value.ItemData.ItemId),
			BottomText = this.RewardItem.Value.Count.ToString()
		};
		this.RewardItemGrid.Apply<PropSmallItemGrid>(parameters);
		SmallItemGrid rewardItemGrid = this.RewardItemGrid;
		TimePointRewardData data = this.Data;
		rewardItemGrid.SetReceivableVisible(data != null && data.RewardState == ETimePointRewardState.UnlockAndUnClaimed);
		SmallItemGrid rewardItemGrid2 = this.RewardItemGrid;
		TimePointRewardData data2 = this.Data;
		rewardItemGrid2.SetLockVisible(data2 != null && data2.RewardState == ETimePointRewardState.Lock);
		SmallItemGrid rewardItemGrid3 = this.RewardItemGrid;
		TimePointRewardData data3 = this.Data;
		rewardItemGrid3.SetReceivedVisible(data3 != null && data3.RewardState == ETimePointRewardState.UnlockAndClaimed);
	}

	// Token: 0x06009A44 RID: 39492 RVA: 0x00216214 File Offset: 0x00214414
	private void SetTime(double timeStamp)
	{
		DateTime dataFromTimeStamp = TimeUtil.Instance.GetDataFromTimeStamp(timeStamp * TimeUtil.Instance.Millisecond);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "TimePointRewardActivity_TimeDesc01", new <>z__ReadOnlyArray<object>(new object[]
		{
			dataFromTimeStamp.Month,
			dataFromTimeStamp.Day
		}));
	}

	// Token: 0x06009A45 RID: 39493 RVA: 0x00216278 File Offset: 0x00214478
	private void SetIndex(int index)
	{
		UUISprite spriteIndex = base.GetSprite(5);
		spriteIndex.SetUIActive(false);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 1);
		defaultInterpolatedStringHandler.AppendLiteral("SP_TimePointReward_Index0");
		defaultInterpolatedStringHandler.AppendFormatted<int>(index);
		string resourceId = defaultInterpolatedStringHandler.ToStringAndClear();
		string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
		this.SetSpriteByPath(resourcePath, spriteIndex, false, null, delegate(bool _)
		{
			spriteIndex.SetUIActive(true);
		});
	}

	// Token: 0x06009A46 RID: 39494 RVA: 0x002162FC File Offset: 0x002144FC
	private void SetTextStateChangeColor(bool useChangeColor)
	{
		UUIItem text = base.GetText(4);
		FColor? fcolor = new FColor?(base.GetText(4).changeColor);
		text.SetChangeColor(useChangeColor, fcolor);
	}

	// Token: 0x06009A47 RID: 39495 RVA: 0x0021632A File Offset: 0x0021452A
	private void OnClickedButton()
	{
		TimePointRewardData data = this.Data;
		if (data != null && data.RewardState == ETimePointRewardState.UnlockAndUnClaimed)
		{
			Action<int> onClickToGet = this.OnClickToGet;
			if (onClickToGet == null)
			{
				return;
			}
			onClickToGet(this.Data.Id);
		}
	}

	// Token: 0x06009A48 RID: 39496 RVA: 0x00216360 File Offset: 0x00214560
	[NullableContext(1)]
	private void OnClickedGrid(MediumItemGridExtendCallback callback)
	{
		TimePointRewardData data = this.Data;
		if (data == null || data.RewardState != ETimePointRewardState.UnlockAndUnClaimed)
		{
			if (this.RewardItem != null)
			{
				ItemController.Instance.OpenItemTipsByItemId(this.RewardItem.Value.ItemData.ItemId, true, null);
			}
			return;
		}
		Action<int> onClickToGet = this.OnClickToGet;
		if (onClickToGet == null)
		{
			return;
		}
		onClickToGet(this.Data.Id);
	}

	// Token: 0x040043E6 RID: 17382
	private TimePointRewardData Data;

	// Token: 0x040043E7 RID: 17383
	private SmallItemGrid RewardItemGrid;

	// Token: 0x040043E8 RID: 17384
	private TItem? RewardItem;

	// Token: 0x040043E9 RID: 17385
	public Action<int> OnClickToGet;

	// Token: 0x02007B50 RID: 31568
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x040288C0 RID: 166080
		public const int Button = 0;

		// Token: 0x040288C1 RID: 166081
		public const int ItemGrid = 1;

		// Token: 0x040288C2 RID: 166082
		public const int TxtDate = 2;

		// Token: 0x040288C3 RID: 166083
		public const int ItemCanReceive = 3;

		// Token: 0x040288C4 RID: 166084
		public const int TxtState = 4;

		// Token: 0x040288C5 RID: 166085
		public const int SpriteIndex = 5;
	}
}
