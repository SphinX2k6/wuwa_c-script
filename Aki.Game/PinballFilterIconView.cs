using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200186F RID: 6255
public class PinballFilterIconView : UiPanelBase
{
	// Token: 0x0600B79F RID: 47007 RVA: 0x00298A48 File Offset: 0x00296C48
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

	// Token: 0x0600B7A0 RID: 47008 RVA: 0x00298AB4 File Offset: 0x00296CB4
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

	// Token: 0x0600B7A1 RID: 47009 RVA: 0x00298AF4 File Offset: 0x00296CF4
	public void SetBgChangeColor(bool needChangeColor, FColor? changeColor = null)
	{
		UUISprite sprite = base.GetSprite(0);
		if (sprite == null)
		{
			return;
		}
		sprite.SetChangeColor(needChangeColor, changeColor);
	}

	// Token: 0x02007E34 RID: 32308
	private enum EPinballFilterIconComponent
	{
		// Token: 0x040294DC RID: 169180
		SprBg,
		// Token: 0x040294DD RID: 169181
		TexIcon
	}
}
