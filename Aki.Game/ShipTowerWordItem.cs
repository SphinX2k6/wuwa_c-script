using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020029E4 RID: 10724
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class ShipTowerWordItem : GridProxyAbstract<ShipTowerWordItemData>
{
	// Token: 0x060163C4 RID: 91076 RVA: 0x0059FB4C File Offset: 0x0059DD4C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUISprite))
		};
	}

	// Token: 0x060163C5 RID: 91077 RVA: 0x0059FBA8 File Offset: 0x0059DDA8
	public override void Refresh(ShipTowerWordItemData data, bool isSelected, int gridIndex)
	{
		this.ItemData = data;
		base.GetText(1).SetText(data.Title, true);
		if (!string.IsNullOrEmpty(data.TitleColor))
		{
			FColor color = FColor.FromHex(data.TitleColor);
			base.GetText(1).SetColor(color);
			base.GetSprite(0).SetColor(color);
		}
		this.SetSpriteByPath(data.IconPath, base.GetSprite(2), false, null, null);
	}

	// Token: 0x0400A577 RID: 42359
	private ShipTowerWordItemData ItemData;

	// Token: 0x02009018 RID: 36888
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x0402EA81 RID: 191105
		public const int SpriteBg = 0;

		// Token: 0x0402EA82 RID: 191106
		public const int TxtName = 1;

		// Token: 0x0402EA83 RID: 191107
		public const int SpriteIcon = 2;
	}
}
