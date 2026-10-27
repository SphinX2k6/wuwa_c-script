using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000FE8 RID: 4072
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class FurnitureShopGridItem : GridProxyAbstract<FurnitureShopGridItemProxy>
{
	// Token: 0x0600688D RID: 26765 RVA: 0x0014C794 File Offset: 0x0014A994
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIText))
		};
	}

	// Token: 0x0600688E RID: 26766 RVA: 0x0014C7EE File Offset: 0x0014A9EE
	protected override void OnStart()
	{
		this.PayShopItem = new GameplayShopItem();
		this.PayShopItem.CreateThenShowByActor(base.GetItem(0).GetOwner(), null);
	}

	// Token: 0x0600688F RID: 26767 RVA: 0x0014C813 File Offset: 0x0014AA13
	[NullableContext(1)]
	public override void Refresh(FurnitureShopGridItemProxy data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		this.PayShopItem.RefreshByData(this.Data.FurnitureShopItemProxy);
		this.RefreshAtmosphereText();
	}

	// Token: 0x06006890 RID: 26768 RVA: 0x0014C838 File Offset: 0x0014AA38
	public void RefreshAtmosphereText()
	{
		base.GetText(2).SetText(this.Data.AtmosphereText, true);
	}

	// Token: 0x04002FDB RID: 12251
	private GameplayShopItem PayShopItem;

	// Token: 0x04002FDC RID: 12252
	private FurnitureShopGridItemProxy Data;
}
