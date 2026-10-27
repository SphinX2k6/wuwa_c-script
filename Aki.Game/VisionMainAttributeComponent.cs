using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020024D0 RID: 9424
public class VisionMainAttributeComponent : UiPanelBase
{
	// Token: 0x06012F3C RID: 77628 RVA: 0x004B11D1 File Offset: 0x004AF3D1
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x06012F3D RID: 77629 RVA: 0x004B120A File Offset: 0x004AF40A
	protected override void OnStart()
	{
		this.Layout = new GenericLayout<VisionIdentifyAttributeItem, AttrListScrollData>(base.GetVerticalLayout(0), new Func<VisionIdentifyAttributeItem>(this.InitItem), null, false, true);
		this.SetActive(true);
		base.GetItem(1).SetUIActive(false);
	}

	// Token: 0x06012F3E RID: 77630 RVA: 0x004B1241 File Offset: 0x004AF441
	[NullableContext(1)]
	private VisionIdentifyAttributeItem InitItem()
	{
		return new VisionIdentifyAttributeItem();
	}

	// Token: 0x06012F3F RID: 77631 RVA: 0x004B1248 File Offset: 0x004AF448
	[NullableContext(1)]
	public void Update(AttrListScrollData[] data)
	{
		this.Layout.RefreshByData(data.ToList<AttrListScrollData>(), null, false);
	}

	// Token: 0x04008EB6 RID: 36534
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected GenericLayout<VisionIdentifyAttributeItem, AttrListScrollData> Layout;

	// Token: 0x02008A62 RID: 35426
	private enum ELevelAttribute
	{
		// Token: 0x0402CEED RID: 184045
		Layout,
		// Token: 0x0402CEEE RID: 184046
		Item
	}
}
