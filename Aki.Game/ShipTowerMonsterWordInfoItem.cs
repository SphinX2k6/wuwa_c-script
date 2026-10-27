using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020029BA RID: 10682
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class ShipTowerMonsterWordInfoItem : GridProxyAbstract<ShipTowerMonsterWordInfoItemData>
{
	// Token: 0x0601625F RID: 90719 RVA: 0x00599EE8 File Offset: 0x005980E8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUISprite)),
			new ValueTuple<int, Type>(2, typeof(UUIText))
		};
	}

	// Token: 0x06016260 RID: 90720 RVA: 0x00599F42 File Offset: 0x00598142
	public override void Refresh(ShipTowerMonsterWordInfoItemData data, bool isSelected, int gridIndex)
	{
		this.Refresh(data);
	}

	// Token: 0x06016261 RID: 90721 RVA: 0x00599F4C File Offset: 0x0059814C
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

	// Token: 0x02008FD1 RID: 36817
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x0402E93F RID: 190783
		public const int ItemIconRoot = 0;

		// Token: 0x0402E940 RID: 190784
		public const int SpriteIcon = 1;

		// Token: 0x0402E941 RID: 190785
		public const int TxtDesc = 2;
	}
}
