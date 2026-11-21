using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Infrastructure
{
	// Token: 0x020048FC RID: 18684
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class InfrastructureShopItem : GridProxyAbstract<PayShopGoods>
	{
		// Token: 0x17005EAD RID: 24237
		// (get) Token: 0x0602EE85 RID: 192133 RVA: 0x00D16BE5 File Offset: 0x00D14DE5
		private PayShopItemBaseSt ItemBaseSt
		{
			get
			{
				PayShopGoods data = this.Data;
				if (data == null)
				{
					return null;
				}
				return data.ConvertToPayShopBaseSt();
			}
		}

		// Token: 0x0602EE86 RID: 192134 RVA: 0x00D16BF8 File Offset: 0x00D14DF8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 12;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickShopItem));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602EE87 RID: 192135 RVA: 0x00D16DEC File Offset: 0x00D14FEC
		public override void Refresh(PayShopGoods data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			this.RefreshTexture();
			this.RefreshQualityTexture();
			this.RefreshShopItemName();
			this.RefreshPrice();
			this.RefreshWarnState();
		}

		// Token: 0x0602EE88 RID: 192136 RVA: 0x00D16E14 File Offset: 0x00D15014
		private void RefreshTexture()
		{
			PayShopItemBaseSt payShopItemBaseSt = this.Data.ConvertToPayShopBaseSt();
			UUITexture texture = base.GetTexture(1);
			if (payShopItemBaseSt.IfRechargeItem)
			{
				base.SetTextureByPath(payShopItemBaseSt.StageImage, texture, null, null);
				return;
			}
			if (!string.IsNullOrEmpty(payShopItemBaseSt.ShowStageImage))
			{
				base.SetTextureByPath(payShopItemBaseSt.ShowStageImage, texture, null, null);
				return;
			}
			base.SetItemIcon(texture, payShopItemBaseSt.ItemId, null, null);
		}

		// Token: 0x0602EE89 RID: 192137 RVA: 0x00D16E94 File Offset: 0x00D15094
		private void RefreshQualityTexture()
		{
			string itemQualityColor = InfrastructureConfig.Instance.GetItemQualityColor(this.ItemBaseSt.Quality);
			UUISprite sprite = base.GetSprite(2);
			if (sprite == null)
			{
				return;
			}
			sprite.SetColor(FColor.FromHex(itemQualityColor));
		}

		// Token: 0x0602EE8A RID: 192138 RVA: 0x00D16ECE File Offset: 0x00D150CE
		private void RefreshShopItemName()
		{
			base.GetText(4).SetText(this.ItemBaseSt.ItemName, true);
		}

		// Token: 0x0602EE8B RID: 192139 RVA: 0x00D16EE8 File Offset: 0x00D150E8
		private void RefreshPrice()
		{
			UUITexture texture = base.GetTexture(5);
			if (this.ItemBaseSt.IsDirect)
			{
				texture.SetUIActive(false);
				return;
			}
			IPriceData priceData = this.ItemBaseSt.PriceData;
			if (priceData.NowPrice == 0)
			{
				texture.SetUIActive(false);
				return;
			}
			texture.SetUIActive(true);
			base.SetItemIcon(texture, priceData.CurrencyId, null, null);
			UUIText text = base.GetText(6);
			text.SetText(priceData.NowPrice.ToString(), true);
			int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(80700004, 0);
			UUIItem uuiitem = text;
			bool bUseChangeColor = itemCountByConfigId < priceData.NowPrice;
			FColor? fcolor = new FColor?(text.changeColor);
			uuiitem.SetChangeColor(bUseChangeColor, fcolor);
		}

		// Token: 0x0602EE8C RID: 192140 RVA: 0x00D16F9C File Offset: 0x00D1519C
		private void RefreshWarnState()
		{
			bool flag = !this.Data.IfCanBuy();
			UUIItem item = base.GetItem(7);
			if (item != null)
			{
				item.SetUIActive(flag);
			}
			UUIItem item2 = base.GetItem(9);
			if (item2 != null)
			{
				item2.SetUIActive(false);
			}
			if (flag)
			{
				UUIText text = base.GetText(8);
				if (text != null)
				{
					text.SetText(this.Data.GetConditionLimitText(), true);
				}
			}
			else if (this.Data.IsSoldOut())
			{
				UUIItem item3 = base.GetItem(9);
				if (item3 != null)
				{
					item3.SetUIActive(true);
				}
			}
			UUIText text2 = base.GetText(11);
			if (text2 == null)
			{
				return;
			}
			text2.SetText(this.Data.GetBuyLimitText(), true);
		}

		// Token: 0x0602EE8D RID: 192141 RVA: 0x00D17041 File Offset: 0x00D15241
		private void OnClickShopItem()
		{
			if (!this.Data.IfCanBuy())
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("JijianTask_Rewardsunlocked", Array.Empty<object>());
				return;
			}
			PayShopController.Instance.OpenBuyViewByGoodsId(this.Data, null);
		}

		// Token: 0x04018E16 RID: 101910
		private PayShopGoods Data;

		// Token: 0x0200A5D0 RID: 42448
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x040334F9 RID: 210169
			public const int ShopItem = 0;

			// Token: 0x040334FA RID: 210170
			public const int TextureBigIcon = 1;

			// Token: 0x040334FB RID: 210171
			public const int SpriteQualityLight = 2;

			// Token: 0x040334FC RID: 210172
			public const int PanelItemDescription = 3;

			// Token: 0x040334FD RID: 210173
			public const int TextItemName = 4;

			// Token: 0x040334FE RID: 210174
			public const int TextureCostIcon = 5;

			// Token: 0x040334FF RID: 210175
			public const int TextCostNum = 6;

			// Token: 0x04033500 RID: 210176
			public const int PanelWarning = 7;

			// Token: 0x04033501 RID: 210177
			public const int TextWarning = 8;

			// Token: 0x04033502 RID: 210178
			public const int PanelOut = 9;

			// Token: 0x04033503 RID: 210179
			public const int TextOut = 10;

			// Token: 0x04033504 RID: 210180
			public const int TextTime = 11;
		}
	}
}
