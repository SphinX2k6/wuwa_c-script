using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001760 RID: 5984
[Nullable(new byte[]
{
	0,
	1
})]
public class MotorcycleDiyPresetIconItem : GridProxyAbstract<string>
{
	// Token: 0x0600E876 RID: 59510 RVA: 0x00441FFC File Offset: 0x004401FC
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

	// Token: 0x0600E877 RID: 59511 RVA: 0x00442044 File Offset: 0x00440244
	[NullableContext(1)]
	public override void Refresh(string data, bool isSelected, int gridIndex)
	{
		base.SetTextureByPath(data, base.GetTexture(0), null, null);
	}

	// Token: 0x0200794A RID: 31050
	private class EMotorDiyPresetIconComponent
	{
		// Token: 0x04027503 RID: 161027
		public const int TexIcon = 0;
	}
}
