using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.ItemReward;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x0200111D RID: 4381
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class GachaAccumulateRewardItem : GridProxyAbstract<GachaAccumulateRewardItemData>
{
	// Token: 0x0600AF0F RID: 44815 RVA: 0x0033916C File Offset: 0x0033736C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 14;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600AF10 RID: 44816 RVA: 0x003393A4 File Offset: 0x003375A4
	protected override void OnStart()
	{
		this.CommonItemGrid = new CommonItemSmallItemGrid();
		this.CommonItemGrid.CreateThenShowByActor(base.GetItem(5).GetOwner());
		this.CommonItemGrid.SetAllowClickBack(false);
	}

	// Token: 0x0600AF11 RID: 44817 RVA: 0x003393D4 File Offset: 0x003375D4
	public void RefreshSpriteWidth(float width)
	{
		base.GetSprite(11).SetWidth(width);
	}

	// Token: 0x0600AF12 RID: 44818 RVA: 0x003393E4 File Offset: 0x003375E4
	private void OnClickButton()
	{
		if (this.Data.Data.Status != EGachaAccumulateRewardStatus.CanClaim)
		{
			ItemController.Instance.OpenItemTipsByItemId(this.Data.Data.GetRewardItemList()[0].ConfigId, true, null, false);
			return;
		}
		if (this.Data.IfSpecial)
		{
			ItemRewardSelectViewOpenParam viewData = new ItemRewardSelectViewOpenParam();
			int configId = this.Data.Data.GetRewardItemList()[0].ConfigId;
			int num;
			int giftPackageId = InventoryConfig.Instance.GetItemConfigData(configId).Parameters.TryGetValue(2, out num) ? num : 0;
			viewData.GiftPackageId = giftPackageId;
			viewData.AccumulateSourceId = this.Data.AccumulateId;
			viewData.OnSelectItemCallBack = delegate(int index, int itemId)
			{
				GachaAccumulateController.Instance.ClaimAccumulateRewardAsync(this.Data.AccumulateId, new int[]
				{
					this.Data.Data.Id
				}, new int[]
				{
					itemId
				}).Forget<bool>();
			};
			UiManager.Instance.CloseView(EUiViewName.GachaAccumulateBonusView, delegate(bool _)
			{
				UiManager.Instance.OpenView(EUiViewName.ItemRewardSelectView, viewData, null);
			});
			return;
		}
		List<int> list = GachaAccumulateModel.Instance.GetAccumulateData(this.Data.AccumulateId).CollectAllClaimableRewardIds();
		GachaAccumulateController.Instance.ClaimAccumulateRewardAsync(this.Data.AccumulateId, list.ToArray(), Array.Empty<int>()).Forget<bool>();
	}

	// Token: 0x0600AF13 RID: 44819 RVA: 0x00339520 File Offset: 0x00337720
	public override void Refresh(GachaAccumulateRewardItemData data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		this.RefreshCanFinishItem(data);
		this.RefreshFinishItem(data);
		this.RefreshSelectTag(data);
		this.RefreshProgressText(data);
		this.RefreshTextBg(data);
		this.RefreshItem(data);
		this.RefreshRedDot(data);
		this.RefreshSpriteBar(data);
	}

	// Token: 0x0600AF14 RID: 44820 RVA: 0x0033956C File Offset: 0x0033776C
	private void RefreshSpriteBar(GachaAccumulateRewardItemData data)
	{
		UUISprite sprite = base.GetSprite(11);
		int curGachaNum = GachaAccumulateModel.Instance.GetAccumulateData(data.AccumulateId).CurGachaNum;
		GachaAccumulateRewardData data2 = data.Data;
		int num = (data2 != null) ? data2.GachaNum : 0;
		if (curGachaNum >= num)
		{
			sprite.SetFillAmount(1f);
			return;
		}
		GachaAccumulateRewardData lastData = data.LastData;
		int num2 = (lastData != null) ? lastData.GachaNum : 0;
		int num3 = num - num2;
		float num4 = (num3 != 0) ? ((float)(curGachaNum - num2) / (float)num3) : 0f;
		sprite.SetFillAmount((num4 < 0f) ? 0f : ((num4 > 1f) ? 1f : num4));
	}

	// Token: 0x0600AF15 RID: 44821 RVA: 0x00339610 File Offset: 0x00337810
	private void RefreshProgressText(GachaAccumulateRewardItemData data)
	{
		base.GetText(6).SetText(data.Data.GachaNum.ToString(), true);
	}

	// Token: 0x0600AF16 RID: 44822 RVA: 0x00339630 File Offset: 0x00337830
	private void RefreshItem(GachaAccumulateRewardItemData data)
	{
		RewardItemData rewardItemData = data.Data.GetRewardItemList()[0];
		TItem data2 = new TItem
		{
			ItemData = new InventoryDefine.GetItemData(rewardItemData.ConfigId, 0),
			Count = rewardItemData.Count
		};
		this.CommonItemGrid.Refresh(data2);
	}

	// Token: 0x0600AF17 RID: 44823 RVA: 0x00339684 File Offset: 0x00337884
	private void RefreshTextBg(GachaAccumulateRewardItemData data)
	{
		UUIItem item = base.GetItem(7);
		UUIItem item2 = base.GetItem(8);
		bool flag = data.Data.Status == EGachaAccumulateRewardStatus.Claimed || data.Data.Status == EGachaAccumulateRewardStatus.CanClaim;
		item.SetUIActive(!flag);
		item2.SetUIActive(flag);
	}

	// Token: 0x0600AF18 RID: 44824 RVA: 0x003396D0 File Offset: 0x003378D0
	private void RefreshCanFinishItem(GachaAccumulateRewardItemData data)
	{
		bool flag = data.Data.Status == EGachaAccumulateRewardStatus.Claimed || data.Data.Status == EGachaAccumulateRewardStatus.CanClaim;
		base.GetItem(3).SetUIActive(false);
		base.GetItem(4).SetUIActive(false);
		base.GetItem(1).SetUIActive(false);
		base.GetItem(2).SetUIActive(false);
		if (data.IfSpecial)
		{
			base.GetItem(flag ? 3 : 4).SetUIActive(true);
			return;
		}
		base.GetItem(flag ? 1 : 2).SetUIActive(true);
	}

	// Token: 0x0600AF19 RID: 44825 RVA: 0x00339760 File Offset: 0x00337960
	private void RefreshFinishItem(GachaAccumulateRewardItemData data)
	{
		bool uiactive = data.Data.Status == EGachaAccumulateRewardStatus.Claimed;
		base.GetItem(14).SetUIActive(false);
		base.GetItem(13).SetUIActive(false);
		if (data.IfSpecial)
		{
			base.GetItem(14).SetUIActive(uiactive);
			return;
		}
		base.GetItem(13).SetUIActive(uiactive);
	}

	// Token: 0x0600AF1A RID: 44826 RVA: 0x003397BD File Offset: 0x003379BD
	private void RefreshSelectTag(GachaAccumulateRewardItemData data)
	{
		base.GetItem(9).SetUIActive(data.IfSpecial);
	}

	// Token: 0x0600AF1B RID: 44827 RVA: 0x003397D2 File Offset: 0x003379D2
	private void RefreshRedDot(GachaAccumulateRewardItemData data)
	{
		base.GetItem(10).SetUIActive(data.Data.Status == EGachaAccumulateRewardStatus.CanClaim);
	}

	// Token: 0x04006511 RID: 25873
	[Nullable(2)]
	private GachaAccumulateRewardItemData Data;

	// Token: 0x04006512 RID: 25874
	[Nullable(2)]
	private CommonItemSmallItemGrid CommonItemGrid;
}
