using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.PayShop;

// Token: 0x02000D95 RID: 3477
[NullableContext(1)]
[Nullable(0)]
public class TipsOverPowerData : ItemTipsData
{
	// Token: 0x06008E92 RID: 36498 RVA: 0x002AF2DD File Offset: 0x002AD4DD
	public TipsOverPowerData(ItemTipsParam data) : base(data)
	{
		this.ItemType = EItemTipsType.OverPower;
	}

	// Token: 0x06008E93 RID: 36499 RVA: 0x002AF2F0 File Offset: 0x002AD4F0
	public PayShopGoods ConvertToPayShopGoods()
	{
		PayShopGoodsData payShopGoodsData = new PayShopGoodsData();
		payShopGoodsData.PhraseFromTempData(this.ConfigId, 0);
		PayShopGoods payShopGoods = new PayShopGoods(PayShopDefine.EPayShopTabType.None);
		payShopGoods.SetGoodsData(payShopGoodsData);
		return payShopGoods;
	}
}
