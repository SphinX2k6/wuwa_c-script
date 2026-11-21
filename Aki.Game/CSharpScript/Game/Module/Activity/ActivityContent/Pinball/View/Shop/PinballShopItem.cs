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
	// Token: 0x02005269 RID: 21097
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballShopItem : UiPanelBase
	{
		// Token: 0x06034847 RID: 215111 RVA: 0x00EB1A74 File Offset: 0x00EAFC74
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

		// Token: 0x06034848 RID: 215112 RVA: 0x00EB1CAC File Offset: 0x00EAFEAC
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

		// Token: 0x06034849 RID: 215113 RVA: 0x00EB1D24 File Offset: 0x00EAFF24
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

		// Token: 0x0603484A RID: 215114 RVA: 0x00EB1D6F File Offset: 0x00EAFF6F
		protected override void OnBeforeDestroy()
		{
			this.PendingBaseProxy = null;
			this.IsItemBaseReady = false;
		}

		// Token: 0x0603484B RID: 215115 RVA: 0x00EB1D80 File Offset: 0x00EAFF80
		private void OnPointerEnterItem(EToggleState state)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(1);
			if (extendToggle != null)
			{
				extendToggle.SetToggleState(EToggleState.ETT_Checked, false, false, false);
			}
		}

		// Token: 0x0603484C RID: 215116 RVA: 0x00EB1DA4 File Offset: 0x00EAFFA4
		private void OnPointerExitItem(EToggleState state)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(1);
			if (extendToggle != null)
			{
				extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			}
		}

		// Token: 0x0603484D RID: 215117 RVA: 0x00EB1DC8 File Offset: 0x00EAFFC8
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

		// Token: 0x0603484E RID: 215118 RVA: 0x00EB1E6E File Offset: 0x00EB006E
		public void RefreshByData(PinballExchangeShopItemProxy data)
		{
			this.RefreshByDataInternal(data);
		}

		// Token: 0x0603484F RID: 215119 RVA: 0x00EB1E77 File Offset: 0x00EB0077
		public void RefreshByData(PinballShopItemProxy data)
		{
			this.RefreshByDataInternal(data);
		}

		// Token: 0x06034850 RID: 215120 RVA: 0x00EB1E80 File Offset: 0x00EB0080
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

		// Token: 0x06034851 RID: 215121 RVA: 0x00EB1EE0 File Offset: 0x00EB00E0
		private void TryRefreshItemBase()
		{
			if (!this.IsItemBaseReady || this.ItemBase == null || this.PendingBaseProxy == null)
			{
				return;
			}
			this.ItemBase.RefreshByShopData(this.PendingBaseProxy);
		}

		// Token: 0x06034852 RID: 215122 RVA: 0x00EB1F0C File Offset: 0x00EB010C
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

		// Token: 0x06034853 RID: 215123 RVA: 0x00EB1FA8 File Offset: 0x00EB01A8
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

		// Token: 0x06034854 RID: 215124 RVA: 0x00EB2049 File Offset: 0x00EB0249
		public void RefreshItemCost()
		{
			if (this.ItemProxy == null)
			{
				return;
			}
			base.GetItem(2).SetUIActive(true);
		}

		// Token: 0x06034855 RID: 215125 RVA: 0x00EB2064 File Offset: 0x00EB0264
		public void HideItemCost()
		{
			UUIItem item = base.GetItem(2);
			if (item != null)
			{
				item.SetUIActive(false);
			}
		}

		// Token: 0x06034856 RID: 215126 RVA: 0x00EB2084 File Offset: 0x00EB0284
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

		// Token: 0x06034857 RID: 215127 RVA: 0x00EB20B8 File Offset: 0x00EB02B8
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

		// Token: 0x06034858 RID: 215128 RVA: 0x00EB2100 File Offset: 0x00EB0300
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

		// Token: 0x06034859 RID: 215129 RVA: 0x00EB21A0 File Offset: 0x00EB03A0
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

		// Token: 0x0603485A RID: 215130 RVA: 0x00EB21F8 File Offset: 0x00EB03F8
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

		// Token: 0x0603485B RID: 215131 RVA: 0x00EB2234 File Offset: 0x00EB0434
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

		// Token: 0x0603485C RID: 215132 RVA: 0x00EB229C File Offset: 0x00EB049C
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

		// Token: 0x0603485D RID: 215133 RVA: 0x00EB22F0 File Offset: 0x00EB04F0
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

		// Token: 0x0603485E RID: 215134 RVA: 0x00EB2348 File Offset: 0x00EB0548
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

		// Token: 0x0603485F RID: 215135 RVA: 0x00EB23AC File Offset: 0x00EB05AC
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

		// Token: 0x0401BDA9 RID: 114089
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

		// Token: 0x0401BDAA RID: 114090
		[Nullable(2)]
		protected CommonGameplayShopItemProxy ItemProxy;

		// Token: 0x0401BDAB RID: 114091
		[Nullable(2)]
		protected PinballItemView ItemBase;

		// Token: 0x0401BDAC RID: 114092
		[Nullable(2)]
		private CommonGameplayShopItemProxy PendingBaseProxy;

		// Token: 0x0401BDAD RID: 114093
		private bool IsItemBaseReady;

		// Token: 0x0200AEC3 RID: 44739
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x04035FE4 RID: 221156
			public const int QualitySprite = 0;

			// Token: 0x04035FE5 RID: 221157
			public const int ItemBase = 1;

			// Token: 0x04035FE6 RID: 221158
			public const int ItemCost = 2;

			// Token: 0x04035FE7 RID: 221159
			public const int TexIcon = 3;

			// Token: 0x04035FE8 RID: 221160
			public const int TxtPrice = 4;

			// Token: 0x04035FE9 RID: 221161
			public const int TxtOriginalPrice = 5;

			// Token: 0x04035FEA RID: 221162
			public const int ItemSoldOut = 6;

			// Token: 0x04035FEB RID: 221163
			public const int ItemSoldLock = 7;

			// Token: 0x04035FEC RID: 221164
			public const int TxtTips = 8;

			// Token: 0x04035FED RID: 221165
			public const int ItemPurchaseLimit = 9;

			// Token: 0x04035FEE RID: 221166
			public const int TextNum = 10;

			// Token: 0x04035FEF RID: 221167
			public const int Discount = 11;

			// Token: 0x04035FF0 RID: 221168
			public const int TextDiscount = 12;

			// Token: 0x04035FF1 RID: 221169
			public const int SpriteUtility = 13;
		}
	}
}
