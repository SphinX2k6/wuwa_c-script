using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001F5F RID: 8031
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class ShipTowerWordItem : GridProxyAbstract<ShipTowerWordItemData>
{
	// Token: 0x06013DCA RID: 81354 RVA: 0x005CAB04 File Offset: 0x005C8D04
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUISprite))
		};
	}

	// Token: 0x06013DCB RID: 81355 RVA: 0x005CAB60 File Offset: 0x005C8D60
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

	// Token: 0x0400A961 RID: 43361
	private ShipTowerWordItemData ItemData;

	// Token: 0x0200825F RID: 33375
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x0402A179 RID: 172409
		public const int SpriteBg = 0;

		// Token: 0x0402A17A RID: 172410
		public const int TxtName = 1;

		// Token: 0x0402A17B RID: 172411
		public const int SpriteIcon = 2;
	}
}
