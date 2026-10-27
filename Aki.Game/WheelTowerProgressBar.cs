using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001651 RID: 5713
internal sealed class WheelTowerProgressBar : UiPanelBase
{
	// Token: 0x0600A06D RID: 41069 RVA: 0x00235778 File Offset: 0x00233978
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600A06E RID: 41070 RVA: 0x002357E1 File Offset: 0x002339E1
	public void Refresh(int currentProgress)
	{
		UUIText text = base.GetText(1);
		if (text == null)
		{
			return;
		}
		text.SetText(currentProgress.ToString(), true);
	}
}
