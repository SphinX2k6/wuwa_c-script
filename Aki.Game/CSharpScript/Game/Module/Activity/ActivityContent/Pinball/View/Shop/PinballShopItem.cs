using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Item;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Shop
{
	// Token: 0x020062EB RID: 25323
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballShopItem : UiPanelBase
	{
		// Token: 0x0603FB86 RID: 260998 RVA: 0x00F6AB18 File Offset: 0x00F68D18
		protected unsafe override void OnRegisterComponent()
		{
			int num = 14;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action<EToggleState>(this.OnClickItemBase));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603FB87 RID: 260999 RVA: 0x00F6AD50 File Offset: 0x00F68F50
		protected override void OnStart()
		{
			this.ItemBase = new PinballItemView();
			UUIExtendToggle extendToggle = base.GetExtendToggle(1);
			if (extendToggle != null)
			{
				AActor owner = extendToggle.GetOwner();
				if (owner != null)
				{
					this.InitItemBaseAsync(owner).Forget();
				}
				extendToggle.bToggleOnSelect = false;
				extendToggle.bCheckToggleSelected = false;
				extendToggle.OnPointEnterCallBack.Bind(new Action<EToggleState>(this.OnPointerEnterItem));
				extendToggle.OnPointExitCallBack.Bind(new Action<EToggleState>(this.OnPointerExitItem));
			}
		}

		// Token: 0x0603FB88 RID: 261000 RVA: 0x00F6ADC8 File Offset: 0x00F68FC8
		private UniTask InitItemBaseAsync(AActor owner)
		{
			PinballShopItem.<InitItemBaseAsync>d__8 <InitItemBaseAsync>d__;
			<InitItemBaseAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitItemBaseAsync>d__.<>4__this = this;
			<InitItemBaseAsync>d__.owner = owner;
			<InitItemBaseAsync>d__.<>1__state = -1;
			<InitItemBaseAsync>d__.<>t__builder.Start<PinballShopItem.<InitItemBaseAsync>d__8>(ref <InitItemBaseAsync>d__);
			return <InitItemBaseAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603FB89 RID: 261001 RVA: 0x00F6AE13 File Offset: 0x00F69013
		protected override void OnBeforeDestroy()
		{
			this.PendingBaseProxy = null;
			this.IsItemBaseReady = false;
		}

		// Token: 0x0603FB8A RID: 261002 RVA: 0x00F6AE24 File Offset: 0x00F69024
		private void OnPointerEnterItem(EToggleState state)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(1);
			if (extendToggle != null)
			{
				extendToggle.SetToggleState(EToggleState.ETT_Checked, false, false, false);
			}
		}

		// Token: 0x0603FB8B RID: 261003 RVA: 0x00F6AE48 File Offset: 0x00F69048
		private void OnPointerExitItem(EToggleState state)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(1);
			if (extendToggle != null)
			{
				extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			}
		}

		// Token: 0x0603FB8C RID: 261004 RVA: 0x00F6AE6C File Offset: 0x00F6906C
		private void OnClickItemBase(EToggleState state)
		{
			CommonGameplayShopItemProxy itemProxy = this.ItemProxy;
			if (itemProxy == null || !itemProxy.RaycastTarget)
			{
				return;
			}
			PayShopGoods goodsData = this.ItemProxy.GoodsData;
			if (goodsData != null)
			{
				int goodsId = goodsData.GetGoodsId();
				if (goodsId > 0 && !NewFlagModel.Instance.HasNewFlag(ELocalStoragePlayerKey.PayShopTabItemChecked, goodsId))
				{
					NewFlagModel.Instance.AddNewFlag(ELocalStoragePlayerKey.PayShopTabItemChecked, goodsId);
					NewFlagModel.Instance.SaveNewFlagConfig(ELocalStoragePlayerKey.PayShopTabItemChecked);
					PinballActivityData activityData = PinballModel.Instance.ActivityData;
					int num = (activityData != null) ? activityData.Id : 0;
					if (num > 0)
					{
						EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, num);
					}
					this.TryRefreshItemBase();
				}
			}
			this.ItemProxy.OnBuyButtonClick();
		}

		// Token: 0x0603FB8D RID: 261005 RVA: 0x00F6AF12 File Offset: 0x00F69112
		public void RefreshByData(PinballExchangeShopItemProxy data)
		{
			this.RefreshByDataInternal(data);
		}

		// Token: 0x0603FB8E RID: 261006 RVA: 0x00F6AF1B File Offset: 0x00F6911B
		public void RefreshByData(PinballShopItemProxy data)
		{
			this.RefreshByDataInternal(data);
		}

		// Token: 0x0603FB8F RID: 261007 RVA: 0x00F6AF24 File Offset: 0x00F69124
		private void RefreshByDataInternal(CommonGameplayShopItemProxy data)
		{
			this.ItemProxy = data;
			if (data != null)
			{
				this.PendingBaseProxy = data;
				this.TryRefreshItemBase();
				this.RefreshQualitySprite();
				this.RefreshUtilityColor();
				this.RefreshItemCost();
				this.RefreshItemIcon();
				this.RefreshPriceInfo();
				this.RefreshTips();
				this.RefreshLockState();
				this.RefreshSoldOutState();
				this.RefreshPurchaseLimit();
				this.RefreshDiscount();
			}
		}

		// Token: 0x0603FB90 RID: 261008 RVA: 0x00F6AF84 File Offset: 0x00F69184
		private void TryRefreshItemBase()
		{
			if (!this.IsItemBaseReady || this.ItemBase == null || this.PendingBaseProxy == null)
			{
				return;
			}
			this.ItemBase.RefreshByShopData(this.PendingBaseProxy);
		}

		// Token: 0x0603FB91 RID: 261009 RVA: 0x00F6AFB0 File Offset: 0x00F691B0
		public void RefreshQualitySprite()
		{
			if (this.ItemProxy == null)
			{
				return;
			}
			UUISprite sprite = base.GetSprite(0);
			PayShopGoods goodsData = this.ItemProxy.GoodsData;
			int? num;
			if (goodsData == null)
			{
				num = null;
			}
			else
			{
				CSharpScript.Game.Module.PayShop.IItemData itemData = goodsData.GetItemData();
				num = ((itemData != null) ? new int?(itemData.Quality) : null);
			}
			int? num2 = num;
			if (num2 != null)
			{
				int? num3 = num2;
				int num4 = 0;
				if (!(num3.GetValueOrDefault() == num4 & num3 != null))
				{
					string hexStr;
					if (PinballShopItem.QualityUtilityColorMap.TryGetValue(num2.Value, out hexStr))
					{
						sprite.SetColor(FColor.FromHex(hexStr));
					}
					return;
				}
			}
		}

		// Token: 0x0603FB92 RID: 261010 RVA: 0x00F6B04C File Offset: 0x00F6924C
		public void RefreshUtilityColor()
		{
			if (this.ItemProxy == null)
			{
				return;
			}
			UUISprite sprite = base.GetSprite(13);
			if (sprite == null)
			{
				return;
			}
			PayShopGoods goodsData = this.ItemProxy.GoodsData;
			int? num;
			if (goodsData == null)
			{
				num = null;
			}
			else
			{
				CSharpScript.Game.Module.PayShop.IItemData itemData = goodsData.GetItemData();
				num = ((itemData != null) ? new int?(itemData.Quality) : null);
			}
			int? num2 = num;
			if (num2 != null)
			{
				int? num3 = num2;
				int num4 = 0;
				if (!(num3.GetValueOrDefault() == num4 & num3 != null))
				{
					string hexStr;
					if (PinballShopItem.QualityUtilityColorMap.TryGetValue(num2.Value, out hexStr))
					{
						sprite.SetColor(FColor.FromHex(hexStr));
					}
					return;
				}
			}
		}

		// Token: 0x0603FB93 RID: 261011 RVA: 0x00F6B0ED File Offset: 0x00F692ED
		public void RefreshItemCost()
		{
			if (this.ItemProxy == null)
			{
				return;
			}
			base.GetItem(2).SetUIActive(true);
		}

		// Token: 0x0603FB94 RID: 261012 RVA: 0x00F6B108 File Offset: 0x00F69308
		public void HideItemCost()
		{
			UUIItem item = base.GetItem(2);
			if (item != null)
			{
				item.SetUIActive(false);
			}
		}

		// Token: 0x0603FB95 RID: 261013 RVA: 0x00F6B128 File Offset: 0x00F69328
		public void SetItemFrameVisible(bool visible)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(1);
			if (extendToggle != null)
			{
				extendToggle.SetSelfInteractive(visible);
				if (!visible)
				{
					extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
					extendToggle.SetSelectionState(EUISelectableSelectionState.Normal);
				}
			}
		}

		// Token: 0x0603FB96 RID: 261014 RVA: 0x00F6B15C File Offset: 0x00F6935C
		public void RefreshItemIcon()
		{
			if (this.ItemProxy == null)
			{
				return;
			}
			UUITexture texture = base.GetTexture(3);
			CommonGameplayShopItemProxy itemProxy = this.ItemProxy;
			if (itemProxy.CurrencyId > 0)
			{
				base.SetItemIcon(texture, itemProxy.CurrencyId, null, null);
			}
		}

		// Token: 0x0603FB97 RID: 261015 RVA: 0x00F6B1A4 File Offset: 0x00F693A4
		public void RefreshPriceInfo()
		{
			if (this.ItemProxy == null)
			{
				return;
			}
			CommonGameplayShopItemProxy itemProxy = this.ItemProxy;
			UUIText text = base.GetText(4);
			GameplayShopUtil.SetText(text, itemProxy.NowPriceTextData);
			PayShopGoods goodsData = itemProxy.GoodsData;
			IPriceData priceData = (goodsData != null) ? goodsData.GetPriceData() : null;
			bool flag = priceData != null && priceData.OwnNumber() < priceData.NowPrice;
			FColor changeColor = text.changeColor;
			bool bUseChangeColor = flag;
			FColor? fcolor = new FColor?(changeColor);
			text.SetChangeColor(bUseChangeColor, fcolor);
			UUIText text2 = base.GetText(5);
			if (itemProxy.OriginalPriceTextData != null)
			{
				GameplayShopUtil.SetText(text2, itemProxy.OriginalPriceTextData);
				text2.SetUIActive(itemProxy.OriginalPriceVisible);
			}
		}

		// Token: 0x0603FB98 RID: 261016 RVA: 0x00F6B244 File Offset: 0x00F69444
		public void RefreshSoldOutState()
		{
			if (this.ItemProxy == null)
			{
				return;
			}
			UUIItem item = base.GetItem(6);
			CommonGameplayShopItemProxy itemProxy = this.ItemProxy;
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

		// Token: 0x0603FB99 RID: 261017 RVA: 0x00F6B29C File Offset: 0x00F6949C
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

		// Token: 0x0603FB9A RID: 261018 RVA: 0x00F6B2D8 File Offset: 0x00F694D8
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

		// Token: 0x0603FB9B RID: 261019 RVA: 0x00F6B340 File Offset: 0x00F69540
		public void RefreshLockState()
		{
			if (this.ItemProxy == null)
			{
				return;
			}
			UUIItem item = base.GetItem(7);
			CommonGameplayShopItemProxy itemProxy = this.ItemProxy;
			item.SetUIActive(itemProxy.LockItemVisible);
			if (itemProxy.LockItemVisible && itemProxy.LockTextData != null)
			{
				GameplayShopUtil.SetText(base.GetText(8), itemProxy.LockTextData);
			}
		}

		// Token: 0x0603FB9C RID: 261020 RVA: 0x00F6B394 File Offset: 0x00F69594
		public void RefreshTips()
		{
			if (this.ItemProxy == null)
			{
				return;
			}
			UUIText text = base.GetText(8);
			CommonGameplayShopItemProxy itemProxy = this.ItemProxy;
			if (itemProxy.SoldOutItemVisible || itemProxy.LockItemVisible)
			{
				return;
			}
			text.SetUIActive(itemProxy.PriceTipsTextVisible);
			if (itemProxy.PriceTipsTextVisible)
			{
				GameplayShopUtil.SetText(text, itemProxy.PriceTipsTextData);
			}
		}

		// Token: 0x0603FB9D RID: 261021 RVA: 0x00F6B3EC File Offset: 0x00F695EC
		public void RefreshPurchaseLimit()
		{
			if (this.ItemProxy == null)
			{
				return;
			}
			UUIItem item = base.GetItem(9);
			UUIText text = base.GetText(10);
			CommonGameplayShopItemProxy itemProxy = this.ItemProxy;
			item.SetUIActive(itemProxy.BuyLimitCountTextVisible);
			text.SetUIActive(itemProxy.BuyLimitCountTextVisible);
			if (itemProxy.BuyLimitCountTextVisible && itemProxy.BuyLimitCountTextData != null)
			{
				GameplayShopUtil.SetText(text, itemProxy.BuyLimitCountTextData);
			}
		}

		// Token: 0x0603FB9E RID: 261022 RVA: 0x00F6B450 File Offset: 0x00F69650
		public void RefreshDiscount()
		{
			if (this.ItemProxy == null)
			{
				return;
			}
			UUIItem item = base.GetItem(11);
			UUIText text = base.GetText(12);
			CommonGameplayShopItemProxy itemProxy = this.ItemProxy;
			item.SetUIActive(itemProxy.DiscountItemVisible);
			text.SetUIActive(itemProxy.DiscountItemVisible);
			if (itemProxy.DiscountItemVisible && itemProxy.DiscountTextData != null)
			{
				GameplayShopUtil.SetText(text, itemProxy.DiscountTextData);
			}
		}

		// Token: 0x0402147A RID: 136314
		[StaticVariableRuleIgnore]
		private static readonly Dictionary<int, string> QualityUtilityColorMap = new Dictionary<int, string>
		{
			{
				1,
				"76A291FF"
			},
			{
				2,
				"729FCAFF"
			},
			{
				3,
				"946EBAFF"
			},
			{
				4,
				"D6AD49FF"
			},
			{
				5,
				"CB5877FF"
			}
		};

		// Token: 0x0402147B RID: 136315
		[Nullable(2)]
		protected CommonGameplayShopItemProxy ItemProxy;

		// Token: 0x0402147C RID: 136316
		[Nullable(2)]
		protected PinballItemView ItemBase;

		// Token: 0x0402147D RID: 136317
		[Nullable(2)]
		private CommonGameplayShopItemProxy PendingBaseProxy;

		// Token: 0x0402147E RID: 136318
		private bool IsItemBaseReady;

		// Token: 0x0200C4DC RID: 50396
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x0403B682 RID: 243330
			public const int QualitySprite = 0;

			// Token: 0x0403B683 RID: 243331
			public const int ItemBase = 1;

			// Token: 0x0403B684 RID: 243332
			public const int ItemCost = 2;

			// Token: 0x0403B685 RID: 243333
			public const int TexIcon = 3;

			// Token: 0x0403B686 RID: 243334
			public const int TxtPrice = 4;

			// Token: 0x0403B687 RID: 243335
			public const int TxtOriginalPrice = 5;

			// Token: 0x0403B688 RID: 243336
			public const int ItemSoldOut = 6;

			// Token: 0x0403B689 RID: 243337
			public const int ItemSoldLock = 7;

			// Token: 0x0403B68A RID: 243338
			public const int TxtTips = 8;

			// Token: 0x0403B68B RID: 243339
			public const int ItemPurchaseLimit = 9;

			// Token: 0x0403B68C RID: 243340
			public const int TextNum = 10;

			// Token: 0x0403B68D RID: 243341
			public const int Discount = 11;

			// Token: 0x0403B68E RID: 243342
			public const int TextDiscount = 12;

			// Token: 0x0403B68F RID: 243343
			public const int SpriteUtility = 13;
		}
	}
}
