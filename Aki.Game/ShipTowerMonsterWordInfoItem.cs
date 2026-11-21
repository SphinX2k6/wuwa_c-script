using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001F35 RID: 7989
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class ShipTowerMonsterWordInfoItem : GridProxyAbstract<ShipTowerMonsterWordInfoItemData>
{
	// Token: 0x06013C65 RID: 80997 RVA: 0x005C4E74 File Offset: 0x005C3074
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUISprite)),
			new ValueTuple<int, Type>(2, typeof(UUIText))
		};
	}

	// Token: 0x06013C66 RID: 80998 RVA: 0x005C4ECE File Offset: 0x005C30CE
	public override void Refresh(ShipTowerMonsterWordInfoItemData data, bool isSelected, int gridIndex)
	{
		this.Refresh(data);
	}

	// Token: 0x06013C67 RID: 80999 RVA: 0x005C4ED8 File Offset: 0x005C30D8
	public void Refresh(ShipTowerMonsterWordInfoItemData data)
	{
		bool flag = !string.IsNullOrEmpty(data.IconPath);
		UUISprite sprite = base.GetSprite(1);
		UUIItem item = base.GetItem(0);
		if (flag)
		{
			this.SetSpriteByPath(data.IconPath, sprite, false, null, null);
		}
		item.SetUIActive(flag);
		base.GetText(2).SetText(data.Desc, true);
	}

	// Token: 0x02008219 RID: 33305
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x0402A03C RID: 172092
		public const int ItemIconRoot = 0;

		// Token: 0x0402A03D RID: 172093
		public const int SpriteIcon = 1;

		// Token: 0x0402A03E RID: 172094
		public const int TxtDesc = 2;
	}
}
