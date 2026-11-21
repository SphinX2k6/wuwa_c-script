using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020005D2 RID: 1490
public class BabelTowerBuffStarItem : UiPanelBase
{
	// Token: 0x0600463C RID: 17980 RVA: 0x00180F24 File Offset: 0x0017F124
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

	// Token: 0x0600463D RID: 17981 RVA: 0x00180F6C File Offset: 0x0017F16C
	[NullableContext(1)]
	public void SetText(string text)
	{
		base.GetText(0).SetText(text, true);
	}

	// Token: 0x02006879 RID: 26745
	private class EComponents
	{
		// Token: 0x04022702 RID: 141058
		public const int StarNumText = 0;
	}
}
