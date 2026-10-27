using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.PayShop;

// Token: 0x020018DC RID: 6364
[NullableContext(1)]
[Nullable(0)]
public class TipsOverPowerData : ItemTipsData
{
	// Token: 0x0600BAA9 RID: 47785 RVA: 0x002A4B61 File Offset: 0x002A2D61
	public TipsOverPowerData(ItemTipsParam data) : base(data)
	{
		this.ItemType = EItemTipsType.OverPower;
	}

	// Token: 0x0600BAAA RID: 47786 RVA: 0x002A4B74 File Offset: 0x002A2D74
	public PayShopGoods ConvertToPayShopGoods()
	{
		PayShopGoodsData payShopGoodsData = new PayShopGoodsData();
		payShopGoodsData.PhraseFromTempData(this.ConfigId, 0);
		PayShopGoods payShopGoods = new PayShopGoods(PayShopDefine.EPayShopTabType.None);
		payShopGoods.SetGoodsData(payShopGoodsData);
		return payShopGoods;
	}
}
