using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200103D RID: 4157
public class FloroRanchBuffRemindDayItem : UiPanelBase
{
	// Token: 0x0600A587 RID: 42375 RVA: 0x0030B1F0 File Offset: 0x003093F0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 1;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int index = 0;
		*span[index] = new ValueTuple<int, Type>(0, typeof(UUIArtText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600A588 RID: 42376 RVA: 0x0030B238 File Offset: 0x00309438
	[NullableContext(2)]
	public void Refresh(FloroRanchBuffData buffData)
	{
		if (buffData == null)
		{
			base.GetRootItem().SetUIActive(false);
			return;
		}
		base.GetArtText(0).SetText(buffData.RemindDay.ToString());
		base.GetRootItem().SetUIActive(true);
	}

	// Token: 0x02007290 RID: 29328
	private class EComponent
	{
		// Token: 0x040254D8 RID: 152792
		public const int RemindTimeText = 0;
	}
}
