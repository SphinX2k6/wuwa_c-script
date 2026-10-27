using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020016F1 RID: 5873
public class AttributeView : UiViewBase
{
	// Token: 0x0600A860 RID: 43104 RVA: 0x0025D8E7 File Offset: 0x0025BAE7
	[NullableContext(1)]
	public AttributeView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600A861 RID: 43105 RVA: 0x0025D8F0 File Offset: 0x0025BAF0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIScrollViewWithScrollbarComponent))
		};
	}

	// Token: 0x0600A862 RID: 43106 RVA: 0x0025D914 File Offset: 0x0025BB14
	protected override void OnStart()
	{
		CommonAttributeData[] source = this.OpenParam as CommonAttributeData[];
		this.AttrScrollList = new GenericScrollView<CommonAttributeItem>(base.GetScrollViewWithScrollbar(0), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<CommonAttributeItem>(this.InitAttrItem), null);
		this.AttrScrollList.RefreshByData<CommonAttributeData>(source.ToList<CommonAttributeData>(), null);
	}

	// Token: 0x0600A863 RID: 43107 RVA: 0x0025D968 File Offset: 0x0025BB68
	[NullableContext(1)]
	private ILayoutItem<CommonAttributeItem> InitAttrItem(object data, UUIItem item, int index)
	{
		CommonAttributeItem commonAttributeItem = new CommonAttributeItem(item);
		commonAttributeItem.ShowTemp((CommonAttributeData)data);
		return new LayoutItem<CommonAttributeItem>
		{
			Key = index,
			Value = commonAttributeItem
		};
	}

	// Token: 0x0600A864 RID: 43108 RVA: 0x0025D9A0 File Offset: 0x0025BBA0
	protected override void OnBeforeDestroy()
	{
		if (this.AttrScrollList != null)
		{
			this.AttrScrollList.ClearChildren();
			this.AttrScrollList = null;
		}
	}

	// Token: 0x04004CC8 RID: 19656
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollView<CommonAttributeItem> AttrScrollList;

	// Token: 0x02007CB8 RID: 31928
	private enum EAttributeView
	{
		// Token: 0x04028E86 RID: 167558
		AttributeContent
	}
}
