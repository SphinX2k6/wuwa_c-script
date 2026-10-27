using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200238D RID: 9101
public class PayShopRoleRoundIconItem : UiPanelBase
{
	// Token: 0x06012323 RID: 74531 RVA: 0x0047AC8B File Offset: 0x00478E8B
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture))
		};
	}

	// Token: 0x06012324 RID: 74532 RVA: 0x0047ACB0 File Offset: 0x00478EB0
	[NullableContext(1)]
	public void SetIconByPath(string path)
	{
		base.SetTextureByPath(path, base.GetTexture(0), null, null);
	}

	// Token: 0x0200892F RID: 35119
	private enum EComponents
	{
		// Token: 0x0402C987 RID: 182663
		TextureIcon
	}
}
