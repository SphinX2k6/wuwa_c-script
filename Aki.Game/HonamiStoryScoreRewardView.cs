using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020013AB RID: 5035
public class HonamiStoryScoreRewardView : UiViewBase
{
	// Token: 0x0600C7BF RID: 51135 RVA: 0x003B79E1 File Offset: 0x003B5BE1
	[NullableContext(1)]
	public HonamiStoryScoreRewardView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600C7C0 RID: 51136 RVA: 0x003B79EC File Offset: 0x003B5BEC
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

	// Token: 0x02007667 RID: 30311
	private enum EHonamiStoryScoreRewardComponent
	{
		// Token: 0x04026710 RID: 157456
		ItemCaption
	}
}
