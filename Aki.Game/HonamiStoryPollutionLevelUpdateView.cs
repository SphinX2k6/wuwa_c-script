using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020013A7 RID: 5031
public class HonamiStoryPollutionLevelUpdateView : UiViewBase
{
	// Token: 0x0600C7A2 RID: 51106 RVA: 0x003B6EF2 File Offset: 0x003B50F2
	[NullableContext(1)]
	public HonamiStoryPollutionLevelUpdateView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600C7A3 RID: 51107 RVA: 0x003B6EFC File Offset: 0x003B50FC
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

	// Token: 0x0600C7A4 RID: 51108 RVA: 0x003B6F68 File Offset: 0x003B5168
	protected override void OnStart()
	{
		IHonamiStoryPollutionUpdateParams honamiStoryPollutionUpdateParams = (IHonamiStoryPollutionUpdateParams)this.OpenParam;
		base.GetText(0).SetText(honamiStoryPollutionUpdateParams.PollutionLevel.ToString(), true);
		base.GetText(1).SetText(honamiStoryPollutionUpdateParams.MonsterIncreaseLevel.ToString(), true);
		TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
		{
			base.CloseMe(null);
		}, 3500f, null, null, true, 1f);
	}

	// Token: 0x02007661 RID: 30305
	private enum EComponentType
	{
		// Token: 0x040266EC RID: 157420
		PollutionLevelText,
		// Token: 0x040266ED RID: 157421
		MonsterLevelText
	}
}
