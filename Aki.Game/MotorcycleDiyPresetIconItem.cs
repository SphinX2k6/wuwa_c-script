using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200227C RID: 8828
[Nullable(new byte[]
{
	0,
	1
})]
public class MotorcycleDiyPresetIconItem : GridProxyAbstract<string>
{
	// Token: 0x060113E0 RID: 70624 RVA: 0x004353F0 File Offset: 0x004335F0
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

	// Token: 0x060113E1 RID: 70625 RVA: 0x00435438 File Offset: 0x00433638
	[NullableContext(1)]
	public override void Refresh(string data, bool isSelected, int gridIndex)
	{
		base.SetTextureByPath(data, base.GetTexture(0), null, null);
	}

	// Token: 0x020087C1 RID: 34753
	private class EMotorDiyPresetIconComponent
	{
		// Token: 0x0402C1EB RID: 180715
		public const int TexIcon = 0;
	}
}
