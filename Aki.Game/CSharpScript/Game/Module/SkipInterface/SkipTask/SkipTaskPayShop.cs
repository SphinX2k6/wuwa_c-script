using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.SkipInterface.SkipTask
{
	// Token: 0x02004BB1 RID: 19377
	public class SkipTaskPayShop : SkipTask
	{
		// Token: 0x060322F0 RID: 205552 RVA: 0x00BA926C File Offset: 0x00BA746C
		protected override void OnRun([Nullable(new byte[]
		{
			1,
			2
		})] params object[] data)
		{
			string text = (string)data[0];
			string text2 = (string)data[1];
			string goodIdString = (data.Length > 2) ? ((string)data[2]) : null;
			base.Finish();
			if (UiManager.Instance.IsViewShow(EUiViewName.PayShopRootView))
			{
				GenericPromptController.Instance.ShowPromptByCode("IsInView", Array.Empty<object>());
				return;
			}
			PayShopViewData payShopViewData = new PayShopViewData();
			payShopViewData.PayShopId = PayShopDefine.EPayShopTabType.ExchangeEntry;
			PayShopController.Instance.OpenPayShopView(payShopViewData, delegate(bool success, int viewId)
			{
				if (success)
				{
					if (!UiManager.Instance.IsViewOpen(EUiViewName.PayShopRootView))
					{
						this.Finish();
						return;
					}
					if (StringUtils.IsEmpty(goodIdString) || (goodIdString != null && int.Parse(goodIdString) == 0))
					{
						ItemTipsData currentItemTipsData = ItemTipsModel.Instance.GetCurrentItemTipsData();
						if (currentItemTipsData == null)
						{
							this.Finish();
							return;
						}
						PayShopGoods goodsInTab = PayShopModel.Instance.GetGoodsInTab(PayShopDefine.EPayShopTabType.ExchangeEntry, currentItemTipsData.ConfigId);
						if (goodsInTab == null)
						{
							ScrollingTipsController.Instance.ShowTipsByText(ConfigMultiTextLang.GetLocalTextNew("Shop_UnableBuy_Desc01", null));
							this.Finish();
							return;
						}
						PayShopController.Instance.OpenExchangePopView(goodsInTab.GetGoodsId(), null);
						return;
					}
					else
					{
						PayShopController.Instance.OpenExchangePopView(int.Parse(goodIdString), null);
					}
				}
			});
		}
	}
}
