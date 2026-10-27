using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020017A8 RID: 6056
public class ChatTimeText : UiPanelBase
{
	// Token: 0x0600B07C RID: 45180 RVA: 0x0027E414 File Offset: 0x0027C614
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

	// Token: 0x0600B07D RID: 45181 RVA: 0x0027E45C File Offset: 0x0027C65C
	public void Refresh(double timeStamp)
	{
		UUIText text = base.GetText(0);
		string newText = TimeUtil.Instance.DateFormatString(timeStamp);
		text.SetText(newText, true);
	}

	// Token: 0x02007DB9 RID: 32185
	private class EChildType
	{
		// Token: 0x04029288 RID: 168584
		public const int TimeText = 0;
	}
}
