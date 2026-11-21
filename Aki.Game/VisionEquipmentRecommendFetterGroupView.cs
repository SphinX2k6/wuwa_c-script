using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200198D RID: 6541
public class VisionEquipmentRecommendFetterGroupView : UiPanelBase
{
	// Token: 0x06010214 RID: 66068 RVA: 0x004B3DC3 File Offset: 0x004B1FC3
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUILayoutBase))
		};
	}

	// Token: 0x06010215 RID: 66069 RVA: 0x004B3DE6 File Offset: 0x004B1FE6
	protected override void OnStart()
	{
		this.ElementLayout = new GenericLayout<FetterGroupIcon, int>(base.GetLayoutBase(0), new Func<FetterGroupIcon>(this.InitElementItem), null, false, true);
	}

	// Token: 0x06010216 RID: 66070 RVA: 0x004B3E09 File Offset: 0x004B2009
	[NullableContext(1)]
	private FetterGroupIcon InitElementItem()
	{
		return new FetterGroupIcon();
	}

	// Token: 0x06010217 RID: 66071 RVA: 0x004B3E10 File Offset: 0x004B2010
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

	// Token: 0x04008F1F RID: 36639
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<FetterGroupIcon, int> ElementLayout;

	// Token: 0x02007BB6 RID: 31670
	private enum EComp
	{
		// Token: 0x040280F2 RID: 164082
		ElementLayout
	}
}
