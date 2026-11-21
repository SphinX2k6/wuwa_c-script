using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000482 RID: 1154
[NullableContext(1)]
[Nullable(0)]
public class FurnitureExchangeShopItem : UiPanelBase
{
	// Token: 0x06003B88 RID: 15240 RVA: 0x001530E0 File Offset: 0x001512E0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIText))
		};
	}

	// Token: 0x06003B89 RID: 15241 RVA: 0x0015313A File Offset: 0x0015133A
	protected override void OnStart()
	{
		this.PayShopItem = new GameplayShopItem();
		this.PayShopItem.CreateThenShowByActor(base.GetItem(0).GetOwner(), null);
	}

	// Token: 0x06003B8A RID: 15242 RVA: 0x0015315F File Offset: 0x0015135F
	public void RefreshByData(FurnitureShopExchangeItemProxy data)
	{
		this.ShopItemProxy = data;
		this.PayShopItem.RefreshByData(this.ShopItemProxy.FurnitureShopItemProxy);
		this.RefreshAtmosphereText();
	}

	// Token: 0x06003B8B RID: 15243 RVA: 0x00153184 File Offset: 0x00151384
	public void RefreshAtmosphereText()
	{
		base.GetText(2).SetText(this.ShopItemProxy.AtmosphereText, true);
	}

	// Token: 0x04002FFD RID: 12285
	private FurnitureShopExchangeItemProxy ShopItemProxy = new FurnitureShopExchangeItemProxy();

	// Token: 0x04002FFE RID: 12286
	[Nullable(2)]
	private GameplayShopItem PayShopItem;
}
