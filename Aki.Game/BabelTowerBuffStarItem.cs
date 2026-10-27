using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200111E RID: 4382
public class BabelTowerBuffStarItem : UiPanelBase
{
	// Token: 0x060072A6 RID: 29350 RVA: 0x00178568 File Offset: 0x00176768
	protected unsafe override void OnRegisterComponent()
	{
		int num = 1;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int index = 0;
		*span[index] = new ValueTuple<int, Type>(0, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x060072A7 RID: 29351 RVA: 0x001785B0 File Offset: 0x001767B0
	[NullableContext(1)]
	public void SetText(string text)
	{
		base.GetText(0).SetText(text, true);
	}

	// Token: 0x020076E5 RID: 30437
	private class EComponents
	{
		// Token: 0x040273B9 RID: 160697
		public const int StarNumText = 0;
	}
}
