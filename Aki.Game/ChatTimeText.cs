using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000C61 RID: 3169
public class ChatTimeText : UiPanelBase
{
	// Token: 0x06008464 RID: 33892 RVA: 0x002889AC File Offset: 0x00286BAC
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

	// Token: 0x06008465 RID: 33893 RVA: 0x002889F4 File Offset: 0x00286BF4
	public void Refresh(double timeStamp)
	{
		UUIText text = base.GetText(0);
		string newText = TimeUtil.Instance.DateFormatString(timeStamp);
		text.SetText(newText, true);
	}

	// Token: 0x02006F3F RID: 28479
	private class EChildType
	{
		// Token: 0x040245B3 RID: 148915
		public const int TimeText = 0;
	}
}
