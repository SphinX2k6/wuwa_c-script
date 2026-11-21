using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x02000CD8 RID: 3288
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class OneTextTitleItem : TitleItemBase<TableTextArgNew>
{
	// Token: 0x0600890C RID: 35084 RVA: 0x00298A51 File Offset: 0x00296C51
	public OneTextTitleItem(UUIItem uiItem) : base(uiItem)
	{
	}

	// Token: 0x0600890D RID: 35085 RVA: 0x00298A5C File Offset: 0x00296C5C
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

	// Token: 0x0600890E RID: 35086 RVA: 0x00298AA4 File Offset: 0x00296CA4
	public override void ShowTemp(TableTextArgNew data, DropDownItemBase<TableTextArgNew> selectedItemObj)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.TextKey, data.Params);
	}

	// Token: 0x02006F91 RID: 28561
	[NullableContext(0)]
	private class ECompDefine
	{
		// Token: 0x04024729 RID: 149289
		public const int Title = 0;
	}
}
