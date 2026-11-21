using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020006DC RID: 1756
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class DangoMonopolyBuffStateItem : GridProxyAbstract<IDangoMonopolyRoundBuffData>
{
	// Token: 0x06005166 RID: 20838 RVA: 0x001B3894 File Offset: 0x001B1A94
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

	// Token: 0x06005167 RID: 20839 RVA: 0x001B3930 File Offset: 0x001B1B30
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

	// Token: 0x040039C8 RID: 14792
	private IDangoMonopolyRoundBuffData ItemData;

	// Token: 0x040039C9 RID: 14793
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<IDangoMonopolyRoundBuffData> ClickCallBack;

	// Token: 0x020069A9 RID: 27049
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04022C95 RID: 142485
		ItemFinish,
		// Token: 0x04022C96 RID: 142486
		ItemUnFinish,
		// Token: 0x04022C97 RID: 142487
		SpriteActive,
		// Token: 0x04022C98 RID: 142488
		TxtNameActive,
		// Token: 0x04022C99 RID: 142489
		TxtNameUnActive,
		// Token: 0x04022C9A RID: 142490
		TextureIcon
	}
}
