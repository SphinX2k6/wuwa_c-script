using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200203F RID: 8255
public class SurvivorsRogueCardAttributeItem : UiPanelBase
{
	// Token: 0x060146D3 RID: 83667 RVA: 0x005F64C8 File Offset: 0x005F46C8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUITexture))
		};
	}

	// Token: 0x060146D4 RID: 83668 RVA: 0x005F6522 File Offset: 0x005F4722
	public void SetIsUp(bool bUp)
	{
		base.GetItem(0).SetUIActive(!bUp);
		base.GetItem(1).SetUIActive(bUp);
	}

	// Token: 0x060146D5 RID: 83669 RVA: 0x005F6541 File Offset: 0x005F4741
	[NullableContext(2)]
	public void SetTextureIcon(string path)
	{
		if (!string.IsNullOrEmpty(path))
		{
			base.SetTextureShowUntilLoaded(path, base.GetTexture(2), null);
		}
	}
}
