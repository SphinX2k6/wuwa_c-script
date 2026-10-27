using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001FD0 RID: 8144
[NullableContext(1)]
[Nullable(0)]
internal class ConvertShowItem : UiPanelBase
{
	// Token: 0x0600FF37 RID: 65335 RVA: 0x003E247C File Offset: 0x003E067C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUILoopScrollViewComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600FF38 RID: 65336 RVA: 0x003E2506 File Offset: 0x003E0706
	protected override void OnStart()
	{
		this.ItemScrollView = new LoopScrollView<CommonItemSmallItemGrid, TItem>(base.GetLoopScrollViewComponent(1), base.GetItem(2).GetOwner() as AUIBaseActor, new Func<CommonItemSmallItemGrid>(this.OnGridProxyCreate), false);
	}

	// Token: 0x0600FF39 RID: 65337 RVA: 0x003E2538 File Offset: 0x003E0738
	private CommonItemSmallItemGrid OnGridProxyCreate()
	{
		return new CommonItemSmallItemGrid();
	}

	// Token: 0x0600FF3A RID: 65338 RVA: 0x003E253F File Offset: 0x003E073F
	public void Refresh(string title, IReadOnlyList<TItem> itemList)
	{
		LoopScrollView<CommonItemSmallItemGrid, TItem> itemScrollView = this.ItemScrollView;
		if (itemScrollView != null)
		{
			itemScrollView.RefreshByData(itemList.ToList<TItem>(), false, null, false);
		}
		base.GetText(0).ShowTextNew(title);
	}

	// Token: 0x0400761C RID: 30236
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private LoopScrollView<CommonItemSmallItemGrid, TItem> ItemScrollView;
}
