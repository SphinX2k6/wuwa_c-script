using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000EF8 RID: 3832
[NullableContext(1)]
[Nullable(0)]
internal class SpriteTextItem : UiPanelBase
{
	// Token: 0x06009981 RID: 39297 RVA: 0x002D7CC0 File Offset: 0x002D5EC0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText))
		};
	}

	// Token: 0x06009982 RID: 39298 RVA: 0x002D7D1A File Offset: 0x002D5F1A
	public void SetTitle(string title)
	{
		UUIText text = base.GetText(1);
		if (text == null)
		{
			return;
		}
		text.SetText(title, true);
	}

	// Token: 0x06009983 RID: 39299 RVA: 0x002D7D2F File Offset: 0x002D5F2F
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
