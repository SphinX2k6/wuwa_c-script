using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001E22 RID: 7714
public class HandBookQuestPlotNode : UiPanelBase
{
	// Token: 0x0600EA6D RID: 60013 RVA: 0x003778C8 File Offset: 0x00375AC8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText))
		};
	}

	// Token: 0x0600EA6E RID: 60014 RVA: 0x003778EC File Offset: 0x00375AEC
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
