using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000F24 RID: 3876
internal class ProgressPanel : UiPanelBase
{
	// Token: 0x06009AFC RID: 39676 RVA: 0x002DF538 File Offset: 0x002DD738
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUISprite))
		};
	}

	// Token: 0x06009AFD RID: 39677 RVA: 0x002DF594 File Offset: 0x002DD794
	[NullableContext(1)]
	public void Refresh(DangoAbyssActivityData data)
	{
		string abyssWorldProgressText = data.GetAbyssWorldProgressText();
		base.GetText(1).SetText(abyssWorldProgressText, true);
		float abyssWorldProgressPercentage = data.GetAbyssWorldProgressPercentage();
		base.GetSprite(2).SetFillAmount(abyssWorldProgressPercentage);
	}
}
