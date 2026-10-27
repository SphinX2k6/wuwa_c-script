using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001EE9 RID: 7913
public class HonamiStoryScoreRewardView : UiViewBase
{
	// Token: 0x0600F3A0 RID: 62368 RVA: 0x003ABEE5 File Offset: 0x003AA0E5
	[NullableContext(1)]
	public HonamiStoryScoreRewardView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600F3A1 RID: 62369 RVA: 0x003ABEF0 File Offset: 0x003AA0F0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 1;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int index = 0;
		*span[index] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x020084E2 RID: 34018
	private enum EHonamiStoryScoreRewardComponent
	{
		// Token: 0x0402B3EC RID: 177132
		ItemCaption
	}
}
