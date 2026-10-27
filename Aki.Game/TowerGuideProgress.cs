using System;
using System.Collections.Generic;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001524 RID: 5412
internal class TowerGuideProgress : UiPanelBase
{
	// Token: 0x06009A64 RID: 39524 RVA: 0x00216D12 File Offset: 0x00214F12
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
	}

	// Token: 0x06009A65 RID: 39525 RVA: 0x00216D4B File Offset: 0x00214F4B
	public void Refresh(int currentProgress, int totalProgress)
	{
		base.GetText(0).SetText(currentProgress.ToString(), true);
		base.GetText(1).SetText("/" + totalProgress.ToString(), true);
	}
}
