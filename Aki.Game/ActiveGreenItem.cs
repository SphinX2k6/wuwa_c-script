using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020017E4 RID: 6116
public class ActiveGreenItem : UiPanelBase
{
	// Token: 0x0600B2E2 RID: 45794 RVA: 0x002870E5 File Offset: 0x002852E5
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
	}

	// Token: 0x0600B2E3 RID: 45795 RVA: 0x0028711E File Offset: 0x0028531E
	[NullableContext(1)]
	public void SetText(string text)
	{
		UUIText text2 = base.GetText(1);
		if (text2 == null)
		{
			return;
		}
		text2.SetText(text, true);
	}

	// Token: 0x02007DD0 RID: 32208
	private enum EComponent
	{
		// Token: 0x040292FB RID: 168699
		Sprite,
		// Token: 0x040292FC RID: 168700
		Desc
	}
}
