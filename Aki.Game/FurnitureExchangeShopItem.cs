using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000FCD RID: 4045
[NullableContext(1)]
[Nullable(0)]
public class FurnitureExchangeShopItem : UiPanelBase
{
	// Token: 0x060067F0 RID: 26608 RVA: 0x0014A81C File Offset: 0x00148A1C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIText))
		};
	}

	// Token: 0x060067F1 RID: 26609 RVA: 0x0014A876 File Offset: 0x00148A76
	protected override void OnStart()
	{
		this.PayShopItem = new GameplayShopItem();
		this.PayShopItem.CreateThenShowByActor(base.GetItem(0).GetOwner(), null);
	}

	// Token: 0x060067F2 RID: 26610 RVA: 0x0014A89B File Offset: 0x00148A9B
	public void RefreshByData(FurnitureShopExchangeItemProxy data)
	{
		this.ShopItemProxy = data;
		this.PayShopItem.RefreshByData(this.ShopItemProxy.FurnitureShopItemProxy);
		this.RefreshAtmosphereText();
	}

	// Token: 0x060067F3 RID: 26611 RVA: 0x0014A8C0 File Offset: 0x00148AC0
	public void RefreshAtmosphereText()
	{
		base.GetText(2).SetText(this.ShopItemProxy.AtmosphereText, true);
	}

	// Token: 0x04002F64 RID: 12132
	private FurnitureShopExchangeItemProxy ShopItemProxy = new FurnitureShopExchangeItemProxy();

	// Token: 0x04002F65 RID: 12133
	[Nullable(2)]
	private GameplayShopItem PayShopItem;
}
