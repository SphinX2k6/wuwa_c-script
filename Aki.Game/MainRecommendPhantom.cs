using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020024B4 RID: 9396
[NullableContext(1)]
[Nullable(0)]
internal class MainRecommendPhantom : UiPanelBase
{
	// Token: 0x06012DBC RID: 77244 RVA: 0x004A818D File Offset: 0x004A638D
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x06012DBD RID: 77245 RVA: 0x004A81C6 File Offset: 0x004A63C6
	protected override void OnStart()
	{
		this.Layout = new GenericLayout<MainPhantomContent, IMainPhantomItemData>(base.GetVerticalLayout(0), new Func<MainPhantomContent>(this.InitItem), null, false, true);
	}

	// Token: 0x06012DBE RID: 77246 RVA: 0x004A81E9 File Offset: 0x004A63E9
	private MainPhantomContent InitItem()
	{
		return new MainPhantomContent();
	}

	// Token: 0x06012DBF RID: 77247 RVA: 0x004A81F0 File Offset: 0x004A63F0
	public void Refresh(List<IMainPhantomItemData> data)
	{
		GenericLayout<MainPhantomContent, IMainPhantomItemData> layout = this.Layout;
		if (layout == null)
		{
			return;
		}
		layout.RefreshByData(data, null, false);
	}

	// Token: 0x04008E0C RID: 36364
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<MainPhantomContent, IMainPhantomItemData> Layout;
}
