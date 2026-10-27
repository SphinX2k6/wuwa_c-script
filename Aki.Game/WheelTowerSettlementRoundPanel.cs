using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020015E4 RID: 5604
public class WheelTowerSettlementRoundPanel : UiPanelBase
{
	// Token: 0x06009E5C RID: 40540 RVA: 0x0022883C File Offset: 0x00226A3C
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

	// Token: 0x06009E5D RID: 40541 RVA: 0x002288A5 File Offset: 0x00226AA5
	public void RefreshRoundScore(int roundScore)
	{
		UUIText text = base.GetText(1);
		if (text == null)
		{
			return;
		}
		text.SetText(roundScore.ToString(), true);
	}

	// Token: 0x06009E5E RID: 40542 RVA: 0x002288C0 File Offset: 0x00226AC0
	[NullableContext(1)]
	public void RefreshRoundTitle(string title)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), title, Array.Empty<object>());
	}
}
