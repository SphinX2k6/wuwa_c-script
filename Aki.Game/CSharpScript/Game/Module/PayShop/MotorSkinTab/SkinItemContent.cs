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
	// Token: 0x0200433C RID: 17212
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class SkinItemContent : GridProxyAbstract<SkinItemContentData>
	{
		// Token: 0x0602B779 RID: 178041 RVA: 0x00C37560 File Offset: 0x00C35760
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

		// Token: 0x0602B77A RID: 178042 RVA: 0x00C37730 File Offset: 0x00C35930
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

		// Token: 0x0602B77B RID: 178043 RVA: 0x00C37794 File Offset: 0x00C35994
		private RewardItemGrid OnCreateRewardItem()
		{
			return new RewardItemGrid();
		}

		// Token: 0x0602B77C RID: 178044 RVA: 0x00C3779C File Offset: 0x00C3599C
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

		// Token: 0x0602B77D RID: 178045 RVA: 0x00C37824 File Offset: 0x00C35A24
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

		// Token: 0x0602B77E RID: 178046 RVA: 0x00C3798C File Offset: 0x00C35B8C
		private void RefreshName(MotorSkinShow config)
		{
			UUIText text = base.GetText(7);
			if (text == null)
			{
				return;
			}
			text.ShowTextNew(config.Name);
		}

		// Token: 0x0602B77F RID: 178047 RVA: 0x00C379A8 File Offset: 0x00C35BA8
		private void RefreshIcon(MotorSkinShow config)
		{
			base.SetTextureByPath(config.Icon, base.GetTexture(3), null, null);
		}

		// Token: 0x0602B780 RID: 178048 RVA: 0x00C379D4 File Offset: 0x00C35BD4
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

		// Token: 0x0602B781 RID: 178049 RVA: 0x00C37AB0 File Offset: 0x00C35CB0
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

		// Token: 0x0602B782 RID: 178050 RVA: 0x00C37B10 File Offset: 0x00C35D10
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

		// Token: 0x0602B783 RID: 178051 RVA: 0x00C37BC4 File Offset: 0x00C35DC4
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

		// Token: 0x0602B784 RID: 178052 RVA: 0x00C37C10 File Offset: 0x00C35E10
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

		// Token: 0x0602B785 RID: 178053 RVA: 0x00C37C3C File Offset: 0x00C35E3C
		private void RefreshRedDotState(ShopMotorSkinData data)
		{
			bool ifNeedRemind = data.GetCurrentGoodsData().GetIfNeedRemind();
			base.GetItem(16).SetUIActive(ifNeedRemind);
		}

		// Token: 0x040177DD RID: 96221
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RewardItemGrid, IRewardItemGridData> RewardLayout;

		// Token: 0x040177DE RID: 96222
		[Nullable(2)]
		private SkinItemContentData CurrentShopMotorSkinData;

		// Token: 0x040177DF RID: 96223
		[Nullable(2)]
		private TotalTopUpPayAdditiveTagItem TotalTopUpTagItem;

		// Token: 0x040177E0 RID: 96224
		private int CurrentIndex;

		// Token: 0x040177E1 RID: 96225
		private int? CacheTotalTopUpData;

		// Token: 0x02009FFB RID: 40955
		[NullableContext(0)]
		private enum EShopMotorItemComponents
		{
			// Token: 0x04031B38 RID: 203576
			BtnClick,
			// Token: 0x04031B39 RID: 203577
			TexQualityBgA,
			// Token: 0x04031B3A RID: 203578
			TexIconType,
			// Token: 0x04031B3B RID: 203579
			TexIcon,
			// Token: 0x04031B3C RID: 203580
			TexQualityBgB,
			// Token: 0x04031B3D RID: 203581
			SpriteModelCol01,
			// Token: 0x04031B3E RID: 203582
			SpriteModelCol02,
			// Token: 0x04031B3F RID: 203583
			TxtName,
			// Token: 0x04031B40 RID: 203584
			PanelRewardList,
			// Token: 0x04031B41 RID: 203585
			BtnReward01,
			// Token: 0x04031B42 RID: 203586
			TexQualityBar,
			// Token: 0x04031B43 RID: 203587
			TxtPrice,
			// Token: 0x04031B44 RID: 203588
			PanelDiscountTime,
			// Token: 0x04031B45 RID: 203589
			TxtTime,
			// Token: 0x04031B46 RID: 203590
			TxtLimit,
			// Token: 0x04031B47 RID: 203591
			PanelGot,
			// Token: 0x04031B48 RID: 203592
			PanelRedDot,
			// Token: 0x04031B49 RID: 203593
			PanelTag
		}
	}
}
