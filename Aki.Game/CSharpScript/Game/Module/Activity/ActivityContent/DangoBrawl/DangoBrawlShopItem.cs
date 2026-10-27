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
	// Token: 0x02006841 RID: 26689
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DangoBrawlShopItem : GridProxyAbstract<DangoBrawlShopItemProxy>
	{
		// Token: 0x060429CE RID: 272846 RVA: 0x010321E0 File Offset: 0x010303E0
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

		// Token: 0x060429CF RID: 272847 RVA: 0x0103241C File Offset: 0x0103061C
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

		// Token: 0x060429D0 RID: 272848 RVA: 0x0103246C File Offset: 0x0103066C
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

		// Token: 0x060429D1 RID: 272849 RVA: 0x010324BF File Offset: 0x010306BF
		public void RefreshItemCost()
		{
			if (this.ItemProxy == null)
			{
				return;
			}
			base.GetTexture(4).SetUIActive(this.ItemProxy.PriceItemVisible);
			base.GetText(5).SetUIActive(this.ItemProxy.PriceItemVisible);
		}

		// Token: 0x060429D2 RID: 272850 RVA: 0x010324F8 File Offset: 0x010306F8
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

		// Token: 0x060429D3 RID: 272851 RVA: 0x01032569 File Offset: 0x01030769
		public void RefreshItemName()
		{
			if (this.ItemProxy == null)
			{
				return;
			}
			GameplayShopUtil.SetText(base.GetText(3), this.ItemProxy.ItemNameTextData);
		}

		// Token: 0x060429D4 RID: 272852 RVA: 0x0103258C File Offset: 0x0103078C
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

		// Token: 0x060429D5 RID: 272853 RVA: 0x01032638 File Offset: 0x01030838
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

		// Token: 0x060429D6 RID: 272854 RVA: 0x01032694 File Offset: 0x01030894
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

		// Token: 0x060429D7 RID: 272855 RVA: 0x010326D0 File Offset: 0x010308D0
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

		// Token: 0x060429D8 RID: 272856 RVA: 0x01032738 File Offset: 0x01030938
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

		// Token: 0x060429D9 RID: 272857 RVA: 0x0103278C File Offset: 0x0103098C
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

		// Token: 0x060429DA RID: 272858 RVA: 0x010327E4 File Offset: 0x010309E4
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

		// Token: 0x060429DB RID: 272859 RVA: 0x01032848 File Offset: 0x01030A48
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

		// Token: 0x060429DC RID: 272860 RVA: 0x010328B8 File Offset: 0x01030AB8
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

		// Token: 0x04022B2F RID: 142127
		[Nullable(2)]
		private DangoBrawlShopItemProxy ItemProxy;

		// Token: 0x0200CA03 RID: 51715
		[NullableContext(0)]
		private enum EShopItemComponent
		{
			// Token: 0x0403D0BA RID: 250042
			TexItemQuality,
			// Token: 0x0403D0BB RID: 250043
			TexItemIcon,
			// Token: 0x0403D0BC RID: 250044
			TxtLimitBuyNum,
			// Token: 0x0403D0BD RID: 250045
			TxtName,
			// Token: 0x0403D0BE RID: 250046
			TexCostItemIcon,
			// Token: 0x0403D0BF RID: 250047
			TxtCostPrice,
			// Token: 0x0403D0C0 RID: 250048
			TxtOriginalPrice,
			// Token: 0x0403D0C1 RID: 250049
			TxtDiscount,
			// Token: 0x0403D0C2 RID: 250050
			DiscountItem,
			// Token: 0x0403D0C3 RID: 250051
			SellOutItem,
			// Token: 0x0403D0C4 RID: 250052
			LockItem,
			// Token: 0x0403D0C5 RID: 250053
			TxtLockItem,
			// Token: 0x0403D0C6 RID: 250054
			NewFlagItem,
			// Token: 0x0403D0C7 RID: 250055
			BtnBuy
		}
	}
}
