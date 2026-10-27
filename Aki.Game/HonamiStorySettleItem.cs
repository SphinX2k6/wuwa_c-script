using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001F17 RID: 7959
[Nullable(new byte[]
{
	0,
	1
})]
public class HonamiStorySettleItem : GridProxyAbstract<IHonamiStorySettleItemParams>
{
	// Token: 0x0600F538 RID: 62776 RVA: 0x003B2AD4 File Offset: 0x003B0CD4
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

	// Token: 0x0600F539 RID: 62777 RVA: 0x003B2B3D File Offset: 0x003B0D3D
	[NullableContext(1)]
	public override void Refresh(IHonamiStorySettleItemParams data, bool isSelected, int gridIndex)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.Name, Array.Empty<object>());
		base.GetText(1).SetText(data.Value, true);
	}

	// Token: 0x02008524 RID: 34084
	private enum EComponentType
	{
		// Token: 0x0402B55A RID: 177498
		NameText,
		// Token: 0x0402B55B RID: 177499
		ValueText
	}
}
