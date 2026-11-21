using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02005791 RID: 22417
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DangoBrawlShopItem : GridProxyAbstract<DangoBrawlShopItemProxy>
	{
		// Token: 0x06037522 RID: 226594 RVA: 0x00F736EC File Offset: 0x00F718EC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 14;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(13, new Action(this.OnBtnBuyClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06037523 RID: 226595 RVA: 0x00F73928 File Offset: 0x00F71B28
		public override void Refresh(DangoBrawlShopItemProxy data, bool isSelected, int gridIndex)
		{
			this.ItemProxy = data;
			this.RefreshQualityTexture();
			this.RefreshItemCost();
			this.RefreshItemIcon();
			this.RefreshItemName();
			this.RefreshPriceInfo();
			this.RefreshLockState();
			this.RefreshSoldOutState();
			this.RefreshPurchaseLimit();
			this.RefreshDiscount();
			this.RefreshNewFlag();
		}

		// Token: 0x06037524 RID: 226596 RVA: 0x00F73978 File Offset: 0x00F71B78
		public void RefreshQualityTexture()
		{
			if (this.ItemProxy == null)
			{
				return;
			}
			UUITexture texture = base.GetTexture(0);
			string qualityTexturePath = this.ItemProxy.QualityTexturePath;
			if (string.IsNullOrEmpty(qualityTexturePath))
			{
				texture.SetUIActive(false);
				return;
			}
			texture.SetUIActive(true);
			base.SetTextureByPath(qualityTexturePath, texture, null, null);
		}

		// Token: 0x06037525 RID: 226597 RVA: 0x00F739CB File Offset: 0x00F71BCB
		public void RefreshItemCost()
		{
			if (this.ItemProxy == null)
			{
				return;
			}
			base.GetTexture(4).SetUIActive(this.ItemProxy.PriceItemVisible);
			base.GetText(5).SetUIActive(this.ItemProxy.PriceItemVisible);
		}

		// Token: 0x06037526 RID: 226598 RVA: 0x00F73A04 File Offset: 0x00F71C04
		public void RefreshItemIcon()
		{
			if (this.ItemProxy == null)
			{
				return;
			}
			UUITexture texture = base.GetTexture(1);
			DangoBrawlShopItemProxy itemProxy = this.ItemProxy;
			texture.SetUIActive(itemProxy.ItemTextureVisible);
			if (itemProxy.ItemTextureVisible)
			{
				if (itemProxy.ItemId > 0)
				{
					base.SetItemIcon(texture, itemProxy.ItemId, null, null);
					return;
				}
				base.SetTextureByPath(itemProxy.ItemTexturePath, texture, null, null);
			}
		}

		// Token: 0x06037527 RID: 226599 RVA: 0x00F73A75 File Offset: 0x00F71C75
		public void RefreshItemName()
		{
			if (this.ItemProxy == null)
			{
				return;
			}
			GameplayShopUtil.SetText(base.GetText(3), this.ItemProxy.ItemNameTextData);
		}

		// Token: 0x06037528 RID: 226600 RVA: 0x00F73A98 File Offset: 0x00F71C98
		public void RefreshPriceInfo()
		{
			if (this.ItemProxy == null)
			{
				return;
			}
			DangoBrawlShopItemProxy itemProxy = this.ItemProxy;
			UUIText text = base.GetText(5);
			GameplayShopUtil.SetText(text, itemProxy.NowPriceTextData);
			text.SetColor(FColor.FromHex(itemProxy.NowPriceTextColor));
			UUITexture texture = base.GetTexture(4);
			texture.SetUIActive(itemProxy.CurrencyIconVisible);
			if (itemProxy.CurrencyIconVisible && itemProxy.CurrencyId > 0)
			{
				base.SetItemIcon(texture, itemProxy.CurrencyId, null, null);
			}
			UUIText text2 = base.GetText(6);
			text2.SetUIActive(itemProxy.OriginalPriceVisible);
			if (itemProxy.OriginalPriceVisible && itemProxy.OriginalPriceTextData != null)
			{
				GameplayShopUtil.SetText(text2, itemProxy.OriginalPriceTextData);
			}
		}

		// Token: 0x06037529 RID: 226601 RVA: 0x00F73B44 File Offset: 0x00F71D44
		public void RefreshSoldOutState()
		{
			if (this.ItemProxy == null)
			{
				return;
			}
			UUIItem item = base.GetItem(9);
			DangoBrawlShopItemProxy itemProxy = this.ItemProxy;
			item.SetUIActive(itemProxy.SoldOutItemVisible);
			if (itemProxy.SoldOutItemVisible && itemProxy.SoldOutTextData != null)
			{
				UUIText soldOutLabelText = this.GetSoldOutLabelText(item);
				if (soldOutLabelText != null)
				{
					GameplayShopUtil.SetText(soldOutLabelText, itemProxy.SoldOutTextData);
				}
			}
		}

		// Token: 0x0603752A RID: 226602 RVA: 0x00F73BA0 File Offset: 0x00F71DA0
		[return: Nullable(2)]
		private UUIText GetSoldOutLabelText(UUIItem soldOutPanel)
		{
			AActor owner = soldOutPanel.GetOwner();
			if (owner != null)
			{
				UUIText uuitext = owner.GetComponentByClass(UUIText.StaticClass()) as UUIText;
				if (uuitext != null)
				{
					return uuitext;
				}
			}
			return this.FindTextInChildren(soldOutPanel);
		}

		// Token: 0x0603752B RID: 226603 RVA: 0x00F73BDC File Offset: 0x00F71DDC
		[return: Nullable(2)]
		private UUIText FindTextInChildren(UUIItem ui)
		{
			int num = ui.GetAttachUIChildren().Num();
			for (int i = 0; i < num; i++)
			{
				UUIItem attachUIChild = ui.GetAttachUIChild(i);
				if (attachUIChild != null)
				{
					AActor owner = attachUIChild.GetOwner();
					UUIText uuitext = ((owner != null) ? owner.GetComponentByClass(UUIText.StaticClass()) : null) as UUIText;
					if (uuitext != null)
					{
						return uuitext;
					}
					UUIText uuitext2 = this.FindTextInChildren(attachUIChild);
					if (uuitext2 != null)
					{
						return uuitext2;
					}
				}
			}
			return null;
		}

		// Token: 0x0603752C RID: 226604 RVA: 0x00F73C44 File Offset: 0x00F71E44
		public void RefreshLockState()
		{
			if (this.ItemProxy == null)
			{
				return;
			}
			UUIItem item = base.GetItem(10);
			DangoBrawlShopItemProxy itemProxy = this.ItemProxy;
			item.SetUIActive(itemProxy.LockItemVisible);
			if (itemProxy.LockItemVisible && itemProxy.LockTextData != null)
			{
				GameplayShopUtil.SetText(base.GetText(11), itemProxy.LockTextData);
			}
		}

		// Token: 0x0603752D RID: 226605 RVA: 0x00F73C98 File Offset: 0x00F71E98
		public void RefreshPurchaseLimit()
		{
			if (this.ItemProxy == null)
			{
				return;
			}
			UUIText text = base.GetText(2);
			DangoBrawlShopItemProxy itemProxy = this.ItemProxy;
			text.SetUIActive(itemProxy.BuyLimitCountTextVisible);
			if (itemProxy.BuyLimitCountTextVisible)
			{
				text.SetRichText(true);
				text.SetAlpha(itemProxy.LimitCountAlpha);
				GameplayShopUtil.SetText(text, itemProxy.BuyLimitCountTextData);
			}
		}

		// Token: 0x0603752E RID: 226606 RVA: 0x00F73CF0 File Offset: 0x00F71EF0
		public void RefreshDiscount()
		{
			if (this.ItemProxy == null)
			{
				return;
			}
			UUIItem item = base.GetItem(8);
			UUIText text = base.GetText(7);
			DangoBrawlShopItemProxy itemProxy = this.ItemProxy;
			item.SetUIActive(itemProxy.DiscountItemVisible);
			text.SetUIActive(itemProxy.DiscountItemVisible);
			if (itemProxy.DiscountItemVisible && itemProxy.DiscountTextData != null)
			{
				GameplayShopUtil.SetText(text, itemProxy.DiscountTextData);
			}
		}

		// Token: 0x0603752F RID: 226607 RVA: 0x00F73D54 File Offset: 0x00F71F54
		public void RefreshNewFlag()
		{
			UUIItem item = base.GetItem(12);
			if (this.ItemProxy == null || this.ItemProxy.LockItemVisible)
			{
				item.SetUIActive(false);
				return;
			}
			PayShopGoods goodsData = this.ItemProxy.GoodsData;
			int num = (goodsData != null) ? goodsData.GetGoodsId() : 0;
			if (num <= 0)
			{
				item.SetUIActive(false);
				return;
			}
			bool flag = NewFlagModel.Instance.HasNewFlag(ELocalStoragePlayerKey.PayShopTabItemChecked, num);
			item.SetUIActive(!flag);
		}

		// Token: 0x06037530 RID: 226608 RVA: 0x00F73DC4 File Offset: 0x00F71FC4
		private void OnBtnBuyClick()
		{
			DangoBrawlShopItemProxy itemProxy = this.ItemProxy;
			if (itemProxy == null || !itemProxy.RaycastTarget)
			{
				return;
			}
			PayShopGoods goodsData = this.ItemProxy.GoodsData;
			int num = (goodsData != null) ? goodsData.GetGoodsId() : 0;
			bool flag = NewFlagModel.Instance.HasNewFlag(ELocalStoragePlayerKey.PayShopTabItemChecked, num);
			if (num > 0 && !flag)
			{
				NewFlagModel.Instance.AddNewFlag(ELocalStoragePlayerKey.PayShopTabItemChecked, num);
				NewFlagModel.Instance.SaveNewFlagConfig(ELocalStoragePlayerKey.PayShopTabItemChecked);
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.ItemProxy.ActivityId);
				this.RefreshNewFlag();
			}
			this.ItemProxy.OnBuyButtonClick();
		}

		// Token: 0x0401D38C RID: 119692
		[Nullable(2)]
		private DangoBrawlShopItemProxy ItemProxy;

		// Token: 0x0200B3CF RID: 46031
		[NullableContext(0)]
		private enum EShopItemComponent
		{
			// Token: 0x040379A3 RID: 227747
			TexItemQuality,
			// Token: 0x040379A4 RID: 227748
			TexItemIcon,
			// Token: 0x040379A5 RID: 227749
			TxtLimitBuyNum,
			// Token: 0x040379A6 RID: 227750
			TxtName,
			// Token: 0x040379A7 RID: 227751
			TexCostItemIcon,
			// Token: 0x040379A8 RID: 227752
			TxtCostPrice,
			// Token: 0x040379A9 RID: 227753
			TxtOriginalPrice,
			// Token: 0x040379AA RID: 227754
			TxtDiscount,
			// Token: 0x040379AB RID: 227755
			DiscountItem,
			// Token: 0x040379AC RID: 227756
			SellOutItem,
			// Token: 0x040379AD RID: 227757
			LockItem,
			// Token: 0x040379AE RID: 227758
			TxtLockItem,
			// Token: 0x040379AF RID: 227759
			NewFlagItem,
			// Token: 0x040379B0 RID: 227760
			BtnBuy
		}
	}
}
