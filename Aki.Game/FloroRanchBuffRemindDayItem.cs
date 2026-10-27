using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001B7E RID: 7038
public class FloroRanchBuffRemindDayItem : UiPanelBase
{
	// Token: 0x0600D176 RID: 53622 RVA: 0x00300118 File Offset: 0x002FE318
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

	// Token: 0x0600D177 RID: 53623 RVA: 0x00300160 File Offset: 0x002FE360
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

	// Token: 0x02008102 RID: 33026
	private class EComponent
	{
		// Token: 0x0402A1A4 RID: 172452
		public const int RemindTimeText = 0;
	}
}
