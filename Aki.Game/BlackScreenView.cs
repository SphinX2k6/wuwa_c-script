using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002C45 RID: 11333
public class BlackScreenView : UiPanelBase
{
	// Token: 0x06017A1E RID: 96798 RVA: 0x00603578 File Offset: 0x00601778
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

	// Token: 0x06017A1F RID: 96799 RVA: 0x006035C0 File Offset: 0x006017C0
	[NullableContext(2)]
	public AActor GetBlackScreenTextureActor()
	{
		UUITexture texture = base.GetTexture(0);
		if (texture == null)
		{
			return null;
		}
		return texture.GetOwner();
	}

	// Token: 0x02009235 RID: 37429
	private enum EChildType
	{
		// Token: 0x0402F4A1 RID: 193697
		BlackTexture
	}
}
