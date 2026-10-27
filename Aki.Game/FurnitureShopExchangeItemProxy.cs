using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PayShop;

// Token: 0x02000F73 RID: 3955
[NullableContext(1)]
[Nullable(0)]
public class FurnitureShopExchangeItemProxy
{
	// Token: 0x06006549 RID: 25929 RVA: 0x00142658 File Offset: 0x00140858
	public void UpdateFromPayShopGoods(PayShopGoods data)
	{
		this.FurnitureShopItemProxy.UpdateFromPayShopGoods(data);
		this.AtmosphereText = FurnitureModel.Instance.GetFurnitureConfigByGoodsData(data).Atmosphere.ToString();
	}

	// Token: 0x04002E06 RID: 11782
	public CommonGameplayExchangeShopItemProxy FurnitureShopItemProxy = new CommonGameplayExchangeShopItemProxy();

	// Token: 0x04002E07 RID: 11783
	public string AtmosphereText = "";
}
