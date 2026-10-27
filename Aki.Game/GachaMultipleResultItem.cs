using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001C9B RID: 7323
public class GachaMultipleResultItem : UiPanelBase
{
	// Token: 0x0600DD02 RID: 56578 RVA: 0x0033913B File Offset: 0x0033733B
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIGridLayout))
		};
	}

	// Token: 0x0600DD03 RID: 56579 RVA: 0x0033915E File Offset: 0x0033735E
	[NullableContext(2)]
	public UUIGridLayout GetGachaResultItemLayout()
	{
		return base.GetGridLayout(0);
	}

	// Token: 0x02008274 RID: 33396
	private enum EComponent
	{
		// Token: 0x0402A8FB RID: 174331
		GachaResultGridLayout
	}
}
