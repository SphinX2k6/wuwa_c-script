using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001CED RID: 7405
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RoleTowerPropBuffItem : GridProxyAbstract<RoleTowerPropBuffData>
{
	// Token: 0x06012553 RID: 75091 RVA: 0x0056892C File Offset: 0x00566B2C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUISprite)),
			new ValueTuple<int, Type>(2, typeof(UUISprite)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIText))
		};
	}

	// Token: 0x06012554 RID: 75092 RVA: 0x005689C8 File Offset: 0x00566BC8
	public override void Refresh(RoleTowerPropBuffData data, bool isSelected, int gridIndex)
	{
		UUISprite sprite = base.GetSprite(1);
		if (sprite != null)
		{
			sprite.SetUIActive(true);
		}
		if (sprite != null)
		{
			UUIItem uuiitem = sprite;
			bool isActive = data.IsActive;
			FColor? fcolor = new FColor?(sprite.changeColor);
			uuiitem.SetChangeColor(isActive, fcolor);
		}
		UUISprite sprite2 = base.GetSprite(2);
		if (sprite2 != null)
		{
			sprite2.SetUIActive(data.IsActive);
		}
		UUIText text = base.GetText(4);
		if (text != null)
		{
			text.ShowTextNew(data.Title);
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(5), data.Desc, data.DescParams);
	}

	// Token: 0x06012555 RID: 75093 RVA: 0x00568A51 File Offset: 0x00566C51
	public override object GetKey(RoleTowerPropBuffData data, int displayIndex)
	{
		return displayIndex;
	}

	// Token: 0x02007FF8 RID: 32760
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x04029666 RID: 169574
		public const int PrtState = 0;

		// Token: 0x04029667 RID: 169575
		public const int SprNone = 1;

		// Token: 0x04029668 RID: 169576
		public const int SprChoose = 2;

		// Token: 0x04029669 RID: 169577
		public const int PrtTitle = 3;

		// Token: 0x0402966A RID: 169578
		public const int TxtContentA = 4;

		// Token: 0x0402966B RID: 169579
		public const int TxtContentB = 5;
	}
}
