using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp;
using CSharpScript.Game.Module.Skin;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.PayShop.MotorSkinTab
{
	// Token: 0x02005359 RID: 21337
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class SkinItemContent : GridProxyAbstract<SkinItemContentData>
	{
		// Token: 0x06036833 RID: 223283 RVA: 0x00CE86D8 File Offset: 0x00CE68D8
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUITexture)),
				new ValueTuple<int, Type>(2, typeof(UUITexture)),
				new ValueTuple<int, Type>(3, typeof(UUITexture)),
				new ValueTuple<int, Type>(4, typeof(UUITexture)),
				new ValueTuple<int, Type>(5, typeof(UUISprite)),
				new ValueTuple<int, Type>(6, typeof(UUISprite)),
				new ValueTuple<int, Type>(7, typeof(UUIText)),
				new ValueTuple<int, Type>(8, typeof(UUIHorizontalLayout)),
				new ValueTuple<int, Type>(9, typeof(UUIItem)),
				new ValueTuple<int, Type>(10, typeof(UUITexture)),
				new ValueTuple<int, Type>(11, typeof(UUIText)),
				new ValueTuple<int, Type>(12, typeof(UUIItem)),
				new ValueTuple<int, Type>(13, typeof(UUIText)),
				new ValueTuple<int, Type>(14, typeof(UUIText)),
				new ValueTuple<int, Type>(15, typeof(UUIItem)),
				new ValueTuple<int, Type>(16, typeof(UUIItem)),
				new ValueTuple<int, Type>(17, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action(this.OnClickBuyButton))
			};
		}

		// Token: 0x06036834 RID: 223284 RVA: 0x00CE88A8 File Offset: 0x00CE6AA8
		protected override void OnStart()
		{
			this.RewardLayout = new GenericLayout<RewardItemGrid, IRewardItemGridData>(base.GetHorizontalLayout(8), new Func<RewardItemGrid>(this.OnCreateRewardItem), null, false, true);
			this.TotalTopUpTagItem = new TotalTopUpPayAdditiveTagItem();
			this.TotalTopUpTagItem.CreateByResourceIdAsync("UiItem_CumulativeRechargeScoreTag", base.GetItem(17), false).ContinueWith(delegate()
			{
				if (this.CacheTotalTopUpData != null)
				{
					TotalTopUpPayAdditiveTagItem totalTopUpTagItem = this.TotalTopUpTagItem;
					if (totalTopUpTagItem == null)
					{
						return;
					}
					totalTopUpTagItem.RefreshByGoodsId(this.CacheTotalTopUpData.Value);
				}
			});
		}

		// Token: 0x06036835 RID: 223285 RVA: 0x00CE890C File Offset: 0x00CE6B0C
		private RewardItemGrid OnCreateRewardItem()
		{
			return new RewardItemGrid();
		}

		// Token: 0x06036836 RID: 223286 RVA: 0x00CE8914 File Offset: 0x00CE6B14
		private void OnClickBuyButton()
		{
			if (this.CurrentShopMotorSkinData == null)
			{
				return;
			}
			List<ShopMotorSkinData> list = new List<ShopMotorSkinData>();
			int count = this.CurrentShopMotorSkinData.AllData.Count;
			for (int i = 0; i < count; i++)
			{
				ShopMotorSkinData item = ShopMotorSkinData.Create(this.CurrentShopMotorSkinData.AllData[i]);
				list.Add(item);
			}
			MotorSkinBuyDetailViewData motorSkinBuyDetailViewData = MotorSkinBuyDetailViewData.Create(list);
			motorSkinBuyDetailViewData.SetIndex(this.CurrentIndex);
			motorSkinBuyDetailViewData.SetPreviewTitle("MotorSkinShopTitle_Text");
			UiManager.Instance.OpenView(EUiViewName.MotorSkinBuyDetailView, motorSkinBuyDetailViewData, null);
		}

		// Token: 0x06036837 RID: 223287 RVA: 0x00CE899C File Offset: 0x00CE6B9C
		public override void Refresh(SkinItemContentData data, bool isSelected, int gridIndex)
		{
			ShopMotorSkinData shopMotorSkinData = data.ShopMotorSkinData;
			this.CurrentShopMotorSkinData = data;
			this.CurrentIndex = gridIndex;
			if (shopMotorSkinData == null)
			{
				return;
			}
			MotorSkinData motorSkinData = shopMotorSkinData.GetMotorSkinData();
			MotorSkinShow? motorSkinShow = (motorSkinData != null) ? motorSkinData.GetMotorSkinShow() : null;
			if (motorSkinShow == null)
			{
				return;
			}
			this.RefreshName(motorSkinShow.Value);
			this.RefreshIcon(motorSkinShow.Value);
			this.RefreshQuality(motorSkinShow.Value);
			this.RefreshPrice(shopMotorSkinData);
			this.RefreshTime(shopMotorSkinData);
			this.RefreshLimit(shopMotorSkinData);
			this.RefreshGotState(shopMotorSkinData);
			this.RefreshRedDotState(shopMotorSkinData);
			PayShopGoods payShopGoods = shopMotorSkinData.GetPayShopGoods();
			this.CacheTotalTopUpData = new int?((payShopGoods != null) ? payShopGoods.GetGoodsId() : 0);
			if (this.TotalTopUpTagItem != null && !this.TotalTopUpTagItem.InAsyncLoading())
			{
				this.TotalTopUpTagItem.RefreshByGoodsId(this.CacheTotalTopUpData.Value);
			}
			List<IRewardItemGridData> list = new List<IRewardItemGridData>();
			foreach (KeyValuePair<string, int> keyValuePair in motorSkinShow.Value.ItemCount())
			{
				list.Add(new RewardItemGridData
				{
					IconPath = keyValuePair.Key,
					Count = keyValuePair.Value
				});
			}
			GenericLayout<RewardItemGrid, IRewardItemGridData> rewardLayout = this.RewardLayout;
			if (rewardLayout == null)
			{
				return;
			}
			rewardLayout.RefreshByData(list, null, false);
		}

		// Token: 0x06036838 RID: 223288 RVA: 0x00CE8B04 File Offset: 0x00CE6D04
		private void RefreshName(MotorSkinShow config)
		{
			UUIText text = base.GetText(7);
			if (text == null)
			{
				return;
			}
			text.ShowTextNew(config.Name);
		}

		// Token: 0x06036839 RID: 223289 RVA: 0x00CE8B20 File Offset: 0x00CE6D20
		private void RefreshIcon(MotorSkinShow config)
		{
			base.SetTextureByPath(config.Icon, base.GetTexture(3), null, null);
		}

		// Token: 0x0603683A RID: 223290 RVA: 0x00CE8B4C File Offset: 0x00CE6D4C
		private void RefreshQuality(MotorSkinShow config)
		{
			int qualityId = config.QualityId;
			MotorGiftQuality value = SkinConfig.Instance.GetMotorSkinGiftQualityConfig(qualityId).Value;
			base.SetTextureByPath(value.BgA, base.GetTexture(1), null, null);
			base.SetTextureByPath(value.BgBar, base.GetTexture(10), null, null);
			base.SetTextureByPath(value.BgType, base.GetTexture(2), null, null);
			base.SetTextureByPath(value.BgC, base.GetTexture(4), null, null);
			UUIItem sprite = base.GetSprite(5);
			bool bUseChangeColor = qualityId != 1;
			FColor? fcolor = null;
			sprite.SetChangeColor(bUseChangeColor, fcolor);
			UUIItem sprite2 = base.GetSprite(6);
			bool bUseChangeColor2 = qualityId != 1;
			fcolor = null;
			sprite2.SetChangeColor(bUseChangeColor2, fcolor);
		}

		// Token: 0x0603683B RID: 223291 RVA: 0x00CE8C28 File Offset: 0x00CE6E28
		private void RefreshPrice(ShopMotorSkinData data)
		{
			IPriceData priceData = data.GetPriceData();
			if (!data.GetCurrentGoodsData().IsDirect())
			{
				if (priceData != null)
				{
					UUIText text = base.GetText(11);
					if (text == null)
					{
						return;
					}
					text.SetText(priceData.NowPrice.ToString(), true);
				}
				return;
			}
			UUIText text2 = base.GetText(11);
			if (text2 == null)
			{
				return;
			}
			text2.SetText(data.GetDirectPriceText(), true);
		}

		// Token: 0x0603683C RID: 223292 RVA: 0x00CE8C88 File Offset: 0x00CE6E88
		private void RefreshTime(ShopMotorSkinData data)
		{
			if (data == null)
			{
				base.GetItem(13).SetUIActive(false);
				return;
			}
			ValueTuple<EPayCountTimeType, CommonDefine.IPayShowCountDownRemainTime, double> countDownData = data.GetCurrentGoodsData().GetCountDownData();
			CommonDefine.IPayShowCountDownRemainTime item = countDownData.Item2;
			if (countDownData.Item3 == 0.0)
			{
				base.GetItem(12).SetUIActive(false);
				return;
			}
			base.GetItem(12).SetUIActive(true);
			UUIText text = base.GetText(13);
			CommonDefine.PayShowCountDownRemainTime<string> payShowCountDownRemainTime = item as CommonDefine.PayShowCountDownRemainTime<string>;
			if (payShowCountDownRemainTime != null)
			{
				text.SetText(payShowCountDownRemainTime.Value, true);
				return;
			}
			CommonDefine.PayShowCountDownRemainTime<CommonDefine.IRemainTime> payShowCountDownRemainTime2 = item as CommonDefine.PayShowCountDownRemainTime<CommonDefine.IRemainTime>;
			if (payShowCountDownRemainTime2 != null)
			{
				LguiUtil.Instance.SetLocalText(text, payShowCountDownRemainTime2.Value.TextId, new <>z__ReadOnlySingleElementList<object>(payShowCountDownRemainTime2.Value.TimeValue));
			}
		}

		// Token: 0x0603683D RID: 223293 RVA: 0x00CE8D3C File Offset: 0x00CE6F3C
		private void RefreshLimit(ShopMotorSkinData data)
		{
			UUIText text = base.GetText(14);
			if (data.GetIfCanBuy())
			{
				string shopTipsText = data.GetCurrentGoodsData().GetShopTipsText();
				if (text != null)
				{
					text.SetText(shopTipsText, true);
				}
				if (text != null)
				{
					text.SetUIActive(true);
					return;
				}
			}
			else if (text != null)
			{
				text.SetUIActive(false);
			}
		}

		// Token: 0x0603683E RID: 223294 RVA: 0x00CE8D88 File Offset: 0x00CE6F88
		private void RefreshGotState(ShopMotorSkinData data)
		{
			bool uiactive = !data.GetIfCanBuy();
			UUIItem item = base.GetItem(15);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(uiactive);
		}

		// Token: 0x0603683F RID: 223295 RVA: 0x00CE8DB4 File Offset: 0x00CE6FB4
		private void RefreshRedDotState(ShopMotorSkinData data)
		{
			bool ifNeedRemind = data.GetCurrentGoodsData().GetIfNeedRemind();
			base.GetItem(16).SetUIActive(ifNeedRemind);
		}

		// Token: 0x0401CD49 RID: 118089
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RewardItemGrid, IRewardItemGridData> RewardLayout;

		// Token: 0x0401CD4A RID: 118090
		[Nullable(2)]
		private SkinItemContentData CurrentShopMotorSkinData;

		// Token: 0x0401CD4B RID: 118091
		[Nullable(2)]
		private TotalTopUpPayAdditiveTagItem TotalTopUpTagItem;

		// Token: 0x0401CD4C RID: 118092
		private int CurrentIndex;

		// Token: 0x0401CD4D RID: 118093
		private int? CacheTotalTopUpData;

		// Token: 0x0200B5C2 RID: 46530
		[NullableContext(0)]
		private enum EShopMotorItemComponents
		{
			// Token: 0x040370E0 RID: 225504
			BtnClick,
			// Token: 0x040370E1 RID: 225505
			TexQualityBgA,
			// Token: 0x040370E2 RID: 225506
			TexIconType,
			// Token: 0x040370E3 RID: 225507
			TexIcon,
			// Token: 0x040370E4 RID: 225508
			TexQualityBgB,
			// Token: 0x040370E5 RID: 225509
			SpriteModelCol01,
			// Token: 0x040370E6 RID: 225510
			SpriteModelCol02,
			// Token: 0x040370E7 RID: 225511
			TxtName,
			// Token: 0x040370E8 RID: 225512
			PanelRewardList,
			// Token: 0x040370E9 RID: 225513
			BtnReward01,
			// Token: 0x040370EA RID: 225514
			TexQualityBar,
			// Token: 0x040370EB RID: 225515
			TxtPrice,
			// Token: 0x040370EC RID: 225516
			PanelDiscountTime,
			// Token: 0x040370ED RID: 225517
			TxtTime,
			// Token: 0x040370EE RID: 225518
			TxtLimit,
			// Token: 0x040370EF RID: 225519
			PanelGot,
			// Token: 0x040370F0 RID: 225520
			PanelRedDot,
			// Token: 0x040370F1 RID: 225521
			PanelTag
		}
	}
}
