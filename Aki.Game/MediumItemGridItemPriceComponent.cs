using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x02000DD3 RID: 3539
public class MediumItemGridItemPriceComponent : MediumItemGridComponent
{
	// Token: 0x06009023 RID: 36899 RVA: 0x002B4AA5 File Offset: 0x002B2CA5
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemDiscount";
	}

	// Token: 0x06009024 RID: 36900 RVA: 0x002B4AAC File Offset: 0x002B2CAC
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

	// Token: 0x06009025 RID: 36901 RVA: 0x002B4B18 File Offset: 0x002B2D18
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

	// Token: 0x06009026 RID: 36902 RVA: 0x002B4B64 File Offset: 0x002B2D64
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

	// Token: 0x06009027 RID: 36903 RVA: 0x002B4C0C File Offset: 0x002B2E0C
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

	// Token: 0x02007011 RID: 28689
	private class EComponents
	{
		// Token: 0x04024983 RID: 149891
		public const int TexIcon = 0;

		// Token: 0x04024984 RID: 149892
		public const int TxtPrice = 1;
	}
}
