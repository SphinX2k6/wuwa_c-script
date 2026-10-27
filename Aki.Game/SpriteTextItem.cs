using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001A39 RID: 6713
[NullableContext(1)]
[Nullable(0)]
internal class SpriteTextItem : UiPanelBase
{
	// Token: 0x0600C571 RID: 50545 RVA: 0x002CCB9C File Offset: 0x002CAD9C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText))
		};
	}

	// Token: 0x0600C572 RID: 50546 RVA: 0x002CCBF6 File Offset: 0x002CADF6
	public void SetTitle(string title)
	{
		UUIText text = base.GetText(1);
		if (text == null)
		{
			return;
		}
		text.SetText(title, true);
	}

	// Token: 0x0600C573 RID: 50547 RVA: 0x002CCC0B File Offset: 0x002CAE0B
	public void SetDesc(string desc)
	{
		UUIText text = base.GetText(2);
		if (text == null)
		{
			return;
		}
		text.SetText(desc, true);
	}
}
