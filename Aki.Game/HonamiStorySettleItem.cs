using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020013D9 RID: 5081
[Nullable(new byte[]
{
	0,
	1
})]
public class HonamiStorySettleItem : GridProxyAbstract<IHonamiStorySettleItemParams>
{
	// Token: 0x0600C957 RID: 51543 RVA: 0x003BE5C0 File Offset: 0x003BC7C0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600C958 RID: 51544 RVA: 0x003BE629 File Offset: 0x003BC829
	[NullableContext(1)]
	public override void Refresh(IHonamiStorySettleItemParams data, bool isSelected, int gridIndex)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.Name, Array.Empty<object>());
		base.GetText(1).SetText(data.Value, true);
	}

	// Token: 0x020076A9 RID: 30377
	private enum EComponentType
	{
		// Token: 0x0402687E RID: 157822
		NameText,
		// Token: 0x0402687F RID: 157823
		ValueText
	}
}
