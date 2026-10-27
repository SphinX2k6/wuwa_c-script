using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001EE5 RID: 7909
public class HonamiStoryPollutionLevelUpdateView : UiViewBase
{
	// Token: 0x0600F383 RID: 62339 RVA: 0x003AB3F6 File Offset: 0x003A95F6
	[NullableContext(1)]
	public HonamiStoryPollutionLevelUpdateView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600F384 RID: 62340 RVA: 0x003AB400 File Offset: 0x003A9600
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

	// Token: 0x0600F385 RID: 62341 RVA: 0x003AB46C File Offset: 0x003A966C
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

	// Token: 0x020084DC RID: 34012
	private enum EComponentType
	{
		// Token: 0x0402B3C8 RID: 177096
		PollutionLevelText,
		// Token: 0x0402B3C9 RID: 177097
		MonsterLevelText
	}
}
