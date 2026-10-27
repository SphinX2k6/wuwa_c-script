using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001E24 RID: 7716
public class HandBookQuestPlotOptionTalker : UiPanelBase
{
	// Token: 0x0600EA71 RID: 60017 RVA: 0x00377946 File Offset: 0x00375B46
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText))
		};
	}

	// Token: 0x0600EA72 RID: 60018 RVA: 0x00377969 File Offset: 0x00375B69
	[NullableContext(1)]
	public void RefreshByText(string title)
	{
		UUIText text = base.GetText(0);
		if (text == null)
		{
			return;
		}
		text.SetText(title, true);
	}
}
