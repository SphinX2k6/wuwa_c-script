using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x0200578D RID: 22413
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlExchangeShopItem : UiPanelBase
	{
		// Token: 0x06037504 RID: 226564 RVA: 0x00F72D54 File Offset: 0x00F70F54
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
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06037505 RID: 226565 RVA: 0x00F72F50 File Offset: 0x00F71150
		public void RefreshByData(DangoBrawlExchangeShopItemProxy data)
		{
			this.ItemProxy = data;
			this.RefreshQualityTexture();
			this.RefreshItemCost();
			this.RefreshItemIcon();
			this.RefreshItemName();
			this.RefreshLockState();
			this.RefreshSoldOutState();
			this.RefreshPurchaseLimit();
			this.RefreshDiscount();
			this.RefreshNewFlag();
			this.RefreshRaycastTarget();
		}

		// Token: 0x06037506 RID: 226566 RVA: 0x00F72FA0 File Offset: 0x00F711A0
		private void RefreshQualityTexture()
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

		// Token: 0x06037507 RID: 226567 RVA: 0x00F72FF4 File Offset: 0x00F711F4
		private void RefreshItemCost()
		{
			UUITexture texture = base.GetTexture(4);
			UUIText text = base.GetText(5);
			UUIItem text2 = base.GetText(6);
			texture.SetUIActive(false);
			text.SetUIActive(false);
			text2.SetUIActive(false);
		}

		// Token: 0x06037508 RID: 226568 RVA: 0x00F7302C File Offset: 0x00F7122C
		private void RefreshItemIcon()
		{
			if (this.ItemProxy == null)
			{
				return;
			}
			UUITexture texture = base.GetTexture(1);
			DangoBrawlExchangeShopItemProxy itemProxy = this.ItemProxy;
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

		// Token: 0x06037509 RID: 226569 RVA: 0x00F7309D File Offset: 0x00F7129D
		private void RefreshItemName()
		{
			if (this.ItemProxy == null)
			{
				return;
			}
			GameplayShopUtil.SetText(base.GetText(3), this.ItemProxy.ItemNameTextData);
		}

		// Token: 0x0603750A RID: 226570 RVA: 0x00F730C0 File Offset: 0x00F712C0
		private void RefreshSoldOutState()
		{
			if (this.ItemProxy == null)
			{
				return;
			}
			UUIItem item = base.GetItem(9);
			DangoBrawlExchangeShopItemProxy itemProxy = this.ItemProxy;
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

		// Token: 0x0603750B RID: 226571 RVA: 0x00F7311C File Offset: 0x00F7131C
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

		// Token: 0x0603750C RID: 226572 RVA: 0x00F73158 File Offset: 0x00F71358
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

		// Token: 0x0603750D RID: 226573 RVA: 0x00F731C0 File Offset: 0x00F713C0
		private void RefreshLockState()
		{
			base.GetItem(10).SetUIActive(false);
		}

		// Token: 0x0603750E RID: 226574 RVA: 0x00F731D0 File Offset: 0x00F713D0
		private void RefreshPurchaseLimit()
		{
			base.GetText(2).SetUIActive(false);
		}

		// Token: 0x0603750F RID: 226575 RVA: 0x00F731E0 File Offset: 0x00F713E0
		private void RefreshDiscount()
		{
			if (this.ItemProxy == null)
			{
				return;
			}
			UUIItem item = base.GetItem(8);
			UUIText text = base.GetText(7);
			DangoBrawlExchangeShopItemProxy itemProxy = this.ItemProxy;
			item.SetUIActive(itemProxy.DiscountItemVisible);
			text.SetUIActive(itemProxy.DiscountItemVisible);
			if (itemProxy.DiscountItemVisible && itemProxy.DiscountTextData != null)
			{
				GameplayShopUtil.SetText(text, itemProxy.DiscountTextData);
			}
		}

		// Token: 0x06037510 RID: 226576 RVA: 0x00F73244 File Offset: 0x00F71444
		private void RefreshNewFlag()
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

		// Token: 0x06037511 RID: 226577 RVA: 0x00F732B4 File Offset: 0x00F714B4
		private void RefreshRaycastTarget()
		{
			DangoBrawlExchangeShopItemProxy itemProxy = this.ItemProxy;
			bool raycastTarget = itemProxy != null && itemProxy.RaycastTarget;
			UUIItem rootItem = this.RootItem;
			if (rootItem != null)
			{
				rootItem.SetRaycastTarget(raycastTarget);
			}
			UUIItem item = base.GetItem(13);
			if (item == null)
			{
				return;
			}
			item.SetRaycastTarget(raycastTarget);
		}

		// Token: 0x0401D387 RID: 119687
		[Nullable(2)]
		private DangoBrawlExchangeShopItemProxy ItemProxy;

		// Token: 0x0200B3CE RID: 46030
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x04037994 RID: 227732
			TexQuality,
			// Token: 0x04037995 RID: 227733
			TexItemIcon,
			// Token: 0x04037996 RID: 227734
			TxtLimitBuyNum,
			// Token: 0x04037997 RID: 227735
			TxtItemName,
			// Token: 0x04037998 RID: 227736
			TexPriceIcon,
			// Token: 0x04037999 RID: 227737
			TxtPrice,
			// Token: 0x0403799A RID: 227738
			TxtOriginPrice,
			// Token: 0x0403799B RID: 227739
			TxtDiscount,
			// Token: 0x0403799C RID: 227740
			DiscountItem,
			// Token: 0x0403799D RID: 227741
			SellOutItem,
			// Token: 0x0403799E RID: 227742
			LockItem,
			// Token: 0x0403799F RID: 227743
			TxtLockItem,
			// Token: 0x040379A0 RID: 227744
			NewFlagItem,
			// Token: 0x040379A1 RID: 227745
			SelfItem
		}
	}
}
