using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020007F1 RID: 2033
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class MemoryContentItemA : GridProxyAbstract<IMemoryItemData>
{
	// Token: 0x06005CBC RID: 23740 RVA: 0x001DDDBC File Offset: 0x001DBFBC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUISprite))
		};
	}

	// Token: 0x06005CBD RID: 23741 RVA: 0x001DDE18 File Offset: 0x001DC018
	public override void Refresh(IMemoryItemData data, bool isSelected, int gridIndex)
	{
		UUISprite sprite = base.GetSprite(2);
		this.SetSpriteByPath(data.IconPath ?? "", sprite, false, null, null);
		base.GetText(1).ShowTextNew(data.Title);
		base.GetText(0).SetText(data.Content ?? "", true);
	}
}
