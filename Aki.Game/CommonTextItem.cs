using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000CA5 RID: 3237
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class CommonTextItem : GridProxyAbstract<TableTextArgNew>
{
	// Token: 0x0600871E RID: 34590 RVA: 0x0029250C File Offset: 0x0029070C
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

	// Token: 0x0600871F RID: 34591 RVA: 0x00292554 File Offset: 0x00290754
	public void SetTextByTextId(string textId, [ParamCollection] [Nullable(new byte[]
	{
		1,
		2
	})] IReadOnlyList<object> args)
	{
		LguiUtil.Instance.SetLocalText(base.GetText(0), textId, args);
	}

	// Token: 0x06008720 RID: 34592 RVA: 0x0029256C File Offset: 0x0029076C
	public override void Refresh(TableTextArgNew data, bool isSelected, int gridIndex)
	{
		string textKey = data.TextKey;
		if (textKey != null)
		{
			this.SetTextByTextId(textKey, data.Params);
		}
	}

	// Token: 0x02006F60 RID: 28512
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x04024643 RID: 149059
		public const int Text = 0;
	}
}
