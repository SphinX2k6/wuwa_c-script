using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x0200181F RID: 6175
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class OneTextTitleItem : TitleItemBase<TableTextArgNew>
{
	// Token: 0x0600B521 RID: 46369 RVA: 0x0028E331 File Offset: 0x0028C531
	public OneTextTitleItem(UUIItem uiItem) : base(uiItem)
	{
	}

	// Token: 0x0600B522 RID: 46370 RVA: 0x0028E33C File Offset: 0x0028C53C
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

	// Token: 0x0600B523 RID: 46371 RVA: 0x0028E384 File Offset: 0x0028C584
	public override void ShowTemp(TableTextArgNew data, DropDownItemBase<TableTextArgNew> selectedItemObj)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.TextKey, data.Params);
	}

	// Token: 0x02007E0B RID: 32267
	[NullableContext(0)]
	private class ECompDefine
	{
		// Token: 0x040293FE RID: 168958
		public const int Title = 0;
	}
}
