using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001544 RID: 5444
[Nullable(new byte[]
{
	0,
	1
})]
public class ActivityTurntableDailyItem : GridProxyAbstract<ActivityTaskData>
{
	// Token: 0x06009BA2 RID: 39842 RVA: 0x0021B0C8 File Offset: 0x002192C8
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

	// Token: 0x06009BA3 RID: 39843 RVA: 0x0021B134 File Offset: 0x00219334
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

	// Token: 0x02007B7A RID: 31610
	private class EDailyItemComponents
	{
		// Token: 0x04028992 RID: 166290
		public const int SpriteFinished = 0;

		// Token: 0x04028993 RID: 166291
		public const int Name = 1;
	}
}
