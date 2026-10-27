using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200242C RID: 9260
public class PhantomManagerConfigNewElementItem : UiPanelBase
{
	// Token: 0x06012928 RID: 76072 RVA: 0x00493F58 File Offset: 0x00492158
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

	// Token: 0x06012929 RID: 76073 RVA: 0x00493FC4 File Offset: 0x004921C4
	[NullableContext(1)]
	public void Refresh(string path)
	{
		base.SetTextureByPath(path, base.GetTexture(1), null, null);
	}

	// Token: 0x020089AE RID: 35246
	private enum EElement
	{
		// Token: 0x0402CBC7 RID: 183239
		Sprite,
		// Token: 0x0402CBC8 RID: 183240
		Texture
	}
}
