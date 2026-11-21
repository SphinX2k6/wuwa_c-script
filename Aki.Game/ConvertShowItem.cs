using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020014A3 RID: 5283
[NullableContext(1)]
[Nullable(0)]
internal class ConvertShowItem : UiPanelBase
{
	// Token: 0x0600D39F RID: 54175 RVA: 0x003EEA58 File Offset: 0x003ECC58
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

	// Token: 0x0600D3A0 RID: 54176 RVA: 0x003EEAE2 File Offset: 0x003ECCE2
	protected override void OnStart()
	{
		this.ItemScrollView = new LoopScrollView<CommonItemSmallItemGrid, TItem>(base.GetLoopScrollViewComponent(1), base.GetItem(2).GetOwner() as AUIBaseActor, new Func<CommonItemSmallItemGrid>(this.OnGridProxyCreate), false);
	}

	// Token: 0x0600D3A1 RID: 54177 RVA: 0x003EEB14 File Offset: 0x003ECD14
	private CommonItemSmallItemGrid OnGridProxyCreate()
	{
		return new CommonItemSmallItemGrid();
	}

	// Token: 0x0600D3A2 RID: 54178 RVA: 0x003EEB1B File Offset: 0x003ECD1B
	public void Refresh(string title, IReadOnlyList<TItem> itemList)
	{
		LoopScrollView<CommonItemSmallItemGrid, TItem> itemScrollView = this.ItemScrollView;
		if (itemScrollView != null)
		{
			itemScrollView.RefreshByData(itemList, false, null, false);
		}
		base.GetText(0).ShowTextNew(title);
	}

	// Token: 0x04007705 RID: 30469
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private LoopScrollView<CommonItemSmallItemGrid, TItem> ItemScrollView;
}
