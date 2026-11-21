using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200199B RID: 6555
[NullableContext(1)]
[Nullable(0)]
internal class MainRecommendPhantom : UiPanelBase
{
	// Token: 0x0601027C RID: 66172 RVA: 0x004B5D41 File Offset: 0x004B3F41
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x0601027D RID: 66173 RVA: 0x004B5D7A File Offset: 0x004B3F7A
	protected override void OnStart()
	{
		this.Layout = new GenericLayout<MainPhantomContent, IMainPhantomItemData>(base.GetVerticalLayout(0), new Func<MainPhantomContent>(this.InitItem), null, false, true);
	}

	// Token: 0x0601027E RID: 66174 RVA: 0x004B5D9D File Offset: 0x004B3F9D
	private MainPhantomContent InitItem()
	{
		return new MainPhantomContent();
	}

	// Token: 0x0601027F RID: 66175 RVA: 0x004B5DA4 File Offset: 0x004B3FA4
	public void Refresh(List<IMainPhantomItemData> data)
	{
		GenericLayout<MainPhantomContent, IMainPhantomItemData> layout = this.Layout;
		if (layout == null)
		{
			return;
		}
		layout.RefreshByData(data, null, false);
	}

	// Token: 0x04008F56 RID: 36694
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<MainPhantomContent, IMainPhantomItemData> Layout;
}
