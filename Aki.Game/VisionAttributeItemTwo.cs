using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Module.Vision.View;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002499 RID: 9369
[NullableContext(1)]
[Nullable(0)]
public class VisionAttributeItemTwo : UiPanelBase
{
	// Token: 0x06012CEA RID: 77034 RVA: 0x004A466F File Offset: 0x004A286F
	public VisionAttributeItemTwo(UUIItem root)
	{
		this.LoadingPromise = new CustomPromise<bool>();
		base.CreateThenShowByResourceIdAsync("UiItem_VisionIAttriItemB", root, false);
	}

	// Token: 0x06012CEB RID: 77035 RVA: 0x004A4690 File Offset: 0x004A2890
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

	// Token: 0x06012CEC RID: 77036 RVA: 0x004A46D8 File Offset: 0x004A28D8
	protected override void OnStart()
	{
		this.Layout = new GenericScrollView<AttributeItem>(base.GetScrollViewWithScrollbar(0), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<AttributeItem>(this.InitItem), null);
	}

	// Token: 0x06012CED RID: 77037 RVA: 0x004A46FC File Offset: 0x004A28FC
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

	// Token: 0x06012CEE RID: 77038 RVA: 0x004A4734 File Offset: 0x004A2934
	public void Update(List<VisionAttributeVariantTwoData> data)
	{
		this.Layout.RefreshByData<VisionAttributeVariantTwoData>(data, null);
	}

	// Token: 0x06012CEF RID: 77039 RVA: 0x004A4756 File Offset: 0x004A2956
	protected override void OnBeforeDestroy()
	{
		this.Layout.ClearChildren();
	}

	// Token: 0x04008DA6 RID: 36262
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollView<AttributeItem> Layout;

	// Token: 0x04008DA7 RID: 36263
	public CustomPromise<bool> LoadingPromise;

	// Token: 0x02008A18 RID: 35352
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402CD8B RID: 183691
		Scroller
	}
}
