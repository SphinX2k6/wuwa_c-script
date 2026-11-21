using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020009FC RID: 2556
[Nullable(new byte[]
{
	0,
	1
})]
public class ActivityTurntableDailyItem : GridProxyAbstract<ActivityTaskData>
{
	// Token: 0x06006F80 RID: 28544 RVA: 0x00224E78 File Offset: 0x00223078
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06006F81 RID: 28545 RVA: 0x00224EE4 File Offset: 0x002230E4
	[NullableContext(1)]
	public override void Refresh(ActivityTaskData data, bool isSelected, int gridIndex)
	{
		base.GetSprite(0).SetUIActive(data.Status == EActivityTaskState.FinishedAndClaimed);
		TurntableTask? turntableTaskByTaskId = ActivityTurntableConfig.Instance.GetTurntableTaskByTaskId(data.Id);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), turntableTaskByTaskId.Value.TaskDescription, new <>z__ReadOnlyArray<object>(new object[]
		{
			data.Current.ToString(),
			data.Target.ToString()
		}));
	}

	// Token: 0x02006D05 RID: 27909
	private class EDailyItemComponents
	{
		// Token: 0x04023CCD RID: 146637
		public const int SpriteFinished = 0;

		// Token: 0x04023CCE RID: 146638
		public const int Name = 1;
	}
}
