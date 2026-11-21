using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020012E6 RID: 4838
public class HandBookQuestPlotOptionTalker : UiPanelBase
{
	// Token: 0x0600BE90 RID: 48784 RVA: 0x0038364E File Offset: 0x0038184E
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText))
		};
	}

	// Token: 0x0600BE91 RID: 48785 RVA: 0x00383671 File Offset: 0x00381871
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
