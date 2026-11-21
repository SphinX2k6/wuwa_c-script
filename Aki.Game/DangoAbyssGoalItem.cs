using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000EF5 RID: 3829
[Nullable(new byte[]
{
	0,
	1
})]
public class DangoAbyssGoalItem : GridProxyAbstract<GoalPanelData>
{
	// Token: 0x0600996D RID: 39277 RVA: 0x002D7964 File Offset: 0x002D5B64
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

	// Token: 0x0600996E RID: 39278 RVA: 0x002D79CD File Offset: 0x002D5BCD
	[NullableContext(1)]
	public override void Refresh(GoalPanelData data, bool isSelected, int gridIndex)
	{
		base.GetText(0).SetText(data.Title, true);
		base.GetText(1).SetText(data.Desc ?? "", true);
	}

	// Token: 0x0200710E RID: 28942
	private enum EGoalComponent
	{
		// Token: 0x04024D2A RID: 150826
		Desc,
		// Token: 0x04024D2B RID: 150827
		GoalText
	}
}
