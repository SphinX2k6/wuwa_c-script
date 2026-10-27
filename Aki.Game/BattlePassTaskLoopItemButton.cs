using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002334 RID: 9012
internal class BattlePassTaskLoopItemButton : UiPanelBase
{
	// Token: 0x06011D64 RID: 73060 RVA: 0x004651FC File Offset: 0x004633FC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06011D65 RID: 73061 RVA: 0x00465286 File Offset: 0x00463486
	[NullableContext(2)]
	public void RefreshTextByTextId(string textId)
	{
		LguiUtil.Instance.TrySetLocalTextNew(base.GetText(1), textId, Array.Empty<object>());
	}

	// Token: 0x020088B6 RID: 34998
	private enum EButtonComponent
	{
		// Token: 0x0402C6EC RID: 181996
		Button,
		// Token: 0x0402C6ED RID: 181997
		Text,
		// Token: 0x0402C6EE RID: 181998
		RedDotItem
	}
}
