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
	// Token: 0x0200683D RID: 26685
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlExchangeShopItem : UiPanelBase
	{
		// Token: 0x060429B0 RID: 272816 RVA: 0x01031848 File Offset: 0x0102FA48
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

		// Token: 0x060429B1 RID: 272817 RVA: 0x01031A44 File Offset: 0x0102FC44
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

		// Token: 0x060429B2 RID: 272818 RVA: 0x01031A94 File Offset: 0x0102FC94
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

		// Token: 0x060429B3 RID: 272819 RVA: 0x01031AE8 File Offset: 0x0102FCE8
		private void RefreshItemCost()
		{
			UUITexture texture = base.GetTexture(4);
			UUIText text = base.GetText(5);
			UUIItem text2 = base.GetText(6);
			texture.SetUIActive(false);
			text.SetUIActive(false);
			text2.SetUIActive(false);
		}

		// Token: 0x060429B4 RID: 272820 RVA: 0x01031B20 File Offset: 0x0102FD20
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

		// Token: 0x060429B5 RID: 272821 RVA: 0x01031B91 File Offset: 0x0102FD91
		private void RefreshItemName()
		{
			if (this.ItemProxy == null)
			{
				return;
			}
			GameplayShopUtil.SetText(base.GetText(3), this.ItemProxy.ItemNameTextData);
		}

		// Token: 0x060429B6 RID: 272822 RVA: 0x01031BB4 File Offset: 0x0102FDB4
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

		// Token: 0x060429B7 RID: 272823 RVA: 0x01031C10 File Offset: 0x0102FE10
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

		// Token: 0x060429B8 RID: 272824 RVA: 0x01031C4C File Offset: 0x0102FE4C
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

		// Token: 0x060429B9 RID: 272825 RVA: 0x01031CB4 File Offset: 0x0102FEB4
		private void RefreshLockState()
		{
			base.GetItem(10).SetUIActive(false);
		}

		// Token: 0x060429BA RID: 272826 RVA: 0x01031CC4 File Offset: 0x0102FEC4
		private void RefreshPurchaseLimit()
		{
			base.GetText(2).SetUIActive(false);
		}

		// Token: 0x060429BB RID: 272827 RVA: 0x01031CD4 File Offset: 0x0102FED4
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

		// Token: 0x060429BC RID: 272828 RVA: 0x01031D38 File Offset: 0x0102FF38
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

		// Token: 0x060429BD RID: 272829 RVA: 0x01031DA8 File Offset: 0x0102FFA8
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

		// Token: 0x04022B2A RID: 142122
		[Nullable(2)]
		private DangoBrawlExchangeShopItemProxy ItemProxy;

		// Token: 0x0200CA02 RID: 51714
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x0403D0AB RID: 250027
			TexQuality,
			// Token: 0x0403D0AC RID: 250028
			TexItemIcon,
			// Token: 0x0403D0AD RID: 250029
			TxtLimitBuyNum,
			// Token: 0x0403D0AE RID: 250030
			TxtItemName,
			// Token: 0x0403D0AF RID: 250031
			TexPriceIcon,
			// Token: 0x0403D0B0 RID: 250032
			TxtPrice,
			// Token: 0x0403D0B1 RID: 250033
			TxtOriginPrice,
			// Token: 0x0403D0B2 RID: 250034
			TxtDiscount,
			// Token: 0x0403D0B3 RID: 250035
			DiscountItem,
			// Token: 0x0403D0B4 RID: 250036
			SellOutItem,
			// Token: 0x0403D0B5 RID: 250037
			LockItem,
			// Token: 0x0403D0B6 RID: 250038
			TxtLockItem,
			// Token: 0x0403D0B7 RID: 250039
			NewFlagItem,
			// Token: 0x0403D0B8 RID: 250040
			SelfItem
		}
	}
}
