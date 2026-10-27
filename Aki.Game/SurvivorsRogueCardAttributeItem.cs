using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002AC3 RID: 10947
public class SurvivorsRogueCardAttributeItem : UiPanelBase
{
	// Token: 0x06016CA2 RID: 93346 RVA: 0x005C9974 File Offset: 0x005C7B74
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUITexture))
		};
	}

	// Token: 0x06016CA3 RID: 93347 RVA: 0x005C99CE File Offset: 0x005C7BCE
	public void SetIsUp(bool bUp)
	{
		base.GetItem(0).SetUIActive(!bUp);
		base.GetItem(1).SetUIActive(bUp);
	}

	// Token: 0x06016CA4 RID: 93348 RVA: 0x005C99ED File Offset: 0x005C7BED
	[NullableContext(2)]
	public void SetTextureIcon(string path)
	{
		if (!string.IsNullOrEmpty(path))
		{
			base.SetTextureShowUntilLoaded(path, base.GetTexture(2), null);
		}
	}
}
