using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000A9C RID: 2716
public class WheelTowerSettlementRoundPanel : UiPanelBase
{
	// Token: 0x0600723A RID: 29242 RVA: 0x002325F0 File Offset: 0x002307F0
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

	// Token: 0x0600723B RID: 29243 RVA: 0x00232659 File Offset: 0x00230859
	public void RefreshRoundScore(int roundScore)
	{
		UUIText text = base.GetText(1);
		if (text == null)
		{
			return;
		}
		text.SetText(roundScore.ToString(), true);
	}

	// Token: 0x0600723C RID: 29244 RVA: 0x00232674 File Offset: 0x00230874
	[NullableContext(1)]
	public void RefreshRoundTitle(string title)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), title, Array.Empty<object>());
	}
}
