using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000409 RID: 1033
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class DrinksShowTasteItem : GridProxyAbstract<IDrinkTasteInfo>
{
	// Token: 0x06003800 RID: 14336 RVA: 0x00146002 File Offset: 0x00144202
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
	}

	// Token: 0x06003801 RID: 14337 RVA: 0x0014603C File Offset: 0x0014423C
	public override void Refresh(IDrinkTasteInfo data, bool isSelected, int gridIndex)
	{
		base.SetTextureByPath(DrinksConfig.Instance.GetFlavorType(data.Type).Value.Icon, base.GetTexture(0), null, null);
		UUIText text = base.GetText(1);
		if (text == null)
		{
			return;
		}
		text.SetText(data.Value.ToString(), true);
	}
}
