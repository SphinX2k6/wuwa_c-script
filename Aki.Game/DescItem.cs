using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001A3D RID: 6717
[NullableContext(1)]
[Nullable(0)]
internal class DescItem : UiPanelBase
{
	// Token: 0x0600C57C RID: 50556 RVA: 0x002CCD5C File Offset: 0x002CAF5C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIText))
		};
	}

	// Token: 0x0600C57D RID: 50557 RVA: 0x002CCDCC File Offset: 0x002CAFCC
	protected override void OnStart()
	{
	}

	// Token: 0x0600C57E RID: 50558 RVA: 0x002CCDCE File Offset: 0x002CAFCE
	public void SetTitle(string title)
	{
		UUIText text = base.GetText(1);
		if (text == null)
		{
			return;
		}
		text.SetText(title, true);
	}

	// Token: 0x0600C57F RID: 50559 RVA: 0x002CCDE3 File Offset: 0x002CAFE3
	public void SetDesc(string desc)
	{
		UUIText text = base.GetText(3);
		if (text == null)
		{
			return;
		}
		text.SetText(desc, true);
	}
}
