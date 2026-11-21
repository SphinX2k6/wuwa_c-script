using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common;
using CSharpScript.Game.Module.PayShop;

// Token: 0x020013C3 RID: 5059
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryShopGridItem : ActivityGrid
{
	// Token: 0x0600C883 RID: 51331 RVA: 0x003BAFEE File Offset: 0x003B91EE
	protected override void OnStart()
	{
		base.OnStart();
		base.SetExtraFunction(new Action<PayShopItem, PayShopGoods>(this.ClearNewFlagState));
		base.SetRedDotState(false);
	}

	// Token: 0x0600C884 RID: 51332 RVA: 0x003BB010 File Offset: 0x003B9210
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

	// Token: 0x0600C885 RID: 51333 RVA: 0x003BB0C5 File Offset: 0x003B92C5
	private void ClearNewFlagState(PayShopItem item, PayShopGoods data)
	{
		base.SetRedDotState(false);
		NewFlagModel.Instance.AddNewFlag(ELocalStoragePlayerKey.PayShopTabItemChecked, data.GetGoodsId());
		NewFlagModel.Instance.SaveNewFlagConfig(ELocalStoragePlayerKey.PayShopTabItemChecked);
	}
}
