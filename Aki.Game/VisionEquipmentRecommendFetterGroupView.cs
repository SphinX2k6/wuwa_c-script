using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020024A6 RID: 9382
public class VisionEquipmentRecommendFetterGroupView : UiPanelBase
{
	// Token: 0x06012D53 RID: 77139 RVA: 0x004A62CB File Offset: 0x004A44CB
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUILayoutBase))
		};
	}

	// Token: 0x06012D54 RID: 77140 RVA: 0x004A62EE File Offset: 0x004A44EE
	protected override void OnStart()
	{
		this.ElementLayout = new GenericLayout<FetterGroupIcon, int>(base.GetLayoutBase(0), new Func<FetterGroupIcon>(this.InitElementItem), null, false, true);
	}

	// Token: 0x06012D55 RID: 77141 RVA: 0x004A6311 File Offset: 0x004A4511
	[NullableContext(1)]
	private FetterGroupIcon InitElementItem()
	{
		return new FetterGroupIcon();
	}

	// Token: 0x06012D56 RID: 77142 RVA: 0x004A6318 File Offset: 0x004A4518
	[NullableContext(1)]
	public void Refresh(List<int> data)
	{
		GenericLayout<FetterGroupIcon, int> elementLayout = this.ElementLayout;
		if (elementLayout == null)
		{
			return;
		}
		elementLayout.RefreshByData(data, null, false);
	}

	// Token: 0x04008DD5 RID: 36309
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<FetterGroupIcon, int> ElementLayout;

	// Token: 0x02008A2C RID: 35372
	private enum EComp
	{
		// Token: 0x0402CDD2 RID: 183762
		ElementLayout
	}
}
