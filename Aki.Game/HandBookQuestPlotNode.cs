using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020012E4 RID: 4836
public class HandBookQuestPlotNode : UiPanelBase
{
	// Token: 0x0600BE8C RID: 48780 RVA: 0x003835D0 File Offset: 0x003817D0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText))
		};
	}

	// Token: 0x0600BE8D RID: 48781 RVA: 0x003835F4 File Offset: 0x003817F4
	[NullableContext(1)]
	public void RefreshByNodeText(string nodeTitle)
	{
		string newText = PublicUtil.Instance.GetConfigTextByKey(nodeTitle).Replace("{q_count}", "0").Replace("{q_countMax}", "-");
		UUIText text = base.GetText(0);
		if (text == null)
		{
			return;
		}
		text.SetText(newText, true);
	}
}
