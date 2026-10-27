using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020017EC RID: 6124
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class CommonTextItem : GridProxyAbstract<TableTextArgNew>
{
	// Token: 0x0600B334 RID: 45876 RVA: 0x00287E38 File Offset: 0x00286038
	protected unsafe override void OnRegisterComponent()
	{
		int num = 1;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int index = 0;
		*span[index] = new ValueTuple<int, Type>(0, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600B335 RID: 45877 RVA: 0x00287E80 File Offset: 0x00286080
	public void SetTextByTextId(string textId, [ParamCollection] [Nullable(new byte[]
	{
		1,
		2
	})] IReadOnlyList<object> args)
	{
		LguiUtil.Instance.SetLocalText(base.GetText(0), textId, args);
	}

	// Token: 0x0600B336 RID: 45878 RVA: 0x00287E98 File Offset: 0x00286098
	public override void Refresh(TableTextArgNew data, bool isSelected, int gridIndex)
	{
		string textKey = data.TextKey;
		if (textKey != null)
		{
			this.SetTextByTextId(textKey, data.Params);
		}
	}

	// Token: 0x02007DDA RID: 32218
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x04029318 RID: 168728
		public const int Text = 0;
	}
}
