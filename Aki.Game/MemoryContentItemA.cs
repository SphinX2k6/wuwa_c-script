using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200133D RID: 4925
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class MemoryContentItemA : GridProxyAbstract<IMemoryItemData>
{
	// Token: 0x06008921 RID: 35105 RVA: 0x001D4F50 File Offset: 0x001D3150
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUISprite))
		};
	}

	// Token: 0x06008922 RID: 35106 RVA: 0x001D4FAC File Offset: 0x001D31AC
	public override void Refresh(IMemoryItemData data, bool isSelected, int gridIndex)
	{
		UUISprite sprite = base.GetSprite(2);
		this.SetSpriteByPath(data.IconPath ?? "", sprite, false, null, null);
		base.GetText(1).ShowTextNew(data.Title);
		base.GetText(0).SetText(data.Content ?? "", true);
	}
}
