using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000EFC RID: 3836
[NullableContext(1)]
[Nullable(0)]
internal class DescItem : UiPanelBase
{
	// Token: 0x0600998C RID: 39308 RVA: 0x002D7E80 File Offset: 0x002D6080
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

	// Token: 0x0600998D RID: 39309 RVA: 0x002D7EF0 File Offset: 0x002D60F0
	protected override void OnStart()
	{
	}

	// Token: 0x0600998E RID: 39310 RVA: 0x002D7EF2 File Offset: 0x002D60F2
	public void SetTitle(string title)
	{
		UUIText text = base.GetText(1);
		if (text == null)
		{
			return;
		}
		text.SetText(title, true);
	}

	// Token: 0x0600998F RID: 39311 RVA: 0x002D7F07 File Offset: 0x002D6107
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
