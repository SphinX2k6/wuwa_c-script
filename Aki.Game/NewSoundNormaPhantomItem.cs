using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020016A3 RID: 5795
public class NewSoundNormaPhantomItem : GridProxyAbstract<int>
{
	// Token: 0x0600A566 RID: 42342 RVA: 0x0024F524 File Offset: 0x0024D724
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

	// Token: 0x0600A567 RID: 42343 RVA: 0x0024F56C File Offset: 0x0024D76C
	public override void Refresh(int data, bool isSelected, int gridIndex)
	{
	}

	// Token: 0x02007C7A RID: 31866
	private enum EChildType
	{
		// Token: 0x04028D79 RID: 167289
		IconTexture
	}
}
