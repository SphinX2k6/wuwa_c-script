using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PayShop;

// Token: 0x02000F75 RID: 3957
[NullableContext(1)]
[Nullable(0)]
public class FurnitureShopGridItemProxy
{
	// Token: 0x06006551 RID: 25937 RVA: 0x00142748 File Offset: 0x00140948
	public void UpdateFromPayShopGoods(PayShopGoods data)
	{
		this.FurnitureShopItemProxy.UpdateFromPayShopGoods(data);
		this.AtmosphereText = FurnitureModel.Instance.GetFurnitureConfigByGoodsData(data).Atmosphere.ToString();
	}

	// Token: 0x04002E08 RID: 11784
	public FurnitureShopItemProxy FurnitureShopItemProxy = new FurnitureShopItemProxy();

	// Token: 0x04002E09 RID: 11785
	public string AtmosphereText = "";
}
