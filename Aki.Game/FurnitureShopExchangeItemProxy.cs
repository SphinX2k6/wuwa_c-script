using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PayShop;

// Token: 0x02000428 RID: 1064
[NullableContext(1)]
[Nullable(0)]
public class FurnitureShopExchangeItemProxy
{
	// Token: 0x060038E1 RID: 14561 RVA: 0x0014AEF4 File Offset: 0x001490F4
	public void UpdateFromPayShopGoods(PayShopGoods data)
	{
		this.FurnitureShopItemProxy.UpdateFromPayShopGoods(data);
		this.AtmosphereText = FurnitureModel.Instance.GetFurnitureConfigByGoodsData(data).Atmosphere.ToString();
	}

	// Token: 0x04002E9F RID: 11935
	public CommonGameplayExchangeShopItemProxy FurnitureShopItemProxy = new CommonGameplayExchangeShopItemProxy();

	// Token: 0x04002EA0 RID: 11936
	public string AtmosphereText = "";
}
