using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000C9D RID: 3229
public class ActiveGreenItem : UiPanelBase
{
	// Token: 0x060086CC RID: 34508 RVA: 0x002917B9 File Offset: 0x0028F9B9
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
	}

	// Token: 0x060086CD RID: 34509 RVA: 0x002917F2 File Offset: 0x0028F9F2
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

	// Token: 0x02006F56 RID: 28502
	private enum EComponent
	{
		// Token: 0x04024626 RID: 149030
		Sprite,
		// Token: 0x04024627 RID: 149031
		Desc
	}
}
