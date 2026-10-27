using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common;
using CSharpScript.Game.Module.PayShop;

// Token: 0x02001F01 RID: 7937
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryShopGridItem : ActivityGrid
{
	// Token: 0x0600F464 RID: 62564 RVA: 0x003AF4FA File Offset: 0x003AD6FA
	protected override void OnStart()
	{
		base.OnStart();
		base.SetExtraFunction(new Action<PayShopItem, PayShopGoods>(this.ClearNewFlagState));
		base.SetRedDotState(false);
	}

	// Token: 0x0600F465 RID: 62565 RVA: 0x003AF51C File Offset: 0x003AD71C
	public override void Refresh(IPayShopUnionData data, bool isSelected, int gridIndex)
	{
		PayShopGoods payShopGoods = data as PayShopGoods;
		if (payShopGoods == null)
		{
			return;
		}
		base.Refresh(data, isSelected, gridIndex);
		PayShopGoods payShopGoods2 = payShopGoods;
		bool redDotState = !NewFlagModel.Instance.HasNewFlag(ELocalStoragePlayerKey.PayShopTabItemChecked, payShopGoods2.GetGoodsId());
		base.SetRedDotState(redDotState);
		PayShopExchangeExtraData payShopExchangeExtraData = new PayShopExchangeExtraData();
		int itemId = payShopGoods2.GetGoodsData().ItemId;
		if (HonamiStoryUtil.CheckIsPluginBoxItem(itemId))
		{
			HonamiStoryPluginBoxItem? pluginBoxConfig = HonamiStoryConfig.Instance.GetHonamiStoryPluginBoxItemById(itemId);
			payShopExchangeExtraData.GetMaxBuyCount = (() => pluginBoxConfig.Value.BuyLimit);
		}
		payShopExchangeExtraData.CheckIfCanBuy = delegate()
		{
			if (HonamiStoryModel.Instance.GetBackPackData(1, false).GetOverflowCapacity() > 0)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("HonamiStory_WarehouseFullShop", Array.Empty<object>());
				return false;
			}
			return true;
		};
		base.SetExchangeExtraData(payShopExchangeExtraData);
	}

	// Token: 0x0600F466 RID: 62566 RVA: 0x003AF5D1 File Offset: 0x003AD7D1
	private void ClearNewFlagState(PayShopItem item, PayShopGoods data)
	{
		base.SetRedDotState(false);
		NewFlagModel.Instance.AddNewFlag(ELocalStoragePlayerKey.PayShopTabItemChecked, data.GetGoodsId());
		NewFlagModel.Instance.SaveNewFlagConfig(ELocalStoragePlayerKey.PayShopTabItemChecked);
	}
}
