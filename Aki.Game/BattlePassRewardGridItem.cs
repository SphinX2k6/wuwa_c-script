using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200232D RID: 9005
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class BattlePassRewardGridItem : GridProxyAbstract<BattlePassRewardData>
{
	// Token: 0x06011D3E RID: 73022 RVA: 0x004644B0 File Offset: 0x004626B0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>();
	}

	// Token: 0x06011D3F RID: 73023 RVA: 0x00464568 File Offset: 0x00462768
	private void ClickCallFree(MediumItemGridExtendCallback callbackParameter)
	{
		int itemId = ((TItem)callbackParameter.Data).ItemData.ItemId;
		this.OnClickItem(this.RewardData.FreeRewardItem[0].ItemType.Value, itemId, BattlePassType.Free);
	}

	// Token: 0x06011D40 RID: 73024 RVA: 0x004645AE File Offset: 0x004627AE
	private void OnClickItem(EBattlePassItemType itemType, int itemId, BattlePassType payType)
	{
		if (itemType == EBattlePassItemType.CanGet)
		{
			BattlePassController.Instance.RequestTakeBattlePassReward(payType, this.RewardData.Level.Value, itemId, base.GridIndex);
			return;
		}
		ItemController.Instance.OpenItemTipsByItemId(itemId, true, null);
	}

	// Token: 0x06011D41 RID: 73025 RVA: 0x004645E4 File Offset: 0x004627E4
	private void ClickCallPayItem1(MediumItemGridExtendCallback callbackParameter)
	{
		int itemId = ((TItem)callbackParameter.Data).ItemData.ItemId;
		this.OnClickItem(this.RewardData.PayRewardItem[0].ItemType.Value, itemId, BattlePassType.Pay);
	}

	// Token: 0x06011D42 RID: 73026 RVA: 0x0046462C File Offset: 0x0046282C
	private void ClickCallPayItem2(MediumItemGridExtendCallback callbackParameter)
	{
		int itemId = ((TItem)callbackParameter.Data).ItemData.ItemId;
		this.OnClickItem(this.RewardData.PayRewardItem[1].ItemType.Value, itemId, BattlePassType.Pay);
	}

	// Token: 0x06011D43 RID: 73027 RVA: 0x00464674 File Offset: 0x00462874
	protected override void OnStart()
	{
		BattlePassSmallGridItem battlePassSmallGridItem = new BattlePassSmallGridItem();
		battlePassSmallGridItem.Initialize(base.GetItem(1).GetOwner());
		battlePassSmallGridItem.BindOnExtendToggleClicked(new Action<MediumItemGridExtendCallback>(this.ClickCallFree));
		this.CommonItemGridViews.Add(battlePassSmallGridItem);
		BattlePassSmallGridItem battlePassSmallGridItem2 = new BattlePassSmallGridItem();
		battlePassSmallGridItem2.Initialize(base.GetItem(2).GetOwner());
		battlePassSmallGridItem2.BindOnExtendToggleClicked(new Action<MediumItemGridExtendCallback>(this.ClickCallPayItem1));
		this.CommonItemGridViews.Add(battlePassSmallGridItem2);
		BattlePassSmallGridItem battlePassSmallGridItem3 = new BattlePassSmallGridItem();
		battlePassSmallGridItem3.Initialize(base.GetItem(3).GetOwner());
		battlePassSmallGridItem3.BindOnExtendToggleClicked(new Action<MediumItemGridExtendCallback>(this.ClickCallPayItem2));
		this.CommonItemGridViews.Add(battlePassSmallGridItem3);
	}

	// Token: 0x06011D44 RID: 73028 RVA: 0x00464724 File Offset: 0x00462924
	public override void Refresh(BattlePassRewardData data, bool isLoop, int gridIndex)
	{
		this.RewardData = data;
		base.GetText(0).SetText(data.Level.Value.ToString(), true);
		if (data.FreeRewardItem.Count == 1)
		{
			int index = 0;
			BattlePassSmallGridItem battlePassSmallGridItem = this.CommonItemGridViews[index];
			battlePassSmallGridItem.SetActive(true);
			battlePassSmallGridItem.RefreshItem(data.FreeRewardItem[index].Item.Value, data.FreeRewardItem[index].ItemType.Value);
		}
		else
		{
			this.CommonItemGridViews[0].SetActive(false);
		}
		if (data.PayRewardItem.Count == 2)
		{
			BattlePassSmallGridItem battlePassSmallGridItem2 = this.CommonItemGridViews[1];
			BattlePassSmallGridItem battlePassSmallGridItem3 = this.CommonItemGridViews[2];
			battlePassSmallGridItem2.SetActive(true);
			battlePassSmallGridItem3.SetActive(true);
			battlePassSmallGridItem2.RefreshItem(data.PayRewardItem[0].Item.Value, data.PayRewardItem[0].ItemType.Value);
			battlePassSmallGridItem3.RefreshItem(data.PayRewardItem[1].Item.Value, data.PayRewardItem[1].ItemType.Value);
			return;
		}
		if (data.PayRewardItem.Count == 1)
		{
			this.CommonItemGridViews[1].SetActive(true);
			this.CommonItemGridViews[2].SetActive(false);
			this.CommonItemGridViews[1].RefreshItem(data.PayRewardItem[0].Item.Value, data.PayRewardItem[0].ItemType.Value);
			return;
		}
		this.CommonItemGridViews[1].SetActive(false);
		this.CommonItemGridViews[2].SetActive(false);
	}

	// Token: 0x06011D45 RID: 73029 RVA: 0x004648F0 File Offset: 0x00462AF0
	public int GetGirdLevel()
	{
		BattlePassRewardData rewardData = this.RewardData;
		return ((rewardData != null) ? rewardData.Level : null).GetValueOrDefault(-1);
	}

	// Token: 0x0400871B RID: 34587
	private readonly List<BattlePassSmallGridItem> CommonItemGridViews = new List<BattlePassSmallGridItem>();

	// Token: 0x0400871C RID: 34588
	[Nullable(2)]
	private BattlePassRewardData RewardData;

	// Token: 0x020088B0 RID: 34992
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x0402C6CB RID: 181963
		LevelText,
		// Token: 0x0402C6CC RID: 181964
		Item1,
		// Token: 0x0402C6CD RID: 181965
		Item2,
		// Token: 0x0402C6CE RID: 181966
		Item3
	}
}
