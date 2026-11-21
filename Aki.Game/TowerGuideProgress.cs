using System;
using System.Collections.Generic;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020009DC RID: 2524
internal class TowerGuideProgress : UiPanelBase
{
	// Token: 0x06006E42 RID: 28226 RVA: 0x00220AAE File Offset: 0x0021ECAE
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
	}

	// Token: 0x06006E43 RID: 28227 RVA: 0x00220AE7 File Offset: 0x0021ECE7
	public void Refresh(int currentProgress, int totalProgress)
	{
		base.GetText(0).SetText(currentProgress.ToString(), true);
		base.GetText(1).SetText("/" + totalProgress.ToString(), true);
	}
}
