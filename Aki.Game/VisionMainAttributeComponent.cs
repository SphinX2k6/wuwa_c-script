using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020019B7 RID: 6583
public class VisionMainAttributeComponent : UiPanelBase
{
	// Token: 0x060103FB RID: 66555 RVA: 0x004BEDD5 File Offset: 0x004BCFD5
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x060103FC RID: 66556 RVA: 0x004BEE0E File Offset: 0x004BD00E
	protected override void OnStart()
	{
		this.Layout = new GenericLayout<VisionIdentifyAttributeItem, AttrListScrollData>(base.GetVerticalLayout(0), new Func<VisionIdentifyAttributeItem>(this.InitItem), null, false, true);
		this.SetActive(true);
		base.GetItem(1).SetUIActive(false);
	}

	// Token: 0x060103FD RID: 66557 RVA: 0x004BEE45 File Offset: 0x004BD045
	[NullableContext(1)]
	private VisionIdentifyAttributeItem InitItem()
	{
		return new VisionIdentifyAttributeItem();
	}

	// Token: 0x060103FE RID: 66558 RVA: 0x004BEE4C File Offset: 0x004BD04C
	[NullableContext(1)]
	public void Update(AttrListScrollData[] data)
	{
		this.Layout.RefreshByData(data, null, false);
	}

	// Token: 0x04009000 RID: 36864
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected GenericLayout<VisionIdentifyAttributeItem, AttrListScrollData> Layout;

	// Token: 0x02007BEB RID: 31723
	private enum ELevelAttribute
	{
		// Token: 0x0402820B RID: 164363
		Layout,
		// Token: 0x0402820C RID: 164364
		Item
	}
}
