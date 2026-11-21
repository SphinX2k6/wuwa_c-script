using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200199F RID: 6559
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
internal class MainRecommendAttrItem : GridProxyAbstract<IMainRecommendAttrItemData>
{
	// Token: 0x06010288 RID: 66184 RVA: 0x004B5ECC File Offset: 0x004B40CC
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

	// Token: 0x06010289 RID: 66185 RVA: 0x004B5F3C File Offset: 0x004B413C
	protected override void OnStart()
	{
		this.Layout = new GenericLayout<AttrContent, RecommendItemData>(base.GetVerticalLayout(1), new Func<AttrContent>(this.InitItem), base.GetItem(2).GetOwner() as AUIBaseActor, false, true);
	}

	// Token: 0x0601028A RID: 66186 RVA: 0x004B5F6F File Offset: 0x004B416F
	private AttrContent InitItem()
	{
		return new AttrContent();
	}

	// Token: 0x0601028B RID: 66187 RVA: 0x004B5F78 File Offset: 0x004B4178
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

	// Token: 0x04008F62 RID: 36706
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<AttrContent, RecommendItemData> Layout;
}
