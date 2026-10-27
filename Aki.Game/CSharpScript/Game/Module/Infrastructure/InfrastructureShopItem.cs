using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Infrastructure
{
	// Token: 0x02005923 RID: 22819
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class InfrastructureShopItem : GridProxyAbstract<PayShopGoods>
	{
		// Token: 0x17008AE1 RID: 35553
		// (get) Token: 0x06039F62 RID: 237410 RVA: 0x00DC78BD File Offset: 0x00DC5ABD
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

		// Token: 0x06039F63 RID: 237411 RVA: 0x00DC78D0 File Offset: 0x00DC5AD0
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

		// Token: 0x06039F64 RID: 237412 RVA: 0x00DC7AC4 File Offset: 0x00DC5CC4
		public override void Refresh(PayShopGoods data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			this.RefreshTexture();
			this.RefreshQualityTexture();
			this.RefreshShopItemName();
			this.RefreshPrice();
			this.RefreshWarnState();
		}

		// Token: 0x06039F65 RID: 237413 RVA: 0x00DC7AEC File Offset: 0x00DC5CEC
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

		// Token: 0x06039F66 RID: 237414 RVA: 0x00DC7B6C File Offset: 0x00DC5D6C
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

		// Token: 0x06039F67 RID: 237415 RVA: 0x00DC7BA6 File Offset: 0x00DC5DA6
		private void RefreshShopItemName()
		{
			base.GetText(4).SetText(this.ItemBaseSt.ItemName, true);
		}

		// Token: 0x06039F68 RID: 237416 RVA: 0x00DC7BC0 File Offset: 0x00DC5DC0
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

		// Token: 0x06039F69 RID: 237417 RVA: 0x00DC7C74 File Offset: 0x00DC5E74
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

		// Token: 0x06039F6A RID: 237418 RVA: 0x00DC7D19 File Offset: 0x00DC5F19
		private void OnClickShopItem()
		{
			if (!this.Data.IfCanBuy())
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("JijianTask_Rewardsunlocked", Array.Empty<object>());
				return;
			}
			PayShopController.Instance.OpenBuyViewByGoodsId(this.Data, null);
		}

		// Token: 0x0401E379 RID: 123769
		private PayShopGoods Data;

		// Token: 0x0200BBC1 RID: 48065
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x04038B17 RID: 232215
			public const int ShopItem = 0;

			// Token: 0x04038B18 RID: 232216
			public const int TextureBigIcon = 1;

			// Token: 0x04038B19 RID: 232217
			public const int SpriteQualityLight = 2;

			// Token: 0x04038B1A RID: 232218
			public const int PanelItemDescription = 3;

			// Token: 0x04038B1B RID: 232219
			public const int TextItemName = 4;

			// Token: 0x04038B1C RID: 232220
			public const int TextureCostIcon = 5;

			// Token: 0x04038B1D RID: 232221
			public const int TextCostNum = 6;

			// Token: 0x04038B1E RID: 232222
			public const int PanelWarning = 7;

			// Token: 0x04038B1F RID: 232223
			public const int TextWarning = 8;

			// Token: 0x04038B20 RID: 232224
			public const int PanelOut = 9;

			// Token: 0x04038B21 RID: 232225
			public const int TextOut = 10;

			// Token: 0x04038B22 RID: 232226
			public const int TextTime = 11;
		}
	}
}
