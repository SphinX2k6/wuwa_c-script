using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200115A RID: 4442
public class GachaMultipleResultItem : UiPanelBase
{
	// Token: 0x0600B118 RID: 45336 RVA: 0x00344683 File Offset: 0x00342883
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIGridLayout))
		};
	}

	// Token: 0x0600B119 RID: 45337 RVA: 0x003446A6 File Offset: 0x003428A6
	[NullableContext(2)]
	public UUIGridLayout GetGachaResultItemLayout()
	{
		return base.GetGridLayout(0);
	}

	// Token: 0x020073FB RID: 29691
	private enum EComponent
	{
		// Token: 0x04025C1A RID: 154650
		GachaResultGridLayout
	}
}
