using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000F54 RID: 3924
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class DrinksShowTasteItem : GridProxyAbstract<IDrinkTasteInfo>
{
	// Token: 0x06006468 RID: 25704 RVA: 0x0013D766 File Offset: 0x0013B966
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
	}

	// Token: 0x06006469 RID: 25705 RVA: 0x0013D7A0 File Offset: 0x0013B9A0
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
