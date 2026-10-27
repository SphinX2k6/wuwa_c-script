using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020024B8 RID: 9400
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
internal class MainRecommendAttrItem : GridProxyAbstract<IMainRecommendAttrItemData>
{
	// Token: 0x06012DC8 RID: 77256 RVA: 0x004A8318 File Offset: 0x004A6518
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem))
		};
	}

	// Token: 0x06012DC9 RID: 77257 RVA: 0x004A8388 File Offset: 0x004A6588
	protected override void OnStart()
	{
		this.Layout = new GenericLayout<AttrContent, RecommendItemData>(base.GetVerticalLayout(1), new Func<AttrContent>(this.InitItem), base.GetItem(2).GetOwner() as AUIBaseActor, false, true);
	}

	// Token: 0x06012DCA RID: 77258 RVA: 0x004A83BB File Offset: 0x004A65BB
	private AttrContent InitItem()
	{
		return new AttrContent();
	}

	// Token: 0x06012DCB RID: 77259 RVA: 0x004A83C4 File Offset: 0x004A65C4
	public override void Refresh(IMainRecommendAttrItemData data, bool isSelected, int gridIndex)
	{
		LguiUtil.Instance.TrySetLocalTextNew(base.GetText(0), data.CostLabel, Array.Empty<object>());
		GenericLayout<AttrContent, RecommendItemData> layout = this.Layout;
		if (layout != null)
		{
			layout.RefreshByData(data.Items, null, false);
		}
		UUIItem item = base.GetItem(3);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(data.Items.Count == 0);
	}

	// Token: 0x04008E18 RID: 36376
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<AttrContent, RecommendItemData> Layout;
}
