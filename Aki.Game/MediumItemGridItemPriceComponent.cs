using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x0200191A RID: 6426
public class MediumItemGridItemPriceComponent : MediumItemGridComponent
{
	// Token: 0x0600BC39 RID: 48185 RVA: 0x002AA349 File Offset: 0x002A8549
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemDiscount";
	}

	// Token: 0x0600BC3A RID: 48186 RVA: 0x002AA350 File Offset: 0x002A8550
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600BC3B RID: 48187 RVA: 0x002AA3BC File Offset: 0x002A85BC
	[NullableContext(2)]
	protected override void OnRefresh(object data)
	{
		IMediumItemPrice mediumItemPrice = data as IMediumItemPrice;
		if (mediumItemPrice == null)
		{
			this.SetActive(false);
			return;
		}
		this.SetPrice(mediumItemPrice.CurPrice, mediumItemPrice.OriginalPrice, mediumItemPrice.CurrencyNotEnough);
		this.SetTexture(mediumItemPrice.TexPath);
		this.SetActive(true);
	}

	// Token: 0x0600BC3C RID: 48188 RVA: 0x002AA408 File Offset: 0x002A8608
	public void SetPrice(int curPrice, int? originalPrice, bool? notEnough = null)
	{
		if (originalPrice != null)
		{
			int? num = originalPrice;
			if (!(curPrice == num.GetValueOrDefault() & num != null))
			{
				string textStringId = notEnough.GetValueOrDefault() ? "RogueInfoViewShopPriceWithDiscount_NE" : "RogueInfoViewShopPriceWithDiscount";
				LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textStringId, new <>z__ReadOnlyArray<object>(new object[]
				{
					curPrice,
					originalPrice
				}));
				return;
			}
		}
		string textStringId2 = notEnough.GetValueOrDefault() ? "RogueInfoViewShopPrice_NE" : "RogueInfoViewShopPrice";
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textStringId2, new <>z__ReadOnlySingleElementList<object>(curPrice));
	}

	// Token: 0x0600BC3D RID: 48189 RVA: 0x002AA4B0 File Offset: 0x002A86B0
	[NullableContext(2)]
	public void SetTexture(string path)
	{
		UUITexture texture = base.GetTexture(0);
		if (texture != null)
		{
			texture.SetUIActive(false);
		}
		if (!string.IsNullOrEmpty(path))
		{
			base.SetTextureShowUntilLoaded(path, texture, null);
		}
	}

	// Token: 0x02007E8A RID: 32394
	private class EComponents
	{
		// Token: 0x04029657 RID: 169559
		public const int TexIcon = 0;

		// Token: 0x04029658 RID: 169560
		public const int TxtPrice = 1;
	}
}
