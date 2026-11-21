using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000BA9 RID: 2985
public class AttributeView : UiViewBase
{
	// Token: 0x06007C40 RID: 31808 RVA: 0x00267D07 File Offset: 0x00265F07
	[NullableContext(1)]
	public AttributeView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06007C41 RID: 31809 RVA: 0x00267D10 File Offset: 0x00265F10
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIScrollViewWithScrollbarComponent))
		};
	}

	// Token: 0x06007C42 RID: 31810 RVA: 0x00267D34 File Offset: 0x00265F34
	protected override void OnStart()
	{
		CommonAttributeData[] data = this.OpenParam as CommonAttributeData[];
		this.AttrScrollList = new GenericScrollView<CommonAttributeItem>(base.GetScrollViewWithScrollbar(0), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<CommonAttributeItem>(this.InitAttrItem), null);
		this.AttrScrollList.RefreshByData<CommonAttributeData>(data, null);
	}

	// Token: 0x06007C43 RID: 31811 RVA: 0x00267D84 File Offset: 0x00265F84
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

	// Token: 0x06007C44 RID: 31812 RVA: 0x00267DBC File Offset: 0x00265FBC
	protected override void OnBeforeDestroy()
	{
		if (this.AttrScrollList != null)
		{
			this.AttrScrollList.ClearChildren();
			this.AttrScrollList = null;
		}
	}

	// Token: 0x04004D6F RID: 19823
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollView<CommonAttributeItem> AttrScrollList;

	// Token: 0x02006E3D RID: 28221
	private enum EAttributeView
	{
		// Token: 0x040241AF RID: 147887
		AttributeContent
	}
}
