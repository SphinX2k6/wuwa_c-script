using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001A36 RID: 6710
[Nullable(new byte[]
{
	0,
	1
})]
public class DangoAbyssGoalItem : GridProxyAbstract<GoalPanelData>
{
	// Token: 0x0600C55D RID: 50525 RVA: 0x002CC840 File Offset: 0x002CAA40
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

	// Token: 0x0600C55E RID: 50526 RVA: 0x002CC8A9 File Offset: 0x002CAAA9
	[NullableContext(1)]
	public override void Refresh(GoalPanelData data, bool isSelected, int gridIndex)
	{
		base.GetText(0).SetText(data.Title, true);
		base.GetText(1).SetText(data.Desc ?? "", true);
	}

	// Token: 0x02007F7F RID: 32639
	private enum EGoalComponent
	{
		// Token: 0x040299ED RID: 170477
		Desc,
		// Token: 0x040299EE RID: 170478
		GoalText
	}
}
