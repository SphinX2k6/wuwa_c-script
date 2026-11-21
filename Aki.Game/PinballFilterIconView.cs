using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000D28 RID: 3368
public class PinballFilterIconView : UiPanelBase
{
	// Token: 0x06008B88 RID: 35720 RVA: 0x002A3164 File Offset: 0x002A1364
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06008B89 RID: 35721 RVA: 0x002A31D0 File Offset: 0x002A13D0
	[NullableContext(1)]
	public void SetIcon(bool bVisible, string iconPath = "")
	{
		UUITexture texture = base.GetTexture(1);
		if (texture != null)
		{
			texture.SetUIActive(bVisible);
		}
		if (!StringUtils.IsBlank(iconPath))
		{
			base.TrySetTextureByPath(iconPath, base.GetTexture(1), null, null);
		}
	}

	// Token: 0x06008B8A RID: 35722 RVA: 0x002A3210 File Offset: 0x002A1410
	public void SetBgChangeColor(bool needChangeColor, FColor? changeColor = null)
	{
		UUISprite sprite = base.GetSprite(0);
		if (sprite == null)
		{
			return;
		}
		sprite.SetChangeColor(needChangeColor, changeColor);
	}

	// Token: 0x02006FBB RID: 28603
	private enum EPinballFilterIconComponent
	{
		// Token: 0x04024809 RID: 149513
		SprBg,
		// Token: 0x0402480A RID: 149514
		TexIcon
	}
}
