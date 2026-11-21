using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000B5B RID: 2907
public class NewSoundNormaPhantomItem : GridProxyAbstract<int>
{
	// Token: 0x06007946 RID: 31046 RVA: 0x0025993C File Offset: 0x00257B3C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 1;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int index = 0;
		*span[index] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06007947 RID: 31047 RVA: 0x00259984 File Offset: 0x00257B84
	public override void Refresh(int data, bool isSelected, int gridIndex)
	{
	}

	// Token: 0x02006DFF RID: 28159
	private enum EChildType
	{
		// Token: 0x040240A2 RID: 147618
		IconTexture
	}
}
