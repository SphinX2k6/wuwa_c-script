using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001EF7 RID: 7927
public class HonamiStoryBozaiTalkPanel : UiPanelBase
{
	// Token: 0x0600F406 RID: 62470 RVA: 0x003ADC04 File Offset: 0x003ABE04
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

	// Token: 0x0600F407 RID: 62471 RVA: 0x003ADC4C File Offset: 0x003ABE4C
	public void SetTalkInfoTextAndPlayAudio(HonamiStoryOutDialog? config)
	{
		if (config == null)
		{
			return;
		}
		double num;
		if (!this.LastTimeMap.TryGetValue((EHonamiStoryOutDialogType)config.Value.Type, out num))
		{
			num = 0.0;
		}
		if (Math.Abs(Time.Instance.ServerTimeStamp / 1000.0 - num) < (double)config.Value.Interval)
		{
			return;
		}
		this.LastTimeMap[(EHonamiStoryOutDialogType)config.Value.Type] = Time.Instance.ServerTimeStamp;
		if (!StringUtils.IsBlank(config.Value.Desc))
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), config.Value.Desc, Array.Empty<object>());
		}
		AudioSystem.Instance.PostEvent(config.Value.AudioEvent);
	}

	// Token: 0x040070F7 RID: 28919
	[Nullable(1)]
	private readonly Dictionary<EHonamiStoryOutDialogType, double> LastTimeMap = new Dictionary<EHonamiStoryOutDialogType, double>();

	// Token: 0x020084F4 RID: 34036
	private enum EBoZaiComponent
	{
		// Token: 0x0402B447 RID: 177223
		TxtBoZaiTalk
	}
}
