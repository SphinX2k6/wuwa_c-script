using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001B91 RID: 7057
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class FloroRanchGoodsItem : GridProxyAbstract<FloroRanchShopItemDataBase>
{
	// Token: 0x0600D21E RID: 53790 RVA: 0x00303384 File Offset: 0x00301584
	protected unsafe override void OnRegisterComponent()
	{
		int num = 13;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickGoodsItem));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600D21F RID: 53791 RVA: 0x0030359C File Offset: 0x0030179C
	public override void Refresh(FloroRanchShopItemDataBase data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		base.SetTextureByPath(this.Data.GetIcon(), base.GetTexture(2), null, null);
		FloroRanchRarityData qualityData = this.Data.GetQualityData();
		this.SetSpriteByPath(qualityData.GetRarityShopItemBg(), base.GetSprite(3), true, null, null);
		UUIItem item = base.GetItem(11);
		if (item != null)
		{
			item.SetUIActive(this.Data.GetIsSpecialPhantom());
		}
		FloroRanchCurrencyData diamondData = FloroRanchGamePlayModel.Instance.DiamondData;
		base.SetTextureByPath(diamondData.ConfigData.GetSmallIcon(), base.GetTexture(4), null, null);
		int price = this.Data.Price;
		bool flag = diamondData.GetAmount() >= (long)price;
		UUIText text = base.GetText(5);
		text.SetText(price.ToString(), true);
		UUIItem uuiitem = text;
		bool bUseChangeColor = !flag;
		FColor? fcolor = new FColor?(text.changeColor);
		uuiitem.SetChangeColor(bUseChangeColor, fcolor);
		UUIText text2 = base.GetText(6);
		if (text2 != null)
		{
			text2.SetUIActive(false);
		}
		UUIItem item2 = base.GetItem(7);
		if (item2 != null)
		{
			item2.SetUIActive(false);
		}
		UUIItem item3 = base.GetItem(9);
		if (item3 != null)
		{
			item3.SetUIActive(false);
		}
		if (data.Type == FloroRanchShopItemType.ShopToy)
		{
			FloroRanchRaceData toyRaceData = data.GetToyRaceData();
			if (toyRaceData != null)
			{
				base.SetTextureByPath(toyRaceData.SmallIcon, base.GetTexture(10), null, null);
				UUIItem item4 = base.GetItem(9);
				if (item4 != null)
				{
					item4.SetUIActive(true);
				}
			}
		}
		UUIItem item5 = base.GetItem(8);
		if (item5 != null)
		{
			item5.SetUIActive(this.Data.IsSold);
		}
		global::FloroRanchActivityData currentActivityData = FloroRanchGamePlayModel.Instance.GetCurrentActivityData();
		if (currentActivityData == null)
		{
			return;
		}
		int subInstanceId = FloroRanchGamePlayModel.Instance.SubInstanceId;
		EFloroRanchCardType? efloroRanchCardType = null;
		if (data.Type == FloroRanchShopItemType.ShopToy)
		{
			efloroRanchCardType = new EFloroRanchCardType?(EFloroRanchCardType.Toy);
		}
		else if (data.Type == FloroRanchShopItemType.Card)
		{
			efloroRanchCardType = new EFloroRanchCardType?(EFloroRanchCardType.Phantom);
		}
		bool flag2 = efloroRanchCardType != null && currentActivityData.IsSubDungeonRecommendItem(subInstanceId, data.Id, efloroRanchCardType.Value);
		UUISprite sprite = base.GetSprite(12);
		if (!flag2)
		{
			if (sprite != null)
			{
				sprite.SetUIActive(false);
				return;
			}
		}
		else if (sprite != null)
		{
			sprite.SetUIActive(true);
		}
	}

	// Token: 0x0600D220 RID: 53792 RVA: 0x003037C6 File Offset: 0x003019C6
	public void BindClickCallback(Action<FloroRanchShopItemDataBase> callback)
	{
		this.ClickCallback = callback;
	}

	// Token: 0x0600D221 RID: 53793 RVA: 0x003037CF File Offset: 0x003019CF
	private void OnClickGoodsItem(EToggleState toggleState)
	{
		Action<FloroRanchShopItemDataBase> clickCallback = this.ClickCallback;
		if (clickCallback == null)
		{
			return;
		}
		clickCallback(this.Data);
	}

	// Token: 0x0600D222 RID: 53794 RVA: 0x003037E7 File Offset: 0x003019E7
	public void SetSelectState(bool isSelect)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleState(isSelect ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x0400604C RID: 24652
	public FloroRanchShopItemDataBase Data;

	// Token: 0x0400604D RID: 24653
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<FloroRanchShopItemDataBase> ClickCallback;

	// Token: 0x02008118 RID: 33048
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x0402A229 RID: 172585
		public const int Toggle = 0;

		// Token: 0x0402A22A RID: 172586
		public const int GoodsItem = 1;

		// Token: 0x0402A22B RID: 172587
		public const int GoodsIconTexture = 2;

		// Token: 0x0402A22C RID: 172588
		public const int GoodsQualitySprite = 3;

		// Token: 0x0402A22D RID: 172589
		public const int PriceIconTexture = 4;

		// Token: 0x0402A22E RID: 172590
		public const int CurPrice = 5;

		// Token: 0x0402A22F RID: 172591
		public const int OldPrice = 6;

		// Token: 0x0402A230 RID: 172592
		public const int RedDot = 7;

		// Token: 0x0402A231 RID: 172593
		public const int SoldMask = 8;

		// Token: 0x0402A232 RID: 172594
		public const int ToyRaceItem = 9;

		// Token: 0x0402A233 RID: 172595
		public const int ToyRaceIcon = 10;

		// Token: 0x0402A234 RID: 172596
		public const int ItemPhantomIcon = 11;

		// Token: 0x0402A235 RID: 172597
		public const int RecommendSprite = 12;
	}
}
