using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001228 RID: 4648
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class DangoMonopolyBuffStateItem : GridProxyAbstract<IDangoMonopolyRoundBuffData>
{
	// Token: 0x06007DCF RID: 32207 RVA: 0x001AABD4 File Offset: 0x001A8DD4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUISprite)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUITexture))
		};
	}

	// Token: 0x06007DD0 RID: 32208 RVA: 0x001AAC70 File Offset: 0x001A8E70
	public override void Refresh(IDangoMonopolyRoundBuffData data, bool isSelected, int gridIndex)
	{
		this.ItemData = data;
		UUIItem item = base.GetItem(0);
		if (item != null)
		{
			item.SetUIActive(this.ItemData.IsActive);
		}
		UUIItem item2 = base.GetItem(1);
		if (item2 != null)
		{
			item2.SetUIActive(!this.ItemData.IsActive);
		}
		UUISprite sprite = base.GetSprite(2);
		if (sprite != null)
		{
			sprite.SetUIActive(this.ItemData.IsActive);
		}
		UUIText text = base.GetText(3);
		if (text != null)
		{
			text.ShowTextNew(this.ItemData.PropertyDesc);
		}
		UUIText text2 = base.GetText(4);
		if (text2 != null)
		{
			text2.ShowTextNew(this.ItemData.PropertyDesc);
		}
		base.SetTextureByPath(this.ItemData.DangoIcon, base.GetTexture(5), null, null);
	}

	// Token: 0x04003930 RID: 14640
	private IDangoMonopolyRoundBuffData ItemData;

	// Token: 0x04003931 RID: 14641
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<IDangoMonopolyRoundBuffData> ClickCallBack;

	// Token: 0x0200781E RID: 30750
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04027964 RID: 162148
		ItemFinish,
		// Token: 0x04027965 RID: 162149
		ItemUnFinish,
		// Token: 0x04027966 RID: 162150
		SpriteActive,
		// Token: 0x04027967 RID: 162151
		TxtNameActive,
		// Token: 0x04027968 RID: 162152
		TxtNameUnActive,
		// Token: 0x04027969 RID: 162153
		TextureIcon
	}
}
