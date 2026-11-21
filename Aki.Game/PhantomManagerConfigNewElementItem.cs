using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001911 RID: 6417
public class PhantomManagerConfigNewElementItem : UiPanelBase
{
	// Token: 0x0600FDDE RID: 64990 RVA: 0x004A1524 File Offset: 0x0049F724
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

	// Token: 0x0600FDDF RID: 64991 RVA: 0x004A1590 File Offset: 0x0049F790
	[NullableContext(1)]
	public void Refresh(string path)
	{
		base.SetTextureByPath(path, base.GetTexture(1), null, null);
	}

	// Token: 0x02007B35 RID: 31541
	private enum EElement
	{
		// Token: 0x04027EDD RID: 163549
		Sprite,
		// Token: 0x04027EDE RID: 163550
		Texture
	}
}
