using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001A65 RID: 6757
internal class ProgressPanel : UiPanelBase
{
	// Token: 0x0600C6EC RID: 50924 RVA: 0x002D4440 File Offset: 0x002D2640
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUISprite))
		};
	}

	// Token: 0x0600C6ED RID: 50925 RVA: 0x002D449C File Offset: 0x002D269C
	[NullableContext(1)]
	public void Refresh(DangoAbyssActivityData data)
	{
		string abyssWorldProgressText = data.GetAbyssWorldProgressText();
		base.GetText(1).SetText(abyssWorldProgressText, true);
		float abyssWorldProgressPercentage = data.GetAbyssWorldProgressPercentage();
		base.GetSprite(2).SetFillAmount(abyssWorldProgressPercentage);
	}
}
