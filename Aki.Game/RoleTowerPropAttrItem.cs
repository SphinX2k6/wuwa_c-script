using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001CEC RID: 7404
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RoleTowerPropAttrItem : GridProxyAbstract<RoleTowerPropAttrData>
{
	// Token: 0x0601254F RID: 75087 RVA: 0x005687F0 File Offset: 0x005669F0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUISprite)),
			new ValueTuple<int, Type>(4, typeof(UUISprite))
		};
	}

	// Token: 0x06012550 RID: 75088 RVA: 0x00568878 File Offset: 0x00566A78
	public override void Refresh(RoleTowerPropAttrData data, bool isSelected, int gridIndex)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.AttrName, Array.Empty<object>());
		UUIText text = base.GetText(2);
		if (text != null)
		{
			text.SetText(data.AttrValue, true);
		}
		UUITexture texture = base.GetTexture(0);
		if (texture != null && !string.IsNullOrEmpty(data.IconPath))
		{
			base.SetTextureByPath(data.IconPath, texture, null, null);
		}
		UUISprite sprite = base.GetSprite(3);
		if (sprite != null)
		{
			sprite.SetUIActive(!data.IsHighlight);
		}
		UUISprite sprite2 = base.GetSprite(4);
		if (sprite2 == null)
		{
			return;
		}
		sprite2.SetUIActive(data.IsHighlight);
	}

	// Token: 0x06012551 RID: 75089 RVA: 0x0056891B File Offset: 0x00566B1B
	public override object GetKey(RoleTowerPropAttrData data, int displayIndex)
	{
		return displayIndex;
	}

	// Token: 0x02007FF7 RID: 32759
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x04029661 RID: 169569
		public const int TexIcon = 0;

		// Token: 0x04029662 RID: 169570
		public const int TxtAttributeTxt = 1;

		// Token: 0x04029663 RID: 169571
		public const int TxtNumber = 2;

		// Token: 0x04029664 RID: 169572
		public const int SprBg = 3;

		// Token: 0x04029665 RID: 169573
		public const int SprBgLight = 4;
	}
}
