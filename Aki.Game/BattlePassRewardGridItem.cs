using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001812 RID: 6162
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class BattlePassRewardGridItem : GridProxyAbstract<BattlePassRewardData>
{
	// Token: 0x0600F1EE RID: 61934 RVA: 0x00471574 File Offset: 0x0046F774
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

	// Token: 0x0600F1EF RID: 61935 RVA: 0x0047162C File Offset: 0x0046F82C
	private void ClickCallFree(MediumItemGridExtendCallback callbackParameter)
	{
		int itemId = ((TItem)callbackParameter.Data).ItemData.ItemId;
		this.OnClickItem(this.RewardData.FreeRewardItem[0].ItemType.Value, itemId, BattlePassType.Free);
	}

	// Token: 0x0600F1F0 RID: 61936 RVA: 0x00471672 File Offset: 0x0046F872
	private void OnClickItem(EBattlePassItemType itemType, int itemId, BattlePassType payType)
	{
		if (itemType == EBattlePassItemType.CanGet)
		{
			BattlePassController.Instance.RequestTakeBattlePassReward(payType, this.RewardData.Level.Value, itemId, base.GridIndex);
			return;
		}
		ItemController.Instance.OpenItemTipsByItemId(itemId, true, null, false);
	}

	// Token: 0x0600F1F1 RID: 61937 RVA: 0x004716AC File Offset: 0x0046F8AC
	private void ClickCallPayItem1(MediumItemGridExtendCallback callbackParameter)
	{
		int itemId = ((TItem)callbackParameter.Data).ItemData.ItemId;
		this.OnClickItem(this.RewardData.PayRewardItem[0].ItemType.Value, itemId, BattlePassType.Pay);
	}

	// Token: 0x0600F1F2 RID: 61938 RVA: 0x004716F4 File Offset: 0x0046F8F4
	private void ClickCallPayItem2(MediumItemGridExtendCallback callbackParameter)
	{
		int itemId = ((TItem)callbackParameter.Data).ItemData.ItemId;
		this.OnClickItem(this.RewardData.PayRewardItem[1].ItemType.Value, itemId, BattlePassType.Pay);
	}

	// Token: 0x0600F1F3 RID: 61939 RVA: 0x0047173C File Offset: 0x0046F93C
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

	// Token: 0x0600F1F4 RID: 61940 RVA: 0x004717EC File Offset: 0x0046F9EC
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

	// Token: 0x0600F1F5 RID: 61941 RVA: 0x004719B8 File Offset: 0x0046FBB8
	public int GetGirdLevel()
	{
		BattlePassRewardData rewardData = this.RewardData;
		return ((rewardData != null) ? rewardData.Level : null).GetValueOrDefault(-1);
	}

	// Token: 0x0400885E RID: 34910
	private readonly List<BattlePassSmallGridItem> CommonItemGridViews = new List<BattlePassSmallGridItem>();

	// Token: 0x0400885F RID: 34911
	[Nullable(2)]
	private BattlePassRewardData RewardData;

	// Token: 0x02007A39 RID: 31289
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x040279DF RID: 162271
		LevelText,
		// Token: 0x040279E0 RID: 162272
		Item1,
		// Token: 0x040279E1 RID: 162273
		Item2,
		// Token: 0x040279E2 RID: 162274
		Item3
	}
}
