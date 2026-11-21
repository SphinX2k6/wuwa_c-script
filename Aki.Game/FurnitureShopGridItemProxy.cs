using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PayShop;

// Token: 0x0200042A RID: 1066
[NullableContext(1)]
[Nullable(0)]
public class FurnitureShopGridItemProxy
{
	// Token: 0x060038E9 RID: 14569 RVA: 0x0014AFE4 File Offset: 0x001491E4
	public void UpdateFromPayShopGoods(PayShopGoods data)
	{
		this.FurnitureShopItemProxy.UpdateFromPayShopGoods(data);
		this.AtmosphereText = FurnitureModel.Instance.GetFurnitureConfigByGoodsData(data).Atmosphere.ToString();
	}

	// Token: 0x04002EA1 RID: 11937
	public FurnitureShopItemProxy FurnitureShopItemProxy = new FurnitureShopItemProxy();

	// Token: 0x04002EA2 RID: 11938
	public string AtmosphereText = "";
}
