using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001819 RID: 6169
internal class BattlePassTaskLoopItemButton : UiPanelBase
{
	// Token: 0x0600F214 RID: 61972 RVA: 0x004722C4 File Offset: 0x004704C4
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

	// Token: 0x0600F215 RID: 61973 RVA: 0x0047234E File Offset: 0x0047054E
	[NullableContext(2)]
	public void RefreshTextByTextId(string textId)
	{
		LguiUtil.Instance.TrySetLocalTextNew(base.GetText(1), textId, Array.Empty<object>());
	}

	// Token: 0x02007A3F RID: 31295
	private enum EButtonComponent
	{
		// Token: 0x04027A00 RID: 162304
		Button,
		// Token: 0x04027A01 RID: 162305
		Text,
		// Token: 0x04027A02 RID: 162306
		RedDotItem
	}
}
