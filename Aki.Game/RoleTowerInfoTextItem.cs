using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001D04 RID: 7428
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RoleTowerInfoTextItem : GridProxyAbstract<RoleTowerPropBuffData>
{
	// Token: 0x0601263C RID: 75324 RVA: 0x0056EE4C File Offset: 0x0056D04C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUISprite)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUISprite))
		};
	}

	// Token: 0x0601263D RID: 75325 RVA: 0x0056EED4 File Offset: 0x0056D0D4
	public override void Refresh(RoleTowerPropBuffData data, bool isSelected, int gridIndex)
	{
		UUIItem item = base.GetItem(0);
		if (item != null)
		{
			item.SetUIActive(true);
		}
		if (item != null)
		{
			UUIItem uuiitem = item;
			bool bUseChangeColor = !data.IsActive;
			FColor? fcolor = new FColor?(item.changeColor);
			uuiitem.SetChangeColor(bUseChangeColor, fcolor);
		}
		UUISprite sprite = base.GetSprite(1);
		if (sprite != null)
		{
			sprite.SetUIActive(data.IsActive);
		}
		UUIText text = base.GetText(2);
		if (text != null)
		{
			text.ShowTextNew(data.Title);
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), data.Desc, data.DescParams);
		FColor value = FColor.FromHex("adadadff");
		UUIText text2 = base.GetText(2);
		if (text2 != null)
		{
			bool bUseChangeColor2 = !data.IsActive;
			FColor? fcolor = new FColor?(value);
			text2.SetChangeColor(bUseChangeColor2, fcolor);
		}
		UUIText text3 = base.GetText(3);
		if (text3 != null)
		{
			bool bUseChangeColor3 = !data.IsActive;
			FColor? fcolor = new FColor?(value);
			text3.SetChangeColor(bUseChangeColor3, fcolor);
		}
		UUISprite sprite2 = base.GetSprite(4);
		if (sprite2 != null)
		{
			UUIItem uuiitem2 = sprite2;
			bool bUseChangeColor4 = !data.IsActive;
			FColor? fcolor = new FColor?(sprite2.changeColor);
			uuiitem2.SetChangeColor(bUseChangeColor4, fcolor);
		}
	}

	// Token: 0x0601263E RID: 75326 RVA: 0x0056EFDB File Offset: 0x0056D1DB
	public override object GetKey(RoleTowerPropBuffData data, int displayIndex)
	{
		return displayIndex;
	}

	// Token: 0x0400A03F RID: 41023
	private const string InactiveHexColor = "adadadff";

	// Token: 0x0200802F RID: 32815
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x040297AA RID: 169898
		public const int PnlActiviceState = 0;

		// Token: 0x040297AB RID: 169899
		public const int SprChoose = 1;

		// Token: 0x040297AC RID: 169900
		public const int TxtLevel = 2;

		// Token: 0x040297AD RID: 169901
		public const int TxtDesc = 3;

		// Token: 0x040297AE RID: 169902
		public const int SprBg = 4;
	}
}
