using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200049D RID: 1181
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class FurnitureShopGridItem : GridProxyAbstract<FurnitureShopGridItemProxy>
{
	// Token: 0x06003C25 RID: 15397 RVA: 0x00155058 File Offset: 0x00153258
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIText))
		};
	}

	// Token: 0x06003C26 RID: 15398 RVA: 0x001550B2 File Offset: 0x001532B2
	protected override void OnStart()
	{
		this.PayShopItem = new GameplayShopItem();
		this.PayShopItem.CreateThenShowByActor(base.GetItem(0).GetOwner(), null);
	}

	// Token: 0x06003C27 RID: 15399 RVA: 0x001550D7 File Offset: 0x001532D7
	[NullableContext(1)]
	public override void Refresh(FurnitureShopGridItemProxy data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		this.PayShopItem.RefreshByData(this.Data.FurnitureShopItemProxy);
		this.RefreshAtmosphereText();
	}

	// Token: 0x06003C28 RID: 15400 RVA: 0x001550FC File Offset: 0x001532FC
	public void RefreshAtmosphereText()
	{
		base.GetText(2).SetText(this.Data.AtmosphereText, true);
	}

	// Token: 0x04003074 RID: 12404
	private GameplayShopItem PayShopItem;

	// Token: 0x04003075 RID: 12405
	private FurnitureShopGridItemProxy Data;
}
