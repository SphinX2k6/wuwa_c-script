using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001872 RID: 6258
public class PayShopRoleRoundIconItem : UiPanelBase
{
	// Token: 0x0600F7D5 RID: 63445 RVA: 0x00487FDB File Offset: 0x004861DB
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture))
		};
	}

	// Token: 0x0600F7D6 RID: 63446 RVA: 0x00488000 File Offset: 0x00486200
	[NullableContext(1)]
	public void SetIconByPath(string path)
	{
		base.SetTextureByPath(path, base.GetTexture(0), null, null);
	}

	// Token: 0x02007ABA RID: 31418
	private enum EComponents
	{
		// Token: 0x04027CA5 RID: 162981
		TextureIcon
	}
}
