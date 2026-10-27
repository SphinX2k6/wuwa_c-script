using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001A68 RID: 6760
internal class DangoWorldMainProgressPanel : UiPanelBase
{
	// Token: 0x0600C703 RID: 50947 RVA: 0x002D4948 File Offset: 0x002D2B48
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUITexture))
		};
	}

	// Token: 0x0600C704 RID: 50948 RVA: 0x002D49A4 File Offset: 0x002D2BA4
	[NullableContext(1)]
	public void Refresh(DangoAbyssActivityData data)
	{
		string abyssWorldProgressText = data.GetAbyssWorldProgressText();
		base.GetText(1).SetText(abyssWorldProgressText, true);
		float abyssWorldProgressPercentage = data.GetAbyssWorldProgressPercentage();
		base.GetTexture(2).SetFillAmount(abyssWorldProgressPercentage);
	}
}
