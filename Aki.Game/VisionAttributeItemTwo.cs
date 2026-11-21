using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Module.Vision.View;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001980 RID: 6528
[NullableContext(1)]
[Nullable(0)]
public class VisionAttributeItemTwo : UiPanelBase
{
	// Token: 0x060101AB RID: 65963 RVA: 0x004B215F File Offset: 0x004B035F
	public VisionAttributeItemTwo(UUIItem root)
	{
		this.LoadingPromise = new CustomPromise<bool>();
		base.CreateThenShowByResourceIdAsync("UiItem_VisionIAttriItemB", root, false);
	}

	// Token: 0x060101AC RID: 65964 RVA: 0x004B2180 File Offset: 0x004B0380
	protected unsafe override void OnRegisterComponent()
	{
		int num = 1;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int index = 0;
		*span[index] = new ValueTuple<int, Type>(0, typeof(UUIScrollViewWithScrollbarComponent));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x060101AD RID: 65965 RVA: 0x004B21C8 File Offset: 0x004B03C8
	protected override void OnStart()
	{
		this.Layout = new GenericScrollView<AttributeItem>(base.GetScrollViewWithScrollbar(0), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<AttributeItem>(this.InitItem), null);
	}

	// Token: 0x060101AE RID: 65966 RVA: 0x004B21EC File Offset: 0x004B03EC
	private ILayoutItem<AttributeItem> InitItem(object data, UUIItem uiItem, int index)
	{
		AttributeItem attributeItem = new AttributeItem(uiItem);
		attributeItem.Update((VisionAttributeVariantTwoData)data);
		return new LayoutItem<AttributeItem>
		{
			Key = index,
			Value = attributeItem
		};
	}

	// Token: 0x060101AF RID: 65967 RVA: 0x004B2224 File Offset: 0x004B0424
	public void Update(List<VisionAttributeVariantTwoData> data)
	{
		this.Layout.RefreshByData<VisionAttributeVariantTwoData>(data, null);
	}

	// Token: 0x060101B0 RID: 65968 RVA: 0x004B2246 File Offset: 0x004B0446
	protected override void OnBeforeDestroy()
	{
		this.Layout.ClearChildren();
	}

	// Token: 0x04008EEF RID: 36591
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollView<AttributeItem> Layout;

	// Token: 0x04008EF0 RID: 36592
	public CustomPromise<bool> LoadingPromise;

	// Token: 0x02007BA2 RID: 31650
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x040280AB RID: 164011
		Scroller
	}
}
